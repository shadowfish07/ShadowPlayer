Public Class PlayEngine
    Event AddedAMusic(musicName As String)
    Event ChangedMusic()
    Event PlayEnd()

    Dim lyr As Lyric
    Dim WithEvents _timer As New Timer With {.Interval = 100, .Enabled = False}

    Public Sub New(up As Label, down As Label)
        lyr = New Lyric(up, down)
    End Sub

    Public Sub ShowLyric()
        lyr.Timer.Start()
        lyr.lbl_up.Text = ""
        lyr.lbl_up.Visible = True
    End Sub

    Public Sub HideLyric()
        lyr.Timer.Stop()
        lyr.lbl_up.Visible = False
        lyr.lbl_down.Visible = False
    End Sub

    Private Class Lyric

        Public WithEvents Timer As New Timer With {.Interval = 100}
        Public lbl_up As Label, lbl_down As Label

        Public Sub New(up As Label, down As Label)
            lbl_up = up
            lbl_down = down
        End Sub

        Public Sub ChangeLyric(sender As Object, e As EventArgs) Handles Timer.Tick
            Dim result As Double = Showlryic()
            If result = -1 Then Exit Sub
            If Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.GetHaveLanguages Then
                '双语字幕
                lbl_up.ForeColor = Modren_UI.mainOption.Lyric_English_ForeColor
                lbl_down.ForeColor = Modren_UI.mainOption.Lyric_CN_ForeColor
                lbl_up.Font = Modren_UI.mainOption.Lyric_english_font
                lbl_down.Font = Modren_UI.mainOption.Lyric_cn_font
                lbl_down.Visible = True
                If Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result) <> "" Then
                    'If StrLength(Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result)) > 46 Then
                    'Label2.Font = New Font(Label1.Font.FontFamily, 24)
                    'Label2.Top = 40
                    'Else
                    'Label2.Font = New Font(Label1.Font.FontFamily, 29)
                    'Label2.Top = 29
                    'End If
                    lbl_up.Text = Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result)
                    lbl_down.Text = Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics2.Item(result)
                End If
            Else
                '中文字幕
                lbl_up.ForeColor = Modren_UI.mainOption.Lyric_SingleLine_ForeColor
                lbl_up.Font = Modren_UI.mainOption.Lyric_SingleLine_font
                lbl_down.Visible = False
                If Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result) <> "" Then
                    'If StrLength(Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result)) > 26 Then
                    'Label1.Font = New Font(Label1.Font.FontFamily, 40)
                    'Else
                    'Label1.Font = New Font(Label1.Font.FontFamily, 48)
                    'End If
                    lbl_up.Text = Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.Item(result)
                End If
            End If

        End Sub

        Private Function Showlryic() As Double
            Dim exNum As Double = 0.1 'Timer1.Interval / 2000
            Dim maximum As Double = Modren_UI.Player.Ctlcontrols.currentPosition + exNum
            Dim minimum As Double = Modren_UI.Player.Ctlcontrols.currentPosition - exNum
            Dim d As Double
            Try
                For Each d In Modren_UI.MusicList(Modren_UI.nowPlay).Lyric.Lyrics.keys
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

    Public Sub Add(filePaths() As String, targetList As FlowLayoutPanel, tooltip As ToolTip)
        Dim s As String
        Dim sr As System.IO.StreamReader
        For Each s In filePaths
            Dim lab As New MusicListLabel()
            targetList.Controls.Add(lab)
            Modren_UI.MusicList.Add(lab)
            lab.Index = Modren_UI.MusicList.Count - 1
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).AutoEllipsis = True
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).text = Dir(s)
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).tag = s
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).width = 155
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).image = Nothing
            ' lab.CreatLyrImage()
            '导入歌词文件
            If Dir(System.IO.Path.ChangeExtension(s, "lrc")) <> "" Then
                sr = New System.IO.StreamReader(System.IO.Path.ChangeExtension(s, "lrc"), System.Text.Encoding.UTF8)
                lab.Lyric.AddString(sr.ReadToEnd)
                'Do Until sr.Peek = -1
                '    lab.Lyric.AddLine(sr.ReadLine)
                'Loop
                sr.Close()
            ElseIf Dir(System.IO.Path.ChangeExtension(s, "txt")) <> "" Then
                sr = New System.IO.StreamReader(System.IO.Path.ChangeExtension(s, "txt"), System.Text.Encoding.UTF8)
                lab.Lyric.AddString(sr.ReadToEnd)
                'Do Until sr.Peek = -1
                '    lab.Lyric.AddLine(sr.ReadLine)
                'Loop
                sr.Close()
            ElseIf Dir(System.IO.Path.ChangeExtension(s, "trc")) <> "" Then
                sr = New System.IO.StreamReader(System.IO.Path.ChangeExtension(s, "trc"), System.Text.Encoding.UTF8)
                Dim temps() As String = Change_trc(sr.ReadToEnd).Split(vbCrLf)
                Dim i As Integer
                For i = 0 To temps.GetLength(0) - 1
                    lab.Lyric.AddLine(temps(i))
                Next

            End If
            tooltip.SetToolTip(Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1), s)
            AddHandler lab.MouseMove, AddressOf Listmousemove
            AddHandler lab.MouseLeave, AddressOf Listmouseleave
            AddHandler lab.MouseDoubleClick, AddressOf ListDoubleclick
            AddHandler lab.Click, AddressOf ListClick
            If Modren_UI.MusicList.Count - 1 = 0 Then
                Modren_UI.nowPlay = 0
                Modren_UI.lastPlay = 0
                RaiseEvent AddedAMusic(s)
                Modren_UI.Player.URL = Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).tag
                Modren_UI.SetDealPlayStateChange(CPlayStateChangeSub.Load)
                Me.Play()
            End If
        Next
    End Sub

    Private Sub Listmousemove(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.mouseleaveimage Is Nothing Then
            sender.image = My.Resources.ListMouseMoveImage
        End If

        Modren_UI.ListRemainTime = 0
        'sender.GetObLyrImage.BackColor = Color.FromArgb(58, 83, 163)
    End Sub

    Private Sub Listmouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.image = sender.MouseLeaveImage
        'sender.GetObLyrImage.BackColor = Color.FromArgb(87, 135, 195)
    End Sub

    Private Sub ListDoubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangeMusic(sender.index)
    End Sub

    Private Sub ListClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Modren_UI.chooseItem <> -1 And Modren_UI.chooseItem <= Modren_UI.MusicList.Count - 1 Then
            Modren_UI.MusicList(Modren_UI.chooseItem).MouseLeaveImage = Nothing
            Modren_UI.MusicList(Modren_UI.chooseItem).image = Nothing
        End If
        sender.MouseLeaveImage = My.Resources.ListChosenImage
        Modren_UI.chooseItem = sender.index
    End Sub

    Public Sub SetTimerEnabled(value As Boolean)
        If value = True Then
            _timer.Start()
        Else
            _timer.Stop()
        End If
    End Sub

    Public Sub Play()
        Modren_UI.Player.Ctlcontrols.play()
    End Sub

    Public Sub Pause()
        Modren_UI.Player.Ctlcontrols.pause()
    End Sub

    Public Sub [Stop]()
        Modren_UI.Player.Ctlcontrols.stop()
    End Sub

    Public Sub ChangeMusic(Optional ByVal nowPlayIndex As Integer = -1, Optional ByVal Play As Boolean = True)
        _timer.Enabled = False
        If nowPlayIndex > -1 Then '指定播放情况
            Modren_UI.nowPlay = nowPlayIndex
        ElseIf modren_ui.nowPlay < Modren_UI.MusicList.Count - 1 Then '可下一首情况
            Modren_UI.nowPlay += 1
        Else '最后一首情况
            '回到列表初
            Modren_UI.nowPlay = 0
        End If
        Dim myFontFamily As System.Drawing.FontFamily = New FontFamily("微软雅黑")
        Modren_UI.MusicList.Item(Modren_UI.lastPlay).Font = New Font(myFontFamily, 9, FontStyle.Regular)
        Modren_UI.MusicList.Item(Modren_UI.nowPlay).Font = New Font(myFontFamily, 9, FontStyle.Bold)
        Modren_UI.lastPlay = Modren_UI.nowPlay
        Modren_UI.Player.URL = Modren_UI.MusicList.Item(Modren_UI.nowPlay).tag
        RaiseEvent ChangedMusic()
        If Play Then Me.Play()
    End Sub

    Private Sub Wait_Until_Music_End(sender As Object, e As EventArgs) Handles _timer.Tick
        'next music
        If Modren_UI.Player.currentMedia.duration - 0.3 <= Modren_UI.Player.Ctlcontrols.currentPosition Then
            Select Case Modren_UI.playMode
                Case Cplaynum.ListOnce
                    If Modren_UI.nowPlay < Modren_UI.MusicList.Count - 1 Then
                        ChangeMusic()
                    Else
                        '回到列表初并停止播放
                        Me.Stop()
                        Modren_UI.Player.URL = Modren_UI.MusicList.Item(0).tag
                        Modren_UI.nowPlay = 0
                        Modren_UI.lastPlay = 0
                        RaiseEvent PlayEnd()
                    End If
                Case Cplaynum.ListCycle
                    ChangeMusic()
                Case Cplaynum.OneOnce
                    Me.Stop()
                    RaiseEvent PlayEnd()
                Case Cplaynum.OneCycle
                    Modren_UI.Player.Ctlcontrols.currentPosition = 0
                Case Cplaynum.Random
                    Dim rnd As New Random
                    ChangeMusic(rnd.Next(0, Modren_UI.MusicList.Count))
            End Select

        End If
    End Sub

End Class
