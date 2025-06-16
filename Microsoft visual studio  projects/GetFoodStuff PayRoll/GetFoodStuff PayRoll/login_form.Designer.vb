<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.password_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lock_lbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.BorderRadius = 5
        Me.login_btn.CheckedState.Parent = Me.login_btn
        Me.login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login_btn.CustomImages.Parent = Me.login_btn
        Me.login_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.login_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.login_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.login_btn.HoverState.Parent = Me.login_btn
        Me.login_btn.Location = New System.Drawing.Point(360, 362)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.ShadowDecoration.Parent = Me.login_btn
        Me.login_btn.Size = New System.Drawing.Size(213, 55)
        Me.login_btn.TabIndex = 6
        Me.login_btn.Text = "LOGIN"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(16, 396)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(303, 23)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forget Password? Reset password here"
        '
        'password_txt
        '
        Me.password_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.password_txt.BorderRadius = 5
        Me.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_txt.DefaultText = ""
        Me.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.DisabledState.Parent = Me.password_txt
        Me.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.FocusedState.Parent = Me.password_txt
        Me.password_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.Black
        Me.password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password_txt.HoverState.Parent = Me.password_txt
        Me.password_txt.Location = New System.Drawing.Point(20, 257)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.PlaceholderText = "ENTER YOUR PASSWORD HERE"
        Me.password_txt.SelectedText = ""
        Me.password_txt.ShadowDecoration.Parent = Me.password_txt
        Me.password_txt.Size = New System.Drawing.Size(553, 71)
        Me.password_txt.TabIndex = 3
        '
        'email_address_txt
        '
        Me.email_address_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.email_address_txt.BorderRadius = 5
        Me.email_address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address_txt.DefaultText = ""
        Me.email_address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.email_address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.email_address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.DisabledState.Parent = Me.email_address_txt
        Me.email_address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.email_address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.FocusedState.Parent = Me.email_address_txt
        Me.email_address_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address_txt.ForeColor = System.Drawing.Color.Black
        Me.email_address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.email_address_txt.HoverState.Parent = Me.email_address_txt
        Me.email_address_txt.Location = New System.Drawing.Point(20, 153)
        Me.email_address_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_address_txt.PlaceholderText = "ENTER YOUR EMAIL HERE"
        Me.email_address_txt.SelectedText = ""
        Me.email_address_txt.ShadowDecoration.Parent = Me.email_address_txt
        Me.email_address_txt.Size = New System.Drawing.Size(553, 69)
        Me.email_address_txt.TabIndex = 4
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
        Me.Panel1.Size = New System.Drawing.Size(606, 49)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN LOGIN FORM"
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(555, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(145, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'lock_lbl
        '
        Me.lock_lbl.AutoSize = False
        Me.lock_lbl.BackColor = System.Drawing.Color.Transparent
        Me.lock_lbl.Location = New System.Drawing.Point(485, 289)
        Me.lock_lbl.Name = "lock_lbl"
        Me.lock_lbl.Size = New System.Drawing.Size(42, 18)
        Me.lock_lbl.TabIndex = 9
        Me.lock_lbl.Text = "Hide"
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 479)
        Me.Controls.Add(Me.lock_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.email_address_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "login_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login_form"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents password_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lock_lbl As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
