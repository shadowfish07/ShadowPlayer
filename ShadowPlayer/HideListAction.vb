Public Class HideListAction
    '本类功能：
    '确保移动时下底不变

    Inherits VisualAction
    Dim _stepToHeight As Single
    Dim _targetHeight As Integer

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        MyBase.New(target, targetLocation, total_time, interval)
        _stepToHeight = target.Height / (total_time / interval)
        If _stepY > 0 Then
            _targetHeight = 0
            _stepToHeight = -_stepToHeight
        Else
            _targetHeight = target.Height
        End If
    End Sub

    Private Sub Change(sander As Object, e As VisualActionEventArg) Handles MyBase.OncePace
        _target.Height += -e.StepY
    End Sub
End Class
