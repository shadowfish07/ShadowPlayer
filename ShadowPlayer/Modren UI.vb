Imports WMPLib
Public Class Modren_UI
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
        Player.uiMode = "none"
        Player.settings.autoStart = False
    End Sub
End Class