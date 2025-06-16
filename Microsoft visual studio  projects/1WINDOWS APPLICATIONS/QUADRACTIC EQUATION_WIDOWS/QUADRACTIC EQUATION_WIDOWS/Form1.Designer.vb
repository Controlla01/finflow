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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstno_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.secondno_txt = New System.Windows.Forms.TextBox()
        Me.Thirdno_txt = New System.Windows.Forms.TextBox()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.Results1_txt = New System.Windows.Forms.TextBox()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Results2_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUADRACTIC EQUATION"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input the First Number"
        '
        'firstno_txt
        '
        Me.firstno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstno_txt.Location = New System.Drawing.Point(38, 105)
        Me.firstno_txt.Multiline = True
        Me.firstno_txt.Name = "firstno_txt"
        Me.firstno_txt.Size = New System.Drawing.Size(340, 48)
        Me.firstno_txt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Input the Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Input the Third Number"
        '
        'secondno_txt
        '
        Me.secondno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondno_txt.Location = New System.Drawing.Point(38, 192)
        Me.secondno_txt.Multiline = True
        Me.secondno_txt.Name = "secondno_txt"
        Me.secondno_txt.Size = New System.Drawing.Size(340, 48)
        Me.secondno_txt.TabIndex = 5
        '
        'Thirdno_txt
        '
        Me.Thirdno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thirdno_txt.Location = New System.Drawing.Point(38, 281)
        Me.Thirdno_txt.Multiline = True
        Me.Thirdno_txt.Name = "Thirdno_txt"
        Me.Thirdno_txt.Size = New System.Drawing.Size(340, 48)
        Me.Thirdno_txt.TabIndex = 6
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Location = New System.Drawing.Point(38, 351)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(340, 48)
        Me.calc_btn.TabIndex = 7
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'Results1_txt
        '
        Me.Results1_txt.Enabled = False
        Me.Results1_txt.Location = New System.Drawing.Point(40, 427)
        Me.Results1_txt.Multiline = True
        Me.Results1_txt.Name = "Results1_txt"
        Me.Results1_txt.Size = New System.Drawing.Size(198, 39)
        Me.Results1_txt.TabIndex = 8
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Location = New System.Drawing.Point(282, 427)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(96, 70)
        Me.clear_btn.TabIndex = 9
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Results2_txt
        '
        Me.Results2_txt.Enabled = False
        Me.Results2_txt.Location = New System.Drawing.Point(38, 500)
        Me.Results2_txt.Multiline = True
        Me.Results2_txt.Name = "Results2_txt"
        Me.Results2_txt.Size = New System.Drawing.Size(200, 39)
        Me.Results2_txt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "X1 -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "X2 -"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 558)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Results2_txt)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Results1_txt)
        Me.Controls.Add(Me.calc_btn)
        Me.Controls.Add(Me.Thirdno_txt)
        Me.Controls.Add(Me.secondno_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstno_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents firstno_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents secondno_txt As System.Windows.Forms.TextBox
    Friend WithEvents Thirdno_txt As System.Windows.Forms.TextBox
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents Results1_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Results2_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
