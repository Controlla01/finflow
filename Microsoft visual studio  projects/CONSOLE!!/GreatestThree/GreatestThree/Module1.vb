Module Module1

    Sub Main()
        Dim FirstNumber, SecondNumber, ThirdNumber As Double
        Console.WriteLine("THIS SOFTWARE SHOWS THE GREATEST BETWEEN THREE NUMBERS")
        Console.WriteLine("")

        Console.WriteLine("Enter the First Number")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("")

        Console.WriteLine("Enter the Second Number")
        SecondNumber = Console.ReadLine()

        Console.WriteLine("")

        Console.WriteLine("Enter the Third Number")
        ThirdNumber = Console.ReadLine()

        If (FirstNumber = SecondNumber) And (SecondNumber = ThirdNumber) Then
            Console.WriteLine("The First Number (" + FirstNumber.ToString + "), The Second number (" + SecondNumber.ToString + ") and The Third Number (" + ThirdNumber.ToString + ") are equal")

        ElseIf (SecondNumber = ThirdNumber) And (ThirdNumber > FirstNumber) Then
            Console.WriteLine("Second Number and Third Number (" + SecondNumber.ToString + "), are equal and are greater than The First Number (" + FirstNumber.ToString + ")")
        ElseIf (FirstNumber = ThirdNumber) And (ThirdNumber > SecondNumber) Then
            Console.WriteLine("First Number and Third Number(" + FirstNumber.ToString + "), are equal and are greater than The Second number (" + SecondNumber.ToString + ")")
        ElseIf (FirstNumber = SecondNumber) And (FirstNumber > ThirdNumber) Then
            Console.WriteLine("First Number and Second Number(" + FirstNumber.ToString + "), are equal and are greater than The Third number (" + ThirdNumber.ToString + ")")

        ElseIf (SecondNumber = ThirdNumber) And (ThirdNumber < FirstNumber) Then
            Console.WriteLine("Second Number and Third Number (" + SecondNumber.ToString + "), are equal and are lesser than The First Number (" + FirstNumber.ToString + ")")
        ElseIf (FirstNumber = ThirdNumber) And (ThirdNumber < SecondNumber) Then
            Console.WriteLine("First Number and Third Number(" + FirstNumber.ToString + "), are equal and are lesser than The Second number (" + SecondNumber.ToString + ")")
        ElseIf (FirstNumber = SecondNumber) And (FirstNumber < ThirdNumber) Then
            Console.WriteLine("First Number and Second Number(" + FirstNumber.ToString + "), are equal and are lesser than The Third number (" + ThirdNumber.ToString + ")")

        ElseIf (SecondNumber > ThirdNumber) And (SecondNumber > FirstNumber) Then
            Console.WriteLine("The Second Number (" + SecondNumber.ToString + "), is greater than The First Number (" + FirstNumber.ToString + ") and The Third Number(" + ThirdNumber.ToString + ")")
        ElseIf (FirstNumber > ThirdNumber) And (FirstNumber > SecondNumber) Then
            Console.WriteLine("The First Number (" + FirstNumber.ToString + "), is greater than The Second number (" + SecondNumber.ToString + ")  and The Third Number(" + ThirdNumber.ToString + ")")
        ElseIf (ThirdNumber > SecondNumber) And (ThirdNumber > FirstNumber) Then
            Console.WriteLine("The Third Number (" + ThirdNumber.ToString + "), is greater than The Second Number (" + SecondNumber.ToString + ") and The First Number (" + FirstNumber.ToString + ")")





        End If



        Console.ReadLine()

    End Sub

End Module
