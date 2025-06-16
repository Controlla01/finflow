<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_branch_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_branch_form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.status_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.clear_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.create_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.branch_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.branch_phone_number = New Guna.UI2.WinForms.Guna2TextBox()
        Me.branch_email_address_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.branch_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.branch_id_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.fetch_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1173, 49)
        Me.Panel1.TabIndex = 6
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
        Me.close_btn.Location = New System.Drawing.Point(1120, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 5
        Me.Guna2GroupBox3.Controls.Add(Me.back_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.Label5)
        Me.Guna2GroupBox3.Controls.Add(Me.status_combo)
        Me.Guna2GroupBox3.Controls.Add(Me.clear_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.create_btn)
        Me.Guna2GroupBox3.Controls.Add(Me.Label4)
        Me.Guna2GroupBox3.Controls.Add(Me.Label2)
        Me.Guna2GroupBox3.Controls.Add(Me.Label1)
        Me.Guna2GroupBox3.Controls.Add(Me.Label3)
        Me.Guna2GroupBox3.Controls.Add(Me.branch_address)
        Me.Guna2GroupBox3.Controls.Add(Me.branch_phone_number)
        Me.Guna2GroupBox3.Controls.Add(Me.branch_email_address_txt)
        Me.Guna2GroupBox3.Controls.Add(Me.branch_name_txt)
        Me.Guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(423, 81)
        Me.Guna2GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(704, 698)
        Me.Guna2GroupBox3.TabIndex = 8
        Me.Guna2GroupBox3.Text = "CREATE BRANCH"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.BorderColor = System.Drawing.Color.Silver
        Me.back_btn.BorderRadius = 5
        Me.back_btn.BorderThickness = 1
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.Transparent
        Me.back_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.back_btn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(557, 5)
        Me.back_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.PressedColor = System.Drawing.Color.Silver
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(128, 34)
        Me.back_btn.TabIndex = 13
        Me.back_btn.Text = "BACK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 532)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "STATUS"
        '
        'status_combo
        '
        Me.status_combo.BackColor = System.Drawing.Color.Transparent
        Me.status_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status_combo.FocusedColor = System.Drawing.Color.Empty
        Me.status_combo.FocusedState.Parent = Me.status_combo
        Me.status_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.status_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.status_combo.FormattingEnabled = True
        Me.status_combo.HoverState.Parent = Me.status_combo
        Me.status_combo.ItemHeight = 30
        Me.status_combo.ItemsAppearance.Parent = Me.status_combo
        Me.status_combo.Location = New System.Drawing.Point(33, 556)
        Me.status_combo.Margin = New System.Windows.Forms.Padding(4)
        Me.status_combo.Name = "status_combo"
        Me.status_combo.ShadowDecoration.Parent = Me.status_combo
        Me.status_combo.Size = New System.Drawing.Size(632, 36)
        Me.status_combo.TabIndex = 11
        '
        'clear_btn
        '
        Me.clear_btn.BorderRadius = 5
        Me.clear_btn.CheckedState.Parent = Me.clear_btn
        Me.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear_btn.CustomImages.Parent = Me.clear_btn
        Me.clear_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.HoverState.Parent = Me.clear_btn
        Me.clear_btn.Location = New System.Drawing.Point(33, 623)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.ShadowDecoration.Parent = Me.clear_btn
        Me.clear_btn.Size = New System.Drawing.Size(265, 55)
        Me.clear_btn.TabIndex = 10
        Me.clear_btn.Text = "CLEAR"
        '
        'create_btn
        '
        Me.create_btn.BorderRadius = 5
        Me.create_btn.CheckedState.Parent = Me.create_btn
        Me.create_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create_btn.CustomImages.Parent = Me.create_btn
        Me.create_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.create_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_btn.ForeColor = System.Drawing.Color.White
        Me.create_btn.HoverState.Parent = Me.create_btn
        Me.create_btn.Location = New System.Drawing.Point(404, 623)
        Me.create_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.create_btn.Name = "create_btn"
        Me.create_btn.ShadowDecoration.Parent = Me.create_btn
        Me.create_btn.Size = New System.Drawing.Size(265, 55)
        Me.create_btn.TabIndex = 10
        Me.create_btn.Text = "SUBMIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 430)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "BRANCH ADDRESS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 315)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BRANCH PHONE NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BRANCH EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "BRANCH NAME"
        '
        'branch_address
        '
        Me.branch_address.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.branch_address.BorderRadius = 5
        Me.branch_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.branch_address.DefaultText = ""
        Me.branch_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.branch_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.branch_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_address.DisabledState.Parent = Me.branch_address
        Me.branch_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_address.FocusedState.Parent = Me.branch_address
        Me.branch_address.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_address.ForeColor = System.Drawing.Color.Black
        Me.branch_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_address.HoverState.Parent = Me.branch_address
        Me.branch_address.Location = New System.Drawing.Point(28, 455)
        Me.branch_address.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.branch_address.Name = "branch_address"
        Me.branch_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.branch_address.PlaceholderText = "ENTER BRANCH ADDRESS"
        Me.branch_address.SelectedText = ""
        Me.branch_address.ShadowDecoration.Parent = Me.branch_address
        Me.branch_address.Size = New System.Drawing.Size(639, 55)
        Me.branch_address.TabIndex = 7
        '
        'branch_phone_number
        '
        Me.branch_phone_number.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.branch_phone_number.BorderRadius = 5
        Me.branch_phone_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.branch_phone_number.DefaultText = ""
        Me.branch_phone_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.branch_phone_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.branch_phone_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_phone_number.DisabledState.Parent = Me.branch_phone_number
        Me.branch_phone_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_phone_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_phone_number.FocusedState.Parent = Me.branch_phone_number
        Me.branch_phone_number.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_phone_number.ForeColor = System.Drawing.Color.Black
        Me.branch_phone_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_phone_number.HoverState.Parent = Me.branch_phone_number
        Me.branch_phone_number.Location = New System.Drawing.Point(31, 341)
        Me.branch_phone_number.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.branch_phone_number.Name = "branch_phone_number"
        Me.branch_phone_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.branch_phone_number.PlaceholderText = "ENTER BRANCH PHONE NUMBER"
        Me.branch_phone_number.SelectedText = ""
        Me.branch_phone_number.ShadowDecoration.Parent = Me.branch_phone_number
        Me.branch_phone_number.Size = New System.Drawing.Size(639, 55)
        Me.branch_phone_number.TabIndex = 7
        '
        'branch_email_address_txt
        '
        Me.branch_email_address_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.branch_email_address_txt.BorderRadius = 5
        Me.branch_email_address_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.branch_email_address_txt.DefaultText = ""
        Me.branch_email_address_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.branch_email_address_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.branch_email_address_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_email_address_txt.DisabledState.Parent = Me.branch_email_address_txt
        Me.branch_email_address_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_email_address_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_email_address_txt.FocusedState.Parent = Me.branch_email_address_txt
        Me.branch_email_address_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_email_address_txt.ForeColor = System.Drawing.Color.Black
        Me.branch_email_address_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_email_address_txt.HoverState.Parent = Me.branch_email_address_txt
        Me.branch_email_address_txt.Location = New System.Drawing.Point(28, 228)
        Me.branch_email_address_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.branch_email_address_txt.Name = "branch_email_address_txt"
        Me.branch_email_address_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.branch_email_address_txt.PlaceholderText = "ENTER BRANCH EMAIL"
        Me.branch_email_address_txt.SelectedText = ""
        Me.branch_email_address_txt.ShadowDecoration.Parent = Me.branch_email_address_txt
        Me.branch_email_address_txt.Size = New System.Drawing.Size(639, 55)
        Me.branch_email_address_txt.TabIndex = 7
        '
        'branch_name_txt
        '
        Me.branch_name_txt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.branch_name_txt.BorderRadius = 5
        Me.branch_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.branch_name_txt.DefaultText = ""
        Me.branch_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.branch_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.branch_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_name_txt.DisabledState.Parent = Me.branch_name_txt
        Me.branch_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.branch_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_name_txt.FocusedState.Parent = Me.branch_name_txt
        Me.branch_name_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branch_name_txt.ForeColor = System.Drawing.Color.Black
        Me.branch_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branch_name_txt.HoverState.Parent = Me.branch_name_txt
        Me.branch_name_txt.Location = New System.Drawing.Point(28, 114)
        Me.branch_name_txt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.branch_name_txt.Name = "branch_name_txt"
        Me.branch_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.branch_name_txt.PlaceholderText = "ENTER BRANCH NAME"
        Me.branch_name_txt.SelectedText = ""
        Me.branch_name_txt.ShadowDecoration.Parent = Me.branch_name_txt
        Me.branch_name_txt.Size = New System.Drawing.Size(639, 55)
        Me.branch_name_txt.TabIndex = 7
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.branch_id_combo)
        Me.Guna2GroupBox1.Controls.Add(Me.fetch_btn)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(29, 81)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(351, 315)
        Me.Guna2GroupBox1.TabIndex = 10
        Me.Guna2GroupBox1.Text = "BRANCH PROFILE"
        '
        'branch_id_combo
        '
        Me.branch_id_combo.BackColor = System.Drawing.Color.Transparent
        Me.branch_id_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.branch_id_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.branch_id_combo.FocusedColor = System.Drawing.Color.Empty
        Me.branch_id_combo.FocusedState.Parent = Me.branch_id_combo
        Me.branch_id_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.branch_id_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.branch_id_combo.FormattingEnabled = True
        Me.branch_id_combo.HoverState.Parent = Me.branch_id_combo
        Me.branch_id_combo.ItemHeight = 30
        Me.branch_id_combo.ItemsAppearance.Parent = Me.branch_id_combo
        Me.branch_id_combo.Location = New System.Drawing.Point(25, 95)
        Me.branch_id_combo.Margin = New System.Windows.Forms.Padding(4)
        Me.branch_id_combo.Name = "branch_id_combo"
        Me.branch_id_combo.ShadowDecoration.Parent = Me.branch_id_combo
        Me.branch_id_combo.Size = New System.Drawing.Size(297, 36)
        Me.branch_id_combo.TabIndex = 12
        '
        'fetch_btn
        '
        Me.fetch_btn.BorderRadius = 5
        Me.fetch_btn.CheckedState.Parent = Me.fetch_btn
        Me.fetch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetch_btn.CustomImages.Parent = Me.fetch_btn
        Me.fetch_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.fetch_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetch_btn.ForeColor = System.Drawing.Color.White
        Me.fetch_btn.HoverState.Parent = Me.fetch_btn
        Me.fetch_btn.Location = New System.Drawing.Point(25, 231)
        Me.fetch_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.fetch_btn.Name = "fetch_btn"
        Me.fetch_btn.ShadowDecoration.Parent = Me.fetch_btn
        Me.fetch_btn.Size = New System.Drawing.Size(299, 52)
        Me.fetch_btn.TabIndex = 1
        Me.fetch_btn.Text = "FETCH"
        '
        'add_branch_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 805)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "add_branch_form"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_branch_form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Guna2GroupBox3.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents branch_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents branch_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents branch_phone_number As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents branch_email_address_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents create_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents status_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents branch_id_combo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents fetch_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clear_btn As Guna.UI2.WinForms.Guna2Button
End Class
