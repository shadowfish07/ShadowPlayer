Imports ShadowPlayer

Public Class OptionClass
    Private _LoudOpen As New Myboolean(True)
    Private _CloseOpen As New Myboolean(True)
    Private _CloseEndOpen As New Myboolean(False)
    Private _CloseMiniOpen As New Myboolean(True)
    Private _CloseNothingOpen As New Myboolean(False)
    Private _AfterClose_puase As New Myboolean(False)
    Private _AfterClose_stop As New Myboolean(False)
    Private _AfterClose_next As New Myboolean(True)
    Private _LyricScreenOpen As New Myboolean(True)
    Private _LoudTime As String = "13:30:22"
    Private _EndTime As String = "13:34:40"
    Public Property Lyric_SingleLine_ForeColor As Color = Color.Gold
    Public Property Lyric_CN_ForeColor As Color = Color.Gold
    Public Property Lyric_English_ForeColor As Color = Color.Moccasin
    Public Property Lyric_SingleLine_Font As Font = New Font("微软雅黑", 20)
    Public Property Lyric_CN_Font As Font = New Font("微软雅黑", 20)
    Public Property Lyric_English_Font As Font = New Font("微软雅黑", 20)
    'Public Property Lyric_Load_

    Public Sub New()
        SetOnlyOneTrue({_CloseEndOpen, _CloseMiniOpen, _CloseNothingOpen})
        SetOnlyOneTrue({_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
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

    Public Property CloseOpen As Myboolean
        Get
            Return _CloseOpen
        End Get
        Set
            _CloseOpen = Value
        End Set
    End Property

    Public Property CloseEndOpen As Myboolean
        Get
            Return _CloseEndOpen
        End Get
        Set
            _CloseEndOpen = Value
        End Set
    End Property

    Public Property CloseMiniOpen As Myboolean
        Get
            Return _CloseMiniOpen
        End Get
        Set
            _CloseMiniOpen = Value
        End Set
    End Property

    Public Property AfterClose_puase As Myboolean
        Get
            Return _AfterClose_puase
        End Get
        Set
            _AfterClose_puase = Value
        End Set
    End Property

    Public Property AfterClose_stop As Myboolean
        Get
            Return _AfterClose_stop
        End Get
        Set
            _AfterClose_stop = Value
        End Set
    End Property

    Public Property AfterClose_next As Myboolean
        Get
            Return _AfterClose_next
        End Get
        Set
            _AfterClose_next = Value
        End Set
    End Property

    Public Property LyricScreenOpen As Myboolean
        Get
            Return _LyricScreenOpen
        End Get
        Set
            _LyricScreenOpen = Value
        End Set
    End Property

    Public Property LoudOpen As Myboolean
        Get
            Return _LoudOpen
        End Get
        Set
            _LoudOpen = Value
        End Set
    End Property

    Public Property EndTime As String
        Get
            If _CloseOpen.Value Then
                Return _EndTime
            Else
                Return "未设置"
            End If

        End Get
        Set(value As String)
            _EndTime = value
        End Set
    End Property

    Public Property LoudTime As String
        Get
            If _LoudOpen.Value Then
                Return _LoudTime
            Else
                Return "未设置"
            End If

        End Get
        Set(value As String)
            _LoudTime = value
        End Set
    End Property

    Public Property CloseNothingOpen As Myboolean
        Get
            Return _CloseNothingOpen
        End Get
        Set(value As Myboolean)
            _CloseNothingOpen = value
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
        _LoudOpen = New Myboolean(True)
        _CloseOpen = New Myboolean(True)
        _CloseEndOpen = New Myboolean(False)
        _CloseMiniOpen = New Myboolean(True)
        _AfterClose_puase = New Myboolean(False)
        _AfterClose_stop = New Myboolean(False)
        _AfterClose_next = New Myboolean(True)
        _LyricScreenOpen = New Myboolean(True)
        SetOnlyOneTrue({_CloseEndOpen, _CloseMiniOpen, _CloseNothingOpen})
        SetOnlyOneTrue({_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
        _LoudTime = "13:50:35"
        _EndTime = "13:54:20"
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
