Imports CoreAudioApi
Public Class frmVolCtrl
    Dim origiVol As Integer
    Private device As MMDevice
    Private Sub frmVolCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DevEnum As New MMDeviceEnumerator()
        device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        origiVol = CInt(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100)
        tbMaster.Value = origiVol
        lbCurrent.Text = "当前音量：" & origiVol & "%"
        lbOrigi.Text = "原始音量：" & origiVol & "%"
        lbLast.Text = "上一次设置为：" & pref_VOL & "%"
        AddHandler device.AudioEndpointVolume.OnVolumeNotification, New AudioEndpointVolumeNotificationDelegate(AddressOf AudioEndpointVolume_OnVolumeNotification)
    End Sub

   
    Private Sub AudioEndpointVolume_OnVolumeNotification(data As AudioVolumeNotificationData)
        If Me.InvokeRequired Then
            Dim Params As Object() = New Object(0) {}
            Params(0) = data
            Me.Invoke(New AudioEndpointVolumeNotificationDelegate(AddressOf AudioEndpointVolume_OnVolumeNotification), Params)
        Else
            tbMaster.Value = CInt(data.MasterVolume * 100)
            lbCurrent.Text = "当前音量：" & tbMaster.Value & "%"
        End If
    End Sub

    Private Sub tbMaster_Scroll(sender As Object, e As EventArgs) Handles tbMaster.Scroll
        device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(tbMaster.Value) / 100.0F)
        lbCurrent.Text = "当前音量为：" & tbMaster.Value & "%"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbMaster.Value = CInt(device.AudioMeterInformation.MasterPeakValue * 100)
        pbCurrent.Value = pbMaster.Value * (tbMaster.Value / 100)
        lbFull.Text = "总的音量（" & Format(pbMaster.Value, "000") & "/100）"
        lbNow.Text = "当前音量（" & Format(pbCurrent.Value, "000") & "/100）"
        If pbMaster.Value > 40 And pbMaster.Value < 86 Then lbFull.ForeColor = Color.Orange
        If pbMaster.Value > 85 Then lbFull.ForeColor = Color.Red
        If pbMaster.Value <= 40 Then lbFull.ForeColor = Color.Green
        If pbCurrent.Value > 40 And pbCurrent.Value < 86 Then lbNow.ForeColor = Color.Orange
        If pbCurrent.Value > 85 Then lbNow.ForeColor = Color.Red
        If pbCurrent.Value <= 40 Then lbNow.ForeColor = Color.Green
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(origiVol) / 100.0F)
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        device.AudioEndpointVolume.MasterVolumeLevelScalar = (CSng(origiVol) / 100.0F)
        pref_VOL = tbMaster.Value
        Me.Close()
    End Sub
End Class