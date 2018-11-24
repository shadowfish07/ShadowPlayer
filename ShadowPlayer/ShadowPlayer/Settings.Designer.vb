<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Mainexit = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.btn_licenses = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Mainexit
        '
        Me.btn_Mainexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mainexit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Mainexit.FlatAppearance.BorderSize = 0
        Me.btn_Mainexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_Mainexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Mainexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Mainexit.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mainexit.ForeColor = System.Drawing.Color.White
        Me.btn_Mainexit.Location = New System.Drawing.Point(503, 0)
        Me.btn_Mainexit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_Mainexit.Name = "btn_Mainexit"
        Me.btn_Mainexit.Size = New System.Drawing.Size(45, 28)
        Me.btn_Mainexit.TabIndex = 17
        Me.btn_Mainexit.TabStop = False
        Me.btn_Mainexit.Text = "✕"
        Me.btn_Mainexit.UseVisualStyleBackColor = False
        '
        'Lbl_title
        '
        Me.Lbl_title.AutoSize = True
        Me.Lbl_title.Font = New System.Drawing.Font("微软雅黑", 13.75!)
        Me.Lbl_title.ForeColor = System.Drawing.Color.White
        Me.Lbl_title.Location = New System.Drawing.Point(12, 24)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(107, 25)
        Me.Lbl_title.TabIndex = 22
        Me.Lbl_title.Text = "影子播放器"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(88, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 365)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(373, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_options
        '
        Me.btn_options.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_options.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_options.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_options.FlatAppearance.BorderSize = 0
        Me.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_options.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_options.ForeColor = System.Drawing.Color.White
        Me.btn_options.Location = New System.Drawing.Point(-1, 78)
        Me.btn_options.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_options.Size = New System.Drawing.Size(145, 36)
        Me.btn_options.TabIndex = 25
        Me.btn_options.Text = "Options"
        Me.btn_options.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_options.UseVisualStyleBackColor = False
        '
        'btn_licenses
        '
        Me.btn_licenses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_licenses.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btn_licenses.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_licenses.FlatAppearance.BorderSize = 0
        Me.btn_licenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_licenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btn_licenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_licenses.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_licenses.ForeColor = System.Drawing.Color.White
        Me.btn_licenses.Location = New System.Drawing.Point(-1, 110)
        Me.btn_licenses.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
        Me.btn_licenses.Name = "btn_licenses"
        Me.btn_licenses.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_licenses.Size = New System.Drawing.Size(145, 36)
        Me.btn_licenses.TabIndex = 26
        Me.btn_licenses.Text = "External Licenses"
        Me.btn_licenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_licenses.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(548, 418)
        Me.Controls.Add(Me.btn_licenses)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Lbl_title)
        Me.Controls.Add(Me.btn_Mainexit)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Mainexit As Button
    Friend WithEvents Lbl_title As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_options As Button
    Friend WithEvents btn_licenses As Button
End Class
