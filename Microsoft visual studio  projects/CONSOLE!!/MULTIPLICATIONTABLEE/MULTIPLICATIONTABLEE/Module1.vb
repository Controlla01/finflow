Module Module1

    Sub Main()
        Dim i, sum, opp, op, result As Integer
        Console.WriteLine()
        Console.WriteLine("THIS SOFTWARE WORKS AS A MULTIPLICATION TABLE ")
        Console.WriteLine("======================================================")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("INPUT MULTIPLICATION NUMBER")
        If Not Integer.TryParse(Console.ReadLine(), op) Or (op < 1) Then
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
            Console.WriteLine("")
            Console.WriteLine("Re-enter Multiplication Number")
            If Not Integer.TryParse(Console.ReadLine(), op) Or (op < 1) Then
                Console.WriteLine("Invalid number.")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine()
        Console.WriteLine("INPUT NUMBER TO BE MULTIPLIED WITH")
        If Not Integer.TryParse(Console.ReadLine(), opp) Or (opp < 1) Then
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
            Console.WriteLine("")
            Console.WriteLine("Re-enter Multiplication Number")
            If Not Integer.TryParse(Console.ReadLine(), opp) Or (opp < 1) Then
                Console.WriteLine("Invalid number.")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine()
        sum = 0
        For i = 1 To opp
            result = op + opp
            'i = i + 1
            sum = sum + op
            Console.WriteLine(op.ToString + " x " + i.ToString + " = " + sum.ToString)
            Console.WriteLine()
        Next


        Console.ReadLine()

    End Sub

End Module
