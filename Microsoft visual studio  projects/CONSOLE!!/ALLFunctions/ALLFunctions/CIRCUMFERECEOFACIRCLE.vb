Module CIRCUMFERECEOFACIRCLE
    Sub CIRCUMFERECEOFACIRCLE()

        Dim radius, Pi, circumference, a As Double

        Console.WriteLine()
        Console.WriteLine("This Software Calculates the  Circumference of a Circle")
        Console.WriteLine()

        Console.WriteLine("Input the  value of the  radius")
        While Not Double.TryParse(Console.ReadLine, radius) Or (radius < 0)
            Console.WriteLine("Incorrect Input, Please Re-enter")
        End While

        Console.WriteLine()
        Pi = 3.142
        a = 2

        circumference = a * Pi * radius
        Console.WriteLine("result = " + circumference.ToString)


        Console.ReadLine()

    End Sub

End Module
