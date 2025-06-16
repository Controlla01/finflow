Module Module1

    Sub Main()
        Dim a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v As Double

        Console.WriteLine()
        Console.WriteLine("==================================================================")
        Console.WriteLine("This Software Performs Quadractic Equation")
        Console.WriteLine("==================================================================")
        Console.WriteLine("Input the first number as value of (a)")
        While Not Double.TryParse(Console.ReadLine, a)
            Console.WriteLine("Incorrect Input")
        End While
        Console.WriteLine()
        Console.WriteLine("Input the second number as value of (b)")
        While Not Double.TryParse(Console.ReadLine, b)
            Console.WriteLine("Incorrect Input")
        End While
        Console.WriteLine()
        Console.WriteLine("Input the third number as value of (c)")
        While Not Double.TryParse(Console.ReadLine, c)
            Console.WriteLine("Incorrect Input")
        End While
        Console.WriteLine()
        d = getAAA(a) * c
        e = getAA(a) * b
        f = d / e
        g = getAB(a, b) * b
        h = getAA(a) * c
        i = g / h
        j = f * i
        k = getAB(a, b)
        l = j / k
        m = Math.Sqrt(l)
        n = k * k
        o = getAA(a) * b * b
        p = h * h
        q = o + p
        r = getAAA(a) * a
        s = q / r
        t = m * s
        u = getAA(a) * b * c
        v = t / u

        Console.WriteLine()
        Console.WriteLine("Answer = " + v.ToString("f3"))


        Console.ReadLine()


    End Sub

    Function getAA(ByVal a As Double)
        Dim d As Double
        d = a * a
        Return d
    End Function

    Function getAAC(ByVal a As Double, ByVal c As Double)
        Dim e As Double
        e = a * a * c
        Return e
    End Function

    Function getAB(ByVal a As Double, ByVal b As Double)
        Dim f As Double
        f = a * b
        Return f
    End Function
    Function getAAA(ByVal a As Double)
        Dim q As Double
        q = a * a * a
        Return q
    End Function

End Module

