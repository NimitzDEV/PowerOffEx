Public Class frmVolCtrl4XP

    Private Sub frmVolCtrl4XP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudHOUR.Value = pref_VOL_EFF_HOUR
        nudMIN.Value = pref_VOL_EFF_MIN
        lbCurrent.Text = "当前设置：降低 " & pref_VOL_XP & "%"
        tbMaster.Value = pref_VOL_XP
    End Sub

    Private Sub tbMaster_Scroll(sender As Object, e As EventArgs) Handles tbMaster.Scroll
        lbCurrent.Text = "当前设置：降低 " & tbMaster.Value & "%"
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        pref_VOL_XP = tbMaster.Value
        pref_VOL_EFF_HOUR = nudHOUR.Value
        pref_VOL_EFF_MIN = nudMIN.Value
        Me.Dispose()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Dispose()
    End Sub
End Class