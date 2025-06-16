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
        Me.fac_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Clear_txt = New System.Windows.Forms.Button()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.ListBoxResults = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTORIAL OF NUMBERS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input Number. (1 - 11)"
        '
        'fac_txt
        '
        Me.fac_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fac_txt.Location = New System.Drawing.Point(27, 52)
        Me.fac_txt.Multiline = True
        Me.fac_txt.Name = "fac_txt"
        Me.fac_txt.Size = New System.Drawing.Size(241, 51)
        Me.fac_txt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Factorial Results."
        '
        'Clear_txt
        '
        Me.Clear_txt.BackColor = System.Drawing.Color.Red
        Me.Clear_txt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear_txt.FlatAppearance.BorderSize = 0
        Me.Clear_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear_txt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_txt.ForeColor = System.Drawing.Color.White
        Me.Clear_txt.Location = New System.Drawing.Point(187, 116)
        Me.Clear_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Clear_txt.Name = "Clear_txt"
        Me.Clear_txt.Size = New System.Drawing.Size(81, 48)
        Me.Clear_txt.TabIndex = 68
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
        Me.calc_btn.Location = New System.Drawing.Point(27, 116)
        Me.calc_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calc_btn.Name = "calc_btn"
        Me.calc_btn.Size = New System.Drawing.Size(139, 48)
        Me.calc_btn.TabIndex = 67
        Me.calc_btn.Text = "CALCULATE"
        Me.calc_btn.UseVisualStyleBackColor = False
        '
        'ListBoxResults
        '
        Me.ListBoxResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxResults.FormattingEnabled = True
        Me.ListBoxResults.ItemHeight = 18
        Me.ListBoxResults.Location = New System.Drawing.Point(27, 216)
        Me.ListBoxResults.Name = "ListBoxResults"
        Me.ListBoxResults.Size = New System.Drawing.Size(241, 148)
        Me.ListBoxResults.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.ListBoxResults)
        Me.GroupBox1.Controls.Add(Me.Clear_txt)
        Me.GroupBox1.Controls.Add(Me.calc_btn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fac_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 381)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factorial Of"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 474)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fac_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Clear_txt As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents ListBoxResults As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
