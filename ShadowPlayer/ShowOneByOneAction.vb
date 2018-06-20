Public Class ShowOneByOneAction
    Inherits VisualAction
    '用于控件左移，逐步展现水平方向上的其他控件
    '目前只支持左移

    Dim ToBeShowedControl() As Control
    Dim _toShow As Boolean

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer, ToBeShowedControl() As Control, toShow As Boolean)
        MyBase.New(target, targetLocation, total_time, interval)
        Me.ToBeShowedControl = ToBeShowedControl.Clone
        _toShow = toShow
    End Sub

    Private Sub Change(sander As Object, e As VisualActionEventArg) Handles MyBase.OncePace
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
