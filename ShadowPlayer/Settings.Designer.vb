<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_time = New System.Windows.Forms.TabPage()
        Me.btn_saveLoudTime = New System.Windows.Forms.Button()
        Me.PnlOpen = New System.Windows.Forms.Panel()
        Me.txtLoudTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlStop = New System.Windows.Forms.Panel()
        Me.btn_saveCloseTime = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RdoNext = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RdoStop = New System.Windows.Forms.RadioButton()
        Me.RdoPause = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RdoSetEndEnabled = New System.Windows.Forms.RadioButton()
        Me.RdoSetMiniEnabled = New System.Windows.Forms.RadioButton()
        Me.RdoSetCloseNothing = New System.Windows.Forms.RadioButton()
        Me.txtEndTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkSetTimeEnabled = New System.Windows.Forms.CheckBox()
        Me.ChkSetCloseEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage_lyric = New System.Windows.Forms.TabPage()
        Me.PnlLryic = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnFilesystem = New System.Windows.Forms.Button()
        Me.BtnAddLrc = New System.Windows.Forms.Button()
        Me.TxtOriginLyr = New System.Windows.Forms.TextBox()
        Me.CboOriginSong = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboTextStyle = New System.Windows.Forms.ComboBox()
        Me.CboLrcFunction = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblShowEnLyricFont = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblShowCnLyricFont = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PicCnLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PicEnLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblShowLyricFont = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkLyricOpen = New System.Windows.Forms.CheckBox()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.lbl_CheckUpdates = New System.Windows.Forms.LinkLabel()
        Me.lbl_buidLevel = New System.Windows.Forms.Label()
        Me.lbl_mainLevel = New System.Windows.Forms.Label()
        Me.btn_Mainexit = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Lyric = New System.Windows.Forms.Button()
        Me.btn_time = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.chkAutoFullScreen = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_time.SuspendLayout()
        Me.PnlOpen.SuspendLayout()
        Me.PnlStop.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage_lyric.SuspendLayout()
        Me.PnlLryic.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PicCnLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEnLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_top.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_time)
        Me.TabControl1.Controls.Add(Me.TabPage_lyric)
        Me.TabControl1.Location = New System.Drawing.Point(85, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(474, 409)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage_time
        '
        Me.TabPage_time.Controls.Add(Me.btn_saveLoudTime)
        Me.TabPage_time.Controls.Add(Me.PnlOpen)
        Me.TabPage_time.Controls.Add(Me.PnlStop)
        Me.TabPage_time.Controls.Add(Me.ChkSetTimeEnabled)
        Me.TabPage_time.Controls.Add(Me.ChkSetCloseEnabled)
        Me.TabPage_time.Location = New System.Drawing.Point(4, 26)
        Me.TabPage_time.Name = "TabPage_time"
        Me.TabPage_time.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_time.Size = New System.Drawing.Size(466, 379)
        Me.TabPage_time.TabIndex = 0
        Me.TabPage_time.Text = "TabPage1"
        Me.TabPage_time.UseVisualStyleBackColor = True
        '
        'btn_saveLoudTime
        '
        Me.btn_saveLoudTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_saveLoudTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_saveLoudTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveLoudTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_saveLoudTime.ForeColor = System.Drawing.Color.White
        Me.btn_saveLoudTime.Location = New System.Drawing.Point(181, 57)
        Me.btn_saveLoudTime.Name = "btn_saveLoudTime"
        Me.btn_saveLoudTime.Size = New System.Drawing.Size(75, 25)
        Me.btn_saveLoudTime.TabIndex = 45
        Me.btn_saveLoudTime.Text = "保存"
        Me.btn_saveLoudTime.UseVisualStyleBackColor = False
        Me.btn_saveLoudTime.Visible = False
        '
        'PnlOpen
        '
        Me.PnlOpen.Controls.Add(Me.chkAutoFullScreen)
        Me.PnlOpen.Controls.Add(Me.txtLoudTime)
        Me.PnlOpen.Controls.Add(Me.Label1)
        Me.PnlOpen.ForeColor = System.Drawing.Color.Black
        Me.PnlOpen.Location = New System.Drawing.Point(15, 57)
        Me.PnlOpen.Name = "PnlOpen"
        Me.PnlOpen.Size = New System.Drawing.Size(160, 63)
        Me.PnlOpen.TabIndex = 43
        '
        'txtLoudTime
        '
        Me.txtLoudTime.AsciiOnly = True
        Me.txtLoudTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoudTime.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtLoudTime.Location = New System.Drawing.Point(68, 0)
        Me.txtLoudTime.Mask = "90:00:00"
        Me.txtLoudTime.Name = "txtLoudTime"
        Me.txtLoudTime.RejectInputOnFirstFailure = True
        Me.txtLoudTime.Size = New System.Drawing.Size(83, 26)
        Me.txtLoudTime.TabIndex = 28
        Me.txtLoudTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLoudTime.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "闹钟时间"
        '
        'PnlStop
        '
        Me.PnlStop.Controls.Add(Me.btn_saveCloseTime)
        Me.PnlStop.Controls.Add(Me.Panel3)
        Me.PnlStop.Controls.Add(Me.Panel2)
        Me.PnlStop.Controls.Add(Me.txtEndTime)
        Me.PnlStop.Controls.Add(Me.Label2)
        Me.PnlStop.ForeColor = System.Drawing.Color.Black
        Me.PnlStop.Location = New System.Drawing.Point(15, 156)
        Me.PnlStop.Name = "PnlStop"
        Me.PnlStop.Size = New System.Drawing.Size(305, 178)
        Me.PnlStop.TabIndex = 44
        '
        'btn_saveCloseTime
        '
        Me.btn_saveCloseTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_saveCloseTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_saveCloseTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveCloseTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_saveCloseTime.ForeColor = System.Drawing.Color.White
        Me.btn_saveCloseTime.Location = New System.Drawing.Point(166, 5)
        Me.btn_saveCloseTime.Name = "btn_saveCloseTime"
        Me.btn_saveCloseTime.Size = New System.Drawing.Size(75, 25)
        Me.btn_saveCloseTime.TabIndex = 46
        Me.btn_saveCloseTime.Text = "保存"
        Me.btn_saveCloseTime.UseVisualStyleBackColor = False
        Me.btn_saveCloseTime.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RdoNext)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.RdoStop)
        Me.Panel3.Controls.Add(Me.RdoPause)
        Me.Panel3.Location = New System.Drawing.Point(149, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 118)
        Me.Panel3.TabIndex = 46
        '
        'RdoNext
        '
        Me.RdoNext.AutoSize = True
        Me.RdoNext.Checked = True
        Me.RdoNext.Location = New System.Drawing.Point(7, 73)
        Me.RdoNext.Name = "RdoNext"
        Me.RdoNext.Size = New System.Drawing.Size(98, 21)
        Me.RdoNext.TabIndex = 2
        Me.RdoNext.TabStop = True
        Me.RdoNext.Text = "切换到下一首"
        Me.RdoNext.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(3, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 20)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "停止后动作"
        '
        'RdoStop
        '
        Me.RdoStop.AutoSize = True
        Me.RdoStop.Location = New System.Drawing.Point(7, 56)
        Me.RdoStop.Name = "RdoStop"
        Me.RdoStop.Size = New System.Drawing.Size(98, 21)
        Me.RdoStop.TabIndex = 1
        Me.RdoStop.Text = "停止当前歌曲"
        Me.RdoStop.UseVisualStyleBackColor = True
        '
        'RdoPause
        '
        Me.RdoPause.AutoSize = True
        Me.RdoPause.Location = New System.Drawing.Point(7, 39)
        Me.RdoPause.Name = "RdoPause"
        Me.RdoPause.Size = New System.Drawing.Size(98, 21)
        Me.RdoPause.TabIndex = 0
        Me.RdoPause.Text = "暂停当前歌曲"
        Me.RdoPause.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.RdoSetEndEnabled)
        Me.Panel2.Controls.Add(Me.RdoSetMiniEnabled)
        Me.Panel2.Controls.Add(Me.RdoSetCloseNothing)
        Me.Panel2.Location = New System.Drawing.Point(3, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 118)
        Me.Panel2.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "停止模式"
        '
        'RdoSetEndEnabled
        '
        Me.RdoSetEndEnabled.AutoSize = True
        Me.RdoSetEndEnabled.Location = New System.Drawing.Point(6, 56)
        Me.RdoSetEndEnabled.Name = "RdoSetEndEnabled"
        Me.RdoSetEndEnabled.Size = New System.Drawing.Size(110, 21)
        Me.RdoSetEndEnabled.TabIndex = 37
        Me.RdoSetEndEnabled.Text = "停止时关闭程序"
        Me.RdoSetEndEnabled.UseVisualStyleBackColor = True
        '
        'RdoSetMiniEnabled
        '
        Me.RdoSetMiniEnabled.AutoSize = True
        Me.RdoSetMiniEnabled.Checked = True
        Me.RdoSetMiniEnabled.Location = New System.Drawing.Point(6, 74)
        Me.RdoSetMiniEnabled.Name = "RdoSetMiniEnabled"
        Me.RdoSetMiniEnabled.Size = New System.Drawing.Size(122, 21)
        Me.RdoSetMiniEnabled.TabIndex = 38
        Me.RdoSetMiniEnabled.TabStop = True
        Me.RdoSetMiniEnabled.Text = "停止时最小化程序"
        Me.RdoSetMiniEnabled.UseVisualStyleBackColor = True
        '
        'RdoSetCloseNothing
        '
        Me.RdoSetCloseNothing.AutoSize = True
        Me.RdoSetCloseNothing.Location = New System.Drawing.Point(6, 39)
        Me.RdoSetCloseNothing.Name = "RdoSetCloseNothing"
        Me.RdoSetCloseNothing.Size = New System.Drawing.Size(62, 21)
        Me.RdoSetCloseNothing.TabIndex = 39
        Me.RdoSetCloseNothing.Text = "仅停止"
        Me.RdoSetCloseNothing.UseVisualStyleBackColor = True
        '
        'txtEndTime
        '
        Me.txtEndTime.AsciiOnly = True
        Me.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndTime.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtEndTime.Location = New System.Drawing.Point(68, 5)
        Me.txtEndTime.Mask = "90:00:00"
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.RejectInputOnFirstFailure = True
        Me.txtEndTime.Size = New System.Drawing.Size(83, 26)
        Me.txtEndTime.TabIndex = 37
        Me.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtEndTime.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "关闭时间"
        '
        'ChkSetTimeEnabled
        '
        Me.ChkSetTimeEnabled.AutoSize = True
        Me.ChkSetTimeEnabled.BackColor = System.Drawing.Color.Transparent
        Me.ChkSetTimeEnabled.Checked = True
        Me.ChkSetTimeEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSetTimeEnabled.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ChkSetTimeEnabled.ForeColor = System.Drawing.Color.Black
        Me.ChkSetTimeEnabled.Location = New System.Drawing.Point(11, 33)
        Me.ChkSetTimeEnabled.Name = "ChkSetTimeEnabled"
        Me.ChkSetTimeEnabled.Size = New System.Drawing.Size(118, 24)
        Me.ChkSetTimeEnabled.TabIndex = 41
        Me.ChkSetTimeEnabled.Text = "定时开启播放"
        Me.ChkSetTimeEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSetTimeEnabled.UseVisualStyleBackColor = False
        '
        'ChkSetCloseEnabled
        '
        Me.ChkSetCloseEnabled.AutoSize = True
        Me.ChkSetCloseEnabled.BackColor = System.Drawing.Color.Transparent
        Me.ChkSetCloseEnabled.Checked = True
        Me.ChkSetCloseEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSetCloseEnabled.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ChkSetCloseEnabled.ForeColor = System.Drawing.Color.Black
        Me.ChkSetCloseEnabled.Location = New System.Drawing.Point(11, 126)
        Me.ChkSetCloseEnabled.Name = "ChkSetCloseEnabled"
        Me.ChkSetCloseEnabled.Size = New System.Drawing.Size(118, 24)
        Me.ChkSetCloseEnabled.TabIndex = 42
        Me.ChkSetCloseEnabled.Text = "定时停止播放"
        Me.ChkSetCloseEnabled.UseVisualStyleBackColor = False
        '
        'TabPage_lyric
        '
        Me.TabPage_lyric.Controls.Add(Me.PnlLryic)
        Me.TabPage_lyric.Controls.Add(Me.ChkLyricOpen)
        Me.TabPage_lyric.Location = New System.Drawing.Point(4, 26)
        Me.TabPage_lyric.Name = "TabPage_lyric"
        Me.TabPage_lyric.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_lyric.Size = New System.Drawing.Size(466, 379)
        Me.TabPage_lyric.TabIndex = 1
        Me.TabPage_lyric.Text = "TabPage2"
        Me.TabPage_lyric.UseVisualStyleBackColor = True
        '
        'PnlLryic
        '
        Me.PnlLryic.AutoScroll = True
        Me.PnlLryic.Controls.Add(Me.Panel4)
        Me.PnlLryic.Controls.Add(Me.LblShowEnLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label14)
        Me.PnlLryic.Controls.Add(Me.LblShowCnLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label12)
        Me.PnlLryic.Controls.Add(Me.PicCnLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label10)
        Me.PnlLryic.Controls.Add(Me.PicEnLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label9)
        Me.PnlLryic.Controls.Add(Me.LblShowLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label4)
        Me.PnlLryic.Controls.Add(Me.PicLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label3)
        Me.PnlLryic.Location = New System.Drawing.Point(31, 57)
        Me.PnlLryic.Name = "PnlLryic"
        Me.PnlLryic.Size = New System.Drawing.Size(389, 316)
        Me.PnlLryic.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.CboTextStyle)
        Me.Panel4.Controls.Add(Me.CboLrcFunction)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(6, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(358, 207)
        Me.Panel4.TabIndex = 15
        Me.Panel4.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.BtnFilesystem)
        Me.Panel5.Controls.Add(Me.BtnAddLrc)
        Me.Panel5.Controls.Add(Me.TxtOriginLyr)
        Me.Panel5.Controls.Add(Me.CboOriginSong)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(13, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(324, 119)
        Me.Panel5.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(16, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "手动载入"
        '
        'BtnFilesystem
        '
        Me.BtnFilesystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnFilesystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnFilesystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilesystem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFilesystem.ForeColor = System.Drawing.Color.White
        Me.BtnFilesystem.Location = New System.Drawing.Point(277, 63)
        Me.BtnFilesystem.Name = "BtnFilesystem"
        Me.BtnFilesystem.Size = New System.Drawing.Size(33, 23)
        Me.BtnFilesystem.TabIndex = 22
        Me.BtnFilesystem.Text = "..."
        Me.BtnFilesystem.UseVisualStyleBackColor = False
        '
        'BtnAddLrc
        '
        Me.BtnAddLrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnAddLrc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnAddLrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddLrc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddLrc.ForeColor = System.Drawing.Color.White
        Me.BtnAddLrc.Location = New System.Drawing.Point(138, 91)
        Me.BtnAddLrc.Name = "BtnAddLrc"
        Me.BtnAddLrc.Size = New System.Drawing.Size(75, 25)
        Me.BtnAddLrc.TabIndex = 21
        Me.BtnAddLrc.Text = "导入"
        Me.BtnAddLrc.UseVisualStyleBackColor = False
        '
        'TxtOriginLyr
        '
        Me.TxtOriginLyr.Location = New System.Drawing.Point(90, 63)
        Me.TxtOriginLyr.Name = "TxtOriginLyr"
        Me.TxtOriginLyr.Size = New System.Drawing.Size(185, 23)
        Me.TxtOriginLyr.TabIndex = 20
        '
        'CboOriginSong
        '
        Me.CboOriginSong.FormattingEnabled = True
        Me.CboOriginSong.Location = New System.Drawing.Point(90, 30)
        Me.CboOriginSong.Name = "CboOriginSong"
        Me.CboOriginSong.Size = New System.Drawing.Size(220, 25)
        Me.CboOriginSong.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "目标歌词"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "目标歌曲"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "编码格式"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(42, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "读取方式"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(9, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 20)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "字幕读取设置"
        '
        'CboTextStyle
        '
        Me.CboTextStyle.FormattingEnabled = True
        Me.CboTextStyle.Items.AddRange(New Object() {"UTF-8", "默认", "ASCII", "Unicode"})
        Me.CboTextStyle.Location = New System.Drawing.Point(121, 61)
        Me.CboTextStyle.Name = "CboTextStyle"
        Me.CboTextStyle.Size = New System.Drawing.Size(184, 25)
        Me.CboTextStyle.TabIndex = 8
        Me.CboTextStyle.Text = "UTF-8"
        '
        'CboLrcFunction
        '
        Me.CboLrcFunction.FormattingEnabled = True
        Me.CboLrcFunction.Items.AddRange(New Object() {"整体读入", "逐行读入"})
        Me.CboLrcFunction.Location = New System.Drawing.Point(121, 33)
        Me.CboLrcFunction.Name = "CboLrcFunction"
        Me.CboLrcFunction.Size = New System.Drawing.Size(184, 25)
        Me.CboLrcFunction.TabIndex = 6
        Me.CboLrcFunction.Text = "整体读入"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-94, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "文本格式"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-94, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "字幕载入算法"
        '
        'LblShowEnLyricFont
        '
        Me.LblShowEnLyricFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblShowEnLyricFont.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblShowEnLyricFont.Location = New System.Drawing.Point(154, 86)
        Me.LblShowEnLyricFont.Name = "LblShowEnLyricFont"
        Me.LblShowEnLyricFont.Size = New System.Drawing.Size(157, 19)
        Me.LblShowEnLyricFont.TabIndex = 14
        Me.LblShowEnLyricFont.Text = "影子播放器_ShadowPlayer"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "英文字幕字体"
        '
        'LblShowCnLyricFont
        '
        Me.LblShowCnLyricFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblShowCnLyricFont.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblShowCnLyricFont.Location = New System.Drawing.Point(154, 68)
        Me.LblShowCnLyricFont.Name = "LblShowCnLyricFont"
        Me.LblShowCnLyricFont.Size = New System.Drawing.Size(157, 19)
        Me.LblShowCnLyricFont.TabIndex = 12
        Me.LblShowCnLyricFont.Text = "影子播放器_ShadowPlayer"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "中文字幕字体"
        '
        'PicCnLyricColor
        '
        Me.PicCnLyricColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCnLyricColor.Location = New System.Drawing.Point(266, 28)
        Me.PicCnLyricColor.Name = "PicCnLyricColor"
        Me.PicCnLyricColor.Size = New System.Drawing.Size(45, 17)
        Me.PicCnLyricColor.TabIndex = 10
        Me.PicCnLyricColor.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "英文字幕颜色"
        '
        'PicEnLyricColor
        '
        Me.PicEnLyricColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicEnLyricColor.Location = New System.Drawing.Point(89, 28)
        Me.PicEnLyricColor.Name = "PicEnLyricColor"
        Me.PicEnLyricColor.Size = New System.Drawing.Size(45, 17)
        Me.PicEnLyricColor.TabIndex = 8
        Me.PicEnLyricColor.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "中文字幕颜色"
        '
        'LblShowLyricFont
        '
        Me.LblShowLyricFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblShowLyricFont.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblShowLyricFont.Location = New System.Drawing.Point(154, 49)
        Me.LblShowLyricFont.Name = "LblShowLyricFont"
        Me.LblShowLyricFont.Size = New System.Drawing.Size(157, 19)
        Me.LblShowLyricFont.TabIndex = 4
        Me.LblShowLyricFont.Text = "影子播放器_ShadowPlayer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "单行字幕字体"
        '
        'PicLyricColor
        '
        Me.PicLyricColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicLyricColor.Location = New System.Drawing.Point(89, 4)
        Me.PicLyricColor.Name = "PicLyricColor"
        Me.PicLyricColor.Size = New System.Drawing.Size(45, 17)
        Me.PicLyricColor.TabIndex = 2
        Me.PicLyricColor.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "单行字幕颜色"
        '
        'ChkLyricOpen
        '
        Me.ChkLyricOpen.AutoSize = True
        Me.ChkLyricOpen.Checked = True
        Me.ChkLyricOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLyricOpen.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkLyricOpen.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.ChkLyricOpen.Location = New System.Drawing.Point(31, 30)
        Me.ChkLyricOpen.Name = "ChkLyricOpen"
        Me.ChkLyricOpen.Size = New System.Drawing.Size(88, 24)
        Me.ChkLyricOpen.TabIndex = 6
        Me.ChkLyricOpen.Text = "开启字幕"
        Me.ChkLyricOpen.UseVisualStyleBackColor = True
        '
        'Panel_top
        '
        Me.Panel_top.Controls.Add(Me.lbl_CheckUpdates)
        Me.Panel_top.Controls.Add(Me.lbl_buidLevel)
        Me.Panel_top.Controls.Add(Me.lbl_mainLevel)
        Me.Panel_top.Controls.Add(Me.btn_Mainexit)
        Me.Panel_top.Controls.Add(Me.Lbl_title)
        Me.Panel_top.Location = New System.Drawing.Point(-1, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(549, 66)
        Me.Panel_top.TabIndex = 42
        '
        'lbl_CheckUpdates
        '
        Me.lbl_CheckUpdates.AutoSize = True
        Me.lbl_CheckUpdates.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lbl_CheckUpdates.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CheckUpdates.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_CheckUpdates.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_CheckUpdates.Location = New System.Drawing.Point(215, 29)
        Me.lbl_CheckUpdates.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lbl_CheckUpdates.Name = "lbl_CheckUpdates"
        Me.lbl_CheckUpdates.Size = New System.Drawing.Size(55, 13)
        Me.lbl_CheckUpdates.TabIndex = 27
        Me.lbl_CheckUpdates.TabStop = True
        Me.lbl_CheckUpdates.Text = "检查更新"
        '
        'lbl_buidLevel
        '
        Me.lbl_buidLevel.AutoSize = True
        Me.lbl_buidLevel.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.lbl_buidLevel.ForeColor = System.Drawing.Color.White
        Me.lbl_buidLevel.Location = New System.Drawing.Point(171, 31)
        Me.lbl_buidLevel.Name = "lbl_buidLevel"
        Me.lbl_buidLevel.Size = New System.Drawing.Size(38, 16)
        Me.lbl_buidLevel.TabIndex = 26
        Me.lbl_buidLevel.Text = "00000"
        '
        'lbl_mainLevel
        '
        Me.lbl_mainLevel.AutoSize = True
        Me.lbl_mainLevel.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.lbl_mainLevel.ForeColor = System.Drawing.Color.White
        Me.lbl_mainLevel.Location = New System.Drawing.Point(128, 27)
        Me.lbl_mainLevel.Name = "lbl_mainLevel"
        Me.lbl_mainLevel.Size = New System.Drawing.Size(51, 20)
        Me.lbl_mainLevel.TabIndex = 25
        Me.lbl_mainLevel.Text = "V4.0.0."
        '
        'btn_Mainexit
        '
        Me.btn_Mainexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mainexit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mainexit.FlatAppearance.BorderSize = 0
        Me.btn_Mainexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_Mainexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Mainexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mainexit.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mainexit.ForeColor = System.Drawing.Color.White
        Me.btn_Mainexit.Location = New System.Drawing.Point(504, 0)
        Me.btn_Mainexit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Mainexit.Name = "btn_Mainexit"
        Me.btn_Mainexit.Size = New System.Drawing.Size(45, 28)
        Me.btn_Mainexit.TabIndex = 24
        Me.btn_Mainexit.TabStop = False
        Me.btn_Mainexit.Text = "✕"
        Me.btn_Mainexit.UseVisualStyleBackColor = False
        '
        'Lbl_title
        '
        Me.Lbl_title.AutoSize = True
        Me.Lbl_title.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Lbl_title.ForeColor = System.Drawing.Color.White
        Me.Lbl_title.Location = New System.Drawing.Point(3, 16)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(134, 31)
        Me.Lbl_title.TabIndex = 23
        Me.Lbl_title.Text = "影子播放器"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_Lyric)
        Me.Panel1.Controls.Add(Me.btn_time)
        Me.Panel1.Location = New System.Drawing.Point(-1, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 354)
        Me.Panel1.TabIndex = 43
        '
        'btn_Lyric
        '
        Me.btn_Lyric.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Lyric.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_Lyric.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_Lyric.FlatAppearance.BorderSize = 0
        Me.btn_Lyric.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_Lyric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_Lyric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Lyric.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_Lyric.ForeColor = System.Drawing.Color.White
        Me.btn_Lyric.Location = New System.Drawing.Point(0, 36)
        Me.btn_Lyric.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btn_Lyric.Name = "btn_Lyric"
        Me.btn_Lyric.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_Lyric.Size = New System.Drawing.Size(94, 36)
        Me.btn_Lyric.TabIndex = 28
        Me.btn_Lyric.Text = "字幕"
        Me.btn_Lyric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Lyric.UseVisualStyleBackColor = False
        '
        'btn_time
        '
        Me.btn_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_time.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_time.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_time.FlatAppearance.BorderSize = 0
        Me.btn_time.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_time.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_time.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_time.ForeColor = System.Drawing.Color.White
        Me.btn_time.Location = New System.Drawing.Point(1, 0)
        Me.btn_time.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btn_time.Name = "btn_time"
        Me.btn_time.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_time.Size = New System.Drawing.Size(94, 36)
        Me.btn_time.TabIndex = 27
        Me.btn_time.Text = "定时"
        Me.btn_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_time.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("微软雅黑", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.LinkLabel1.Location = New System.Drawing.Point(121, 5)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(52, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "检查更新"
        Me.LinkLabel1.Visible = False
        '
        'chkAutoFullScreen
        '
        Me.chkAutoFullScreen.AutoSize = True
        Me.chkAutoFullScreen.Location = New System.Drawing.Point(10, 32)
        Me.chkAutoFullScreen.Name = "chkAutoFullScreen"
        Me.chkAutoFullScreen.Size = New System.Drawing.Size(147, 21)
        Me.chkAutoFullScreen.TabIndex = 46
        Me.chkAutoFullScreen.Text = "若为视频自动全屏播放"
        Me.chkAutoFullScreen.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 418)
        Me.Controls.Add(Me.Panel_top)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_time.ResumeLayout(False)
        Me.TabPage_time.PerformLayout()
        Me.PnlOpen.ResumeLayout(False)
        Me.PnlOpen.PerformLayout()
        Me.PnlStop.ResumeLayout(False)
        Me.PnlStop.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage_lyric.ResumeLayout(False)
        Me.TabPage_lyric.PerformLayout()
        Me.PnlLryic.ResumeLayout(False)
        Me.PnlLryic.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PicCnLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEnLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_time As TabPage
    Friend WithEvents TabPage_lyric As TabPage
    Friend WithEvents Panel_top As Panel
    Friend WithEvents btn_Mainexit As Button
    Friend WithEvents Lbl_title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Lyric As Button
    Friend WithEvents btn_time As Button
    Friend WithEvents PnlOpen As Panel
    Friend WithEvents txtLoudTime As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlStop As Panel
    Friend WithEvents RdoNext As RadioButton
    Friend WithEvents RdoStop As RadioButton
    Friend WithEvents RdoPause As RadioButton
    Friend WithEvents txtEndTime As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChkSetTimeEnabled As CheckBox
    Friend WithEvents ChkSetCloseEnabled As CheckBox
    Friend WithEvents PnlLryic As Panel
    Friend WithEvents LblShowEnLyricFont As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LblShowCnLyricFont As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PicCnLyricColor As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PicEnLyricColor As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LblShowLyricFont As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PicLyricColor As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkLyricOpen As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents RdoSetEndEnabled As RadioButton
    Friend WithEvents RdoSetMiniEnabled As RadioButton
    Friend WithEvents RdoSetCloseNothing As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnFilesystem As Button
    Friend WithEvents BtnAddLrc As Button
    Friend WithEvents TxtOriginLyr As TextBox
    Friend WithEvents CboOriginSong As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CboTextStyle As ComboBox
    Friend WithEvents CboLrcFunction As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_mainLevel As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl_buidLevel As Label
    Friend WithEvents lbl_CheckUpdates As LinkLabel
    Friend WithEvents btn_saveLoudTime As Button
    Friend WithEvents btn_saveCloseTime As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents chkAutoFullScreen As CheckBox
End Class
