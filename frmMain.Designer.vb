﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.rbSetTime = New System.Windows.Forms.RadioButton()
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.nudMinute = New System.Windows.Forms.NumericUpDown()
        Me.lbTip1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.llbVolume = New System.Windows.Forms.LinkLabel()
        Me.cbVol = New System.Windows.Forms.CheckBox()
        Me.llbHistory = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbTip2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudBattery = New System.Windows.Forms.NumericUpDown()
        Me.cbRecordTvProgress = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbEvents = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.llbAbout = New System.Windows.Forms.LinkLabel()
        Me.llbUpdate = New System.Windows.Forms.LinkLabel()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbSetTime
        '
        Me.rbSetTime.AutoSize = True
        Me.rbSetTime.Checked = True
        Me.rbSetTime.Location = New System.Drawing.Point(10, 18)
        Me.rbSetTime.Name = "rbSetTime"
        Me.rbSetTime.Size = New System.Drawing.Size(95, 16)
        Me.rbSetTime.TabIndex = 0
        Me.rbSetTime.TabStop = True
        Me.rbSetTime.Text = "设定时间关机"
        Me.rbSetTime.UseVisualStyleBackColor = True
        '
        'nudHour
        '
        Me.nudHour.Location = New System.Drawing.Point(29, 42)
        Me.nudHour.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(41, 21)
        Me.nudHour.TabIndex = 1
        Me.nudHour.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudMinute
        '
        Me.nudMinute.Location = New System.Drawing.Point(110, 42)
        Me.nudMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinute.Name = "nudMinute"
        Me.nudMinute.Size = New System.Drawing.Size(41, 21)
        Me.nudMinute.TabIndex = 2
        '
        'lbTip1
        '
        Me.lbTip1.AutoSize = True
        Me.lbTip1.ForeColor = System.Drawing.Color.Tomato
        Me.lbTip1.Location = New System.Drawing.Point(108, 20)
        Me.lbTip1.Name = "lbTip1"
        Me.lbTip1.Size = New System.Drawing.Size(137, 12)
        Me.lbTip1.TabIndex = 3
        Me.lbTip1.Text = "在设定的时间长度内关机"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "小时"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "分钟"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.llbVolume)
        Me.GroupBox1.Controls.Add(Me.cbVol)
        Me.GroupBox1.Controls.Add(Me.llbHistory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbTip2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.nudBattery)
        Me.GroupBox1.Controls.Add(Me.cbRecordTvProgress)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbEvents)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbSetTime)
        Me.GroupBox1.Controls.Add(Me.nudHour)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nudMinute)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbTip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 229)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'llbVolume
        '
        Me.llbVolume.AutoSize = True
        Me.llbVolume.Location = New System.Drawing.Point(136, 197)
        Me.llbVolume.Name = "llbVolume"
        Me.llbVolume.Size = New System.Drawing.Size(29, 12)
        Me.llbVolume.TabIndex = 16
        Me.llbVolume.TabStop = True
        Me.llbVolume.Text = "设置"
        '
        'cbVol
        '
        Me.cbVol.AutoSize = True
        Me.cbVol.Location = New System.Drawing.Point(10, 197)
        Me.cbVol.Name = "cbVol"
        Me.cbVol.Size = New System.Drawing.Size(120, 16)
        Me.cbVol.TabIndex = 15
        Me.cbVol.Text = "深夜降低电脑音量"
        Me.cbVol.UseVisualStyleBackColor = True
        '
        'llbHistory
        '
        Me.llbHistory.AutoSize = True
        Me.llbHistory.Location = New System.Drawing.Point(172, 175)
        Me.llbHistory.Name = "llbHistory"
        Me.llbHistory.Size = New System.Drawing.Size(53, 12)
        Me.llbHistory.TabIndex = 11
        Me.llbHistory.TabStop = True
        Me.llbHistory.Text = "观看记录"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(6, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(418, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "-----------------------------------------------------------"
        '
        'lbTip2
        '
        Me.lbTip2.AutoSize = True
        Me.lbTip2.Location = New System.Drawing.Point(141, 129)
        Me.lbTip2.Name = "lbTip2"
        Me.lbTip2.Size = New System.Drawing.Size(29, 12)
        Me.lbTip2.TabIndex = 13
        Me.lbTip2.Text = "% 时"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Tomato
        Me.Label5.Location = New System.Drawing.Point(26, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "电量少于"
        '
        'nudBattery
        '
        Me.nudBattery.Location = New System.Drawing.Point(85, 127)
        Me.nudBattery.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudBattery.Name = "nudBattery"
        Me.nudBattery.Size = New System.Drawing.Size(50, 21)
        Me.nudBattery.TabIndex = 11
        Me.nudBattery.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'cbRecordTvProgress
        '
        Me.cbRecordTvProgress.AutoSize = True
        Me.cbRecordTvProgress.Location = New System.Drawing.Point(10, 175)
        Me.cbRecordTvProgress.Name = "cbRecordTvProgress"
        Me.cbRecordTvProgress.Size = New System.Drawing.Size(156, 16)
        Me.cbRecordTvProgress.TabIndex = 6
        Me.cbRecordTvProgress.Text = "同时记录电视剧观看进度"
        Me.cbRecordTvProgress.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(111, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "在设置的电量时关机（仅笔记本有效）"
        '
        'rbEvents
        '
        Me.rbEvents.AutoSize = True
        Me.rbEvents.Enabled = False
        Me.rbEvents.Location = New System.Drawing.Point(10, 98)
        Me.rbEvents.Name = "rbEvents"
        Me.rbEvents.Size = New System.Drawing.Size(95, 16)
        Me.rbEvents.TabIndex = 9
        Me.rbEvents.Text = "特定条件关机"
        Me.rbEvents.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(418, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "-----------------------------------------------------------"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(370, 237)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 8
        Me.btnSet.Text = " 开始"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'llbAbout
        '
        Me.llbAbout.AutoSize = True
        Me.llbAbout.Location = New System.Drawing.Point(335, 243)
        Me.llbAbout.Name = "llbAbout"
        Me.llbAbout.Size = New System.Drawing.Size(29, 12)
        Me.llbAbout.TabIndex = 9
        Me.llbAbout.TabStop = True
        Me.llbAbout.Text = "关于"
        '
        'llbUpdate
        '
        Me.llbUpdate.AutoSize = True
        Me.llbUpdate.Location = New System.Drawing.Point(10, 242)
        Me.llbUpdate.Name = "llbUpdate"
        Me.llbUpdate.Size = New System.Drawing.Size(65, 12)
        Me.llbUpdate.TabIndex = 10
        Me.llbUpdate.TabStop = True
        Me.llbUpdate.Text = "查找新版本"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 269)
        Me.Controls.Add(Me.llbUpdate)
        Me.Controls.Add(Me.llbAbout)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudBattery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbSetTime As System.Windows.Forms.RadioButton
    Friend WithEvents nudHour As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMinute As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbTip1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbEvents As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbTip2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudBattery As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbRecordTvProgress As System.Windows.Forms.CheckBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents llbAbout As System.Windows.Forms.LinkLabel
    Friend WithEvents llbHistory As System.Windows.Forms.LinkLabel
    Friend WithEvents cbVol As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents llbVolume As System.Windows.Forms.LinkLabel
    Friend WithEvents llbUpdate As System.Windows.Forms.LinkLabel

End Class
