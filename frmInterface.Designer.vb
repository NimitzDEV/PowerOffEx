﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterface
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterface))
        Me.notifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAutoHide = New System.Windows.Forms.Timer(Me.components)
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.cmsRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.延长时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.remainTip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QqqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrChargeAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUIFresh = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheckTv = New System.Windows.Forms.Timer(Me.components)
        Me.tmrVol = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReminder = New System.Windows.Forms.Timer(Me.components)
        Me.tmrProgressDrawer = New System.Windows.Forms.Timer(Me.components)
        Me.cmsInterfaceMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.加时ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add10min = New System.Windows.Forms.ToolStripMenuItem()
        Me.add20min = New System.Windows.Forms.ToolStripMenuItem()
        Me.add30min = New System.Windows.Forms.ToolStripMenuItem()
        Me.add60min = New System.Windows.Forms.ToolStripMenuItem()
        Me.add120min = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.返回ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.隐藏ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.outAnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimeMode = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBatteryMode = New System.Windows.Forms.Timer(Me.components)
        Me.tmrVChecker = New System.Windows.Forms.Timer(Me.components)
        Me.pbStatus = New System.Windows.Forms.PictureBox()
        Me.llbMore = New System.Windows.Forms.LinkLabel()
        Me.cmsRightClick.SuspendLayout()
        Me.cmsInterfaceMenu.SuspendLayout()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notifyIcon
        '
        Me.notifyIcon.Icon = CType(resources.GetObject("notifyIcon.Icon"), System.Drawing.Icon)
        Me.notifyIcon.Text = "定时关机Ex"
        Me.notifyIcon.Visible = True
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 5
        '
        'tmrAutoHide
        '
        Me.tmrAutoHide.Enabled = True
        Me.tmrAutoHide.Interval = 3000
        '
        'btnMenu
        '
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMenu.Location = New System.Drawing.Point(250, 367)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(60, 23)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "≡ 菜单"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'cmsRightClick
        '
        Me.cmsRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出ToolStripMenuItem, Me.ToolStripMenuItem1, Me.延长时间ToolStripMenuItem, Me.remainTip, Me.ToolStripMenuItem2, Me.QqqToolStripMenuItem})
        Me.cmsRightClick.Name = "cmsRightClick"
        Me.cmsRightClick.Size = New System.Drawing.Size(182, 120)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(178, 6)
        '
        '延长时间ToolStripMenuItem
        '
        Me.延长时间ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add10, Me.add20, Me.add50, Me.add1, Me.add2})
        Me.延长时间ToolStripMenuItem.Name = "延长时间ToolStripMenuItem"
        Me.延长时间ToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.延长时间ToolStripMenuItem.Text = "延长时间"
        '
        'add10
        '
        Me.add10.Name = "add10"
        Me.add10.Size = New System.Drawing.Size(114, 22)
        Me.add10.Text = "10分钟"
        '
        'add20
        '
        Me.add20.Name = "add20"
        Me.add20.Size = New System.Drawing.Size(114, 22)
        Me.add20.Text = "20分钟"
        '
        'add50
        '
        Me.add50.Name = "add50"
        Me.add50.Size = New System.Drawing.Size(114, 22)
        Me.add50.Text = "30分钟"
        '
        'add1
        '
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(114, 22)
        Me.add1.Text = "1小时"
        '
        'add2
        '
        Me.add2.Name = "add2"
        Me.add2.Size = New System.Drawing.Size(114, 22)
        Me.add2.Text = "2小时"
        '
        'remainTip
        '
        Me.remainTip.BackColor = System.Drawing.Color.DodgerBlue
        Me.remainTip.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.remainTip.ForeColor = System.Drawing.Color.White
        Me.remainTip.Name = "remainTip"
        Me.remainTip.Size = New System.Drawing.Size(181, 26)
        Me.remainTip.Text = "当前剩余"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(178, 6)
        '
        'QqqToolStripMenuItem
        '
        Me.QqqToolStripMenuItem.Name = "QqqToolStripMenuItem"
        Me.QqqToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.QqqToolStripMenuItem.Text = "显示/隐藏 详细界面"
        '
        'tmrChargeAnimate
        '
        Me.tmrChargeAnimate.Interval = 500
        '
        'tmrUIFresh
        '
        Me.tmrUIFresh.Enabled = True
        Me.tmrUIFresh.Interval = 5000
        '
        'tmrCheckTv
        '
        Me.tmrCheckTv.Interval = 5000
        '
        'tmrVol
        '
        Me.tmrVol.Interval = 30000
        '
        'tmrReminder
        '
        Me.tmrReminder.Interval = 5000
        '
        'tmrProgressDrawer
        '
        Me.tmrProgressDrawer.Enabled = True
        Me.tmrProgressDrawer.Interval = 200
        '
        'cmsInterfaceMenu
        '
        Me.cmsInterfaceMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.加时ToolStripMenuItem, Me.ToolStripMenuItem3, Me.返回ToolStripMenuItem, Me.退出ToolStripMenuItem1, Me.隐藏ToolStripMenuItem})
        Me.cmsInterfaceMenu.Name = "cmsInterfaceMenu"
        Me.cmsInterfaceMenu.Size = New System.Drawing.Size(101, 98)
        '
        '加时ToolStripMenuItem
        '
        Me.加时ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add10min, Me.add20min, Me.add30min, Me.add60min, Me.add120min})
        Me.加时ToolStripMenuItem.Name = "加时ToolStripMenuItem"
        Me.加时ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.加时ToolStripMenuItem.Text = "加时"
        '
        'add10min
        '
        Me.add10min.Name = "add10min"
        Me.add10min.Size = New System.Drawing.Size(114, 22)
        Me.add10min.Text = "10分钟"
        '
        'add20min
        '
        Me.add20min.Name = "add20min"
        Me.add20min.Size = New System.Drawing.Size(114, 22)
        Me.add20min.Text = "20分钟"
        '
        'add30min
        '
        Me.add30min.Name = "add30min"
        Me.add30min.Size = New System.Drawing.Size(114, 22)
        Me.add30min.Text = "30分钟"
        '
        'add60min
        '
        Me.add60min.Name = "add60min"
        Me.add60min.Size = New System.Drawing.Size(114, 22)
        Me.add60min.Text = "1小时"
        '
        'add120min
        '
        Me.add120min.Name = "add120min"
        Me.add120min.Size = New System.Drawing.Size(114, 22)
        Me.add120min.Text = "2小时"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(97, 6)
        '
        '返回ToolStripMenuItem
        '
        Me.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem"
        Me.返回ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.返回ToolStripMenuItem.Text = "返回"
        '
        '退出ToolStripMenuItem1
        '
        Me.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1"
        Me.退出ToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.退出ToolStripMenuItem1.Text = "退出"
        '
        '隐藏ToolStripMenuItem
        '
        Me.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem"
        Me.隐藏ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.隐藏ToolStripMenuItem.Text = "隐藏"
        '
        'outAnimationTimer
        '
        Me.outAnimationTimer.Interval = 5
        '
        'tmrTimeMode
        '
        Me.tmrTimeMode.Interval = 1000
        '
        'tmrBatteryMode
        '
        Me.tmrBatteryMode.Interval = 1000
        '
        'tmrVChecker
        '
        Me.tmrVChecker.Interval = 10000
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(0, 0)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(321, 400)
        Me.pbStatus.TabIndex = 7
        Me.pbStatus.TabStop = False
        '
        'llbMore
        '
        Me.llbMore.AutoSize = True
        Me.llbMore.BackColor = System.Drawing.Color.Transparent
        Me.llbMore.Location = New System.Drawing.Point(97, 119)
        Me.llbMore.Name = "llbMore"
        Me.llbMore.Size = New System.Drawing.Size(29, 12)
        Me.llbMore.TabIndex = 8
        Me.llbMore.TabStop = True
        Me.llbMore.Text = "More"
        Me.llbMore.Visible = False
        '
        'frmInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.llbMore)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.pbStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInterface"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.Text = "详细"
        Me.TopMost = True
        Me.cmsRightClick.ResumeLayout(False)
        Me.cmsInterfaceMenu.ResumeLayout(False)
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents notifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents animationTimer As System.Windows.Forms.Timer
    Friend WithEvents tmrAutoHide As System.Windows.Forms.Timer
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents cmsRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QqqToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 延长时间ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents remainTip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add50 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrChargeAnimate As System.Windows.Forms.Timer
    Friend WithEvents tmrUIFresh As System.Windows.Forms.Timer
    Friend WithEvents tmrCheckTv As System.Windows.Forms.Timer
    Friend WithEvents tmrVol As System.Windows.Forms.Timer
    Friend WithEvents tmrReminder As System.Windows.Forms.Timer
    Friend WithEvents pbStatus As System.Windows.Forms.PictureBox
    Friend WithEvents tmrProgressDrawer As System.Windows.Forms.Timer
    Friend WithEvents cmsInterfaceMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 加时ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 隐藏ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 返回ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add10min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add20min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add30min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add60min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add120min As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents outAnimationTimer As System.Windows.Forms.Timer
    Friend WithEvents tmrTimeMode As System.Windows.Forms.Timer
    Friend WithEvents tmrBatteryMode As System.Windows.Forms.Timer
    Friend WithEvents tmrVChecker As System.Windows.Forms.Timer
    Friend WithEvents llbMore As System.Windows.Forms.LinkLabel
End Class
