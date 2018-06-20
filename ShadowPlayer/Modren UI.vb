Imports AxWMPLib
Imports ShadowPlayer
Imports WMPLib
Public Class Modren_UI
    Const SPECIALVISION As String = ""

    Const FILTERS = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*.snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
    Dim playProgres As PlayProgress
    Dim WithEvents Engine As PlayEngine
    Public WithEvents MusicList As New ArrayList
    Dim log As New LogWriter("ShadowPlayer_RunTime.log")
    Dim loaded As Boolean = False

    Friend playMode As CplayMode = CplayMode.ListOnce
    Public nowPlay As Integer, lastPlay As Integer, chooseItem As Integer = -1

    Public mainOption As New OptionClass

    Private isListOpen As Boolean = False

    '分别为列表、播放模式的动画重置时间
    Public ListRemainTime As Integer = 0, PlayModeReminTime As Integer = 0

    Delegate Sub PlayStateChangeEvent()

    Private _dealPlayStateChange As PlayStateChangeEvent = AddressOf PlayStateChange_Normal

    Public ReadOnly Property DealPlayStateChange As PlayStateChangeEvent
        Get
            Return _dealPlayStateChange
        End Get
    End Property

    Friend Sub SetDealPlayStateChange(type As CPlayStateChangeSub)
        Select Case type
            Case CPlayStateChangeSub.Nomral
                _dealPlayStateChange = AddressOf PlayStateChange_Normal
            Case CPlayStateChangeSub.Load
                _dealPlayStateChange = AddressOf PlayStateChange_Load
        End Select
    End Sub

    Private Sub btn_Mainexit_Click(sender As Object, e As EventArgs) Handles btn_Mainexit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Mainmin_Click(sender As Object, e As EventArgs) Handles btn_Mainmin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Modren_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As New OptionClass.Myboolean(True)
        Dim b As New OptionClass.Myboolean(False)
        If a <> b Then Debug.Print("1")
        log.Write("正在启动程序")
        log.PrintMyVision()
        Player.uiMode = "none"
        Player.settings.autoStart = False
        Lbl_MusicName.Text = "双击以添加歌曲"
        Lbl_title.Text = "ShadowPlayer"
        NotifyIcon1.Icon = My.Resources.LOGO_Play

        Engine = New PlayEngine(Lbl_LryicUp, Lbl_LryicDown)

        Lbl_Vision.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString + SPECIALVISION

        If mainOption.Alarm_LoudOpen.Value Then
            ToolTip1.SetToolTip(Btn_Alarm, "闹钟已开启" + vbCrLf + "开启时间： " + mainOption.Alarm_LoudTime + vbCrLf + "关闭时间： " + mainOption.Alarm_EndTime)
        End If

        '调用载入后PlayProgress绘制
        Dim FormLoaded As New Timer
        FormLoaded.Interval = 30
        AddHandler FormLoaded.Tick, AddressOf FormLoad
        FormLoaded.Enabled = True
        '设置字幕颜色
        Lbl_LryicUp.ForeColor = mainOption.Lyric_English_ForeColor
        Lbl_LryicDown.ForeColor = mainOption.Lyric_CN_ForeColor
        Lbl_LryicUp.Font = mainOption.Lyric_English_Font
        Lbl_LryicDown.Font = mainOption.Lyric_CN_Font

        log.Write("程序启动成功")
    End Sub

    Sub FormLoad(e As Object, ev As EventArgs)
        playProgres = New PlayProgress(Pnl_Circle, 30, Color.FromArgb(180, 198, 214), Color.FromArgb(80, 173, 255))
        e.Dispose
        loaded = True
    End Sub

    Private Sub Modren_UI_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop, FlowLayoutPanel1.DragDrop, Pnl_Circle.DragDrop, Lbl_MusicName.DragDrop
        Engine.Add(e.Data.GetData(DataFormats.FileDrop), FlowLayoutPanel1, ToolTip1)
    End Sub

    Private Sub Modren_UI_DragOver(sender As Object, e As DragEventArgs) Handles MyBase.DragOver, FlowLayoutPanel1.DragOver, Pnl_Circle.DragOver, Lbl_MusicName.DragOver
        e.Effect = e.Effect.All
    End Sub

    Private Sub player_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles Player.PlayStateChange
        DealPlayStateChange.Invoke
    End Sub

    Private Sub PlayStateChange_Normal()
        '正常情况下播放器改变播放状态的处理过程
        Const PLAY As Integer = 0, PUASE As Integer = 1
        If Player.playState = CPlayState.Playing Then
            Engine.SetTimerEnabled(True)
            Btn_PlayPause.BackgroundImage = My.Resources.Pause
            Lbl_TotalTime.Text = Player.currentMedia.durationString
            'NotifyIcon1.Icon = My.Resources.渡船播放器LOGO_playing
            播放ToolStripMenuItem.DropDownItems.Item(PLAY).Enabled = False
            播放ToolStripMenuItem.DropDownItems.Item(PUASE).Enabled = True
        ElseIf Player.playState = CPlayState.Stoping Or Player.playState = CPlayState.Pausing Or Player.playState = CPlayState.Ready Then
            Engine.SetTimerEnabled(False)
            Btn_PlayPause.BackgroundImage = My.Resources.Play
            'NotifyIcon1.Icon = My.Resources.渡船播放器LOGO_stoping
            播放ToolStripMenuItem.DropDownItems.Item(PLAY).Enabled = True
            播放ToolStripMenuItem.DropDownItems.Item(PUASE).Enabled = False
        End If

        If Player.playState = CPlayState.Ready And mainOption.LyricScreen_Open.Value Then
            If MusicList(nowPlay).lyric.GetHaveLyrics Then
                Engine.ShowLyric()
                ' Zimu.Show()
                'Zimu.WindowState = FormWindowState.Normal
                'Zimu.Timer1.Enabled = True
            End If
        ElseIf Player.playState = CPlayState.Stoping Then
            Engine.HideLyric()
            'Zimu.Label1.Text = MusicList(nowPlay).text
        End If
    End Sub

    Private Sub PlayStateChange_Load()
        '仅读取歌曲信息时用的播放器改变播放状态的处理过程
        If Player.playState = CPlayState.Playing Then
            Lbl_TotalTime.Text = Player.currentMedia.durationString
            Engine.Stop()
        ElseIf Player.playState = CPlayState.Stoping Then
            SetDealPlayStateChange(CPlayStateChangeSub.Nomral)
        End If
    End Sub

    Private Sub EverySecond(sender As Object, e As EventArgs) Handles Timer1.Tick
        '检测是否需要阻止系统睡眠
        Dim preventSleep
        If mainOption.PreventSleep_Open.Value = True Then
            If mainOption.PreventSleep_Alltime.Value = True Then
                preventSleep = SetThreadExecutionState(ES_DISPLAY_REQUIRED Or ES_SYSTEM_REQUIRED)
            Else
                If mainOption.PreventSleep_Playing.Value And Player.playState = WMPPlayState.wmppsPlaying Then
                    preventSleep = SetThreadExecutionState(ES_DISPLAY_REQUIRED Or ES_SYSTEM_REQUIRED)
                ElseIf mainOption.PreventSleep_Alarm.Value And (mainOption.Alarm_LoudOpen.Value Or mainOption.Alarm_CloseOpen.Value) Then
                    preventSleep = SetThreadExecutionState(ES_DISPLAY_REQUIRED Or ES_SYSTEM_REQUIRED)
                End If
            End If
        End If

        If Player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            '更新播放显示
            Lbl_NowTime.Text = Player.Ctlcontrols.currentPositionString
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
        End If
        If Format(Now, "HH:mm:ss") = mainOption.Alarm_LoudTime And mainOption.Alarm_LoudOpen.Value = True Then
            '自动开始播放
            Try
                Engine.Play()
                Btn_PlayPause.BackgroundImage = My.Resources.Pause
                log.Write("自动播放——闹钟")
            Catch ex As Exception

            End Try
        ElseIf Format(Now, "HH:mm:ss") = mainOption.Alarm_EndTime And mainOption.Alarm_CloseOpen.Value = True Then
            log.Write("自动停止——闹钟")
            '自动结束播放
            Try
                '结束后程序操作
                If mainOption.WhenClose_EndOpen.Value = True Then
                    End
                ElseIf mainOption.WhenClose_MiniOpen.Value = True Then
                    Btn_PlayPause.BackgroundImage = My.Resources.Play
                    HideForm()
                    Zimu.Timer1.Enabled = False
                End If
                '结束后播放操作
                If mainOption.AfterClose_next.Value = True Then
                    If playMode = CplayMode.Random Then
                        Dim rnd As New Random
                        Engine.ChangeMusic(rnd.Next(0, MusicList.Count), False)
                    Else '暂时不考虑播放模式为单曲循环的情况
                        Engine.ChangeMusic(, False)
                    End If
                ElseIf mainOption.AfterClose_puase.Value = True Then
                    Engine.Pause()
                ElseIf mainOption.AfterClose_stop.Value = True Then
                    Engine.Stop()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    ''' <summary>
    ''' 程序隐藏至任务栏
    ''' </summary>
    Private Sub HideForm()
        Me.Hide()
        Settings.Hide()
        Zimu.Hide()
    End Sub

    Private Sub AddMusic(sender As Object, e As EventArgs) Handles Lbl_MusicName.DoubleClick, Btn_Add.Click
        OpenFileDialog1.Filter = FILTERS
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Btn_PlayPause_Click(sender As Object, e As EventArgs) Handles Btn_PlayPause.Click
        If Player.playState = CPlayState.Pausing Or Player.playState = CPlayState.Stoping Or Player.playState = CPlayState.Ready Then
            If MusicList.Count = 0 Then Exit Sub '后面可提示错误
            Engine.Play()
            If IO.Path.GetExtension(MusicList.Item(nowPlay).tag) = ".mp4" Then
                Player.Show()
                Btn_FullScreen.Visible = True
            Else
                Player.Hide()
                Btn_FullScreen.Visible = False
            End If
            Lbl_MusicName.Text = Dir(MusicList.Item(nowPlay).tag)
        ElseIf Player.playState = WMPPlayState.wmppsPlaying Then
            Engine.Pause()
        End If

    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        Engine.Stop()
        Btn_PlayPause.BackgroundImage = My.Resources.Play
        Lbl_NowTime.Text = "00:00"
        playProgres.Flush(0)
    End Sub

    Private Sub Engine_AddMusic(musicname As String) Handles Engine.AddedAMusic
        Call UpdateMusicNameText(musicname)
    End Sub

    ''' <summary>
    ''' 实现更改播放歌曲后歌曲序号、主界面UI等的修改
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Engine_ChangedMusic(sender As Object, e As ChangedMusicEventArgs) Handles Engine.ChangedMusic
        If MusicList.Count = 0 Then Exit Sub
        If e.NowPlayIndex > -1 Then
            '指定播放序列，跳转至指定的歌曲
            nowPlay = e.NowPlayIndex
        ElseIf nowPlay < MusicList.Count - 1 Then '省略NowPlayIndex时，默认切换至下一首
            '若当前播放歌曲不是下一首，切换至下一首
            nowPlay += 1
        Else
            '若当前播放歌曲是下一首，回到列表初
            nowPlay = 0
        End If
        Dim myFontFamily As System.Drawing.FontFamily = New FontFamily("微软雅黑")
        MusicList.Item(lastPlay).Font = New Font(myFontFamily, 9, FontStyle.Regular)
        MusicList.Item(nowPlay).Font = New Font(myFontFamily, 9, FontStyle.Bold)
        lastPlay = nowPlay
        Player.URL = MusicList.Item(nowPlay).tag
        Lbl_MusicName.Text = MusicList(nowPlay).text
        Btn_Stop_Click(Nothing, Nothing)
    End Sub

    ''' <summary>
    ''' 实现Engine类调用Play时主界面的修改
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Engine_played(sender As Object, e As EventArgs) Handles Engine.Played
        If PlayEngine.IsFileVideo(MusicList(nowPlay).tag) And mainOption.Video_AutoFullScreen Then
            Player.fullScreen = True
        End If
    End Sub

    Private Sub UpdateMusicNameText(musicname As String)
        '输入路径转换为歌名
        Lbl_MusicName.Text = Dir(musicname)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Engine.Add(OpenFileDialog1.FileNames, FlowLayoutPanel1, ToolTip1)
    End Sub

    Private Sub Modren_UI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        log.EndWrite()
    End Sub

    Private Sub FullScreen(sender As Object, e As EventArgs) Handles Btn_FullScreen.Click
        Try
            Player.fullScreen = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ImageChangeToReplay() Handles Engine.PlayEnd
        Btn_PlayPause.BackgroundImage = My.Resources.刷新
        Lbl_NowTime.Text = Lbl_TotalTime.Text
        playProgres.Flush(1)
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Pnl_Circle.Click
        If Lbl_TotalTime.Text = "00:00" Then Exit Sub
        Dim point_x As Integer = Me.MousePosition.X - Pnl_Circle.Location.X - Me.Location.X
        Dim point_y As Integer = Me.MousePosition.Y - Pnl_Circle.Location.Y - Me.Location.Y
        If playProgres.IsinYuanHuan(New Point(point_x, point_y)) Then
            Player.Ctlcontrols.currentPosition = (Pnl_Circle.Height - point_y) / Pnl_Circle.Height * Player.currentMedia.duration
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
            Lbl_NowTime.Text = Player.Ctlcontrols.currentPositionString
            'Engine.ChangeLyric()
        End If
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        btn_Mainexit_Click(Me, Nothing)
    End Sub

    Private Sub 停止ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 停止ToolStripMenuItem.Click
        Try
            Engine.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        NotifyIcon1_MouseDoubleClick(Me, Nothing)
    End Sub

#Region "窗体拖动移动"

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function ReleaseCapture() As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function


    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, &HA1, 2, 0)
    End Sub

    Private Sub FormDrag(sender As Object, e As MouseEventArgs) Handles Panel_top.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then MoveForm()
    End Sub

    Private Sub Repaint() Handles Me.Paint
        If loaded = False Then Exit Sub
        Try
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
        Catch ex As Exception
            If Btn_PlayPause.BackgroundImage Is My.Resources.刷新 Then
                playProgres.Flush(1)
            Else
                playProgres.Flush(0)
            End If

        End Try
    End Sub

#End Region

#Region "列表动画"
    Private Sub Btn_List_MouseEnter(sender As Object, e As EventArgs) Handles Btn_List.MouseEnter
        If isListOpen = False Then
            Dim a As New HideListAction(Panel_hideList, New PointF(Panel_hideList.Location.X, Panel_hideList.Location.Y + 300), 300, 5)
            a.Start()
            Dim b As New ShowOneByOneAction(Btn_Alarm, New PointF(550, 85), 100, 5, {Btn_MoveToDown, Btn_MoveToUp, Btn_Remove}, True)
            b.Start()

            Timer_List.Start()
            Btn_List.Visible = False
            Btn_Add.Visible = True

        End If
    End Sub

    Private Sub Timer_List_Tick(sender As Object, e As EventArgs) Handles Timer_List.Tick
        If ListRemainTime = 5 Then
            Dim a As New HideListAction(Panel_hideList, New PointF(Panel_hideList.Location.X, Panel_hideList.Location.Y - 300), 300, 10)
            a.Start()
            ListRemainTime = 0
            Timer_List.Stop()
            Btn_List.Visible = True
            Btn_Add.Visible = False

            Dim b As New ShowOneByOneAction(Btn_Alarm, New PointF(651, 85), 300, 10, {Btn_MoveToDown, Btn_MoveToUp, Btn_Remove}, False)
            b.Start()
        End If
        ListRemainTime += 1
    End Sub

    Private Sub Btn_Add_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Add.MouseEnter
        ListRemainTime = 0
    End Sub

    Private Sub Btn_MoveToDown_MouseEnter(sender As Object, e As EventArgs) Handles Btn_MoveToDown.MouseEnter
        ListRemainTime = 0
    End Sub

    Private Sub Btn_MoveToUp_MouseEnter(sender As Object, e As EventArgs) Handles Btn_MoveToUp.MouseEnter
        ListRemainTime = 0
    End Sub

    Private Sub Btn_Remove_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Remove.MouseEnter
        ListRemainTime = 0
    End Sub
#End Region
#Region "播放模式动画"
    Private Sub Timer_PlayMode_Tick(sender As Object, e As EventArgs) Handles Timer_PlayMode.Tick
        If PlayModeReminTime = 3 Then
            PlayModeReminTime = 0
            Timer_PlayMode.Stop()
            Dim b As New VisualAction(label1, New PointF(642, 365), 100, 5)
            b.Start()
        End If
        PlayModeReminTime += 1
    End Sub

    Private Sub Lbl_PlayMode_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_PlayMode.MouseEnter
        If Timer_PlayMode.Enabled = False Then
            Dim a As New VisualAction(label1, New PointF(579, 365), 100, 5)
            a.Start()
            Timer_PlayMode.Start()
        End If
        PlayModeReminTime = 0
    End Sub

    Private Sub label1_MouseEnter(sender As Object, e As EventArgs) Handles label1.MouseEnter
        PlayModeReminTime = 0
    End Sub
#End Region

    Private Sub Btn_NextMusic_Click(sender As Object, e As EventArgs) Handles Btn_NextMusic.Click
        Engine.ChangeMusic()
    End Sub

    Private Sub Btn_PrevMusic_Click(sender As Object, e As EventArgs) Handles Btn_PrevMusic.Click
        Engine.ChangeMusic(nowPlay - 1)
    End Sub

    Private Sub 播放ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 播放ToolStripMenuItem1.Click
        Try
            Engine.Play()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub 暂停ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 暂停ToolStripMenuItem.Click
        Try
            Engine.Pause()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_MoveToUp_Click(sender As Object, e As EventArgs) Handles Btn_MoveToUp.Click
        If chooseItem = -1 Or chooseItem = 0 Then Exit Sub
        Dim temp As MusicListLabel = New MusicListLabel
        temp.Text = MusicList(chooseItem).Text : MusicList(chooseItem).Text = MusicList(chooseItem - 1).Text : MusicList(chooseItem - 1).Text = temp.Text
        temp.Tag = MusicList(chooseItem).tag : MusicList(chooseItem).tag = MusicList(chooseItem - 1).tag : MusicList(chooseItem - 1).tag = temp.Tag
        temp.Font = MusicList(chooseItem).font : MusicList(chooseItem).font = MusicList(chooseItem - 1).font : MusicList(chooseItem - 1).font = temp.Font
        MusicList(chooseItem - 1).MouseLeaveImage = My.Resources.ListChosenImage
        MusicList(chooseItem).MouseLeaveImage = Nothing
        MusicList(chooseItem - 1).Image = My.Resources.ListChosenImage
        MusicList(chooseItem).Image = Nothing
        nowPlay -= 1
        chooseItem -= 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        Settings.Show()
    End Sub

    Private Sub Btn_MoveToDown_Click(sender As Object, e As EventArgs) Handles Btn_MoveToDown.Click
        If chooseItem = -1 Or chooseItem = MusicList.Count - 1 Then Exit Sub
        Dim temp As MusicListLabel = New MusicListLabel
        temp.Text = MusicList(chooseItem).Text : MusicList(chooseItem).Text = MusicList(chooseItem + 1).Text : MusicList(chooseItem + 1).Text = temp.Text
        temp.Tag = MusicList(chooseItem).tag : MusicList(chooseItem).tag = MusicList(chooseItem + 1).tag : MusicList(chooseItem + 1).tag = temp.Tag
        temp.Font = MusicList(chooseItem).font : MusicList(chooseItem).font = MusicList(chooseItem + 1).font : MusicList(chooseItem + 1).font = temp.Font
        MusicList(chooseItem + 1).MouseLeaveImage = My.Resources.ListChosenImage
        MusicList(chooseItem).MouseLeaveImage = Nothing
        MusicList(chooseItem + 1).Image = My.Resources.ListChosenImage
        MusicList(chooseItem).Image = Nothing
        nowPlay += 1
        chooseItem += 1
    End Sub

    ''' <summary>
    ''' 切换播放模式
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lblPlayMode_MouseDown(sender As Object, e As EventArgs) Handles Lbl_PlayMode.MouseDown
        Static modeIndex = 1
        Select Case modeIndex
            Case 0
                '当前为随机播放
                Lbl_PlayMode.Text = "单次列表"
                playMode = CplayMode.ListOnce
                modeIndex += 1
            Case 1
                '当前为单次列表
                Lbl_PlayMode.Text = "列表循环"
                playMode = CplayMode.ListCycle
                modeIndex += 1
            Case 2
                '当前为列表循环
                Lbl_PlayMode.Text = "单次播放"
                playMode = CplayMode.OneOnce
                modeIndex += 1
            Case 3
                '当前为单次播放
                Lbl_PlayMode.Text = "循环单首"
                playMode = CplayMode.OneCycle
                modeIndex += 1
            Case 4
                '当前为循环单首
                Lbl_PlayMode.Text = "随机播放"
                playMode = CplayMode.Random
                modeIndex = 0
        End Select
    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Try
            Call Engine.Stop()
            Call ArrayListRemoveItem(MusicList, chooseItem)
            Call FlowLayoutPanelRemoveItem(FlowLayoutPanel1, chooseItem)
            Player.URL = ""
            Lbl_MusicName.Text = "双击以添加歌曲"
            Lbl_NowTime.Text = "00:00"
            Lbl_TotalTime.Text = "00:00"
        Catch ex As Exception

        End Try
    End Sub



    ''' <summary>
    ''' 防止按钮失去焦点出现白色边框
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Btn_Add_Paint(sender As Object, e As PaintEventArgs) Handles Btn_Add.Paint, btn_Mainmin.Paint,
            Btn_PlayPause.Paint, Btn_Stop.Paint, Btn_FullScreen.Paint, Btn_NextMusic.Paint,
            Btn_PrevMusic.Paint, Btn_NextMusic.Paint, Btn_MoveToUp.Paint, Btn_MoveToDown.Paint, Btn_Settings.Paint，
            Btn_Remove.Paint
        Dim ctl As Button = sender
        ctl.FlatAppearance.BorderColor = ctl.Parent.BackColor
    End Sub

    Private Sub Lbl_title_DoubleClick(sender As Object, e As EventArgs) Handles Lbl_title.DoubleClick
        HideForm()
    End Sub



End Class


