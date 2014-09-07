﻿Imports CoreAudioApi
Imports System.Text.RegularExpressions.Regex
Public Class frmMain
    Dim inputArgument As String = "/input="
    Dim inputName As String = ""
    Public selectedMode As Integer = 0
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmbeddedAssembly.Load("定时关机Ex.CoreAudioApi.dll", "CoreAudioApi.dll")
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, New System.ResolveEventHandler(AddressOf assResolve)
        ReadSettings()
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        fNHour.Value = pref_HOUR
        fNMinute.Value = pref_MIN
        ftRecord.Checked = chk_RECORD
        ftVol.Checked = chk_VOLCTRL
        ftReminder.Checked = chk_REMINDER
        valSetTime = 0
        startArgsChecking()
        FormSkin1.Text = Me.Text
    End Sub


    Private Function assResolve(ByVal sender As System.Object, ByVal e As System.ResolveEventArgs) As System.Reflection.Assembly
        Return EmbeddedAssembly.Get(e.Name)
    End Function


    Private Sub tsmiContinue_Click(sender As Object, e As EventArgs) Handles tsmiContinue.Click
        valBatteryLifeLB = 0
        frmInterface.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiRefresh_Click(sender As Object, e As EventArgs) Handles tsmiRefresh.Click
        valSetTime = fNHour.Value * 3600 + fNMinute.Value * 60
        valBatteryLifeLB = 0
        frmInterface.Show()
        Me.Hide()
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
            If fNHour.Value = 0 And fNMinute.Value = 0 Then
                MsgBox("时间不能为0")
                Exit Sub
            Else
                If valSetTime > 0 Then
                    cmsSelect.Show(btnStart, 0, btnStart.Height)
                    tsmiContinue.Text = "继续刚才（剩余" & converTime(valSetTime) & ")"
                    Exit Sub
                End If
                valSetTime = fNHour.Value * 3600 + fNMinute.Value * 60
                valBatteryLifeLB = 0
        End If
        selectedMode = 0
        startActive()
    End Sub

    Private Sub startActive()
        If ftVol.Checked Then
            If osMajorVersion > 5 Then
                Dim device As MMDevice
                Dim DevEnum As New MMDeviceEnumerator()
                device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
                Dim vol_n As Integer = CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
                If pref_VOL > vol_n Then
                    MsgBox("当前设置的深夜音量比目前音量还要大，请重新设置后再试吧~")
                    frmVolCtrl.ShowDialog()
                    Exit Sub
                End If
            End If
        End If
        pref_HOUR = fNHour.Value
        pref_MIN = fNMinute.Value
        frmInterface.Show()
        Me.Hide()
    End Sub

    Private Sub btnFindNew_Click(sender As Object, e As EventArgs) Handles btnFindNew.Click
        frmUpdate.ShowDialog()
        frmUpdate.Dispose()
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Me.Close()
    End Sub


    Private Sub fbAbout_Click(sender As Object, e As EventArgs) Handles fbAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub tbBatteryMode_Click(sender As Object, e As EventArgs) Handles tbBatteryMode.Click

    End Sub

    Private Sub ftbBattery_Scroll(sender As Object) Handles ftbBattery.Scroll
        lbBatterySettings.Text = "将在电量低于" & ftbBattery.Value & "%时关机"
    End Sub

    Private Sub FlatTabControl1_Click(sender As Object, e As EventArgs) Handles FlatTabControl1.Click
        Select Case FlatTabControl1.SelectedIndex
            Case 0
                FlatTabControl1.ActiveColor = Color.FromArgb(35, 168, 109)
            Case 1
                fgbError.Visible = False
                FlatTabControl1.ActiveColor = Color.DodgerBlue
                updateBatteryInfo()
                If checkIsLaptop() = False Then
                    FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "台式机不适用此功能！", 5000)
                    fgbError.Width = tbBatteryMode.Width
                    fgbError.Visible = True
                    Exit Sub
                End If
                ftbBattery.Maximum = batteryPercent - 1
                ftbBattery.Minimum = 5
                If batteryChargeStatus = 1 Then
                    FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Error, "当前正在充电不可用！", 5000)
                    fgbError.Width = tbBatteryMode.Width
                    fgbError.Visible = True
                Else
                    Dim tipString As String
                    tipString = "剩余：" & batteryPercent & "%"
                    If batteryLife = 0 Or batteryLife = -1 Then
                        tipString &= "（暂时无法估算剩余时间）"
                    Else
                        tipString &= "（可用" & converTime(batteryLife) & "）"
                    End If
                    fpbCurrentBattery.Value = batteryPercent
                    FlatAlertBox1.ShowControl(FlatAlertBox._Kind.Info, tipString, 6000)
                End If
                Debug.Print(batteryLife)
            Case 2
                FlatTabControl1.ActiveColor = Color.Orange
        End Select
        fsbTime.RectColor = FlatTabControl1.ActiveColor
        FormSkin1.FlatColor = FlatTabControl1.ActiveColor
        Me.Refresh()
    End Sub

    Private Sub ftRecord_CheckedChanged(sender As Object) Handles ftRecord.CheckedChanged
        chk_RECORD = ftRecord.Checked
    End Sub

    Private Sub ftVol_CheckedChanged(sender As Object) Handles ftVol.CheckedChanged
        chk_VOLCTRL = ftVol.Checked
    End Sub

    Private Sub ftReminder_CheckedChanged(sender As Object) Handles ftReminder.CheckedChanged
        chk_REMINDER = ftReminder.Checked
    End Sub

    Private Sub fbHistory_Click(sender As Object, e As EventArgs) Handles fbHistory.Click
        frmTVP.ShowDialog()
    End Sub

    Private Sub fbVolSettings_Click(sender As Object, e As EventArgs) Handles fbVolSettings.Click
        If osMajorVersion < 6 Then
            frmVolCtrl4XP.ShowDialog()
        Else
            frmVolCtrl.ShowDialog()
        End If
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        fsbTime.Text = Date.Today & "- " & TimeOfDay
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        updateBatteryInfo()
        If batteryChargeStatus = 1 Then
            MsgBox("当前正在充电，无法使用此功能")
            Exit Sub
        Else
            valSetTime = 0
            valBatteryLifeLB = ftbBattery.Value
        End If
        selectedMode = 1
        startActive()
    End Sub

    Private Sub help4TVP_MouseHover(sender As Object, e As EventArgs) Handles help4TVP.MouseHover
        ToolTip1.Show(Unescape("本功能用能够简单的记录您在浏览器或者部分客户端看电视剧的记录\n当浏览器或者客户端的标题中包含\n""第""和""集""两个关键字的时候才会生效"), help4TVP)
    End Sub


    Private Sub help4VOL_MouseHover(sender As Object, e As EventArgs) Handles help4VOL.MouseHover
        ToolTip1.Show(Unescape("本功能可以在深夜的时候自动降低电脑的音量\n以防打扰别人休息"), help4VOL)
    End Sub

    Private Sub help4REMINDER_MouseHover(sender As Object, e As EventArgs) Handles help4REMINDER.MouseHover
        ToolTip1.Show(Unescape("类似电视台的报时功能\n在半点和整点的时候提示当前时间"), help4REMINDER)
    End Sub
End Class
