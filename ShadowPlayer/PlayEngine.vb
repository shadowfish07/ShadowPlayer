Public Class PlayEngine
    Event AddedAMusic(musicName As String)

    Dim WithEvents _timer As New Timer With {.Interval = 200, .Enabled = False}

    Public Sub Add(filePaths() As String, targetList As FlowLayoutPanel, tooltip As ToolTip)
        Dim s As String
        Dim sr As System.IO.StreamReader
        For Each s In filePaths
            Dim lab As New LabelWithIndex()
            targetList.Controls.Add(lab)
            Modren_UI.MusicList.Add(lab)
            lab.Index = Modren_UI.MusicList.Count - 1
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).AutoEllipsis = True
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).text = Dir(s)
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).tag = s
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).width = 170
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).image = My.Resources.labelback1
            lab.CreatLyrImage()
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
            End If
        Next
    End Sub

    Private Sub Listmousemove(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.image = My.Resources.labelback2
        sender.GetObLyrImage.BackColor = Color.FromArgb(58, 83, 163)
    End Sub

    Private Sub Listmouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.image = sender.MouseMoveImage
        sender.GetObLyrImage.BackColor = Color.FromArgb(87, 135, 195)
    End Sub

    Private Sub ListDoubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangeMusic(sender.index)
    End Sub

    Private Sub ListClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Modren_UI.chooseItem <> -1 And Modren_UI.chooseItem <= Modren_UI.MusicList.Count - 1 Then
            Modren_UI.MusicList(Modren_UI.chooseItem).MouseMoveImage = My.Resources.labelback1
            Modren_UI.MusicList(Modren_UI.chooseItem).image = My.Resources.labelback1
        End If
        sender.MouseMoveImage = My.Resources.labelback3
        Modren_UI.chooseItem = sender.index
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
                    End If
                Case Cplaynum.ListCycle
                    ChangeMusic()
                Case Cplaynum.OneOnce
                    Me.Stop()
                Case Cplaynum.OneCycle
                    Modren_UI.Player.Ctlcontrols.currentPosition = 0
                Case Cplaynum.Random
                    Dim rnd As New Random
                    ChangeMusic(rnd.Next(0, Modren_UI.MusicList.Count))
            End Select

        End If
    End Sub

End Class
