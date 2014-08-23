<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVolCtrl4XP
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
        Me.nudHOUR = New System.Windows.Forms.NumericUpDown()
        Me.nudMIN = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbMaster = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbCurrent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        CType(Me.nudHOUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudHOUR
        '
        Me.nudHOUR.Location = New System.Drawing.Point(206, 112)
        Me.nudHOUR.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudHOUR.Name = "nudHOUR"
        Me.nudHOUR.Size = New System.Drawing.Size(40, 21)
        Me.nudHOUR.TabIndex = 35
        '
        'nudMIN
        '
        Me.nudMIN.Location = New System.Drawing.Point(275, 112)
        Me.nudMIN.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMIN.Name = "nudMIN"
        Me.nudMIN.Size = New System.Drawing.Size(40, 21)
        Me.nudMIN.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "分"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "点"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "生效时间："
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(329, 45)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "目前这个版本是为XP用户独立设计的，XP用户版本的音量控制只能实现降低百分比设置。建议升级您的操作系统获得更好的体验。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 12)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "-----------------------------------------------"
        '
        'tbMaster
        '
        Me.tbMaster.Location = New System.Drawing.Point(9, 151)
        Me.tbMaster.Maximum = 100
        Me.tbMaster.Name = "tbMaster"
        Me.tbMaster.Size = New System.Drawing.Size(332, 45)
        Me.tbMaster.TabIndex = 31
        Me.tbMaster.TickFrequency = 5
        Me.tbMaster.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 41)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "本功能适用于喜欢看电视剧到深夜的用户，一般都会看着看着就睡着了，为了防止深夜的时候声音过大打扰别人，可以使用本功能实现自动深夜音量调整"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(12, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 12)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "-----------------------------------------------"
        '
        'lbCurrent
        '
        Me.lbCurrent.AutoSize = True
        Me.lbCurrent.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbCurrent.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbCurrent.Location = New System.Drawing.Point(204, 199)
        Me.lbCurrent.Name = "lbCurrent"
        Me.lbCurrent.Size = New System.Drawing.Size(117, 12)
        Me.lbCurrent.TabIndex = 40
        Me.lbCurrent.Text = "当前设置：降低 0%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(12, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(334, 12)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "-----------------------------------------------"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(190, 226)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 22)
        Me.btnNo.TabIndex = 43
        Me.btnNo.Text = "取消"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(271, 226)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 22)
        Me.btnYes.TabIndex = 42
        Me.btnYes.Text = "确认"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'frmVolCtrl4XP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbCurrent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudHOUR)
        Me.Controls.Add(Me.nudMIN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMaster)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVolCtrl4XP"
        Me.Text = "深夜音量控制（XP系统版）"
        CType(Me.nudHOUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudHOUR As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMIN As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbMaster As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbCurrent As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button
End Class
