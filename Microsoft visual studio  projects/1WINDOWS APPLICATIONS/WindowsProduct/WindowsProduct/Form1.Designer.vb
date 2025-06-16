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
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.results_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.secondno_txt = New System.Windows.Forms.TextBox()
        Me.firstno_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.clear_btn.Location = New System.Drawing.Point(341, 386)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 55)
        Me.clear_btn.TabIndex = 17
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.calc_btn.Location = New System.Drawing.Point(36, 382)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(148, 59)
        Me.calc_btn.TabIndex = 16
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'results_txt
        '
        Me.results_txt.Enabled = False
        Me.results_txt.Location = New System.Drawing.Point(341, 221)
        Me.results_txt.Multiline = True
        Me.results_txt.Name = "results_txt"
        Me.results_txt.Size = New System.Drawing.Size(115, 59)
        Me.results_txt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "RESULTS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 39)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Enter the second Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter the first Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Product of Two Numbers"
        '
        'secondno_txt
        '
        Me.secondno_txt.Location = New System.Drawing.Point(35, 287)
        Me.secondno_txt.Multiline = True
        Me.secondno_txt.Name = "secondno_txt"
        Me.secondno_txt.Size = New System.Drawing.Size(216, 51)
        Me.secondno_txt.TabIndex = 18
        '
        'firstno_txt
        '
        Me.firstno_txt.Location = New System.Drawing.Point(35, 170)
        Me.firstno_txt.Multiline = True
        Me.firstno_txt.Name = "firstno_txt"
        Me.firstno_txt.Size = New System.Drawing.Size(216, 52)
        Me.firstno_txt.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(513, 480)
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
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents results_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents secondno_txt As System.Windows.Forms.TextBox
    Friend WithEvents firstno_txt As System.Windows.Forms.TextBox

End Class
