Public Class VisualAction
    '视觉动作基类
    Dim WithEvents _timer As New Timer
    Dim _totalLength As Single = 0
    Protected _stepX As Single = 0, _stepY As Single = 0
    Protected _target As Control = Nothing
    Dim _targetLocation As PointF
    Dim _isHeightMove As Boolean = False, _isWeightMove As Boolean = False
    Public Property Finished As Boolean = True

    Event OncePace(sender As Object, e As VisualActionEventArg)

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        Initialize(target, targetLocation, total_time, interval)
    End Sub

    Public Sub Initialize(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        Me.Target = target
        Me.TargetLocation = targetLocation
        _timer.Interval = interval
        Call GetStep(total_time)
        If Me.Target.Location.X = targetLocation.X Then
            _isHeightMove = True
        ElseIf Me.Target.Location.Y = targetLocation.Y Then
            _isWeightMove = True
        End If
    End Sub

    Public Sub New()

    End Sub

    Protected Sub SetInterval(total_time As Single, interval As Integer, targetLocation As PointF)
        Me.TargetLocation = targetLocation
        _timer.Interval = interval
        Call GetStep(total_time)
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

        Dim isLastPace As Boolean = Me.IsLastPace(tempX, tempY)


        If Math.Abs(tempX) > 1 Then
            If tempX > 0 Then
                If isLastPace = False Then _target.Location = New Point(_target.Location.X + Math.Abs(Math.Floor(tempX)), _target.Location.Y)
                changeX = Math.Abs(Math.Floor(tempX))
                tempX -= Math.Abs(Math.Floor(tempX))
            Else
                If isLastPace = False Then _target.Location = New Point(_target.Location.X - Math.Abs(Math.Ceiling(tempX)), _target.Location.Y)
                changeX = -Math.Abs(Math.Ceiling(tempX))
                tempX += Math.Abs(Math.Ceiling(tempX))
            End If
        End If
        If Math.Abs(tempY) > 1 And isLastPace = False Then
            If tempY > 0 Then
                If isLastPace = False Then _target.Location = New Point(_target.Location.X, _target.Location.Y + Math.Abs(Math.Floor(tempY)))
                changeY = Math.Abs(Math.Floor(tempY))
                tempY -= Math.Abs(Math.Floor(tempY))
            Else
                If isLastPace = False Then _target.Location = New Point(_target.Location.X, _target.Location.Y - Math.Abs(Math.Ceiling(tempY)))
                changeY = -Math.Abs(Math.Ceiling(tempY))
                tempY += Math.Abs(Math.Ceiling(tempY))
            End If
        End If
        Finished = isLastPace
        If isLastPace = True Then
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

    Protected Function IsLastPace(toAddX As Single, toAddY As Single) As Boolean
        If _isHeightMove = True Then
            If toAddY > 0 Then
                If _target.Location.Y + Math.Floor(toAddY) >= TargetLocation.Y Then
                    Return True
                End If
            Else
                If _target.Location.Y + Math.Ceiling(toAddY) <= TargetLocation.Y Then
                    Return True
                End If
            End If
        ElseIf _isWeightMove = True Then
            If toAddX > 0 Then
                If _target.Location.X + Math.Floor(toAddX) >= TargetLocation.X Then
                    Return True
                End If
            Else
                If _target.Location.X + Math.Ceiling(toAddX) <= TargetLocation.X Then
                    Return True
                End If
            End If
        Else
            If toAddX > 0 Then
                If _target.Location.X + Math.Floor(toAddX) >= TargetLocation.X Then
                    Return True
                End If
            Else
                If _target.Location.X + Math.Ceiling(toAddX) <= TargetLocation.X Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function
End Class
