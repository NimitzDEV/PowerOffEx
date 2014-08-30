Public Class frmVolCtrl4XP

    Private Sub freshMSG()
        lbMsg.Text = "，降低" & tbMaster.Value & "%将发送" & Math.Round(tbMaster.Value / nudMsg.Value) & "次消息"
    End Sub
    Private Sub frmVolCtrl4XP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudHOUR.Value = pref_VOL_EFF_HOUR
        nudMIN.Value = pref_VOL_EFF_MIN
        nudMsg.Value = pref_VOL_XP_MSG
        lbCurrent.Text = "当前设置：降低 " & pref_VOL_XP & "%"
        tbMaster.Value = pref_VOL_XP
        freshMSG()
    End Sub

    Private Sub tbMaster_Scroll(sender As Object, e As EventArgs) Handles tbMaster.Scroll
        lbCurrent.Text = "当前设置：降低 " & tbMaster.Value & "%"
        freshMSG()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        pref_VOL_XP = tbMaster.Value
        pref_VOL_EFF_HOUR = nudHOUR.Value
        pref_VOL_EFF_MIN = nudMIN.Value
        pref_VOL_XP_MSG = nudMsg.Value
        Me.Dispose()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Dispose()
    End Sub
End Class