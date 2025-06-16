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
        Me.results_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstno_txt
        '
        Me.firstno_txt.Location = New System.Drawing.Point(40, 111)
        Me.firstno_txt.Multiline = True
        Me.firstno_txt.Name = "firstno_txt"
        Me.firstno_txt.Size = New System.Drawing.Size(249, 52)
        Me.firstno_txt.TabIndex = 28
        '
        'secondno_txt
        '
        Me.secondno_txt.Location = New System.Drawing.Point(40, 222)
        Me.secondno_txt.Multiline = True
        Me.secondno_txt.Name = "secondno_txt"
        Me.secondno_txt.Size = New System.Drawing.Size(249, 51)
        Me.secondno_txt.TabIndex = 27
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(230, 405)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 55)
        Me.clear_btn.TabIndex = 26
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.calc_btn.Location = New System.Drawing.Point(40, 298)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(249, 53)
        Me.calc_btn.TabIndex = 25
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'results_txt
        '
        Me.results_txt.Enabled = False
        Me.results_txt.Location = New System.Drawing.Point(40, 405)
        Me.results_txt.Multiline = True
        Me.results_txt.Name = "results_txt"
        Me.results_txt.Size = New System.Drawing.Size(115, 59)
        Me.results_txt.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "RESULTS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 39)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Enter the second Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter the first Number"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 36)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fraction of Two Numbers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 489)
        Me.Controls.Add(Me.firstno_txt)
        Me.Controls.Add(Me.secondno_txt)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.calc_btn)
        Me.Controls.Add(Me.results_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstno_txt As System.Windows.Forms.TextBox
    Friend WithEvents secondno_txt As System.Windows.Forms.TextBox
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents results_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
