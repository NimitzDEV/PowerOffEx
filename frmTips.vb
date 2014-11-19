Public Class frmTips
    Dim actionSign As Integer
    Dim animating As Integer

    Private Sub frmTips_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = animating
        If animating <> -1 Then Me.Dispose()
    End Sub
    Private Sub frmTips_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Region = roundedCorner(Me, 20)
        Me.Opacity = 0
        actionSign = 0
        Me.Top = Screen.PrimaryScreen.WorkingArea.Height - frmInterface.Height - Me.Height
        Me.Left = frmInterface.Left
        Me.BackgroundImage = bgImage
        tmrAnimation.Enabled = True
    End Sub

    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        If actionSign = 0 Then showUp()
        If actionSign = 1 Then
            animating = -1
            closeDown()
        End If
    End Sub
    Private Sub showUp()
        If Me.Opacity = 1 Then
            tmrAnimation.Enabled = False
            Exit Sub
        End If
        Me.Opacity += 0.05
    End Sub
    Private Sub closeDown()
        If Me.Opacity = 0 Then
            Exit Sub
        End If
        Me.Opacity -= 0.05
    End Sub

    Private Sub llbMore_Click(sender As Object, e As EventArgs) Handles llbMore.Click
        Process.Start(llbMore.Tag)
    End Sub
End Class