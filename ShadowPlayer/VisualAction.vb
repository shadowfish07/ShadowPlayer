Public Class VisualAction
    Dim WithEvents _timer As New Timer
    Dim _totalLength As Single
    Dim _step As Single
    Dim _movedTarget As Panel
    Dim _ShowOrHide As Integer

    Public Sub New(target As Panel， total_length As Single, total_time As Single, interval As Integer)
        _movedTarget = target
        _timer.Interval = interval
        _step = total_time / _timer.Interval
        _totalLength = total_length
    End Sub


    Public Sub ShowList()
        _ShowOrHide = 1
        _timer.Start()
    End Sub

    Public Sub HideList()
        _ShowOrHide = -1
    End Sub

    Private Sub Timer_Tick() Handles _timer.Tick
        Static Decreased_num As Single
        If Decreased_num + _ShowOrHide * _step > _totalLength Then
            Decreased_num = _totalLength
            _movedTarget.Location = New Point(_movedTarget.Location.X, _movedTarget.Location.Y + _ShowOrHide * Decreased_num)
        End If
    End Sub
End Class
