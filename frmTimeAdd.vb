Public Class frmTimeAdd

    Private Sub frmTimeAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = frmInterface.Width
        If frmInterface.Visible = False Then
            Me.Left = MousePosition.X - Me.Width / 2
            Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
        Else
            Me.Top = frmInterface.Top
            Me.Left = frmInterface.Left
        End If
        tbTimeAdd.Left = 0
        tbTimeAdd.Width = Me.Width
    End Sub

    Private Sub tbTimeAdd_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTimeAdd.Scroll
        lbTip.Text = converTime(tbTimeAdd.Value)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        valSetTime += tbTimeAdd.Value
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class