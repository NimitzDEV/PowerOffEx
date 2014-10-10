Public Class frmNotify

    Private Sub frmTvNotify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = -Me.Height
        Me.Left = 15
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 30
        Label1.Text = globalNotifyInfo
        Label1.Left = (Me.Width - Label1.Width) / 2
        Timer2.Enabled = True
        'drawWindowStep1(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    'Private Sub frmTvNotify_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    drawWindowStep2(Me, e, Color.Gray, Color.Transparent)
    'End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Top > 15 Then
            Me.Top = 15
            Timer2.Enabled = False
        End If
        Me.Top += 5
    End Sub
End Class