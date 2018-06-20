Public Class LogWriter
    Dim sw As IO.StreamWriter
    Public Sub New(logPath As String)
        sw = New IO.StreamWriter(logPath, True)
        Trace.Listeners.Add(New TextWriterTraceListener(sw))
    End Sub

    Public Sub Write(message As String)
        Trace.WriteLine("[" + Now.ToString + " " + Now.Millisecond.ToString + "]" + " " + message)
        sw.Flush()
    End Sub

    Public Sub Indent()
        Trace.Indent()
    End Sub

    Public Sub Unindent()
        Trace.Unindent()
    End Sub

    Public Sub PrintMyVision()
        Me.Indent()
        Trace.WriteLine("版本号： " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString)
        Trace.WriteLine("文件路径： " + Application.ExecutablePath)
        Trace.WriteLine("程序最后修改时间： " + IO.Directory.GetLastWriteTime(Application.ExecutablePath))
        Me.Unindent()
    End Sub

    Public Sub EndWrite(Optional message As String = "")
        Me.Write("程序退出")
        Trace.Indent()
        Trace.WriteLine("附加信息：" + message)
        Trace.Unindent()
        Trace.WriteLine("=========================================")
        sw.Flush()
    End Sub
End Class
