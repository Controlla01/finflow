Module Module1

    Sub Main()
        Dim Firstno, Secondno As Double

        Console.WriteLine()
        Console.WriteLine("======================================================")
        Console.WriteLine("THIS SOFTWARE PERFORMS SUMMATION OF TWO NUMBERS")
        Console.WriteLine("======================================================")
        Console.WriteLine()
        Console.WriteLine("Enter the First number")
        While Not Double.TryParse(Console.ReadLine, Firstno) Or (Firstno < 0)
            Console.WriteLine("Invalid Input, Please Re-enter correctly")
        End While
        Console.WriteLine()
        Console.WriteLine("Enter the Second number")
        While Not Double.TryParse(Console.ReadLine, Secondno) Or (Secondno < 0)
            Console.WriteLine("Invalid Input, Please Re-enter correctly")
        End While

        Dim Sum = Firstno + Secondno
        Console.WriteLine()
        Console.WriteLine("SUM = " + Sum.ToString)


        Console.ReadLine()

    End Sub

    Function addTwo(ByVal Firstno As Double, ByVal Secondno As Double)
        Dim Result As Double
        Result = Firstno + Secondno
        Return Result
    End Function

End Module
