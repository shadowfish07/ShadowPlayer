﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modren_UI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modren_UI))
        Me.btn_Mainmin = New System.Windows.Forms.Button()
        Me.btn_Mainmax = New System.Windows.Forms.Button()
        Me.btn_Mainexit = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.播放ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.播放ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.暂停ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lbl_MusicName = New System.Windows.Forms.Label()
        Me.Pnl_Circle = New System.Windows.Forms.Panel()
        Me.Lbl_TotalTime = New System.Windows.Forms.Label()
        Me.Lbl_NowTime = New System.Windows.Forms.Label()
        Me.Lbl_LryicDown = New System.Windows.Forms.Label()
        Me.Lbl_LryicUp = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_FullScreen = New System.Windows.Forms.Button()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_List = New System.Windows.Forms.Button()
        Me.Btn_PrevMusic = New System.Windows.Forms.Button()
        Me.Btn_NextMusic = New System.Windows.Forms.Button()
        Me.Btn_Stop = New System.Windows.Forms.Button()
        Me.Btn_PlayPause = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Alarm = New System.Windows.Forms.Button()
        Me.Lbl_Vision = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel_top = New System.Windows.Forms.Panel()
        Me.Panel_hideList = New System.Windows.Forms.Panel()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_MoveToUp = New System.Windows.Forms.Button()
        Me.Btn_MoveToDown = New System.Windows.Forms.Button()
        Me.Timer_List = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Lbl_PlayMode = New System.Windows.Forms.Label()
        Me.Timer_PlayMode = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Pnl_Circle.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Mainmin
        '
        Me.btn_Mainmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mainmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mainmin.FlatAppearance.BorderSize = 0
        Me.btn_Mainmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_Mainmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Mainmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mainmin.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!)
        Me.btn_Mainmin.ForeColor = System.Drawing.Color.White
        Me.btn_Mainmin.Location = New System.Drawing.Point(537, -4)
        Me.btn_Mainmin.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Mainmin.Name = "btn_Mainmin"
        Me.btn_Mainmin.Size = New System.Drawing.Size(52, 55)
        Me.btn_Mainmin.TabIndex = 20
        Me.btn_Mainmin.TabStop = False
        Me.btn_Mainmin.Text = "—"
        Me.btn_Mainmin.UseVisualStyleBackColor = False
        '
        'btn_Mainmax
        '
        Me.btn_Mainmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mainmax.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mainmax.FlatAppearance.BorderSize = 0
        Me.btn_Mainmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_Mainmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Mainmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mainmax.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!)
        Me.btn_Mainmax.ForeColor = System.Drawing.Color.White
        Me.btn_Mainmax.Location = New System.Drawing.Point(604, -4)
        Me.btn_Mainmax.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Mainmax.Name = "btn_Mainmax"
        Me.btn_Mainmax.Size = New System.Drawing.Size(51, 55)
        Me.btn_Mainmax.TabIndex = 19
        Me.btn_Mainmax.TabStop = False
        Me.btn_Mainmax.Text = "☐"
        Me.btn_Mainmax.UseVisualStyleBackColor = False
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
        Me.btn_Mainexit.Location = New System.Drawing.Point(655, -4)
        Me.btn_Mainexit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Mainexit.Name = "btn_Mainexit"
        Me.btn_Mainexit.Size = New System.Drawing.Size(66, 55)
        Me.btn_Mainexit.TabIndex = 18
        Me.btn_Mainexit.TabStop = False
        Me.btn_Mainexit.Text = "✕"
        Me.btn_Mainexit.UseVisualStyleBackColor = False
        '
        'Lbl_title
        '
        Me.Lbl_title.AutoSize = True
        Me.Lbl_title.Font = New System.Drawing.Font("微软雅黑", 13.75!)
        Me.Lbl_title.ForeColor = System.Drawing.Color.White
        Me.Lbl_title.Location = New System.Drawing.Point(14, 16)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(107, 25)
        Me.Lbl_title.TabIndex = 21
        Me.Lbl_title.Text = "影子播放器"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "影子播放器"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.播放ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(112, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem1.Text = "打开主界面"
        '
        '播放ToolStripMenuItem
        '
        Me.播放ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.播放ToolStripMenuItem1, Me.暂停ToolStripMenuItem, Me.停止ToolStripMenuItem})
        Me.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem"
        Me.播放ToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.播放ToolStripMenuItem.Text = "播放控制"
        '
        '播放ToolStripMenuItem1
        '
        Me.播放ToolStripMenuItem1.Enabled = False
        Me.播放ToolStripMenuItem1.Name = "播放ToolStripMenuItem1"
        Me.播放ToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.播放ToolStripMenuItem1.Text = "播放"
        '
        '暂停ToolStripMenuItem
        '
        Me.暂停ToolStripMenuItem.Enabled = False
        Me.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem"
        Me.暂停ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.暂停ToolStripMenuItem.Text = "暂停"
        '
        '停止ToolStripMenuItem
        '
        Me.停止ToolStripMenuItem.Enabled = False
        Me.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem"
        Me.停止ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.停止ToolStripMenuItem.Text = "停止"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Lbl_MusicName
        '
        Me.Lbl_MusicName.AllowDrop = True
        Me.Lbl_MusicName.AutoEllipsis = True
        Me.Lbl_MusicName.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Lbl_MusicName.Location = New System.Drawing.Point(157, 81)
        Me.Lbl_MusicName.Name = "Lbl_MusicName"
        Me.Lbl_MusicName.Size = New System.Drawing.Size(404, 30)
        Me.Lbl_MusicName.TabIndex = 23
        Me.Lbl_MusicName.Text = "MusicName"
        Me.Lbl_MusicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pnl_Circle
        '
        Me.Pnl_Circle.Controls.Add(Me.Lbl_TotalTime)
        Me.Pnl_Circle.Controls.Add(Me.Lbl_NowTime)
        Me.Pnl_Circle.Location = New System.Drawing.Point(259, 128)
        Me.Pnl_Circle.Name = "Pnl_Circle"
        Me.Pnl_Circle.Size = New System.Drawing.Size(200, 200)
        Me.Pnl_Circle.TabIndex = 26
        '
        'Lbl_TotalTime
        '
        Me.Lbl_TotalTime.Font = New System.Drawing.Font("微软雅黑", 14.0!)
        Me.Lbl_TotalTime.ForeColor = System.Drawing.Color.Silver
        Me.Lbl_TotalTime.Location = New System.Drawing.Point(41, 110)
        Me.Lbl_TotalTime.Name = "Lbl_TotalTime"
        Me.Lbl_TotalTime.Size = New System.Drawing.Size(119, 25)
        Me.Lbl_TotalTime.TabIndex = 27
        Me.Lbl_TotalTime.Text = "00:00"
        Me.Lbl_TotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_NowTime
        '
        Me.Lbl_NowTime.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Lbl_NowTime.Location = New System.Drawing.Point(41, 65)
        Me.Lbl_NowTime.Name = "Lbl_NowTime"
        Me.Lbl_NowTime.Size = New System.Drawing.Size(119, 45)
        Me.Lbl_NowTime.TabIndex = 26
        Me.Lbl_NowTime.Text = "00:00"
        Me.Lbl_NowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_LryicDown
        '
        Me.Lbl_LryicDown.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.Lbl_LryicDown.ForeColor = System.Drawing.Color.Gold
        Me.Lbl_LryicDown.Location = New System.Drawing.Point(-1, 449)
        Me.Lbl_LryicDown.Name = "Lbl_LryicDown"
        Me.Lbl_LryicDown.Size = New System.Drawing.Size(719, 42)
        Me.Lbl_LryicDown.TabIndex = 33
        Me.Lbl_LryicDown.Text = "影子播放器_追求，永无止境"
        Me.Lbl_LryicDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_LryicDown.Visible = False
        '
        'Lbl_LryicUp
        '
        Me.Lbl_LryicUp.Font = New System.Drawing.Font("微软雅黑", 20.0!)
        Me.Lbl_LryicUp.ForeColor = System.Drawing.Color.Moccasin
        Me.Lbl_LryicUp.Location = New System.Drawing.Point(-1, 409)
        Me.Lbl_LryicUp.Name = "Lbl_LryicUp"
        Me.Lbl_LryicUp.Size = New System.Drawing.Size(721, 47)
        Me.Lbl_LryicUp.TabIndex = 32
        Me.Lbl_LryicUp.Text = "Soon I'll be 60 years old, will I think the world is cold"
        Me.Lbl_LryicUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_LryicUp.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AllowDrop = True
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(537, 122)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(181, 235)
        Me.FlowLayoutPanel1.TabIndex = 34
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'Btn_FullScreen
        '
        Me.Btn_FullScreen.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.全屏
        Me.Btn_FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_FullScreen.FlatAppearance.BorderSize = 0
        Me.Btn_FullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_FullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FullScreen.ForeColor = System.Drawing.Color.White
        Me.Btn_FullScreen.Location = New System.Drawing.Point(237, 334)
        Me.Btn_FullScreen.Name = "Btn_FullScreen"
        Me.Btn_FullScreen.Size = New System.Drawing.Size(16, 16)
        Me.Btn_FullScreen.TabIndex = 37
        Me.Btn_FullScreen.TabStop = False
        Me.Btn_FullScreen.UseVisualStyleBackColor = False
        Me.Btn_FullScreen.Visible = False
        '
        'Btn_Settings
        '
        Me.Btn_Settings.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.设置
        Me.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Settings.FlatAppearance.BorderSize = 0
        Me.Btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.ForeColor = System.Drawing.Color.White
        Me.Btn_Settings.Location = New System.Drawing.Point(509, 12)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(16, 16)
        Me.Btn_Settings.TabIndex = 36
        Me.Btn_Settings.TabStop = False
        Me.Btn_Settings.UseVisualStyleBackColor = False
        '
        'Btn_List
        '
        Me.Btn_List.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.Content
        Me.Btn_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_List.FlatAppearance.BorderSize = 0
        Me.Btn_List.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_List.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_List.ForeColor = System.Drawing.Color.White
        Me.Btn_List.Location = New System.Drawing.Point(686, 85)
        Me.Btn_List.Name = "Btn_List"
        Me.Btn_List.Size = New System.Drawing.Size(32, 32)
        Me.Btn_List.TabIndex = 35
        Me.Btn_List.TabStop = False
        Me.Btn_List.UseVisualStyleBackColor = False
        '
        'Btn_PrevMusic
        '
        Me.Btn_PrevMusic.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.Prev
        Me.Btn_PrevMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_PrevMusic.FlatAppearance.BorderSize = 0
        Me.Btn_PrevMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_PrevMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_PrevMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PrevMusic.ForeColor = System.Drawing.Color.White
        Me.Btn_PrevMusic.Location = New System.Drawing.Point(300, 349)
        Me.Btn_PrevMusic.Name = "Btn_PrevMusic"
        Me.Btn_PrevMusic.Size = New System.Drawing.Size(20, 20)
        Me.Btn_PrevMusic.TabIndex = 30
        Me.Btn_PrevMusic.TabStop = False
        Me.Btn_PrevMusic.UseVisualStyleBackColor = False
        '
        'Btn_NextMusic
        '
        Me.Btn_NextMusic.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.NextP
        Me.Btn_NextMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_NextMusic.FlatAppearance.BorderSize = 0
        Me.Btn_NextMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_NextMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_NextMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_NextMusic.ForeColor = System.Drawing.Color.White
        Me.Btn_NextMusic.Location = New System.Drawing.Point(399, 349)
        Me.Btn_NextMusic.Name = "Btn_NextMusic"
        Me.Btn_NextMusic.Size = New System.Drawing.Size(20, 20)
        Me.Btn_NextMusic.TabIndex = 29
        Me.Btn_NextMusic.TabStop = False
        Me.Btn_NextMusic.UseVisualStyleBackColor = False
        '
        'Btn_Stop
        '
        Me.Btn_Stop.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.StopP
        Me.Btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Stop.FlatAppearance.BorderSize = 0
        Me.Btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Stop.ForeColor = System.Drawing.Color.White
        Me.Btn_Stop.Location = New System.Drawing.Point(366, 349)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Stop.TabIndex = 28
        Me.Btn_Stop.TabStop = False
        Me.Btn_Stop.UseVisualStyleBackColor = False
        '
        'Btn_PlayPause
        '
        Me.Btn_PlayPause.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.Play
        Me.Btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_PlayPause.FlatAppearance.BorderSize = 0
        Me.Btn_PlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_PlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PlayPause.ForeColor = System.Drawing.Color.White
        Me.Btn_PlayPause.Location = New System.Drawing.Point(333, 349)
        Me.Btn_PlayPause.Name = "Btn_PlayPause"
        Me.Btn_PlayPause.Size = New System.Drawing.Size(20, 20)
        Me.Btn_PlayPause.TabIndex = 27
        Me.Btn_PlayPause.TabStop = False
        Me.Btn_PlayPause.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FilterIndex = 3
        Me.OpenFileDialog1.Multiselect = True
        '
        'Btn_Alarm
        '
        Me.Btn_Alarm.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.闹钟
        Me.Btn_Alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Alarm.FlatAppearance.BorderSize = 0
        Me.Btn_Alarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Alarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Alarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Alarm.ForeColor = System.Drawing.Color.White
        Me.Btn_Alarm.Location = New System.Drawing.Point(651, 85)
        Me.Btn_Alarm.Name = "Btn_Alarm"
        Me.Btn_Alarm.Size = New System.Drawing.Size(32, 32)
        Me.Btn_Alarm.TabIndex = 38
        Me.Btn_Alarm.TabStop = False
        Me.Btn_Alarm.UseVisualStyleBackColor = False
        '
        'Lbl_Vision
        '
        Me.Lbl_Vision.AutoSize = True
        Me.Lbl_Vision.Dock = System.Windows.Forms.DockStyle.Right
        Me.Lbl_Vision.Location = New System.Drawing.Point(194, 0)
        Me.Lbl_Vision.Name = "Lbl_Vision"
        Me.Lbl_Vision.Size = New System.Drawing.Size(65, 17)
        Me.Lbl_Vision.TabIndex = 39
        Me.Lbl_Vision.Text = "Lbl_Vision"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Vision)
        Me.Panel2.Location = New System.Drawing.Point(462, 505)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 15)
        Me.Panel2.TabIndex = 40
        '
        'Panel_top
        '
        Me.Panel_top.Location = New System.Drawing.Point(-4, -4)
        Me.Panel_top.Name = "Panel_top"
        Me.Panel_top.Size = New System.Drawing.Size(725, 68)
        Me.Panel_top.TabIndex = 41
        '
        'Panel_hideList
        '
        Me.Panel_hideList.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_hideList.Location = New System.Drawing.Point(537, 121)
        Me.Panel_hideList.Name = "Panel_hideList"
        Me.Panel_hideList.Size = New System.Drawing.Size(180, 241)
        Me.Panel_hideList.TabIndex = 42
        '
        'Btn_Add
        '
        Me.Btn_Add.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.新增
        Me.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Add.FlatAppearance.BorderSize = 0
        Me.Btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.Location = New System.Drawing.Point(684, 85)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(34, 34)
        Me.Btn_Add.TabIndex = 43
        Me.Btn_Add.TabStop = False
        Me.Btn_Add.UseVisualStyleBackColor = False
        Me.Btn_Add.Visible = False
        '
        'Btn_Remove
        '
        Me.Btn_Remove.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.移除
        Me.Btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.ForeColor = System.Drawing.Color.White
        Me.Btn_Remove.Location = New System.Drawing.Point(649, 85)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Size = New System.Drawing.Size(32, 32)
        Me.Btn_Remove.TabIndex = 44
        Me.Btn_Remove.TabStop = False
        Me.Btn_Remove.UseVisualStyleBackColor = False
        Me.Btn_Remove.Visible = False
        '
        'Btn_MoveToUp
        '
        Me.Btn_MoveToUp.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.上移
        Me.Btn_MoveToUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_MoveToUp.FlatAppearance.BorderSize = 0
        Me.Btn_MoveToUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_MoveToUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_MoveToUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MoveToUp.ForeColor = System.Drawing.Color.White
        Me.Btn_MoveToUp.Location = New System.Drawing.Point(616, 85)
        Me.Btn_MoveToUp.Name = "Btn_MoveToUp"
        Me.Btn_MoveToUp.Size = New System.Drawing.Size(32, 32)
        Me.Btn_MoveToUp.TabIndex = 45
        Me.Btn_MoveToUp.TabStop = False
        Me.Btn_MoveToUp.UseVisualStyleBackColor = False
        Me.Btn_MoveToUp.Visible = False
        '
        'Btn_MoveToDown
        '
        Me.Btn_MoveToDown.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.下移
        Me.Btn_MoveToDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_MoveToDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_MoveToDown.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_MoveToDown.FlatAppearance.BorderSize = 0
        Me.Btn_MoveToDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_MoveToDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_MoveToDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MoveToDown.ForeColor = System.Drawing.Color.White
        Me.Btn_MoveToDown.Location = New System.Drawing.Point(583, 85)
        Me.Btn_MoveToDown.Name = "Btn_MoveToDown"
        Me.Btn_MoveToDown.Size = New System.Drawing.Size(32, 32)
        Me.Btn_MoveToDown.TabIndex = 46
        Me.Btn_MoveToDown.TabStop = False
        Me.Btn_MoveToDown.UseVisualStyleBackColor = False
        Me.Btn_MoveToDown.Visible = False
        '
        'Timer_List
        '
        Me.Timer_List.Interval = 1000
        '
        'Player
        '
        Me.Player.Enabled = True
        Me.Player.Location = New System.Drawing.Point(12, 128)
        Me.Player.Name = "Player"
        Me.Player.OcxState = CType(resources.GetObject("Player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Player.Size = New System.Drawing.Size(241, 200)
        Me.Player.TabIndex = 37
        Me.Player.Visible = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(642, 365)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 20)
        Me.label1.TabIndex = 47
        Me.label1.Text = "播放模式"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl_PlayMode
        '
        Me.Lbl_PlayMode.AutoSize = True
        Me.Lbl_PlayMode.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.Lbl_PlayMode.ForeColor = System.Drawing.Color.Gainsboro
        Me.Lbl_PlayMode.Location = New System.Drawing.Point(642, 365)
        Me.Lbl_PlayMode.Name = "Lbl_PlayMode"
        Me.Lbl_PlayMode.Size = New System.Drawing.Size(65, 20)
        Me.Lbl_PlayMode.TabIndex = 48
        Me.Lbl_PlayMode.Text = "单次列表"
        Me.Lbl_PlayMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer_PlayMode
        '
        Me.Timer_PlayMode.Interval = 1000
        '
        'Modren_UI
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 521)
        Me.Controls.Add(Me.Lbl_PlayMode)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Btn_Alarm)
        Me.Controls.Add(Me.Btn_MoveToDown)
        Me.Controls.Add(Me.Btn_MoveToUp)
        Me.Controls.Add(Me.Panel_hideList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_FullScreen)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Lbl_LryicDown)
        Me.Controls.Add(Me.Lbl_LryicUp)
        Me.Controls.Add(Me.Btn_PrevMusic)
        Me.Controls.Add(Me.Btn_NextMusic)
        Me.Controls.Add(Me.Btn_Stop)
        Me.Controls.Add(Me.Btn_PlayPause)
        Me.Controls.Add(Me.Pnl_Circle)
        Me.Controls.Add(Me.Lbl_MusicName)
        Me.Controls.Add(Me.Lbl_title)
        Me.Controls.Add(Me.btn_Mainmin)
        Me.Controls.Add(Me.btn_Mainmax)
        Me.Controls.Add(Me.btn_Mainexit)
        Me.Controls.Add(Me.Panel_top)
        Me.Controls.Add(Me.Btn_List)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Btn_Remove)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Modren_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShadowPlayer"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Pnl_Circle.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Mainmin As Button
    Friend WithEvents btn_Mainmax As Button
    Friend WithEvents btn_Mainexit As Button
    Friend WithEvents Lbl_title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 播放ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 播放ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 暂停ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停止ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Lbl_MusicName As Label
    Friend WithEvents Pnl_Circle As Panel
    Friend WithEvents Lbl_TotalTime As Label
    Friend WithEvents Lbl_NowTime As Label
    Friend WithEvents Btn_PlayPause As Button
    Friend WithEvents Btn_Stop As Button
    Friend WithEvents Btn_NextMusic As Button
    Friend WithEvents Btn_PrevMusic As Button
    Friend WithEvents Lbl_LryicDown As Label
    Friend WithEvents Lbl_LryicUp As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn_List As Button
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents Player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Btn_FullScreen As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Btn_Alarm As Button
    Friend WithEvents Lbl_Vision As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_top As Panel
    Friend WithEvents Panel_hideList As Panel
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_MoveToUp As Button
    Friend WithEvents Btn_MoveToDown As Button
    Friend WithEvents Timer_List As Timer
    Friend WithEvents label1 As Label
    Friend WithEvents Lbl_PlayMode As Label
    Friend WithEvents Timer_PlayMode As Timer
End Class
