Module Module1

    Sub Main()
        Dim i, factorial, product, input As Integer
        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE WORKS AS A FACTORIAL CALCULATOR")
        Console.WriteLine("======================================================")
        Console.WriteLine()
        Console.WriteLine("INPUT NUMBER TO CALCULATE FACTORIAL")
        If Not Integer.TryParse(Console.ReadLine(), input) Or (input < 1) Then
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
            Console.WriteLine()
            Console.WriteLine("Re-enter Factorial Number")
            If Not Integer.TryParse(Console.ReadLine(), input) Or (input < 1) Then
                Console.WriteLine("Invalid number.")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine()
        factorial = 1
        For i = 1 To input
            product = factorial
            factorial = factorial * i
            Console.WriteLine(i.ToString + " x " + product.ToString + " = " + factorial.ToString)
            Console.WriteLine("FACTORIAL OF " & i.ToString() & " IS " & factorial.ToString())
            Console.WriteLine()
        Next
        Console.WriteLine(input.ToString() & " ! = " & factorial.ToString())


        Console.ReadLine()

    End Sub

End Module
