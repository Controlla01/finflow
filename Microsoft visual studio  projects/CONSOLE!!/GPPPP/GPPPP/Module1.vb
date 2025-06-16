Module Module1

    Dim First_sems, Second_sems, FIRST_GPA, SECOND_GPA, YOUR_CGPA, CGPA As Double

    Public Sub Main()
        Dim op As Integer
        Console.WriteLine("==========================================================")
        Console.WriteLine("THIS SOFTWARE CALCULATES THE CGPA OF TWO SEMESTERS")
        Console.WriteLine("==========================================================")
        Console.WriteLine("")
        Console.WriteLine("PRESS ONE(1) TO CALCULATE THE GPA FOR THE FIRST SEMESTER")
        Console.WriteLine("")
        Console.WriteLine("PRESS TWO(2) TO CALCULATE THE GPA FOR THE SECOND SEMESTER")
        Console.WriteLine("")
        Console.WriteLine("PRESS THREE(3) TO CALCULATE THE CGPA")
        Console.WriteLine("")
        If Not Integer.TryParse(Console.ReadLine, op) Or (op > 3) Or (op < 1) Then
            Console.WriteLine("INVALID INPUT!! PLEASE SELECT FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (1 - 3")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER INPUT")
            If Not Integer.TryParse(Console.ReadLine, op) Or (op > 3) Or (op < 1) Then
                Console.WriteLine("INVALID INPUT!")
                Console.ReadLine()
                End
            End If
        End If

        Console.WriteLine("")

        If (op = 1) Then
            First_semsPro()
        ElseIf (op = 2) Then
            Second_semsPro()
        Else
            FindCGPAPro()
        End If

        Console.WriteLine("")

        Console.ReadLine()
    End Sub

    Private Sub First_semsPro()
        Dim TP_totalPoints, TCU_totalCreditUnits, SDT101, MAD102, SDA103, WAD104, NS105, AGD106, FIRST_GPA As Double

        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE Calculates the scores for First Semester")
        Console.WriteLine("=============================================")
        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Software Development Training (SDT101)  (4 UNITS)")
        Console.WriteLine("")
        If Not Double.TryParse(Console.ReadLine, SDT101) Or (SDT101 > 100) Or (SDT101 < 0) Then
            Console.WriteLine("INVALID SCORE!! PLEASE INPUT SCORE FOR THE LAST TIME, ENTER A VALID NUMERIC SCORE FROM (0 - 100) FOR SDT101")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER SCORE FOR SDT101")
            If Not Double.TryParse(Console.ReadLine, SDT101) Or (SDT101 > 100) Or (SDT101 < 0) Then
                Console.WriteLine("INVALID SCORE!")
                Console.ReadLine()
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Mobile Application Development (MAD102)  (4 UNITS)")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR System And Data Analysis (SDA103)  (5 UNITS)")
        Console.WriteLine("")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Website And Web Application Development (WAD104)  (4 UNITS)")
        Console.WriteLine("")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Networking And Security (NS105)  (4 UNITS)")
        Console.WriteLine("")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Advanced Graphics Design (AGD106)  (4 UNITS)")
        Console.WriteLine("")
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

        Console.WriteLine("")
        TP_totalPoints = SDT101 + MAD102 + SDA103 + WAD104 + NS105 + AGD106
        TCU_totalCreditUnits = 4 + 4 + 5 + 4 + 4 + 4
        FIRST_GPA = TP_totalPoints / TCU_totalCreditUnits
        Console.WriteLine("=============================================")
        Console.WriteLine("YOUR GPA FOR 1ST SEMESTER = " + FIRST_GPA.ToString("F2"))


    End Sub


    Private Sub Second_semsPro()

        Dim TP_totalPoints, TCU_totalCreditUnits, DBMS201, UI_UX202, AI204, SQT205, AA206, DEVOP207, SECOND_GPA As Double

        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE CALCULATES THE GP FOR SECOND SEMESTER")
        Console.WriteLine("=============================================")
        Console.WriteLine("")

        Console.WriteLine("ENTER SCORE FOR Database Management System (DBMS201)  (5 UNITS)")
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

        Console.WriteLine("ENTER SCORE FOR UI/UX Design (UI_UX202)  (3 UNITS)")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Artificial Intelligence (AI204)  (5 UNITS)")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Software Quality Training (SQT205)  (3 UNITS)")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Augumented Analysis (AA206)  (4 UNITS)")
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

        Console.WriteLine("")
        Console.WriteLine("ENTER SCORE FOR Software Development And IT Operation (DEVOP207)  (4 UNITS)")
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

        Console.WriteLine("")

        TP_totalPoints = DBMS201 + UI_UX202 + AI204 + SQT205 + AA206 + DEVOP207
        TCU_totalCreditUnits = 5 + 3 + 5 + 3 + 4 + 4
        SECOND_GPA = TP_totalPoints / TCU_totalCreditUnits
        Console.WriteLine("=============================================")
        Console.WriteLine("YOUR GPA FOR 2ND SEMESTER = " + SECOND_GPA.ToString("F2"))

        Console.WriteLine("")

    End Sub

    Private Sub FindCGPAPro()

        Console.WriteLine("To Calculate your CGPA, Input your 1st and 2nd Semester Scores")
        Console.WriteLine("")
        First_semsPro()
        Console.WriteLine("")
        Second_semsPro()
        Console.WriteLine("")
        YOUR_CGPA = FIRST_GPA + SECOND_GPA
        CGPA = YOUR_CGPA / 2
        Console.WriteLine("==========================================")
        Console.WriteLine("YOUR_CGPA = " + CGPA.ToString)
        Console.WriteLine("")
        If (CGPA >= 3.5) And (CGPA <= 4.0) Then
            Console.WriteLine("CLASS CATEGORY = DISTINCTION")
        ElseIf (CGPA >= 3.0) And (CGPA <= 3.49) Then
            Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
        ElseIf (CGPA >= 2.5) And (CGPA <= 2.99) Then
            Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
        ElseIf (CGPA >= 2.0) And (CGPA <= 2.49) Then
            Console.WriteLine("CLASS CATEGORY = PASS")
        Else
            Console.WriteLine("CLASS CATEGORY = FAIL")
        End If

    End Sub
End Module
