<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.salary_txt = New System.Windows.Forms.TextBox()
        Me.deducted_txt = New System.Windows.Forms.TextBox()
        Me.percentage_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.balance_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.secondno_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'salary_txt
        '
        Me.salary_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary_txt.Location = New System.Drawing.Point(16, 94)
        Me.salary_txt.Multiline = True
        Me.salary_txt.Name = "salary_txt"
        Me.salary_txt.Size = New System.Drawing.Size(409, 40)
        Me.salary_txt.TabIndex = 45
        '
        'deducted_txt
        '
        Me.deducted_txt.Enabled = False
        Me.deducted_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deducted_txt.Location = New System.Drawing.Point(16, 336)
        Me.deducted_txt.Multiline = True
        Me.deducted_txt.Name = "deducted_txt"
        Me.deducted_txt.Size = New System.Drawing.Size(158, 48)
        Me.deducted_txt.TabIndex = 43
        '
        'percentage_txt
        '
        Me.percentage_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage_txt.Location = New System.Drawing.Point(16, 171)
        Me.percentage_txt.Multiline = True
        Me.percentage_txt.Name = "percentage_txt"
        Me.percentage_txt.Size = New System.Drawing.Size(409, 42)
        Me.percentage_txt.TabIndex = 44
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(283, 233)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 59)
        Me.clear_btn.TabIndex = 42
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.calculate_btn.Location = New System.Drawing.Point(16, 233)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(249, 59)
        Me.calculate_btn.TabIndex = 41
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 23)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Percentage Deducted (%)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 39)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Enter the Rate (%)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Enter the Staff's Salary (#)"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 35)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Calc Staff Salary"
        '
        'balance_txt
        '
        Me.balance_txt.Enabled = False
        Me.balance_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balance_txt.Location = New System.Drawing.Point(267, 336)
        Me.balance_txt.Multiline = True
        Me.balance_txt.Name = "balance_txt"
        Me.balance_txt.Size = New System.Drawing.Size(158, 48)
        Me.balance_txt.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 23)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Balance After (#)"
        '
        'secondno_txt
        '
        Me.secondno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondno_txt.Location = New System.Drawing.Point(16, 171)
        Me.secondno_txt.Multiline = True
        Me.secondno_txt.Name = "secondno_txt"
        Me.secondno_txt.Size = New System.Drawing.Size(409, 42)
        Me.secondno_txt.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(453, 411)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.salary_txt)
        Me.Controls.Add(Me.balance_txt)
        Me.Controls.Add(Me.deducted_txt)
        Me.Controls.Add(Me.percentage_txt)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents salary_txt As System.Windows.Forms.TextBox
    Friend WithEvents deducted_txt As System.Windows.Forms.TextBox
    Friend WithEvents percentage_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents balance_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents secondno_txt As System.Windows.Forms.TextBox

End Class
