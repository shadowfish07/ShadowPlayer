Public Class ShowOneByOneAction
    Inherits VisualAction
    '用于控件左移，逐步展现水平方向上的其他控件
    '目前只支持左移

    Dim ToBeShowedControl() As Control

    Public Sub New(target As Control， targetLocation As PointF, total_time As Single, interval As Integer, ToBeShowedControl() As Control)
        MyBase.New(target, targetLocation, total_time, interval)
        ReDim Me.ToBeShowedControl(ToBeShowedControl.Length - 1)
        For Each a As Control In ToBeShowedControl
            Dim i As Integer
            Me.ToBeShowedControl(i) = a
        Next
    End Sub

    Private Sub Change(sander As Object, e As VisualActionEventArg) Handles MyBase.OncePace
        For Each c As Control In ToBeShowedControl
            If _target.Location.X <= c.Location.X Then
                c.Visible = True
            End If
        Next
    End Sub
End Class
