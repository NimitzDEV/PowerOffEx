Imports CoreAudioApi

Public Class frmInterface
    Dim currentData As Integer
    Dim batteryAnimateStep As Integer
    Dim targetTime As Integer
    Dim fullTime As Integer
    Dim fullPercent As Integer
    Private device As MMDevice
    Dim origiHeight As Integer
    Dim origiWidth As Integer
    Dim changingAngle As Integer
    Dim speedIndex As Integer

    Private Sub fullUI(ByVal isEnable As Boolean)
        tmrChargeAnimate.Enabled = isEnable
        tmrUIFresh.Enabled = isEnable
        tmrProgressDrawer.Enabled = isEnable
    End Sub
    Private Sub freshUI()
        If batteryChargeStatus = 0 Then
            If batteryPercent > 80 Then
                batteryStatusImage = My.Resources.fullbattery
            ElseIf batteryPercent > 35 And batteryPercent < 80 Then
                batteryStatusImage = My.Resources.halfbattery
            Else
                batteryStatusImage = My.Resources.lowbattery
            End If
        End If
        networkStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable
        If networkStatus = True Then
            linkStatusString = " 网络连接"
            linkStatusImage = My.Resources.internet_connected
        Else
            linkStatusString = " 网络断开"
            linkStatusImage = My.Resources.internet_disconnected
        End If
        selectBG()
    End Sub
    Private Sub frmInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateBatteryInfo()
        drawStatus()
        Me.Width = pbStatus.Width
        Me.Height = pbStatus.Height
        origiHeight = Me.Height
        origiWidth = Me.Width
        pbStatus.Left = 0
        pbStatus.Top = 0
        Me.Region = roundedCorner(Me, 20)
        fullTime = valSetTime
        fullPercent = batteryPercent - valBatteryLifeLB
        notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        notifyIcon.BalloonTipText = "点击这里打开详细页面"
        notifyIcon.BalloonTipTitle = frmMain.Text
        notifyIcon.ShowBalloonTip(1000)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        '动画效果
        showSwipAnimation()
        selectBG()
        '开始
        tmrCheckTv.Enabled = chk_RECORD
        tmrReminder.Enabled = chk_REMINDER
        targetTime = pref_VOL_EFF_HOUR * 60 + pref_VOL_EFF_MIN
        freshUI()
        tmrVol.Enabled = chk_VOLCTRL
        batteryStatusImage = My.Resources.fullbattery
        SaveSettings()
        '是否初始化CAAPI
        If selectedMode = 2 Or chk_VOLCTRL Then
            If osMajorVersion < 6 Then Exit Sub
            Dim DevEnum As New MMDeviceEnumerator()
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        End If
        '确定模式
        If selectedMode = 0 Then
            tmrTimeMode.Enabled = True
        ElseIf selectedMode = 1 Then
            tmrBatteryMode.Enabled = True
            延长时间ToolStripMenuItem.Enabled = False
            加时ToolStripMenuItem.Enabled = False
        ElseIf selectedMode = 2 Then
            tmrVChecker.Enabled = True
            延长时间ToolStripMenuItem.Enabled = False
            加时ToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub showUpUI()
        showSwipAnimation()
        Me.Visible = Not Me.Visible
        fullUI(Me.Visible)
        Me.Left = MousePosition.X - Me.Width / 2
        If Me.Left > (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) Then Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        If Me.Left < 0 Then Me.Left = 0
    End Sub
    Private Sub outAnimationTimer_Tick(sender As Object, e As EventArgs) Handles outAnimationTimer.Tick
        If speedIndex - 1 > 0 Then speedIndex -= 1
        Me.Top -= speedIndex
        Me.Opacity -= 0.04
        Me.Refresh()
        If Me.Top < (Screen.PrimaryScreen.WorkingArea.Height - Me.Height - Me.Height * 0.4) Then
            outAnimationTimer.Enabled = False
            Me.Refresh()
            Me.Opacity = 9
            Me.Hide()
            fullUI(False)
        End If
        Application.DoEvents()
    End Sub
    Private Sub hideUI()
        outAnimationTimer.Enabled = False
        If Me.Visible = False Then Me.Visible = True
        Me.Opacity = 9
        speedIndex = 18
        outAnimationTimer.Enabled = True
    End Sub

    Private Sub notifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.Visible = True Then hideUI()
            If Me.Visible = False Then showUpUI()
        ElseIf e.Button = MouseButtons.Right Then
            cmsRightClick.Show(MousePosition.X - cmsRightClick.Width / 2, MousePosition.Y)
        End If
    End Sub

    Private Sub animationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animationTimer.Tick
        If speedIndex - 1 > 0 Then speedIndex -= 1
        Me.Top -= speedIndex
        Me.Opacity += 0.04
        Me.Refresh()
        If Me.Top < (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) Then
            Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            animationTimer.Enabled = False
            Me.Refresh()
        End If

        Application.DoEvents()
    End Sub

    Private Sub showSwipAnimation()
        'Me.Height = 0
        Me.Opacity = 0
        speedIndex = 18
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height * 0.6)
        animationTimer.Enabled = True
    End Sub

    Private Sub drawStatus()
        If batteryChargeStatus = 1 And batteryStatus = 8 Then
            batteryStatusString = "正在充电"
            tmrChargeAnimate.Enabled = True
        ElseIf batteryChargeStatus = 0 Then
            tmrChargeAnimate.Enabled = False
            batteryStatusString = "电池剩余" & batteryPercent & "%"
        ElseIf (batteryChargeStatus = 1 And batteryStatus = 0) Or (batteryChargeStatus = 1 And batteryStatus = 1 And batteryPercent > 95) Then
            tmrChargeAnimate.Enabled = False
            batteryStatusString = "电源接通，但未充电"
            batteryStatusImage = My.Resources.charging3
        ElseIf batteryChargeStatus = 1 And batteryStatus <> 0 Then
            batteryStatusString = "正在充电"
            tmrChargeAnimate.Enabled = True
        End If
    End Sub


    Private Sub tmrAutoHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoHide.Tick
        'Me.Visible = False
        hideUI()
        fullUI(False)
        tmrAutoHide.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        cmsInterfaceMenu.Show(Me, btnMenu.Left - (cmsInterfaceMenu.Width - btnMenu.Width), btnMenu.Top - cmsInterfaceMenu.Height)
    End Sub
    Private Sub add10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add10.Click
        addTime(10)
    End Sub

    Private Sub add20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add20.Click
        addTime(20)
    End Sub

    Private Sub add50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add50.Click
        addTime(30)
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        addTime(60)
    End Sub

    Private Sub add2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add2.Click
        addTime(120)
    End Sub

    Private Sub QqqToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QqqToolStripMenuItem.Click
        If Me.Visible = False Then
            showUpUI()
        Else
            hideUI()
        End If
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        exitProgram(1)
    End Sub


    Private Sub tmrChargeAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChargeAnimate.Tick
        If (batteryChargeStatus = 1 And batteryStatus = 8) Or (batteryChargeStatus = 1 And batteryStatus <> 0) Then
            batteryAnimateStep += 1
            If batteryAnimateStep = 1 Then batteryStatusImage = My.Resources.lowbattery
            If batteryAnimateStep = 2 Then batteryStatusImage = My.Resources.halfbattery
            If batteryAnimateStep = 3 Then
                batteryStatusImage = My.Resources.fullbattery
                batteryAnimateStep = 0
            End If
        End If
    End Sub

    Private Sub tmrConnectionCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUIFresh.Tick
        freshUI()
    End Sub

    Private Sub tmrCheckTv_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckTv.Tick
        getTvTitleAndPg()
        If oldTvProgress <> tvProgress Or oldTvTitle <> tvTitle Then
            oldTvProgress = tvProgress
            oldTvTitle = tvTitle
            showNotify("正在收看《" & tvTitle & "》 -  " & tvProgress, Color.DodgerBlue)
            set_TVP = "《" & tvTitle & "》 - " & tvProgress
            SaveSettings()
        End If
    End Sub

    Private Sub tmrVol_Tick(sender As Object, e As EventArgs) Handles tmrVol.Tick
        If Hour(Now) * 60 + Minute(Now) >= targetTime Then
            If osMajorVersion > 5 Then
                device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(pref_VOL) / 100.0F)
            Else
                changeVolume4XP(pref_VOL_XP / pref_VOL_XP_MSG)
            End If
            tmrVol.Enabled = False
        End If
    End Sub

    Private Sub tmrReminder_Tick(sender As Object, e As EventArgs) Handles tmrReminder.Tick
        If Minute(Now) = 29 Or Minute(Now) = 59 Then
            If Second(Now) > 29 Then
                frmReminder.Show()
                tmrReminder.Enabled = False
            End If
        End If
    End Sub

    Private Sub tmrProgressDrawer_Tick(sender As Object, e As EventArgs) Handles tmrProgressDrawer.Tick
        If selectedMode = 2 And tmrTimeMode.Enabled = False Then
            currentProgress = CInt(device.AudioMeterInformation.MasterPeakValue * 100)
            If currentProgress > 0 Then
                showStringMiddle = "有声音~"
            ElseIf currentProgress = 0 Then
                showStringMiddle = "没声音~"
            End If
            remainTip.Text = showStringMiddle
        End If
        changingAngle += 3
        If changingAngle > 360 Then changingAngle = 0
        pbStatus.Image = DrawProgressBar(changingAngle)
    End Sub

    Private Sub 退出ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem1.Click
        exitProgram(1)
    End Sub

    Private Sub 隐藏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 隐藏ToolStripMenuItem.Click
        Me.Visible = False
        hideUI()
    End Sub

    Private Sub 返回ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回ToolStripMenuItem.Click
        Me.Dispose()
        frmMain.Show()
        frmMain.Refresh()
    End Sub

    Private Sub addTime(ByVal min As Integer)
        valSetTime += min * 60
        fullTime = valSetTime
    End Sub

    Private Sub add10min_Click(sender As Object, e As EventArgs) Handles add10min.Click
        addTime(10)
    End Sub

    Private Sub add20min_Click(sender As Object, e As EventArgs) Handles add20min.Click
        addTime(20)
    End Sub

    Private Sub add30min_Click(sender As Object, e As EventArgs) Handles add30min.Click
        addTime(30)
    End Sub

    Private Sub add60min_Click(sender As Object, e As EventArgs) Handles add60min.Click
        addTime(60)
    End Sub

    Private Sub add120min_Click(sender As Object, e As EventArgs) Handles add120min.Click
        addTime(120)
    End Sub

    Private Sub btnMenu_MouseHover(sender As Object, e As EventArgs) Handles btnMenu.MouseHover
        ToolTip1.Show("点击此处显示更多的选项", btnMenu)
    End Sub


    Private Sub tmrTimeMode_Tick(sender As Object, e As EventArgs) Handles tmrTimeMode.Tick
        updateBatteryInfo()
        valSetTime -= 1
        'lbInfo.Text = "将在 " & converTime(valSetTime) & " 后关机"
        remainTip.Text = "将在 " & converTime(valSetTime) & " 后关机"
        If valSetTime = 180 Then showNotify("剩余3分钟关机", Color.Orange)
        If valSetTime = 30 Then showNotify("即将关机", Color.Red)
        If valSetTime = 0 Then
            mainTick.Enabled = False
            shutdownWindows()
            exitProgram(0)
        End If
        currentProgress = (valSetTime) / fullTime * 100
        showStringMiddle = Split(converTime(valSetTime), "分")(0) & "分"
        showStringDown = Split(converTime(valSetTime), "分")(1).Replace("秒", "")
        drawStatus()
        smallTitle = "剩余"
    End Sub

    Private Sub tmrBatteryMode_Tick(sender As Object, e As EventArgs) Handles tmrBatteryMode.Tick
        updateBatteryInfo()
        remainTip.Text = "将在电量低于" & valBatteryLifeLB & "%时关机"
        If batteryPercent - valBatteryLifeLB = 3 Then showNotify("再下降3%的电量将关机", Color.Orange)
        If batteryPercent - valBatteryLifeLB = 0 Then showNotify("即将关机", Color.Red)
        If batteryPercent < valBatteryLifeLB Then
            mainTick.Enabled = False
            shutdownWindows()
            exitProgram(0)
        End If
        batteryStatusMode()
        currentProgress = (batteryPercent - valBatteryLifeLB) / fullPercent * 100
        showStringMiddle = batteryPercent & "%"
        showStringDown = ""
        drawStatus()
        smallTitle = "剩余"
    End Sub

    Private Sub tmrVChecker_Tick(sender As Object, e As EventArgs) Handles tmrVChecker.Tick
        updateBatteryInfo()
        If CInt(device.AudioMeterInformation.MasterPeakValue * 100) = 0 Then
            If tmrTimeMode.Enabled = True Then Exit Sub
            ticker_SL += 1
            If ticker_SL < 2 Then Exit Sub
            showNotify("电脑当前无声，持续" & valStime & "分钟后将关机", Color.Orange)
            valSetTime = valStime * 60
            fullTime = valSetTime
            tmrTimeMode.Enabled = True
        Else
            remainTip.Text = "有声音~"
            ticker_SL = 0
            tmrTimeMode.Enabled = False
            showStringDown = ""
            smallTitle = ""
        End If
    End Sub


End Class