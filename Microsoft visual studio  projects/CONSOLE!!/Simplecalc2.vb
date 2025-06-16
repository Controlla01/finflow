Module Module1

    Sub Main()

        Dim FirstNum, SecondNum, Result As Double
        Dim op As String

        Console.WriteLine("Welcome to SimpleCalc 2.0")
        Console.WriteLine("==========================================")
        Console.WriteLine("")


        Console.WriteLine("Input  first Number")
        While Not Double.TryParse(Console.ReadLine(), FirstNum)
            Console.WriteLine("Invalid Input. Please enter a valid number for the first number.")
        End While

        Console.WriteLine("")
        Do
            Console.WriteLine("Enter Arithmetic Symbol (+), (-), (*), (/)")
            op = Console.ReadLine()

            If (op = "+") Or (op = "-") Or (op = "*") Or (op = "/") Then
                Exit Do
            Else
                Console.WriteLine("Invalid  operator. Please select again")
            End If
        Loop

        Console.WriteLine("")
        Console.WriteLine("Input  Second Number")
        While Not Double.TryParse(Console.ReadLine(), SecondNum)
            Console.WriteLine("Invalid Input. Please enter a valid number for the Second number.")
        End While

        Console.WriteLine("")
        If op = "+" Then
            Result = FirstNum + SecondNum
            Console.WriteLine("Result = " + Result.ToString)

        ElseIf op = "-" Then
            Result = FirstNum - SecondNum
            Console.WriteLine("Result = " + Result.ToString)

        ElseIf op = "*" Then
            Result = FirstNum * SecondNum
            Console.WriteLine("Result = " + Result.ToString)

        ElseIf op = "/" Then
            If SecondNum <> 0 Then
                Result = Math.Round(FirstNum / SecondNum, 3)
                Console.WriteLine("Result = " + Result.ToString)

            Else
                Console.WriteLine("Invalid input: Division by zero is not allowed.")
            End If
        End If

        Console.ReadLine()

    End Sub

End Module
