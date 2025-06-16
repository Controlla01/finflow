<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblDateTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_passport = New System.Windows.Forms.PictureBox()
        Me.lblAdminGreeting = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.refresh_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAnnouncements = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStaff_payments = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMySchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.last_login_lbl = New System.Windows.Forms.Label()
        Me.role_id_lbl = New System.Windows.Forms.Label()
        Me.staff_fullname_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1298, 49)
        Me.Panel1.TabIndex = 6
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
        Me.close_btn.Location = New System.Drawing.Point(1246, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.Silver
        Me.Guna2GroupBox2.BorderRadius = 5
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2GradientPanel1)
        Me.Guna2GroupBox2.Controls.Add(Me.lblDateTime)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2Panel2)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(284, 69)
        Me.Guna2GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(971, 598)
        Me.Guna2GroupBox2.TabIndex = 8
        Me.Guna2GroupBox2.Text = "STAFF'S DETAILS"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = False
        Me.lblDateTime.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Black
        Me.lblDateTime.Location = New System.Drawing.Point(537, 60)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(327, 83)
        Me.lblDateTime.TabIndex = 2
        Me.lblDateTime.Text = "Guna2HtmlLabel1"
        Me.lblDateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.admin_passport)
        Me.Guna2Panel2.Controls.Add(Me.lblAdminGreeting)
        Me.Guna2Panel2.Location = New System.Drawing.Point(17, 57)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(847, 111)
        Me.Guna2Panel2.TabIndex = 4
        '
        'admin_passport
        '
        Me.admin_passport.BackgroundImage = CType(resources.GetObject("admin_passport.BackgroundImage"), System.Drawing.Image)
        Me.admin_passport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admin_passport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.admin_passport.Enabled = False
        Me.admin_passport.Location = New System.Drawing.Point(10, -3)
        Me.admin_passport.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_passport.Name = "admin_passport"
        Me.admin_passport.Size = New System.Drawing.Size(102, 99)
        Me.admin_passport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_passport.TabIndex = 1
        Me.admin_passport.TabStop = False
        '
        'lblAdminGreeting
        '
        Me.lblAdminGreeting.AutoSize = False
        Me.lblAdminGreeting.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAdminGreeting.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminGreeting.ForeColor = System.Drawing.Color.Black
        Me.lblAdminGreeting.Location = New System.Drawing.Point(128, 9)
        Me.lblAdminGreeting.Name = "lblAdminGreeting"
        Me.lblAdminGreeting.Size = New System.Drawing.Size(440, 99)
        Me.lblAdminGreeting.TabIndex = 3
        Me.lblAdminGreeting.Text = "Guna2HtmlLabel1"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 6
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.btnLogout)
        Me.Guna2Panel3.Controls.Add(Me.refresh_btn)
        Me.Guna2Panel3.Controls.Add(Me.btnReports)
        Me.Guna2Panel3.Controls.Add(Me.btnAnnouncements)
        Me.Guna2Panel3.Controls.Add(Me.btnStaff_payments)
        Me.Guna2Panel3.Controls.Add(Me.btnMySchedule)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 69)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(256, 598)
        Me.Guna2Panel3.TabIndex = 9
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BorderRadius = 5
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.Maroon
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Location = New System.Drawing.Point(11, 472)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(233, 72)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "LogOut"
        '
        'refresh_btn
        '
        Me.refresh_btn.BackColor = System.Drawing.Color.Transparent
        Me.refresh_btn.BorderRadius = 5
        Me.refresh_btn.CheckedState.Parent = Me.refresh_btn
        Me.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh_btn.CustomImages.Parent = Me.refresh_btn
        Me.refresh_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.refresh_btn.Font = New System.Drawing.Font("Segoe UI", 13.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.ForeColor = System.Drawing.Color.White
        Me.refresh_btn.HoverState.Parent = Me.refresh_btn
        Me.refresh_btn.Location = New System.Drawing.Point(11, 14)
        Me.refresh_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.ShadowDecoration.Parent = Me.refresh_btn
        Me.refresh_btn.Size = New System.Drawing.Size(233, 59)
        Me.refresh_btn.TabIndex = 12
        Me.refresh_btn.Text = "DASHBOARD (MAIN)"
        '
        'btnReports
        '
        Me.btnReports.BorderRadius = 5
        Me.btnReports.CheckedState.Parent = Me.btnReports
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.CustomImages.Parent = Me.btnReports
        Me.btnReports.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.HoverState.Parent = Me.btnReports
        Me.btnReports.Location = New System.Drawing.Point(11, 385)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.ShadowDecoration.Parent = Me.btnReports
        Me.btnReports.Size = New System.Drawing.Size(233, 59)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "REPORTS"
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.BorderRadius = 5
        Me.btnAnnouncements.CheckedState.Parent = Me.btnAnnouncements
        Me.btnAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnouncements.CustomImages.Parent = Me.btnAnnouncements
        Me.btnAnnouncements.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnAnnouncements.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnouncements.ForeColor = System.Drawing.Color.White
        Me.btnAnnouncements.HoverState.Parent = Me.btnAnnouncements
        Me.btnAnnouncements.Location = New System.Drawing.Point(11, 293)
        Me.btnAnnouncements.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.ShadowDecoration.Parent = Me.btnAnnouncements
        Me.btnAnnouncements.Size = New System.Drawing.Size(233, 59)
        Me.btnAnnouncements.TabIndex = 10
        Me.btnAnnouncements.Text = "ANNOUNCEMENTS"
        '
        'btnStaff_payments
        '
        Me.btnStaff_payments.BorderRadius = 5
        Me.btnStaff_payments.CheckedState.Parent = Me.btnStaff_payments
        Me.btnStaff_payments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff_payments.CustomImages.Parent = Me.btnStaff_payments
        Me.btnStaff_payments.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnStaff_payments.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff_payments.ForeColor = System.Drawing.Color.White
        Me.btnStaff_payments.HoverState.Parent = Me.btnStaff_payments
        Me.btnStaff_payments.Location = New System.Drawing.Point(11, 198)
        Me.btnStaff_payments.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStaff_payments.Name = "btnStaff_payments"
        Me.btnStaff_payments.ShadowDecoration.Parent = Me.btnStaff_payments
        Me.btnStaff_payments.Size = New System.Drawing.Size(233, 59)
        Me.btnStaff_payments.TabIndex = 9
        Me.btnStaff_payments.Text = "MY PAYMENTS"
        '
        'btnMySchedule
        '
        Me.btnMySchedule.BorderRadius = 5
        Me.btnMySchedule.CheckedState.Parent = Me.btnMySchedule
        Me.btnMySchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMySchedule.CustomImages.Parent = Me.btnMySchedule
        Me.btnMySchedule.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnMySchedule.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMySchedule.ForeColor = System.Drawing.Color.White
        Me.btnMySchedule.HoverState.Parent = Me.btnMySchedule
        Me.btnMySchedule.Location = New System.Drawing.Point(11, 102)
        Me.btnMySchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMySchedule.Name = "btnMySchedule"
        Me.btnMySchedule.ShadowDecoration.Parent = Me.btnMySchedule
        Me.btnMySchedule.Size = New System.Drawing.Size(233, 59)
        Me.btnMySchedule.TabIndex = 8
        Me.btnMySchedule.Text = "MY SCHEDULE"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderRadius = 15
        Me.Guna2GradientPanel1.BorderThickness = 5
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel6)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2GradientPanel1.Controls.Add(Me.last_login_lbl)
        Me.Guna2GradientPanel1.Controls.Add(Me.role_id_lbl)
        Me.Guna2GradientPanel1.Controls.Add(Me.staff_fullname_lbl)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(8, 190)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(954, 391)
        Me.Guna2GradientPanel1.TabIndex = 9
        Me.Guna2GradientPanel1.UseTransparentBackground = True
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.White
        Me.Guna2Panel6.Location = New System.Drawing.Point(23, 313)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(910, 51)
        Me.Guna2Panel6.TabIndex = 14
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(23, 201)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(910, 51)
        Me.Guna2Panel5.TabIndex = 13
        '
        'last_login_lbl
        '
        Me.last_login_lbl.AutoSize = True
        Me.last_login_lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_login_lbl.ForeColor = System.Drawing.Color.White
        Me.last_login_lbl.Location = New System.Drawing.Point(32, 152)
        Me.last_login_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.last_login_lbl.Name = "last_login_lbl"
        Me.last_login_lbl.Size = New System.Drawing.Size(23, 28)
        Me.last_login_lbl.TabIndex = 8
        Me.last_login_lbl.Text = "0"
        '
        'role_id_lbl
        '
        Me.role_id_lbl.AutoSize = True
        Me.role_id_lbl.BackColor = System.Drawing.Color.White
        Me.role_id_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role_id_lbl.ForeColor = System.Drawing.Color.Black
        Me.role_id_lbl.Location = New System.Drawing.Point(92, 80)
        Me.role_id_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.role_id_lbl.Name = "role_id_lbl"
        Me.role_id_lbl.Size = New System.Drawing.Size(23, 28)
        Me.role_id_lbl.TabIndex = 10
        Me.role_id_lbl.Text = "0"
        '
        'staff_fullname_lbl
        '
        Me.staff_fullname_lbl.AutoSize = True
        Me.staff_fullname_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staff_fullname_lbl.ForeColor = System.Drawing.Color.White
        Me.staff_fullname_lbl.Location = New System.Drawing.Point(208, 27)
        Me.staff_fullname_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.staff_fullname_lbl.Name = "staff_fullname_lbl"
        Me.staff_fullname_lbl.Size = New System.Drawing.Size(23, 28)
        Me.staff_fullname_lbl.TabIndex = 9
        Me.staff_fullname_lbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "STAFF FULL NAME :"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Location = New System.Drawing.Point(22, 76)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(911, 51)
        Me.Guna2Panel4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ROLE :"
        '
        'Staff_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 694)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Staff_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff_dashboard"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.admin_passport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents admin_passport As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents refresh_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAnnouncements As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStaff_payments As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMySchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblDateTime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblAdminGreeting As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents last_login_lbl As System.Windows.Forms.Label
    Friend WithEvents role_id_lbl As System.Windows.Forms.Label
    Friend WithEvents staff_fullname_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
