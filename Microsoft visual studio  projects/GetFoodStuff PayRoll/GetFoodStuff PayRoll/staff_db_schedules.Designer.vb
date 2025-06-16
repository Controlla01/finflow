<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_db_schedules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_db_schedules))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.BtnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSort = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveSchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.ListBox1schedule = New System.Windows.Forms.ListBox()
        Me.Btn_del = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_add = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 50)
        Me.Panel1.TabIndex = 8
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
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.close_btn.Location = New System.Drawing.Point(761, -1)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(51, 50)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BorderRadius = 3
        Me.BtnEdit.CheckedState.Parent = Me.BtnEdit
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.CustomImages.Parent = Me.BtnEdit
        Me.BtnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.HoverState.Parent = Me.BtnEdit
        Me.BtnEdit.Location = New System.Drawing.Point(15, 196)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.ShadowDecoration.Parent = Me.BtnEdit
        Me.BtnEdit.Size = New System.Drawing.Size(134, 62)
        Me.BtnEdit.TabIndex = 5
        Me.BtnEdit.Text = "EDIT SCHEDULE"
        '
        'BtnSort
        '
        Me.BtnSort.BorderRadius = 3
        Me.BtnSort.CheckedState.Parent = Me.BtnSort
        Me.BtnSort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSort.CustomImages.Parent = Me.BtnSort
        Me.BtnSort.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSort.ForeColor = System.Drawing.Color.White
        Me.BtnSort.HoverState.Parent = Me.BtnSort
        Me.BtnSort.Location = New System.Drawing.Point(15, 301)
        Me.BtnSort.Name = "BtnSort"
        Me.BtnSort.ShadowDecoration.Parent = Me.BtnSort
        Me.BtnSort.Size = New System.Drawing.Size(134, 63)
        Me.BtnSort.TabIndex = 5
        Me.BtnSort.Text = "SORT SCHEDULE"
        '
        'btnSaveSchedule
        '
        Me.btnSaveSchedule.BorderRadius = 3
        Me.btnSaveSchedule.CheckedState.Parent = Me.btnSaveSchedule
        Me.btnSaveSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSchedule.CustomImages.Parent = Me.btnSaveSchedule
        Me.btnSaveSchedule.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSaveSchedule.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSaveSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSaveSchedule.HoverState.Parent = Me.btnSaveSchedule
        Me.btnSaveSchedule.Location = New System.Drawing.Point(15, 405)
        Me.btnSaveSchedule.Name = "btnSaveSchedule"
        Me.btnSaveSchedule.ShadowDecoration.Parent = Me.btnSaveSchedule
        Me.btnSaveSchedule.Size = New System.Drawing.Size(134, 60)
        Me.btnSaveSchedule.TabIndex = 5
        Me.btnSaveSchedule.Text = "SAVE SCHEDULE"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BorderRadius = 3
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Location = New System.Drawing.Point(15, 108)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(134, 49)
        Me.Guna2Button6.TabIndex = 5
        Me.Guna2Button6.Text = "BACK"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 3
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_add)
        Me.Guna2GroupBox1.Controls.Add(Me.Btn_del)
        Me.Guna2GroupBox1.Controls.Add(Me.ListBox1schedule)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(167, 73)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(626, 392)
        Me.Guna2GroupBox1.TabIndex = 9
        Me.Guna2GroupBox1.Text = "Today's Schedules"
        '
        'ListBox1schedule
        '
        Me.ListBox1schedule.FormattingEnabled = True
        Me.ListBox1schedule.ItemHeight = 25
        Me.ListBox1schedule.Location = New System.Drawing.Point(22, 63)
        Me.ListBox1schedule.Name = "ListBox1schedule"
        Me.ListBox1schedule.Size = New System.Drawing.Size(579, 229)
        Me.ListBox1schedule.TabIndex = 1
        '
        'Btn_del
        '
        Me.Btn_del.BorderRadius = 3
        Me.Btn_del.CheckedState.Parent = Me.Btn_del
        Me.Btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_del.CustomImages.Parent = Me.Btn_del
        Me.Btn_del.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Btn_del.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_del.ForeColor = System.Drawing.Color.White
        Me.Btn_del.HoverState.Parent = Me.Btn_del
        Me.Btn_del.Location = New System.Drawing.Point(436, 309)
        Me.Btn_del.Name = "Btn_del"
        Me.Btn_del.ShadowDecoration.Parent = Me.Btn_del
        Me.Btn_del.Size = New System.Drawing.Size(165, 62)
        Me.Btn_del.TabIndex = 2
        Me.Btn_del.Text = "DELETE SCHEDULE"
        '
        'Btn_add
        '
        Me.Btn_add.BorderRadius = 3
        Me.Btn_add.CheckedState.Parent = Me.Btn_add
        Me.Btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_add.CustomImages.Parent = Me.Btn_add
        Me.Btn_add.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_add.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_add.ForeColor = System.Drawing.Color.White
        Me.Btn_add.HoverState.Parent = Me.Btn_add
        Me.Btn_add.Location = New System.Drawing.Point(22, 313)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.ShadowDecoration.Parent = Me.Btn_add
        Me.Btn_add.Size = New System.Drawing.Size(181, 58)
        Me.Btn_add.TabIndex = 3
        Me.Btn_add.Text = "ADD SCHEDULE"
        '
        'staff_db_schedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 490)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.btnSaveSchedule)
        Me.Controls.Add(Me.BtnSort)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff_db_schedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff_db_schedules"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSort As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ListBox1schedule As System.Windows.Forms.ListBox
    Friend WithEvents Btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_del As Guna.UI2.WinForms.Guna2Button


End Class
