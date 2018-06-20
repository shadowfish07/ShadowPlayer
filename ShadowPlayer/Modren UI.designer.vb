<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TmrMusicEnd = New System.Windows.Forms.Timer(Me.components)
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_TotalTime = New System.Windows.Forms.Label()
        Me.Lbl_NowTime = New System.Windows.Forms.Label()
        Me.Lbl_LryicDown = New System.Windows.Forms.Label()
        Me.Lbl_LryicUp = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_ControlMusicList = New System.Windows.Forms.Button()
        Me.Btn_PrevMusic = New System.Windows.Forms.Button()
        Me.Btn_NextMusic = New System.Windows.Forms.Button()
        Me.Btn_Stop = New System.Windows.Forms.Button()
        Me.Btn_PlayPause = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Mainmin
        '
        Me.btn_Mainmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mainmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mainmin.FlatAppearance.BorderSize = 0
        Me.btn_Mainmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Mainmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
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
        Me.btn_Mainmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_Mainmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FilterIndex = 3
        Me.OpenFileDialog1.Multiselect = True
        '
        'TmrMusicEnd
        '
        Me.TmrMusicEnd.Interval = 200
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "渡船播放器"
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
        Me.Lbl_MusicName.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Lbl_MusicName.Location = New System.Drawing.Point(157, 81)
        Me.Lbl_MusicName.Name = "Lbl_MusicName"
        Me.Lbl_MusicName.Size = New System.Drawing.Size(404, 30)
        Me.Lbl_MusicName.TabIndex = 23
        Me.Lbl_MusicName.Text = "MusicName"
        Me.Lbl_MusicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lbl_TotalTime)
        Me.Panel1.Controls.Add(Me.Lbl_NowTime)
        Me.Panel1.Location = New System.Drawing.Point(259, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 200)
        Me.Panel1.TabIndex = 26
        '
        'Lbl_TotalTime
        '
        Me.Lbl_TotalTime.AutoSize = True
        Me.Lbl_TotalTime.Font = New System.Drawing.Font("微软雅黑", 14.0!)
        Me.Lbl_TotalTime.ForeColor = System.Drawing.Color.Silver
        Me.Lbl_TotalTime.Location = New System.Drawing.Point(70, 110)
        Me.Lbl_TotalTime.Name = "Lbl_TotalTime"
        Me.Lbl_TotalTime.Size = New System.Drawing.Size(61, 25)
        Me.Lbl_TotalTime.TabIndex = 27
        Me.Lbl_TotalTime.Text = "00:00"
        '
        'Lbl_NowTime
        '
        Me.Lbl_NowTime.AutoSize = True
        Me.Lbl_NowTime.Font = New System.Drawing.Font("微软雅黑", 25.0!)
        Me.Lbl_NowTime.Location = New System.Drawing.Point(46, 65)
        Me.Lbl_NowTime.Name = "Lbl_NowTime"
        Me.Lbl_NowTime.Size = New System.Drawing.Size(108, 45)
        Me.Lbl_NowTime.TabIndex = 26
        Me.Lbl_NowTime.Text = "00:00"
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
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 128)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(241, 200)
        Me.AxWindowsMediaPlayer1.TabIndex = 37
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.设置
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(502, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_ControlMusicList
        '
        Me.Btn_ControlMusicList.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.Play
        Me.Btn_ControlMusicList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ControlMusicList.FlatAppearance.BorderSize = 0
        Me.Btn_ControlMusicList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_ControlMusicList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_ControlMusicList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ControlMusicList.ForeColor = System.Drawing.Color.White
        Me.Btn_ControlMusicList.Location = New System.Drawing.Point(698, 96)
        Me.Btn_ControlMusicList.Name = "Btn_ControlMusicList"
        Me.Btn_ControlMusicList.Size = New System.Drawing.Size(20, 20)
        Me.Btn_ControlMusicList.TabIndex = 35
        Me.Btn_ControlMusicList.UseVisualStyleBackColor = False
        Me.Btn_ControlMusicList.Visible = False
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
        Me.Btn_PrevMusic.Location = New System.Drawing.Point(300, 337)
        Me.Btn_PrevMusic.Name = "Btn_PrevMusic"
        Me.Btn_PrevMusic.Size = New System.Drawing.Size(20, 20)
        Me.Btn_PrevMusic.TabIndex = 30
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
        Me.Btn_NextMusic.Location = New System.Drawing.Point(399, 337)
        Me.Btn_NextMusic.Name = "Btn_NextMusic"
        Me.Btn_NextMusic.Size = New System.Drawing.Size(20, 20)
        Me.Btn_NextMusic.TabIndex = 29
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
        Me.Btn_Stop.Location = New System.Drawing.Point(366, 337)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(20, 20)
        Me.Btn_Stop.TabIndex = 28
        Me.Btn_Stop.UseVisualStyleBackColor = False
        '
        'Btn_PlayPause
        '
        Me.Btn_PlayPause.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.Play
        Me.Btn_PlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_PlayPause.FlatAppearance.BorderSize = 0
        Me.Btn_PlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_PlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_PlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_PlayPause.ForeColor = System.Drawing.Color.White
        Me.Btn_PlayPause.Location = New System.Drawing.Point(333, 337)
        Me.Btn_PlayPause.Name = "Btn_PlayPause"
        Me.Btn_PlayPause.Size = New System.Drawing.Size(20, 20)
        Me.Btn_PlayPause.TabIndex = 27
        Me.Btn_PlayPause.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ShadowPlayer.My.Resources.Resources.全屏
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(237, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 16)
        Me.Button2.TabIndex = 37
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Modren_UI
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(719, 521)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_ControlMusicList)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Lbl_LryicDown)
        Me.Controls.Add(Me.Lbl_LryicUp)
        Me.Controls.Add(Me.Btn_PrevMusic)
        Me.Controls.Add(Me.Btn_NextMusic)
        Me.Controls.Add(Me.Btn_Stop)
        Me.Controls.Add(Me.Btn_PlayPause)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lbl_MusicName)
        Me.Controls.Add(Me.Lbl_title)
        Me.Controls.Add(Me.btn_Mainmin)
        Me.Controls.Add(Me.btn_Mainmax)
        Me.Controls.Add(Me.btn_Mainexit)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Modren_UI"
        Me.Text = "Modren_UI"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Mainmin As Button
    Friend WithEvents btn_Mainmax As Button
    Friend WithEvents btn_Mainexit As Button
    Friend WithEvents Lbl_title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TmrMusicEnd As Timer
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_TotalTime As Label
    Friend WithEvents Lbl_NowTime As Label
    Friend WithEvents Btn_PlayPause As Button
    Friend WithEvents Btn_Stop As Button
    Friend WithEvents Btn_NextMusic As Button
    Friend WithEvents Btn_PrevMusic As Button
    Friend WithEvents Lbl_LryicDown As Label
    Friend WithEvents Lbl_LryicUp As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn_ControlMusicList As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button2 As Button
End Class
