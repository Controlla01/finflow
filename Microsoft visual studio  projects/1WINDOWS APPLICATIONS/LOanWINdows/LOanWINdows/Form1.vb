Public Class Form1
    Dim LoanAmount, TotalPrincipalReturn, Interest, MonthlyInterest, PrincipalReturn, InterestRate, MonthlyPay, PayBalance As Double
    Dim LoanTerm, month As Integer

    Private Sub btnCalculateLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateLoan.Click
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

        lstPaymentSchedule.Items.Add("  MONTHS | PAY BALANCE | PRINCIPAL RETURN | INTEREST | MONTHLY PAYMENT")

        For months = 1 To LoanTerm
            PayBalance = LoanAmount - (PrincipalReturn * (months - 1))
            Interest = InterestRate * PayBalance
            MonthlyPay = PrincipalReturn + Interest
            MonthlyInterest = Interest + MonthlyInterest
            TotalPrincipalReturn = MonthlyPay + TotalPrincipalReturn

            lstPaymentSchedule.Items.Add(String.Format("{0,7} | {1,18:N} | {2,16:N} | {3,8:N} | {4,16:N}", months, PayBalance, PrincipalReturn, Interest, MonthlyPay))
        Next


        TotalInterest.Text = "TOTAL INTEREST = #" & MonthlyInterest
        TotalPrincipalReturnn.Text = "TOTAL PRINCIPAL RETURN = #" & TotalPrincipalReturn
    End Sub
End Class
