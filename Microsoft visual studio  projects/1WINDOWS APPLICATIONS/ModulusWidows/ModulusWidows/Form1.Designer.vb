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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Firstno_txt = New System.Windows.Forms.TextBox()
        Me.Secondno_txt = New System.Windows.Forms.TextBox()
        Me.Clear_txt = New System.Windows.Forms.Button()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.results = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MODUSOFT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input the First Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input the Second Number"
        '
        'Firstno_txt
        '
        Me.Firstno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstno_txt.Location = New System.Drawing.Point(42, 125)
        Me.Firstno_txt.Multiline = True
        Me.Firstno_txt.Name = "Firstno_txt"
        Me.Firstno_txt.Size = New System.Drawing.Size(244, 42)
        Me.Firstno_txt.TabIndex = 3
        '
        'Secondno_txt
        '
        Me.Secondno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Secondno_txt.Location = New System.Drawing.Point(42, 201)
        Me.Secondno_txt.Multiline = True
        Me.Secondno_txt.Name = "Secondno_txt"
        Me.Secondno_txt.Size = New System.Drawing.Size(244, 48)
        Me.Secondno_txt.TabIndex = 3
        '
        'Clear_txt
        '
        Me.Clear_txt.BackColor = System.Drawing.Color.Red
        Me.Clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_txt.FlatAppearance.BorderSize = 0
        Me.Clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_txt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_txt.ForeColor = System.Drawing.Color.White
        Me.Clear_txt.Location = New System.Drawing.Point(205, 270)
        Me.Clear_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Clear_txt.Name = "Clear_txt"
        Me.Clear_txt.Size = New System.Drawing.Size(81, 48)
        Me.Clear_txt.TabIndex = 70
        Me.Clear_txt.Text = "CLEAR"
        Me.Clear_txt.UseVisualStyleBackColor = False
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.calc_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calc_btn.FlatAppearance.BorderSize = 0
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn.ForeColor = System.Drawing.Color.White
        Me.calc_btn.Location = New System.Drawing.Point(42, 270)
        Me.calc_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(142, 48)
        Me.calc_btn.TabIndex = 69
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'results
        '
        Me.results.Location = New System.Drawing.Point(43, 355)
        Me.results.Multiline = True
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(243, 53)
        Me.results.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Location = New System.Drawing.Point(30, 335)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 87)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 256)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MOD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 477)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.Clear_txt)
        Me.Controls.Add(Me.calc_btn)
        Me.Controls.Add(Me.Secondno_txt)
        Me.Controls.Add(Me.Firstno_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Firstno_txt As System.Windows.Forms.TextBox
    Friend WithEvents Secondno_txt As System.Windows.Forms.TextBox
    Friend WithEvents Clear_txt As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents results As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
