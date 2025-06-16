<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reset_finish
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reset_finish))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.otp_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.new_password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.confirm_password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.full_name_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 49)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RESET PASSWORD"
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(595, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(21, 214)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(368, 25)
        Me.Guna2HtmlLabel1.TabIndex = 22
        Me.Guna2HtmlLabel1.Text = "OTP"
        '
        'otp_txt
        '
        Me.otp_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.otp_txt.BorderRadius = 5
        Me.otp_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otp_txt.DefaultText = ""
        Me.otp_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.otp_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.otp_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.DisabledState.Parent = Me.otp_txt
        Me.otp_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otp_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.FocusedState.Parent = Me.otp_txt
        Me.otp_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.otp_txt.ForeColor = System.Drawing.Color.Black
        Me.otp_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otp_txt.HoverState.Parent = Me.otp_txt
        Me.otp_txt.Location = New System.Drawing.Point(21, 242)
        Me.otp_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.otp_txt.Name = "otp_txt"
        Me.otp_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.otp_txt.PlaceholderText = "ENTER OTP"
        Me.otp_txt.SelectedText = ""
        Me.otp_txt.ShadowDecoration.Parent = Me.otp_txt
        Me.otp_txt.Size = New System.Drawing.Size(553, 69)
        Me.otp_txt.TabIndex = 23
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(21, 346)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(368, 25)
        Me.Guna2HtmlLabel2.TabIndex = 22
        Me.Guna2HtmlLabel2.Text = "ENTER NEW PASSWORD"
        '
        'new_password_txt
        '
        Me.new_password_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.new_password_txt.BorderRadius = 5
        Me.new_password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.new_password_txt.DefaultText = ""
        Me.new_password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.new_password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.new_password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_password_txt.DisabledState.Parent = Me.new_password_txt
        Me.new_password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.new_password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_password_txt.FocusedState.Parent = Me.new_password_txt
        Me.new_password_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_password_txt.ForeColor = System.Drawing.Color.Black
        Me.new_password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.new_password_txt.HoverState.Parent = Me.new_password_txt
        Me.new_password_txt.Location = New System.Drawing.Point(21, 374)
        Me.new_password_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.new_password_txt.Name = "new_password_txt"
        Me.new_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.new_password_txt.PlaceholderText = "ENTER NEW PASSWORD"
        Me.new_password_txt.SelectedText = ""
        Me.new_password_txt.ShadowDecoration.Parent = Me.new_password_txt
        Me.new_password_txt.Size = New System.Drawing.Size(553, 69)
        Me.new_password_txt.TabIndex = 23
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(21, 482)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(368, 25)
        Me.Guna2HtmlLabel3.TabIndex = 22
        Me.Guna2HtmlLabel3.Text = "CONFIRM NEW PASSWORD"
        '
        'confirm_password_txt
        '
        Me.confirm_password_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.confirm_password_txt.BorderRadius = 5
        Me.confirm_password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirm_password_txt.DefaultText = ""
        Me.confirm_password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirm_password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirm_password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirm_password_txt.DisabledState.Parent = Me.confirm_password_txt
        Me.confirm_password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirm_password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirm_password_txt.FocusedState.Parent = Me.confirm_password_txt
        Me.confirm_password_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_password_txt.ForeColor = System.Drawing.Color.Black
        Me.confirm_password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirm_password_txt.HoverState.Parent = Me.confirm_password_txt
        Me.confirm_password_txt.Location = New System.Drawing.Point(21, 510)
        Me.confirm_password_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.confirm_password_txt.Name = "confirm_password_txt"
        Me.confirm_password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirm_password_txt.PlaceholderText = "CONFIRM PASSWORD"
        Me.confirm_password_txt.SelectedText = ""
        Me.confirm_password_txt.ShadowDecoration.Parent = Me.confirm_password_txt
        Me.confirm_password_txt.Size = New System.Drawing.Size(553, 69)
        Me.confirm_password_txt.TabIndex = 23
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 5
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.submit_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.submit_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(21, 623)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(213, 55)
        Me.submit_btn.TabIndex = 24
        Me.submit_btn.Text = "SUBMIT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(153, 62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'full_name_txt
        '
        Me.full_name_txt.BackColor = System.Drawing.Color.Transparent
        Me.full_name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_name_txt.Location = New System.Drawing.Point(72, 136)
        Me.full_name_txt.Name = "full_name_txt"
        Me.full_name_txt.Size = New System.Drawing.Size(152, 24)
        Me.full_name_txt.TabIndex = 26
        Me.full_name_txt.Text = "Guna2HtmlLabel4,"
        '
        'email_address_txt
        '
        Me.email_address_txt.BackColor = System.Drawing.Color.Transparent
        Me.email_address_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address_txt.Location = New System.Drawing.Point(21, 166)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.Size = New System.Drawing.Size(152, 24)
        Me.email_address_txt.TabIndex = 27
        Me.email_address_txt.Text = "Guna2HtmlLabel5."
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(21, 136)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(52, 24)
        Me.Guna2HtmlLabel4.TabIndex = 28
        Me.Guna2HtmlLabel4.Text = "Dear "
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(227, 136)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(404, 24)
        Me.Guna2HtmlLabel5.TabIndex = 29
        Me.Guna2HtmlLabel5.Text = "an OTP has been sent to your email address,"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(179, 166)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(419, 24)
        Me.Guna2HtmlLabel6.TabIndex = 30
        Me.Guna2HtmlLabel6.Text = " Kindly check your inbox or spam folder."
        '
        'reset_finish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 694)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.email_address_txt)
        Me.Controls.Add(Me.full_name_txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.confirm_password_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.new_password_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.otp_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "reset_finish"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reset_finish"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents otp_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents new_password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents confirm_password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents full_name_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
