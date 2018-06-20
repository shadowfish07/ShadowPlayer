Public Class Settings
    Private Sub PageCommand_Click(sender As Object, e As EventArgs) Handles btn_time.Click, btn_Lyric.Click
        Select Case True
            Case sender Is btn_time
                TabControl1.SelectedTab = TabPage_time
            Case sender Is btn_Lyric
                TabControl1.SelectedTab = TabPage_lyric
        End Select

        For Each b As Button In Panel1.Controls
            If b IsNot sender Then
                b.BackColor = Color.FromArgb(255, 43, 60, 75)
            ElseIf b Is sender Then
                b.BackColor = Color.FromArgb(255, 102, 121, 138)
            End If
        Next
    End Sub

    Private Sub btn_Mainexit_Click(sender As Object, e As EventArgs) Handles btn_Mainexit.Click
        Me.Close()
    End Sub

    Private Sub ChkSetTimeEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSetTimeEnabled.CheckedChanged
        PnlOpen.Enabled = ChkSetTimeEnabled.Checked
    End Sub

    Private Sub ChkSetCloseEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSetCloseEnabled.CheckedChanged
        PnlStop.Enabled = ChkSetCloseEnabled.Checked
    End Sub

    Private Sub ChkLyricOpen_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLyricOpen.CheckedChanged
        PnlLryic.Enabled = ChkLyricOpen.Checked
    End Sub
End Class
