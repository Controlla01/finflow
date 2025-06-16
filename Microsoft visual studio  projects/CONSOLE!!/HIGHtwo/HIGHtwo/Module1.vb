Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("THIS SOFTWARE SHOWS THE GREATEST BETWEEN TWO NUMBERS")
        Console.WriteLine("")

        Console.WriteLine("Enter the First Number")
        a = Console.ReadLine()

        Console.WriteLine("Enter the Second Number")
        b = Console.ReadLine()

        If a > b Then
            Console.WriteLine("Greatest = " + a.ToString)
        Else
            Console.WriteLine("Greatest = " + b.ToString)

        End If



        Console.ReadLine()


    End Sub

End Module
