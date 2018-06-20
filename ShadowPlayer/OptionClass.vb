Public Class OptionClass
    Private _LoudOpen As New Myboolean(True)
    Private _CloseOpen As New Myboolean(True,,, {_CloseEndOpen, _CloseMiniOpen})
    Private _CloseEndOpen As New Myboolean(False, {_CloseEndOpen, _CloseMiniOpen})
    Private _CloseMiniOpen As New Myboolean(True, {_CloseEndOpen, _CloseMiniOpen})
    Private _AfterClose_puase As New Myboolean(False, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
    Private _AfterClose_stop As New Myboolean(False, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
    Private _AfterClose_next As New Myboolean(True, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
    Private _LyricScreenOpen As New Myboolean(True)

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

        Public Sub New(Value As Boolean, Optional OnlyOneTrue() As Myboolean = Nothing, Optional OnlyOneFalse() As Myboolean = Nothing, Optional _
                       Children() As Myboolean = Nothing)
            '检测是否存在只有一个为真/假时Value值的非法性
            '
            _Value = Value
            Dim i As Integer
            If Not OnlyOneTrue Is Nothing Then
                ReDim _OnlyOneTrue(UBound(OnlyOneTrue))
            Else
                ReDim _OnlyOneTrue(-1)
            End If
            If Not OnlyOneFalse Is Nothing Then
                ReDim _OnlyOneFalse(UBound(OnlyOneFalse))
            Else
                ReDim _OnlyOneFalse(-1)
            End If
            If Not Children Is Nothing Then
                ReDim _Children(UBound(Children))
            Else
                ReDim _Children(-1)
            End If

            For i = 0 To UBound(_OnlyOneTrue)
                Me.OnlyOneTrue(i) = _OnlyOneTrue(i)
            Next
            For i = 0 To UBound(_OnlyOneFalse)
                Me.OnlyOneFalse(i) = _OnlyOneFalse(i)
            Next
            For i = 0 To UBound(_Children)
                Me.Children(i) = _Children(i)
            Next

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
                For i = 0 To UBound(_OnlyOneTrue)
                    If Not (_OnlyOneTrue Is Me) Then
                        _OnlyOneTrue(i).Value = False

                    End If
                Next
            Else
                For i = 0 To UBound(_OnlyOneFalse)
                    If Not (_OnlyOneFalse Is Me) Then
                        _OnlyOneFalse(i).Value = True

                    End If
                Next
            End If
            Call DealChildren()
        End Sub

        Private Sub DealChildren()
            Dim i As Integer
            For i = 0 To UBound(_Children)
                _Children(i).Enabled = Value

            Next
        End Sub

    End Class



    Public Sub SetToAdmin()
        _LoudOpen = New Myboolean(True)
        _CloseOpen = New Myboolean(True,,, {_CloseEndOpen, _CloseMiniOpen})
        _CloseEndOpen = New Myboolean(False, {_CloseEndOpen, _CloseMiniOpen})
        _CloseMiniOpen = New Myboolean(True, {_CloseEndOpen, _CloseMiniOpen})
        _AfterClose_puase = New Myboolean(False, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
        _AfterClose_stop = New Myboolean(False, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
        _AfterClose_next = New Myboolean(True, {_AfterClose_next, _AfterClose_puase, _AfterClose_stop})
        _LyricScreenOpen = New Myboolean(True)
    End Sub

    Public Sub New()

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
End Class
