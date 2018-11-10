Public Class HideListAction
    '本类功能：
    '确保移动时下底不变

    Inherits VisualAction

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer)
        MyBase.New(target, targetLocation, total_time, interval)
    End Sub

    Private Sub Change(sander As Object, e As VisualActionEventArg) Handles MyBase.OncePace
        _target.Height += -e.StepY
    End Sub
End Class
