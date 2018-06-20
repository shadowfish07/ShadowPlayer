Imports System.Drawing.Drawing2D

Public Class PlayProgress
    Dim gr As Graphics
    Dim backcolor As Color
    Dim frontcolor As Color
    Dim width As Integer
    Dim yuanHuan As Region
    Dim fillArea As Region
    Dim fillHeight As Single = 0
    Dim inside_circle_r As Single, outside_circle_r As Single
    Dim outside_circle_x As Single, outside_circle_y As Single
    Dim inside_circle_x As Single, inside_circle_y As Single

    Public Sub New(target As Panel, width As Integer, backcolor As Color, frontcolor As Color)
        gr = target.CreateGraphics
        gr.SmoothingMode = SmoothingMode.AntiAlias
        Me.width = width
        Me.backcolor = backcolor
        Me.frontcolor = frontcolor
        outside_circle_r = target.Width / 2
        inside_circle_r = outside_circle_r - width
        outside_circle_x = 0 'target.Width / 2
        outside_circle_y = 0 'target.Height / 2
        inside_circle_x = outside_circle_r - inside_circle_r
        inside_circle_y = inside_circle_x
        yuanHuan = GetYuanHuan()
        gr.FillRegion(New SolidBrush(backcolor), yuanHuan)
        fillArea = GetFillArea()
    End Sub

    Function GetYuanHuan() As Region
        Dim pa As New GraphicsPath
        GetYuanHuan = New Region
        pa.AddEllipse(outside_circle_x, outside_circle_y, outside_circle_r * 2, outside_circle_r * 2)
        GetYuanHuan.MakeEmpty()
        GetYuanHuan.Union(pa)
        pa.Dispose()
        pa = New GraphicsPath
        pa.AddEllipse(inside_circle_x, inside_circle_y, inside_circle_r * 2, inside_circle_r * 2)
        GetYuanHuan.Exclude(pa)
        pa.Dispose()
    End Function

    Public Sub Draw()
        Dim br As New SolidBrush(backcolor)
        gr.FillRegion(br, yuanHuan)
        br.Dispose()
        br = New SolidBrush(frontcolor)
        gr.FillRegion(br, fillArea)
    End Sub

    Function GetFillArea() As Region
        Dim pa As New GraphicsPath
        pa.AddRectangle(New Rectangle(0, 2 * outside_circle_r - fillHeight, outside_circle_r * 2, fillHeight))
        Dim temp As Region = yuanHuan.Clone
        temp.Intersect(pa)
        pa.Dispose()
        Return temp
    End Function

    Public Function IsinYuanHuan(pos As Point) As Boolean
        Return yuanHuan.IsVisible(pos)
    End Function

    Public Sub Flush(rate As Single)
        fillHeight = rate * outside_circle_r * 2
        fillArea = GetFillArea()
        Me.Draw()
    End Sub
End Class
