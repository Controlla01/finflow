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
        Me.FirstNo_txt = New System.Windows.Forms.TextBox()
        Me.SecondNo_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Result_txt = New System.Windows.Forms.TextBox()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(62, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Difference of Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(43, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the first Number"
        '
        'FirstNo_txt
        '
        Me.FirstNo_txt.Location = New System.Drawing.Point(46, 120)
        Me.FirstNo_txt.Multiline = True
        Me.FirstNo_txt.Name = "FirstNo_txt"
        Me.FirstNo_txt.Size = New System.Drawing.Size(244, 58)
        Me.FirstNo_txt.TabIndex = 2
        '
        'SecondNo_txt
        '
        Me.SecondNo_txt.Location = New System.Drawing.Point(46, 231)
        Me.SecondNo_txt.Multiline = True
        Me.SecondNo_txt.Name = "SecondNo_txt"
        Me.SecondNo_txt.Size = New System.Drawing.Size(243, 60)
        Me.SecondNo_txt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(43, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter the second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(43, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Results ="
        '
        'Result_txt
        '
        Me.Result_txt.Enabled = False
        Me.Result_txt.Location = New System.Drawing.Point(46, 344)
        Me.Result_txt.Multiline = True
        Me.Result_txt.Name = "Result_txt"
        Me.Result_txt.Size = New System.Drawing.Size(244, 71)
        Me.Result_txt.TabIndex = 6
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.calculate_btn.Location = New System.Drawing.Point(323, 246)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(155, 115)
        Me.calculate_btn.TabIndex = 7
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.clear_btn.Location = New System.Drawing.Point(334, 172)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(129, 38)
        Me.clear_btn.TabIndex = 8
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 436)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calculate_btn)
        Me.Controls.Add(Me.Result_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SecondNo_txt)
        Me.Controls.Add(Me.FirstNo_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FirstNo_txt As System.Windows.Forms.TextBox
    Friend WithEvents SecondNo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Result_txt As System.Windows.Forms.TextBox
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button

End Class
