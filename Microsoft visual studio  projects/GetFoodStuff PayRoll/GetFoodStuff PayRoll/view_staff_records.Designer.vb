<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_staff_records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(view_staff_records))
        Me.staff_record = New System.Windows.Forms.ListView()
        Me.SN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.STAFFID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FULLNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ROLE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.STATUSNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BRANCHNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DEPARTMENTNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.JOBGRADE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'staff_record
        '
        Me.staff_record.AutoArrange = False
        Me.staff_record.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SN, Me.STAFFID, Me.FULLNAME, Me.ROLE, Me.STATUSNAME, Me.BRANCHNAME, Me.DEPARTMENTNAME, Me.JOBGRADE})
        Me.staff_record.GridLines = True
        Me.staff_record.Location = New System.Drawing.Point(22, 56)
        Me.staff_record.Name = "staff_record"
        Me.staff_record.Size = New System.Drawing.Size(1400, 554)
        Me.staff_record.TabIndex = 0
        Me.staff_record.UseCompatibleStateImageBehavior = False
        Me.staff_record.View = System.Windows.Forms.View.Details
        '
        'SN
        '
        Me.SN.Text = "SN"
        '
        'STAFFID
        '
        Me.STAFFID.Text = "STAFFID"
        Me.STAFFID.Width = 195
        '
        'FULLNAME
        '
        Me.FULLNAME.Text = "FULLNAME"
        Me.FULLNAME.Width = 186
        '
        'ROLE
        '
        Me.ROLE.Text = "ROLE"
        Me.ROLE.Width = 106
        '
        'STATUSNAME
        '
        Me.STATUSNAME.Text = "STATUSNAME"
        Me.STATUSNAME.Width = 125
        '
        'BRANCHNAME
        '
        Me.BRANCHNAME.Text = "BRANCHNAME"
        Me.BRANCHNAME.Width = 125
        '
        'DEPARTMENTNAME
        '
        Me.DEPARTMENTNAME.Text = "DEPARTMENTNAME"
        Me.DEPARTMENTNAME.Width = 168
        '
        'JOBGRADE
        '
        Me.JOBGRADE.Text = "JOBGRADE"
        Me.JOBGRADE.Width = 108
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.close_btn)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1439, 50)
        Me.Panel1.TabIndex = 23
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
        Me.close_btn.Location = New System.Drawing.Point(1387, -2)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 50)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'view_staff_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.staff_record)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "view_staff_records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_staff_records"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents staff_record As System.Windows.Forms.ListView
    Friend WithEvents SN As System.Windows.Forms.ColumnHeader
    Friend WithEvents STAFFID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents FULLNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents ROLE As System.Windows.Forms.ColumnHeader
    Friend WithEvents STATUSNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents BRANCHNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents DEPARTMENTNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents JOBGRADE As System.Windows.Forms.ColumnHeader
End Class
