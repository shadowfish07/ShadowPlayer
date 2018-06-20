Imports WMPLib
Public Class Modren_UI
    Const FILTERS = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
    Public playProgres As PlayProgress
    Dim WithEvents engine As New PlayEngine
    Public WithEvents MusicList As New ArrayList
    Dim choosefile As Boolean = False

    Public nowPlay As Integer, lastPlay As Integer, chooseItem As Integer = -1

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
        playProgres = New PlayProgress(Panel1, 30, Color.AliceBlue, Color.Green)
        playProgres.Flush(0.3)
        e.Dispose
    End Sub

    Private Sub Modren_UI_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop

    End Sub

    Private Sub Lbl_MusicName_Click(sender As Object, e As EventArgs) Handles Lbl_MusicName.DoubleClick
        OpenFileDialog1.Filter = "音频文件|*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd|
视频文件|*.mp4;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2|
所有支持格式|*.mp4;*.wma;*.wax;*.cda;*.mp3;*.m3u;*.wav;*.mid:*.midi;*.rmi;*.aif;*.aifc;*aiff;*.au;*,snd;*.wmv;*.wvx;*.asf;*.asx;*.wpl;*.wm;*.wmx;*.wmd;*.wmz;*.vob;*.dvr;*.avi;*.mpeg:*.mpg;*.mlv;*.mpv2;*.mpa;*.mp2"
        OpenFileDialog1.ShowDialog()
        If chooseFile = False Then
            Exit Sub
        Else
            chooseFile = False
        End If
        engine.Add(OpenFileDialog1.FileNames, FlowLayoutPanel1, ToolTip1)

    End Sub

    Private Sub UpdateMusicNameText(musicname As String) Handles engine.AddedAMusic
        Lbl_MusicName.Text = ListTidy(Dir(musicname), 32)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        choosefile = True
    End Sub
End Class