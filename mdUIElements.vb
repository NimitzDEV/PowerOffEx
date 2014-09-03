﻿Imports System.Drawing.Drawing2D
Module mdUIElements
    Private Function DrawProgressBar(ByVal CurrentAngle As Integer, ByVal changingAngle As Integer, ByVal drawObject As PictureBox, ByVal container As Form, ByVal endColor As Color, ByVal startColor As Color) As Bitmap
        Dim bmp As New Bitmap(drawObject.ClientRectangle.Width, drawObject.ClientRectangle.Height)
        Dim g As Graphics
        g = Graphics.FromImage(bmp)
        Dim percent As Double
        percent = Math.Round(CurrentAngle * 100 / 360, 1)
        Dim path As New GraphicsPath
        Dim rec As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim stringformat As New StringFormat
        stringformat.Alignment = StringAlignment.Center
        stringformat.LineAlignment = StringAlignment.Center
        g.DrawEllipse(Pens.White, rec)
        path.AddPie(rec, 180, CurrentAngle)
        Dim holeRect As Rectangle = New Rectangle(rec.X + 15, rec.Y + 15, rec.Width - 30, rec.Height - 30)
        g.DrawEllipse(Pens.White, holeRect)
        g.Clip = (New Region(path))
        path.AddPie(holeRect, 180, CurrentAngle)
        Dim gradiant As New LinearGradientBrush(rec, endColor, startColor, changingAngle)
        g.FillPath(gradiant, path)
        frmMain.Invalidate(rec)
        Return bmp
    End Function
End Module
