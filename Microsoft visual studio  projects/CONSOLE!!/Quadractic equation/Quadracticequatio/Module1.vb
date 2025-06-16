Module Module1

    Sub Main()
        Dim a, b, c, d, e, f, g, h, i, denominator, x1, x2 As Double

        Console.WriteLine("This Software Performs Quadractic Equation")
        Console.WriteLine("")

        Console.WriteLine("Input the  value of a")
        a = Console.ReadLine()

        Console.WriteLine("")

        Console.WriteLine("Input the  value of b")
        b = Console.ReadLine()

        Console.WriteLine("")

        Console.WriteLine("Input the  value of c")
        c = Console.ReadLine()

        Console.WriteLine("")

        d = b * b

        e = 4 * a * c

        f = d - e

        g = Math.Sqrt(f)

        denominator = 2 * a

        h = -b + g

        i = -b - g

        x1 = Math.Round((h / denominator), 3)

        x2 = Math.Round((i / denominator), 3)

        Console.WriteLine("")

        Console.WriteLine("x1 = " + x1.ToString)

        Console.WriteLine("")

        Console.WriteLine("x2 = " + x2.ToString)


        Console.ReadLine()


    End Sub

End Module
