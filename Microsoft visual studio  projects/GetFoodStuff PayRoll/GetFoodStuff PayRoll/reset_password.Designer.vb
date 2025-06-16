<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reset_password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reset_password))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.next_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.Panel1.Size = New System.Drawing.Size(617, 49)
        Me.Panel1.TabIndex = 8
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
        Me.close_btn.Location = New System.Drawing.Point(565, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
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
        Me.email_address_txt.Location = New System.Drawing.Point(29, 158)
        Me.email_address_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.email_address_txt.Name = "email_address_txt"
        Me.email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email_address_txt.PlaceholderText = "ENTER YOUR EMAIL HERE"
        Me.email_address_txt.SelectedText = ""
        Me.email_address_txt.ShadowDecoration.Parent = Me.email_address_txt
        Me.email_address_txt.Size = New System.Drawing.Size(553, 69)
        Me.email_address_txt.TabIndex = 9
        '
        'back_btn
        '
        Me.back_btn.BorderRadius = 5
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.back_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.back_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(29, 281)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(213, 55)
        Me.back_btn.TabIndex = 10
        Me.back_btn.Text = "BACK"
        '
        'next_btn
        '
        Me.next_btn.BorderRadius = 5
        Me.next_btn.CheckedState.Parent = Me.next_btn
        Me.next_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.next_btn.CustomImages.Parent = Me.next_btn
        Me.next_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.next_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.ForeColor = System.Drawing.Color.White
        Me.next_btn.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.next_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.next_btn.HoverState.Parent = Me.next_btn
        Me.next_btn.Location = New System.Drawing.Point(369, 281)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.ShadowDecoration.Parent = Me.next_btn
        Me.next_btn.Size = New System.Drawing.Size(213, 55)
        Me.next_btn.TabIndex = 10
        Me.next_btn.Text = "NEXT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(166, 70)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'reset_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 418)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.email_address_txt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "reset_password"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reset_password"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents next_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
