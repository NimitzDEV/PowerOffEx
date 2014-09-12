<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmsSelect = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiContinue = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsMode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCountdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSetTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTime = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.fsbTime = New 定时关机Ex.FlatStatusBar()
        Me.FormSkin1 = New 定时关机Ex.FormSkin()
        Me.FlatAlertBox1 = New 定时关机Ex.FlatAlertBox()
        Me.FlatMini1 = New 定时关机Ex.FlatMini()
        Me.FlatTabControl1 = New 定时关机Ex.FlatTabControl()
        Me.tbTimeMode = New System.Windows.Forms.TabPage()
        Me.pnlSetTime = New System.Windows.Forms.Panel()
        Me.llbDay = New System.Windows.Forms.LinkLabel()
        Me.fnSTMinute = New 定时关机Ex.FlatNumeric()
        Me.FlatLabel11 = New 定时关机Ex.FlatLabel()
        Me.fnSTHour = New 定时关机Ex.FlatNumeric()
        Me.FlatLabel12 = New 定时关机Ex.FlatLabel()
        Me.llbMode = New System.Windows.Forms.LinkLabel()
        Me.pnlCountdown = New System.Windows.Forms.Panel()
        Me.fNMinute = New 定时关机Ex.FlatNumeric()
        Me.FlatLabel4 = New 定时关机Ex.FlatLabel()
        Me.fNHour = New 定时关机Ex.FlatNumeric()
        Me.FlatLabel3 = New 定时关机Ex.FlatLabel()
        Me.FlatLabel2 = New 定时关机Ex.FlatLabel()
        Me.FlatLabel1 = New 定时关机Ex.FlatLabel()
        Me.btnStart = New 定时关机Ex.FlatButton()
        Me.tbBatteryMode = New System.Windows.Forms.TabPage()
        Me.FlatLabel5 = New 定时关机Ex.FlatLabel()
        Me.fgbError = New 定时关机Ex.FlatGroupBox()
        Me.FlatLabel7 = New 定时关机Ex.FlatLabel()
        Me.lbBatterySettings = New 定时关机Ex.FlatLabel()
        Me.FlatLabel6 = New 定时关机Ex.FlatLabel()
        Me.ftbBattery = New 定时关机Ex.FlatTrackBar()
        Me.FlatButton1 = New 定时关机Ex.FlatButton()
        Me.fpbCurrentBattery = New 定时关机Ex.FlatProgressBar()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.help4REMINDER = New System.Windows.Forms.PictureBox()
        Me.help4VOL = New System.Windows.Forms.PictureBox()
        Me.help4TVP = New System.Windows.Forms.PictureBox()
        Me.fbVolSettings = New 定时关机Ex.FlatButton()
        Me.fbHistory = New 定时关机Ex.FlatButton()
        Me.FlatLabel10 = New 定时关机Ex.FlatLabel()
        Me.FlatLabel9 = New 定时关机Ex.FlatLabel()
        Me.FlatLabel8 = New 定时关机Ex.FlatLabel()
        Me.ftReminder = New 定时关机Ex.FlatToggle()
        Me.ftVol = New 定时关机Ex.FlatToggle()
        Me.ftRecord = New 定时关机Ex.FlatToggle()
        Me.fbAbout = New 定时关机Ex.FlatButton()
        Me.btnFindNew = New 定时关机Ex.FlatButton()
        Me.FlatClose1 = New 定时关机Ex.FlatClose()
        Me.FlatContextMenuStrip1 = New 定时关机Ex.FlatContextMenuStrip()
        Me.高规格ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsSelect.SuspendLayout()
        Me.cmsMode.SuspendLayout()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.tbTimeMode.SuspendLayout()
        Me.pnlSetTime.SuspendLayout()
        Me.pnlCountdown.SuspendLayout()
        Me.tbBatteryMode.SuspendLayout()
        Me.fgbError.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        CType(Me.help4REMINDER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.help4VOL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.help4TVP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsSelect
        '
        Me.cmsSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiRefresh, Me.ToolStripMenuItem1, Me.tsmiContinue})
        Me.cmsSelect.Name = "cmsSelect"
        Me.cmsSelect.Size = New System.Drawing.Size(125, 54)
        '
        'tsmiRefresh
        '
        Me.tsmiRefresh.Name = "tsmiRefresh"
        Me.tsmiRefresh.Size = New System.Drawing.Size(124, 22)
        Me.tsmiRefresh.Text = "重新开始"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 6)
        '
        'tsmiContinue
        '
        Me.tsmiContinue.Name = "tsmiContinue"
        Me.tsmiContinue.Size = New System.Drawing.Size(124, 22)
        Me.tsmiContinue.Text = "继续刚才"
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'cmsMode
        '
        Me.cmsMode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCountdown, Me.tsmiSetTime})
        Me.cmsMode.Name = "cmsMode"
        Me.cmsMode.Size = New System.Drawing.Size(125, 48)
        '
        'tsmiCountdown
        '
        Me.tsmiCountdown.Name = "tsmiCountdown"
        Me.tsmiCountdown.Size = New System.Drawing.Size(124, 22)
        Me.tsmiCountdown.Text = "固定时长"
        '
        'tsmiSetTime
        '
        Me.tsmiSetTime.Name = "tsmiSetTime"
        Me.tsmiSetTime.Size = New System.Drawing.Size(124, 22)
        Me.tsmiSetTime.Text = "确定时刻"
        '
        'cmsTime
        '
        Me.cmsTime.Name = "cmsTime"
        Me.cmsTime.Size = New System.Drawing.Size(61, 4)
        '
        'fsbTime
        '
        Me.fsbTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fsbTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fsbTime.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.fsbTime.ForeColor = System.Drawing.Color.White
        Me.fsbTime.Location = New System.Drawing.Point(0, 308)
        Me.fsbTime.Name = "fsbTime"
        Me.fsbTime.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fsbTime.ShowTimeDate = False
        Me.fsbTime.Size = New System.Drawing.Size(390, 23)
        Me.fsbTime.TabIndex = 12
        Me.fsbTime.Text = "现在时间"
        Me.fsbTime.TextColor = System.Drawing.Color.White
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatAlertBox1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.Orange
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(390, 331)
        Me.FormSkin1.TabIndex = 11
        Me.FormSkin1.Text = "FormSkin1"
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = 定时关机Ex.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(360, 36)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(384, 42)
        Me.FlatAlertBox1.TabIndex = 15
        Me.FlatAlertBox1.Text = "FlatAlertBox1"
        Me.FlatAlertBox1.Visible = False
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(341, 16)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 16
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.tbTimeMode)
        Me.FlatTabControl1.Controls.Add(Me.tbBatteryMode)
        Me.FlatTabControl1.Controls.Add(Me.tbOptions)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(0, 50)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(391, 260)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 14
        '
        'tbTimeMode
        '
        Me.tbTimeMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tbTimeMode.Controls.Add(Me.pnlSetTime)
        Me.tbTimeMode.Controls.Add(Me.llbMode)
        Me.tbTimeMode.Controls.Add(Me.pnlCountdown)
        Me.tbTimeMode.Controls.Add(Me.FlatLabel2)
        Me.tbTimeMode.Controls.Add(Me.FlatLabel1)
        Me.tbTimeMode.Controls.Add(Me.btnStart)
        Me.tbTimeMode.Location = New System.Drawing.Point(4, 44)
        Me.tbTimeMode.Name = "tbTimeMode"
        Me.tbTimeMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTimeMode.Size = New System.Drawing.Size(383, 212)
        Me.tbTimeMode.TabIndex = 0
        Me.tbTimeMode.Text = "定时模式"
        '
        'pnlSetTime
        '
        Me.pnlSetTime.Controls.Add(Me.llbDay)
        Me.pnlSetTime.Controls.Add(Me.fnSTMinute)
        Me.pnlSetTime.Controls.Add(Me.FlatLabel11)
        Me.pnlSetTime.Controls.Add(Me.fnSTHour)
        Me.pnlSetTime.Controls.Add(Me.FlatLabel12)
        Me.pnlSetTime.Location = New System.Drawing.Point(12, 97)
        Me.pnlSetTime.Name = "pnlSetTime"
        Me.pnlSetTime.Size = New System.Drawing.Size(252, 93)
        Me.pnlSetTime.TabIndex = 20
        Me.pnlSetTime.Visible = False
        '
        'llbDay
        '
        Me.llbDay.AutoSize = True
        Me.llbDay.BackColor = System.Drawing.Color.Transparent
        Me.llbDay.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbDay.LinkColor = System.Drawing.Color.DarkOrange
        Me.llbDay.Location = New System.Drawing.Point(29, 11)
        Me.llbDay.Name = "llbDay"
        Me.llbDay.Size = New System.Drawing.Size(52, 25)
        Me.llbDay.TabIndex = 20
        Me.llbDay.TabStop = True
        Me.llbDay.Text = "今天"
        '
        'fnSTMinute
        '
        Me.fnSTMinute.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fnSTMinute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fnSTMinute.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fnSTMinute.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fnSTMinute.ForeColor = System.Drawing.Color.White
        Me.fnSTMinute.Location = New System.Drawing.Point(135, 42)
        Me.fnSTMinute.Maximum = CType(59, Long)
        Me.fnSTMinute.Minimum = CType(0, Long)
        Me.fnSTMinute.Name = "fnSTMinute"
        Me.fnSTMinute.Size = New System.Drawing.Size(69, 30)
        Me.fnSTMinute.TabIndex = 14
        Me.fnSTMinute.Text = "FlatNumeric2"
        Me.fnSTMinute.Value = CType(0, Long)
        '
        'FlatLabel11
        '
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(210, 50)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New System.Drawing.Size(20, 13)
        Me.FlatLabel11.TabIndex = 17
        Me.FlatLabel11.Text = "分"
        '
        'fnSTHour
        '
        Me.fnSTHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fnSTHour.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fnSTHour.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fnSTHour.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fnSTHour.ForeColor = System.Drawing.Color.White
        Me.fnSTHour.Location = New System.Drawing.Point(34, 42)
        Me.fnSTHour.Maximum = CType(23, Long)
        Me.fnSTHour.Minimum = CType(0, Long)
        Me.fnSTHour.Name = "fnSTHour"
        Me.fnSTHour.Size = New System.Drawing.Size(69, 30)
        Me.fnSTHour.TabIndex = 13
        Me.fnSTHour.Text = "FlatNumeric1"
        Me.fnSTHour.Value = CType(0, Long)
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(109, 50)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New System.Drawing.Size(20, 13)
        Me.FlatLabel12.TabIndex = 16
        Me.FlatLabel12.Text = "时"
        '
        'llbMode
        '
        Me.llbMode.AutoSize = True
        Me.llbMode.BackColor = System.Drawing.Color.Transparent
        Me.llbMode.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbMode.LinkColor = System.Drawing.Color.DarkOrange
        Me.llbMode.Location = New System.Drawing.Point(8, 9)
        Me.llbMode.Name = "llbMode"
        Me.llbMode.Size = New System.Drawing.Size(65, 19)
        Me.llbMode.TabIndex = 19
        Me.llbMode.TabStop = True
        Me.llbMode.Text = "设定模式"
        '
        'pnlCountdown
        '
        Me.pnlCountdown.Controls.Add(Me.fNMinute)
        Me.pnlCountdown.Controls.Add(Me.FlatLabel4)
        Me.pnlCountdown.Controls.Add(Me.fNHour)
        Me.pnlCountdown.Controls.Add(Me.FlatLabel3)
        Me.pnlCountdown.Location = New System.Drawing.Point(131, 19)
        Me.pnlCountdown.Name = "pnlCountdown"
        Me.pnlCountdown.Size = New System.Drawing.Size(252, 91)
        Me.pnlCountdown.TabIndex = 18
        '
        'fNMinute
        '
        Me.fNMinute.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fNMinute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fNMinute.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fNMinute.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fNMinute.ForeColor = System.Drawing.Color.White
        Me.fNMinute.Location = New System.Drawing.Point(133, 29)
        Me.fNMinute.Maximum = CType(59, Long)
        Me.fNMinute.Minimum = CType(0, Long)
        Me.fNMinute.Name = "fNMinute"
        Me.fNMinute.Size = New System.Drawing.Size(69, 30)
        Me.fNMinute.TabIndex = 14
        Me.fNMinute.Text = "FlatNumeric2"
        Me.fNMinute.Value = CType(0, Long)
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(208, 38)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(33, 13)
        Me.FlatLabel4.TabIndex = 17
        Me.FlatLabel4.Text = "分钟"
        '
        'fNHour
        '
        Me.fNHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fNHour.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.fNHour.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fNHour.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fNHour.ForeColor = System.Drawing.Color.White
        Me.fNHour.Location = New System.Drawing.Point(19, 29)
        Me.fNHour.Maximum = CType(100, Long)
        Me.fNHour.Minimum = CType(0, Long)
        Me.fNHour.Name = "fNHour"
        Me.fNHour.Size = New System.Drawing.Size(69, 30)
        Me.fNHour.TabIndex = 13
        Me.fNHour.Text = "FlatNumeric1"
        Me.fNHour.Value = CType(0, Long)
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(94, 38)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(33, 13)
        Me.FlatLabel3.TabIndex = 16
        Me.FlatLabel3.Text = "小时"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(8, 48)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(72, 13)
        Me.FlatLabel2.TabIndex = 15
        Me.FlatLabel2.Text = "请设定时间"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(253, 13)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(124, 13)
        Me.FlatLabel1.TabIndex = 12
        Me.FlatLabel1.Text = "在设定的时长内关机"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(291, 175)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Rounded = False
        Me.btnStart.Size = New System.Drawing.Size(86, 31)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "开始"
        Me.btnStart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'tbBatteryMode
        '
        Me.tbBatteryMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tbBatteryMode.Controls.Add(Me.FlatLabel5)
        Me.tbBatteryMode.Controls.Add(Me.fgbError)
        Me.tbBatteryMode.Controls.Add(Me.lbBatterySettings)
        Me.tbBatteryMode.Controls.Add(Me.FlatLabel6)
        Me.tbBatteryMode.Controls.Add(Me.ftbBattery)
        Me.tbBatteryMode.Controls.Add(Me.FlatButton1)
        Me.tbBatteryMode.Controls.Add(Me.fpbCurrentBattery)
        Me.tbBatteryMode.Location = New System.Drawing.Point(4, 44)
        Me.tbBatteryMode.Name = "tbBatteryMode"
        Me.tbBatteryMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBatteryMode.Size = New System.Drawing.Size(383, 212)
        Me.tbBatteryMode.TabIndex = 1
        Me.tbBatteryMode.Text = "定电量模式"
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(240, 12)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(137, 13)
        Me.FlatLabel5.TabIndex = 13
        Me.FlatLabel5.Text = "在低于设定电量时关机"
        '
        'fgbError
        '
        Me.fgbError.BackColor = System.Drawing.Color.Transparent
        Me.fgbError.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fgbError.Controls.Add(Me.FlatLabel7)
        Me.fgbError.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.fgbError.ForeColor = System.Drawing.Color.DimGray
        Me.fgbError.Location = New System.Drawing.Point(6, 6)
        Me.fgbError.Name = "fgbError"
        Me.fgbError.ShowText = True
        Me.fgbError.Size = New System.Drawing.Size(22, 200)
        Me.fgbError.TabIndex = 19
        Me.fgbError.Text = "错误"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.OrangeRed
        Me.FlatLabel7.Location = New System.Drawing.Point(47, 67)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(137, 13)
        Me.FlatLabel7.TabIndex = 0
        Me.FlatLabel7.Text = "当前无法使用此功能！"
        '
        'lbBatterySettings
        '
        Me.lbBatterySettings.AutoSize = True
        Me.lbBatterySettings.BackColor = System.Drawing.Color.Transparent
        Me.lbBatterySettings.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbBatterySettings.ForeColor = System.Drawing.Color.White
        Me.lbBatterySettings.Location = New System.Drawing.Point(186, 135)
        Me.lbBatterySettings.Name = "lbBatterySettings"
        Me.lbBatterySettings.Size = New System.Drawing.Size(151, 13)
        Me.lbBatterySettings.TabIndex = 18
        Me.lbBatterySettings.Text = "将在电量低于100%时关机"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(53, 87)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(176, 13)
        Me.FlatLabel6.TabIndex = 17
        Me.FlatLabel6.Text = "滑动滑竿调节目标电量百分比"
        '
        'ftbBattery
        '
        Me.ftbBattery.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ftbBattery.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ftbBattery.Location = New System.Drawing.Point(56, 109)
        Me.ftbBattery.Maximum = 10
        Me.ftbBattery.Minimum = 0
        Me.ftbBattery.Name = "ftbBattery"
        Me.ftbBattery.ShowValue = False
        Me.ftbBattery.Size = New System.Drawing.Size(281, 23)
        Me.ftbBattery.Style = 定时关机Ex.FlatTrackBar._Style.Slider
        Me.ftbBattery.TabIndex = 16
        Me.ftbBattery.Text = "FlatTrackBar1"
        Me.ftbBattery.TrackColor = System.Drawing.Color.DodgerBlue
        Me.ftbBattery.Value = 5
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.DodgerBlue
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(291, 175)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(86, 31)
        Me.FlatButton1.TabIndex = 15
        Me.FlatButton1.Text = "开始"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'fpbCurrentBattery
        '
        Me.fpbCurrentBattery.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.fpbCurrentBattery.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.fpbCurrentBattery.Location = New System.Drawing.Point(56, 39)
        Me.fpbCurrentBattery.Maximum = 100
        Me.fpbCurrentBattery.Name = "fpbCurrentBattery"
        Me.fpbCurrentBattery.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.fpbCurrentBattery.Size = New System.Drawing.Size(281, 42)
        Me.fpbCurrentBattery.TabIndex = 14
        Me.fpbCurrentBattery.Text = "FlatProgressBar1"
        Me.fpbCurrentBattery.Value = 50
        '
        'tbOptions
        '
        Me.tbOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.tbOptions.Controls.Add(Me.help4REMINDER)
        Me.tbOptions.Controls.Add(Me.help4VOL)
        Me.tbOptions.Controls.Add(Me.help4TVP)
        Me.tbOptions.Controls.Add(Me.fbVolSettings)
        Me.tbOptions.Controls.Add(Me.fbHistory)
        Me.tbOptions.Controls.Add(Me.FlatLabel10)
        Me.tbOptions.Controls.Add(Me.FlatLabel9)
        Me.tbOptions.Controls.Add(Me.FlatLabel8)
        Me.tbOptions.Controls.Add(Me.ftReminder)
        Me.tbOptions.Controls.Add(Me.ftVol)
        Me.tbOptions.Controls.Add(Me.ftRecord)
        Me.tbOptions.Controls.Add(Me.fbAbout)
        Me.tbOptions.Controls.Add(Me.btnFindNew)
        Me.tbOptions.Location = New System.Drawing.Point(4, 44)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOptions.Size = New System.Drawing.Size(383, 212)
        Me.tbOptions.TabIndex = 2
        Me.tbOptions.Text = "附加选项"
        '
        'help4REMINDER
        '
        Me.help4REMINDER.Image = Global.定时关机Ex.My.Resources.Resources.help
        Me.help4REMINDER.Location = New System.Drawing.Point(10, 111)
        Me.help4REMINDER.Name = "help4REMINDER"
        Me.help4REMINDER.Size = New System.Drawing.Size(24, 24)
        Me.help4REMINDER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.help4REMINDER.TabIndex = 26
        Me.help4REMINDER.TabStop = False
        '
        'help4VOL
        '
        Me.help4VOL.Image = Global.定时关机Ex.My.Resources.Resources.help
        Me.help4VOL.Location = New System.Drawing.Point(10, 72)
        Me.help4VOL.Name = "help4VOL"
        Me.help4VOL.Size = New System.Drawing.Size(24, 24)
        Me.help4VOL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.help4VOL.TabIndex = 25
        Me.help4VOL.TabStop = False
        '
        'help4TVP
        '
        Me.help4TVP.Image = Global.定时关机Ex.My.Resources.Resources.help
        Me.help4TVP.Location = New System.Drawing.Point(10, 32)
        Me.help4TVP.Name = "help4TVP"
        Me.help4TVP.Size = New System.Drawing.Size(24, 24)
        Me.help4TVP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.help4TVP.TabIndex = 24
        Me.help4TVP.TabStop = False
        '
        'fbVolSettings
        '
        Me.fbVolSettings.BackColor = System.Drawing.Color.Transparent
        Me.fbVolSettings.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fbVolSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbVolSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fbVolSettings.Location = New System.Drawing.Point(268, 69)
        Me.fbVolSettings.Name = "fbVolSettings"
        Me.fbVolSettings.Rounded = False
        Me.fbVolSettings.Size = New System.Drawing.Size(106, 32)
        Me.fbVolSettings.TabIndex = 23
        Me.fbVolSettings.Text = "设置"
        Me.fbVolSettings.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'fbHistory
        '
        Me.fbHistory.BackColor = System.Drawing.Color.Transparent
        Me.fbHistory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fbHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fbHistory.Location = New System.Drawing.Point(268, 29)
        Me.fbHistory.Name = "fbHistory"
        Me.fbHistory.Rounded = False
        Me.fbHistory.Size = New System.Drawing.Size(106, 32)
        Me.fbHistory.TabIndex = 22
        Me.fbHistory.Text = "查看记录"
        Me.fbHistory.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(122, 118)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(89, 13)
        Me.FlatLabel10.TabIndex = 21
        Me.FlatLabel10.Text = "半点/整点提醒"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(122, 78)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel9.TabIndex = 20
        Me.FlatLabel9.Text = "深夜音量控制"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(122, 38)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(124, 13)
        Me.FlatLabel8.TabIndex = 19
        Me.FlatLabel8.Text = "记录电视剧观看进度"
        '
        'ftReminder
        '
        Me.ftReminder.BackColor = System.Drawing.Color.Transparent
        Me.ftReminder.Checked = True
        Me.ftReminder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ftReminder.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ftReminder.Location = New System.Drawing.Point(40, 107)
        Me.ftReminder.Name = "ftReminder"
        Me.ftReminder.Options = 定时关机Ex.FlatToggle._Options.Style3
        Me.ftReminder.Size = New System.Drawing.Size(76, 33)
        Me.ftReminder.TabIndex = 18
        Me.ftReminder.Text = "FlatToggle1"
        '
        'ftVol
        '
        Me.ftVol.BackColor = System.Drawing.Color.Transparent
        Me.ftVol.Checked = True
        Me.ftVol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ftVol.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ftVol.Location = New System.Drawing.Point(40, 68)
        Me.ftVol.Name = "ftVol"
        Me.ftVol.Options = 定时关机Ex.FlatToggle._Options.Style3
        Me.ftVol.Size = New System.Drawing.Size(76, 33)
        Me.ftVol.TabIndex = 17
        Me.ftVol.Text = "FlatToggle1"
        '
        'ftRecord
        '
        Me.ftRecord.BackColor = System.Drawing.Color.Transparent
        Me.ftRecord.Checked = True
        Me.ftRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ftRecord.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ftRecord.Location = New System.Drawing.Point(40, 29)
        Me.ftRecord.Name = "ftRecord"
        Me.ftRecord.Options = 定时关机Ex.FlatToggle._Options.Style3
        Me.ftRecord.Size = New System.Drawing.Size(76, 33)
        Me.ftRecord.TabIndex = 16
        Me.ftRecord.Text = "FlatToggle1"
        '
        'fbAbout
        '
        Me.fbAbout.BackColor = System.Drawing.Color.Transparent
        Me.fbAbout.BaseColor = System.Drawing.Color.DodgerBlue
        Me.fbAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbAbout.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fbAbout.Location = New System.Drawing.Point(306, 165)
        Me.fbAbout.Name = "fbAbout"
        Me.fbAbout.Rounded = False
        Me.fbAbout.Size = New System.Drawing.Size(68, 31)
        Me.fbAbout.TabIndex = 15
        Me.fbAbout.Text = "关于"
        Me.fbAbout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnFindNew
        '
        Me.btnFindNew.BackColor = System.Drawing.Color.Transparent
        Me.btnFindNew.BaseColor = System.Drawing.Color.Orange
        Me.btnFindNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnFindNew.Location = New System.Drawing.Point(194, 165)
        Me.btnFindNew.Name = "btnFindNew"
        Me.btnFindNew.Rounded = False
        Me.btnFindNew.Size = New System.Drawing.Size(106, 31)
        Me.btnFindNew.TabIndex = 12
        Me.btnFindNew.Text = "查找新版本"
        Me.btnFindNew.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(365, 16)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 13
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatContextMenuStrip1
        '
        Me.FlatContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.FlatContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.高规格ToolStripMenuItem})
        Me.FlatContextMenuStrip1.Name = "FlatContextMenuStrip1"
        Me.FlatContextMenuStrip1.ShowImageMargin = False
        Me.FlatContextMenuStrip1.Size = New System.Drawing.Size(89, 26)
        '
        '高规格ToolStripMenuItem
        '
        Me.高规格ToolStripMenuItem.Name = "高规格ToolStripMenuItem"
        Me.高规格ToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.高规格ToolStripMenuItem.Text = "高规格"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 331)
        Me.Controls.Add(Me.fsbTime)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.cmsSelect.ResumeLayout(False)
        Me.cmsMode.ResumeLayout(False)
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.tbTimeMode.ResumeLayout(False)
        Me.tbTimeMode.PerformLayout()
        Me.pnlSetTime.ResumeLayout(False)
        Me.pnlSetTime.PerformLayout()
        Me.pnlCountdown.ResumeLayout(False)
        Me.pnlCountdown.PerformLayout()
        Me.tbBatteryMode.ResumeLayout(False)
        Me.tbBatteryMode.PerformLayout()
        Me.fgbError.ResumeLayout(False)
        Me.fgbError.PerformLayout()
        Me.tbOptions.ResumeLayout(False)
        Me.tbOptions.PerformLayout()
        CType(Me.help4REMINDER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.help4VOL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.help4TVP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmsSelect As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiContinue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormSkin1 As 定时关机Ex.FormSkin
    Friend WithEvents btnStart As 定时关机Ex.FlatButton
    Friend WithEvents btnFindNew As 定时关机Ex.FlatButton
    Friend WithEvents FlatClose1 As 定时关机Ex.FlatClose
    Friend WithEvents FlatTabControl1 As 定时关机Ex.FlatTabControl
    Friend WithEvents tbTimeMode As System.Windows.Forms.TabPage
    Friend WithEvents tbBatteryMode As System.Windows.Forms.TabPage
    Friend WithEvents tbOptions As System.Windows.Forms.TabPage
    Friend WithEvents FlatLabel4 As 定时关机Ex.FlatLabel
    Friend WithEvents FlatLabel3 As 定时关机Ex.FlatLabel
    Friend WithEvents FlatLabel2 As 定时关机Ex.FlatLabel
    Friend WithEvents fNMinute As 定时关机Ex.FlatNumeric
    Friend WithEvents fNHour As 定时关机Ex.FlatNumeric
    Friend WithEvents FlatLabel1 As 定时关机Ex.FlatLabel
    Friend WithEvents FlatButton1 As 定时关机Ex.FlatButton
    Friend WithEvents fpbCurrentBattery As 定时关机Ex.FlatProgressBar
    Friend WithEvents FlatLabel5 As 定时关机Ex.FlatLabel
    Friend WithEvents fbAbout As 定时关机Ex.FlatButton
    Friend WithEvents ftbBattery As 定时关机Ex.FlatTrackBar
    Friend WithEvents ftRecord As 定时关机Ex.FlatToggle
    Friend WithEvents FlatLabel6 As 定时关机Ex.FlatLabel
    Friend WithEvents lbBatterySettings As 定时关机Ex.FlatLabel
    Friend WithEvents FlatAlertBox1 As 定时关机Ex.FlatAlertBox
    Friend WithEvents fgbError As 定时关机Ex.FlatGroupBox
    Friend WithEvents FlatLabel7 As 定时关机Ex.FlatLabel
    Friend WithEvents ftReminder As 定时关机Ex.FlatToggle
    Friend WithEvents ftVol As 定时关机Ex.FlatToggle
    Friend WithEvents fbVolSettings As 定时关机Ex.FlatButton
    Friend WithEvents fbHistory As 定时关机Ex.FlatButton
    Friend WithEvents FlatLabel10 As 定时关机Ex.FlatLabel
    Friend WithEvents FlatLabel9 As 定时关机Ex.FlatLabel
    Friend WithEvents FlatLabel8 As 定时关机Ex.FlatLabel
    Friend WithEvents fsbTime As 定时关机Ex.FlatStatusBar
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents FlatContextMenuStrip1 As 定时关机Ex.FlatContextMenuStrip
    Friend WithEvents 高规格ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents help4REMINDER As System.Windows.Forms.PictureBox
    Friend WithEvents help4VOL As System.Windows.Forms.PictureBox
    Friend WithEvents help4TVP As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FlatMini1 As 定时关机Ex.FlatMini
    Friend WithEvents pnlCountdown As System.Windows.Forms.Panel
    Friend WithEvents llbMode As System.Windows.Forms.LinkLabel
    Friend WithEvents cmsMode As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiCountdown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSetTime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlSetTime As System.Windows.Forms.Panel
    Friend WithEvents fnSTMinute As 定时关机Ex.FlatNumeric
    Friend WithEvents FlatLabel11 As 定时关机Ex.FlatLabel
    Friend WithEvents fnSTHour As 定时关机Ex.FlatNumeric
    Friend WithEvents FlatLabel12 As 定时关机Ex.FlatLabel
    Friend WithEvents llbDay As System.Windows.Forms.LinkLabel
    Friend WithEvents cmsTime As System.Windows.Forms.ContextMenuStrip

End Class
