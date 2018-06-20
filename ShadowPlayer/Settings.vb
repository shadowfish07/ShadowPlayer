Imports libVisualAction.Shadowfish.VisualAction

Public Class Settings
    Private Sub PageCommand_Click(sender As Object, e As EventArgs) Handles btn_time.Click, btn_Lyric.Click, btn_others.Click
        Select Case True
            Case sender Is btn_time
                TabControl1.SelectedTab = TabPage_time
            Case sender Is btn_Lyric
                TabControl1.SelectedTab = TabPage_lyric
            Case sender Is btn_others
                TabControl1.SelectedTab = TabPage_others
        End Select

        For Each b As Button In {btn_Lyric, btn_others, btn_time}
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
            PicLyricColor.Click, PicCnLyricColor.Click, PicEnLyricColor.Click,
            LblShowLyricFont.Click, LblShowCnLyricFont.Click, LblShowEnLyricFont.Click,
            chkAutoFullScreen.Click,
            Chk_PreventSleep_Alarm.Click, Chk_PreventSleep_AllTime.Click, Chk_PreventSleep_Playing.Click, Chk_PreventSleep_Open.Click, Chk_PreventSleep_Display.Click, Chk_PreventSleep_system.Click

        Dim cancel As Boolean = False

        Select Case True
            Case sender Is ChkLyricOpen
                PnlLryic.Enabled = ChkLyricOpen.Checked
                Modren_UI.mainOption.LyricScreen_Open.Value = ChkLyricOpen.Checked
            Case sender Is ChkSetCloseEnabled
                PnlStop.Enabled = ChkSetCloseEnabled.Checked
                Modren_UI.mainOption.Alarm_CloseOpen.Value = ChkSetCloseEnabled.Checked
            Case sender Is ChkSetTimeEnabled
                PnlOpen.Enabled = ChkSetTimeEnabled.Checked
                Modren_UI.mainOption.Alarm_LoudOpen.Value = ChkSetTimeEnabled.Checked
            Case sender Is btn_saveLoudTime
                Modren_UI.mainOption.Alarm_LoudTime = txtLoudTime.Text
                btn_saveLoudTime.Visible = False
            Case sender Is btn_saveCloseTime
                Modren_UI.mainOption.Alarm_EndTime = txtEndTime.Text
                btn_saveCloseTime.Visible = False
            Case sender Is RdoSetCloseNothing
                Modren_UI.mainOption.WhenClose_NothingOpen.Value = True
            Case sender Is RdoSetEndEnabled
                Modren_UI.mainOption.WhenClose_EndOpen.Value = True
            Case sender Is RdoSetMiniEnabled
                Modren_UI.mainOption.WhenClose_MiniOpen.Value = True
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
            Case sender Is LblShowLyricFont
                FontDialog1.Font = Modren_UI.mainOption.Lyric_SingleLine_Font
                If FontDialog1.ShowDialog = DialogResult.OK Then
                    LblShowLyricFont.Font = New Font(FontDialog1.Font.FontFamily, 9)
                    Modren_UI.mainOption.Lyric_SingleLine_Font = FontDialog1.Font
                Else
                    cancel = True
                End If
            Case sender Is LblShowCnLyricFont
                FontDialog1.Font = Modren_UI.mainOption.Lyric_CN_Font
                If FontDialog1.ShowDialog = DialogResult.OK Then
                    LblShowCnLyricFont.Font = New Font(FontDialog1.Font.FontFamily, 9)
                    Modren_UI.mainOption.Lyric_CN_Font = FontDialog1.Font
                Else
                    cancel = True
                End If
            Case sender Is LblShowEnLyricFont
                FontDialog1.Font = Modren_UI.mainOption.Lyric_English_Font
                If FontDialog1.ShowDialog = DialogResult.OK Then
                    LblShowEnLyricFont.Font = New Font(FontDialog1.Font.FontFamily, 9)
                    Modren_UI.mainOption.Lyric_English_Font = FontDialog1.Font
                Else
                    cancel = True
                End If
            Case sender Is chkAutoFullScreen
                Modren_UI.mainOption.Video_AutoFullScreen.Value = chkAutoFullScreen.Checked
            Case sender Is Chk_PreventSleep_Open
                Modren_UI.mainOption.PreventSleep_Open.Value = Chk_PreventSleep_Open.Checked
                pnl_sleep.Enabled = Chk_PreventSleep_Open.Checked
                If Not (Chk_PreventSleep_system.Checked Or Chk_PreventSleep_Display.Checked) Then
                    Chk_PreventSleep_system.Checked = True
                    Chk_PreventSleep_Display.Checked = True
                    Modren_UI.mainOption.PreventSleep_Display.Value = True
                    Modren_UI.mainOption.PreventSleep_System.Value = True
                End If
                If Not (Chk_PreventSleep_Alarm.Checked Or Chk_PreventSleep_Playing.Checked) And Chk_PreventSleep_AllTime.Checked = False Then
                    Chk_PreventSleep_AllTime.Checked = True
                    Modren_UI.mainOption.PreventSleep_Alltime.Value = True
                    Chk_PreventSleep_Alarm.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
                    Chk_PreventSleep_Playing.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
                End If
            Case sender Is Chk_PreventSleep_Alarm
                Modren_UI.mainOption.PreventSleep_Alarm.Value = Chk_PreventSleep_Alarm.Checked
                If Chk_PreventSleep_Alarm.Checked = False And Chk_PreventSleep_Playing.Checked = False Then
                    Chk_PreventSleep_Open.Checked = False
                    Modren_UI.mainOption.PreventSleep_Open.Value = False
                    pnl_sleep.Enabled = False
                End If
            Case sender Is Chk_PreventSleep_AllTime
                Chk_PreventSleep_Alarm.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
                Chk_PreventSleep_Playing.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
                Modren_UI.mainOption.PreventSleep_Alltime.Value = Chk_PreventSleep_AllTime.Checked
                If Not (Chk_PreventSleep_Alarm.Checked Or Chk_PreventSleep_Playing.Checked) Then
                    Chk_PreventSleep_Alarm.Checked = True
                    Chk_PreventSleep_Playing.Checked = True
                End If
                If Chk_PreventSleep_Alarm.Checked = False And Chk_PreventSleep_AllTime.Checked = False And Chk_PreventSleep_Playing.Checked = False Then
                    Chk_PreventSleep_Open.Checked = False
                    Modren_UI.mainOption.PreventSleep_Open.Value = False
                    pnl_sleep.Enabled = False
                End If
            Case sender Is Chk_PreventSleep_Playing
                Modren_UI.mainOption.PreventSleep_Playing.Value = Chk_PreventSleep_Playing.Checked
                If Chk_PreventSleep_Alarm.Checked = False And Chk_PreventSleep_Playing.Checked = False Then
                    Chk_PreventSleep_Open.Checked = False
                    Modren_UI.mainOption.PreventSleep_Open.Value = False
                    pnl_sleep.Enabled = False
                End If
            Case sender Is Chk_PreventSleep_Display
                If Not (Chk_PreventSleep_system.Checked Or Chk_PreventSleep_Display.Checked) Then Chk_PreventSleep_Open.Checked = False
                pnl_sleep.Enabled = Chk_PreventSleep_Open.Checked
                Modren_UI.mainOption.PreventSleep_Display.Value = Chk_PreventSleep_Display.Checked
            Case sender Is Chk_PreventSleep_system
                If Not (Chk_PreventSleep_system.Checked Or Chk_PreventSleep_Display.Checked) Then Chk_PreventSleep_Open.Checked = False
                pnl_sleep.Enabled = Chk_PreventSleep_Open.Checked
                Modren_UI.mainOption.PreventSleep_System.Value = Chk_PreventSleep_system.Checked
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
        ChkSetCloseEnabled.Checked = Modren_UI.mainOption.Alarm_CloseOpen.Value
        ChkSetTimeEnabled.Checked = Modren_UI.mainOption.Alarm_LoudOpen.Value
        txtEndTime.Text = Modren_UI.mainOption.Alarm_EndTime
        txtLoudTime.Text = Modren_UI.mainOption.Alarm_LoudTime
        RdoSetEndEnabled.Checked = Modren_UI.mainOption.WhenClose_EndOpen.Value
        RdoSetCloseNothing.Checked = Modren_UI.mainOption.WhenClose_NothingOpen.Value
        RdoSetMiniEnabled.Checked = Modren_UI.mainOption.WhenClose_MiniOpen.Value
        RdoStop.Checked = Modren_UI.mainOption.AfterClose_stop.Value
        RdoNext.Checked = Modren_UI.mainOption.AfterClose_next.Value
        RdoPause.Checked = Modren_UI.mainOption.AfterClose_puase.Value
        chkAutoFullScreen.Checked = Modren_UI.mainOption.Video_AutoFullScreen.Value
        '字幕
        PicLyricColor.BackColor = Modren_UI.mainOption.Lyric_SingleLine_ForeColor
        PicCnLyricColor.BackColor = Modren_UI.mainOption.Lyric_CN_ForeColor
        PicEnLyricColor.BackColor = Modren_UI.mainOption.Lyric_English_ForeColor
        LblShowLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_SingleLine_Font.FontFamily, 9)
        LblShowCnLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_CN_Font.FontFamily, 9)
        LblShowEnLyricFont.Font = New Font(Modren_UI.mainOption.Lyric_English_Font.FontFamily, 9)
        '杂项
        Chk_PreventSleep_Open.Checked = Modren_UI.mainOption.PreventSleep_Open.Value
        Chk_PreventSleep_Alarm.Checked = Modren_UI.mainOption.PreventSleep_Alarm.Value
        Chk_PreventSleep_AllTime.Checked = Modren_UI.mainOption.PreventSleep_Alltime.Value
        Chk_PreventSleep_Playing.Checked = Modren_UI.mainOption.PreventSleep_Playing.Value
        Chk_PreventSleep_Alarm.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
        Chk_PreventSleep_Playing.Enabled = Not (Chk_PreventSleep_AllTime.Checked)
        Chk_PreventSleep_system.Checked = Modren_UI.mainOption.PreventSleep_System.Value
        Chk_PreventSleep_Display.Checked = Modren_UI.mainOption.PreventSleep_Display.Value

        pnl_sleep.Enabled = Chk_PreventSleep_Open.Checked
    End Sub
    Private Sub lbl_CheckUpdates_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_CheckUpdates.LinkClicked
        Process.Start("https://github.com/shadowfish07/ShadowPlayer/releases")
    End Sub

    Private Sub txtLoud_End_Time_txtChanged(sender As Object, e As EventArgs) Handles txtLoudTime.TextChanged, txtEndTime.TextChanged
        Select Case True
            Case sender Is txtLoudTime
                If txtLoudTime.Text = Modren_UI.mainOption.Alarm_LoudTime Then
                    btn_saveLoudTime.Visible = False
                Else
                    btn_saveLoudTime.Visible = True
                End If
            Case sender Is txtEndTime
                If txtEndTime.Text = Modren_UI.mainOption.Alarm_EndTime Then
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

    Private Sub Options_Changed(sender As Object, e As MouseEventArgs)

    End Sub




#End Region
End Class
