Module Module1

    Sub Main()
        Dim HouseInput, FirstNum, SecondNum, Sum, Difference, Product, Fraction As Double

        Console.WriteLine("THIS SOFTWARE WORKS  AS A SIMPLE CALCULATOR")
        Console.WriteLine("")

        Console.WriteLine("Input 1 For Sum of Two Numbers")
        Console.WriteLine("")

        Console.WriteLine("Input  2  For Product of Two Numbers")
        Console.WriteLine("")

        Console.WriteLine("Input 3 For Difference of Two Numers")
        Console.WriteLine("")

        Console.WriteLine("Input 4 for Fraction of Two Numbers")
        Console.WriteLine("")




        If HouseInput = 1 Then

            Console.WriteLine("THE SUM OF TWO NUMBERS")
            Console.WriteLine("=====================================================")

            Console.WriteLine("")

            Console.WriteLine("Input the First Number")
            FirstNum = Console.ReadLine()

            Console.WriteLine("")

            Console.WriteLine("Input the Second Number")
            SecondNum = Console.ReadLine()

            Sum = FirstNum + SecondNum

            Console.WriteLine("")

            Console.WriteLine("Answer = " + Sum.ToString)

        ElseIf HouseInput = 2 Then

            Console.WriteLine("THE PRODUCT OF TWO NUMBERS")
            Console.WriteLine("=====================================================")

            Console.WriteLine("")

            Console.WriteLine("Input the First Number")
            FirstNum = Console.ReadLine()

            Console.WriteLine("")

            Console.WriteLine("Input the Second Number")
            SecondNum = Console.ReadLine()

            Product = FirstNum * SecondNum

            Console.WriteLine("")

            Console.WriteLine("Answer = " + Product.ToString)


        ElseIf HouseInput = 3 Then

            Console.WriteLine("THE DIFFERENCE OF TWO NUMBERS")
            Console.WriteLine("=====================================================")

            Console.WriteLine("")

            Console.WriteLine("Input the First Number")
            FirstNum = Console.ReadLine()

            Console.WriteLine("")

            Console.WriteLine("Input the Second Number")
            SecondNum = Console.ReadLine()

            Difference = FirstNum - SecondNum

            Console.WriteLine("")

            Console.WriteLine("Answer = " + Difference.ToString)



        ElseIf HouseInput = 4 Then

            Console.WriteLine("THE FRACTION OF TWO NUMBERS")
            Console.WriteLine("=====================================================")

            Console.WriteLine("")

            Console.WriteLine("Input the First Number")
            FirstNum = Console.ReadLine()

            Console.WriteLine("")

            Console.WriteLine("Input the Second Number")
            SecondNum = Console.ReadLine()

            Fraction = FirstNum / SecondNum

            Console.WriteLine("")

            Console.WriteLine("Answer = " + Fraction.ToString)


        Else






        End If


        Console.ReadLine()



    End Sub

End Module
