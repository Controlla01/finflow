<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_salary_update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_salary_update))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvBulkSalary = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.job_level_combo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgvBulkSalary, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(877, 50)
        Me.Panel1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, -1)
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
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(825, -2)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 50)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.dgvBulkSalary)
        Me.Guna2GroupBox1.Controls.Add(Me.job_level_combo)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 45, 0, 0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(851, 419)
        Me.Guna2GroupBox1.TabIndex = 23
        Me.Guna2GroupBox1.Text = "SET STAFF SALARIES"
        '
        'dgvBulkSalary
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvBulkSalary.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBulkSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBulkSalary.BackgroundColor = System.Drawing.Color.White
        Me.dgvBulkSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBulkSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBulkSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBulkSalary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBulkSalary.ColumnHeadersHeight = 4
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBulkSalary.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBulkSalary.EnableHeadersVisualStyles = False
        Me.dgvBulkSalary.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBulkSalary.Location = New System.Drawing.Point(34, 109)
        Me.dgvBulkSalary.Name = "dgvBulkSalary"
        Me.dgvBulkSalary.RowHeadersVisible = False
        Me.dgvBulkSalary.RowTemplate.Height = 24
        Me.dgvBulkSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBulkSalary.Size = New System.Drawing.Size(782, 300)
        Me.dgvBulkSalary.TabIndex = 1
        Me.dgvBulkSalary.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvBulkSalary.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBulkSalary.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvBulkSalary.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvBulkSalary.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvBulkSalary.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvBulkSalary.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvBulkSalary.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvBulkSalary.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvBulkSalary.ThemeStyle.ReadOnly = False
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.Height = 24
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBulkSalary.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'job_level_combo
        '
        Me.job_level_combo.BackColor = System.Drawing.Color.Transparent
        Me.job_level_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.job_level_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.job_level_combo.FocusedColor = System.Drawing.Color.Empty
        Me.job_level_combo.FocusedState.Parent = Me.job_level_combo
        Me.job_level_combo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.job_level_combo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.job_level_combo.FormattingEnabled = True
        Me.job_level_combo.HoverState.Parent = Me.job_level_combo
        Me.job_level_combo.ItemHeight = 30
        Me.job_level_combo.ItemsAppearance.Parent = Me.job_level_combo
        Me.job_level_combo.Location = New System.Drawing.Point(38, 60)
        Me.job_level_combo.Name = "job_level_combo"
        Me.job_level_combo.ShadowDecoration.Parent = Me.job_level_combo
        Me.job_level_combo.Size = New System.Drawing.Size(675, 36)
        Me.job_level_combo.TabIndex = 0
        '
        'staff_salary_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 501)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff_salary_update"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff_salary_update"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgvBulkSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvBulkSalary As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents job_level_combo As Guna.UI2.WinForms.Guna2ComboBox
End Class
