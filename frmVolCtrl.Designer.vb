<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVolCtrl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbCurrent = New System.Windows.Forms.Label()
        Me.tbMaster = New System.Windows.Forms.TrackBar()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pbMaster = New System.Windows.Forms.ProgressBar()
        Me.pbCurrent = New System.Windows.Forms.ProgressBar()
        Me.lbFull = New System.Windows.Forms.Label()
        Me.lbNow = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbOrigi = New System.Windows.Forms.Label()
        Me.lbLast = New System.Windows.Forms.Label()
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "本功能适用于喜欢看电视剧到深夜的用户，一般都会看着看着就睡着了，为了防止深夜的时候声音过大打扰别人，可以使用本功能实现自动深夜音量调整"
        '
        'lbCurrent
        '
        Me.lbCurrent.AutoSize = True
        Me.lbCurrent.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCurrent.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbCurrent.Location = New System.Drawing.Point(232, 167)
        Me.lbCurrent.Name = "lbCurrent"
        Me.lbCurrent.Size = New System.Drawing.Size(84, 12)
        Me.lbCurrent.TabIndex = 1
        Me.lbCurrent.Text = "当前音量：0%"
        '
        'tbMaster
        '
        Me.tbMaster.Location = New System.Drawing.Point(2, 157)
        Me.tbMaster.Maximum = 100
        Me.tbMaster.Name = "tbMaster"
        Me.tbMaster.Size = New System.Drawing.Size(224, 45)
        Me.tbMaster.TabIndex = 2
        Me.tbMaster.TickFrequency = 10
        Me.tbMaster.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(266, 272)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 22)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "确认"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(185, 272)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 22)
        Me.btnNo.TabIndex = 4
        Me.btnNo.Text = "取消"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(7, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(334, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "-----------------------------------------------"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'pbMaster
        '
        Me.pbMaster.Location = New System.Drawing.Point(14, 128)
        Me.pbMaster.Name = "pbMaster"
        Me.pbMaster.Size = New System.Drawing.Size(200, 23)
        Me.pbMaster.TabIndex = 16
        '
        'pbCurrent
        '
        Me.pbCurrent.Location = New System.Drawing.Point(14, 208)
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(200, 23)
        Me.pbCurrent.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbCurrent.TabIndex = 17
        '
        'lbFull
        '
        Me.lbFull.AutoSize = True
        Me.lbFull.ForeColor = System.Drawing.Color.Green
        Me.lbFull.Location = New System.Drawing.Point(232, 139)
        Me.lbFull.Name = "lbFull"
        Me.lbFull.Size = New System.Drawing.Size(41, 12)
        Me.lbFull.TabIndex = 18
        Me.lbFull.Text = "总音量"
        '
        'lbNow
        '
        Me.lbNow.AutoSize = True
        Me.lbNow.ForeColor = System.Drawing.Color.Green
        Me.lbNow.Location = New System.Drawing.Point(232, 219)
        Me.lbNow.Name = "lbNow"
        Me.lbNow.Size = New System.Drawing.Size(41, 12)
        Me.lbNow.TabIndex = 19
        Me.lbNow.Text = "总音量"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "-----------------------------------------------"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 41)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "当前为实时预览调整的音量大小，滑动滑杆调节到一个深夜的音量，觉得合适后点击确认即可保存设置。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "设置生效的时间是晚上11点"
        '
        'lbOrigi
        '
        Me.lbOrigi.AutoSize = True
        Me.lbOrigi.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbOrigi.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbOrigi.Location = New System.Drawing.Point(232, 179)
        Me.lbOrigi.Name = "lbOrigi"
        Me.lbOrigi.Size = New System.Drawing.Size(84, 12)
        Me.lbOrigi.TabIndex = 22
        Me.lbOrigi.Text = "原始音量：0%"
        '
        'lbLast
        '
        Me.lbLast.AutoSize = True
        Me.lbLast.ForeColor = System.Drawing.Color.Green
        Me.lbLast.Location = New System.Drawing.Point(232, 103)
        Me.lbLast.Name = "lbLast"
        Me.lbLast.Size = New System.Drawing.Size(41, 12)
        Me.lbLast.TabIndex = 23
        Me.lbLast.Text = "上一次"
        '
        'frmVolCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbLast)
        Me.Controls.Add(Me.lbOrigi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbNow)
        Me.Controls.Add(Me.lbFull)
        Me.Controls.Add(Me.pbCurrent)
        Me.Controls.Add(Me.pbMaster)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.tbMaster)
        Me.Controls.Add(Me.lbCurrent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVolCtrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "深夜音量调整"
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbCurrent As System.Windows.Forms.Label
    Friend WithEvents tbMaster As System.Windows.Forms.TrackBar
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbMaster As System.Windows.Forms.ProgressBar
    Friend WithEvents pbCurrent As System.Windows.Forms.ProgressBar
    Friend WithEvents lbFull As System.Windows.Forms.Label
    Friend WithEvents lbNow As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbOrigi As System.Windows.Forms.Label
    Friend WithEvents lbLast As System.Windows.Forms.Label
End Class
