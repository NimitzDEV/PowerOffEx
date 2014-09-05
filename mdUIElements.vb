Imports System.Drawing.Drawing2D
Module mdUIElements
    '居中style
    Dim stringformat As New StringFormat
    '常规
    Dim stringFormat2 As New StringFormat
        
    Public Function DrawProgressBar(ByVal bgImage As Image, ByVal CurrentAngle As Integer, _
                                    ByVal changingAngle As Integer, ByVal drawObject As PictureBox, _
                                    ByVal endColor As Color, ByVal startColor As Color, _
                                    ByVal linkStatusString As String, ByVal linkStatusImage As Image, _
                                    ByVal batteryStatusString As String, ByVal batteryStatusImage As Image, _
                                    ByVal showStringMiddle As String, ByVal showStringDown As String) As Bitmap
        Dim bmp As New Bitmap(bgImage, drawObject.ClientRectangle.Width, drawObject.ClientRectangle.Height)
        Dim g As Graphics
        stringformat.Alignment = StringAlignment.Center
        stringformat.LineAlignment = StringAlignment.Center
        stringFormat2.Alignment = StringAlignment.Near
        stringFormat2.LineAlignment = StringAlignment.Center
        '100分制转换
        CurrentAngle *= 3.2
        Dim path As New GraphicsPath
        Dim rec As Rectangle = New Rectangle((bmp.Width - bmp.Height + 60) / 2, (bmp.Height - bmp.Height + 20) / 2 + 10, bmp.Height - 60, bmp.Height - 60)
        g = Graphics.FromImage(bmp)
        '网络连接状态
        g.DrawImage(linkStatusImage, 10, bmp.Height - 30, 20, 20)
        g.DrawString(linkStatusString, New Font("Segoe UI", 8, FontStyle.Regular), Brushes.White, New Point(60, bmp.Height - 15), stringformat)
        '电池状态
        g.DrawImage(batteryStatusImage, 100, bmp.Height - 30, 30, 30)
        g.DrawString(batteryStatusString, New Font("Segoe UI", 8, FontStyle.Regular), Brushes.White, New Point(140, bmp.Height - 15), stringFormat2)
        '时间状态
        g.DrawString(showStringMiddle, New Font("Segoe UI", 32, FontStyle.Bold), Brushes.White, New Point(bmp.Width / 2, bmp.Height / 2), stringformat)
        g.DrawString(showStringDown, New Font("Segoe UI", 20, FontStyle.Bold), Brushes.White, New Point(bmp.Width / 2, bmp.Height - 55), stringformat)
        g.DrawString("剩余", New Font("Segoe UI", 16, FontStyle.Regular), Brushes.White, New Point(bmp.Width / 2, bmp.Height / 2 - 60), stringformat)
        'g.DrawEllipse(Pens.White, rec)
        path.AddPie(rec, 110, CurrentAngle)
        Dim holeRect As Rectangle = New Rectangle(rec.X + 15, rec.Y + 15, rec.Width - 30, rec.Height - 30)
        'g.DrawEllipse(Pens.White, holeRect)
        g.Clip = (New Region(path))
        path.AddPie(holeRect, 110, CurrentAngle)
        Dim gradiant As New LinearGradientBrush(rec, endColor, startColor, changingAngle)
        g.FillPath(gradiant, path)
        frmInterface.Invalidate(rec)
        Return bmp
    End Function

End Module
