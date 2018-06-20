Public Class VisualAction
    '视觉动作基类
    Dim WithEvents _timer As New Timer
    Dim _totalLength As Single
    Dim _stepX As Single, _stepY As Single
    Dim _target As Control， _targetLocation As PointF

    Event OncePace(isLastPace As Boolean)

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        Dim [step] As Single, c As Single, x As Single, y As Single, sin As Single, cos As Single
        Me.Target = target
        Me.TargetLocation = targetLocation
        _timer.Interval = interval
        Call GetStep(total_time)
        [step] = total_time / _timer.Interval
        x = targetLocation.X - target.Location.X : y = targetLocation.Y - target.Location.Y
        c = Math.Sqrt(x ^ 2 + y ^ 2)
        sin = y / c : cos = x / c
        If x >= 0 Then
            _stepX = sin * [step]
        Else
            _stepX = -sin * [step]
        End If
        If y >= 0 Then
            _stepY = cos * [step]
        Else
            _stepY = -cos * [step]
        End If
    End Sub

    Private Sub GetStep(total_time As Single)
        Dim [step] As Single, x As Single, y As Single, c As Single, sin As Single, cos As Single
        [step] = total_time / _timer.Interval
        x = TargetLocation.X - Target.Location.X : y = TargetLocation.Y - Target.Location.Y
        c = Math.Sqrt(x ^ 2 + y ^ 2)
        sin = y / c : cos = x / c
        If x >= 0 Then
            _stepX = sin * [step]
        Else
            _stepX = -sin * [step]
        End If
        If y >= 0 Then
            _stepY = cos * [step]
        Else
            _stepY = -cos * [step]
        End If
    End Sub

    Public Property Target As Control
        Get
            Return _Target
        End Get
        Set(value As Control)
            _Target = value
        End Set
    End Property

    Public Property TargetLocation As PointF
        Get
            Return _targetLocation
        End Get
        Set(value As PointF)
            _targetLocation = value
        End Set
    End Property


    Public Sub Start(Optional total_time As Single = -1)
        If total_time = -1 Then
            Call GetStep(total_time)
        End If
        _timer.Start()
    End Sub

    Public Sub [Stop]()
        _timer.Stop()
    End Sub

    Private Sub Timer_Tick() Handles _timer.Tick
        If IsLastPace() Then
            _target.Location = CType(New PointF(CType(_targetLocation, Point)), Point)
            _timer.Stop()
            RaiseEvent OncePace(True)
        Else
            _target.Location = New PointF(_target.Location.X + _stepX, _target.Location.Y + _stepY)
            RaiseEvent OncePace(False)
        End If
    End Sub

    Private Function IsLastPace() As Boolean
        If _stepX > 0 Then
            If _targetLocation.X + _stepX > _targetLocation.X Then
                Return True
            End If
        Else
            If _targetLocation.X + _stepX < _targetLocation.X Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
