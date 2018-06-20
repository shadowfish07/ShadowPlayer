Public Class PlayProgress
    Dim gr As Graphics
    Dim br As Brush
    Dim backcolor As Color
    Dim frontcolor As Color
    Dim width As Integer
    Dim yuanHuan As Region
    Dim fillArea As Region
    Dim fillHeight As Integer

    Public Sub New(target As Graphics, width As Integer, backcolor As Color, frontcolor As Color)
        gr = target
        Me.width = width
        Me.backcolor = backcolor
        Me.frontcolor = frontcolor
    End Sub

    Function SetYuanHuan(target As Graphics, width As Integer) As Region

    End Function

    Public Sub Draw()

    End Sub

    Function GetFillArea() As Region

    End Function

    Public Function IsinYuanHuan() As Boolean

    End Function


End Class
