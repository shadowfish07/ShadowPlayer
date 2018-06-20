Imports WMPLib
Public Class Modren_UI
    Dim playProgres As PlayProgress
    Public Class PlayEngine

        Dim _timer As Timer


        Public Sub Play()

        End Sub

        Public Sub Pause()

        End Sub

        Public Sub [Stop]()

        End Sub

        Public Sub ChangeMusic()

        End Sub

        Private Sub Wait_Until_Music_End()

        End Sub
    End Class
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

        Dim FormLoaded As New Timer
        FormLoaded.Interval = 30
        AddHandler FormLoaded.Tick, AddressOf FormLoad
        FormLoaded.Enabled = True

        Trace.WriteLine("[" + Now.ToString + "]" + "程序启动成功")
        sw.Close()
    End Sub

    Sub FormLoad(e As Object, ev As EventArgs)
        playProgres = New PlayProgress(Panel1, 30, Color.AliceBlue, Color.Green)
        playProgres.Flush(0.3)
        e.Dispose
    End Sub

End Class