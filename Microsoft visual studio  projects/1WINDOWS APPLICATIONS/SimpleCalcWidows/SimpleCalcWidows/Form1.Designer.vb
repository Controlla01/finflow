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
        Me.firstno_txt = New System.Windows.Forms.TextBox()
        Me.secondno_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.fraction_btn = New System.Windows.Forms.Button()
        Me.product_btn = New System.Windows.Forms.Button()
        Me.difference_btn = New System.Windows.Forms.Button()
        Me.operator_label = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.summation_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstno_txt
        '
        Me.firstno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstno_txt.Location = New System.Drawing.Point(29, 124)
        Me.firstno_txt.Multiline = True
        Me.firstno_txt.Name = "firstno_txt"
        Me.firstno_txt.Size = New System.Drawing.Size(249, 52)
        Me.firstno_txt.TabIndex = 37
        '
        'secondno_txt
        '
        Me.secondno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondno_txt.Location = New System.Drawing.Point(29, 272)
        Me.secondno_txt.Multiline = True
        Me.secondno_txt.Name = "secondno_txt"
        Me.secondno_txt.Size = New System.Drawing.Size(249, 51)
        Me.secondno_txt.TabIndex = 36
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(286, 442)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 51)
        Me.clear_btn.TabIndex = 35
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.calc_btn.Location = New System.Drawing.Point(29, 341)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(249, 59)
        Me.calc_btn.TabIndex = 34
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "RESULTS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 39)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Enter the second Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 29)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Enter the first Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 34)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "SIMPLE CALULATOR"
        '
        'result_txt
        '
        Me.result_txt.Enabled = False
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(29, 442)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(249, 51)
        Me.result_txt.TabIndex = 36
        '
        'fraction_btn
        '
        Me.fraction_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.fraction_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraction_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraction_btn.ForeColor = System.Drawing.Color.White
        Me.fraction_btn.Location = New System.Drawing.Point(320, 125)
        Me.fraction_btn.Name = "fraction_btn"
        Me.fraction_btn.Size = New System.Drawing.Size(81, 51)
        Me.fraction_btn.TabIndex = 38
        Me.fraction_btn.Text = "/"
        Me.fraction_btn.UseVisualStyleBackColor = False
        '
        'product_btn
        '
        Me.product_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.product_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_btn.ForeColor = System.Drawing.Color.White
        Me.product_btn.Location = New System.Drawing.Point(320, 187)
        Me.product_btn.Name = "product_btn"
        Me.product_btn.Size = New System.Drawing.Size(81, 50)
        Me.product_btn.TabIndex = 39
        Me.product_btn.Text = "*"
        Me.product_btn.UseVisualStyleBackColor = False
        '
        'difference_btn
        '
        Me.difference_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.difference_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.difference_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difference_btn.ForeColor = System.Drawing.Color.White
        Me.difference_btn.Location = New System.Drawing.Point(320, 252)
        Me.difference_btn.Name = "difference_btn"
        Me.difference_btn.Size = New System.Drawing.Size(81, 50)
        Me.difference_btn.TabIndex = 39
        Me.difference_btn.Text = "-"
        Me.difference_btn.UseVisualStyleBackColor = False
        '
        'operator_label
        '
        Me.operator_label.Enabled = False
        Me.operator_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operator_label.Location = New System.Drawing.Point(74, 187)
        Me.operator_label.Name = "operator_label"
        Me.operator_label.Size = New System.Drawing.Size(81, 50)
        Me.operator_label.TabIndex = 39
        Me.operator_label.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(320, 317)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 83)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Button2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'summation_btn
        '
        Me.summation_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.summation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.summation_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summation_btn.ForeColor = System.Drawing.Color.White
        Me.summation_btn.Location = New System.Drawing.Point(320, 317)
        Me.summation_btn.Name = "summation_btn"
        Me.summation_btn.Size = New System.Drawing.Size(81, 83)
        Me.summation_btn.TabIndex = 39
        Me.summation_btn.Text = "+"
        Me.summation_btn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(320, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 50)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Button2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 507)
        Me.Controls.Add(Me.summation_btn)
        Me.Controls.Add(Me.operator_label)
        Me.Controls.Add(Me.difference_btn)
        Me.Controls.Add(Me.product_btn)
        Me.Controls.Add(Me.fraction_btn)
        Me.Controls.Add(Me.firstno_txt)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.secondno_txt)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calc_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstno_txt As System.Windows.Forms.TextBox
    Friend WithEvents secondno_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents fraction_btn As System.Windows.Forms.Button
    Friend WithEvents product_btn As System.Windows.Forms.Button
    Friend WithEvents difference_btn As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents operator_label As System.Windows.Forms.Button
    Friend WithEvents summation_btn As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
