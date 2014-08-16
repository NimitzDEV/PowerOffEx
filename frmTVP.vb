Public Class frmTVP

    Private Sub frmTVP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If InStr(set_TVP, "-") = 0 Then
            lbA.Text = set_TVP
            lbB.Text = ""
        ElseIf InStr(set_TVP, "-") <> 0 Then
            lbA.Text = Split(set_TVP, "-")(0).Trim
            lbB.Text = Split(set_TVP, "-")(1).Trim
        End If
        If set_TVP = "" Then
            lbA.Text = "暂无记录"
            lbB.Text = ""
        End If
        lbA.Left = (Me.Width - lbA.Width) / 2
        lbB.Left = (Me.Width - lbB.Width) / 2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then set_TVP = ""
        Me.Dispose()
    End Sub
End Class