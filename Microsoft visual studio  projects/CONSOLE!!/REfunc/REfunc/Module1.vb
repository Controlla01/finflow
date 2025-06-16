Module Module1

    Sub Main()
        Dim LoanAmount, TotalPrincipalReturn, MonthlyInterest As Double
        Dim LoanTerm As Integer

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
        TotalPrincipalReturn = Result.item2

        Console.WriteLine()
        Console.WriteLine("TOTAL INTEREST = #" & MonthlyInterest.ToString("N"))
        Console.WriteLine("TOTAL PRINCIPAL RETURN = #" + TotalPrincipalReturn.ToString("N"))

        Console.ReadLine()
    End Sub

    Function CalculateTotals(ByVal LoanAmount As Double, ByVal LoanTerm As Integer) As Tuple(Of Double, Double)
        Dim TotalPrincipalReturn, MonthlyInterest, InitialBalance, FinalBalance, PrincipalReturn, InterestRate As Double
        PrincipalReturn = LoanAmount / LoanTerm
        InterestRate = 5 / 100

        InitialBalance = LoanAmount
        FinalBalance = PrincipalReturn
        MonthlyInterest = InterestRate * LoanTerm * (InitialBalance + FinalBalance) / 2
        TotalPrincipalReturn = LoanTerm * (PrincipalReturn + MonthlyInterest / LoanTerm)
        Return Tuple.Create(TotalPrincipalReturn, MonthlyInterest)
    End Function

End Module
