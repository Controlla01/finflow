Module Module1

    Sub Main()
        Dim op, opera As Integer

        Console.WriteLine()
        Console.WriteLine("=============================================================")
        Console.WriteLine("THIS SOFTWARE WORKS AS A MULTI_FUNCTION SOFTWARE")
        Console.WriteLine("=============================================================")
        Console.WriteLine()
        Do
            Console.WriteLine("ENTER 1(ONE) FOR LOAN APPLICATION")
            Console.WriteLine("ENTER 2(TWO) FOR AGE CALCULATOR")
            Console.WriteLine("ENTER 3(THREE) FOR SIMPLE CALCULATOR")
            Console.WriteLine("ENTER 4(FOUR) FOR AFOOTECH GP CALCULATOR")
            Console.WriteLine("ENTER 5(FIVE) FOR CIRCUMFERENCE OF A CIRCLE")
            Console.WriteLine("ENTER 6(SIX) FOR AREA OF A CIRCLE")
            Console.WriteLine("ENTER 7(SEVEN) FOR BOYLES LAW")
            While Not Integer.TryParse(Console.ReadLine, op) Or (op < 1) Or (op > 7)
                Console.WriteLine("Invalid Input, Please input correct number again.")
            End While
            Console.WriteLine("=============================================================")

            Select Case op
                Case 1
                    LoanApp.LoanApp()
                Case 2
                    AgeCalc.AgeCalc()
                Case 3
                    SimpleArithmeticCalc.SimpleArithmeticCalc()
                Case 4
                    AFOOTECHGPCALC.AFOOTECHGPCALC()
                Case 5
                    CIRCUMFERECEOFACIRCLE.CIRCUMFERECEOFACIRCLE()
                Case 6
                    AREAOFACIRCLE.AREAOFACIRCLE()
                Case 7
                    BOYLESLAW.BOYLESLAW()
            End Select
            Console.WriteLine()

            Console.WriteLine("ENTER 1 TO RESTART")
            Console.WriteLine("ENTER 2 TO EXIT")
            While Not Integer.TryParse(Console.ReadLine, opera) Or (opera < 1) Or (opera > 2)
            End While
            Console.Clear()
        Loop Until opera = 2

        Console.ReadLine()
    End Sub

End Module
