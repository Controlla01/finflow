Module Module1

    Sub Main()
        Dim LoanAmount, PrincipalReturn, InterestRate, MonthlyPay, PayBalance, Interest As Double
        Dim LoanTerm, Month As Integer
        Dim TotalPrincipalReturn As Double, MonthlyInterest As Double

        Console.WriteLine()
        Console.WriteLine("============================================================")
        Console.WriteLine()
        Console.WriteLine("THIS SOFTWARE WORKS AS A LOAN SOFTWARE")
        Console.WriteLine()
        Console.WriteLine("ENTER LOAN AMOUNT (AMOUNT TO BE BORROWED)")
        While Not Double.TryParse(Console.ReadLine(), LoanAmount) OrElse (LoanAmount <= 0)
            Console.WriteLine("Incorrect Amount, please input a real figure.")
        End While
        Console.WriteLine()
        Console.WriteLine("ENTER LOAN DURATION (BORROWED AMOUNT IN MONTHS)")
        While Not Integer.TryParse(Console.ReadLine(), LoanTerm) OrElse (LoanTerm <= 0)
            Console.WriteLine("Incorrect Amount, please input a real figure.")
        End While

        Dim Result = CalculateTotals(LoanAmount, LoanTerm)
        MonthlyInterest = Result.item1
        TotalPrincipalReturn = Result.Item2

        
        Console.WriteLine()
        Console.WriteLine("TOTAL INTEREST = #" & MonthlyInterest.ToString("N"))
        Console.WriteLine("TOTAL PRINCIPAL RETURN = #" + TotalPrincipalReturn.ToString("N"))

        Console.ReadLine()
    End Sub

    Function CalculateTotals(ByVal LoanAmount As Double, ByVal LoanTerm As Integer) As Tuple(Of Double, Double)
        Dim Interest, MonthlyPay, PrincipalReturn, InterestRate As Double
        Dim TotalPrincipalReturn As Double = 0
        Dim MonthlyInterest As Double = 0
        Dim PayBalance As Double = 0

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
