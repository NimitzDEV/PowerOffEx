Imports System.Drawing.Drawing2D
Module mdUIElements
    Public Function DrawProgressBar(ByVal bgImage As Image, ByVal CurrentAngle As Integer, ByVal changingAngle As Integer, ByVal drawObject As PictureBox, ByVal container As Form, ByVal endColor As Color, ByVal startColor As Color) As Bitmap
        Dim bmp As New Bitmap(bgImage, drawObject.ClientRectangle.Width, drawObject.ClientRectangle.Height)
        Dim g As Graphics
        CurrentAngle *= 3.2
        g = Graphics.FromImage(bmp)
        Dim path As New GraphicsPath
        Dim rec As Rectangle = New Rectangle((bmp.Width - bmp.Height + 60) / 2, (bmp.Height - bmp.Height + 20) / 2 + 20, bmp.Height - 60, bmp.Height - 60)
        Dim stringformat As New StringFormat
        stringformat.Alignment = StringAlignment.Center
        stringformat.LineAlignment = StringAlignment.Center
        g.DrawEllipse(Pens.White, rec)
        path.AddPie(rec, 110, CurrentAngle)
        Dim holeRect As Rectangle = New Rectangle(rec.X + 15, rec.Y + 15, rec.Width - 30, rec.Height - 30)
        g.DrawEllipse(Pens.White, holeRect)
        g.Clip = (New Region(path))
        path.AddPie(holeRect, 110, CurrentAngle)
        Dim gradiant As New LinearGradientBrush(rec, endColor, startColor, changingAngle)
        g.FillPath(gradiant, path)
        container.Invalidate(rec)
        Return bmp
    End Function

End Module
