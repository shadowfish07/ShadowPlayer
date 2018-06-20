Imports AxWMPLib
Imports WMPLib
Public Class Modren_UI
    Const FILTERS = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
    Public playProgres As PlayProgress
    Dim WithEvents engine As New PlayEngine
    Public WithEvents MusicList As New ArrayList

    Friend playMode As Cplaynum = Cplaynum.ListOnce
    Public nowPlay As Integer, lastPlay As Integer, chooseItem As Integer = -1

    Public mainOption As New OptionClass

    Private Sub btn_Mainexit_Click(sender As Object, e As EventArgs) Handles btn_Mainexit.Click
        Application.Exit()
    End Sub

    Private Sub btn_Mainmin_Click(sender As Object, e As EventArgs) Handles btn_Mainmin.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Modren_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sw As New IO.StreamWriter("ShadowPlayer_RunTime.log", True)
        Trace.Listeners.Add(New TextWriterTraceListener(sw))
        Trace.WriteLine("[" + Now.ToString + "]" + "正在启动程序")
        Player.uiMode = "none"
        Player.settings.autoStart = False
        Lbl_MusicName.Text = ""
        NotifyIcon1.Icon = My.Resources.LOGO_Play


        '调用载入后PlayProgress绘制
        Dim FormLoaded As New Timer
        FormLoaded.Interval = 30
        AddHandler FormLoaded.Tick, AddressOf FormLoad
        FormLoaded.Enabled = True
        '

        Trace.WriteLine("[" + Now.ToString + "]" + "程序启动成功")
        sw.Close()
    End Sub

    Sub FormLoad(e As Object, ev As EventArgs)
        playProgres = New PlayProgress(Panel1, 30, Color.FromArgb(180, 198, 214), Color.FromArgb(80, 173, 255))
        e.Dispose
    End Sub

    Private Sub Modren_UI_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop

    End Sub

    Private Sub player_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles Player.PlayStateChange
        Const PLAY As Integer = 0, PUASE As Integer = 1
        If Player.playState = CPlayState.Playing Then
            TmrMusicEnd.Enabled = True
            Lbl_TotalTime.Text = Player.currentMedia.durationString
            'NotifyIcon1.Icon = My.Resources.渡船播放器LOGO_playing
            播放ToolStripMenuItem.DropDownItems.Item(PLAY).Enabled = False
            播放ToolStripMenuItem.DropDownItems.Item(PUASE).Enabled = True
        ElseIf Player.playState = CPlayState.Stoping Or Player.playState = CPlayState.Pausing Or Player.playState = CPlayState.Ready Then
            TmrMusicEnd.Enabled = False
            'NotifyIcon1.Icon = My.Resources.渡船播放器LOGO_stoping
            播放ToolStripMenuItem.DropDownItems.Item(PLAY).Enabled = True
            播放ToolStripMenuItem.DropDownItems.Item(PUASE).Enabled = False
        End If

        If Player.playState = CPlayState.Ready And mainOption.LyricScreenOpen.Value Then
            If MusicList(nowPlay).lyric.GetHaveLyrics Then
                Zimu.Show()
                Zimu.WindowState = FormWindowState.Normal
                Zimu.Timer1.Enabled = True
            End If
        End If
        If Player.playState = CPlayState.Stoping Then
            Zimu.Label1.Text = MusicList(nowPlay).text
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
                engine.Play()
                Btn_PlayPause.Image = My.Resources.Pause
            Catch ex As Exception

            End Try
        ElseIf Format(Now, "HH:mm:ss") = mainOption.EndTime And mainOption.CloseOpen.Value = True Then
            '自动结束播放
            Try
                '结束后程序操作
                If mainOption.CloseEndOpen.Value = True Then
                    End
                ElseIf mainOption.CloseMiniOpen.Value = True Then
                    Btn_PlayPause.Image = My.Resources.Play
                    Me.Hide()
                    Zimu.Hide()
                    Zimu.Timer1.Enabled = False
                End If
                '结束后播放操作
                If mainOption.AfterClose_next.Value = True Then
                    If playMode = Cplaynum.Random Then
                        Dim rnd As New Random
                        engine.ChangeMusic(rnd.Next(0, MusicList.Count), False)
                    Else '暂时不考虑播放模式为单曲循环的情况
                        engine.ChangeMusic(, False)
                    End If
                ElseIf mainOption.AfterClose_puase.Value = True Then
                    engine.Pause()
                ElseIf mainOption.AfterClose_stop.Value = True Then
                    engine.Stop()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub AddMusic(sender As Object, e As EventArgs) Handles Lbl_MusicName.DoubleClick
        OpenFileDialog1.Filter = FILTERS
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Btn_PlayPause_Click(sender As Object, e As EventArgs) Handles Btn_PlayPause.Click
        If Player.playState = CPlayState.Pausing Or Player.playState = CPlayState.Stoping Or Player.playState = CPlayState.Ready Then
            If MusicList.Count = 0 Then Exit Sub '后面可提示错误
            engine.Play()
            Lbl_MusicName.Text = ListTidy(Dir(MusicList.Item(nowPlay).tag), 32)
            Btn_PlayPause.BackgroundImage = My.Resources.Pause
        ElseIf Player.playState = WMPPlayState.wmppsPlaying Then
            engine.Pause()
            Btn_PlayPause.BackgroundImage = My.Resources.Play
        End If

    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click
        engine.Stop()
        Btn_PlayPause.BackgroundImage = My.Resources.Play
        Lbl_NowTime.Text = "00.00"
        playProgres.Flush(0)
    End Sub

    Private Sub UpdateMusicNameText(musicname As String) Handles engine.AddedAMusic
        Lbl_MusicName.Text = ListTidy(Dir(musicname), 32)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        engine.Add(OpenFileDialog1.FileNames, FlowLayoutPanel1, ToolTip1)
    End Sub
End Class