Imports Guna.UI2.WinForms

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 255
        txtDisplay.Width = 554


        home_page_panel.Show()
        simple_calc_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        AgeCalc_Panel2.Hide()
        Gp_Calcu_Panel2.Hide()
        Guna2Panel2.Hide()

        cmbUnit.Items.Clear()
        cmbUnit.Items.Add("Choose One")
        cmbUnit.Items.Add("Celsius to Fahrenheit")
        cmbUnit.Items.Add("Fahrenheit to Celsius")
        cmbUnit.Items.Add("Miles to Kilometres")
        cmbUnit.Items.Add("Kilometres to Miles")
        cmbUnit.Items.Add("Centimeters to Meters")
        cmbUnit.SelectedIndex = 0

        p1_txt.Enabled = False
        p2_txt.Enabled = False
        v1_txt.Enabled = False
        v2_txt.Enabled = False

        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""

        home_btn.Checked = True

    End Sub


    Private Sub close_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_button.Click
        Me.Close()
    End Sub

    Private Sub mini_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mini_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Activebtn()
        home_btn.Checked = False
        simple_calc_btn.Checked = False
        LoanApp_btn.Checked = False
        BOYLES_LAW_Btn.Checked = False
        GpCalcu_btn.Checked = False
        AgeCalc_btn.Checked = False
        Unit_converterBtn.Checked = False
    End Sub
    Private Sub HideAllPanels()
        home_page_panel.Hide()
        simple_calc_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
    End Sub

    Private Sub home_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        home_page_panel.Show()
        Activebtn()
        home_btn.Checked = True
        simple_calc_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        AgeCalc_Panel2.Hide()
        Guna2Panel2.Hide()
        Gp_Calcu_Panel2.Hide()
    End Sub

    Private Sub LoanApp_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanApp_btn.Click
        home_page_panel.Hide()
        simple_calc_panel.Hide()
        loan_app_panel.Show()
        Activebtn()
        LoanApp_btn.Checked = True
        Boyleslaw_panel.Hide()
        AgeCalc_Panel2.Hide()
        Gp_Calcu_Panel2.Hide()
        Guna2Panel2.Hide()
    End Sub

    Private Sub simple_calc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simple_calc_btn.Click
        simple_calc_panel.Show()
        Activebtn()
        simple_calc_btn.Checked = True
        home_page_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        AgeCalc_Panel2.Hide()
        Guna2Panel2.Hide()
        Gp_Calcu_Panel2.Hide()
    End Sub

    Private Sub BOYLES_LAW_Btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOYLES_LAW_Btn.Click
        Boyleslaw_panel.Show()
        Activebtn()
        BOYLES_LAW_Btn.Checked = True
        simple_calc_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Show()
        Guna2Panel2.Hide()
        AgeCalc_Panel2.Hide()
        Gp_Calcu_Panel2.Hide()
    End Sub

    Private Sub AgeCalc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgeCalc_btn.Click
        AgeCalc_Panel2.Show()
        Activebtn()
        AgeCalc_btn.Checked = True
        simple_calc_panel.Hide()
        home_page_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        Gp_Calcu_Panel2.Hide()
        Guna2Panel2.Hide()
    End Sub

    Private Sub GpCalcu_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpCalcu_btn.Click
        Gp_Calcu_Panel2.Show()
        Activebtn()
        GpCalcu_btn.Checked = True
        AgeCalc_Panel2.Hide()
        simple_calc_panel.Hide()
        home_page_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        Guna2Panel2.Hide()
    End Sub

    Private Sub Unit_converterBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Unit_converterBtn.Click
        Gp_Calcu_Panel2.Hide()
        AgeCalc_Panel2.Hide()
        simple_calc_panel.Hide()
        home_page_panel.Hide()
        loan_app_panel.Hide()
        Boyleslaw_panel.Hide()
        Guna2Panel2.Show()
        Activebtn()
        Unit_converterBtn.Checked = True
    End Sub

    'SIMPLE CALCU!!
    Private firstnum As Double = 0
    Private secondnum As Double = 0
    Private answer As Double = 9
    Private opera As String = ""

    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click, Button13.Click, Button12.Click, Button11.Click, btnNo9.Click, btnNo8.Click, btnNo7.Click, btnNo4.Click
        Dim b As Button = CType(sender, Button)
        If (txtDisplay.Text = "0") Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text &= b.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button2.Click
        Dim b As Button = CType(sender, Button)
        If (txtDisplay.Text = "0") Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text &= b.Text
        End If
    End Sub

    Private Sub PerformCalculation()
        If txtDisplay.Text <> "" AndAlso Double.TryParse(txtDisplay.Text, secondnum) Then
            Select Case opera
                Case "+"
                    answer += secondnum
                Case "-"
                    answer -= secondnum
                Case "*"
                    answer *= secondnum
                Case "/"
                    If secondnum <> 0 Then
                        answer /= secondnum
                    Else
                        MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ClearDisplay()
                        Return
                    End If
                Case "Mod"
                    answer = answer Mod secondnum
                Case "Exp"
                    answer = Math.Pow(answer, secondnum)
                Case Else
                    MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ClearDisplay()
                    Return
            End Select

            txtDisplay.Text = answer.ToString()
        Else
            MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End If
    End Sub

    Private Sub Arithmetic_Operators(ByVal sender As Object, ByVal e As EventArgs) Handles Button20.Click, Button19.Click, Button18.Click, btnMod.Click, btnNoplus.Click
        Dim ops As Button = CType(sender, Button)
        If txtDisplay.Text <> "" AndAlso Double.TryParse(txtDisplay.Text, firstnum) Then
            If (opera <> "") Then
                PerformCalculation()
            Else
                answer = firstnum
            End If
        Else
            MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
            Return
        End If

        txtShow.Text = answer.ToString() & " " & ops.Text
        txtDisplay.Text = "0"
        opera = ops.Text
    End Sub

    Private Sub btnEquals_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEquals.Click
        PerformCalculation()
        txtShow.Text = ""
        opera = ""
    End Sub

    Private Sub btnBackspace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackspace.Click
        If (txtDisplay.Text.Length > 0) Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1)
            If txtDisplay.Text = "" Then txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub btnDot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDot.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDel.Click
        ClearDisplay()
    End Sub

    Private Sub btnClr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClr.Click
        ClearDisplay()
        txtDisplay.Text = "0"
        txtShow.Text = ""
        firstnum = 0
        secondnum = 0
        answer = 0
        opera = ""
    End Sub

    Private Sub btnNegate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNegate.Click
        If Double.TryParse(txtDisplay.Text, firstnum) Then
            txtDisplay.Text = (-1 * Double.Parse(txtDisplay.Text)).ToString()
        Else
            MessageBox.Show("Invalid number for negation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ApplySingleOperation(ByVal operationName As String, ByVal operation As Func(Of Double, Double))
        Try
            Dim input As Double = Double.Parse(txtDisplay.Text)
            txtShow.Text = operationName & "(" & txtDisplay.Text & ")"
            txtDisplay.Text = operation(input).ToString()
        Catch ex As Exception
            MessageBox.Show("Invalid input for operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End Try
    End Sub

    Private Sub btnLog_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click
        ApplySingleOperation("log", Function(x) Math.Log10(x))
    End Sub

    Private Sub btnCosh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCosh.Click
        ApplySingleOperation("cosh", Function(x) Math.Cosh(x))
    End Sub

    Private Sub btnPi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPi.Click
        txtDisplay.Text = Math.PI.ToString("F15")
    End Sub

    Private Sub btnSignh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignh.Click
        ApplySingleOperation("asin", Function(x) Math.Asin(x))
    End Sub

    Private Sub btnTanh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTanh.Click
        ApplySingleOperation("atan", Function(x) Math.Atan(x))
    End Sub

    Private Sub btnExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExp.Click
        ApplySingleOperation("exp", Function(x) Math.Exp(x))
    End Sub

    Private Sub btnSin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSin.Click
        ApplySingleOperation("sin", Function(x) Math.Sin(x))
    End Sub

    Private Sub btnCos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCos.Click
        ApplySingleOperation("cos", Function(x) Math.Cos(x))
    End Sub

    Private Sub btnTan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTan.Click
        ApplySingleOperation("tan", Function(x) Math.Tan(x))
    End Sub



    Private Sub BtnSqrt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSqrt.Click
        ApplySingleOperation("sqrt", Function(x) Math.Sqrt(x))
    End Sub

    Private Sub btnBin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBin.Click
        ApplyConversion("Binary", Function(x) Convert.ToString(x, 2))
    End Sub

    Private Sub btnHex_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHex.Click
        ApplyConversion("Hexadecimal", Function(x) Convert.ToString(x, 16))
    End Sub

    Private Sub btnOct_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOct.Click
        ApplyConversion("Octal", Function(x) Convert.ToString(x, 8))
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        ApplySingleOperation("x²", Function(x) x * x)
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        ApplySingleOperation("x³", Function(x) x * x * x)
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        ApplySingleOperation("1/x", Function(x) 1 / x)
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Dim input As Double = Double.Parse(txtDisplay.Text)
        txtShow.Text = "ln(" & txtDisplay.Text & ")"
        txtDisplay.Text = Math.Log(input).ToString()
    End Sub

    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        txtDisplay.Text = (Double.Parse(txtDisplay.Text) / 100).ToString()
    End Sub

    Private Sub ClearDisplay()
        txtDisplay.Text = "0"
        txtShow.Text = ""
        firstnum = 0
        secondnum = 0
        answer = 0
        opera = ""
    End Sub

    Private Sub ApplyConversion(ByVal conversionName As String, ByVal conversion As Func(Of Integer, String))
        Try
            Dim input As Integer = Integer.Parse(txtDisplay.Text)
            txtShow.Text = conversionName & "(" & txtDisplay.Text & ")"
            txtDisplay.Text = conversion(input)
        Catch ex As Exception
            MessageBox.Show("Invalid input for conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearDisplay()
        End Try
    End Sub


    'BOYLE'S LAW

    Private Sub UpdateFields(ByVal selectedRadio As RadioButton, ByVal disabledTextBox As TextBox)

        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""
        result_txtt.Text = ""

        p1_txt.Enabled = True
        p2_txt.Enabled = True
        v1_txt.Enabled = True
        v2_txt.Enabled = True

        If (selectedRadio.Checked) Then
            disabledTextBox.Enabled = False
            disabledTextBox.Text = "?"
        End If
    End Sub

    Private Sub p1_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_radio.CheckedChanged
        If (p1_radio.Checked) Then
            UpdateFields(p1_radio, p1_txt)
        End If
    End Sub

    Private Sub v1_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1_radio.CheckedChanged
        If (v1_radio.Checked) Then
            UpdateFields(v1_radio, v1_txt)
        End If
    End Sub

    Private Sub p2_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_radio.CheckedChanged
        If (p2_radio.Checked) Then
            UpdateFields(p2_radio, p2_txt)
        End If
    End Sub

    Private Sub v2_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2_radio.CheckedChanged
        If (v2_radio.Checked) Then
            UpdateFields(v2_radio, v2_txt)
        End If
    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""
        result_txtt.Text = ""

        p1_txt.Enabled = False
        p2_txt.Enabled = False
        v1_txt.Enabled = False
        v2_txt.Enabled = False

        p1_radio.Checked = False
        p2_radio.Checked = False
        v1_radio.Checked = False
        v2_radio.Checked = False


    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
        Handles p1_txt.KeyPress, p2_txt.KeyPress, v1_txt.KeyPress, v2_txt.KeyPress
        Dim currentTextBox As TextBox = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c Then
            If currentTextBox.Text.Contains(".") Then
                e.Handled = True
                MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return
        End If

        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub calc_boyles_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_boyles_btn.Click
        Dim p1, p2, v1, v2, result As Double

        Double.TryParse(p1_txt.Text, p1)
        Double.TryParse(v1_txt.Text, v1)
        Double.TryParse(p2_txt.Text, p2)
        Double.TryParse(v2_txt.Text, v2)

        Try
            Select Case True
                Case p1_radio.Checked
                    If (v1 = 0) Then
                        Throw New DivideByZeroException("Cannot divide by zero. Check V1 or P2 inputs.")
                    End If
                    result = (v2 * p2) / v1
                    result_txtt.Text = "P1 = " & Math.Round(result, 2) & " mm Hg"
                Case v1_radio.Checked
                    If (p1 = 0) Then
                        Throw New DivideByZeroException("Cannot divide by zero. Check P1 or P2 inputs.")
                    End If
                    result = (v2 * p2) / p1
                    result_txtt.Text = "V1 = " & Math.Round(result, 2) & " Litres"
                Case p2_radio.Checked
                    If (v2 = 0) Then
                        Throw New DivideByZeroException("Cannot divide by zero. Check V2 or V1 inputs.")
                    End If
                    result = (v1 * p1) / v2
                    result_txtt.Text = "P2 = " & Math.Round(result, 2) & " mm Hg"
                Case v2_radio.Checked
                    If (p2 = 0) Then
                        Throw New DivideByZeroException("Cannot divide by zero. Check P2 or P1 inputs.")
                    End If
                    result = (v1 * p1) / p2
                    result_txtt.Text = "V2 = " & Math.Round(result, 2) & " Litres"
                Case Else
                    MessageBox.Show("Please select a field to calculate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result_txtt.Text = ""
        Catch ex As Exception
            MessageBox.Show("An error occurred during calculation. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result_txtt.Text = ""
        End Try
    End Sub

    'AGE CALCU!!!!
    Private Sub btnCalculateAge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateAge.Click
        Dim birthYear, birthMonth, birthDay As Integer

        If Not Integer.TryParse(txtBirthYear.Text, birthYear) OrElse birthYear <= 0 OrElse birthYear > DateTime.Now.Year Then
            MessageBox.Show("Please enter a valid birth year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthYear.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtBirthMonth.Text, birthMonth) OrElse birthMonth < 1 OrElse birthMonth > 12 Then
            MessageBox.Show("Please enter a valid birth month (1-12).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthMonth.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtBirthDay.Text, birthDay) OrElse birthDay < 1 OrElse birthDay > DateTime.DaysInMonth(birthYear, birthMonth) Then
            MessageBox.Show("Please enter a valid birth day.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthDay.Focus()
            Exit Sub
        End If

        Dim today As DateTime = DateTime.Today
        Dim birthDate As New DateTime(birthYear, birthMonth, birthDay)

        If birthDate > today Then
            MessageBox.Show("Birth date cannot be in the future.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim ageYears As Integer = today.Year - birthDate.Year
        Dim ageMonths As Integer = today.Month - birthDate.Month
        Dim ageDays As Integer = today.Day - birthDate.Day

        Try
            If (ageDays < 0) Then
                Dim previousMonth As Integer = If(today.Month - 1 = 0, 12, today.Month - 1)
                Dim daysInPreviousMonth As Integer = DateTime.DaysInMonth(If(previousMonth = 12, today.Year - 1, today.Year), previousMonth)
                ageDays += daysInPreviousMonth
                ageMonths -= 1
            End If

            If (ageMonths < 0) Then
                ageMonths += 12
                ageYears -= 1
            End If

            years_txt.Text = ageYears.ToString()
            months_txt.Text = ageMonths.ToString()
            days_txt.Text = ageDays.ToString()
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBirthYear_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBirthYear.KeyPress
        Dim txt = CType(sender, Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If txt.Text.Length >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Year cannot exceed 4 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtBirthMonth_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBirthMonth.KeyPress
        Dim txt = CType(sender, Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If txt.Text.Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsControl(e.KeyChar) Then Return
        Dim newText As String = txt.Text & e.KeyChar
        Dim value As Integer
        If Integer.TryParse(newText, value) Then
            If value > 12 OrElse value < 1 Then
                e.Handled = True
                MessageBox.Show("Month cannot exceed 12.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtBirthDay_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtBirthDay.KeyPress
        Dim txt = CType(sender, Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Only numbers are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If e.KeyChar = "."c AndAlso txt.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txt.Text.Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

      
        MessageBox.Show("Date cannot exceed 31.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        years_txt.Text = ""
        months_txt.Text = ""
        days_txt.Text = ""
        txtBirthDay.Text = ""
        txtBirthYear.Text = ""
        txtBirthMonth.Text = ""
    End Sub


    'LOAN APP

    Dim LoanAmount, TotalPrincipalReturn, Interest, MonthlyInterest, PrincipalReturn, InterestRate, MonthlyPay, PayBalance As Double
    Dim LoanTerm, month As Integer

    Private Sub btnCalculateLoan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateLoan.Click
        If (lstPaymentSchedule.Items.Count > 0) Then
            MessageBox.Show("The loan has already been calculated. Please clear the form before recalculating.")
            Return
        End If

        If Not Double.TryParse(txtLoanAmount.Text, LoanAmount) OrElse LoanAmount <= 0 Then
            MessageBox.Show("Please enter a valid loan amount.")
            Return
        End If

        If Not Integer.TryParse(txtLoanTerm.Text, LoanTerm) OrElse LoanTerm <= 0 Then
            MessageBox.Show("Please enter a valid loan term in months.")
            Return
        End If

        PrincipalReturn = LoanAmount / LoanTerm
        InterestRate = 1.5 / 100
        PayBalance = 0
        MonthlyInterest = 0
        TotalPrincipalReturn = 0

        lstPaymentSchedule.Items.Add(" MONTHS | PAY BALANCE   | PRINCIPAL RETURN   | INTEREST |   MONTHLY PAYMENT")

        For months = 1 To LoanTerm
            PayBalance = LoanAmount - (PrincipalReturn * (months - 1))
            Interest = InterestRate * PayBalance
            MonthlyPay = PrincipalReturn + Interest
            MonthlyInterest = Interest + MonthlyInterest
            TotalPrincipalReturn = MonthlyPay + TotalPrincipalReturn

            lstPaymentSchedule.Items.Add(String.Format("{0,6} | {1,19:N} | {2,20:N} | {3,27:N} | {4,20:N}", months, PayBalance, PrincipalReturn, Interest, MonthlyPay))
        Next


        TotalPrincipalReturnnn.Text = "TOTAL PRINCIPAL RETURN = #" & TotalPrincipalReturn
        TotalInterestt.Text = "TOTAL INTEREST = #" & MonthlyInterest

        txtLoanAmount.Enabled = False
        txtLoanTerm.Enabled = False
    End Sub

    Private Sub Clear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        txtLoanAmount.Text = ""
        txtLoanTerm.Text = ""
        TotalInterestt.Text = ""
        TotalPrincipalReturnnn.Text = ""
        lstPaymentSchedule.Items.Clear()

        txtLoanAmount.Enabled = True
        txtLoanTerm.Enabled = True
    End Sub

    Private Sub txtLoanAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanAmount.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c Then
            If txtLoanAmount.Text.Contains(".") Then
                e.Handled = True
                MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return
        ElseIf Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be umbers, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtLoanTerm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanTerm.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c Then
            If txtLoanTerm.Text.Contains(".") Then
                e.Handled = True
                MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return
        ElseIf Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TotalPrincipalReturnnn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TotalPrincipalReturnnn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
            MessageBox.Show("Only numeric input is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If e.KeyChar = "."c AndAlso textBox.Text.Contains(".") Then
            e.Handled = True
            MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub

    'GP CALCULATOR

    Private Sub second_semester_calc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_semester_calc_btn.Click
        second_semester_Panel.Show()
        first_semester_Panel.Hide()

    End Sub

    Private Sub first_semester_calc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_semester_calc_btn.Click
        first_semester_Panel.Show()
        second_semester_Panel.Hide()

    End Sub

    Dim totalCourseUnitsFirst As Double = 25
    Dim totalCourseUnitsSecond As Double = 24


    Public Sub CalculateCGPAForSemester(ByVal scores() As Double, ByVal units() As Double, ByVal totalUnits As Double, ByRef gpa As Double, ByRef totalGradePoints As Double)
        totalGradePoints = 0
        For i As Integer = 0 To scores.Length - 1
            totalGradePoints += Functions.CalculateGradePoints(scores(i), units(i))
        Next
        gpa = totalGradePoints / totalUnits
    End Sub


    Private Sub calcFirst_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcFirst_btn.Click
        Dim firstSemesterInputs = {SDT101_txt, MAD102_txt, SDA103_txt, WAD104_txt, NS105_txt, AGD106_txt}
        Dim firstSemesterUnits As Double() = {4.0, 4.0, 5.0, 4.0, 4.0, 4.0}

        If Not ValidateInputs(firstSemesterInputs) Then Return

        Dim scores = firstSemesterInputs.Select(Function(txt) Convert.ToDouble(txt.Text)).ToArray()
        Dim gpaFirst As Double = 0
        Dim totalGradePointsFirst As Double = 0

        CalculateCGPAForSemester(scores, firstSemesterUnits, totalCourseUnitsFirst, gpaFirst, totalGradePointsFirst)

        txtCourseUnitsFirst.Text = "Total Course Units: " & totalCourseUnitsFirst.ToString("F2")
        TotalGPFirst_txt.Text = "Total Grade Points: " & totalGradePointsFirst.ToString("F2")
        GPAFirst_txt.Text = "Grade Point Average: " & gpaFirst.ToString("F2")
        GradeClassFirst_txt.Text = "Grade Classification: " & Functions.GetGradeClassification(gpaFirst)
    End Sub

    Private Sub calcSecond_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calcSecond_btn.Click
        Dim secondSemesterInputs = {DBMS201_txt, UIUX202_txt, AI204_txt, SQT205_txt, AA206_txt, DevOp207_txt}
        Dim secondSemesterUnits As Double() = {5.0, 3.0, 5.0, 3.0, 4.0, 4.0}

        If Not Functions.ValidateInputs(secondSemesterInputs) Then Return

        Dim scores = secondSemesterInputs.Select(Function(txt) Convert.ToDouble(txt.Text)).ToArray()
        Dim gpaSecond As Double = 0
        Dim totalGradePointsSecond As Double = 0

        CalculateCGPAForSemester(scores, secondSemesterUnits, totalCourseUnitsSecond, gpaSecond, totalGradePointsSecond)

        txtTotalCourseUnits2.Text = "Total Course Units: " & totalCourseUnitsSecond.ToString("F2")
        TotalGPSecond_txt.Text = "Total Grade Points: " & totalGradePointsSecond.ToString("F2")
        TotalGPASecond_txt.Text = "Grade Point Average: " & gpaSecond.ToString("F2")
        GradeClassSecond_txt.Text = "Grade Classification: " & Functions.GetGradeClassification(gpaSecond)

    End Sub

    Private Sub UIUX202_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UIUX202_txt.KeyPress, SQT205_txt.KeyPress, DevOp207_txt.KeyPress, DBMS201_txt.KeyPress, AI204_txt.KeyPress, AA206_txt.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
                MessageBox.Show("Only numeric input is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim textBox As TextBox = DirectCast(sender, TextBox)
            If e.KeyChar = "."c AndAlso textBox.Text.Contains(".") Then
                e.Handled = True
                MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            AddHandler textBox.TextChanged, Sub()
                                                Dim value As Double
                                                If Double.TryParse(textBox.Text, value) Then
                                                    If value < 0 OrElse value > 100 Then
                                                        textBox.Text = String.Empty
                                                        MessageBox.Show("Please enter a score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    End If
                                                End If
                                            End Sub

            Dim allTextboxes As TextBox() = {UIUX202_txt, SQT205_txt, DevOp207_txt, DBMS201_txt, AI204_txt, AA206_txt, SDT101_txt, MAD102_txt, SDA103_txt, WAD104_txt, NS105_txt, AGD106_txt}
            Dim nonEmptyCount = allTextboxes.Count(Function(tb) Not String.IsNullOrWhiteSpace(tb.Text))

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SDT101_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WAD104_txt.KeyPress, SDT101_txt.KeyPress, SDA103_txt.KeyPress, NS105_txt.KeyPress, MAD102_txt.KeyPress, AGD106_txt.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "."c Then
                e.Handled = True
                MessageBox.Show("Only numeric input is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim textBox As TextBox = DirectCast(sender, TextBox)
            If e.KeyChar = "."c AndAlso textBox.Text.Contains(".") Then
                e.Handled = True
                MessageBox.Show("Only one decimal point is allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            AddHandler textBox.TextChanged, Sub()
                                                Dim value As Double
                                                If Double.TryParse(textBox.Text, value) Then
                                                    If value < 0 OrElse value > 100 Then
                                                        textBox.Text = String.Empty
                                                        MessageBox.Show("Please enter a score between 0 and 100.", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                                    End If
                                                End If
                                            End Sub

            Dim allTextboxes As TextBox() = {UIUX202_txt, SQT205_txt, DevOp207_txt, DBMS201_txt, AI204_txt, AA206_txt, SDT101_txt, MAD102_txt, SDA103_txt, WAD104_txt, NS105_txt, AGD106_txt}
            Dim nonEmptyCount = allTextboxes.Count(Function(tb) Not String.IsNullOrWhiteSpace(tb.Text))

        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearSecond_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSecond_btn.Click
        DBMS201_txt.Clear()
        UIUX202_txt.Clear()
        AI204_txt.Clear()
        SQT205_txt.Clear()
        AA206_txt.Clear()
        DevOp207_txt.Clear()

        txtTotalCourseUnits2.Clear()
        TotalGPSecond_txt.Clear()
        TotalGPASecond_txt.Clear()
        GradeClassSecond_txt.Clear()
    End Sub
    Private Sub ClearFirst_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFirst_btn.Click
        SDT101_txt.Clear()
        MAD102_txt.Clear()
        SDA103_txt.Clear()
        WAD104_txt.Clear()
        NS105_txt.Clear()
        AGD106_txt.Clear()

        txtCourseUnitsFirst.Clear()
        TotalGPFirst_txt.Clear()
        GPAFirst_txt.Clear()
        GradeClassFirst_txt.Clear()
    End Sub


    'UNIT CONVERTER'

    Private _autoConvert As Boolean = False

    Private Sub PerformConversion()
        Dim convert As Double

        If Not Double.TryParse(input_con.Text, convert) Then
            TextBox3.Text = "Invalid Input"
            Return
        End If

        If cmbUnit.Text = "Choose One" Then
            TextBox3.Text = "Select a Conversion Type"
            Return
        End If

        Select Case cmbUnit.Text
            Case "Celsius to Fahrenheit"
                convert = (9 / 5) * convert + 32
                TextBox3.Text = convert.ToString("F2") & " Fahrenheit"
            Case "Fahrenheit to Celsius"
                convert = (convert - 32) * 5 / 9
                TextBox3.Text = convert.ToString("F2") & " Celsius"
            Case "Miles to Kilometres"
                convert *= 1.60934
                TextBox3.Text = convert.ToString("F2") & " Kilometres"
            Case "Kilometres to Miles"
                convert /= 1.60934
                TextBox3.Text = convert.ToString("F2") & " Miles"
            Case "Centimeters to Meters"
                convert /= 100
                TextBox3.Text = convert.ToString("F2") & " Meters"
            Case Else
                TextBox3.Text = "Invalid Conversion Type"
        End Select
    End Sub

    Private Sub btnUnitConverter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitConverter.Click
        _autoConvert = True
        PerformConversion()
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        _autoConvert = False
        cmbUnit.SelectedIndex = 0
        input_con.Text = String.Empty
        TextBox3.Text = String.Empty
    End Sub

    Private Sub input_con_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input_con.TextChanged
        If _autoConvert Then
            PerformConversion()
        End If
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnit.SelectedIndexChanged
        If _autoConvert Then
            PerformConversion()
        End If
    End Sub

    Private Sub input_con_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input_con.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c Then
            If txtLoanTerm.Text.Contains(".") Then
                MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                input_con.Focus()
                e.Handled = True
            End If
            Return
        ElseIf Not Char.IsDigit(e.KeyChar) Then
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            input_con.Focus()
            e.Handled = True
        End If
    End Sub
End Class