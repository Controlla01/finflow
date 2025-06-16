Module SimpleArithmeticCalc

    Sub SimpleArithmeticCalc()
        Dim FirstNum, SecondNum, Result As Double
        Dim operation As String

        Console.WriteLine()
        Console.WriteLine("=================================================================")
        Console.WriteLine("THIS SOFTWARE WORKS AS A SIMPLE CALCULATOR USING SELECT CASE")
        Console.WriteLine()
        Console.WriteLine("ENTER THE FIRST NUMBER")
        While Not Double.TryParse(Console.ReadLine(), FirstNum) Or (FirstNum < 0)
            Console.WriteLine("Invalid Number")
        End While
        Console.WriteLine()
        Console.WriteLine("ENTER THE SECOND NUMBER")
        While Not Double.TryParse(Console.ReadLine(), SecondNum) Or (SecondNum < 0)
            Console.WriteLine("Invalid Number")
        End While
        Console.WriteLine()

        Do
            Console.WriteLine("ENTER ANY OPERATORS (+, -, *, /):")
            operation = Console.ReadLine()

            If (operation = "+") Or (operation = "-") Or (operation = "*") Or (operation = "/") Then
                Exit Do
            Else
                Console.WriteLine("Invalid  operator. Please select again")
            End If
        Loop

        Select Case operation
            Case "+"
                Result = FirstNum + SecondNum
                Console.WriteLine("Answer = " + Result.ToString)
            Case "-"
                Result = FirstNum - SecondNum
                Console.WriteLine("Answer = " + Result.ToString)
            Case "*"
                Result = FirstNum * SecondNum
                Console.WriteLine("Answer = " + Result.ToString)
            Case "/"
                If SecondNum <> 0 Then
                    Result = FirstNum / SecondNum
                    Console.WriteLine("Answer = " + Result.ToString)
                Else
                    Console.WriteLine("Error: Divsion by Zero isn't allowed!")
                End If
            Case Else
                Console.WriteLine("Invalid operation.")

        End Select


    End Sub

End Module
