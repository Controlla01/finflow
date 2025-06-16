<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffs_payroll_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffs_payroll_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.basic_salary_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.commission_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.passport = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tax_percent_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.total_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bonus_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.transport_allowance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 51)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(1008, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 50)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Button6)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.basic_salary_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.commission_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.tax_percent_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.total_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.bonus_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.transport_allowance_txt)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(21, 70)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1013, 642)
        Me.Guna2GroupBox2.TabIndex = 10
        Me.Guna2GroupBox2.Text = "EMPLOYEE'S PAYMENT DETAILS"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BorderColor = System.Drawing.Color.White
        Me.Guna2Button6.BorderRadius = 4
        Me.Guna2Button6.BorderThickness = 1
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Location = New System.Drawing.Point(851, 6)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(107, 38)
        Me.Guna2Button6.TabIndex = 27
        Me.Guna2Button6.Text = "BACK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "BASIC SALARY"
        '
        'basic_salary_txt
        '
        Me.basic_salary_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.basic_salary_txt.BorderRadius = 5
        Me.basic_salary_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.basic_salary_txt.DefaultText = ""
        Me.basic_salary_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.basic_salary_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.basic_salary_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.DisabledState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.Enabled = False
        Me.basic_salary_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.FocusedState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basic_salary_txt.ForeColor = System.Drawing.Color.Black
        Me.basic_salary_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.HoverState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Location = New System.Drawing.Point(50, 100)
        Me.basic_salary_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.basic_salary_txt.Name = "basic_salary_txt"
        Me.basic_salary_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.basic_salary_txt.PlaceholderText = ""
        Me.basic_salary_txt.SelectedText = ""
        Me.basic_salary_txt.ShadowDecoration.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Size = New System.Drawing.Size(646, 53)
        Me.basic_salary_txt.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(49, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "COMMISSION"
        '
        'commission_txt
        '
        Me.commission_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.commission_txt.BorderRadius = 5
        Me.commission_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.commission_txt.DefaultText = ""
        Me.commission_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.commission_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.commission_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.DisabledState.Parent = Me.commission_txt
        Me.commission_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.Enabled = False
        Me.commission_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.FocusedState.Parent = Me.commission_txt
        Me.commission_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commission_txt.ForeColor = System.Drawing.Color.Black
        Me.commission_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.HoverState.Parent = Me.commission_txt
        Me.commission_txt.Location = New System.Drawing.Point(51, 200)
        Me.commission_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.commission_txt.Name = "commission_txt"
        Me.commission_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.commission_txt.PlaceholderText = ""
        Me.commission_txt.SelectedText = ""
        Me.commission_txt.ShadowDecoration.Parent = Me.commission_txt
        Me.commission_txt.Size = New System.Drawing.Size(646, 58)
        Me.commission_txt.TabIndex = 23
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.passport)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(726, 100)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(263, 291)
        Me.Guna2GroupBox1.TabIndex = 22
        Me.Guna2GroupBox1.Text = "PICTURE"
        '
        'passport
        '
        Me.passport.Location = New System.Drawing.Point(17, 61)
        Me.passport.Margin = New System.Windows.Forms.Padding(4)
        Me.passport.Name = "passport"
        Me.passport.ShadowDecoration.Parent = Me.passport
        Me.passport.Size = New System.Drawing.Size(226, 209)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 0
        Me.passport.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 579)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TAX DEDUCTED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(420, 579)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TOTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 402)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "BONUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 287)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TRANSPORT ALLOWANCE"
        '
        'tax_percent_txt
        '
        Me.tax_percent_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tax_percent_txt.BorderRadius = 5
        Me.tax_percent_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tax_percent_txt.DefaultText = ""
        Me.tax_percent_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tax_percent_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tax_percent_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_percent_txt.DisabledState.Parent = Me.tax_percent_txt
        Me.tax_percent_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_percent_txt.Enabled = False
        Me.tax_percent_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_percent_txt.FocusedState.Parent = Me.tax_percent_txt
        Me.tax_percent_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_percent_txt.ForeColor = System.Drawing.Color.Black
        Me.tax_percent_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_percent_txt.HoverState.Parent = Me.tax_percent_txt
        Me.tax_percent_txt.Location = New System.Drawing.Point(178, 531)
        Me.tax_percent_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.tax_percent_txt.Name = "tax_percent_txt"
        Me.tax_percent_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tax_percent_txt.PlaceholderText = ""
        Me.tax_percent_txt.SelectedText = ""
        Me.tax_percent_txt.ShadowDecoration.Parent = Me.tax_percent_txt
        Me.tax_percent_txt.Size = New System.Drawing.Size(193, 71)
        Me.tax_percent_txt.TabIndex = 10
        '
        'total_txt
        '
        Me.total_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.total_txt.BorderRadius = 5
        Me.total_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.total_txt.DefaultText = ""
        Me.total_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.total_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.total_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.total_txt.DisabledState.Parent = Me.total_txt
        Me.total_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.total_txt.Enabled = False
        Me.total_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.FocusedState.Parent = Me.total_txt
        Me.total_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_txt.ForeColor = System.Drawing.Color.Black
        Me.total_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.total_txt.HoverState.Parent = Me.total_txt
        Me.total_txt.Location = New System.Drawing.Point(496, 531)
        Me.total_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.total_txt.Name = "total_txt"
        Me.total_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.total_txt.PlaceholderText = ""
        Me.total_txt.SelectedText = ""
        Me.total_txt.ShadowDecoration.Parent = Me.total_txt
        Me.total_txt.Size = New System.Drawing.Size(193, 71)
        Me.total_txt.TabIndex = 10
        '
        'bonus_txt
        '
        Me.bonus_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.bonus_txt.BorderRadius = 5
        Me.bonus_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bonus_txt.DefaultText = ""
        Me.bonus_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bonus_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bonus_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.DisabledState.Parent = Me.bonus_txt
        Me.bonus_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.Enabled = False
        Me.bonus_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.FocusedState.Parent = Me.bonus_txt
        Me.bonus_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bonus_txt.ForeColor = System.Drawing.Color.Black
        Me.bonus_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.HoverState.Parent = Me.bonus_txt
        Me.bonus_txt.Location = New System.Drawing.Point(51, 429)
        Me.bonus_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.bonus_txt.Name = "bonus_txt"
        Me.bonus_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bonus_txt.PlaceholderText = ""
        Me.bonus_txt.SelectedText = ""
        Me.bonus_txt.ShadowDecoration.Parent = Me.bonus_txt
        Me.bonus_txt.Size = New System.Drawing.Size(646, 56)
        Me.bonus_txt.TabIndex = 10
        '
        'transport_allowance_txt
        '
        Me.transport_allowance_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.transport_allowance_txt.BorderRadius = 5
        Me.transport_allowance_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transport_allowance_txt.DefaultText = ""
        Me.transport_allowance_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.transport_allowance_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.transport_allowance_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transport_allowance_txt.DisabledState.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.transport_allowance_txt.Enabled = False
        Me.transport_allowance_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transport_allowance_txt.FocusedState.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transport_allowance_txt.ForeColor = System.Drawing.Color.Black
        Me.transport_allowance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transport_allowance_txt.HoverState.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Location = New System.Drawing.Point(51, 314)
        Me.transport_allowance_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.transport_allowance_txt.Name = "transport_allowance_txt"
        Me.transport_allowance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transport_allowance_txt.PlaceholderText = ""
        Me.transport_allowance_txt.SelectedText = ""
        Me.transport_allowance_txt.ShadowDecoration.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Size = New System.Drawing.Size(646, 56)
        Me.transport_allowance_txt.TabIndex = 10
        '
        'staffs_payroll_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 738)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staffs_payroll_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffs_payroll_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents basic_salary_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents commission_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents passport As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tax_percent_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents total_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bonus_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents transport_allowance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
End Class
