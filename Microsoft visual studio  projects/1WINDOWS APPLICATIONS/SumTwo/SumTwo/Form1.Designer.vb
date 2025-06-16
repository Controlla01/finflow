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
        Me.FirstNo_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecondNo_txt = New System.Windows.Forms.TextBox()
        Me.Calculate_btn = New System.Windows.Forms.Button()
        Me.Result_txt = New System.Windows.Forms.TextBox()
        Me.Clear_txt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FirstNo_txt
        '
        Me.FirstNo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNo_txt.Location = New System.Drawing.Point(57, 132)
        Me.FirstNo_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstNo_txt.Multiline = True
        Me.FirstNo_txt.Name = "FirstNo_txt"
        Me.FirstNo_txt.Size = New System.Drawing.Size(226, 47)
        Me.FirstNo_txt.TabIndex = 0
        Me.FirstNo_txt.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(53, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Input First Number"
        Me.Label2.UseWaitCursor = True
        '
        'SecondNo_txt
        '
        Me.SecondNo_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNo_txt.Location = New System.Drawing.Point(55, 237)
        Me.SecondNo_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SecondNo_txt.Multiline = True
        Me.SecondNo_txt.Name = "SecondNo_txt"
        Me.SecondNo_txt.Size = New System.Drawing.Size(227, 49)
        Me.SecondNo_txt.TabIndex = 4
        Me.SecondNo_txt.UseWaitCursor = True
        '
        'Calculate_btn
        '
        Me.Calculate_btn.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Calculate_btn.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Calculate_btn.FlatAppearance.BorderSize = 0
        Me.Calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calculate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Calculate_btn.Location = New System.Drawing.Point(53, 328)
        Me.Calculate_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Calculate_btn.Name = "Calculate_btn"
        Me.Calculate_btn.Size = New System.Drawing.Size(360, 57)
        Me.Calculate_btn.TabIndex = 5
        Me.Calculate_btn.Text = "CALCULATE"
        Me.Calculate_btn.UseVisualStyleBackColor = False
        Me.Calculate_btn.UseWaitCursor = True
        '
        'Result_txt
        '
        Me.Result_txt.BackColor = System.Drawing.Color.White
        Me.Result_txt.Enabled = False
        Me.Result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result_txt.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Result_txt.Location = New System.Drawing.Point(321, 237)
        Me.Result_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Result_txt.Multiline = True
        Me.Result_txt.Name = "Result_txt"
        Me.Result_txt.Size = New System.Drawing.Size(204, 49)
        Me.Result_txt.TabIndex = 6
        Me.Result_txt.UseWaitCursor = True
        '
        'Clear_txt
        '
        Me.Clear_txt.BackColor = System.Drawing.Color.Red
        Me.Clear_txt.FlatAppearance.BorderSize = 0
        Me.Clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_txt.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_txt.ForeColor = System.Drawing.Color.White
        Me.Clear_txt.Location = New System.Drawing.Point(433, 329)
        Me.Clear_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Clear_txt.Name = "Clear_txt"
        Me.Clear_txt.Size = New System.Drawing.Size(92, 57)
        Me.Clear_txt.TabIndex = 8
        Me.Clear_txt.Text = "CLEAR"
        Me.Clear_txt.UseVisualStyleBackColor = False
        Me.Clear_txt.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(50, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(422, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Summation Of Two Numbers"
        Me.Label5.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(53, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Input Second Number"
        Me.Label6.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(317, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Result"
        Me.Label3.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(579, 436)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Clear_txt)
        Me.Controls.Add(Me.Result_txt)
        Me.Controls.Add(Me.Calculate_btn)
        Me.Controls.Add(Me.SecondNo_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNo_txt)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Calulator"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstNo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SecondNo_txt As System.Windows.Forms.TextBox
    Friend WithEvents Calculate_btn As System.Windows.Forms.Button
    Friend WithEvents Result_txt As System.Windows.Forms.TextBox
    Friend WithEvents Clear_txt As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
