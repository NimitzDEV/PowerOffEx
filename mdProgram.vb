Imports System.Management
Imports System.Runtime.InteropServices
Module mdProgram
    Public globalNotifyInfo As String
    '绘制阴影
    Public Const CS_DROPSHADOW = &H20000
    Public Const GCL_STYLE = (-26)
    Public Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Public Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    '--------电源信息相关
    Public ps As PowerStatus = SystemInformation.PowerStatus
    Public batteryStatus As Integer = ps.BatteryChargeStatus
    '///数值 Charging=8  Critical=4 High=1 Low=2 NoSystemBattery=128 Unknow=255
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
    'XP音量控制用
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Public Sub drawWindowStep1(ByVal formObj As Form)
        SetClassLong(formObj.Handle, GCL_STYLE, GetClassLong(formObj.Handle, GCL_STYLE) Or CS_DROPSHADOW)
    End Sub
    Public Sub drawWindowStep2(ByVal formObj As Form, ByVal e As System.Windows.Forms.PaintEventArgs, ByVal colorA As Color, ByVal colorB As Color)
        '界面绘制相关 - 绘制背景渐变效果
        Dim frmRect As New Rectangle(0, 0, formObj.Width, formObj.Height)
        Dim backgroundClrSet As New Drawing2D.LinearGradientBrush(frmRect, colorA, colorB, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.FillRectangle(backgroundClrSet, frmRect)
    End Sub
    Public Function checkIsLaptop() As Boolean
        Try
            If batteryChargeStatus = 255 Then Return False
            If batteryStatus = 255 Or batteryStatus = 128 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub updateBatteryInfo()
        batteryStatus = ps.BatteryChargeStatus
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
        'If hours <> 0 Then buildStr &= hours & "时"
        'If mins2 <> 0 Then buildStr &= mins2 & "分"
        'If secs <> 0 Then buildStr &= secs & "秒"
        buildStr &= hours & "时"
        buildStr &= mins2 & "分"
        buildStr &= secs & "秒"
        Return buildStr
    End Function
    Public Sub batteryStatusMode()
        With frmInterface
            '////  检测防止中途进入充电状态
            If batteryChargeStatus = 1 Then
                frmMain.Show()
                .Close()
                frmMain.Show()
                MsgBox("已经接通电源，本模式将不再适用")
            End If
        End With
    End Sub
    'Public Sub reconstractUi()
    '    With frmInterface
    '        '////  检查是否为台式机
    '        If batteryStatus = 128 Then
    '            .pnlBattery.Visible = False
    '            .pnlNetworkConnection.Left = (.Width - .pnlNetworkConnection.Width) / 2
    '        End If
    '    End With
    'End Sub
    Public Sub exitProgram(ByVal askFirst As Integer)
        If askFirst = 1 Then
            If MsgBox("确定要退出吗？", vbOKCancel) <> vbOK Then Exit Sub
        End If
        SaveSettings()
        frmInterface.Close()
        frmMain.Close()
    End Sub

    Public Sub shutdownWindows()
        Dim mboShutdown As ManagementBaseObject = Nothing
        Dim mcWin32 As ManagementClass = New ManagementClass("Win32_OperatingSystem")

        mcWin32.Scope.Options.EnablePrivileges = True
        Dim mboShutdownParams As ManagementBaseObject = mcWin32.GetMethodParameters("Win32Shutdown")
        mboShutdownParams("Flags") = "1"
        mboShutdownParams("Reserved") = "0"
        For Each manObj As ManagementObject In mcWin32.GetInstances()
            mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, Nothing)
        Next
    End Sub
    Public Sub changeVolume4XP(ByVal changePercent As Integer)
        If changePercent = 0 Then Exit Sub
        Math.Round(changePercent)
        For i = 0 To changePercent - 1
            SendMessage(frmMain.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        Next
    End Sub
End Module
