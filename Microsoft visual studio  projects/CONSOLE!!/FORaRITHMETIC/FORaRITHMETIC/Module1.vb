Module Module1

    Sub Main()
        Dim FirstNum, SecondNum, result As Double
        Dim operation As String
        Dim operations() As String = {"+", "-", "*", "/"}

        Console.WriteLine()
        Console.WriteLine("THIS SOFTWARE WORKS FOR SUM, DIFFERENCE, PRODUCT, DIVISION ")
        Console.WriteLine("======================================================")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("INPUT FIRST NUMBER")
        If Not Integer.TryParse(Console.ReadLine(), FirstNum) Or (FirstNum = 0) Then
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
            Console.WriteLine("")
            Console.WriteLine("Re-enter First Number")
            If Not Integer.TryParse(Console.ReadLine(), FirstNum) Or (FirstNum = 0) Then
                Console.WriteLine("Invalid number.")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine()
        Console.WriteLine("INPUT SECOND NUMBER")
        If Not Integer.TryParse(Console.ReadLine(), SecondNum) Or (SecondNum = 0) Then
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
            Console.WriteLine("")
            Console.WriteLine("Re-enter Second Number")
            If Not Integer.TryParse(Console.ReadLine(), SecondNum) Or (SecondNum = 0) Then
                Console.WriteLine("Invalid number.")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine()

        Console.WriteLine("Choose any operation: '+' for Sum, '-' for Difference, '*' for Product, '/' for Fraction")
        operation = Console.ReadLine()


            For Each op In operations
                If operation = op Then

                    If operation = "+" Then
                        result = FirstNum + SecondNum
                        Console.WriteLine()
                        Console.WriteLine("The Sum of " & FirstNum.ToString() & " and " & SecondNum.ToString() & " is = " & result.ToString())

                    ElseIf operation = "-" Then
                        result = FirstNum - SecondNum
                        Console.WriteLine()
                        Console.WriteLine("The Difference of " & FirstNum.ToString() & " and " & SecondNum.ToString() & " is = " & result.ToString())

                    ElseIf operation = "*" Then
                        result = FirstNum * SecondNum
                        Console.WriteLine()
                        Console.WriteLine("The Product of " & FirstNum.ToString() & " and " & SecondNum.ToString() & " is = " & result.ToString())

                    ElseIf operation = "/" Then
                        result = FirstNum / SecondNum
                        Console.WriteLine()
                        Console.WriteLine("The Fraction of " & FirstNum.ToString() & " and " & SecondNum.ToString() & " is = " & result.ToString())

                    
                End If
            Else
                Console.WriteLine("Invalid operation.")
                End If

            Next



            Console.ReadLine()
    End Sub

End Module
