Imports CoreAudioApi
Public Class frmInterface
    Dim batteryAnimateStep As Integer
    Dim targetTime As Integer
    Private device As MMDevice
    Enum originalData As Integer
        oFrmWidth = 533
        oFrmHeight = 211
    End Enum
    Private Sub fullUI(ByVal isEnable As Boolean)
        tmrChargeAnimate.Enabled = isEnable
        tmrUIFresh.Enabled = isEnable
    End Sub
    Private Sub freshUI()
        If batteryChargeStatus = 0 Then
            If batteryPercent > 80 Then
                pbBattery.Image = My.Resources.fullbattery
            ElseIf batteryPercent > 35 And batteryPercent < 80 Then
                pbBattery.Image = My.Resources.halfbattery
            Else
                pbBattery.Image = My.Resources.lowbattery
            End If
        End If
        networkStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable
        If networkStatus = True Then
            pbConnections.Image = My.Resources.wire
            lbConnectStatus.Text = " 已连接网络"
        Else
            pbConnections.Image = My.Resources.disconnect
            lbConnectStatus.Text = " 未连接网络"
        End If
        lbConnectStatus.Left = (pnlNetworkConnection.Width - lbConnectStatus.Width) / 2
    End Sub
    Private Sub frmInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reconstractUi()
        notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        notifyIcon.BalloonTipText = "点击这里打开详细页面"
        notifyIcon.BalloonTipTitle = frmMain.Text
        notifyIcon.ShowBalloonTip(1000)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        '绘制阴影
        drawWindowStep1(Me)
        '动画效果
        showSwipAnimation()
        '开始
        tmrCheckTv.Enabled = chk_RECORD
        tmrReminder.Enabled = chk_REMINDER
        targetTime = pref_VOL_EFF_HOUR * 60 + pref_VOL_EFF_MIN
        updateBatteryInfo()
        freshUI()
        tmrVol.Enabled = chk_VOLCTRL
        If frmMain.rbSetTime.Checked = False Then
            延长时间ToolStripMenuItem.Visible = False
            btnAdd.Visible = False
        End If
        SaveSettings()
    End Sub

    Private Sub notifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles notifyIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            Me.Visible = Not Me.Visible
            fullUI(Me.Visible)
            Me.Left = MousePosition.X - Me.Width / 2
            Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
            showSwipAnimation()
        ElseIf e.Button = MouseButtons.Right Then
            cmsRightClick.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub frmInterface_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        drawWindowStep2(Me, e, Color.White, Color.DodgerBlue)
    End Sub

    Private Sub animationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animationTimer.Tick
        Me.Height += 15
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Me.Refresh()
        If Me.Height > originalData.oFrmHeight Then
            Me.Height = originalData.oFrmHeight
            animationTimer.Enabled = False
            Me.Refresh()
        End If
        Application.DoEvents()
    End Sub

    Private Sub showSwipAnimation()
        Me.Height = 0
        animationTimer.Enabled = True
    End Sub

    Private Sub mainTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainTick.Tick
        updateBatteryInfo()
        If valSetTime > 0 Then
            valSetTime -= 1
            lbInfo.Text = "将在 " & converTime(valSetTime) & " 后关机"
            remainTip.Text = lbInfo.Text
            If valSetTime = 180 Then showNotify(lbInfo.Text)
            If valSetTime = 30 Then showNotify("即将关机")
            If valSetTime = 0 Then
                mainTick.Enabled = False
                shutdownWindows()
                exitProgram(0)
            End If
        ElseIf valBatteryLifeLB > 0 Then
            lbInfo.Text = "将在电量低于" & valBatteryLifeLB & "%时关机"
            remainTip.Text = lbInfo.Text
            If batteryPercent - valBatteryLifeLB = 3 Then showNotify("再下降3%的电量将关机")
            If batteryPercent - valBatteryLifeLB = 0 Then showNotify("即将关机")
            If batteryPercent < valBatteryLifeLB Then
                mainTick.Enabled = False
                shutdownWindows()
                exitProgram(0)
            End If
            batteryStatusMode()
        End If
        '///////////////////////////////////////////////////////////////////////////////////////////

        '///////////////////////////////////////////////////////////////////////////////////////////
        If batteryChargeStatus = 1 And batteryStatus = 8 Then
            lbBatteryStatus.Text = "正在充电"
            tmrChargeAnimate.Enabled = True
        ElseIf batteryChargeStatus = 0 Then
            tmrChargeAnimate.Enabled = False
            lbBatteryStatus.Text = "电池剩余" & batteryPercent & "%"
        ElseIf (batteryChargeStatus = 1 And batteryStatus = 0) Or (batteryChargeStatus = 1 And batteryStatus = 1 And batteryPercent > 95) Then
            tmrChargeAnimate.Enabled = False
            lbBatteryStatus.Text = "电源接通" & vbCrLf & "但未充电"
            pbBattery.Image = My.Resources.nocharging
        ElseIf batteryChargeStatus = 1 And batteryStatus <> 0 Then
            lbBatteryStatus.Text = "正在充电"
            tmrChargeAnimate.Enabled = True
        End If
        lbBatteryStatus.Left = (pnlBattery.Width - lbBatteryStatus.Width) / 2
        '///////////////////////////////////////////////////////////////////////////////////////////
        lbInfo.Left = (Me.Width - lbInfo.Width) / 2

    End Sub

    Private Sub tmrAutoHide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoHide.Tick
        Me.Visible = False
        fullUI(False)
        tmrAutoHide.Enabled = False
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Dispose()
        frmMain.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        exitProgram(1)
    End Sub

    Private Sub add10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add10.Click
        valSetTime += 10 * 60
    End Sub

    Private Sub add20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add20.Click
        valSetTime += 20 * 60
    End Sub

    Private Sub add50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add50.Click
        valSetTime += 50 * 60
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        valSetTime += 60 * 60
    End Sub

    Private Sub add2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add2.Click
        valSetTime += 120 * 60
    End Sub

    Private Sub QqqToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QqqToolStripMenuItem.Click
        Me.Visible = Not Me.Visible
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        exitProgram(1)
    End Sub

    Private Sub 自定义ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 自定义ToolStripMenuItem.Click
        frmTimeAdd.Show(Me)
    End Sub

    Private Sub tmrChargeAnimate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChargeAnimate.Tick
        If (batteryChargeStatus = 1 And batteryStatus = 8) Or (batteryChargeStatus = 1 And batteryStatus <> 0) Then
            batteryAnimateStep += 1
            If batteryAnimateStep = 1 Then pbBattery.Image = My.Resources.lowbattery
            If batteryAnimateStep = 2 Then pbBattery.Image = My.Resources.halfbattery
            If batteryAnimateStep = 3 Then
                pbBattery.Image = My.Resources.fullbattery
                batteryAnimateStep = 0
            End If
        End If
    End Sub

    Private Sub tmrConnectionCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUIFresh.Tick
        freshUI()
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        Me.Visible = False
        fullUI(False)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmTimeAdd.Show(Me)
    End Sub

    Private Class UnselectableFORM
        Inherits frmNotify
        Public Sub New()
            MyBase.New()
            Me.SetStyle(ControlStyles.Selectable, False)
        End Sub
    End Class
    Private Sub showNotify(ByVal info As String)
        Dim frmtvnotifyNoFocus As Form = New UnselectableFORM
        globalNotifyInfo = info
        frmtvnotifyNoFocus.Show()
    End Sub

    Private Sub tmrCheckTv_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckTv.Tick
        getTvTitleAndPg()
        If oldTvProgress <> tvProgress Or oldTvTitle <> tvTitle Then
            oldTvProgress = tvProgress.Trim
            oldTvTitle = tvTitle.Trim
            showNotify("正在收看《" & tvTitle & "》 - " & tvProgress)
            set_TVP = "《" & tvTitle & "》 - " & tvProgress
            SaveSettings()
        End If
    End Sub

    Private Sub tmrVol_Tick(sender As Object, e As EventArgs) Handles tmrVol.Tick
        If Hour(Now) * 60 + Minute(Now) >= targetTime Then
            If osMajorVersion > 5 Then
                Dim DevEnum As New MMDeviceEnumerator()
                device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
                device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(pref_VOL) / 100.0F)
                tmrVol.Enabled = False
            Else
                changeVolume4XP(pref_VOL_XP / pref_VOL_XP_MSG)
            End If
        End If
        tmrVol.Enabled = False
    End Sub

    Private Sub tmrReminder_Tick(sender As Object, e As EventArgs) Handles tmrReminder.Tick
        If Minute(Now) = 29 Or Minute(Now) = 59 Then
            If Second(Now) > 29 Then
                frmReminder.Show()
                tmrReminder.Enabled = False
            End If
        End If
    End Sub
End Class