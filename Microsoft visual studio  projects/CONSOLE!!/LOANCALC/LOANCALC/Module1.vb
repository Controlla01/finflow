Module Module1

    Sub Main()
        Dim LoanAmount, TotalPrincipalReturn, Interest, MonthlyInterest, PrincipalReturn, InterestRate, MonthlyPay, PayBalance As Double
        Dim LoanTerm, month As Integer

        Console.WriteLine()
        Console.WriteLine("============================================================")
        Console.WriteLine()
        Console.WriteLine("THIS SOFTWARE WORKS AS A LOAN CALCULATOR")
        Console.WriteLine()
        Console.WriteLine("ENTER LOAN AMOUNT")
        While Not Double.TryParse(Console.ReadLine(), LoanAmount) OrElse (LoanAmount <= 0)
            Console.WriteLine("Incorrect Amount, please input a real figure.")
        End While
        Console.WriteLine()
        Console.WriteLine("ENTER LOAN TERM")
        While Not Integer.TryParse(Console.ReadLine(), LoanTerm) OrElse (LoanTerm <= 0)
            Console.WriteLine("Incorrect Amount, please input a real figure.")
        End While

            PrincipalReturn = LoanAmount / LoanTerm
            InterestRate = 1.5 / 100
            PayBalance = 0

            Console.WriteLine()
            Console.WriteLine("=================PAYMENT SCHEDULE======================")
            Console.WriteLine()
            Console.WriteLine("  MONTHS" + "|" + "  REMAINING BALANCE   " + "    |" + "  PRINCIPAL RETURN " + "  | " + "  INTEREST " + "    | " + "  MONTHLY PAYMENT")
            Console.WriteLine("=======================================================================================")

            For month = 1 To LoanTerm
                PayBalance = LoanAmount - (PrincipalReturn * (month - 1))
                Interest = InterestRate * PayBalance
                MonthlyPay = PrincipalReturn + Interest
                MonthlyInterest = Interest + MonthlyInterest
                TotalPrincipalReturn = MonthlyPay + TotalPrincipalReturn

            Console.WriteLine(month.ToString() & "          | " & "#" & PayBalance.ToString("N") & "       | " & "#" & PrincipalReturn.ToString("N") & "         | " & "#" & Interest.ToString("N") & "        | " & "#" & MonthlyPay.ToString("N"))

            Next
            Console.WriteLine()
            Console.WriteLine("TOTAL INTEREST = #" + MonthlyInterest.ToString("N"))
            Console.WriteLine("TOTAL PRINCIPAL RETURN = #" + TotalPrincipalReturn.ToString("N"))


            Console.ReadLine()


    End Sub

End Module
