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

    Private Sub Options_Changed(sender As Object, e As EventArgs) Handles ChkLyricOpen.MouseUp, ChkSetCloseEnabled.MouseUp, ChkSetTimeEnabled.MouseUp,
            btn_saveCloseTime.Click, btn_saveLoudTime.Click,
            RdoSetCloseNothing.Click, RdoSetEndEnabled.Click, RdoSetMiniEnabled.Click,
            RdoStop.Click, RdoPause.Click, RdoNext.Click,
            PicLyricColor.Click, PicCnLyricColor.Click, PicEnLyricColor.Click

        Dim cancel As Boolean = False

        Select Case True
            Case sender Is ChkLyricOpen
                PnlLryic.Enabled = ChkLyricOpen.Checked
                Modren_UI.mainOption.LyricScreenOpen.Value = ChkLyricOpen.Checked
            Case sender Is ChkSetCloseEnabled
                PnlStop.Enabled = ChkSetCloseEnabled.Checked
                Modren_UI.mainOption.CloseOpen.Value = ChkSetCloseEnabled.Checked
            Case sender Is ChkSetTimeEnabled
                PnlOpen.Enabled = ChkSetTimeEnabled.Checked
                Modren_UI.mainOption.LoudOpen.Value = ChkSetTimeEnabled.Checked
            Case sender Is btn_saveLoudTime
                Modren_UI.mainOption.LoudTime = txtLoudTime.Text
                btn_saveLoudTime.Visible = False
            Case sender Is btn_saveCloseTime
                Modren_UI.mainOption.EndTime = txtEndTime.Text
                btn_saveCloseTime.Visible = False
            Case sender Is RdoSetCloseNothing
                Modren_UI.mainOption.CloseNothingOpen.Value = True
            Case sender Is RdoSetEndEnabled
                Modren_UI.mainOption.CloseEndOpen.Value = True
            Case sender Is RdoSetMiniEnabled
                Modren_UI.mainOption.CloseMiniOpen.Value = True
            Case sender Is RdoNext
                Modren_UI.mainOption.AfterClose_next.Value = True
            Case sender Is RdoPause
                Modren_UI.mainOption.AfterClose_puase.Value = True
            Case sender Is RdoStop
                Modren_UI.mainOption.AfterClose_stop.Value = True
            Case sender Is PicLyricColor
                ColorDialog1.Color = Modren_UI.mainOption.Lyric_SingleLine_ForeColor
                If ColorDialog1.ShowDialog() = DialogResult.OK Then
                    PicLyricColor.BackColor = ColorDialog1.Color
                    Modren_UI.mainOption.Lyric_SingleLine_ForeColor = ColorDialog1.Color
                Else
                    cancel = True
                End If
            Case sender Is PicCnLyricColor
                ColorDialog1.Color = Modren_UI.mainOption.Lyric_CN_ForeColor
                If ColorDialog1.ShowDialog() = DialogResult.OK Then
                    PicCnLyricColor.BackColor = ColorDialog1.Color
                    Modren_UI.mainOption.Lyric_CN_ForeColor = ColorDialog1.Color
                Else
                    cancel = True
                End If
            Case sender Is PicEnLyricColor
                ColorDialog1.Color = Modren_UI.mainOption.Lyric_English_ForeColor
                If ColorDialog1.ShowDialog() = DialogResult.OK Then
                    PicEnLyricColor.BackColor = ColorDialog1.Color
                    Modren_UI.mainOption.Lyric_English_ForeColor = ColorDialog1.Color
                Else
                    cancel = True
                End If
        End Select
        If cancel = False Then
            SetChangedInform.Show()
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lbl_title.Text = "ShadowPlayer"
        Dim version As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString
        lbl_mainLevel.Text = "V" + version.Substring(0, version.Length - 5)
        lbl_buidLevel.Text = version.Substring(version.Length - 5)
        lbl_mainLevel.Left = Lbl_title.Location.X + Lbl_title.Width - 5
        lbl_buidLevel.Left = lbl_mainLevel.Location.X + lbl_mainLevel.Width - 6
        lbl_CheckUpdates.Left = lbl_buidLevel.Location.X + lbl_buidLevel.Width + 6

        '读入现有设置
        '定时
        ChkSetCloseEnabled.Checked = Modren_UI.mainOption.CloseOpen.Value
        ChkSetTimeEnabled.Checked = Modren_UI.mainOption.LoudOpen.Value
        txtEndTime.Text = Modren_UI.mainOption.EndTime
        txtLoudTime.Text = Modren_UI.mainOption.LoudTime
        RdoSetEndEnabled.Checked = Modren_UI.mainOption.CloseEndOpen.Value
        RdoSetCloseNothing.Checked = Modren_UI.mainOption.CloseNothingOpen.Value
        RdoSetMiniEnabled.Checked = Modren_UI.mainOption.CloseMiniOpen.Value
        RdoStop.Checked = Modren_UI.mainOption.AfterClose_stop.Value
        RdoNext.Checked = Modren_UI.mainOption.AfterClose_next.Value
        RdoPause.Checked = Modren_UI.mainOption.AfterClose_puase.Value
        '字幕
        PicLyricColor.BackColor = Modren_UI.mainOption.Lyric_SingleLine_ForeColor
        PicCnLyricColor.BackColor = Modren_UI.mainOption.Lyric_CN_ForeColor
        PicEnLyricColor.BackColor = Modren_UI.mainOption.Lyric_English_ForeColor
        LblShowLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_SingleLine_Font.FontFamily, 9)
        LblShowCnLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_CN_Font.FontFamily, 9)
        LblShowEnLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_English_Font.FontFamily, 9)
    End Sub
    Private Sub lbl_CheckUpdates_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_CheckUpdates.LinkClicked
        Process.Start("https://github.com/shadowfish07/ShadowPlayer/releases")
    End Sub

    Private Sub txtLoud_End_Time_txtChanged(sender As Object, e As EventArgs) Handles txtLoudTime.TextChanged, txtEndTime.TextChanged
        Select Case True
            Case sender Is txtLoudTime
                If txtLoudTime.Text = Modren_UI.mainOption.LoudTime Then
                    btn_saveLoudTime.Visible = False
                Else
                    btn_saveLoudTime.Visible = True
                End If
            Case sender Is txtEndTime
                If txtEndTime.Text = Modren_UI.mainOption.EndTime Then
                    btn_saveCloseTime.Visible = False
                Else
                    btn_saveCloseTime.Visible = True
                End If
        End Select
    End Sub





#Region "窗体拖动移动"

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function ReleaseCapture() As Boolean
    End Function

    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function


    Private Sub MoveForm()
        ReleaseCapture()
        SendMessage(Me.Handle, &HA1, 2, 0)
    End Sub

    Private Sub FormDrag(sender As Object, e As MouseEventArgs) Handles Panel_top.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then MoveForm()
    End Sub




#End Region
End Class
