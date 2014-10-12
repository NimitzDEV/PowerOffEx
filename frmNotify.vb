Public Class frmNotify

    Private Sub frmTvNotify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = -Me.Height
        Me.Left = 15
        Me.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 30
        Label1.Text = globalNotifyInfo
        Label1.Left = (Me.Width - Label1.Width) / 2
        tmrIn.Enabled = True
        'drawWindowStep1(Me)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tmrOut.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles tmrIn.Tick
        If Me.Top > 15 Then
            Me.Top = 15
            tmrIn.Enabled = False
        End If
        Me.Top += 5
    End Sub

    Private Sub tmrOut_Tick(sender As Object, e As EventArgs) Handles tmrOut.Tick
        If Me.Top < -Me.Height Then
            tmrOut.Enabled = False
            Me.Close()
        End If
        Me.Top -= 5
    End Sub
End Class