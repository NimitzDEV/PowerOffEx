Module mdProgram
    '绘制阴影
    Public Const CS_DROPSHADOW = &H20000
    Public Const GCL_STYLE = (-26)
    Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    '--------电源信息相关
    Public ps As PowerStatus = SystemInformation.PowerStatus
    Public batteryStatus As String = ps.BatteryChargeStatus.ToString
    Public batteryPercent As Integer
    Public batteryLife As Integer
    Public batteryChargeStatus As Integer
    '/////电源标志说明
    '--------Offline=0未充电，Online=1充电，Unknow=255未知状态，对于台式机=1
    '----------网络信息相关
    Public networkStatus As Boolean
    '---------全局设置
    Public valSetTime As Long
    Public valBatteryLifeLB As Integer
    '---------时间转换
    Dim secs As Long
    Dim mins2 As Integer
    Dim hours As Integer
    Dim buildStr As String
    Dim totalTime As Long
    '----------------执行电源操作
    Private Declare Function ExitWindowsEx Lib "user32" (ByVal uFlags As Integer, ByVal dwReserved As Integer) As Integer
    Public Const EWX_FORCE As Short = 4 '强制执行标志，暂不使用
    Public Const EWX_LOGOFF As Short = 0 '注销标志
    Public Const EWX_REBOOT As Short = 2 '重启标志
    Public Const EWX_SHUTDOWN As Short = 1 '关机标志
    Public Function pwmComputer(ByVal actionVal As Short) As Integer
        Return ExitWindowsEx(actionVal, 0)
    End Function
    Public Sub drawWindowShadowStep1(ByVal formObj As Form)
        SetClassLong(formObj.Handle, GCL_STYLE, GetClassLong(formObj.Handle, GCL_STYLE) Or CS_DROPSHADOW)
    End Sub
    Public Sub drawWindowShadowStep2(ByVal formObj As Form, ByVal e As System.Windows.Forms.PaintEventArgs, ByVal colorA As Color, ByVal colorB As Color)
        '界面绘制相关 - 绘制背景渐变效果
        Dim frmRect As New Rectangle(0, 0, formObj.Width, formObj.Height)
        Dim backgroundClrSet As New Drawing2D.LinearGradientBrush(frmRect, colorA, colorB, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.FillRectangle(backgroundClrSet, frmRect)
    End Sub
    Public Function checkIsLaptop() As Boolean
        Try
            If batteryChargeStatus = 255 Then Return False
            If batteryStatus = "NoSystemBattery" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub updateBatteryInfo()
        batteryStatus = ps.BatteryChargeStatus.ToString
        batteryPercent = ps.BatteryLifePercent * 100
        batteryLife = ps.BatteryLifeRemaining
        batteryChargeStatus = ps.PowerLineStatus
    End Sub
    Public Function converTime(ByVal inputSecs As Long) As String
        buildStr = ""
        totalTime = inputSecs
        secs = inputSecs Mod 60
        mins2 = (inputSecs - (inputSecs Mod 60)) / 60
        hours = (mins2 - (mins2 Mod 60)) / 60
        mins2 = mins2 - hours * 60
        If hours <> 0 Then buildStr &= hours & "时"
        If mins2 <> 0 Then buildStr &= mins2 & "分"
        If secs <> 0 Then buildStr &= secs & "秒"
        Return buildStr
    End Function
    Public Sub batteryStatusMode()
        With frmInterface
            '////  检测防止中途进入充电状态
            If batteryChargeStatus = 1 Then
                frmMain.Show()
                .Close()
                MsgBox("已经接通电源，本模式将不再适用")
            End If
            '//// 检测电池电量
            If batteryPercent = valBatteryLifeLB Then
                '//// TODO: SHOW NOTIFY UI
            End If
            If batteryPercent < valBatteryLifeLB Then
                .mainTick.Enabled = False
                pwmComputer(EWX_SHUTDOWN)
                exitProgram(0)
            End If
        End With
    End Sub
    Public Sub reconstractUi()
        With frmInterface
            '////  检查是否为台式机
            If batteryStatus = "NoSystemBattery" Then
                .pnlBattery.Visible = False
                .pnlNetworkConnection.Left = (.Width - .pnlNetworkConnection.Width) / 2
            End If
        End With
    End Sub
    Public Sub exitProgram(ByVal askFirst As Integer)
        If askFirst = 1 Then
            If MsgBox("确定要退出吗？", vbOKCancel) <> vbOK Then Exit Sub
        End If
        frmInterface.Close()
        frmMain.Close()
    End Sub
    Public Sub ReadSettings()
        With frmMain
            .cbRecordTvProgress.Checked = My.Settings.isCheckAutoRecord
            .nudHour.Value = My.Settings.saveHours
            .nudMinute.Value = My.Settings.saveMinutes
        End With
    End Sub
    Public Sub SaveSettings()
        With frmMain
            My.Settings.isCheckAutoRecord = .cbRecordTvProgress.Checked
            My.Settings.saveHours = .nudHour.Value
            My.Settings.saveMinutes = .nudMinute.Value
            My.Settings.Save()
        End With
    End Sub
End Module
