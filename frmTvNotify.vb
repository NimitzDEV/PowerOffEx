Public Class frmTvNotify

    Private Sub frmTvNotify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width
        Label1.Text = "正在收看 《" & tvTitle & "》" & tvProgress
        drawWindowShadowStep1(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub frmTvNotify_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        drawWindowShadowStep2(Me, e, Color.DodgerBlue, Color.White)
    End Sub
End Class