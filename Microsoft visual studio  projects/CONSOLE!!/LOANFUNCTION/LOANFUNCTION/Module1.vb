Module Module1

    Sub Main()
        Dim LoanAmount, PrincipalReturn, InterestRate, MonthlyPay, PayBalance, Interest As Double
        Dim LoanTerm, Month As Integer
        Dim TotalPrincipalReturn As Double = 0
        Dim MonthlyInterest As Double = 0

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
            Console.WriteLine("Incorrect Amount, please input a real positive number.")
        End While

        Dim Result = functions.CalculateTotals(LoanAmount, LoanTerm)
        MonthlyInterest = Result.item1
        TotalPrincipalReturn = Result.Item2

        PrincipalReturn = LoanAmount / LoanTerm
        InterestRate = 1.5 / 100

        Console.WriteLine()
        Console.WriteLine("=================PAYMENT SCHEDULE======================")
        Console.WriteLine()
        Console.WriteLine("  MONTHS" + "|" + "  REMAINING BALANCE   " + "    |" + "  PRINCIPAL RETURN " + "  | " + "  INTEREST " + "    | " + "  MONTHLY PAYMENT")
        Console.WriteLine("=======================================================================================")

        For Month = 1 To LoanTerm
            PayBalance = LoanAmount - (PrincipalReturn * (Month - 1))
            Interest = InterestRate * PayBalance
            MonthlyPay = PrincipalReturn + Interest
        Console.WriteLine(Month.ToString() & "          | " & "#" & PayBalance.ToString("N") & "       | " & "#" & PrincipalReturn.ToString("N") & "         | " & "#" & Interest.ToString("N") & "        | " & "#" & MonthlyPay.ToString("N"))
        Next

        Console.WriteLine("=======================================================================================")
        Console.WriteLine()
        Console.WriteLine("TOTAL INTEREST = #" & MonthlyInterest.ToString("N"))
        Console.WriteLine("TOTAL PRINCIPAL RETURN = #" + TotalPrincipalReturn.ToString("N"))

        Console.ReadLine()
    End Sub


End Module