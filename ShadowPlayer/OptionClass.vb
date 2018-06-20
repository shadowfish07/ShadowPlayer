Imports ShadowPlayer

Public Class OptionClass
    Private _alarm_LoudOpen As New Myboolean(True)
    Private _alarm_CloseOpen As New Myboolean(True)
    Private _whenClose_EndOpen As New Myboolean(False)
    Private _whenClose_MiniOpen As New Myboolean(True)
    Private _whenClose_NothingOpen As New Myboolean(False)
    Private _afterClose_puase As New Myboolean(False)
    Private _afterClose_stop As New Myboolean(False)
    Private _afterClose_next As New Myboolean(True)
    Private _lyricScreen_Open As New Myboolean(True)
    Private _preventSleep_Alltime As New Myboolean(False)
    Private _preventSleep_Alarm As New Myboolean(True)
    Private _preventSleep_Playing As New Myboolean(True)
    Private _preventSleep_Open As New Myboolean(True)

    Private _alarm_LoudTime As String = "13:29:50"
    Private _alarm_EndTime As String = "13:34:20"

    Public Property Lyric_SingleLine_ForeColor As Color = Color.Gold
    Public Property Lyric_CN_ForeColor As Color = Color.Gold
    Public Property Lyric_English_ForeColor As Color = Color.Moccasin
    Public Property Lyric_SingleLine_Font As Font = New Font("微软雅黑", 20)
    Public Property Lyric_CN_Font As Font = New Font("微软雅黑", 20)
    Public Property Lyric_English_Font As Font = New Font("微软雅黑", 20)
    'Public Property Lyric_Load_

    Public Property Video_AutoFullScreen As New Myboolean(True)

    Public Sub New()
        SetOnlyOneTrue({_whenClose_EndOpen, _whenClose_MiniOpen, _whenClose_NothingOpen})
        SetOnlyOneTrue({_afterClose_next, _afterClose_puase, _afterClose_stop})
    End Sub

    Private Sub SetOnlyOneTrue(group() As Myboolean)
        If Not group Is Nothing Then
            For Each i As Myboolean In group
                i.RedimOnlyOneTrue(UBound(group))
                Dim j As Integer = 0
                For Each k As Myboolean In group
                    i.OnlyOneTrue(j) = k
                    j += 1
                Next
                j = 0
            Next
        Else
            For Each i As Myboolean In group
                i.RedimOnlyOneTrue(-1)
            Next
        End If
    End Sub

    Private Sub SetOnlyOneFalse(group() As Myboolean)
        If Not group Is Nothing Then
            For Each i As Myboolean In group
                i.RedimOnlyOneFalse(UBound(group))
                Dim j As Integer = 0
                For Each k As Myboolean In group
                    i.OnlyOneFalse(j) = k
                    j += 1
                Next
                j = 0
            Next
        Else
            For Each i As Myboolean In group
                i.RedimOnlyOneFalse(-1)
            Next
        End If
    End Sub

    Private Sub SetChildren(father As Myboolean, group() As Myboolean)
        If Not group Is Nothing Then
            father.RedimChildren(UBound(group))
            For i = 0 To UBound(group)
                father.Children(i) = group(i)
            Next
        Else
            father.RedimChildren(-1)
        End If
    End Sub

    Public Property Alarm_CloseOpen As Myboolean
        Get
            Return _alarm_CloseOpen
        End Get
        Set
            _alarm_CloseOpen = Value
        End Set
    End Property

    Public Property WhenClose_EndOpen As Myboolean
        Get
            Return _whenClose_EndOpen
        End Get
        Set
            _whenClose_EndOpen = Value
        End Set
    End Property

    Public Property WhenClose_MiniOpen As Myboolean
        Get
            Return _whenClose_MiniOpen
        End Get
        Set
            _whenClose_MiniOpen = Value
        End Set
    End Property

    Public Property AfterClose_puase As Myboolean
        Get
            Return _afterClose_puase
        End Get
        Set
            _afterClose_puase = Value
        End Set
    End Property

    Public Property AfterClose_stop As Myboolean
        Get
            Return _afterClose_stop
        End Get
        Set
            _afterClose_stop = Value
        End Set
    End Property

    Public Property AfterClose_next As Myboolean
        Get
            Return _afterClose_next
        End Get
        Set
            _afterClose_next = Value
        End Set
    End Property

    Public Property LyricScreen_Open As Myboolean
        Get
            Return _lyricScreen_Open
        End Get
        Set
            _lyricScreen_Open = Value
        End Set
    End Property

    Public Property Alarm_LoudOpen As Myboolean
        Get
            Return _alarm_LoudOpen
        End Get
        Set
            _alarm_LoudOpen = Value
        End Set
    End Property

    Public Property Alarm_EndTime As String
        Get
            If _alarm_CloseOpen.Value Then
                Return _alarm_EndTime
            Else
                Return "未设置"
            End If

        End Get
        Set(value As String)
            _alarm_EndTime = value
        End Set
    End Property

    Public Property Alarm_LoudTime As String
        Get
            If _alarm_LoudOpen.Value Then
                Return _alarm_LoudTime
            Else
                Return "未设置"
            End If

        End Get
        Set(value As String)
            _alarm_LoudTime = value
        End Set
    End Property

    Public Property WhenClose_NothingOpen As Myboolean
        Get
            Return _whenClose_NothingOpen
        End Get
        Set(value As Myboolean)
            _whenClose_NothingOpen = value
        End Set
    End Property

    Public Property PreventSleep_Alltime As Myboolean
        Get
            Return _preventSleep_Alltime
        End Get
        Set(value As Myboolean)
            _preventSleep_Alltime = value
        End Set
    End Property

    Public Property PreventSleep_Playing As Myboolean
        Get
            Return _preventSleep_Playing
        End Get
        Set(value As Myboolean)
            _preventSleep_Playing = value
        End Set
    End Property

    Public Property PreventSleep_Alarm As Myboolean
        Get
            Return _preventSleep_Alarm
        End Get
        Set(value As Myboolean)
            _preventSleep_Alarm = value
        End Set
    End Property

    Public Property PreventSleep_Open As Myboolean
        Get
            Return _preventSleep_Open
        End Get
        Set(value As Myboolean)
            _preventSleep_Open = value
        End Set
    End Property

    Public Class Myboolean
        Private _Value As Boolean
        Private _OnlyOneTrue() As Myboolean
        Private _OnlyOneFalse() As Myboolean
        Private _Children() As Myboolean
        Public Property Enabled As Boolean = True

        Public Property OnlyOneTrue(index As Integer) As Myboolean
            Get
                Return _OnlyOneTrue(index)
            End Get
            Set
                _OnlyOneTrue(index) = Value
            End Set
        End Property
        Public Property OnlyOneFalse(index As Integer) As Myboolean
            Get
                Return _OnlyOneFalse(index)
            End Get
            Set
                _OnlyOneFalse(index) = Value
            End Set
        End Property
        Public Property Children(index As Integer) As Myboolean
            Get
                Return _Children(index)
            End Get
            Set
                _Children(index) = Value
            End Set
        End Property
        Public Sub RedimOnlyOneTrue(ubound As Integer)
            ReDim _OnlyOneTrue(ubound)
        End Sub
        Public Sub RedimOnlyOneFalse(ubound As Integer)
            ReDim _OnlyOneFalse(ubound)
        End Sub
        Public Sub RedimChildren(ubound As Integer)
            ReDim _Children(ubound)
        End Sub


        Public Sub New(Value As Boolean)
            _Value = Value
        End Sub

        Public Property Value As Boolean
            Get
                Return _Value
            End Get
            Set
                If Enabled = False Then Exit Property
                _Value = Value
                Call DealOnlys()

            End Set
        End Property

        Public Sub Change()
            Value = Not Value
        End Sub

        Private Sub DealOnlys()
            Dim i As Integer
            If Value = True Then
                If _OnlyOneTrue IsNot Nothing Then
                    For i = 0 To UBound(_OnlyOneTrue)
                        If Not (_OnlyOneTrue(i) Is Me) Then
                            _OnlyOneTrue(i)._Value = False

                        End If
                    Next
                End If
            Else
                If _OnlyOneFalse IsNot Nothing Then
                    For i = 0 To UBound(_OnlyOneFalse)
                        If Not (_OnlyOneFalse(i) Is Me) Then
                            _OnlyOneFalse(i)._Value = True

                        End If
                    Next
                End If
            End If
            Call DealChildren()
        End Sub

        Private Sub DealChildren()
            Dim i As Integer
            If _Children IsNot Nothing Then
                For i = 0 To UBound(_Children)
                    _Children(i).Enabled = _Value

                Next
            End If
        End Sub

    End Class



    Public Sub SetToAdmin()
        _alarm_LoudOpen = New Myboolean(True)
        _alarm_CloseOpen = New Myboolean(True)
        _whenClose_EndOpen = New Myboolean(False)
        _whenClose_MiniOpen = New Myboolean(True)
        _afterClose_puase = New Myboolean(False)
        _afterClose_stop = New Myboolean(False)
        _afterClose_next = New Myboolean(True)
        _lyricScreen_Open = New Myboolean(True)
        SetOnlyOneTrue({_whenClose_EndOpen, _whenClose_MiniOpen, _whenClose_NothingOpen})
        SetOnlyOneTrue({_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
        _alarm_LoudTime = "13:50:35"
        _alarm_EndTime = "13:54:20"
    End Sub



    Public Enum EOptions
        _LoudOpen
        _CloseOpen
        _CloseEndOpen
        _CloseMiniOpen
        _AfterClose_puase
        _AfterClose_stop
        _AfterClose_next
        _LyricScreenOpen
    End Enum


End Class
