<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class job_grade1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(job_grade1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.net_salary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tax_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.commission_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bonus_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.basic_salary_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.allowance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.job_grade_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbJobGrade = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 49)
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
        Me.close_btn.Location = New System.Drawing.Point(805, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.submit_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.net_salary)
        Me.Guna2GroupBox1.Controls.Add(Me.tax_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.commission_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.bonus_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.basic_salary_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.allowance_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.job_grade_name_txt)
        Me.Guna2GroupBox1.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbJobGrade)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(14, 63)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(830, 684)
        Me.Guna2GroupBox1.TabIndex = 10
        Me.Guna2GroupBox1.Text = "JOB GRADE "
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 5
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.submit_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(585, 608)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(192, 55)
        Me.submit_btn.TabIndex = 34
        Me.submit_btn.Text = "SUBMIT"
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(35, 608)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(192, 55)
        Me.clear_btn.TabIndex = 33
        Me.clear_btn.Text = "CLEAR"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.AutoSize = False
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(484, 493)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(291, 30)
        Me.Guna2HtmlLabel6.TabIndex = 32
        Me.Guna2HtmlLabel6.Text = "TOTAL PAYMENT"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.AutoSize = False
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(35, 493)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(236, 26)
        Me.Guna2HtmlLabel7.TabIndex = 31
        Me.Guna2HtmlLabel7.Text = "TAX PERCENTAGE %"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(485, 379)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(234, 30)
        Me.Guna2HtmlLabel3.TabIndex = 28
        Me.Guna2HtmlLabel3.Text = "COMMISSION"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(35, 378)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(163, 30)
        Me.Guna2HtmlLabel5.TabIndex = 27
        Me.Guna2HtmlLabel5.Text = "BONUS"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.AutoSize = False
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(484, 270)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(235, 27)
        Me.Guna2HtmlLabel4.TabIndex = 26
        Me.Guna2HtmlLabel4.Text = "ALLOWANCE"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(35, 270)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(192, 27)
        Me.Guna2HtmlLabel2.TabIndex = 5
        Me.Guna2HtmlLabel2.Text = "BASIC SALARY"
        '
        'net_salary
        '
        Me.net_salary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.net_salary.DefaultText = ""
        Me.net_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.net_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.net_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.net_salary.DisabledState.Parent = Me.net_salary
        Me.net_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.net_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.net_salary.FocusedState.Parent = Me.net_salary
        Me.net_salary.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.net_salary.ForeColor = System.Drawing.Color.Black
        Me.net_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.net_salary.HoverState.Parent = Me.net_salary
        Me.net_salary.Location = New System.Drawing.Point(484, 529)
        Me.net_salary.Margin = New System.Windows.Forms.Padding(29, 114, 29, 114)
        Me.net_salary.Name = "net_salary"
        Me.net_salary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.net_salary.PlaceholderText = ""
        Me.net_salary.SelectedText = ""
        Me.net_salary.ShadowDecoration.Parent = Me.net_salary
        Me.net_salary.Size = New System.Drawing.Size(304, 60)
        Me.net_salary.TabIndex = 4
        '
        'tax_txt
        '
        Me.tax_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tax_txt.DefaultText = ""
        Me.tax_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tax_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tax_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_txt.DisabledState.Parent = Me.tax_txt
        Me.tax_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tax_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_txt.FocusedState.Parent = Me.tax_txt
        Me.tax_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax_txt.ForeColor = System.Drawing.Color.Black
        Me.tax_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tax_txt.HoverState.Parent = Me.tax_txt
        Me.tax_txt.Location = New System.Drawing.Point(35, 529)
        Me.tax_txt.Margin = New System.Windows.Forms.Padding(21, 65, 21, 65)
        Me.tax_txt.Name = "tax_txt"
        Me.tax_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tax_txt.PlaceholderText = ""
        Me.tax_txt.SelectedText = ""
        Me.tax_txt.ShadowDecoration.Parent = Me.tax_txt
        Me.tax_txt.Size = New System.Drawing.Size(304, 60)
        Me.tax_txt.TabIndex = 4
        '
        'commission_txt
        '
        Me.commission_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.commission_txt.DefaultText = ""
        Me.commission_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.commission_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.commission_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.DisabledState.Parent = Me.commission_txt
        Me.commission_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.commission_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.FocusedState.Parent = Me.commission_txt
        Me.commission_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commission_txt.ForeColor = System.Drawing.Color.Black
        Me.commission_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.HoverState.Parent = Me.commission_txt
        Me.commission_txt.Location = New System.Drawing.Point(484, 409)
        Me.commission_txt.Margin = New System.Windows.Forms.Padding(15, 37, 15, 37)
        Me.commission_txt.Name = "commission_txt"
        Me.commission_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.commission_txt.PlaceholderText = ""
        Me.commission_txt.SelectedText = ""
        Me.commission_txt.ShadowDecoration.Parent = Me.commission_txt
        Me.commission_txt.Size = New System.Drawing.Size(304, 60)
        Me.commission_txt.TabIndex = 4
        '
        'bonus_txt
        '
        Me.bonus_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.bonus_txt.DefaultText = ""
        Me.bonus_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.bonus_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.bonus_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.DisabledState.Parent = Me.bonus_txt
        Me.bonus_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.bonus_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.FocusedState.Parent = Me.bonus_txt
        Me.bonus_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bonus_txt.ForeColor = System.Drawing.Color.Black
        Me.bonus_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.HoverState.Parent = Me.bonus_txt
        Me.bonus_txt.Location = New System.Drawing.Point(35, 409)
        Me.bonus_txt.Margin = New System.Windows.Forms.Padding(11, 21, 11, 21)
        Me.bonus_txt.Name = "bonus_txt"
        Me.bonus_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bonus_txt.PlaceholderText = ""
        Me.bonus_txt.SelectedText = ""
        Me.bonus_txt.ShadowDecoration.Parent = Me.bonus_txt
        Me.bonus_txt.Size = New System.Drawing.Size(304, 60)
        Me.bonus_txt.TabIndex = 4
        '
        'basic_salary_txt
        '
        Me.basic_salary_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.basic_salary_txt.DefaultText = ""
        Me.basic_salary_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.basic_salary_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.basic_salary_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.DisabledState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.basic_salary_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.FocusedState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basic_salary_txt.ForeColor = System.Drawing.Color.Black
        Me.basic_salary_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.basic_salary_txt.HoverState.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Location = New System.Drawing.Point(35, 301)
        Me.basic_salary_txt.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        Me.basic_salary_txt.Name = "basic_salary_txt"
        Me.basic_salary_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.basic_salary_txt.PlaceholderText = ""
        Me.basic_salary_txt.SelectedText = ""
        Me.basic_salary_txt.ShadowDecoration.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Size = New System.Drawing.Size(304, 60)
        Me.basic_salary_txt.TabIndex = 4
        '
        'allowance_txt
        '
        Me.allowance_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.allowance_txt.DefaultText = ""
        Me.allowance_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.allowance_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.allowance_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.allowance_txt.DisabledState.Parent = Me.allowance_txt
        Me.allowance_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.allowance_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.allowance_txt.FocusedState.Parent = Me.allowance_txt
        Me.allowance_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowance_txt.ForeColor = System.Drawing.Color.Black
        Me.allowance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.allowance_txt.HoverState.Parent = Me.allowance_txt
        Me.allowance_txt.Location = New System.Drawing.Point(484, 301)
        Me.allowance_txt.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.allowance_txt.Name = "allowance_txt"
        Me.allowance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.allowance_txt.PlaceholderText = ""
        Me.allowance_txt.SelectedText = ""
        Me.allowance_txt.ShadowDecoration.Parent = Me.allowance_txt
        Me.allowance_txt.Size = New System.Drawing.Size(304, 60)
        Me.allowance_txt.TabIndex = 4
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(35, 159)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(267, 30)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "JOB GRADE NAME"
        '
        'job_grade_name_txt
        '
        Me.job_grade_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.job_grade_name_txt.DefaultText = ""
        Me.job_grade_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.job_grade_name_txt.DisabledState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.job_grade_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.job_grade_name_txt.FocusedState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.job_grade_name_txt.ForeColor = System.Drawing.Color.Black
        Me.job_grade_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.job_grade_name_txt.HoverState.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Location = New System.Drawing.Point(35, 199)
        Me.job_grade_name_txt.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.job_grade_name_txt.Name = "job_grade_name_txt"
        Me.job_grade_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.job_grade_name_txt.PlaceholderText = ""
        Me.job_grade_name_txt.SelectedText = ""
        Me.job_grade_name_txt.ShadowDecoration.Parent = Me.job_grade_name_txt
        Me.job_grade_name_txt.Size = New System.Drawing.Size(753, 44)
        Me.job_grade_name_txt.TabIndex = 2
        '
        'fetch_btn
        '
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.fetch_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(597, 120)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(180, 45)
        Me.fetch_btn.TabIndex = 1
        Me.fetch_btn.Text = "FETCH"
        '
        'cmbJobGrade
        '
        Me.cmbJobGrade.BackColor = System.Drawing.Color.Transparent
        Me.cmbJobGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbJobGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJobGrade.FocusedColor = System.Drawing.Color.Empty
        Me.cmbJobGrade.FocusedState.Parent = Me.cmbJobGrade
        Me.cmbJobGrade.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJobGrade.ForeColor = System.Drawing.Color.Black
        Me.cmbJobGrade.FormattingEnabled = True
        Me.cmbJobGrade.HoverState.Parent = Me.cmbJobGrade
        Me.cmbJobGrade.ItemHeight = 30
        Me.cmbJobGrade.ItemsAppearance.Parent = Me.cmbJobGrade
        Me.cmbJobGrade.Location = New System.Drawing.Point(46, 63)
        Me.cmbJobGrade.Name = "cmbJobGrade"
        Me.cmbJobGrade.ShadowDecoration.Parent = Me.cmbJobGrade
        Me.cmbJobGrade.Size = New System.Drawing.Size(742, 36)
        Me.cmbJobGrade.TabIndex = 0
        '
        'job_grade1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 759)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "job_grade1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "job_grade1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cmbJobGrade As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents job_grade_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents commission_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bonus_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents basic_salary_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents allowance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents net_salary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tax_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
End Class
