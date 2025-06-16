Module Module1

    Sub Main()
        Dim radius, Pi, circumference, a As Double

        Console.WriteLine("This Software Calculates the  Circumference of a Circle")
        Console.WriteLine("")

        Console.WriteLine("Input the  value of the  radius")
        radius = Console.ReadLine()

        Console.WriteLine("")
        Pi = 3.142
        a = 2

        circumference = a * Pi * radius
        Console.WriteLine("result = " + circumference.ToString)

        
        Console.ReadLine()

    End Sub

End Module
