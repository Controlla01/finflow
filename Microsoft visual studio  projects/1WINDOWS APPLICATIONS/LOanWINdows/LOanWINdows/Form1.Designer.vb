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
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.txtLoanTerm = New System.Windows.Forms.TextBox()
        Me.btnCalculateLoan = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.lstPaymentSchedule = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalInterest = New System.Windows.Forms.TextBox()
        Me.TotalPrincipalReturnn = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOAN APP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the Loan Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter the Loan Duration"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(13, 42)
        Me.txtLoanAmount.Multiline = True
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(213, 50)
        Me.txtLoanAmount.TabIndex = 3
        '
        'txtLoanTerm
        '
        Me.txtLoanTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanTerm.Location = New System.Drawing.Point(299, 42)
        Me.txtLoanTerm.Multiline = True
        Me.txtLoanTerm.Name = "txtLoanTerm"
        Me.txtLoanTerm.Size = New System.Drawing.Size(213, 50)
        Me.txtLoanTerm.TabIndex = 3
        '
        'btnCalculateLoan
        '
        Me.btnCalculateLoan.BackColor = System.Drawing.Color.LightGray
        Me.btnCalculateLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculateLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateLoan.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateLoan.ForeColor = System.Drawing.Color.Black
        Me.btnCalculateLoan.Location = New System.Drawing.Point(53, 193)
        Me.btnCalculateLoan.Name = "btnCalculateLoan"
        Me.btnCalculateLoan.Size = New System.Drawing.Size(298, 59)
        Me.btnCalculateLoan.TabIndex = 51
        Me.btnCalculateLoan.Text = "CALCULATE"
        Me.btnCalculateLoan.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Red
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(390, 193)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(162, 59)
        Me.Button10.TabIndex = 52
        Me.Button10.Text = "CLEAR"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'lstPaymentSchedule
        '
        Me.lstPaymentSchedule.FormattingEnabled = True
        Me.lstPaymentSchedule.ItemHeight = 16
        Me.lstPaymentSchedule.Location = New System.Drawing.Point(53, 284)
        Me.lstPaymentSchedule.Name = "lstPaymentSchedule"
        Me.lstPaymentSchedule.Size = New System.Drawing.Size(499, 148)
        Me.lstPaymentSchedule.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Total Interest"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(335, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 21)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Total Principal Return"
        '
        'TotalInterest
        '
        Me.TotalInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalInterest.Location = New System.Drawing.Point(53, 472)
        Me.TotalInterest.Multiline = True
        Me.TotalInterest.Name = "TotalInterest"
        Me.TotalInterest.Size = New System.Drawing.Size(213, 50)
        Me.TotalInterest.TabIndex = 3
        '
        'TotalPrincipalReturnn
        '
        Me.TotalPrincipalReturnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPrincipalReturnn.Location = New System.Drawing.Point(339, 472)
        Me.TotalPrincipalReturnn.Multiline = True
        Me.TotalPrincipalReturnn.Name = "TotalPrincipalReturnn"
        Me.TotalPrincipalReturnn.Size = New System.Drawing.Size(213, 50)
        Me.TotalPrincipalReturnn.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtLoanTerm)
        Me.GroupBox1.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 102)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUTS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(40, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 270)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OUTPUTS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(596, 564)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstPaymentSchedule)
        Me.Controls.Add(Me.btnCalculateLoan)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TotalPrincipalReturnn)
        Me.Controls.Add(Me.TotalInterest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanTerm As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateLoan As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents lstPaymentSchedule As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalInterest As System.Windows.Forms.TextBox
    Friend WithEvents TotalPrincipalReturnn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
