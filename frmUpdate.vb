Public Class frmUpdate
    Dim docString As String
    Dim versionString As String
    Dim linkString As String
    Dim updateString As String
    Dim spliter() As String = {"≠"}
    Public timeout As Integer = 20

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Height = 128
        'Me.Top = frmMain.Top
        Me.Height = frmMain.Height
        Me.Width = frmMain.Width
        Me.Top = frmMain.Top
        Me.Left = frmMain.Left
        ProgressBar1.Top = (Me.Height - ProgressBar1.Height) / 2
        ProgressBar1.Left = (Me.Width - ProgressBar1.Width) / 2
        txtDetails.Width = Me.Width
        'ProgressBar1.Left = Me.Width - ProgressBar1.Width
        fbDownload.Left = Me.Width - fbDownload.Width
        fbDownload.Top = Me.Height - fbDownload.Height
        fbClose.Top = fbDownload.Top
        txtDetails.Height = Me.Height - 50 - fbDownload.Height
        fbClose.Width = Me.Width / 2
        fbDownload.Left = Me.Width / 2
        fbDownload.Width = Me.Width / 2
        wbStart.Navigate("http://nimitzdev.free3v.net/update/update_dsgjex.html")
    End Sub

    Private Sub wbStart_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbStart.DocumentCompleted
        'Dim gs() As String = (From mt As HtmlElement In wbStart.Document.Links Select System.Text.RegularExpressions.Regex.Match(mt.OuterHtml, "http://[^\x22 >]+").Value).ToArray
        'If gs.Count = 0 Then
        '    MsgBox("噢~真不好意思~服务器打了一下小瞌睡，重新试一次叫醒她")
        '    Me.Close()
        '    Exit Sub
        'End If
        'wbInfo.Navigate(gs(0))
        docString = New System.IO.StreamReader(wbStart.DocumentStream, System.Text.Encoding.Default).ReadToEnd
        versionString = Split(docString, "≡")(1).Trim
        updateString = Split(docString, "≡")(2).Trim
        linkString = Split(docString, "≡")(3).Trim
        detectUpdate()
        ProgressBar1.Visible = False
        fbClose.Text = "关闭"
        fbClose.Refresh()
    End Sub

    Private Sub detectUpdate()
        If isNew() = False Then
            ProgressBar1.Visible = False
            txtDetails.Text = "当前已经是最新版本!" & vbCrLf & Application.ProductVersion
            FormSkin1.Text = "OK！"
            FormSkin1.FlatColor = Color.DodgerBlue
            FormSkin1.Refresh()
            'lbStatus.ForeColor = Color.DodgerBlue
            'btnClose.Top = 51
            'PictureBox1.Image = My.Resources.uptodate64px
        Else
            fbDownload.Visible = True
            If listLoaded() = True Then
                fbDownload.Enabled = True
            Else
                fbDownload.Enabled = False
                fbDownload.Text = "无法下载"
                fbDownload.Refresh()
            End If
            txtDetails.ScrollBars = ScrollBars.Vertical
            'Me.Height = 260
            'txtDetails.Visible = True
            'txtDetails.Text = updateString
            txtDetails.Text = "当前版本：" & Application.ProductVersion & vbCrLf _
                & "新的版本：" & versionString & vbCrLf & vbCrLf & updateString
            'PictureBox1.Image = My.Resources.new64px
            FormSkin1.Text = "检测到新的版本可以下载！"
            FormSkin1.FlatColor = Color.Red
            FormSkin1.Refresh()
            ' & vbCrLf & "- 新的版本：" & versionString & vbCrLf & "- 当前版本：" & Application.ProductVersion
            'lbStatus.ForeColor = Color.Green
        End If
        'btnClose.Text = "关闭"
        tmrTimeOut.Enabled = False
        Me.Refresh()
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

    Private Function listLoaded() As Boolean
        Dim downloadList() As String
        If linkString = "" Then Return False
        Try
            downloadList = linkString.Split(spliter, StringSplitOptions.RemoveEmptyEntries)
            For i = 0 To downloadList.Count - 1
                cmsDownloadList.Items.Add(Split(downloadList(i), "∫")(0), _
                               Nothing, AddressOf downloadClickHandler).Tag = Split(downloadList(i), "∫")(1)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub downloadClickHandler(sender As Object, e As EventArgs)
        Process.Start(sender.tag)
    End Sub

    Private Sub tmrTimeOut_Tick(sender As Object, e As EventArgs) Handles tmrTimeOut.Tick
        timeout -= 1
        If timeout < 0 Then
            wbStart.Stop()
            tmrTimeOut.Enabled = False
            MsgBox("与服务器的连接超时" & vbCrLf & "建议您重试即可")
            Me.Close()
        End If
    End Sub




    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles fbDownload.Click
        cmsDownloadList.Show(fbDownload, 0, fbDownload.Height)
    End Sub

    Private Sub fbClose_Click(sender As Object, e As EventArgs) Handles fbClose.Click
        Me.Close()
    End Sub
End Class