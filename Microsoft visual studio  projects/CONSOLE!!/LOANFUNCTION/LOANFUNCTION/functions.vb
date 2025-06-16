Module functions

    Function CalculateTotals(ByVal LoanAmount As Double, ByVal LoanTerm As Integer) As Tuple(Of Double, Double)
        Dim Interest, MonthlyPay, PrincipalReturn, InterestRate As Double
        Dim TotalPrincipalReturn As Double = 0
        Dim MonthlyInterest As Double = 0
        Dim PayBalance As Double = LoanAmount

        PrincipalReturn = LoanAmount / LoanTerm
        InterestRate = 1.5 / 100

        For Month As Integer = 1 To LoanTerm
            PayBalance = LoanAmount - (PrincipalReturn * (Month - 1))
            Interest = InterestRate * PayBalance
            MonthlyPay = PrincipalReturn + Interest
            MonthlyInterest = Interest + MonthlyInterest
            TotalPrincipalReturn = MonthlyPay + TotalPrincipalReturn
        Next

        Return Tuple.Create(TotalPrincipalReturn, MonthlyInterest)
    End Function
End Module
