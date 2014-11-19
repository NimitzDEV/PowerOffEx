<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTips
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
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.llbMore = New System.Windows.Forms.LinkLabel()
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbInfo
        '
        Me.lbInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbInfo.ForeColor = System.Drawing.Color.White
        Me.lbInfo.Location = New System.Drawing.Point(12, 9)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(297, 42)
        Me.lbInfo.TabIndex = 0
        '
        'llbMore
        '
        Me.llbMore.AutoSize = True
        Me.llbMore.BackColor = System.Drawing.Color.Transparent
        Me.llbMore.Location = New System.Drawing.Point(238, 39)
        Me.llbMore.Name = "llbMore"
        Me.llbMore.Size = New System.Drawing.Size(71, 12)
        Me.llbMore.TabIndex = 1
        Me.llbMore.TabStop = True
        Me.llbMore.Text = "更多内容..."
        '
        'tmrAnimation
        '
        Me.tmrAnimation.Interval = 10
        '
        'frmTips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 60)
        Me.Controls.Add(Me.llbMore)
        Me.Controls.Add(Me.lbInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTips"
        Me.ShowInTaskbar = False
        Me.Text = "frmTips"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents llbMore As System.Windows.Forms.LinkLabel
    Friend WithEvents tmrAnimation As System.Windows.Forms.Timer
End Class
