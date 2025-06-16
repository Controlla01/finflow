<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home_page))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.min_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.admin_login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.user_login_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.home_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.min_btn)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 55)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'min_btn
        '
        Me.min_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.min_btn.BackColor = System.Drawing.Color.Silver
        Me.min_btn.FlatAppearance.BorderSize = 0
        Me.min_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.min_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.min_btn.Location = New System.Drawing.Point(1326, -1)
        Me.min_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.min_btn.Name = "min_btn"
        Me.min_btn.Size = New System.Drawing.Size(55, 55)
        Me.min_btn.TabIndex = 0
        Me.min_btn.Text = "-"
        Me.min_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(1381, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(55, 55)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'admin_login_btn
        '
        Me.admin_login_btn.BorderRadius = 2
        Me.admin_login_btn.BorderThickness = 2
        Me.admin_login_btn.CheckedState.Parent = Me.admin_login_btn
        Me.admin_login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_login_btn.CustomImages.Parent = Me.admin_login_btn
        Me.admin_login_btn.FillColor = System.Drawing.Color.White
        Me.admin_login_btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_login_btn.ForeColor = System.Drawing.Color.Black
        Me.admin_login_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.admin_login_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.admin_login_btn.HoverState.FillColor = System.Drawing.Color.White
        Me.admin_login_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.admin_login_btn.HoverState.Parent = Me.admin_login_btn
        Me.admin_login_btn.Location = New System.Drawing.Point(13, 94)
        Me.admin_login_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_login_btn.Name = "admin_login_btn"
        Me.admin_login_btn.ShadowDecoration.Parent = Me.admin_login_btn
        Me.admin_login_btn.Size = New System.Drawing.Size(227, 83)
        Me.admin_login_btn.TabIndex = 2
        Me.admin_login_btn.Text = "Login As Admin"
        '
        'user_login_btn
        '
        Me.user_login_btn.BorderRadius = 5
        Me.user_login_btn.BorderThickness = 2
        Me.user_login_btn.CheckedState.Parent = Me.user_login_btn
        Me.user_login_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_login_btn.CustomImages.Parent = Me.user_login_btn
        Me.user_login_btn.FillColor = System.Drawing.Color.White
        Me.user_login_btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_login_btn.ForeColor = System.Drawing.Color.Black
        Me.user_login_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.user_login_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.user_login_btn.HoverState.FillColor = System.Drawing.Color.White
        Me.user_login_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.user_login_btn.HoverState.Parent = Me.user_login_btn
        Me.user_login_btn.Location = New System.Drawing.Point(18, 94)
        Me.user_login_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.user_login_btn.Name = "user_login_btn"
        Me.user_login_btn.ShadowDecoration.Parent = Me.user_login_btn
        Me.user_login_btn.Size = New System.Drawing.Size(227, 75)
        Me.user_login_btn.TabIndex = 2
        Me.user_login_btn.Text = "Login As Staff"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(1, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1436, 79)
        Me.Panel2.TabIndex = 3
        '
        'home_btn
        '
        Me.home_btn.BorderRadius = 5
        Me.home_btn.BorderThickness = 2
        Me.home_btn.CheckedState.Parent = Me.home_btn
        Me.home_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home_btn.CustomImages.Parent = Me.home_btn
        Me.home_btn.FillColor = System.Drawing.Color.White
        Me.home_btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_btn.ForeColor = System.Drawing.Color.Black
        Me.home_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.home_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.home_btn.HoverState.FillColor = System.Drawing.Color.White
        Me.home_btn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.home_btn.HoverState.Parent = Me.home_btn
        Me.home_btn.Location = New System.Drawing.Point(257, 128)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.ShadowDecoration.Parent = Me.home_btn
        Me.home_btn.Size = New System.Drawing.Size(252, 64)
        Me.home_btn.TabIndex = 2
        Me.home_btn.Text = "HOME"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderRadius = 15
        Me.Guna2GradientPanel1.BorderThickness = 5
        Me.Guna2GradientPanel1.Controls.Add(Me.home_btn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2GradientPanel3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(616, 325)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(811, 465)
        Me.Guna2GradientPanel1.TabIndex = 4
        Me.Guna2GradientPanel1.UseTransparentBackground = True
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel4.BorderRadius = 15
        Me.Guna2GradientPanel4.BorderThickness = 2
        Me.Guna2GradientPanel4.Controls.Add(Me.PictureBox2)
        Me.Guna2GradientPanel4.Controls.Add(Me.admin_login_btn)
        Me.Guna2GradientPanel4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(36, 254)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.ShadowDecoration.Parent = Me.Guna2GradientPanel4
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(254, 185)
        Me.Guna2GradientPanel4.TabIndex = 6
        Me.Guna2GradientPanel4.UseTransparentBackground = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GetFoodStuff_PayRoll.My.Resources.Resources.about_me_icon_1
        Me.PictureBox2.Location = New System.Drawing.Point(62, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel3.BorderRadius = 15
        Me.Guna2GradientPanel3.BorderThickness = 2
        Me.Guna2GradientPanel3.Controls.Add(Me.PictureBox3)
        Me.Guna2GradientPanel3.Controls.Add(Me.user_login_btn)
        Me.Guna2GradientPanel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.White
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.White
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(508, 254)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.ShadowDecoration.Parent = Me.Guna2GradientPanel3
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(254, 185)
        Me.Guna2GradientPanel3.TabIndex = 5
        Me.Guna2GradientPanel3.UseTransparentBackground = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GetFoodStuff_PayRoll.My.Resources.Resources.about_me_icon_1
        Me.PictureBox3.Location = New System.Drawing.Point(78, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe Print", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(275, 61)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(593, 68)
        Me.Guna2HtmlLabel2.TabIndex = 9
        Me.Guna2HtmlLabel2.Text = "LOGIN HERE"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe Print", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(120, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(783, 68)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "WELCOME TO GETFOODSTUFFS"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 42)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1437, 650)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'home_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1439, 683)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "home_page"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents min_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents admin_login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents user_login_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents home_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
