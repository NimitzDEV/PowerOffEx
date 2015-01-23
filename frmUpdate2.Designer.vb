<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate2
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
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnDonload = New System.Windows.Forms.Button()
        Me.lbCheckStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOfficialSite = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(193, 63)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnDetails.TabIndex = 42
        Me.btnDetails.Text = "更新详情"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnDonload
        '
        Me.btnDonload.Location = New System.Drawing.Point(274, 63)
        Me.btnDonload.Name = "btnDonload"
        Me.btnDonload.Size = New System.Drawing.Size(75, 23)
        Me.btnDonload.TabIndex = 41
        Me.btnDonload.Text = "下载新版"
        Me.btnDonload.UseVisualStyleBackColor = True
        '
        'lbCheckStatus
        '
        Me.lbCheckStatus.AutoSize = True
        Me.lbCheckStatus.Location = New System.Drawing.Point(6, 68)
        Me.lbCheckStatus.Name = "lbCheckStatus"
        Me.lbCheckStatus.Size = New System.Drawing.Size(11, 12)
        Me.lbCheckStatus.TabIndex = 40
        Me.lbCheckStatus.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 12)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nimitz Software Developments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 39)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "NimitzDEV"
        '
        'btnOfficialSite
        '
        Me.btnOfficialSite.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOfficialSite.FlatAppearance.BorderSize = 0
        Me.btnOfficialSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficialSite.ForeColor = System.Drawing.Color.White
        Me.btnOfficialSite.Image = Global.定时关机Ex.My.Resources.Resources.off
        Me.btnOfficialSite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOfficialSite.Location = New System.Drawing.Point(243, 9)
        Me.btnOfficialSite.Name = "btnOfficialSite"
        Me.btnOfficialSite.Size = New System.Drawing.Size(106, 48)
        Me.btnOfficialSite.TabIndex = 39
        Me.btnOfficialSite.Text = "访问官网"
        Me.btnOfficialSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOfficialSite.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.定时关机Ex.My.Resources.Resources.n_48
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'frmUpdate2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 92)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnDonload)
        Me.Controls.Add(Me.lbCheckStatus)
        Me.Controls.Add(Me.btnOfficialSite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdate2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于与更新"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents btnDonload As System.Windows.Forms.Button
    Friend WithEvents lbCheckStatus As System.Windows.Forms.Label
    Friend WithEvents btnOfficialSite As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
