Module Module1

    Sub Main()
        Dim i, sum, op As Integer
        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE WORKS AS A MULTIPLICATION TABLE ")
        Console.WriteLine("======================================================")
        Console.WriteLine("")
        Console.WriteLine("INPUT MULTIPLICATION NUMBER")
        While Not Double.TryParse(Console.ReadLine(), op) Or (op < 1)
            Console.WriteLine("Invalid number. Don't press nonsense again sir/ma.. its ur last chance")
        End While
        Console.WriteLine("")

        Console.WriteLine("")
        sum = 0
        While sum < 12
            sum = sum + i
            'Console.WriteLine(sum.ToString)
            i = i + 1
            sum = sum + op
            Console.WriteLine(op.ToString + " x " + i.ToString + " = " + sum.ToString)
            Console.WriteLine("")
        End While


        Console.ReadLine()

    End Sub

End Module
