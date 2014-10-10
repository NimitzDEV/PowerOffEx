Module mdNotify
    Public Sub showNotify(ByVal info As String, bgColor As Color)
        frmNotify.Show()
        frmNotify.Label1.Text = info
        frmNotify.BackColor = bgColor
        adjust()
    End Sub
    Public Sub adjust()
        With frmNotify
            Dim counter As Integer = 1
            .Label1.Visible = False
            Do
                .Label1.Font = New Font("Segou UI", counter)
                If .Label1.Width >= .ClientSize.Width Or .Label1.Height >= .ClientSize.Height Then
                    If counter - 5 > 1 Then counter -= 5
                    Exit Do
                End If
                If .Label1.Width < .ClientSize.Width And .Label1.Height < .ClientSize.Height Then
                    counter += 5
                End If
                Application.DoEvents()
            Loop
            .Label1.Font = New Font("Segou UI", counter)
            .Label1.Top = (frmNotify.Height - .Label1.Height) / 2
            .Label1.Left = (.Width - .Label1.Width) / 2
            .Label1.Visible = True
            Debug.Print(counter / .Width)
            Debug.Print(counter / .Height)
        End With
    End Sub
End Module
