Public Class MusicListLabel
    Inherits System.Windows.Forms.Label

    Public Property Index As Integer
    Public Property MouseMoveImage As Object
    Public Lyric As Lyrics = New Lyrics
    ' Private LyrImage As PictureBox

    Sub New()
        'MouseMoveImage = My.Resources.labelback1

    End Sub

    Sub New(SetMouseMoveImage As Object)
        If SetMouseMoveImage = Nothing Then
            'MouseMoveImage = My.Resources.labelback1
        Else
            'MouseMoveImage = SetMouseMoveImage
        End If
    End Sub

    ' Public Sub CreatLyrImage()
    '     LyrImage = New PictureBox
    '     Modren_UI.Controls.Add(LyrImage)
    ' With LyrImage
    ' .Visible = False
    ' .Size = New Size(16, 16)
    ' .Location = New Point(245, Me.Location.Y + Me.Size.Height / 2 - .Size.Height / 2 + 147)
    ''.Image = My.Resources.attachment_1_16
    '.BackColor = Color.FromArgb(87, 135, 195)
    '.BringToFront()
    'End With
    ''AddHandler LyrImage.MouseMove, AddressOf Modren_UI.LyrImage_MouseMove
    ''AddHandler LyrImage.MouseLeave, AddressOf Modren_UI.LyrImage_MouseLeave
    ''AddHandler LyrImage.MouseUp, AddressOf Modren_UI.LyrImage_MouseUp
    'End Sub


    'Public Function GetObLyrImage() As PictureBox
    'Return LyrImage
    'End Function

    'Shared Sub ObLyrImageExchange(ob1 As LabelWithIndex, ob2 As LabelWithIndex)
    ''Dim temp As Point = New Point(245, ob1.LyrImage.Location.Y)
    '    ob1.LyrImage.Location = New Point(245, ob2.LyrImage.Location.Y)
    '    ob2.LyrImage.Location = temp
    'Dim temp2 As PictureBox = ob1.LyrImage
    '    ob1.LyrImage = ob2.LyrImage
    '    ob2.LyrImage = temp2
    'End Sub

    Public Class Lyrics
        Private _Lyrics As Hashtable = New Hashtable

        Protected HaveLyrics As Boolean = False
        Protected HaveLanguages As Boolean = False
        Private _Lyrics2 As Hashtable = New Hashtable
        'Private parent As LabelWithIndex

        'Public Sub New(obj As LabelWithIndex)
        '    parent = obj
        'End Sub


        Public Function GetHaveLyrics() As Boolean
            Return HaveLyrics
        End Function
        Public Function GetHaveLanguages() As Boolean
            Return HaveLanguages
        End Function

        Public Sub Add(ByVal key As String, ByVal value As String)
            Dim changedkey As Double = ChangetoD(key)
            Try
                If changedkey <> 0 AndAlso _Lyrics.ContainsKey(changedkey) = True And _Lyrics2.ContainsKey(changedkey) = False Then _Lyrics2.Add(changedkey, value) : HaveLanguages = True
                If changedkey <> 0 AndAlso _Lyrics.ContainsKey(changedkey) = False Then _Lyrics.Add(changedkey, value)
            Catch ex As Exception
                MsgBox("导入歌词时发生错误" + ex.Message)
            End Try
            HaveLyrics = True
            'parent.GetObLyrImage.Visible = True
        End Sub

        Private Function ChangetoD(str As String) As Double
            Dim min As Double = 0, s As Double = 0, ms As Double = 0
            Try
                min = CDbl(str.Substring(0, str.IndexOf(":")))
                If str.IndexOf(".") <> -1 Then
                    s = CDbl(str.Substring(str.IndexOf(":") + 1, str.IndexOf(".") - str.IndexOf(":") - 1))
                    ms = CDbl(str.Substring(str.IndexOf(".") + 1))
                Else
                    s = CDbl(str.Substring(str.IndexOf(".") + 1))
                End If

            Catch ex As Exception

            End Try
            If ms >= 100 Then ms /= 10
            Return min * 60 + s + ms / 100
        End Function

        Public Sub AddString(ByVal str As String)
            Dim time As String = "", word As String = ""
            Dim nowPosition As Integer = str.IndexOf("["), rightPosition As Integer = 0, nextPosition As Integer = 0
            If str = "" Or nowPosition = -1 Then Exit Sub
            Do Until nowPosition = str.Length
                rightPosition = str.IndexOf("]", nowPosition)
                If rightPosition = -1 Then Throw New ArgumentException("[]不匹配")
                nextPosition = str.IndexOf("[", rightPosition)
                If nextPosition = -1 Then nextPosition = str.Length
                time = str.Substring(nowPosition + 1, rightPosition - nowPosition - 1)
                word = str.Substring(rightPosition + 1, nextPosition - rightPosition - 1)
                Call Add(time, word)
                nowPosition = nextPosition
            Loop
        End Sub

        Public Sub AddLine(ByVal str As String)
            Dim time() As String, word As String = ""
            Dim nowPosition As Integer = str.IndexOf("["), rightPosition As Integer = 0
            Dim time_num As Integer = -1
            If str = "" Or nowPosition = -1 Then Exit Sub
            'If str.Substring(0, 1) <> "[" And str.Substring(0, 1) <> vbCr And str.Substring(0, 1) <> vbLf And str.Substring(0, 1) <> vbCrLf Then Exit Sub
            If nowPosition = -1 Then Exit Sub
            Do Until str.Length <= nowPosition OrElse (str.Substring(nowPosition, 1) <> "[" And str.Substring(nowPosition, 1) <> vbCr And str.Substring(nowPosition, 1) <> vbLf And str.Substring(nowPosition, 1) <> vbCrLf)
                rightPosition = str.IndexOf("]", nowPosition)
                If rightPosition = -1 Then
                    Exit Do
                End If
                time_num += 1
                ReDim Preserve time(time_num)
                time(time_num) = str.Substring(nowPosition + 1, rightPosition - nowPosition - 1)
                nowPosition = rightPosition + 1
            Loop
            word = str.Substring(nowPosition)
            Dim i As Integer
            For i = 0 To time_num
                Call Add(time(i), word)
            Next
        End Sub

        Public Property Lyrics As Hashtable
            Get
                Return _Lyrics
            End Get
            Set
                _Lyrics = Value
            End Set
        End Property
        Public Property Lyrics2 As Hashtable
            Get
                Return _Lyrics2
            End Get
            Set
                _Lyrics2 = Value
            End Set
        End Property
    End Class

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
