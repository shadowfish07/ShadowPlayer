Public Class PlayEngine
    Event AddedAMusic(musicName As String)

    Dim _timer As Timer

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
            Modren_UI.MusicList.Item(Modren_UI.MusicList.Count - 1).width = 239
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

    End Sub

    Public Sub Pause()

    End Sub

    Public Sub [Stop]()

    End Sub

    Public Sub ChangeMusic(listIndex As Integer)

    End Sub

    Private Sub Wait_Until_Music_End()

    End Sub
End Class
