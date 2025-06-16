<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_staff_payment_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_staff_payment_form))
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.passport = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.save_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.submit_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.profile_id_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tax_percent_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.total_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.commission_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bonus_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.transport_allowance_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.basic_salary_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.ComboBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2GroupBox2.Controls.Add(Me.save_btn)
        Me.Guna2GroupBox2.Controls.Add(Me.submit_btn)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.Controls.Add(Me.profile_id_combo)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.tax_percent_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.total_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.commission_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.bonus_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.transport_allowance_txt)
        Me.Guna2GroupBox2.Controls.Add(Me.basic_salary_txt)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(27, 68)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1005, 753)
        Me.Guna2GroupBox2.TabIndex = 8
        Me.Guna2GroupBox2.Text = "EMPLOYEE'S PAYMENT DETAILS"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(52, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(643, 36)
        Me.ComboBox1.TabIndex = 24
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.Maroon
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(460, 683)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(237, 55)
        Me.clear_btn.TabIndex = 23
        Me.clear_btn.Text = "CLEAR"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.passport)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(715, 74)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(271, 317)
        Me.Guna2GroupBox1.TabIndex = 22
        Me.Guna2GroupBox1.Text = "PICTURE"
        '
        'passport
        '
        Me.passport.Location = New System.Drawing.Point(22, 61)
        Me.passport.Margin = New System.Windows.Forms.Padding(4)
        Me.passport.Name = "passport"
        Me.passport.ShadowDecoration.Parent = Me.passport
        Me.passport.Size = New System.Drawing.Size(227, 237)
        Me.passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passport.TabIndex = 0
        Me.passport.TabStop = False
        '
        'save_btn
        '
        Me.save_btn.BorderRadius = 5
        Me.save_btn.CheckedState.Parent = Me.save_btn
        Me.save_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_btn.CustomImages.Parent = Me.save_btn
        Me.save_btn.FillColor = System.Drawing.Color.Green
        Me.save_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.White
        Me.save_btn.HoverState.Parent = Me.save_btn
        Me.save_btn.Location = New System.Drawing.Point(51, 683)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.ShadowDecoration.Parent = Me.save_btn
        Me.save_btn.Size = New System.Drawing.Size(240, 55)
        Me.save_btn.TabIndex = 21
        Me.save_btn.Text = "SAVE"
        '
        'submit_btn
        '
        Me.submit_btn.BorderRadius = 5
        Me.submit_btn.CheckedState.Parent = Me.submit_btn
        Me.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_btn.CustomImages.Parent = Me.submit_btn
        Me.submit_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.submit_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.HoverState.Parent = Me.submit_btn
        Me.submit_btn.Location = New System.Drawing.Point(477, 94)
        Me.submit_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.ShadowDecoration.Parent = Me.submit_btn
        Me.submit_btn.Size = New System.Drawing.Size(220, 36)
        Me.submit_btn.TabIndex = 20
        Me.submit_btn.Text = "FETCH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(47, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "PROFILE_ID"
        '
        'profile_id_combo
        '
        Me.profile_id_combo.BackColor = System.Drawing.Color.Transparent
        Me.profile_id_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profile_id_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profile_id_combo.FocusedColor = System.Drawing.Color.Empty
        Me.profile_id_combo.FocusedState.Parent = Me.profile_id_combo
        Me.profile_id_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.profile_id_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.profile_id_combo.FormattingEnabled = True
        Me.profile_id_combo.HoverState.Parent = Me.profile_id_combo
        Me.profile_id_combo.ItemHeight = 30
        Me.profile_id_combo.ItemsAppearance.Parent = Me.profile_id_combo
        Me.profile_id_combo.Location = New System.Drawing.Point(50, 94)
        Me.profile_id_combo.Margin = New System.Windows.Forms.Padding(4)
        Me.profile_id_combo.Name = "profile_id_combo"
        Me.profile_id_combo.ShadowDecoration.Parent = Me.profile_id_combo
        Me.profile_id_combo.Size = New System.Drawing.Size(373, 36)
        Me.profile_id_combo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(47, 634)
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
        Me.Label5.Location = New System.Drawing.Point(426, 634)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 470)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "COMMISSION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(47, 350)
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
        Me.Label2.Location = New System.Drawing.Point(458, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ALLOWANCE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(50, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "JOB GRADE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "BASIC SALARY"
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
        Me.tax_percent_txt.Location = New System.Drawing.Point(184, 586)
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
        Me.total_txt.Location = New System.Drawing.Point(502, 586)
        Me.total_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.total_txt.Name = "total_txt"
        Me.total_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.total_txt.PlaceholderText = ""
        Me.total_txt.SelectedText = ""
        Me.total_txt.ShadowDecoration.Parent = Me.total_txt
        Me.total_txt.Size = New System.Drawing.Size(193, 71)
        Me.total_txt.TabIndex = 10
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
        Me.commission_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.FocusedState.Parent = Me.commission_txt
        Me.commission_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commission_txt.ForeColor = System.Drawing.Color.Black
        Me.commission_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.commission_txt.HoverState.Parent = Me.commission_txt
        Me.commission_txt.Location = New System.Drawing.Point(50, 498)
        Me.commission_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.commission_txt.Name = "commission_txt"
        Me.commission_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.commission_txt.PlaceholderText = ""
        Me.commission_txt.SelectedText = ""
        Me.commission_txt.ShadowDecoration.Parent = Me.commission_txt
        Me.commission_txt.Size = New System.Drawing.Size(646, 58)
        Me.commission_txt.TabIndex = 10
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
        Me.bonus_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.FocusedState.Parent = Me.bonus_txt
        Me.bonus_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bonus_txt.ForeColor = System.Drawing.Color.Black
        Me.bonus_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bonus_txt.HoverState.Parent = Me.bonus_txt
        Me.bonus_txt.Location = New System.Drawing.Point(51, 377)
        Me.bonus_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.bonus_txt.Name = "bonus_txt"
        Me.bonus_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bonus_txt.PlaceholderText = ""
        Me.bonus_txt.SelectedText = ""
        Me.bonus_txt.ShadowDecoration.Parent = Me.bonus_txt
        Me.bonus_txt.Size = New System.Drawing.Size(240, 56)
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
        Me.transport_allowance_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transport_allowance_txt.FocusedState.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transport_allowance_txt.ForeColor = System.Drawing.Color.Black
        Me.transport_allowance_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transport_allowance_txt.HoverState.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Location = New System.Drawing.Point(460, 377)
        Me.transport_allowance_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.transport_allowance_txt.Name = "transport_allowance_txt"
        Me.transport_allowance_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.transport_allowance_txt.PlaceholderText = ""
        Me.transport_allowance_txt.SelectedText = ""
        Me.transport_allowance_txt.ShadowDecoration.Parent = Me.transport_allowance_txt
        Me.transport_allowance_txt.Size = New System.Drawing.Size(237, 56)
        Me.transport_allowance_txt.TabIndex = 10
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
        Me.basic_salary_txt.Location = New System.Drawing.Point(51, 264)
        Me.basic_salary_txt.Margin = New System.Windows.Forms.Padding(15)
        Me.basic_salary_txt.Name = "basic_salary_txt"
        Me.basic_salary_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.basic_salary_txt.PlaceholderText = ""
        Me.basic_salary_txt.SelectedText = ""
        Me.basic_salary_txt.ShadowDecoration.Parent = Me.basic_salary_txt
        Me.basic_salary_txt.Size = New System.Drawing.Size(646, 53)
        Me.basic_salary_txt.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 49)
        Me.Panel1.TabIndex = 9
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
        'close_btn
        '
        Me.close_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.BackColor = System.Drawing.Color.Red
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(1013, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'view_staff_payment_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 834)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_staff_payment_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_staff_payment_form"
        Me.TopMost = True
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents basic_salary_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents total_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents commission_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bonus_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents transport_allowance_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents profile_id_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents passport As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents save_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents submit_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tax_percent_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
