Public Class Calculator
    Dim firstnum, secondnum, answer As Double
    Dim opera As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 255
        txtDisplay.Width = 215
        Me.Text = "Standard Calculator"

    End Sub

    Private Sub ScientificToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 480
        txtDisplay.Width = 400
        Me.Text = "Scientific Calculator"
        GroupBox4.Location = New Point(190, 20)
    End Sub

    Private Sub FactoriaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactoriaToolStripMenuItem.Click
        Me.Width = 750
        txtDisplay.Width = 400
        Me.Text = "Factoria of Numbers"
        GroupBox5.Location = New Point(490, 20)
        GroupBox5.Width = 490
        GroupBox5.Height = 310

        GroupBox5.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub StaffsSalaryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffsSalaryToolStripMenuItem.Click
        Me.Width = 835
        txtDisplay.Width = 400
        Me.Text = "Staff's Salary"
        GroupBox1.Location = New Point(490, 20)
        GroupBox1.Width = 406
        GroupBox1.Height = 310

        GroupBox5.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub button_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button8.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, btnNo9.Click, btnNo8.Click, btnNo7.Click, btnNo4.Click
        Dim b As Button = sender

        If txtDisplay.Text = "0" Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub Arithmetic_Operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click, Button19.Click, Button18.Click, btnNoplus.Click, btnMod.Click, btnExp.Click
        Dim ops As Button = sender

        firstnum = txtDisplay.Text
        txtShow.Text = txtDisplay.Text
        txtDisplay.Text = ""
        opera = ops.Text
        txtShow.Text = txtShow.Text + " " + opera

    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        secondnum = txtDisplay.Text

        secondnum = txtDisplay.Text

        Select Case opera
            Case "+"
                answer = firstnum + secondnum
            Case "-"
                answer = firstnum - secondnum
            Case "*"
                answer = firstnum * secondnum
            Case "/"
                If secondnum <> 0 Then
                    answer = firstnum / secondnum
                Else
                    MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Case "Mod"
                answer = firstnum Mod secondnum
            Case "Exp"
                answer = firstnum ^ secondnum
            Case Else
                MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select


        txtDisplay.Text = answer
        txtShow.Text = ""
    End Sub

    Private Sub btnBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDot.Click
        If InStr(txtDisplay.Text, ".") = 0 Then
            txtDisplay.Text = txtDisplay.Text + "."
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        txtDisplay.Text = "0"
        txtShow.Text = ""
    End Sub

    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        txtDisplay.Text = "0"
        txtShow.Text = ""
    End Sub

    Private Sub btnNegate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegate.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub

    Private Sub btnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        txtDisplay.Text = "3.141592653589976323"
    End Sub

    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click
        Dim iLog As Double

        iLog = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
        iLog = Math.Log10(iLog)
        txtDisplay.Text = System.Convert.ToString(iLog)
    End Sub

    Private Sub BtnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSqrt.Click
        Dim iSqrt As Double

        iSqrt = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")")
        iSqrt = Math.Sqrt(iSqrt)
        txtDisplay.Text = System.Convert.ToString(iSqrt)
    End Sub

    Private Sub btnSignh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignh.Click
        Dim iSinh As Double

        iSinh = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")")
        iSinh = Math.Sinh(iSinh)
        txtDisplay.Text = System.Convert.ToString(iSinh)
    End Sub

    Private Sub btnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        Dim iSin As Double

        iSin = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")")
        iSin = Math.Sin(iSin)
        txtDisplay.Text = System.Convert.ToString(iSin)
    End Sub

    Private Sub btnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click
        Dim iCos As Double

        iCos = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")")
        iCos = Math.Cos(iCos)
        txtDisplay.Text = System.Convert.ToString(iCos)
    End Sub

    Private Sub btnCosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCosh.Click
        Dim iCosh As Double

        iCosh = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")")
        iCosh = Math.Cosh(iCosh)
        txtDisplay.Text = System.Convert.ToString(iCosh)
    End Sub

    Private Sub btnTanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanh.Click
        Dim iTanh As Double

        iTanh = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("Tanh" + "(" + (txtDisplay.Text) + ")")
        iTanh = Math.Tanh(iTanh)
        txtDisplay.Text = System.Convert.ToString(iTanh)
    End Sub

    Private Sub btnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        Dim iTan As Double

        iTan = Double.Parse(txtDisplay.Text)
        txtShow.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")")
        iTan = Math.Tan(iTan)
        txtDisplay.Text = System.Convert.ToString(iTan)
    End Sub

    Private Sub btnOct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOct.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 8)
    End Sub

    Private Sub btnHex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHex.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 16)
    End Sub

    Private Sub btnBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBin.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 2)
    End Sub

    'STAFFSALARY
    Dim percentage As Double
    Private Sub salary_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salary_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "-" Then
                If salary_txt.SelectionStart <> 0 OrElse salary_txt.Text.Contains("-") Then
                    e.Handled = True
                End If
            ElseIf e.KeyChar = "." Then
                If salary_txt.Text.Contains(".") Then
                    e.Handled = True
                End If
            Else
                e.Handled = True
                MsgBox("Wrong Input")
            End If
        End If
    End Sub

    Private Sub percentage_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles percentage_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "-" Then
                If percentage_txt.SelectionStart <> 0 OrElse percentage_txt.Text.Contains("-") Then
                    e.Handled = True
                End If
            ElseIf e.KeyChar = "." Then
                If percentage_txt.Text.Contains(".") Then
                    e.Handled = True
                End If
            Else
                e.Handled = True
                MsgBox("Wrong Input")
            End If
        End If
    End Sub

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        If salary_txt.Text = "" Or percentage_txt.Text = "" Then
            MsgBox("Fill the Empty space")
        ElseIf percentage_txt.Text > 100 Or percentage_txt.Text < 1 Then
            MsgBox("Percentage must be less than 100")
        Else
            percentage = percentage_txt.Text / 100

            deducted_txt.Text = salary_txt.Text * percentage

            balance_txt.Text = salary_txt.Text - deducted_txt.Text
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        salary_txt.Text = ""
        percentage_txt.Text = ""
        deducted_txt.Text = ""
        balance_txt.Text = ""
    End Sub

    'FACTORIA
    Dim input, product As Integer
    Dim factorial As Integer = 1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click

        If String.IsNullOrWhiteSpace(fac_txt.Text) Then
            MessageBox.Show("Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fac_txt.Focus()
            Return
        End If

        If Not Integer.TryParse(fac_txt.Text, input) OrElse input < 1 OrElse input > 11 Then
            MessageBox.Show("Invalid Number! Can't accept digits more than eleven(11) nor less than one(1). ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For i As Integer = 1 To input
            product = factorial
            factorial *= i
            ListBoxResults.Items.Add(i.ToString() & " x " & product.ToString() & " = " & factorial.ToString())
        Next
        ListBoxResults.Items.Add("Factorial of " & input.ToString() & " (" & input.ToString() & "!) = " & factorial.ToString())
    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        fac_txt.Text = ""
        ListBoxResults.Items.Clear()
        fac_txt.Focus()
    End Sub

    Private Sub fac_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fac_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If CType(sender, TextBox).TextLength >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fac_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fac_txt.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub StandardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardToolStripMenuItem.Click

    End Sub
End Class
