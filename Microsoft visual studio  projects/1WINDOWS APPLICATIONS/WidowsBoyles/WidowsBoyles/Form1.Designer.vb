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
        Me.v1_txt = New System.Windows.Forms.TextBox()
        Me.p1_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.result_txt = New System.Windows.Forms.Button()
        Me.p1_radio = New System.Windows.Forms.RadioButton()
        Me.v1_radio = New System.Windows.Forms.RadioButton()
        Me.p2_radio = New System.Windows.Forms.RadioButton()
        Me.v2_radio = New System.Windows.Forms.RadioButton()
        Me.p2_txt = New System.Windows.Forms.TextBox()
        Me.v2_txt = New System.Windows.Forms.TextBox()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.Clear_txt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 32)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Boyle's Law Calculator "
        '
        'v1_txt
        '
        Me.v1_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1_txt.Location = New System.Drawing.Point(21, 132)
        Me.v1_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.v1_txt.Multiline = True
        Me.v1_txt.Name = "v1_txt"
        Me.v1_txt.Size = New System.Drawing.Size(235, 41)
        Me.v1_txt.TabIndex = 52
        '
        'p1_txt
        '
        Me.p1_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_txt.Location = New System.Drawing.Point(21, 49)
        Me.p1_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.p1_txt.Multiline = True
        Me.p1_txt.Name = "p1_txt"
        Me.p1_txt.Size = New System.Drawing.Size(235, 39)
        Me.p1_txt.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Input initial volume (V1)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 32)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Input initial Pressure(P1)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(274, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 26)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Input final pressure (P2)"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 26)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Input final volume (V2)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Results"
        '
        'result_txt
        '
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(26, 123)
        Me.result_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(458, 49)
        Me.result_txt.TabIndex = 58
        Me.result_txt.UseVisualStyleBackColor = True
        '
        'p1_radio
        '
        Me.p1_radio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.p1_radio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p1_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_radio.Location = New System.Drawing.Point(23, 27)
        Me.p1_radio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.p1_radio.Name = "p1_radio"
        Me.p1_radio.Size = New System.Drawing.Size(163, 26)
        Me.p1_radio.TabIndex = 59
        Me.p1_radio.TabStop = True
        Me.p1_radio.Text = "Initial Pressure (P1)"
        Me.p1_radio.UseVisualStyleBackColor = False
        '
        'v1_radio
        '
        Me.v1_radio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.v1_radio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.v1_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v1_radio.Location = New System.Drawing.Point(23, 58)
        Me.v1_radio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.v1_radio.Name = "v1_radio"
        Me.v1_radio.Size = New System.Drawing.Size(163, 39)
        Me.v1_radio.TabIndex = 60
        Me.v1_radio.TabStop = True
        Me.v1_radio.Text = "Initial Volume    (V1)"
        Me.v1_radio.UseVisualStyleBackColor = False
        '
        'p2_radio
        '
        Me.p2_radio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.p2_radio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p2_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_radio.Location = New System.Drawing.Point(23, 102)
        Me.p2_radio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.p2_radio.Name = "p2_radio"
        Me.p2_radio.Size = New System.Drawing.Size(163, 30)
        Me.p2_radio.TabIndex = 61
        Me.p2_radio.TabStop = True
        Me.p2_radio.Text = "Final Pressure  (P2)"
        Me.p2_radio.UseVisualStyleBackColor = False
        '
        'v2_radio
        '
        Me.v2_radio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.v2_radio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.v2_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2_radio.Location = New System.Drawing.Point(23, 136)
        Me.v2_radio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.v2_radio.Name = "v2_radio"
        Me.v2_radio.Size = New System.Drawing.Size(163, 36)
        Me.v2_radio.TabIndex = 62
        Me.v2_radio.TabStop = True
        Me.v2_radio.Text = "Final Volume     (V2)"
        Me.v2_radio.UseVisualStyleBackColor = False
        '
        'p2_txt
        '
        Me.p2_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2_txt.Location = New System.Drawing.Point(278, 49)
        Me.p2_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.p2_txt.Multiline = True
        Me.p2_txt.Name = "p2_txt"
        Me.p2_txt.Size = New System.Drawing.Size(234, 41)
        Me.p2_txt.TabIndex = 64
        '
        'v2_txt
        '
        Me.v2_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v2_txt.Location = New System.Drawing.Point(278, 132)
        Me.v2_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.v2_txt.Multiline = True
        Me.v2_txt.Name = "v2_txt"
        Me.v2_txt.Size = New System.Drawing.Size(234, 41)
        Me.v2_txt.TabIndex = 64
        '
        'calc_btn
        '
        Me.calc_btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.calc_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calc_btn.FlatAppearance.BorderSize = 0
        Me.calc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calc_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc_btn.ForeColor = System.Drawing.Color.White
        Me.calc_btn.Location = New System.Drawing.Point(26, 41)
        Me.calc_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(325, 48)
        Me.calc_btn.TabIndex = 65
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'Clear_txt
        '
        Me.Clear_txt.BackColor = System.Drawing.Color.Red
        Me.Clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_txt.FlatAppearance.BorderSize = 0
        Me.Clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_txt.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_txt.ForeColor = System.Drawing.Color.White
        Me.Clear_txt.Location = New System.Drawing.Point(378, 42)
        Me.Clear_txt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Clear_txt.Name = "Clear_txt"
        Me.Clear_txt.Size = New System.Drawing.Size(105, 46)
        Me.Clear_txt.TabIndex = 66
        Me.Clear_txt.Text = "CLEAR"
        Me.Clear_txt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.p1_txt)
        Me.GroupBox1.Controls.Add(Me.p2_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.v2_txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.v1_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(525, 193)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boyles Law"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.v2_radio)
        Me.GroupBox2.Controls.Add(Me.p2_radio)
        Me.GroupBox2.Controls.Add(Me.p1_radio)
        Me.GroupBox2.Controls.Add(Me.v1_radio)
        Me.GroupBox2.Location = New System.Drawing.Point(570, 61)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(216, 191)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Click to Select Choice"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Clear_txt)
        Me.GroupBox3.Controls.Add(Me.result_txt)
        Me.GroupBox3.Controls.Add(Me.calc_btn)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 263)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(525, 200)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculate"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(813, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents v1_txt As System.Windows.Forms.TextBox
    Friend WithEvents p1_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents result_txt As System.Windows.Forms.Button
    Friend WithEvents p1_radio As System.Windows.Forms.RadioButton
    Friend WithEvents v1_radio As System.Windows.Forms.RadioButton
    Friend WithEvents p2_radio As System.Windows.Forms.RadioButton
    Friend WithEvents v2_radio As System.Windows.Forms.RadioButton
    Friend WithEvents p2_txt As System.Windows.Forms.TextBox
    Friend WithEvents v2_txt As System.Windows.Forms.TextBox
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents Clear_txt As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
