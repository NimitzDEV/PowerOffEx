Imports System.Drawing.Drawing2D
Module mdUIElements
    '居中style
    Dim sfCenter As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
    '左对齐
    Dim sfNear As New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center}
    '右对齐
    Dim sfFar As New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Near}
    'SYSINFO
    Public ticker_SL As Integer = 0
    Public smallTitle As String = ""
    Public linkStatusString As String
    Public linkStatusImage As Image
    Public batteryStatusString As String
    Public batteryStatusImage As Image
    Public currentProgress As Integer
    Public showStringMiddle As String
    Public showStringDown As String
    Public showNowStatus As String
    Public bgImage As Image
    Dim dtBG, nowBG As Integer
    '===
    Dim g As Graphics
    Public Function DrawProgressBar(ByVal changingAngle As Integer, _
                                    ByVal endColor As Color, ByVal startColor As Color) As Bitmap
        Dim bmp As New Bitmap(bgImage, frmInterface.pbStatus.ClientRectangle.Width, frmInterface.pbStatus.ClientRectangle.Height)
        Dim path As New GraphicsPath
        Dim rec As Rectangle = New Rectangle(25, bmp.Height - (bmp.Width - 22.5) - 15, bmp.Width - 50, bmp.Width - 50)
        g = Graphics.FromImage(bmp)
        '状态标语
        g.DrawString(showNowStatus, New Font("Segoe UI", 30, FontStyle.Regular), Brushes.White, New Point(20, 50), sfNear)
        g.DrawString(Hour(Now) & "时", New Font("Segoe UI", 17, FontStyle.Regular), Brushes.White, New Point(bmp.Width - 20, 20), sfFar)
        g.DrawString(Minute(Now) & "分", New Font("Segoe UI", 17, FontStyle.Regular), Brushes.White, New Point(bmp.Width - 20, 45), sfFar)
        '网络连接状态
        g.DrawImage(linkStatusImage, 10, bmp.Height - 30, 20, 20)
        g.DrawString(linkStatusString, New Font("Segoe UI", 8, FontStyle.Regular), Brushes.White, New Point(55, bmp.Height - 20), sfCenter)
        '电池状态
        g.DrawImage(batteryStatusImage, 90, bmp.Height - 35, 30, 30)
        g.DrawString(batteryStatusString, New Font("Segoe UI", 8, FontStyle.Regular), Brushes.White, New Point(120, bmp.Height - 20), sfNear)
        '时间状态
        g.DrawString(showStringMiddle, New Font("Segoe UI", 32, FontStyle.Bold), Brushes.White, New Point(bmp.Width / 2, bmp.Height / 2 + 30), sfCenter)
        g.DrawString(showStringDown, New Font("Segoe UI", 20, FontStyle.Bold), Brushes.White, New Point(bmp.Width / 2, bmp.Height - 55), sfCenter)
        g.DrawString(smallTitle, New Font("Segoe UI", 16, FontStyle.Regular), Brushes.White, New Point(bmp.Width / 2, bmp.Height / 2 - 15), sfCenter)
        'g.DrawEllipse(Pens.White, rec)
        path.AddPie(rec, 110, currentProgress * 3.2)
        Dim holeRect As Rectangle = New Rectangle(rec.X + 15, rec.Y + 15, rec.Width - 30, rec.Height - 30)
        'g.DrawEllipse(Pens.White, holeRect)
        g.Clip = (New Region(path))
        path.AddPie(holeRect, 110, currentProgress * 3.2)
        Dim gradiant As New LinearGradientBrush(rec, endColor, startColor, changingAngle)
        g.FillPath(gradiant, path)
        frmInterface.Invalidate(rec)
        Return bmp
    End Function

    Public Function roundedCorner(ByVal rForm As Form, ByVal cAngle As Integer) As System.Drawing.Region
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, cAngle, cAngle), 180, 90)
        p.AddLine(cAngle, 0, rForm.Width - cAngle, 0)
        p.AddArc(New Rectangle(rForm.Width - cAngle, 0, cAngle, cAngle), -90, 90)
        p.AddLine(rForm.Width, cAngle, rForm.Width, rForm.Height - cAngle)
        p.AddArc(New Rectangle(rForm.Width - cAngle, rForm.Height - cAngle, cAngle, cAngle), 0, 90)
        p.AddLine(rForm.Width - cAngle, rForm.Height, cAngle, rForm.Height)
        p.AddArc(New Rectangle(0, rForm.Height - cAngle, cAngle, cAngle), 90, 90)
        p.CloseFigure()
        Return New System.Drawing.Region(p)
    End Function

    Public Sub selectBG(Optional nh As Integer = 0)
        nh = Hour(Now)
        If nh < 7 Then dtBG = 1
        If nh > 6 And nh < 12 Then dtBG = 2
        If nh > 11 And nh < 14 Then dtBG = 3
        If nh > 13 And nh < 19 Then dtBG = 4
        If nh > 18 Then dtBG = 5
        If dtBG = nowBG Then Exit Sub
        nowBG = dtBG
        Select Case nowBG
            Case 1
                bgImage = My.Resources.bg_midnight_01
                showNowStatus = "凌晨"
            Case 2
                bgImage = My.Resources.bg_morning_01
                showNowStatus = "早上"
            Case 3
                bgImage = My.Resources.bg_noon_01
                showNowStatus = "中午"
            Case 4
                bgImage = My.Resources.bg_afternoon_01
                showNowStatus = "下午"
            Case 5
                bgImage = My.Resources.bg_evening_01
                showNowStatus = "晚上"
        End Select
    End Sub
End Module
