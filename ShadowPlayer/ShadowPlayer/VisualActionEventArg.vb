Public Class VisualActionEventArg
    Inherits EventArgs
    Dim _isLastPace As Boolean
    Dim _stepX As Integer
    Dim _stepY As Integer

    Public Sub New(lastPace As Boolean, stepX As Integer, stepY As Integer)
        IsLastPace = lastPace
        Me.StepX = stepX
        Me.StepY = stepY
    End Sub

    Public Property IsLastPace As Boolean
        Get
            Return _isLastPace
        End Get
        Set(value As Boolean)
            _isLastPace = value
        End Set
    End Property

    Public Property StepX As Integer
        Get
            Return _stepX
        End Get
        Set(value As Integer)
            _stepX = value
        End Set
    End Property

    Public Property StepY As Integer
        Get
            Return _stepY
        End Get
        Set(value As Integer)
            _stepY = value
        End Set
    End Property
End Class
