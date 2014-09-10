<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.tmrTimeOut = New System.Windows.Forms.Timer(Me.components)
        Me.cmsDownloadList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FormSkin1 = New 定时关机Ex.FormSkin()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.fbClose = New 定时关机Ex.FlatButton()
        Me.fbDownload = New 定时关机Ex.FlatButton()
        Me.wbStart = New System.Windows.Forms.WebBrowser()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrTimeOut
        '
        Me.tmrTimeOut.Enabled = True
        Me.tmrTimeOut.Interval = 1000
        '
        'cmsDownloadList
        '
        Me.cmsDownloadList.Name = "cmsDownloadList"
        Me.cmsDownloadList.Size = New System.Drawing.Size(61, 4)
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.ProgressBar1)
        Me.FormSkin1.Controls.Add(Me.fbClose)
        Me.FormSkin1.Controls.Add(Me.fbDownload)
        Me.FormSkin1.Controls.Add(Me.wbStart)
        Me.FormSkin1.Controls.Add(Me.txtDetails)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Orange
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(351, 213)
        Me.FormSkin1.TabIndex = 8
        Me.FormSkin1.Text = "正在检查更新..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(154, 12)
        Me.ProgressBar1.MarqueeAnimationSpeed = 3
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(157, 23)
        Me.ProgressBar1.Step = 3
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 2
        '
        'fbClose
        '
        Me.fbClose.BackColor = System.Drawing.Color.Transparent
        Me.fbClose.BaseColor = System.Drawing.Color.Orange
        Me.fbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbClose.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fbClose.Location = New System.Drawing.Point(0, 170)
        Me.fbClose.Name = "fbClose"
        Me.fbClose.Rounded = False
        Me.fbClose.Size = New System.Drawing.Size(62, 44)
        Me.fbClose.TabIndex = 9
        Me.fbClose.Text = "取消"
        Me.fbClose.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'fbDownload
        '
        Me.fbDownload.BackColor = System.Drawing.Color.Transparent
        Me.fbDownload.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fbDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbDownload.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fbDownload.Location = New System.Drawing.Point(248, 170)
        Me.fbDownload.Name = "fbDownload"
        Me.fbDownload.Rounded = False
        Me.fbDownload.Size = New System.Drawing.Size(106, 43)
        Me.fbDownload.TabIndex = 8
        Me.fbDownload.Text = "立即下载"
        Me.fbDownload.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.fbDownload.Visible = False
        '
        'wbStart
        '
        Me.wbStart.Location = New System.Drawing.Point(32, 230)
        Me.wbStart.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbStart.Name = "wbStart"
        Me.wbStart.ScriptErrorsSuppressed = True
        Me.wbStart.Size = New System.Drawing.Size(160, 94)
        Me.wbStart.TabIndex = 3
        Me.wbStart.Visible = False
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetails.ForeColor = System.Drawing.Color.White
        Me.txtDetails.Location = New System.Drawing.Point(0, 50)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.Size = New System.Drawing.Size(351, 130)
        Me.txtDetails.TabIndex = 4
        Me.txtDetails.Text = "请稍后......"
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 213)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "检查更新"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTimeOut As System.Windows.Forms.Timer
    Friend WithEvents cmsDownloadList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents wbStart As System.Windows.Forms.WebBrowser
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDetails As System.Windows.Forms.TextBox
    Friend WithEvents FormSkin1 As 定时关机Ex.FormSkin
    Friend WithEvents fbDownload As 定时关机Ex.FlatButton
    Friend WithEvents fbClose As 定时关机Ex.FlatButton
End Class
