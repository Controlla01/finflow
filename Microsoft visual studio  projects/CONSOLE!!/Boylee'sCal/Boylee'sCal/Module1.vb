Module Module1

    Sub Main()
        Dim P1, V1, P2, V2 As Double
        Dim op As String

        Console.WriteLine("Welcome to Boyle's  Law Calculator")
        Console.WriteLine("========================================")
        Console.WriteLine("")

        Console.WriteLine("Input P1  to Calculate Initial Pressure")
        Console.WriteLine("")

        Console.WriteLine("Input V1  to Calculate Initial Volume")
        Console.WriteLine("")

        Console.WriteLine("Input P2  to Calculate Final Pressure")
        Console.WriteLine("")

        Console.WriteLine("Input V2  to Calculate Final Volume")
        Console.WriteLine("")
        op = Console.ReadLine().ToUpper()
        Console.WriteLine("")

        If (op = "P1" Or op = "V1" Or op = "P2" Or op = "V2") Then
        Else
            Console.WriteLine("Invalid Choice")
        End If

        If op = "P1" Then
            Console.WriteLine("")
            Console.WriteLine("Enter Final Pressure")
            P2 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Final Volume")
            V2 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Initial Volume")
            V1 = Console.ReadLine()
            Console.WriteLine("")

            If V1 = 0 Then
                Console.WriteLine("Error: Division by Zero is not allowed.")
            Else
                P1 = (P2 * V2) / V1
                Console.WriteLine("")

                Console.WriteLine("P1 = " + P1.ToString)
            End If

        ElseIf op = "V1" Then
            Console.WriteLine("Enter Final Pressure")
            P2 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Final Volume")
            V2 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Initial Pressure")
            P1 = Console.ReadLine()
            Console.WriteLine("")

            If P1 = 0 Then
                Console.WriteLine("Error: Division by Zero is not allowed.")
            Else
                V1 = (P2 * V2) / P1
                Console.WriteLine("")

                Console.WriteLine("V1 = " + V1.ToString)
            End If

        ElseIf op = "P2" Then
            Console.WriteLine("Enter Initial Pressure")
            P1 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Initial Volume")
            V1 = Console.ReadLine
            Console.WriteLine("")

            Console.WriteLine("Enter Final Volume")
            V2 = Console.ReadLine
            Console.WriteLine("")

            If V2 = 0 Then
                Console.WriteLine("Error: Division by Zero is not allowed.")
            Else
                P2 = (P1 * V1) / V2
                Console.WriteLine("")

                Console.WriteLine("P2 = " + P2.ToString)
            End If

        ElseIf op = "V2" Then
            Console.WriteLine("Enter Initial Pressure")
            P1 = Console.ReadLine()
            Console.WriteLine("")

            Console.WriteLine("Enter Initial Volume")
            V1 = Console.ReadLine
            Console.WriteLine("")

            Console.WriteLine("Enter Final Pressure")
            P2 = Console.ReadLine
            Console.WriteLine("")

            If P2 = 0 Then
                Console.WriteLine("Error: Division by Zero is not allowed.")
            Else
                V2 = (P1 * V1) / P2
                Console.WriteLine("")

                Console.WriteLine("V2 = " + V2.ToString)
            End If






        End If


        Console.ReadLine()

    End Sub

End Module
