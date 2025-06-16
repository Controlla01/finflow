<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll_gangan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payroll_gangan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.dgvPayroll = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblTotalPayment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.btnRunPayroll = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSavePayroll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1484, 49)
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
        Me.close_btn.Location = New System.Drawing.Point(1432, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 48)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'dgvPayroll
        '
        Me.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPayroll.Location = New System.Drawing.Point(16, 120)
        Me.dgvPayroll.Name = "dgvPayroll"
        Me.dgvPayroll.RowTemplate.Height = 24
        Me.dgvPayroll.Size = New System.Drawing.Size(1229, 478)
        Me.dgvPayroll.TabIndex = 7
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.lblTotalPayment)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbYear)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbMonth)
        Me.Guna2GroupBox1.Controls.Add(Me.dgvPayroll)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 45, 0, 0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(211, 62)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1260, 609)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "PROCESS STAFF PAYROLL"
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = False
        Me.lblTotalPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayment.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPayment.Location = New System.Drawing.Point(469, 63)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(776, 28)
        Me.lblTotalPayment.TabIndex = 10
        Me.lblTotalPayment.Text = Nothing
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(259, 53)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(192, 59)
        Me.cmbYear.TabIndex = 9
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(16, 53)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(200, 59)
        Me.cmbMonth.TabIndex = 8
        '
        'btnRunPayroll
        '
        Me.btnRunPayroll.BorderRadius = 5
        Me.btnRunPayroll.CheckedState.Parent = Me.btnRunPayroll
        Me.btnRunPayroll.CustomImages.Parent = Me.btnRunPayroll
        Me.btnRunPayroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnRunPayroll.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRunPayroll.ForeColor = System.Drawing.Color.White
        Me.btnRunPayroll.HoverState.Parent = Me.btnRunPayroll
        Me.btnRunPayroll.Location = New System.Drawing.Point(21, 295)
        Me.btnRunPayroll.Name = "btnRunPayroll"
        Me.btnRunPayroll.ShadowDecoration.Parent = Me.btnRunPayroll
        Me.btnRunPayroll.Size = New System.Drawing.Size(174, 66)
        Me.btnRunPayroll.TabIndex = 9
        Me.btnRunPayroll.Text = "RUN PAYROLL"
        '
        'btnSavePayroll
        '
        Me.btnSavePayroll.BorderRadius = 5
        Me.btnSavePayroll.CheckedState.Parent = Me.btnSavePayroll
        Me.btnSavePayroll.CustomImages.Parent = Me.btnSavePayroll
        Me.btnSavePayroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnSavePayroll.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSavePayroll.ForeColor = System.Drawing.Color.White
        Me.btnSavePayroll.HoverState.Parent = Me.btnSavePayroll
        Me.btnSavePayroll.Location = New System.Drawing.Point(21, 411)
        Me.btnSavePayroll.Name = "btnSavePayroll"
        Me.btnSavePayroll.ShadowDecoration.Parent = Me.btnSavePayroll
        Me.btnSavePayroll.Size = New System.Drawing.Size(174, 66)
        Me.btnSavePayroll.TabIndex = 9
        Me.btnSavePayroll.Text = "SAVE PAYROLL"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(21, 182)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(174, 66)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "BACK"
        '
        'btnClear
        '
        Me.btnClear.BorderRadius = 5
        Me.btnClear.CheckedState.Parent = Me.btnClear
        Me.btnClear.CustomImages.Parent = Me.btnClear
        Me.btnClear.FillColor = System.Drawing.Color.Red
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.HoverState.Parent = Me.btnClear
        Me.btnClear.Location = New System.Drawing.Point(21, 529)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.ShadowDecoration.Parent = Me.btnClear
        Me.btnClear.Size = New System.Drawing.Size(174, 66)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "CLEAR"
        '
        'payroll_gangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 685)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnSavePayroll)
        Me.Controls.Add(Me.btnRunPayroll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "payroll_gangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payroll_gangan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents dgvPayroll As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnRunPayroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSavePayroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalPayment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
End Class
