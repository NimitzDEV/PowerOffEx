Public Class frmNotify

    Private Sub frmTvNotify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width
        Label1.Text = globalNotifyInfo
        Label1.Left = (Me.Width - Label1.Width) / 2
        drawWindowStep1(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub frmTvNotify_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        drawWindowStep2(Me, e, Color.Gray, Color.Transparent)
    End Sub
End Class