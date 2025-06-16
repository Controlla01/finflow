Module Module1

    Sub Main()
        Dim FirstNumber, SecondNumber As Integer
        Console.WriteLine("THIS SOFTWARE SHOWS THE GREATEST BETWEEN TWO NUMBERS")
        Console.WriteLine("")

        Console.WriteLine("Enter the First Number")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("")

        Console.WriteLine("Enter the Second Number")
        SecondNumber = Console.ReadLine()

        Console.WriteLine("")

        If (FirstNumber > SecondNumber) Then
            Console.WriteLine("The Greatest Number is the First Number (" + FirstNumber.ToString + "), While the Lowest is the Second Number (" + SecondNumber.ToString + ")")
        ElseIf (SecondNumber > FirstNumber) Then
            Console.WriteLine("The Greatest Number is the Second Number (" + SecondNumber.ToString + "), While the Lowest is the First Number (" + FirstNumber.ToString + ")")
        Else
            Console.WriteLine("The First Number (" + FirstNumber.ToString + ") and The Second number (" + SecondNumber.ToString + ") are equal")

        End If



        Console.ReadLine()

    End Sub

End Module
