Module Module1

    Sub Main()
        Dim operation As Double
        Dim condition As Integer
        Console.WriteLine()
        Console.WriteLine("This software works as a FOR LOOP MULTIPURPOSE CALCULATOR")
        Console.WriteLine("============================================================")
        Console.WriteLine()
        Do
            Console.WriteLine("Enter 1 (one) for Sum")
            Console.WriteLine()
            Console.WriteLine("Enter 2 (two) for Differences")
            Console.WriteLine()
            Console.WriteLine("Enter 3 (three) for Product")
            Console.WriteLine()
            Console.WriteLine("Enter 4 (four) for Fraction")
            Console.WriteLine()
            Console.WriteLine("Enter 5 (five) for Modulus")
            Console.WriteLine()
            Console.WriteLine("Any other number or letter na invalid ooo")
            Console.WriteLine()
            While Not Double.TryParse(Console.ReadLine(), operation) Or (operation < 1) Or (operation > 5)
                Console.WriteLine("Invalid number. Please Don't press incorrect number again sir/ma, I don beg u now.. its ur last chance")
                Console.WriteLine("")
            End While
            Console.WriteLine()

            If operation = 1 Then
                FindSumPro()

            ElseIf operation = 2 Then
                FindDiffPro()

            ElseIf operation = 3 Then
                FindDProductPro()

            ElseIf operation = 4 Then
                FindDFractionPro()

            ElseIf operation = 5 Then
                FindDModPro()

            End If

            Console.WriteLine()
            Console.WriteLine("PRESS 1 TO GO TO HOMEPAGE")
            Console.WriteLine("PRESS 2 TO EXIT")
            Console.WriteLine()
            While Not Integer.TryParse(Console.ReadLine(), condition) Or (condition > 2) Or (condition < 1)
                Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
            End While

            Console.Clear()
        Loop Until condition = 2
        Exit Sub

        Console.ReadLine()

    End Sub


    Private Sub FindSumPro()
        Dim input, sum, yello As Double

        Console.WriteLine("Enter number to find Sum")
        While Not Double.TryParse(Console.ReadLine, input) Or (input < 0)
            Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
        End While
        sum = 0
        For i = 1 To 12
            yello = input + i
            Console.WriteLine(input.ToString + " + " + i.ToString + " = " + yello.ToString)
            Console.WriteLine()
        Next

    End Sub

    Private Sub FindDiffPro()
        Dim input, sum, yello As Double

        Console.WriteLine("Enter number to find Differences")
        While Not Double.TryParse(Console.ReadLine(), input) Or (input < 0)
            Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
        End While
        sum = 0
        For i = 1 To 12
            yello = input - i
            Console.WriteLine(input.ToString + " - " + i.ToString + " = " + yello.ToString)
            Console.WriteLine()
        Next

    End Sub

    Private Sub FindDProductPro()
        Dim input, sum, yello As Double

        Console.WriteLine("Enter number to find Product")
        While Not Double.TryParse(Console.ReadLine(), input) Or (input < 1)
            Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
        End While
        sum = 1
        For i = 1 To 12
            yello = input * i
            Console.WriteLine(input.ToString + " * " + i.ToString + " = " + yello.ToString)
            Console.WriteLine()
        Next
    End Sub

    Private Sub FindDFractionPro()
        Dim input, sum As Double

        Console.WriteLine("Enter number to find Fraction")
        While Not Double.TryParse(Console.ReadLine(), input) Or (input <= 0)
            Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
        End While
        sum = 1
        For i = 1 To 12
            sum = Math.Round(input / i, 2)
            Console.WriteLine(input.ToString + " / " + i.ToString + " = " + sum.ToString("F2"))
            Console.WriteLine()
        Next

    End Sub

    Private Sub FindDModPro()
        Dim input, yello As Double

        Console.WriteLine("Enter number to find Modulus")
        While Not Double.TryParse(Console.ReadLine(), input) Or (input <= 0)
            Console.WriteLine("Invalid number. Don't press incorrect number again sir/ma.. its ur last chance")
        End While
        'input = 1
        For i = 1 To 12
            yello = input Mod i
            Console.WriteLine(Input.ToString + " % " + i.ToString + " = " + yello.ToString)
            Console.WriteLine()
        Next


    End Sub

End Module
