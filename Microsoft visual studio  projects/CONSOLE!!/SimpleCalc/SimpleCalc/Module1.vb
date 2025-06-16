Module Module1

    Sub Main()
        Dim FirstNum, SecondNum, Sum, Difference, Product, Fraction As Double
        Dim op As String

        Console.WriteLine("THIS SOFTWARE WORKS  AS A SIMPLE CALCULATOR")
        Console.WriteLine("")

        Console.WriteLine("Input 1 For Sum of Two Numbers")
        Console.WriteLine("")

        Console.WriteLine("Input 2 For Product of Two Numbers")
        Console.WriteLine("")

        Console.WriteLine("Input 3 For Difference of Two Numbers")
        Console.WriteLine("")

        Console.WriteLine("Input 4 for Fraction of Two Numbers")
        Console.WriteLine("")
        op = Console.ReadLine()


        If (op) = "1" Then

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

            Console.WriteLine("Sum = " + Sum.ToString)

        ElseIf (op) = "2" Then

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

            Console.WriteLine("Product = " + Product.ToString)


        ElseIf (op) = "3" Then

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

            Console.WriteLine("Difference = " + Difference.ToString)



        ElseIf (op) = "4" Then

            Console.WriteLine("THE FRACTION OF TWO NUMBERS")
            Console.WriteLine("=====================================================")

            Console.WriteLine("")

            Console.WriteLine("Input the Numerator")
            FirstNum = Console.ReadLine()

            Console.WriteLine("")

            Console.WriteLine("Input the Denominator")
            SecondNum = Console.ReadLine()

            If SecondNum <> 0 Then

                Fraction = FirstNum / SecondNum

                Console.WriteLine("")

                Console.WriteLine("Fraction = " + Fraction.ToString)

            Else
                Console.WriteLine("Error: Division by Zero is not allowed")


            End If

        Else
            Console.WriteLine("Invalid Input, please enter a number between 1 and 4")


        End If


        Console.ReadLine()

    End Sub

End Module
