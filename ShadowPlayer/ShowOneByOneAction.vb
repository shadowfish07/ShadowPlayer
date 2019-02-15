Public Class ShowOneByOneAction
    Inherits VisualAction
    '用于控件左移，逐步展现水平方向上的其他控件
    '目前只支持左移
    Dim ToBeShowedControl() As Control
    Dim _toShow As Boolean
    Dim _targetLocation As PointF
    Dim _total_time As Single
    Dim _interval As Single
    Public Property OriginLocation As Point


    Public Sub Back(total_time As Single, interval As Integer)
        [Stop]()
        SetInterval(total_time, interval, OriginLocation)
        _toShow = False
        MyBase.Start()
    End Sub

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer, ToBeShowedControl() As Control, toShow As Boolean)
        MyBase.New(target, targetLocation, total_time, interval)
        _targetLocation = targetLocation
        _total_time = total_time
        _interval = interval
        Me.ToBeShowedControl = ToBeShowedControl.Clone
        _toShow = toShow
        OriginLocation = target.Location
    End Sub

    Public Overloads Sub Start()
        _toShow = True
        TargetLocation = _targetLocation
        SetInterval(_total_time, _interval, _targetLocation)
        MyBase.Start()
    End Sub

    Private Sub Change(sander As Object, e As VisualActionEventArg) Handles MyBase.OncePace
        Finished = e.IsLastPace
        For Each c As Control In ToBeShowedControl
            If _toShow = True Then
                If _target.Location.X <= c.Location.X Then
                    c.Visible = True
                End If
            Else
                If _target.Location.X >= c.Location.X Then
                    c.Visible = False
                End If
            End If
        Next
    End Sub
End Class
