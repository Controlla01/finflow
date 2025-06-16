Module AREAOFACIRCLE
    Sub AREAOFACIRCLE()
        Dim r, Pi, area As Double

        Console.WriteLine("This Software Calculates the  Area of a Circle")
        Console.WriteLine("")

        Console.WriteLine("Input the  value of the  radius")
        While Not Double.TryParse(Console.ReadLine, r) Or (r < 0)
            Console.WriteLine("Incorrect Input, Please Re-enter")
        End While


        Pi = 3.142

        area = 3.142 * r * r

        Console.WriteLine("result = " + area.ToString)
        Console.ReadLine()

    End Sub

End Module
