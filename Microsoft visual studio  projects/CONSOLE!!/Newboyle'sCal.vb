Module Module1
    Dim P1, V1, P2, V2, a, Result As Double
    Dim op As Integer

    Public Sub Main()

        Console.WriteLine("Welcome to Boyle's  Law Calculator")
        Console.WriteLine("===========================================")
        Console.WriteLine("")

        Console.WriteLine("Input 1 to Calculate Initial Pressure (P1)")
        Console.WriteLine("Input 2 to Calculate Initial Volume (V1)")
        Console.WriteLine("Input 3 to Calculate Final Pressure (P2)")
        Console.WriteLine("Input 4 to Calculate Final Volume (V2)")
        Console.WriteLine("===========================================")
        Console.WriteLine("")

        If Not Integer.TryParse(Console.ReadLine, op) Or (op > 4) Or (op = 0) Then

            Console.WriteLine("")
            Console.WriteLine("Invalid Choice!!! Please select correctly")
            Console.WriteLine("Input 1 to Calculate Initial Pressure (P1)")
            Console.WriteLine("Input 2 to Calculate Initial Volume (V1)")
            Console.WriteLine("Input 3 to Calculate Final Pressure (P2)")
            Console.WriteLine("Input 4 to Calculate Final Volume (V2)")
            Console.WriteLine("===========================================")

            op = Console.ReadLine()
            Console.WriteLine("")
        End If

        If (op = 1) Then
            findP1Pro()
        ElseIf (op = 2) Then
            findV1Pro()
        ElseIf (op = "3") Then
            findP2Pro()
        ElseIf (op = "4") Then
            findV2Pro()

        End If

        Console.ReadLine()

    End Sub


    Private Sub findP1Pro()
        Console.WriteLine("To Find Initial Pressure (P1)")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("")
        Console.WriteLine("Enter Final Pressure (P2)")
        If Not Double.TryParse(Console.ReadLine, P2) Or (P2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Pressure (P2)")
            P2 = Console.ReadLine()
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Final Volume (V2)")
        If Not Double.TryParse(Console.ReadLine, V2) Or (V2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Volume (V2)")
            V2 = Console.ReadLine()
            Console.WriteLine("")
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Initial Volume (V1)")
        If Not Double.TryParse(Console.ReadLine, V1) Or (V1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Initial Volume (V1)")
            V1 = Console.ReadLine()
        End If
        Console.WriteLine("")

        a = P2 * V2
        P1 = a / V1
        Result = Math.Round(P1, 3)
        Console.WriteLine("Initial Pressure (P1) = " + Result.ToString + " mm Hg")
    End Sub

    Private Sub findV1Pro()
        Console.WriteLine("To Find Initial Volume (V1)")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("")
        Console.WriteLine("--------------------------------")
        Console.WriteLine("Enter Final Pressure (P2)")
        If Not Double.TryParse(Console.ReadLine, P2) Or (P2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Pressure (P2)")
            P2 = Console.ReadLine()
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Final Volume (V2)")
        If Not Double.TryParse(Console.ReadLine, V2) Or (V2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Volume (V2)")
            V2 = Console.ReadLine()
            Console.WriteLine("")
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Initial Pressure (P1)")
        If Not Double.TryParse(Console.ReadLine, V1) Or (V1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("Enter Initial Pressure (P1)")
            P1 = Console.ReadLine()
        End If
        Console.WriteLine("")

        a = P2 * V2
        V1 = a / P1
        Result = Math.Round(V1, 3)
        Console.WriteLine("Initial Volume (V1) = " + Result.ToString + " Litres")
    End Sub

    Private Sub findP2Pro()
        Console.WriteLine("To Find Final Pressure (P2)")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("")
        Console.WriteLine("--------------------------------")
        Console.WriteLine("Enter Initial Pressure (P1)")
        If Not Double.TryParse(Console.ReadLine, P1) Or (P1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Initial Pressure (P1)")
            P1 = Console.ReadLine()
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Initial Volume (V1)")
        If Not Double.TryParse(Console.ReadLine, V1) Or (V1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Initial Volume (V1)")
            V1 = Console.ReadLine()
            Console.WriteLine("")
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Final Volume (V2)")
        If Not Double.TryParse(Console.ReadLine, V2) Or (V2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Volume (V2)")
            V2 = Console.ReadLine()
            Console.WriteLine("")
        End If

        a = P1 * V1
        P2 = a / V2
        Result = Math.Round(P2, 3)
        Console.WriteLine("Initial Pressure (P2) = " + Result.ToString + " mm Hg")
    End Sub

    Private Sub findV2Pro()
        Console.WriteLine("To Find Final Volume (V2)")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("")
        Console.WriteLine("--------------------------------")
        Console.WriteLine("Enter Initial Pressure (P1)")
        If Not Double.TryParse(Console.ReadLine, P1) Or (P1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Initial Pressure (P1)")
            P1 = Console.ReadLine()
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Initial Volume (V1)")
        If Not Double.TryParse(Console.ReadLine, V1) Or (V1 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Initial Volume (V1)")
            V1 = Console.ReadLine()
            Console.WriteLine("")
        End If

        Console.WriteLine("")
        Console.WriteLine("Enter Final Pressure (P2)")
        If Not Double.TryParse(Console.ReadLine, P2) Or (P2 = 0) Then
            Console.WriteLine("Invalid Input, You have one(1) more chance!")
            Console.WriteLine("")
            Console.WriteLine("Enter Final Pressure (P2)")
            P2 = Console.ReadLine()
        End If
        Console.WriteLine("")

        a = P1 * V1
        V2 = a / P2
        Result = Math.Round(V2, 3)
        Console.WriteLine("Final Volume (V2) = " + Result.ToString + " Litres")
    End Sub



End Module
