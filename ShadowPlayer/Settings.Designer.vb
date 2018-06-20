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
        Me.PnlOpen = New System.Windows.Forms.Panel()
        Me.txtLoudTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlStop = New System.Windows.Forms.Panel()
        Me.GrpStopBehavior = New System.Windows.Forms.GroupBox()
        Me.RdoNext = New System.Windows.Forms.RadioButton()
        Me.RdoStop = New System.Windows.Forms.RadioButton()
        Me.RdoPause = New System.Windows.Forms.RadioButton()
        Me.txtEndTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpStopMode = New System.Windows.Forms.GroupBox()
        Me.RdoSetEndEnabled = New System.Windows.Forms.RadioButton()
        Me.RdoSetMiniEnabled = New System.Windows.Forms.RadioButton()
        Me.RdoSetCloseNothing = New System.Windows.Forms.RadioButton()
        Me.ChkSetTimeEnabled = New System.Windows.Forms.CheckBox()
        Me.ChkSetCloseEnabled = New System.Windows.Forms.CheckBox()
        Me.TabPage_lyric = New System.Windows.Forms.TabPage()
        Me.PnlLryic = New System.Windows.Forms.Panel()
        Me.LblShowEnLyricFont = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblShowCnLyricFont = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PicCnLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PicEnLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboTextStyle = New System.Windows.Forms.ComboBox()
        Me.CboLrcFunction = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblShowLyricFont = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicLyricColor = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkLyricOpen = New System.Windows.Forms.CheckBox()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.btn_Mainexit = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Lyric = New System.Windows.Forms.Button()
        Me.btn_time = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboOriginSong = New System.Windows.Forms.ComboBox()
        Me.TxtOriginLyr = New System.Windows.Forms.TextBox()
        Me.BtnAddLrc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnFilesystem = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_time.SuspendLayout()
        Me.PnlOpen.SuspendLayout()
        Me.PnlStop.SuspendLayout()
        Me.GrpStopBehavior.SuspendLayout()
        Me.GrpStopMode.SuspendLayout()
        Me.TabPage_lyric.SuspendLayout()
        Me.PnlLryic.SuspendLayout()
        CType(Me.PicCnLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEnLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicLyricColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_top.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'PnlOpen
        '
        Me.PnlOpen.Controls.Add(Me.txtLoudTime)
        Me.PnlOpen.Controls.Add(Me.Label1)
        Me.PnlOpen.ForeColor = System.Drawing.Color.Black
        Me.PnlOpen.Location = New System.Drawing.Point(106, 65)
        Me.PnlOpen.Name = "PnlOpen"
        Me.PnlOpen.Size = New System.Drawing.Size(160, 26)
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
        Me.PnlStop.Controls.Add(Me.GrpStopBehavior)
        Me.PnlStop.Controls.Add(Me.txtEndTime)
        Me.PnlStop.Controls.Add(Me.Label2)
        Me.PnlStop.Controls.Add(Me.GrpStopMode)
        Me.PnlStop.ForeColor = System.Drawing.Color.Black
        Me.PnlStop.Location = New System.Drawing.Point(32, 129)
        Me.PnlStop.Name = "PnlStop"
        Me.PnlStop.Size = New System.Drawing.Size(305, 139)
        Me.PnlStop.TabIndex = 44
        '
        'GrpStopBehavior
        '
        Me.GrpStopBehavior.Controls.Add(Me.RdoNext)
        Me.GrpStopBehavior.Controls.Add(Me.RdoStop)
        Me.GrpStopBehavior.Controls.Add(Me.RdoPause)
        Me.GrpStopBehavior.Location = New System.Drawing.Point(149, 44)
        Me.GrpStopBehavior.Name = "GrpStopBehavior"
        Me.GrpStopBehavior.Size = New System.Drawing.Size(153, 77)
        Me.GrpStopBehavior.TabIndex = 38
        Me.GrpStopBehavior.TabStop = False
        Me.GrpStopBehavior.Text = "停止后动作"
        '
        'RdoNext
        '
        Me.RdoNext.AutoSize = True
        Me.RdoNext.Checked = True
        Me.RdoNext.Location = New System.Drawing.Point(6, 50)
        Me.RdoNext.Name = "RdoNext"
        Me.RdoNext.Size = New System.Drawing.Size(98, 21)
        Me.RdoNext.TabIndex = 2
        Me.RdoNext.TabStop = True
        Me.RdoNext.Text = "切换到下一首"
        Me.RdoNext.UseVisualStyleBackColor = True
        '
        'RdoStop
        '
        Me.RdoStop.AutoSize = True
        Me.RdoStop.Location = New System.Drawing.Point(6, 33)
        Me.RdoStop.Name = "RdoStop"
        Me.RdoStop.Size = New System.Drawing.Size(98, 21)
        Me.RdoStop.TabIndex = 1
        Me.RdoStop.Text = "停止当前歌曲"
        Me.RdoStop.UseVisualStyleBackColor = True
        '
        'RdoPause
        '
        Me.RdoPause.AutoSize = True
        Me.RdoPause.Location = New System.Drawing.Point(6, 16)
        Me.RdoPause.Name = "RdoPause"
        Me.RdoPause.Size = New System.Drawing.Size(98, 21)
        Me.RdoPause.TabIndex = 0
        Me.RdoPause.Text = "暂停当前歌曲"
        Me.RdoPause.UseVisualStyleBackColor = True
        '
        'txtEndTime
        '
        Me.txtEndTime.AsciiOnly = True
        Me.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEndTime.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtEndTime.Location = New System.Drawing.Point(142, 5)
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
        Me.Label2.Location = New System.Drawing.Point(83, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "关闭时间"
        '
        'GrpStopMode
        '
        Me.GrpStopMode.Controls.Add(Me.RdoSetEndEnabled)
        Me.GrpStopMode.Controls.Add(Me.RdoSetMiniEnabled)
        Me.GrpStopMode.Controls.Add(Me.RdoSetCloseNothing)
        Me.GrpStopMode.Location = New System.Drawing.Point(8, 43)
        Me.GrpStopMode.Name = "GrpStopMode"
        Me.GrpStopMode.Size = New System.Drawing.Size(135, 78)
        Me.GrpStopMode.TabIndex = 37
        Me.GrpStopMode.TabStop = False
        Me.GrpStopMode.Text = "停止模式"
        '
        'RdoSetEndEnabled
        '
        Me.RdoSetEndEnabled.AutoSize = True
        Me.RdoSetEndEnabled.Location = New System.Drawing.Point(6, 33)
        Me.RdoSetEndEnabled.Name = "RdoSetEndEnabled"
        Me.RdoSetEndEnabled.Size = New System.Drawing.Size(110, 21)
        Me.RdoSetEndEnabled.TabIndex = 34
        Me.RdoSetEndEnabled.Text = "停止时关闭程序"
        Me.RdoSetEndEnabled.UseVisualStyleBackColor = True
        '
        'RdoSetMiniEnabled
        '
        Me.RdoSetMiniEnabled.AutoSize = True
        Me.RdoSetMiniEnabled.Checked = True
        Me.RdoSetMiniEnabled.Location = New System.Drawing.Point(6, 51)
        Me.RdoSetMiniEnabled.Name = "RdoSetMiniEnabled"
        Me.RdoSetMiniEnabled.Size = New System.Drawing.Size(122, 21)
        Me.RdoSetMiniEnabled.TabIndex = 35
        Me.RdoSetMiniEnabled.TabStop = True
        Me.RdoSetMiniEnabled.Text = "停止时最小化程序"
        Me.RdoSetMiniEnabled.UseVisualStyleBackColor = True
        '
        'RdoSetCloseNothing
        '
        Me.RdoSetCloseNothing.AutoSize = True
        Me.RdoSetCloseNothing.Location = New System.Drawing.Point(6, 16)
        Me.RdoSetCloseNothing.Name = "RdoSetCloseNothing"
        Me.RdoSetCloseNothing.Size = New System.Drawing.Size(62, 21)
        Me.RdoSetCloseNothing.TabIndex = 36
        Me.RdoSetCloseNothing.Text = "仅停止"
        Me.RdoSetCloseNothing.UseVisualStyleBackColor = True
        '
        'ChkSetTimeEnabled
        '
        Me.ChkSetTimeEnabled.AutoSize = True
        Me.ChkSetTimeEnabled.BackColor = System.Drawing.Color.Transparent
        Me.ChkSetTimeEnabled.Checked = True
        Me.ChkSetTimeEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSetTimeEnabled.ForeColor = System.Drawing.Color.Black
        Me.ChkSetTimeEnabled.Location = New System.Drawing.Point(32, 38)
        Me.ChkSetTimeEnabled.Name = "ChkSetTimeEnabled"
        Me.ChkSetTimeEnabled.Size = New System.Drawing.Size(99, 21)
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
        Me.ChkSetCloseEnabled.ForeColor = System.Drawing.Color.Black
        Me.ChkSetCloseEnabled.Location = New System.Drawing.Point(32, 102)
        Me.ChkSetCloseEnabled.Name = "ChkSetCloseEnabled"
        Me.ChkSetCloseEnabled.Size = New System.Drawing.Size(99, 21)
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
        Me.PnlLryic.Controls.Add(Me.LblShowEnLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label14)
        Me.PnlLryic.Controls.Add(Me.LblShowCnLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label12)
        Me.PnlLryic.Controls.Add(Me.PicCnLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label10)
        Me.PnlLryic.Controls.Add(Me.PicEnLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label9)
        Me.PnlLryic.Controls.Add(Me.GroupBox1)
        Me.PnlLryic.Controls.Add(Me.LblShowLyricFont)
        Me.PnlLryic.Controls.Add(Me.Label4)
        Me.PnlLryic.Controls.Add(Me.PicLyricColor)
        Me.PnlLryic.Controls.Add(Me.Label3)
        Me.PnlLryic.Location = New System.Drawing.Point(31, 57)
        Me.PnlLryic.Name = "PnlLryic"
        Me.PnlLryic.Size = New System.Drawing.Size(389, 303)
        Me.PnlLryic.TabIndex = 7
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTextStyle)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CboLrcFunction)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 184)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "字幕文件载入"
        '
        'CboTextStyle
        '
        Me.CboTextStyle.FormattingEnabled = True
        Me.CboTextStyle.Items.AddRange(New Object() {"UTF-8", "默认", "ASCII", "Unicode"})
        Me.CboTextStyle.Location = New System.Drawing.Point(109, 44)
        Me.CboTextStyle.Name = "CboTextStyle"
        Me.CboTextStyle.Size = New System.Drawing.Size(184, 25)
        Me.CboTextStyle.TabIndex = 3
        Me.CboTextStyle.Text = "UTF-8"
        '
        'CboLrcFunction
        '
        Me.CboLrcFunction.FormattingEnabled = True
        Me.CboLrcFunction.Items.AddRange(New Object() {"整体读入", "逐行读入"})
        Me.CboLrcFunction.Location = New System.Drawing.Point(109, 16)
        Me.CboLrcFunction.Name = "CboLrcFunction"
        Me.CboLrcFunction.Size = New System.Drawing.Size(184, 25)
        Me.CboLrcFunction.TabIndex = 1
        Me.CboLrcFunction.Text = "整体读入"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "文本格式"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "字幕载入算法"
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
        Me.ChkLyricOpen.Location = New System.Drawing.Point(31, 30)
        Me.ChkLyricOpen.Name = "ChkLyricOpen"
        Me.ChkLyricOpen.Size = New System.Drawing.Size(75, 21)
        Me.ChkLyricOpen.TabIndex = 6
        Me.ChkLyricOpen.Text = "开启字幕"
        Me.ChkLyricOpen.UseVisualStyleBackColor = True
        '
        'Panel_top
        '
        Me.Panel_top.Controls.Add(Me.btn_Mainexit)
        Me.Panel_top.Controls.Add(Me.Lbl_title)
        Me.Panel_top.Location = New System.Drawing.Point(-1, 0)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(549, 66)
        Me.Panel_top.TabIndex = 42
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
        Me.Lbl_title.Font = New System.Drawing.Font("微软雅黑", 13.75!)
        Me.Lbl_title.ForeColor = System.Drawing.Color.White
        Me.Lbl_title.Location = New System.Drawing.Point(3, 19)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(107, 25)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "目标歌曲"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "目标歌词"
        '
        'CboOriginSong
        '
        Me.CboOriginSong.FormattingEnabled = True
        Me.CboOriginSong.Location = New System.Drawing.Point(69, 18)
        Me.CboOriginSong.Name = "CboOriginSong"
        Me.CboOriginSong.Size = New System.Drawing.Size(220, 25)
        Me.CboOriginSong.TabIndex = 5
        '
        'TxtOriginLyr
        '
        Me.TxtOriginLyr.Location = New System.Drawing.Point(69, 51)
        Me.TxtOriginLyr.Name = "TxtOriginLyr"
        Me.TxtOriginLyr.Size = New System.Drawing.Size(185, 23)
        Me.TxtOriginLyr.TabIndex = 6
        '
        'BtnAddLrc
        '
        Me.BtnAddLrc.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnAddLrc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnAddLrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddLrc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnAddLrc.ForeColor = System.Drawing.Color.White
        Me.BtnAddLrc.Location = New System.Drawing.Point(117, 80)
        Me.BtnAddLrc.Name = "BtnAddLrc"
        Me.BtnAddLrc.Size = New System.Drawing.Size(75, 25)
        Me.BtnAddLrc.TabIndex = 15
        Me.BtnAddLrc.Text = "导入"
        Me.BtnAddLrc.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFilesystem)
        Me.GroupBox2.Controls.Add(Me.BtnAddLrc)
        Me.GroupBox2.Controls.Add(Me.TxtOriginLyr)
        Me.GroupBox2.Controls.Add(Me.CboOriginSong)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 112)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "手动载入"
        '
        'BtnFilesystem
        '
        Me.BtnFilesystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.BtnFilesystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.BtnFilesystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilesystem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnFilesystem.ForeColor = System.Drawing.Color.White
        Me.BtnFilesystem.Location = New System.Drawing.Point(256, 51)
        Me.BtnFilesystem.Name = "BtnFilesystem"
        Me.BtnFilesystem.Size = New System.Drawing.Size(33, 23)
        Me.BtnFilesystem.TabIndex = 16
        Me.BtnFilesystem.Text = "..."
        Me.BtnFilesystem.UseVisualStyleBackColor = False
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
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_time.ResumeLayout(False)
        Me.TabPage_time.PerformLayout()
        Me.PnlOpen.ResumeLayout(False)
        Me.PnlOpen.PerformLayout()
        Me.PnlStop.ResumeLayout(False)
        Me.PnlStop.PerformLayout()
        Me.GrpStopBehavior.ResumeLayout(False)
        Me.GrpStopBehavior.PerformLayout()
        Me.GrpStopMode.ResumeLayout(False)
        Me.GrpStopMode.PerformLayout()
        Me.TabPage_lyric.ResumeLayout(False)
        Me.TabPage_lyric.PerformLayout()
        Me.PnlLryic.ResumeLayout(False)
        Me.PnlLryic.PerformLayout()
        CType(Me.PicCnLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEnLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicLyricColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_top.ResumeLayout(False)
        Me.Panel_top.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GrpStopBehavior As GroupBox
    Friend WithEvents RdoNext As RadioButton
    Friend WithEvents RdoStop As RadioButton
    Friend WithEvents RdoPause As RadioButton
    Friend WithEvents txtEndTime As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GrpStopMode As GroupBox
    Friend WithEvents RdoSetEndEnabled As RadioButton
    Friend WithEvents RdoSetMiniEnabled As RadioButton
    Friend WithEvents RdoSetCloseNothing As RadioButton
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CboTextStyle As ComboBox
    Friend WithEvents CboLrcFunction As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblShowLyricFont As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PicLyricColor As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ChkLyricOpen As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnFilesystem As Button
    Friend WithEvents BtnAddLrc As Button
    Friend WithEvents TxtOriginLyr As TextBox
    Friend WithEvents CboOriginSong As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
