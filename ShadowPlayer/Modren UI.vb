Imports AxWMPLib
Imports ShadowPlayer
Imports WMPLib
Public Class Modren_UI
    Const SPECIALVISION As String = ""

    Const FILTERS = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
    Dim playProgres As PlayProgress
    Dim WithEvents Engine As PlayEngine
    Public WithEvents MusicList As New ArrayList
    Dim log As New LogWriter("ShadowPlayer_RunTime.log")
    Dim loaded As Boolean = False

    Friend playMode As Cplaynum = Cplaynum.ListOnce
    Public nowPlay As Integer, lastPlay As Integer, chooseItem As Integer = -1

    Public mainOption As New OptionClass

    Private isListOpen As Boolean = False
    Public ListRemainTime As Integer = 0

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
        log.Write("正在启动程序")
        log.PrintMyVision()
        Player.uiMode = "none"
        Player.settings.autoStart = False
        Lbl_MusicName.Text = "双击以添加歌曲"
        Lbl_title.Text = "ShadowPlayer"
        NotifyIcon1.Icon = My.Resources.LOGO_Play

        Engine = New PlayEngine(Lbl_LryicUp, Lbl_LryicDown)

        Lbl_Vision.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString + SPECIALVISION

        If mainOption.LoudOpen.Value Then
            ToolTip1.SetToolTip(Btn_Alarm, "闹钟已开启" + vbCrLf + "开启时间： " + mainOption.LoudTime + vbCrLf + "关闭时间： " + mainOption.EndTime)
        End If

        '调用载入后PlayProgress绘制
        Dim FormLoaded As New Timer
        FormLoaded.Interval = 30
        AddHandler FormLoaded.Tick, AddressOf FormLoad
        FormLoaded.Enabled = True
        '

        log.Write("程序启动成功")
    End Sub

    Sub FormLoad(e As Object, ev As EventArgs)
        playProgres = New PlayProgress(Panel1, 30, Color.FromArgb(180, 198, 214), Color.FromArgb(80, 173, 255))
        e.Dispose
        loaded = True
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

        If Player.playState = CPlayState.Ready And mainOption.LyricScreenOpen.Value Then
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
        If Player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            '更新播放显示
            Lbl_NowTime.Text = Player.Ctlcontrols.currentPositionString
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
        End If
        If Format(Now, "HH:mm:ss") = mainOption.LoudTime And mainOption.LoudOpen.Value = True Then
            '自动开始播放
            Try
                Engine.Play()
                Btn_PlayPause.BackgroundImage = My.Resources.Pause
                log.Write("自动播放——闹钟")
            Catch ex As Exception

            End Try
        ElseIf Format(Now, "HH:mm:ss") = mainOption.EndTime And mainOption.CloseOpen.Value = True Then
            log.Write("自动停止——闹钟")
            '自动结束播放
            Try
                '结束后程序操作
                If mainOption.CloseEndOpen.Value = True Then
                    End
                ElseIf mainOption.CloseMiniOpen.Value = True Then
                    Btn_PlayPause.BackgroundImage = My.Resources.Play
                    Me.Hide()
                    Zimu.Hide()
                    Zimu.Timer1.Enabled = False
                End If
                '结束后播放操作
                If mainOption.AfterClose_next.Value = True Then
                    If playMode = Cplaynum.Random Then
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
            Lbl_MusicName.Text = ListTidy(Dir(MusicList.Item(nowPlay).tag), 32)
        ElseIf Player.playState = WMPPlayState.wmppsPlaying Then
            Engine.Pause()
        End If

    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        Engine.Stop()
        Btn_PlayPause.BackgroundImage = My.Resources.Play
        Lbl_NowTime.Text = "00.00"
        playProgres.Flush(0)
    End Sub

    Private Sub UpdateMusicNameText(musicname As String) Handles Engine.AddedAMusic
        Lbl_MusicName.Text = ListTidy(Dir(musicname), 32)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
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

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If Lbl_TotalTime.Text = "00:00" Then Exit Sub
        Dim point_x As Integer = Me.MousePosition.X - Panel1.Location.X - Me.Location.X
        Dim point_y As Integer = Me.MousePosition.Y - Panel1.Location.Y - Me.Location.Y
        If playProgres.IsinYuanHuan(New Point(point_x, point_y)) Then
            Player.Ctlcontrols.currentPosition = (Panel1.Height - point_y) / Panel1.Height * Player.currentMedia.duration
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
            Lbl_NowTime.Text = Player.Ctlcontrols.currentPositionString
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

    Private Sub Btn_NextMusic_Click(sender As Object, e As EventArgs) Handles Btn_NextMusic.Click
        Engine.ChangeMusic()
    End Sub

    Private Sub Btn_PrevMusic_Click(sender As Object, e As EventArgs) Handles Btn_PrevMusic.Click
        Engine.ChangeMusic(nowPlay - 1)
    End Sub

#End Region

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
End Class


