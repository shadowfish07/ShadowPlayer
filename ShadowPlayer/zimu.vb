Public Class Zimu
    Public Sub ChangeLyric(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim result As Double = Showlryic()
        If result = -1 Then Exit Sub
        If Main.ListLab(Main.nowPlay).Lyric.GetHaveLanguages Then
            '双语字幕
            Label1.Visible = False
            Label2.Visible = True
            Label3.Visible = True
            If Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result) <> "" Then
                If StrLength(Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result)) > 46 Then
                    Label2.Font = New Font(Label1.Font.FontFamily, 24)
                    Label2.Top = 40
                Else
                    Label2.Font = New Font(Label1.Font.FontFamily, 29)
                    Label2.Top = 29
                End If
                Label2.Text = Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result)
                Label3.Text = Main.ListLab(Main.nowPlay).Lyric.Lyrics2.Item(result)
            End If

        Else
            '中文字幕
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            If Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result) <> "" Then
                If StrLength(Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result)) > 26 Then
                    Label1.Font = New Font(Label1.Font.FontFamily, 40)
                Else
                    Label1.Font = New Font(Label1.Font.FontFamily, 48)
                End If
                Label1.Text = Main.ListLab(Main.nowPlay).Lyric.Lyrics.Item(result)
            End If
        End If

    End Sub

    Private Function Showlryic() As Double
        Dim exNum As Double = 0.1 'Timer1.Interval / 2000
        Dim maximum As Double = Main.player.Ctlcontrols.currentPosition + exNum
        Dim minimum As Double = Main.player.Ctlcontrols.currentPosition - exNum
        Dim d As Double
        Try
            For Each d In Main.ListLab(Main.nowPlay).Lyric.Lyrics.keys
                If d >= minimum And d <= maximum Then
                    Return d
                    Exit Function
                End If
            Next
        Catch ex As Exception

        End Try

        Return -1
    End Function
End Class