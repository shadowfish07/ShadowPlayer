Imports System.Windows.Forms

Namespace Shadowfish
    Namespace VisualAction
        ''' <summary>
        ''' 该类用于实现窗体渐显渐隐
        ''' </summary>
        Public Class GradualShow


            Private _target As Form
            Private WithEvents _timer As Timer = New Timer With {.Enabled = False, .Interval = 20}
            Private WithEvents _timerStop As Timer = New Timer With {.Enabled = False, .Interval = 100}
            Private _remainTime As Single
            Private _pace As Single
            Private _sum As Single = 0

            Event FinishedShow(sender As Object, e As EventArgs)
            Event FinishedClosed(sender As Object, e As EventArgs)

            Public Sub New(target As Form, Optional remainTime As Single = -1)
                _target = target
                _remainTime = remainTime
            End Sub

            Public Sub Show(Optional pace As Single = 0.05)
                _target.Opacity = 0
                _target.Show()
                _pace = pace
                _sum = 0
                _timerStop.Stop()
                _timer.Enabled = True

            End Sub

            Public Sub Closed(Optional pace As Single = -0.05)
                _pace = pace

                _timer.Enabled = True

            End Sub

            Private Sub Tick() Handles _timer.Tick
                If (_target.Opacity >= 1 And _pace > 0) Or (_target.Opacity <= 0 And _pace < 0) Then
                    _timer.Enabled = False
                    If _pace > 0 Then
                        RaiseEvent FinishedShow(Me, New EventArgs)
                    ElseIf _pace < 0 Then
                        RaiseEvent FinishedClosed(Me, New EventArgs)
                    End If

                Else
                    _target.Opacity += _pace
                End If
            End Sub

            Private Sub DealFinishedShow(sender As Object, e As EventArgs) Handles Me.FinishedShow
                If _remainTime <> -1 Then
                    _timerStop.Start()
                End If
            End Sub

            Private Sub StopTick() Handles _timerStop.Tick

                _sum += 0.1
                If _sum >= _remainTime Then
                    _sum = 0
                    Closed()
                    _timerStop.Stop()
                End If

            End Sub

        End Class
    End Namespace
End Namespace


