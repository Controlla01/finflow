<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.add_staff_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.add_branch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.add_department_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.last_login_lbl = New System.Windows.Forms.Label()
        Me.admin_passport = New System.Windows.Forms.PictureBox()
        Me.role_id_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.staff_fullname_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.total_employee_lbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.branch_count_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblTotalPayment = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAdminGreeting = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDateTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.logout_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_staff_payment_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.salary_updates_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.view_payrollbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GradientPanel4.SuspendLayout()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(288, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 61)
        Me.Panel1.TabIndex = 5
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
        Me.close_btn.Location = New System.Drawing.Point(839, 1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 56)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'add_staff_btn
        '
        Me.add_staff_btn.BorderRadius = 5
        Me.add_staff_btn.CheckedState.Parent = Me.add_staff_btn
        Me.add_staff_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_staff_btn.CustomImages.Parent = Me.add_staff_btn
        Me.add_staff_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_staff_btn.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_staff_btn.ForeColor = System.Drawing.Color.White
        Me.add_staff_btn.HoverState.Parent = Me.add_staff_btn
        Me.add_staff_btn.Location = New System.Drawing.Point(13, 193)
        Me.add_staff_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.add_staff_btn.Name = "add_staff_btn"
        Me.add_staff_btn.ShadowDecoration.Parent = Me.add_staff_btn
        Me.add_staff_btn.Size = New System.Drawing.Size(233, 65)
        Me.add_staff_btn.TabIndex = 6
        Me.add_staff_btn.Text = "ADD STAFF"
        '
        'add_branch_btn
        '
        Me.add_branch_btn.BorderRadius = 5
        Me.add_branch_btn.CheckedState.Parent = Me.add_branch_btn
        Me.add_branch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_branch_btn.CustomImages.Parent = Me.add_branch_btn
        Me.add_branch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_branch_btn.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_branch_btn.ForeColor = System.Drawing.Color.White
        Me.add_branch_btn.HoverState.Parent = Me.add_branch_btn
        Me.add_branch_btn.Location = New System.Drawing.Point(13, 13)
        Me.add_branch_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.add_branch_btn.Name = "add_branch_btn"
        Me.add_branch_btn.ShadowDecoration.Parent = Me.add_branch_btn
        Me.add_branch_btn.Size = New System.Drawing.Size(233, 63)
        Me.add_branch_btn.TabIndex = 6
        Me.add_branch_btn.Text = "ADD BRANCH"
        '
        'add_department_btn
        '
        Me.add_department_btn.BorderRadius = 5
        Me.add_department_btn.CheckedState.Parent = Me.add_department_btn
        Me.add_department_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_department_btn.CustomImages.Parent = Me.add_department_btn
        Me.add_department_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.add_department_btn.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_department_btn.ForeColor = System.Drawing.Color.White
        Me.add_department_btn.HoverState.Parent = Me.add_department_btn
        Me.add_department_btn.Location = New System.Drawing.Point(13, 95)
        Me.add_department_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.add_department_btn.Name = "add_department_btn"
        Me.add_department_btn.ShadowDecoration.Parent = Me.add_department_btn
        Me.add_department_btn.Size = New System.Drawing.Size(233, 74)
        Me.add_department_btn.TabIndex = 6
        Me.add_department_btn.Text = "ADD DEPARTMENT"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GradientPanel4)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GradientPanel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GradientPanel2)
        Me.Guna2GroupBox2.Controls.Add(Me.lblAdminGreeting)
        Me.Guna2GroupBox2.Controls.Add(Me.lblDateTime)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(288, 72)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(882, 653)
        Me.Guna2GroupBox2.TabIndex = 7
        Me.Guna2GroupBox2.Text = "ALL EMPLOYEE'S DETAILS"
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.BorderRadius = 15
        Me.Guna2GradientPanel4.BorderThickness = 5
        Me.Guna2GradientPanel4.Controls.Add(Me.last_login_lbl)
        Me.Guna2GradientPanel4.Controls.Add(Me.admin_passport)
        Me.Guna2GradientPanel4.Controls.Add(Me.role_id_lbl)
        Me.Guna2GradientPanel4.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel4.Controls.Add(Me.staff_fullname_lbl)
        Me.Guna2GradientPanel4.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.ForestGreen
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(20, 166)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.ShadowDecoration.Parent = Me.Guna2GradientPanel4
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(843, 232)
        Me.Guna2GradientPanel4.TabIndex = 8
        Me.Guna2GradientPanel4.UseTransparentBackground = True
        '
        'last_login_lbl
        '
        Me.last_login_lbl.AutoSize = True
        Me.last_login_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_lbl.ForeColor = System.Drawing.Color.White
        Me.last_login_lbl.Location = New System.Drawing.Point(37, 136)
        Me.last_login_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.last_login_lbl.Name = "last_login_lbl"
        Me.last_login_lbl.Size = New System.Drawing.Size(23, 28)
        Me.last_login_lbl.TabIndex = 0
        Me.last_login_lbl.Text = "0"
        '
        'admin_passport
        '
        Me.admin_passport.BackgroundImage = CType(resources.GetObject("admin_passport.BackgroundImage"), System.Drawing.Image)
        Me.admin_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admin_passport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.admin_passport.Enabled = False
        Me.admin_passport.Location = New System.Drawing.Point(674, 36)
        Me.admin_passport.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_passport.Name = "admin_passport"
        Me.admin_passport.Size = New System.Drawing.Size(139, 139)
        Me.admin_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_passport.TabIndex = 1
        Me.admin_passport.TabStop = False
        '
        'role_id_lbl
        '
        Me.role_id_lbl.AutoSize = True
        Me.role_id_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role_id_lbl.ForeColor = System.Drawing.Color.White
        Me.role_id_lbl.Location = New System.Drawing.Point(98, 76)
        Me.role_id_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.role_id_lbl.Name = "role_id_lbl"
        Me.role_id_lbl.Size = New System.Drawing.Size(23, 28)
        Me.role_id_lbl.TabIndex = 0
        Me.role_id_lbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN FULL NAME :"
        '
        'staff_fullname_lbl
        '
        Me.staff_fullname_lbl.AutoSize = True
        Me.staff_fullname_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_fullname_lbl.ForeColor = System.Drawing.Color.White
        Me.staff_fullname_lbl.Location = New System.Drawing.Point(213, 19)
        Me.staff_fullname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.staff_fullname_lbl.Name = "staff_fullname_lbl"
        Me.staff_fullname_lbl.Size = New System.Drawing.Size(23, 28)
        Me.staff_fullname_lbl.TabIndex = 0
        Me.staff_fullname_lbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ROLE :"
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel3.BorderRadius = 15
        Me.Guna2GradientPanel3.BorderThickness = 5
        Me.Guna2GradientPanel3.Controls.Add(Me.total_employee_lbl)
        Me.Guna2GradientPanel3.Controls.Add(Me.Label8)
        Me.Guna2GradientPanel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.ForestGreen
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(20, 447)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.ShadowDecoration.Parent = Me.Guna2GradientPanel3
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(254, 184)
        Me.Guna2GradientPanel3.TabIndex = 9
        Me.Guna2GradientPanel3.UseTransparentBackground = True
        '
        'total_employee_lbl
        '
        Me.total_employee_lbl.AutoSize = True
        Me.total_employee_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_employee_lbl.ForeColor = System.Drawing.Color.White
        Me.total_employee_lbl.Location = New System.Drawing.Point(115, 106)
        Me.total_employee_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.total_employee_lbl.Name = "total_employee_lbl"
        Me.total_employee_lbl.Size = New System.Drawing.Size(23, 28)
        Me.total_employee_lbl.TabIndex = 2
        Me.total_employee_lbl.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(10, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(234, 35)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "TOTAL EMPLOYEES :"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderRadius = 15
        Me.Guna2GradientPanel1.BorderThickness = 5
        Me.Guna2GradientPanel1.Controls.Add(Me.branch_count_lbl)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.ForestGreen
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(609, 447)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(254, 184)
        Me.Guna2GradientPanel1.TabIndex = 8
        Me.Guna2GradientPanel1.UseTransparentBackground = True
        '
        'branch_count_lbl
        '
        Me.branch_count_lbl.AutoSize = True
        Me.branch_count_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_count_lbl.ForeColor = System.Drawing.Color.White
        Me.branch_count_lbl.Location = New System.Drawing.Point(120, 106)
        Me.branch_count_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.branch_count_lbl.Name = "branch_count_lbl"
        Me.branch_count_lbl.Size = New System.Drawing.Size(23, 28)
        Me.branch_count_lbl.TabIndex = 2
        Me.branch_count_lbl.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TOTAL BRANCH :"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.BorderRadius = 15
        Me.Guna2GradientPanel2.BorderThickness = 5
        Me.Guna2GradientPanel2.Controls.Add(Me.lblTotalPayment)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.ForestGreen
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(317, 447)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(254, 184)
        Me.Guna2GradientPanel2.TabIndex = 7
        Me.Guna2GradientPanel2.UseTransparentBackground = True
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = True
        Me.lblTotalPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.ForeColor = System.Drawing.Color.White
        Me.lblTotalPayment.Location = New System.Drawing.Point(57, 106)
        Me.lblTotalPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(23, 28)
        Me.lblTotalPayment.TabIndex = 4
        Me.lblTotalPayment.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 70)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "TOTAL PAID THIS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MONTH :"
        '
        'lblAdminGreeting
        '
        Me.lblAdminGreeting.AutoSize = False
        Me.lblAdminGreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblAdminGreeting.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminGreeting.ForeColor = System.Drawing.Color.Black
        Me.lblAdminGreeting.Location = New System.Drawing.Point(80, 63)
        Me.lblAdminGreeting.Name = "lblAdminGreeting"
        Me.lblAdminGreeting.Size = New System.Drawing.Size(440, 77)
        Me.lblAdminGreeting.TabIndex = 1
        Me.lblAdminGreeting.Text = "Guna2HtmlLabel1"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = False
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Black
        Me.lblDateTime.Location = New System.Drawing.Point(578, 60)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(327, 89)
        Me.lblDateTime.TabIndex = 0
        Me.lblDateTime.Text = "Guna2HtmlLabel1"
        Me.lblDateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.logout_btn.BorderRadius = 5
        Me.logout_btn.CheckedState.Parent = Me.logout_btn
        Me.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout_btn.CustomImages.Parent = Me.logout_btn
        Me.logout_btn.FillColor = System.Drawing.Color.Maroon
        Me.logout_btn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.HoverState.Parent = Me.logout_btn
        Me.logout_btn.Location = New System.Drawing.Point(13, 650)
        Me.logout_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.ShadowDecoration.Parent = Me.logout_btn
        Me.logout_btn.Size = New System.Drawing.Size(233, 72)
        Me.logout_btn.TabIndex = 7
        Me.logout_btn.Text = "LogOut"
        '
        'view_staff_payment_btn
        '
        Me.view_staff_payment_btn.BorderRadius = 5
        Me.view_staff_payment_btn.CheckedState.Parent = Me.view_staff_payment_btn
        Me.view_staff_payment_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view_staff_payment_btn.CustomImages.Parent = Me.view_staff_payment_btn
        Me.view_staff_payment_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_staff_payment_btn.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_staff_payment_btn.ForeColor = System.Drawing.Color.White
        Me.view_staff_payment_btn.HoverState.Parent = Me.view_staff_payment_btn
        Me.view_staff_payment_btn.Location = New System.Drawing.Point(13, 376)
        Me.view_staff_payment_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.view_staff_payment_btn.Name = "view_staff_payment_btn"
        Me.view_staff_payment_btn.ShadowDecoration.Parent = Me.view_staff_payment_btn
        Me.view_staff_payment_btn.Size = New System.Drawing.Size(233, 74)
        Me.view_staff_payment_btn.TabIndex = 6
        Me.view_staff_payment_btn.Text = "VIEW STAFF PAYMENTS"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.view_staff_payment_btn)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel3.Controls.Add(Me.salary_updates_btn)
        Me.Guna2Panel3.Controls.Add(Me.view_payrollbtn)
        Me.Guna2Panel3.Controls.Add(Me.logout_btn)
        Me.Guna2Panel3.Controls.Add(Me.add_staff_btn)
        Me.Guna2Panel3.Controls.Add(Me.add_department_btn)
        Me.Guna2Panel3.Controls.Add(Me.add_branch_btn)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(266, 735)
        Me.Guna2Panel3.TabIndex = 8
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(13, 473)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(233, 63)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "ADD JOB GRADE"
        '
        'salary_updates_btn
        '
        Me.salary_updates_btn.BorderRadius = 5
        Me.salary_updates_btn.CheckedState.Parent = Me.salary_updates_btn
        Me.salary_updates_btn.CustomImages.Parent = Me.salary_updates_btn
        Me.salary_updates_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.salary_updates_btn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.salary_updates_btn.ForeColor = System.Drawing.Color.White
        Me.salary_updates_btn.HoverState.Parent = Me.salary_updates_btn
        Me.salary_updates_btn.Location = New System.Drawing.Point(12, 283)
        Me.salary_updates_btn.Name = "salary_updates_btn"
        Me.salary_updates_btn.ShadowDecoration.Parent = Me.salary_updates_btn
        Me.salary_updates_btn.Size = New System.Drawing.Size(233, 74)
        Me.salary_updates_btn.TabIndex = 9
        Me.salary_updates_btn.Text = "VIEW STAFF RECORDS"
        '
        'view_payrollbtn
        '
        Me.view_payrollbtn.BorderRadius = 5
        Me.view_payrollbtn.CheckedState.Parent = Me.view_payrollbtn
        Me.view_payrollbtn.CustomImages.Parent = Me.view_payrollbtn
        Me.view_payrollbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.view_payrollbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.view_payrollbtn.ForeColor = System.Drawing.Color.White
        Me.view_payrollbtn.HoverState.Parent = Me.view_payrollbtn
        Me.view_payrollbtn.Location = New System.Drawing.Point(12, 558)
        Me.view_payrollbtn.Name = "view_payrollbtn"
        Me.view_payrollbtn.ShadowDecoration.Parent = Me.view_payrollbtn
        Me.view_payrollbtn.Size = New System.Drawing.Size(233, 74)
        Me.view_payrollbtn.TabIndex = 8
        Me.view_payrollbtn.Text = "VIEW PAYROLL"
        '
        'admin_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 735)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "admin_dashboard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin_dashboard"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2GradientPanel4.PerformLayout()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents add_staff_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents add_branch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents add_department_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents staff_fullname_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents role_id_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents admin_passport As System.Windows.Forms.PictureBox
    Friend WithEvents last_login_lbl As System.Windows.Forms.Label
    Friend WithEvents logout_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_staff_payment_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDateTime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblAdminGreeting As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents salary_updates_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents view_payrollbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents branch_count_lbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents total_employee_lbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
