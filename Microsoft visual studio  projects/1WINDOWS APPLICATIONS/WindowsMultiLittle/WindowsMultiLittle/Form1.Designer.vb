<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffsSalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FactoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBackspace = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnNo7 = New System.Windows.Forms.Button()
        Me.btnNo8 = New System.Windows.Forms.Button()
        Me.btnNo9 = New System.Windows.Forms.Button()
        Me.btnNo4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnNegate = New System.Windows.Forms.Button()
        Me.btnNoplus = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnSignh = New System.Windows.Forms.Button()
        Me.BtnSqrt = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.btnCosh = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnTanh = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.btnBin = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.btnTan = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnHex = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.btnOct = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBoxResults = New System.Windows.Forms.ListBox()
        Me.Clear_txt = New System.Windows.Forms.Button()
        Me.calc_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.fac_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.calculate_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.salary_txt = New System.Windows.Forms.TextBox()
        Me.percentage_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.balance_txt = New System.Windows.Forms.TextBox()
        Me.deducted_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.BackColor = System.Drawing.Color.White
        Me.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(24, 50)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(278, 57)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.Text = "0"
        Me.txtDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1378, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.StaffsSalaryToolStripMenuItem, Me.FactoriaToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'StaffsSalaryToolStripMenuItem
        '
        Me.StaffsSalaryToolStripMenuItem.Name = "StaffsSalaryToolStripMenuItem"
        Me.StaffsSalaryToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.StaffsSalaryToolStripMenuItem.Text = "Staff's Salary"
        '
        'FactoriaToolStripMenuItem
        '
        Me.FactoriaToolStripMenuItem.Name = "FactoriaToolStripMenuItem"
        Me.FactoriaToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.FactoriaToolStripMenuItem.Text = "Factoria"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'btnBackspace
        '
        Me.btnBackspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackspace.Location = New System.Drawing.Point(24, 120)
        Me.btnBackspace.Name = "btnBackspace"
        Me.btnBackspace.Size = New System.Drawing.Size(71, 53)
        Me.btnBackspace.TabIndex = 2
        Me.btnBackspace.Text = "Backspace"
        Me.btnBackspace.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(92, 120)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(71, 53)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "CE"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(161, 120)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(71, 53)
        Me.btnClr.TabIndex = 2
        Me.btnClr.Text = "C"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnNo7
        '
        Me.btnNo7.Location = New System.Drawing.Point(24, 175)
        Me.btnNo7.Name = "btnNo7"
        Me.btnNo7.Size = New System.Drawing.Size(71, 53)
        Me.btnNo7.TabIndex = 2
        Me.btnNo7.Text = "7"
        Me.btnNo7.UseVisualStyleBackColor = True
        '
        'btnNo8
        '
        Me.btnNo8.Location = New System.Drawing.Point(92, 175)
        Me.btnNo8.Name = "btnNo8"
        Me.btnNo8.Size = New System.Drawing.Size(71, 53)
        Me.btnNo8.TabIndex = 2
        Me.btnNo8.Text = "8"
        Me.btnNo8.UseVisualStyleBackColor = True
        '
        'btnNo9
        '
        Me.btnNo9.Location = New System.Drawing.Point(161, 175)
        Me.btnNo9.Name = "btnNo9"
        Me.btnNo9.Size = New System.Drawing.Size(71, 53)
        Me.btnNo9.TabIndex = 2
        Me.btnNo9.Text = "9"
        Me.btnNo9.UseVisualStyleBackColor = True
        '
        'btnNo4
        '
        Me.btnNo4.Location = New System.Drawing.Point(24, 229)
        Me.btnNo4.Name = "btnNo4"
        Me.btnNo4.Size = New System.Drawing.Size(71, 53)
        Me.btnNo4.TabIndex = 2
        Me.btnNo4.Text = "4"
        Me.btnNo4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(92, 229)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(71, 53)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "5"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(161, 229)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(71, 53)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "6"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(24, 285)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(71, 53)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "1"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(92, 285)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(71, 53)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "2"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(161, 285)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(71, 53)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "3"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(24, 339)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(71, 53)
        Me.Button13.TabIndex = 2
        Me.Button13.Text = "0"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(92, 339)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(71, 53)
        Me.btnDot.TabIndex = 2
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(161, 339)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(71, 53)
        Me.btnEquals.TabIndex = 2
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnNegate
        '
        Me.btnNegate.Location = New System.Drawing.Point(231, 120)
        Me.btnNegate.Name = "btnNegate"
        Me.btnNegate.Size = New System.Drawing.Size(71, 53)
        Me.btnNegate.TabIndex = 2
        Me.btnNegate.Text = "±"
        Me.btnNegate.UseVisualStyleBackColor = True
        '
        'btnNoplus
        '
        Me.btnNoplus.Location = New System.Drawing.Point(231, 175)
        Me.btnNoplus.Name = "btnNoplus"
        Me.btnNoplus.Size = New System.Drawing.Size(71, 53)
        Me.btnNoplus.TabIndex = 2
        Me.btnNoplus.Text = "+"
        Me.btnNoplus.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(231, 229)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(71, 53)
        Me.Button18.TabIndex = 2
        Me.Button18.Text = "-"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(231, 285)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(71, 53)
        Me.Button19.TabIndex = 2
        Me.Button19.Text = "*"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(231, 339)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(71, 53)
        Me.Button20.TabIndex = 2
        Me.Button20.Text = "/"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPi.Location = New System.Drawing.Point(321, 120)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(71, 53)
        Me.btnPi.TabIndex = 2
        Me.btnPi.Text = "π"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(389, 120)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(71, 53)
        Me.btnLog.TabIndex = 2
        Me.btnLog.Text = "Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnSignh
        '
        Me.btnSignh.Location = New System.Drawing.Point(321, 175)
        Me.btnSignh.Name = "btnSignh"
        Me.btnSignh.Size = New System.Drawing.Size(71, 53)
        Me.btnSignh.TabIndex = 2
        Me.btnSignh.Text = "Sinh"
        Me.btnSignh.UseVisualStyleBackColor = True
        '
        'BtnSqrt
        '
        Me.BtnSqrt.Location = New System.Drawing.Point(458, 120)
        Me.BtnSqrt.Name = "BtnSqrt"
        Me.BtnSqrt.Size = New System.Drawing.Size(71, 53)
        Me.BtnSqrt.TabIndex = 2
        Me.BtnSqrt.Text = "Sqrt"
        Me.BtnSqrt.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(528, 120)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(71, 53)
        Me.Button25.TabIndex = 2
        Me.Button25.Text = "x²"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'btnCosh
        '
        Me.btnCosh.Location = New System.Drawing.Point(321, 229)
        Me.btnCosh.Name = "btnCosh"
        Me.btnCosh.Size = New System.Drawing.Size(71, 53)
        Me.btnCosh.TabIndex = 2
        Me.btnCosh.Text = "Cosh"
        Me.btnCosh.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Location = New System.Drawing.Point(389, 175)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(71, 53)
        Me.btnSin.TabIndex = 2
        Me.btnSin.Text = "Sin"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnTanh
        '
        Me.btnTanh.Location = New System.Drawing.Point(321, 285)
        Me.btnTanh.Name = "btnTanh"
        Me.btnTanh.Size = New System.Drawing.Size(71, 53)
        Me.btnTanh.TabIndex = 2
        Me.btnTanh.Text = "Tanh"
        Me.btnTanh.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(321, 339)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(71, 53)
        Me.btnExp.TabIndex = 2
        Me.btnExp.Text = "Exp"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(458, 175)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(71, 53)
        Me.Button30.TabIndex = 2
        Me.Button30.Text = "Dec"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(528, 175)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(71, 53)
        Me.Button31.TabIndex = 2
        Me.Button31.Text = "x^3"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Location = New System.Drawing.Point(389, 229)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(71, 53)
        Me.btnCos.TabIndex = 2
        Me.btnCos.Text = "Cos"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'btnBin
        '
        Me.btnBin.Location = New System.Drawing.Point(458, 229)
        Me.btnBin.Name = "btnBin"
        Me.btnBin.Size = New System.Drawing.Size(71, 53)
        Me.btnBin.TabIndex = 2
        Me.btnBin.Text = "Bin"
        Me.btnBin.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(528, 229)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(71, 53)
        Me.Button34.TabIndex = 2
        Me.Button34.Text = "1/x"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'btnTan
        '
        Me.btnTan.Location = New System.Drawing.Point(389, 285)
        Me.btnTan.Name = "btnTan"
        Me.btnTan.Size = New System.Drawing.Size(71, 53)
        Me.btnTan.TabIndex = 2
        Me.btnTan.Text = "Tan"
        Me.btnTan.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(389, 339)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(71, 53)
        Me.btnMod.TabIndex = 2
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnHex
        '
        Me.btnHex.Location = New System.Drawing.Point(458, 285)
        Me.btnHex.Name = "btnHex"
        Me.btnHex.Size = New System.Drawing.Size(71, 53)
        Me.btnHex.TabIndex = 2
        Me.btnHex.Text = "Hex"
        Me.btnHex.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Location = New System.Drawing.Point(528, 285)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(71, 53)
        Me.Button38.TabIndex = 2
        Me.Button38.Text = "In x"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'btnOct
        '
        Me.btnOct.Location = New System.Drawing.Point(458, 339)
        Me.btnOct.Name = "btnOct"
        Me.btnOct.Size = New System.Drawing.Size(71, 53)
        Me.btnOct.TabIndex = 2
        Me.btnOct.Text = "Oct"
        Me.btnOct.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Location = New System.Drawing.Point(528, 339)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(71, 53)
        Me.btnPercent.TabIndex = 2
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(601, 362)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'ListBoxResults
        '
        Me.ListBoxResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxResults.FormattingEnabled = True
        Me.ListBoxResults.ItemHeight = 18
        Me.ListBoxResults.Location = New System.Drawing.Point(27, 216)
        Me.ListBoxResults.Name = "ListBoxResults"
        Me.ListBoxResults.Size = New System.Drawing.Size(241, 130)
        Me.ListBoxResults.TabIndex = 69
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Factorial Results."
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox5.Controls.Add(Me.ListBoxResults)
        Me.GroupBox5.Controls.Add(Me.Clear_txt)
        Me.GroupBox5.Controls.Add(Me.calc_btn)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.fac_txt)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(1071, 50)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 354)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Factorial Of"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Input Number. (1 - 11)"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(726, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 35)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Calc Staff Salary"
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.White
        Me.clear_btn.Location = New System.Drawing.Point(288, 181)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 48)
        Me.clear_btn.TabIndex = 53
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'calculate_btn
        '
        Me.calculate_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calculate_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.calculate_btn.Location = New System.Drawing.Point(21, 181)
        Me.calculate_btn.Name = "calculate_btn"
        Me.calculate_btn.Size = New System.Drawing.Size(230, 48)
        Me.calculate_btn.TabIndex = 52
        Me.calculate_btn.Text = "CALCULATE"
        Me.calculate_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(293, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Enter the Rate (%)"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(293, 29)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Enter the Staff's Salary (#)"
        '
        'salary_txt
        '
        Me.salary_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary_txt.Location = New System.Drawing.Point(21, 49)
        Me.salary_txt.Multiline = True
        Me.salary_txt.Name = "salary_txt"
        Me.salary_txt.Size = New System.Drawing.Size(382, 46)
        Me.salary_txt.TabIndex = 61
        '
        'percentage_txt
        '
        Me.percentage_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage_txt.Location = New System.Drawing.Point(21, 125)
        Me.percentage_txt.Multiline = True
        Me.percentage_txt.Name = "percentage_txt"
        Me.percentage_txt.Size = New System.Drawing.Size(382, 46)
        Me.percentage_txt.TabIndex = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.balance_txt)
        Me.GroupBox1.Controls.Add(Me.deducted_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.percentage_txt)
        Me.GroupBox1.Controls.Add(Me.salary_txt)
        Me.GroupBox1.Controls.Add(Me.clear_btn)
        Me.GroupBox1.Controls.Add(Me.calculate_btn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(627, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 325)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate"
        '
        'balance_txt
        '
        Me.balance_txt.Location = New System.Drawing.Point(258, 269)
        Me.balance_txt.Multiline = True
        Me.balance_txt.Name = "balance_txt"
        Me.balance_txt.Size = New System.Drawing.Size(145, 39)
        Me.balance_txt.TabIndex = 65
        '
        'deducted_txt
        '
        Me.deducted_txt.Location = New System.Drawing.Point(21, 269)
        Me.deducted_txt.Multiline = True
        Me.deducted_txt.Name = "deducted_txt"
        Me.deducted_txt.Size = New System.Drawing.Size(145, 39)
        Me.deducted_txt.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Balance After (N)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Percentage Deducted (%)"
        '
        'txtShow
        '
        Me.txtShow.Enabled = False
        Me.txtShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShow.Location = New System.Drawing.Point(53, 53)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(51, 23)
        Me.txtShow.TabIndex = 64
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 481)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.btnOct)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.btnHex)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.btnTan)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.btnBin)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.btnNoplus)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnNo9)
        Me.Controls.Add(Me.btnTanh)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.btnCosh)
        Me.Controls.Add(Me.btnNo8)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.btnNo4)
        Me.Controls.Add(Me.BtnSqrt)
        Me.Controls.Add(Me.btnNegate)
        Me.Controls.Add(Me.btnSignh)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnNo7)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnBackspace)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplay As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBackspace As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnClr As System.Windows.Forms.Button
    Friend WithEvents btnNo7 As System.Windows.Forms.Button
    Friend WithEvents btnNo8 As System.Windows.Forms.Button
    Friend WithEvents btnNo9 As System.Windows.Forms.Button
    Friend WithEvents btnNo4 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnNegate As System.Windows.Forms.Button
    Friend WithEvents btnNoplus As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents btnPi As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnSignh As System.Windows.Forms.Button
    Friend WithEvents BtnSqrt As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents btnCosh As System.Windows.Forms.Button
    Friend WithEvents btnSin As System.Windows.Forms.Button
    Friend WithEvents btnTanh As System.Windows.Forms.Button
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents btnCos As System.Windows.Forms.Button
    Friend WithEvents btnBin As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents btnTan As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents btnHex As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents btnOct As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxResults As System.Windows.Forms.ListBox
    Friend WithEvents Clear_txt As System.Windows.Forms.Button
    Friend WithEvents calc_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents fac_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FactoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffsSalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents calculate_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents salary_txt As System.Windows.Forms.TextBox
    Friend WithEvents percentage_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents balance_txt As System.Windows.Forms.TextBox
    Friend WithEvents deducted_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShow As System.Windows.Forms.TextBox

End Class
