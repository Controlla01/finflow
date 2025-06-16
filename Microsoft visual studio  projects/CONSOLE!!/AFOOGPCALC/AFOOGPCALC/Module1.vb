Module Module1
    Dim YOUR_GPA, TP_totalPoints, TCU_totalCreditUnits, SDT101, MAD102, SDA103, WAD104, NS105, AGD106, RESULT As Double
    Dim GP_gradePoint As Integer

    Public Sub Main()
        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE WORKS AS A GP CALCULATOR")
        Console.WriteLine("=============================================")
        Console.WriteLine("")

        Console.WriteLine("ENTER SCORE FOR Software Development Training (SDT101)  (4 UNITS)")
        FindSDT101Pro()

        Console.WriteLine("ENTER SCORE FOR Mobile Application Developmet (MAD102)  (4 UNITS)")
        FindMAD102Pro()
        
        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR System And Data Analysis (SDA103)  (5 UNITS)")
        FindSDA103Pro()
        
        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Website And Web Application Development (WAD104)  (4 UNITS)")
        FindWAD104Pro()
        
        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Networking And Security (NS105)  (4 UNITS)")
        FindNS105Pro()
        
        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Advanced Graphics Design (AGD106)  (4 UNITS)")
        FindAGD106Pro()

        Console.WriteLine("")

        TP_totalPoints = SDT101 + MAD102 + SDA103 + WAD104 + NS105 + AGD106
        TCU_totalCreditUnits = 4 + 4 + 5 + 4 + 4 + 4
        YOUR_GPA = TP_totalPoints / TCU_totalCreditUnits
        RESULT = Math.Round(YOUR_GPA, 2)
        Console.WriteLine("=============================================")
        Console.WriteLine("YOUR_GPA = " + YOUR_GPA.ToString("F2"))
        FindGPAPro()

        Console.WriteLine("")


        Console.ReadLine()
    End Sub

    Private Sub FindSDT101Pro()
        If Not Double.TryParse(Console.ReadLine, SDT101) Or (SDT101 > 100) Or (SDT101 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR SDT101")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR SDT101")
            If Not Double.TryParse(Console.ReadLine, SDT101) Or (SDT101 > 100) Or (SDT101 < 0) Then
                Console.WriteLine("INVALID SCORE!")

                End
            End If
        End If
        Console.WriteLine("")
        If (SDT101 >= 80) And (SDT101 <= 100) Then
            SDT101 = 4.0 * 4
        ElseIf (SDT101 >= 70) And (SDT101 <= 79.9) Then
            SDT101 = 3.5 * 4
        ElseIf (SDT101 >= 60) And (SDT101 <= 69.9) Then
            SDT101 = 3.0 * 4
        ElseIf (SDT101 >= 50) And (SDT101 <= 59.9) Then
            SDT101 = 2.5 * 4
        ElseIf (SDT101 >= 40) And (SDT101 <= 49.9) Then
            SDT101 = 2.0 * 4
        Else : SDT101 = 0 * 4
        End If

    End Sub

    Private Sub FindMAD102Pro()
        If Not Double.TryParse(Console.ReadLine, MAD102) Or (MAD102 > 100) Or (MAD102 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR MAD102")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR MAD102")
            If Not Double.TryParse(Console.ReadLine, MAD102) Or (MAD102 > 100) Or (MAD102 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (MAD102 >= 80) And (MAD102 <= 100) Then
            MAD102 = 4.0 * 4
        ElseIf (MAD102 >= 70) And (MAD102 <= 79.9) Then
            MAD102 = 3.5 * 4
        ElseIf (MAD102 >= 60) And (MAD102 <= 69.9) Then
            MAD102 = 3.0 * 4
        ElseIf (MAD102 >= 50) And (MAD102 <= 59.9) Then
            MAD102 = 2.5 * 4
        ElseIf (MAD102 >= 40) And (MAD102 <= 49.9) Then
            MAD102 = 2.0 * 4
        Else : SDT101 = 0 * 4
        End If

    End Sub

    Private Sub FindSDA103Pro()
        If Not Double.TryParse(Console.ReadLine, SDA103) Or (SDA103 > 100) Or (SDA103 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR SDA103")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR SDA103")
            If Not Double.TryParse(Console.ReadLine, SDA103) Or (SDA103 > 100) Or (SDA103 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (SDA103 >= 80) And (SDA103 <= 100) Then
            SDA103 = 4.0 * 5
        ElseIf (SDA103 >= 70) And (SDA103 <= 79.9) Then
            SDA103 = 3.5 * 5
        ElseIf (SDA103 >= 60) And (SDA103 <= 69.9) Then
            SDA103 = 3.0 * 5
        ElseIf (SDA103 >= 50) And (SDA103 <= 59.9) Then
            SDA103 = 2.5 * 5
        ElseIf (SDA103 >= 40) And (SDA103 <= 49.9) Then
            SDA103 = 2.0 * 5
        Else : SDA103 = 0 * 5
        End If

    End Sub

    Private Sub FindWAD104Pro()
        If Not Double.TryParse(Console.ReadLine, WAD104) Or (WAD104 > 100) Or (WAD104 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR WAD104")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR WAD104")
            If Not Double.TryParse(Console.ReadLine, WAD104) Or (WAD104 > 100) Or (WAD104 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (WAD104 >= 80) And (WAD104 <= 100) Then
            WAD104 = 4.0 * 4
        ElseIf (WAD104 >= 70) And (WAD104 <= 79.9) Then
            WAD104 = 3.5 * 4
        ElseIf (WAD104 >= 60) And (WAD104 <= 69.9) Then
            WAD104 = 3.0 * 4
        ElseIf (WAD104 >= 50) And (WAD104 <= 59.9) Then
            WAD104 = 2.5 * 4
        ElseIf (SDA103 >= 40) And (WAD104 <= 49.9) Then
            WAD104 = 2.0 * 4
        Else : WAD104 = 0 * 4
        End If

    End Sub

    Private Sub FindNS105Pro()
        If Not Double.TryParse(Console.ReadLine, NS105) Or (NS105 > 100) Or (NS105 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR NS105")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR NS105")
            If Not Double.TryParse(Console.ReadLine, NS105) Or (NS105 > 100) Or (NS105 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (NS105 >= 80) And (NS105 <= 100) Then
            NS105 = 4.0 * 4
        ElseIf (NS105 >= 70) And (NS105 <= 79.9) Then
            NS105 = 3.5 * 4
        ElseIf (NS105 >= 60) And (NS105 <= 69.9) Then
            NS105 = 3.0 * 4
        ElseIf (NS105 >= 50) And (NS105 <= 59.9) Then
            NS105 = 2.5 * 4
        ElseIf (NS105 >= 40) And (NS105 <= 49.9) Then
            NS105 = 2.0 * 4
        Else : NS105 = 0 * 4
        End If

    End Sub

    Private Sub FindAGD106Pro()
        If Not Double.TryParse(Console.ReadLine, AGD106) Or (AGD106 > 100) Or (AGD106 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR AGD106")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR AGD106")
            If Not Double.TryParse(Console.ReadLine, AGD106) Or (AGD106 > 100) Or (AGD106 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (AGD106 >= 80) And (AGD106 <= 100) Then
            AGD106 = 4.0 * 4
        ElseIf (AGD106 >= 70) And (AGD106 <= 79.9) Then
            AGD106 = 3.5 * 4
        ElseIf (AGD106 >= 60) And (AGD106 <= 69.9) Then
            AGD106 = 3.0 * 4
        ElseIf (AGD106 >= 50) And (AGD106 <= 59.9) Then
            AGD106 = 2.5 * 4
        ElseIf (AGD106 >= 40) And (AGD106 <= 49.9) Then
            AGD106 = 2.0 * 4
        Else : AGD106 = 0 * 4
        End If

    End Sub

    Private Sub FindGPAPro()
        If (YOUR_GPA >= 3.5) And (YOUR_GPA <= 4.0) Then
            Console.WriteLine("CLASS CATEGORY = DISTINCTION")
        ElseIf (YOUR_GPA >= 3.0) And (YOUR_GPA <= 3.49) Then
            Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
        ElseIf (YOUR_GPA >= 2.5) And (YOUR_GPA <= 2.99) Then
            Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
        ElseIf (YOUR_GPA >= 2.0) And (YOUR_GPA <= 2.49) Then
            Console.WriteLine("CLASS CATEGORY = PASS")
        Else
            Console.WriteLine("CLASS CATEGORY = FAIL")
        End If
    End Sub


End Module
