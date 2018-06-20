Public Class LogWriter
    Dim sw As IO.StreamWriter
    Public Sub New(logPath As String)
        sw = New IO.StreamWriter(logPath, True)
        Trace.Listeners.Add(New TextWriterTraceListener(sw))
    End Sub

    Public Sub Write(message As String)
        Trace.WriteLine("[" + Now.ToString + " " + Now.Millisecond + "]" + " " + message)
        sw.Flush()
    End Sub

    Public Sub Indent()
        Trace.Indent()
    End Sub

    Public Sub Unindent()
        Trace.Unindent()
    End Sub
End Class
