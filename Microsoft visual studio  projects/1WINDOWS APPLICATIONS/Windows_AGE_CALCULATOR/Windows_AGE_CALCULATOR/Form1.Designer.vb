<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBirthYear = New System.Windows.Forms.TextBox()
        Me.txtBirthMonth = New System.Windows.Forms.TextBox()
        Me.txtBirthDay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculateAge = New System.Windows.Forms.Button()
        Me.Clear_btn = New System.Windows.Forms.Button()
        Me.years_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.days_txt = New System.Windows.Forms.TextBox()
        Me.months_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Your Birth month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Your Birth year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Input Your Birth day"
        '
        'txtBirthYear
        '
        Me.txtBirthYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthYear.Font = New System.Drawing.Font("Cascadia Code", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthYear.Location = New System.Drawing.Point(12, 33)
        Me.txtBirthYear.Multiline = True
        Me.txtBirthYear.Name = "txtBirthYear"
        Me.txtBirthYear.Size = New System.Drawing.Size(452, 44)
        Me.txtBirthYear.TabIndex = 4
        '
        'txtBirthMonth
        '
        Me.txtBirthMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthMonth.Font = New System.Drawing.Font("Cascadia Code", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthMonth.Location = New System.Drawing.Point(12, 106)
        Me.txtBirthMonth.Multiline = True
        Me.txtBirthMonth.Name = "txtBirthMonth"
        Me.txtBirthMonth.Size = New System.Drawing.Size(452, 44)
        Me.txtBirthMonth.TabIndex = 5
        '
        'txtBirthDay
        '
        Me.txtBirthDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBirthDay.Font = New System.Drawing.Font("Cascadia Code", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDay.Location = New System.Drawing.Point(12, 181)
        Me.txtBirthDay.Multiline = True
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(452, 44)
        Me.txtBirthDay.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "AGE CALCULATOR"
        '
        'btnCalculateAge
        '
        Me.btnCalculateAge.BackColor = System.Drawing.Color.LightGray
        Me.btnCalculateAge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculateAge.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateAge.ForeColor = System.Drawing.Color.Black
        Me.btnCalculateAge.Location = New System.Drawing.Point(32, 340)
        Me.btnCalculateAge.Name = "btnCalculateAge"
        Me.btnCalculateAge.Size = New System.Drawing.Size(317, 55)
        Me.btnCalculateAge.TabIndex = 8
        Me.btnCalculateAge.Text = "CALCULATE"
        Me.btnCalculateAge.UseVisualStyleBackColor = False
        '
        'Clear_btn
        '
        Me.Clear_btn.BackColor = System.Drawing.Color.Red
        Me.Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_btn.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_btn.ForeColor = System.Drawing.Color.White
        Me.Clear_btn.Location = New System.Drawing.Point(356, 340)
        Me.Clear_btn.Name = "Clear_btn"
        Me.Clear_btn.Size = New System.Drawing.Size(129, 55)
        Me.Clear_btn.TabIndex = 9
        Me.Clear_btn.Text = "CLEAR"
        Me.Clear_btn.UseVisualStyleBackColor = False
        '
        'years_txt
        '
        Me.years_txt.BackColor = System.Drawing.Color.White
        Me.years_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.years_txt.Enabled = False
        Me.years_txt.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.years_txt.Location = New System.Drawing.Point(10, 27)
        Me.years_txt.Multiline = True
        Me.years_txt.Name = "years_txt"
        Me.years_txt.Size = New System.Drawing.Size(136, 44)
        Me.years_txt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "YOU ARE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "MONTHS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "YEARS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DAYS"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(237, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(199, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Date :"
        '
        'days_txt
        '
        Me.days_txt.BackColor = System.Drawing.Color.White
        Me.days_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.days_txt.Enabled = False
        Me.days_txt.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days_txt.Location = New System.Drawing.Point(322, 27)
        Me.days_txt.Multiline = True
        Me.days_txt.Name = "days_txt"
        Me.days_txt.Size = New System.Drawing.Size(136, 44)
        Me.days_txt.TabIndex = 11
        '
        'months_txt
        '
        Me.months_txt.BackColor = System.Drawing.Color.White
        Me.months_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.months_txt.Enabled = False
        Me.months_txt.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.months_txt.Location = New System.Drawing.Point(167, 27)
        Me.months_txt.Multiline = True
        Me.months_txt.Name = "months_txt"
        Me.months_txt.Size = New System.Drawing.Size(136, 44)
        Me.months_txt.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtBirthDay)
        Me.GroupBox1.Controls.Add(Me.txtBirthMonth)
        Me.GroupBox1.Controls.Add(Me.txtBirthYear)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 229)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.months_txt)
        Me.GroupBox2.Controls.Add(Me.days_txt)
        Me.GroupBox2.Controls.Add(Me.years_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 104)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(525, 527)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Clear_btn)
        Me.Controls.Add(Me.btnCalculateAge)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBirthYear As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthDay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateAge As System.Windows.Forms.Button
    Friend WithEvents Clear_btn As System.Windows.Forms.Button
    Friend WithEvents years_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents days_txt As System.Windows.Forms.TextBox
    Friend WithEvents months_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
