﻿Imports AxWMPLib
Imports WMPLib
Public Class Modren_UI
    Const SPECIALVISION As String = " Alpha"

    Const FILTERS = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
    Dim playProgres As PlayProgress
    Dim WithEvents Engine As PlayEngine
    Public WithEvents MusicList As New ArrayList
    Dim log As New LogWriter("ShadowPlayer_RunTime.log")

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
        log.Write("正在启动程序")
        log.PrintMyVision()
        Player.uiMode = "none"
        Player.settings.autoStart = False
        Lbl_MusicName.Text = "双击以添加歌曲"
        Lbl_title.Text = "ShadowPlayer"
        NotifyIcon1.Icon = My.Resources.LOGO_Play

        Engine = New PlayEngine(Lbl_LryicUp, Lbl_LryicDown)

        Lbl_Vision.Text = "Vision " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString + SPECIALVISION

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
    End Sub

    Private Sub Modren_UI_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop

    End Sub

    Private Sub player_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles Player.PlayStateChange
        Const PLAY As Integer = 0, PUASE As Integer = 1
        If Player.playState = CPlayState.Playing Then
            Engine.TimerEnabled(True)
            Btn_PlayPause.BackgroundImage = My.Resources.Pause
            Lbl_TotalTime.Text = Player.currentMedia.durationString
            'NotifyIcon1.Icon = My.Resources.渡船播放器LOGO_playing
            播放ToolStripMenuItem.DropDownItems.Item(PLAY).Enabled = False
            播放ToolStripMenuItem.DropDownItems.Item(PUASE).Enabled = True
        ElseIf Player.playState = CPlayState.Stoping Or Player.playState = CPlayState.Pausing Or Player.playState = CPlayState.Ready Then
            Engine.TimerEnabled(False)
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
        End If
        If Player.playState = CPlayState.Stoping Then
            'Zimu.Label1.Text = MusicList(nowPlay).text
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

    Private Sub AddMusic(sender As Object, e As EventArgs) Handles Lbl_MusicName.DoubleClick
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

    Private Sub Player_DoubleClickEvent(sender As Object, e As _WMPOCXEvents_DoubleClickEvent) Handles Player.DoubleClickEvent
        Stop
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
        Me.Refresh()
        Try
            playProgres.Flush(Player.Ctlcontrols.currentPosition / Player.currentMedia.duration)
        Catch ex As Exception
            playProgres.Flush(0)
        End Try

    End Sub

#End Region
End Class


