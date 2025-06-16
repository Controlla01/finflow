Module Module1
    Dim YOUR_GPA, TP_totalPoints, TCU_totalCreditUnits, DBMS201, UI_UX202, AI204, SQT205, AA206, DEVOP207, RESULT As Double
    Dim GP_gradePoint As Integer

    Public Sub Main()
        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE WORKS AS A GP CALCULATOR FOR SECOND SEMESTER")
        Console.WriteLine("=============================================")
        Console.WriteLine("")

        Console.WriteLine("ENTER SCORE FOR Database Management System (DBMS201)  (5 UNITS)")
        FindDBMS201Pro()

        Console.WriteLine("ENTER SCORE FOR UI/UX Design (UI_UX202)  (3 UNITS)")
        FindUI_UX202Pro()

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Artificial Intelligence (AI204)  (5 UNITS)")
        FindAI204Pro()

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Software Quality Training (SQT205)  (3 UNITS)")
        FindSQT205Pro()

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Augumented Analysis (AA206)  (4 UNITS)")
        FindAA206Pro()

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Software Development And IT Operation (DEVOP207)  (4 UNITS)")
        FindDEVOP207Pro()

        Console.WriteLine("")

        TP_totalPoints = DBMS201 + UI_UX202 + AI204 + SQT205 + AA206 + DEVOP207
        TCU_totalCreditUnits = 5 + 3 + 5 + 3 + 4 + 4
        YOUR_GPA = TP_totalPoints / TCU_totalCreditUnits
        RESULT = Math.Round(YOUR_GPA, 2)
        Console.WriteLine("=============================================")
        Console.WriteLine("YOUR_GPA = " + YOUR_GPA.ToString("F2"))
        FindGPAPro()

        Console.WriteLine("")


        Console.ReadLine()
    End Sub


    Private Sub FindDBMS201Pro()
        If Not Double.TryParse(Console.ReadLine, DBMS201) Or (DBMS201 > 100) Or (DBMS201 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR DBMS201")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR DBMS201")
            If Not Double.TryParse(Console.ReadLine, DBMS201) Or (DBMS201 > 100) Or (DBMS201 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        Console.WriteLine("")
        If (DBMS201 >= 80) And (DBMS201 <= 100) Then
            DBMS201 = 4.0 * 5
        ElseIf (DBMS201 >= 70) And (DBMS201 <= 79.9) Then
            DBMS201 = 3.5 * 5
        ElseIf (DBMS201 >= 60) And (DBMS201 <= 69.9) Then
            DBMS201 = 3.0 * 5
        ElseIf (DBMS201 >= 50) And (DBMS201 <= 59.9) Then
            DBMS201 = 2.5 * 5
        ElseIf (DBMS201 >= 40) And (DBMS201 <= 49.9) Then
            DBMS201 = 2.0 * 5
        Else : DBMS201 = 0 * 5
        End If

    End Sub


    Private Sub FindUI_UX202Pro()
        If Not Double.TryParse(Console.ReadLine, UI_UX202) Or (UI_UX202 > 100) Or (UI_UX202 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR UI_UX202")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR UI_UX202")
            If Not Double.TryParse(Console.ReadLine, UI_UX202) Or (UI_UX202 > 100) Or (UI_UX202 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (UI_UX202 >= 80) And (UI_UX202 <= 100) Then
            UI_UX202 = 4.0 * 3
        ElseIf (UI_UX202 >= 70) And (UI_UX202 <= 79.9) Then
            UI_UX202 = 3.5 * 3
        ElseIf (UI_UX202 >= 60) And (UI_UX202 <= 69.9) Then
            UI_UX202 = 3.0 * 3
        ElseIf (UI_UX202 >= 50) And (UI_UX202 <= 59.9) Then
            UI_UX202 = 2.5 * 3
        ElseIf (UI_UX202 >= 40) And (UI_UX202 <= 49.9) Then
            UI_UX202 = 2.0 * 3
        Else : UI_UX202 = 0 * 3
        End If

    End Sub


    Private Sub FindAI204Pro()
        If Not Double.TryParse(Console.ReadLine, AI204) Or (AI204 > 100) Or (AI204 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR AI204")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR AI204")
            If Not Double.TryParse(Console.ReadLine, AI204) Or (AI204 > 100) Or (AI204 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (AI204 >= 80) And (AI204 <= 100) Then
            AI204 = 4.0 * 5
        ElseIf (AI204 >= 70) And (AI204 <= 79.9) Then
            AI204 = 3.5 * 5
        ElseIf (AI204 >= 60) And (AI204 <= 69.9) Then
            AI204 = 3.0 * 5
        ElseIf (AI204 >= 50) And (AI204 <= 59.9) Then
            AI204 = 2.5 * 5
        ElseIf (AI204 >= 40) And (AI204 <= 49.9) Then
            AI204 = 2.0 * 5
        Else : AI204 = 0 * 5
        End If

    End Sub


    Private Sub FindSQT205Pro()
        If Not Double.TryParse(Console.ReadLine, SQT205) Or (SQT205 > 100) Or (SQT205 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR SQT205")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR SQT205")
            If Not Double.TryParse(Console.ReadLine, SQT205) Or (SQT205 > 100) Or (SQT205 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (SQT205 >= 80) And (SQT205 <= 100) Then
            SQT205 = 4.0 * 3
        ElseIf (SQT205 >= 70) And (SQT205 <= 79.9) Then
            SQT205 = 3.5 * 3
        ElseIf (SQT205 >= 60) And (SQT205 <= 69.9) Then
            SQT205 = 3.0 * 3
        ElseIf (SQT205 >= 50) And (SQT205 <= 59.9) Then
            SQT205 = 2.5 * 3
        ElseIf (SQT205 >= 40) And (SQT205 <= 49.9) Then
            SQT205 = 2.0 * 3
        Else : SQT205 = 0 * 3
        End If

    End Sub


    Private Sub FindAA206Pro()
        If Not Double.TryParse(Console.ReadLine, AA206) Or (AA206 > 100) Or (AA206 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR AA206")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR AA206")
            If Not Double.TryParse(Console.ReadLine, AA206) Or (AA206 > 100) Or (AA206 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (AA206 >= 80) And (AA206 <= 100) Then
            AA206 = 4.0 * 4
        ElseIf (AA206 >= 70) And (AA206 <= 79.9) Then
            AA206 = 3.5 * 4
        ElseIf (AA206 >= 60) And (AA206 <= 69.9) Then
            AA206 = 3.0 * 4
        ElseIf (AA206 >= 50) And (AA206 <= 59.9) Then
            AA206 = 2.5 * 4
        ElseIf (AA206 >= 40) And (AA206 <= 49.9) Then
            AA206 = 2.0 * 4
        Else : AA206 = 0 * 4
        End If

    End Sub


    Private Sub FindDEVOP207Pro()
        If Not Double.TryParse(Console.ReadLine, DEVOP207) Or (DEVOP207 > 100) Or (DEVOP207 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR DEVOP207")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER FOR DEVOP207")
            If Not Double.TryParse(Console.ReadLine, DEVOP207) Or (DEVOP207 > 100) Or (DEVOP207 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
                End
            End If
        End If
        If (DEVOP207 >= 80) And (DEVOP207 <= 100) Then
            DEVOP207 = 4.0 * 4
        ElseIf (DEVOP207 >= 70) And (DEVOP207 <= 79.9) Then
            DEVOP207 = 3.5 * 4
        ElseIf (DEVOP207 >= 60) And (DEVOP207 <= 69.9) Then
            DEVOP207 = 3.0 * 4
        ElseIf (DEVOP207 >= 50) And (DEVOP207 <= 59.9) Then
            DEVOP207 = 2.5 * 4
        ElseIf (DEVOP207 >= 40) And (DEVOP207 <= 49.9) Then
            DEVOP207 = 2.0 * 4
        Else : DEVOP207 = 0 * 4
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
