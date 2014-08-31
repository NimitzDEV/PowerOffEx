Public Class frmReminder
    Dim counter As Integer
    Private Sub frmReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 6
        Me.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        lbTime.Text = Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTime.Text = Hour(Now) & ":" & Minute(Now) & ":" & Second(Now)
        If (Minute(Now) = 30 Or Minute(Now)) = 0 And Second(Now) > 30 Then
            frmInterface.tmrReminder.Enabled = True
            Me.Close()
        End If
    End Sub
End Class