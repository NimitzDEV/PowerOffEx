Public Class frmUpdate
    Dim docString As String
    Dim versionString As String
    Dim linkBaidu As String
    Dim linkFeifan As String
    Dim updateString As String
    Public timeout As Integer = 20

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 128
        Me.Top = frmMain.Top
        wbStart.Navigate("http://nimitzdev.free3v.net/update/update_dsgjex.txt")
    End Sub

    Private Sub wbStart_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbStart.DocumentCompleted
        Dim gs() As String = (From mt As HtmlElement In wbStart.Document.Links Select System.Text.RegularExpressions.Regex.Match(mt.OuterHtml, "http://[^\x22 >]+").Value).ToArray
        wbInfo.Navigate(gs(0))
    End Sub

    Private Sub wbInfo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbInfo.DocumentCompleted
        docString = wbInfo.DocumentText
        versionString = Split(docString, "%%%%")(1).Trim
        linkBaidu = Split(docString, "%%%%")(3).Trim
        linkFeifan = Split(docString, "%%%%")(4).Trim
        updateString = Split(docString, "%%%%")(2).Trim
        detectUpdate()
    End Sub

    Private Sub detectUpdate()
        If isNew() = False Then
            ProgressBar1.Visible = False
            lbStatus.Text = "当前已经是最新版本 （" & Application.ProductVersion & "）"
            PictureBox1.Image = My.Resources.uptodate64px
        Else
            Me.Height = 247
            txtDetails.Visible = True
            txtDetails.Text = updateString
            PictureBox1.Image = My.Resources.new64px
            lbStatus.Text = "检测到新的版本可以下载！" & vbCrLf & "- 新的版本：" & versionString & vbCrLf & "- 当前版本：" & Application.ProductVersion
            If linkBaidu <> "" Then btnBaidu.Enabled = True
            If linkFeifan <> "" Then btnFeifan.Enabled = True
        End If
        btnClose.Text = "关闭"
        tmrTimeOut.Enabled = False
    End Sub

    Private Function isNew() As Boolean
        For i = 0 To 3
            If Int(Split(versionString, ".")(i)) > Int(Split(Application.ProductVersion, ".")(i)) Then
                Return True
            ElseIf Int(Split(versionString, ".")(i)) < Int(Split(Application.ProductVersion, ".")(i)) Then
                Return False
            End If
        Next
        Return False
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tmrTimeOut_Tick(sender As Object, e As EventArgs) Handles tmrTimeOut.Tick
        timeout -= 1
        If timeout < 0 Then
            wbStart.Stop()
            wbInfo.Stop()
            tmrTimeOut.Enabled = False
            MsgBox("与服务器的连接超时" & vbCrLf & "建议您重试即可")
            Me.Close()
        End If
    End Sub

    Private Sub btnBaidu_Click(sender As Object, e As EventArgs) Handles btnBaidu.Click
        Process.Start(linkBaidu)
    End Sub

    Private Sub btnFeifan_Click(sender As Object, e As EventArgs) Handles btnFeifan.Click
        Process.Start(linkFeifan)
    End Sub
End Class