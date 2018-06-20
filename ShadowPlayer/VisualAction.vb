Public Class VisualAction
    '视觉动作基类
    Dim WithEvents _timer As New Timer
    Dim _totalLength As Single
    Protected _stepX As Single, _stepY As Single
    Protected _target As Control
    Dim _targetLocation As PointF
    Dim _isHeightMove As Boolean = False, _isWeightMove As Boolean = False

    Event OncePace(sender As Object, e As VisualActionEventArg)

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        Me.Target = target
        Me.TargetLocation = targetLocation
        _timer.Interval = interval
        Call GetStep(total_time)
        If Me.Target.Location.X = targetLocation.X Then
            _isheightmove = True
        ElseIf Me.Target.Location.y = targetLocation.y Then
            _isweightmove = True
        End If

    End Sub

    Private Sub GetStep(total_time As Single)
        Dim [step] As Single, x As Single, y As Single, c As Single, sin As Single, cos As Single

        x = TargetLocation.X - Target.Location.X : y = TargetLocation.Y - Target.Location.Y
        c = Math.Sqrt(x ^ 2 + y ^ 2)
        [step] = c / (total_time / _timer.Interval)
        sin = Math.Abs(y / c) : cos = Math.Abs(x / c)
        If x >= 0 Then
            _stepX = cos * [step]
        Else
            _stepX = -cos * [step]
        End If
        If y >= 0 Then
            _stepY = sin * [step]
        Else
            _stepY = -sin * [step]
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
        If total_time <> -1 Then
            Call GetStep(total_time)
        End If
        _timer.Start()
    End Sub

    Public Sub [Stop]()
        _timer.Stop()
    End Sub

    Private Sub Timer_Tick() Handles _timer.Tick
        Static tempLocation As PointF = New PointF(_target.Location.X, _target.Location.Y)
        Static tempX As Single = 0
        Static tempY As Single = 0
        '用于事件输出
        Dim changeX As Integer
        Dim changeY As Integer

        tempX += _stepX
        tempY += _stepY

        If Math.Abs(tempX) > 1 Then
            If tempX > 0 Then
                _target.Location = New Point(_target.Location.X + Math.Abs(Math.Floor(tempX)), _target.Location.Y)
                changeX = Math.Abs(Math.Floor(tempX))
                tempX -= Math.Abs(Math.Floor(tempX))
            Else
                _target.Location = New Point(_target.Location.X - Math.Abs(Math.Ceiling(tempX)), _target.Location.Y)
                changeX = Math.Abs(Math.Ceiling(tempX))
                tempX += Math.Abs(Math.Ceiling(tempX))
            End If
        End If
        If Math.Abs(tempY) > 1 Then
            If tempY > 0 Then
                _target.Location = New Point(_target.Location.X, _target.Location.Y + Math.Abs(Math.Floor(tempY)))
                changeY = Math.Abs(Math.Floor(tempY))
                tempY -= Math.Abs(Math.Floor(tempY))
            Else
                _target.Location = New Point(_target.Location.X, _target.Location.Y - Math.Abs(Math.Ceiling(tempY)))
                changeY = Math.Abs(Math.Ceiling(tempY))
                tempY += Math.Abs(Math.Ceiling(tempY))
            End If
        End If

        If (_target.Location.X = TargetLocation.X And _isheightmove = False) Or (_target.Location.Y = TargetLocation.Y And _isweightmove = False) Then
            changeX = TargetLocation.X - _target.Location.X
            changeY = TargetLocation.Y - _target.Location.Y

            _target.Location = Point.Round(TargetLocation)
            _timer.Stop()
            tempLocation = Nothing
            tempX = 0
            tempY = 0
            RaiseEvent OncePace(Me, New VisualActionEventArg(True, changeX, changeY))
        Else
            RaiseEvent OncePace(Me, New VisualActionEventArg(False, changeX, changeY))
        End If
    End Sub

    Protected Function IsLastPace() As Boolean
        If _stepX > 0 Then
            If _target.Location.X + _stepX > _targetLocation.X Then
                Return True
            End If
        Else
            If _target.Location.X + _stepX < _targetLocation.X Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
