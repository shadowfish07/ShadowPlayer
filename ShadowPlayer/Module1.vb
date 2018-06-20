Module Module1

    'Public Option_loudOpen As Boolean = True, Option_closeOpen As Boolean = True, Option_closeEndOpen As Boolean = False, Option_closeMiniOpen As Boolean = True
    'Public Option_afterClose_puase As Boolean = False, Option_afterClose_stop As Boolean = False, Option_afterClose_next As Boolean = True
    'Public Option_lyricScreenOpen As Boolean = True



    Public Function ListTidy(ByVal text As String, length As Integer) As String
        If Len(text) <= length Then
            ListTidy = text
        Else
            ListTidy = Left(text, length - 3) + "..."
        End If
    End Function

    Public Function StrLength(ByVal str As String) As Integer
        Dim i As Char
        For Each i In str
            If Asc(i) < 0 Then
                StrLength += 2
            Else
                StrLength += 1
            End If
        Next
        Return StrLength
    End Function

    Public Enum CPlayState
        Playing = 3
        Stoping = 1
        Pausing = 2
        Undifined = 0
        Ready = 10
        Connecting = 9
    End Enum
    Public Enum Cplaynum
        ListOnce = 1
        ListCycle
        OneOnce
        OneCycle
        Random
    End Enum


    Public Function Change_trc(str As String) As String
        Dim i As Integer
        Dim find As Boolean = False
        Change_trc = ""
        For i = 0 To str.Length - 1
            If str.Substring(i, 1) <> "<" And find = False Then
                Change_trc += str.Substring(i, 1)
            ElseIf str.Substring(i, 1) = "<" Then
                find = True
            ElseIf str.Substring(i, 1) = ">" Then
                find = False
            End If
        Next
        Return Change_trc
    End Function

    Public Sub ArrayListRemoveItem(ByVal arr As ArrayList, ByVal index As Integer)
        If index = arr.Count - 1 Then
            arr.RemoveAt(index)
        ElseIf index > arr.Count - 1 Then
            Throw New ArgumentException("索引超出范围")
        Else
            Dim i As Integer
            For i = index To arr.Count - 2
                arr(i) = arr(i + 1)
                arr(i).index = i
            Next
            arr.RemoveAt(arr.Count - 1)
        End If
    End Sub
End Module
