Module Module1

    Sub Main()
        Dim Input, Mum As Double

        Console.WriteLine()
        Console.WriteLine("=======================================================================")
        Console.WriteLine()
        Console.WriteLine("ENTER NUMBER TO FIND PRODUCT")
        While Not Double.TryParse(Console.ReadLine(), Input) Or (Input < 1)
            Console.WriteLine("Invalid number... Please press correct number ")
        End While

        For x = 1 To Input
            Mum = 0
            For i = 1 To 12
                Mum = Mum + x
                Console.WriteLine()
                Console.WriteLine(x.ToString + " * " + i.ToString + " = " + Mum.ToString)
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub

End Module
