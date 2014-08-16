Imports CoreAudioApi
Public Class frmMain
    Dim os As OperatingSystem = Environment.OSVersion
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmbeddedAssembly.Load("定时关机Ex.CoreAudioApi.dll", "CoreAudioApi.dll")
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, New System.ResolveEventHandler(AddressOf assResolve)
        ReadSettings()
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        If checkIsLaptop() = True Then
            updateBatteryInfo()
            rbEvents.Enabled = True
            nudBattery.Maximum = batteryPercent
        End If
        '是否为XP
        If os.Version.Major < 6 Then
            chk_VOLCTRL = False
            cbVol.Enabled = False
            cbVol.Text &= "- XP系统暂不支持功能，请等待后续升级"
            llbVolume.Visible = False
        End If
        nudHour.Value = pref_HOUR
        nudMinute.Value = pref_MIN
        cbRecordTvProgress.Checked = chk_RECORD
        cbVol.Checked = chk_VOLCTRL

    End Sub

    Private Function assResolve(ByVal sender As System.Object, ByVal e As System.ResolveEventArgs) As System.Reflection.Assembly
        Return EmbeddedAssembly.Get(e.Name)
    End Function
   

    Private Sub rbEvents_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEvents.CheckedChanged
        updateBatteryInfo()
        If batteryChargeStatus = 1 Then
            lbTip2.Text = "% 时 - 当前正在充电，不可用"
            nudBattery.Enabled = False
        Else
            nudBattery.Enabled = True
            lbTip2.Text = "% 时 - 当前剩余：" & batteryPercent
            If batteryLife = 0 Or batteryLife = -1 Then
                lbTip2.Text &= "% - 暂时无法估算剩余时间"
            Else
                lbTip2.Text &= "% - 电池可用" & converTime(batteryLife)
            End If
        End If
        Debug.Print(batteryLife)
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        If rbSetTime.Checked = True Then
            If nudHour.Value = 0 And nudMinute.Value = 0 Then
                MsgBox("时间不能为0")
                Exit Sub
            Else
                valSetTime = nudHour.Value * 3600 + nudMinute.Value * 60
                valBatteryLifeLB = 0
            End If
        End If
        If rbEvents.Checked = True Then
            updateBatteryInfo()
            If batteryChargeStatus = 1 Then
                MsgBox("当前正在充电，无法使用此功能")
                Exit Sub
            Else
                valSetTime = 0
                valBatteryLifeLB = nudBattery.Value
            End If
        End If
        If cbVol.Checked Then
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
        frmInterface.Show()
        Me.Hide()
    End Sub


    Private Sub llbHistory_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbHistory.LinkClicked
        frmTVP.ShowDialog()
    End Sub

    Private Sub llbAbout_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbAbout.LinkClicked
        frmAbout.Show()
    End Sub

    Private Sub llbVolume_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbVolume.LinkClicked
        frmVolCtrl.ShowDialog()
    End Sub

    Private Sub cbRecordTvProgress_CheckedChanged(sender As Object, e As EventArgs) Handles cbRecordTvProgress.CheckedChanged
        chk_RECORD = cbRecordTvProgress.Checked
    End Sub

    Private Sub cbVol_CheckedChanged(sender As Object, e As EventArgs) Handles cbVol.CheckedChanged
        chk_VOLCTRL = cbVol.Checked
    End Sub


End Class
