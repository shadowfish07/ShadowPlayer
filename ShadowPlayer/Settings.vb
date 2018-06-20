Imports libVisualAction.Shadowfish.VisualAction

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

    Private Sub Options_MouseUp(sender As Object, e As EventArgs) Handles ChkLyricOpen.MouseUp, ChkSetCloseEnabled.MouseUp, ChkSetTimeEnabled.MouseUp
        Select Case True
            Case sender Is ChkLyricOpen
                PnlLryic.Enabled = ChkLyricOpen.Checked
            Case sender Is ChkSetCloseEnabled
                PnlStop.Enabled = ChkSetCloseEnabled.Checked
            Case sender Is ChkSetTimeEnabled
                PnlOpen.Enabled = ChkSetTimeEnabled.Checked
        End Select
        Dim showf As New GradualShow(SetChangedInform, 0.75)
        showf.Show()
    End Sub

    Private Sub ToChangeSetChangedInform()

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lbl_title.Text = "ShadowPlayer"
        Dim version As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString
        lbl_mainLevel.Text = "V" + version.Substring(0, version.Length - 5)
        lbl_buidLevel.Text = version.Substring(version.Length - 5)
        lbl_mainLevel.Left = Lbl_title.Location.X + Lbl_title.Width - 5
        lbl_buidLevel.Left = lbl_mainLevel.Location.X + lbl_mainLevel.Width - 6
    End Sub
End Class
