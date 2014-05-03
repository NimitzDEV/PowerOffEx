<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.mainTick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAutoHide = New System.Windows.Forms.Timer(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmsRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.延长时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.add2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.自定义ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.remainTip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QqqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlNetworkConnection = New System.Windows.Forms.Panel()
        Me.lbConnectStatus = New System.Windows.Forms.Label()
        Me.pbConnections = New System.Windows.Forms.PictureBox()
        Me.pnlBattery = New System.Windows.Forms.Panel()
        Me.lbBatteryStatus = New System.Windows.Forms.Label()
        Me.pbBattery = New System.Windows.Forms.PictureBox()
        Me.tmrChargeAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrConnectionCheck = New System.Windows.Forms.Timer(Me.components)
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tmrCheckTv = New System.Windows.Forms.Timer(Me.components)
        Me.cmsRightClick.SuspendLayout()
        Me.pnlNetworkConnection.SuspendLayout()
        CType(Me.pbConnections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBattery.SuspendLayout()
        CType(Me.pbBattery, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbInfo
        '
        Me.lbInfo.AutoSize = True
        Me.lbInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbInfo.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbInfo.ForeColor = System.Drawing.Color.White
        Me.lbInfo.Location = New System.Drawing.Point(7, 176)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(93, 28)
        Me.lbInfo.TabIndex = 0
        Me.lbInfo.Text = "请稍后..."
        '
        'mainTick
        '
        Me.mainTick.Enabled = True
        Me.mainTick.Interval = 1000
        '
        'tmrAutoHide
        '
        Me.tmrAutoHide.Enabled = True
        Me.tmrAutoHide.Interval = 3000
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(175, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "返回"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cmsRightClick
        '
        Me.cmsRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出ToolStripMenuItem, Me.ToolStripMenuItem1, Me.延长时间ToolStripMenuItem, Me.remainTip, Me.ToolStripMenuItem2, Me.QqqToolStripMenuItem})
        Me.cmsRightClick.Name = "cmsRightClick"
        Me.cmsRightClick.Size = New System.Drawing.Size(180, 120)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        '延长时间ToolStripMenuItem
        '
        Me.延长时间ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add10, Me.add20, Me.add50, Me.add1, Me.add2, Me.ToolStripMenuItem3, Me.自定义ToolStripMenuItem})
        Me.延长时间ToolStripMenuItem.Name = "延长时间ToolStripMenuItem"
        Me.延长时间ToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.延长时间ToolStripMenuItem.Text = "延长时间"
        '
        'add10
        '
        Me.add10.Name = "add10"
        Me.add10.Size = New System.Drawing.Size(112, 22)
        Me.add10.Text = "10分钟"
        '
        'add20
        '
        Me.add20.Name = "add20"
        Me.add20.Size = New System.Drawing.Size(112, 22)
        Me.add20.Text = "20分钟"
        '
        'add50
        '
        Me.add50.Name = "add50"
        Me.add50.Size = New System.Drawing.Size(112, 22)
        Me.add50.Text = "50分钟"
        '
        'add1
        '
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(112, 22)
        Me.add1.Text = "1小时"
        '
        'add2
        '
        Me.add2.Name = "add2"
        Me.add2.Size = New System.Drawing.Size(112, 22)
        Me.add2.Text = "2小时"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(109, 6)
        '
        '自定义ToolStripMenuItem
        '
        Me.自定义ToolStripMenuItem.Name = "自定义ToolStripMenuItem"
        Me.自定义ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.自定义ToolStripMenuItem.Text = "自定义"
        '
        'remainTip
        '
        Me.remainTip.BackColor = System.Drawing.Color.Orange
        Me.remainTip.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.remainTip.ForeColor = System.Drawing.Color.White
        Me.remainTip.Name = "remainTip"
        Me.remainTip.Size = New System.Drawing.Size(179, 26)
        Me.remainTip.Text = "当前剩余"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 6)
        '
        'QqqToolStripMenuItem
        '
        Me.QqqToolStripMenuItem.Name = "QqqToolStripMenuItem"
        Me.QqqToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.QqqToolStripMenuItem.Text = "显示/隐藏 详细界面"
        '
        'pnlNetworkConnection
        '
        Me.pnlNetworkConnection.BackColor = System.Drawing.Color.Transparent
        Me.pnlNetworkConnection.Controls.Add(Me.lbConnectStatus)
        Me.pnlNetworkConnection.Controls.Add(Me.pbConnections)
        Me.pnlNetworkConnection.Location = New System.Drawing.Point(46, 45)
        Me.pnlNetworkConnection.Name = "pnlNetworkConnection"
        Me.pnlNetworkConnection.Size = New System.Drawing.Size(96, 128)
        Me.pnlNetworkConnection.TabIndex = 3
        '
        'lbConnectStatus
        '
        Me.lbConnectStatus.AutoSize = True
        Me.lbConnectStatus.Location = New System.Drawing.Point(30, 102)
        Me.lbConnectStatus.Name = "lbConnectStatus"
        Me.lbConnectStatus.Size = New System.Drawing.Size(41, 12)
        Me.lbConnectStatus.TabIndex = 1
        Me.lbConnectStatus.Text = "请稍后"
        '
        'pbConnections
        '
        Me.pbConnections.Image = Global.定时关机Ex.My.Resources.Resources.wire
        Me.pbConnections.Location = New System.Drawing.Point(0, 3)
        Me.pbConnections.Name = "pbConnections"
        Me.pbConnections.Size = New System.Drawing.Size(96, 96)
        Me.pbConnections.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbConnections.TabIndex = 0
        Me.pbConnections.TabStop = False
        '
        'pnlBattery
        '
        Me.pnlBattery.BackColor = System.Drawing.Color.Transparent
        Me.pnlBattery.Controls.Add(Me.lbBatteryStatus)
        Me.pnlBattery.Controls.Add(Me.pbBattery)
        Me.pnlBattery.Location = New System.Drawing.Point(148, 45)
        Me.pnlBattery.Name = "pnlBattery"
        Me.pnlBattery.Size = New System.Drawing.Size(98, 128)
        Me.pnlBattery.TabIndex = 4
        '
        'lbBatteryStatus
        '
        Me.lbBatteryStatus.AutoSize = True
        Me.lbBatteryStatus.Location = New System.Drawing.Point(25, 102)
        Me.lbBatteryStatus.Name = "lbBatteryStatus"
        Me.lbBatteryStatus.Size = New System.Drawing.Size(41, 12)
        Me.lbBatteryStatus.TabIndex = 1
        Me.lbBatteryStatus.Text = "请稍后"
        '
        'pbBattery
        '
        Me.pbBattery.Image = Global.定时关机Ex.My.Resources.Resources.fullbattery
        Me.pbBattery.Location = New System.Drawing.Point(0, 3)
        Me.pbBattery.Name = "pbBattery"
        Me.pbBattery.Size = New System.Drawing.Size(96, 96)
        Me.pbBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbBattery.TabIndex = 0
        Me.pbBattery.TabStop = False
        '
        'tmrChargeAnimate
        '
        Me.tmrChargeAnimate.Interval = 500
        '
        'tmrConnectionCheck
        '
        Me.tmrConnectionCheck.Enabled = True
        Me.tmrConnectionCheck.Interval = 9000
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(118, 12)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(51, 23)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "隐藏"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(51, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "加时"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tmrCheckTv
        '
        Me.tmrCheckTv.Interval = 5000
        '
        'frmInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.pnlBattery)
        Me.Controls.Add(Me.pnlNetworkConnection)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lbInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInterface"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.Text = "详细"
        Me.TopMost = True
        Me.cmsRightClick.ResumeLayout(False)
        Me.pnlNetworkConnection.ResumeLayout(False)
        Me.pnlNetworkConnection.PerformLayout()
        CType(Me.pbConnections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBattery.ResumeLayout(False)
        Me.pnlBattery.PerformLayout()
        CType(Me.pbBattery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents notifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents animationTimer As System.Windows.Forms.Timer
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents mainTick As System.Windows.Forms.Timer
    Friend WithEvents tmrAutoHide As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
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
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 自定义ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlNetworkConnection As System.Windows.Forms.Panel
    Friend WithEvents pbConnections As System.Windows.Forms.PictureBox
    Friend WithEvents lbConnectStatus As System.Windows.Forms.Label
    Friend WithEvents pnlBattery As System.Windows.Forms.Panel
    Friend WithEvents lbBatteryStatus As System.Windows.Forms.Label
    Friend WithEvents pbBattery As System.Windows.Forms.PictureBox
    Friend WithEvents tmrChargeAnimate As System.Windows.Forms.Timer
    Friend WithEvents tmrConnectionCheck As System.Windows.Forms.Timer
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tmrCheckTv As System.Windows.Forms.Timer
End Class
