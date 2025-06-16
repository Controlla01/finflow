Module AFOOTECHGPCALC
    Dim dbms201, ui_ux202, a_i204, sqt205, a_a206, dev_op207, t_c_u, t_g_p, second_g_p_a, cgpa As Double
    Dim gp_sdt101, gp_mad102, gp_sda103, gp_wad104, gp_ns105, gp_agd106, first_t_c_u, first_t_g_p, first_g_p_a, totalg_p_a As Double
    Sub AFOOTECHGPCALC()
        Dim op As Integer
        Console.WriteLine("THIS SOFTWARE CALCULATE CGPA OF A STUDENT")
        Console.WriteLine("==============================================")
        Console.WriteLine("")


        Console.WriteLine("PRESS (1) TO CALCULATE FIRST SEMESTER GP")
        Console.WriteLine("PRESS (2) TO CALCULATE SECOND SEMESTER GP")
        Console.WriteLine("PRESS (3) TO CALCULATE CGPA")
        While Not Integer.TryParse(Console.ReadLine, op) Or (op > 3) Or (op <= 0)
            Console.WriteLine("Invalid Input!!!, Please input correctly")
        End While

        If op = 1 Then
            findfirstsemester()
        ElseIf op = 2 Then
            findsecondsemester()
        ElseIf op = 3 Then
            findcgpa()
        End If

        Console.ReadLine()
    End Sub

    Private Sub findfirstsemester()


        Console.WriteLine("THIS SOFTWARE CALCULATE AFOOTECH GP CALCULATOR")
        Console.WriteLine("=======================================================================================")
        Console.WriteLine("")

        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE DEVELOPMENT TRAINING 101 (SDT101)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_sdt101) Or (gp_sdt101 > 100) Or (gp_sdt101 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SDT101 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR MOBILE APPLICATION DEVELOPMENT 102 (MAD102)      (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_mad102) Or (gp_mad102 > 100) Or (gp_mad102 < 0)
            Console.WriteLine("Invalid Input!!!, Please input MAD102 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR SYSTEM AND DATA ANALYSIS 103 (SDA103)            (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_sda103) Or (gp_sda103 > 100) Or (gp_sda103 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SDA103 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR WEBSITE APPLICATION DEVELOPMENT 104 (WAD104)     (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_wad104) Or (gp_wad104 > 100) Or (gp_wad104 < 0)
            Console.WriteLine("Invalid Input!!!, Please input WAD104 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR NETWORKING AND SECURITY 105 (NS105)              (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_ns105) Or (gp_ns105 > 100) Or (gp_ns105 < 0)
            Console.WriteLine("Invalid Input!!!, Please input NS105 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR ADVANCED GRAPHICS DESIGN 106 (AGD106)            (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_agd106) Or (gp_agd106 > 100) Or (gp_agd106 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AGD106 scores correctly")
        End While
        Console.WriteLine("=======================================================================================")

        If (gp_sdt101 >= 80) And (gp_sdt101 <= 100) Then
            gp_sdt101 = 4.0 * 4
        ElseIf (gp_sdt101 >= 70) And (gp_sdt101 <= 79.9) Then
            gp_sdt101 = 3.5 * 4
        ElseIf (gp_sdt101 >= 60) And (gp_sdt101 <= 69.9) Then
            gp_sdt101 = 3.0 * 4
        ElseIf (gp_sdt101 >= 50) And (gp_sdt101 <= 59.9) Then
            gp_sdt101 = 2.5 * 4
        ElseIf (gp_sdt101 >= 40) And (gp_sdt101 <= 49.9) Then
            gp_sdt101 = 2.0 * 4
        ElseIf (gp_sdt101 >= 0) And (gp_sdt101 <= 39.9) Then
            gp_sdt101 = 0 * 4
        End If


        If (gp_mad102 >= 80) And (gp_mad102 <= 100) Then
            gp_mad102 = 4.0 * 4
        ElseIf (gp_mad102 >= 70) And (gp_mad102 <= 79.9) Then
            gp_mad102 = 3.5 * 4
        ElseIf (gp_mad102 >= 60) And (gp_mad102 <= 69.9) Then
            gp_mad102 = 3.0 * 4
        ElseIf (gp_mad102 >= 50) And (gp_mad102 <= 59.9) Then
            gp_mad102 = 2.5 * 4
        ElseIf (gp_mad102 >= 40) And (gp_mad102 <= 49.9) Then
            gp_mad102 = 2.0 * 4
        ElseIf (gp_mad102 >= 0) And (gp_mad102 <= 39.9) Then
            gp_mad102 = 0 * 4
        End If



        If (gp_sda103 >= 80) And (gp_sda103 <= 100) Then
            gp_sda103 = 4.0 * 5
        ElseIf (gp_sda103 >= 70) And (gp_sda103 <= 79.9) Then
            gp_sda103 = 3.5 * 5
        ElseIf (gp_sda103 >= 60) And (gp_sda103 <= 69.9) Then
            gp_sda103 = 3.0 * 5
        ElseIf (gp_sda103 >= 50) And (gp_sda103 <= 59.9) Then
            gp_sda103 = 2.5 * 5
        ElseIf (gp_sda103 >= 40) And (gp_sda103 <= 49.9) Then
            gp_sda103 = 2.0 * 5
        ElseIf (gp_sda103 >= 0) And (gp_sda103 <= 39.9) Then
            gp_sda103 = 0 * 5
        End If


        If (gp_wad104 >= 80) And (gp_wad104 <= 100) Then
            gp_wad104 = 4.0 * 4
        ElseIf (gp_wad104 >= 70) And (gp_wad104 <= 79.9) Then
            gp_wad104 = 3.5 * 4
        ElseIf (gp_wad104 >= 60) And (gp_wad104 <= 69.9) Then
            gp_wad104 = 3.0 * 4
        ElseIf (gp_wad104 >= 50) And (gp_wad104 <= 59.9) Then
            gp_wad104 = 2.5 * 4
        ElseIf (gp_wad104 >= 40) And (gp_wad104 <= 49.9) Then
            gp_wad104 = 2.0 * 4
        ElseIf (gp_wad104 >= 0) And (gp_wad104 <= 39.9) Then
            gp_wad104 = 0 * 4
        End If



        If (gp_ns105 >= 80) And (gp_ns105 <= 100) Then
            gp_ns105 = 4.0 * 4
        ElseIf (gp_ns105 >= 70) And (gp_ns105 <= 79.9) Then
            gp_ns105 = 3.5 * 4
        ElseIf (gp_ns105 >= 60) And (gp_ns105 <= 69.9) Then
            gp_ns105 = 3.0 * 4
        ElseIf (gp_ns105 >= 50) And (gp_ns105 <= 59.9) Then
            gp_ns105 = 2.5 * 4
        ElseIf (gp_ns105 >= 40) And (gp_ns105 <= 49.9) Then
            gp_ns105 = 2.0 * 4
        ElseIf (gp_ns105 >= 0) And (gp_ns105 <= 39.9) Then
            gp_ns105 = 0 * 4
        End If



        If (gp_agd106 >= 80) And (gp_agd106 <= 100) Then
            gp_agd106 = 4.0 * 4
        ElseIf (gp_agd106 >= 70) And (gp_agd106 <= 79.9) Then
            gp_agd106 = 3.5 * 4
        ElseIf (gp_agd106 >= 60) And (gp_agd106 <= 69.9) Then
            gp_agd106 = 3.0 * 4
        ElseIf (gp_agd106 >= 50) And (gp_agd106 <= 59.9) Then
            gp_agd106 = 2.5 * 4
        ElseIf (gp_agd106 >= 40) And (gp_agd106 <= 49.9) Then
            gp_agd106 = 2.0 * 4
        ElseIf (gp_agd106 >= 0) And (gp_agd106 <= 39.9) Then
            gp_agd106 = 0 * 4
        End If

        first_t_c_u = 25
        first_t_g_p = gp_sdt101 + gp_mad102 + gp_sda103 + gp_wad104 + gp_ns105 + gp_agd106
        first_g_p_a = first_t_g_p / first_t_c_u

        Console.WriteLine("Total Course Unit = " + first_t_c_u.ToString)
        Console.WriteLine("Total Grade Point = " + first_t_g_p.ToString)
        Console.WriteLine("GRADE POINT AVERAGE = " + first_g_p_a.ToString("f2"))
        Console.WriteLine("=======================================================================================")

        If (first_g_p_a >= 3.5) And (first_g_p_a <= 4.0) Then
            Console.WriteLine("GRADE CLASSIFICATION = DISTINCTION")
        ElseIf (first_g_p_a >= 3.0) And (first_g_p_a <= 3.49) Then
            Console.WriteLine("GRADE CLASSIFICATION = UPPER CREDIT")
        ElseIf (first_g_p_a >= 2.5) And (first_g_p_a <= 2.99) Then
            Console.WriteLine("GRADE CLASSIFICATION = LOWER CREDIT")
        ElseIf (first_g_p_a >= 2.0) And (first_g_p_a <= 2.49) Then
            Console.WriteLine("GRADE CLASSIFICATION = PASS")
        ElseIf (first_g_p_a >= 0) And (first_g_p_a <= 1.99) Then
            Console.WriteLine("GRADE CLASSIFICATION = FAIL")
        End If


    End Sub

    Private Sub findsecondsemester()


        Console.WriteLine("THIS SOFTWARE CALCULATE AFOOTECH GP CALCULATOR SECOND SEMESTER")
        Console.WriteLine("=======================================================================================")
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR DATABASE MANAGEMENT SYSTEM 201 (DBMS201)       (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, dbms201) Or (dbms201 > 100) Or (dbms201 < 0)
            Console.WriteLine("Invalid Input!!!, Please input DBMS201 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR UI/UX DESIGN 202 (UI/UX202)       (3 UNIT)")
        While Not Double.TryParse(Console.ReadLine, ui_ux202) Or (ui_ux202 > 100) Or (ui_ux202 < 0)
            Console.WriteLine("Invalid Input!!!, Please input UI/UX DESIGN202 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR ARTIFICIAL INTELLIGENCE 204 (AI 204)       (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, a_i204) Or (a_i204 > 100) Or (a_i204 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AI204 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE QUALITY TESTING 205 (SQT 205)       (3 UNIT)")
        While Not Double.TryParse(Console.ReadLine, sqt205) Or (sqt205 > 100) Or (sqt205 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SQT205 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR AUGUMENTED ANALYSIS 206 (A A 206)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, a_a206) Or (a_a206 > 100) Or (a_a206 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AA206 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE DEV & IT OPERATION 207 (DEV OP 207)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, dev_op207) Or (dev_op207 > 100) Or (dev_op207 < 0)
            Console.WriteLine("Invalid Input!!!, Please input DEVOP207 scores correctly")
        End While

        Console.WriteLine("=======================================================================================")



        If (dbms201 >= 80) And (dbms201 <= 100) Then
            dbms201 = 4.0 * 5
        ElseIf (dbms201 >= 70) And (dbms201 <= 79.9) Then
            dbms201 = 3.5 * 5
        ElseIf (dbms201 >= 60) And (dbms201 <= 69.9) Then
            dbms201 = 3.0 * 5
        ElseIf (dbms201 >= 50) And (dbms201 <= 59.9) Then
            dbms201 = 2.5 * 5
        ElseIf (dbms201 >= 40) And (dbms201 <= 49.9) Then
            dbms201 = 2.0 * 5
        ElseIf (dbms201 >= 0) And (dbms201 <= 39.9) Then
            dbms201 = 0 * 5
        End If


        If (ui_ux202 >= 80) And (ui_ux202 <= 100) Then
            ui_ux202 = 4.0 * 3
        ElseIf (ui_ux202 >= 70) And (ui_ux202 <= 79.9) Then
            ui_ux202 = 3.5 * 3
        ElseIf (ui_ux202 >= 60) And (ui_ux202 <= 69.9) Then
            ui_ux202 = 3.0 * 3
        ElseIf (ui_ux202 >= 50) And (ui_ux202 <= 59.9) Then
            ui_ux202 = 2.5 * 3
        ElseIf (ui_ux202 >= 40) And (ui_ux202 <= 49.9) Then
            ui_ux202 = 2.0 * 3
        ElseIf (ui_ux202 >= 0) And (ui_ux202 <= 39.9) Then
            ui_ux202 = 0 * 3
        End If



        If (a_i204 >= 80) And (a_i204 <= 100) Then
            a_i204 = 4.0 * 5
        ElseIf (a_i204 >= 70) And (a_i204 <= 79.9) Then
            a_i204 = 3.5 * 5
        ElseIf (a_i204 >= 60) And (a_i204 <= 69.9) Then
            a_i204 = 3.0 * 5
        ElseIf (a_i204 >= 50) And (a_i204 <= 59.9) Then
            a_i204 = 2.5 * 5
        ElseIf (a_i204 >= 40) And (a_i204 <= 49.9) Then
            a_i204 = 2.0 * 5
        ElseIf (a_i204 >= 0) And (a_i204 <= 39.9) Then
            a_i204 = 0 * 5
        End If


        If (sqt205 >= 80) And (sqt205 <= 100) Then
            sqt205 = 4.0 * 3
        ElseIf (sqt205 >= 70) And (sqt205 <= 79.9) Then
            sqt205 = 3.5 * 3
        ElseIf (sqt205 >= 60) And (sqt205 <= 69.9) Then
            sqt205 = 3.0 * 3
        ElseIf (sqt205 >= 50) And (sqt205 <= 59.9) Then
            sqt205 = 2.5 * 3
        ElseIf (sqt205 >= 40) And (sqt205 <= 49.9) Then
            sqt205 = 2.0 * 3
        ElseIf (sqt205 >= 0) And (sqt205 <= 39.9) Then
            sqt205 = 0 * 3
        End If



        If (a_a206 >= 80) And (a_a206 <= 100) Then
            a_a206 = 4.0 * 4
        ElseIf (a_a206 >= 70) And (a_a206 <= 79.9) Then
            a_a206 = 3.5 * 4
        ElseIf (a_a206 >= 60) And (a_a206 <= 69.9) Then
            a_a206 = 3.0 * 4
        ElseIf (a_a206 >= 50) And (a_a206 <= 59.9) Then
            a_a206 = 2.5 * 4
        ElseIf (a_a206 >= 40) And (a_a206 <= 49.9) Then
            a_a206 = 2.0 * 4
        ElseIf (a_a206 >= 0) And (a_a206 <= 39.9) Then
            a_a206 = 0 * 4
        End If


        If (dev_op207 >= 80) And (dev_op207 <= 100) Then
            dev_op207 = 4.0 * 4
        ElseIf (a_a206 >= 70) And (dev_op207 <= 79.9) Then
            dev_op207 = 3.5 * 4
        ElseIf (a_a206 >= 60) And (dev_op207 <= 69.9) Then
            dev_op207 = 3.0 * 4
        ElseIf (dev_op207 >= 50) And (dev_op207 <= 59.9) Then
            dev_op207 = 2.5 * 4
        ElseIf (dev_op207 >= 40) And (dev_op207 <= 49.9) Then
            dev_op207 = 2.0 * 4
        ElseIf (dev_op207 >= 0) And (dev_op207 <= 39.9) Then
            dev_op207 = 0 * 4
        End If


        t_c_u = 24
        t_g_p = dbms201 + ui_ux202 + a_i204 + sqt205 + a_a206 + dev_op207
        second_g_p_a = t_g_p / t_c_u

        Console.WriteLine("Total Course Unit = " + t_c_u.ToString)
        Console.WriteLine("Total Grade Point = " + t_g_p.ToString)
        Console.WriteLine("GRADE POINT AVERAGE = " + second_g_p_a.ToString("f2"))
        Console.WriteLine("=======================================================================================")

        If (second_g_p_a >= 3.5) And (second_g_p_a <= 4.0) Then
            Console.WriteLine("GRADE CLASSIFICATION = DISTINCTION")
        ElseIf (second_g_p_a >= 3.0) And (second_g_p_a <= 3.49) Then
            Console.WriteLine("GRADE CLASSIFICATION = UPPER CREDIT")
        ElseIf (second_g_p_a >= 2.5) And (second_g_p_a <= 2.99) Then
            Console.WriteLine("GRADE CLASSIFICATION = LOWER CREDIT")
        ElseIf (second_g_p_a >= 2.0) And (second_g_p_a <= 2.49) Then
            Console.WriteLine("GRADE CLASSIFICATION = PASS")
        ElseIf (second_g_p_a >= 0) And (second_g_p_a <= 1.99) Then
            Console.WriteLine("GRADE CLASSIFICATION = FAIL")
        End If

    End Sub

    Private Sub findcgpa()
        Console.WriteLine("=======================================================================================")
        Console.WriteLine("ENTER THE SCORE FOR FIRST SEMESTER COURSE")
        Console.WriteLine("=======================================================================================")
        Console.WriteLine("")

        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE DEVELOPMENT TRAINING 101 (SDT101)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_sdt101) Or (gp_sdt101 > 100) Or (gp_sdt101 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SDT101 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR MOBILE APPLICATION DEVELOPMENT 102 (MAD102)      (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_mad102) Or (gp_mad102 > 100) Or (gp_mad102 < 0)
            Console.WriteLine("Invalid Input!!!, Please input MAD102 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR SYSTEM AND DATA ANALYSIS 103 (SDA103)            (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_sda103) Or (gp_sda103 > 100) Or (gp_sda103 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SDA103 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR WEBSITE APPLICATION DEVELOPMENT 104 (WAD104)     (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_wad104) Or (gp_wad104 > 100) Or (gp_wad104 < 0)
            Console.WriteLine("Invalid Input!!!, Please input WAD104 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR NETWORKING AND SECURITY 105 (NS105)              (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_ns105) Or (gp_ns105 > 100) Or (gp_ns105 < 0)
            Console.WriteLine("Invalid Input!!!, Please input NS105 scores correctly")
        End While
        Console.WriteLine("")
        Console.WriteLine("INPUT THE SCORE FOR ADVANCED GRAPHICS DESIGN 106 (AGD106)            (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, gp_agd106) Or (gp_agd106 > 100) Or (gp_agd106 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AGD106 scores correctly")
        End While

        Console.WriteLine("=======================================================================================")
        Console.WriteLine("ENTER SCORE FOR SECOND SEMESTER COURSE")
        Console.WriteLine("=======================================================================================")
        Console.WriteLine("")

        Console.WriteLine("INPUT THE SCORE FOR DATABASE MANAGEMENT SYSTEM 201 (DBMS201)       (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, dbms201) Or (dbms201 > 100) Or (dbms201 < 0)
            Console.WriteLine("Invalid Input!!!, Please input DBMS201 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR UI/UX DESIGN 202 (UI/UX202)       (3 UNIT)")
        While Not Double.TryParse(Console.ReadLine, ui_ux202) Or (ui_ux202 > 100) Or (ui_ux202 < 0)
            Console.WriteLine("Invalid Input!!!, Please input UI/UX DESIGN202 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR ARTIFICIAL INTELLIGENCE 204 (AI 204)       (5 UNIT)")
        While Not Double.TryParse(Console.ReadLine, a_i204) Or (a_i204 > 100) Or (a_i204 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AI204 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE QUALITY TESTING 205 (SQT 205)       (3 UNIT)")
        While Not Double.TryParse(Console.ReadLine, sqt205) Or (sqt205 > 100) Or (sqt205 < 0)
            Console.WriteLine("Invalid Input!!!, Please input SQT205 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR AUGUMENTED ANALYSIS 206 (A A 206)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, a_a206) Or (a_a206 > 100) Or (a_a206 < 0)
            Console.WriteLine("Invalid Input!!!, Please input AA206 scores correctly")
        End While
        Console.WriteLine("INPUT THE SCORE FOR SOFTWARE DEV & IT OPERATION 207 (DEV OP 207)       (4 UNIT)")
        While Not Double.TryParse(Console.ReadLine, dev_op207) Or (dev_op207 > 100) Or (dev_op207 < 0)
            Console.WriteLine("Invalid Input!!!, Please input DEVOP207 scores correctly")
        End While


        If (gp_sdt101 >= 80) And (gp_sdt101 <= 100) Then
            gp_sdt101 = 4.0 * 4
        ElseIf (gp_sdt101 >= 70) And (gp_sdt101 <= 79.9) Then
            gp_sdt101 = 3.5 * 4
        ElseIf (gp_sdt101 >= 60) And (gp_sdt101 <= 69.9) Then
            gp_sdt101 = 3.0 * 4
        ElseIf (gp_sdt101 >= 50) And (gp_sdt101 <= 59.9) Then
            gp_sdt101 = 2.5 * 4
        ElseIf (gp_sdt101 >= 40) And (gp_sdt101 <= 49.9) Then
            gp_sdt101 = 2.0 * 4
        ElseIf (gp_sdt101 >= 0) And (gp_sdt101 <= 39.9) Then
            gp_sdt101 = 0 * 4
        End If


        If (gp_mad102 >= 80) And (gp_mad102 <= 100) Then
            gp_mad102 = 4.0 * 4
        ElseIf (gp_mad102 >= 70) And (gp_mad102 <= 79.9) Then
            gp_mad102 = 3.5 * 4
        ElseIf (gp_mad102 >= 60) And (gp_mad102 <= 69.9) Then
            gp_mad102 = 3.0 * 4
        ElseIf (gp_mad102 >= 50) And (gp_mad102 <= 59.9) Then
            gp_mad102 = 2.5 * 4
        ElseIf (gp_mad102 >= 40) And (gp_mad102 <= 49.9) Then
            gp_mad102 = 2.0 * 4
        ElseIf (gp_mad102 >= 0) And (gp_mad102 <= 39.9) Then
            gp_mad102 = 0 * 4
        End If



        If (gp_sda103 >= 80) And (gp_sda103 <= 100) Then
            gp_sda103 = 4.0 * 5
        ElseIf (gp_sda103 >= 70) And (gp_sda103 <= 79.9) Then
            gp_sda103 = 3.5 * 5
        ElseIf (gp_sda103 >= 60) And (gp_sda103 <= 69.9) Then
            gp_sda103 = 3.0 * 5
        ElseIf (gp_sda103 >= 50) And (gp_sda103 <= 59.9) Then
            gp_sda103 = 2.5 * 5
        ElseIf (gp_sda103 >= 40) And (gp_sda103 <= 49.9) Then
            gp_sda103 = 2.0 * 5
        ElseIf (gp_sda103 >= 0) And (gp_sda103 <= 39.9) Then
            gp_sda103 = 0 * 5
        End If


        If (gp_wad104 >= 80) And (gp_wad104 <= 100) Then
            gp_wad104 = 4.0 * 4
        ElseIf (gp_wad104 >= 70) And (gp_wad104 <= 79.9) Then
            gp_wad104 = 3.5 * 4
        ElseIf (gp_wad104 >= 60) And (gp_wad104 <= 69.9) Then
            gp_wad104 = 3.0 * 4
        ElseIf (gp_wad104 >= 50) And (gp_wad104 <= 59.9) Then
            gp_wad104 = 2.5 * 4
        ElseIf (gp_wad104 >= 40) And (gp_wad104 <= 49.9) Then
            gp_wad104 = 2.0 * 4
        ElseIf (gp_wad104 >= 0) And (gp_wad104 <= 39.9) Then
            gp_wad104 = 0 * 4
        End If



        If (gp_ns105 >= 80) And (gp_ns105 <= 100) Then
            gp_ns105 = 4.0 * 4
        ElseIf (gp_ns105 >= 70) And (gp_ns105 <= 79.9) Then
            gp_ns105 = 3.5 * 4
        ElseIf (gp_ns105 >= 60) And (gp_ns105 <= 69.9) Then
            gp_ns105 = 3.0 * 4
        ElseIf (gp_ns105 >= 50) And (gp_ns105 <= 59.9) Then
            gp_ns105 = 2.5 * 4
        ElseIf (gp_ns105 >= 40) And (gp_ns105 <= 49.9) Then
            gp_ns105 = 2.0 * 4
        ElseIf (gp_ns105 >= 0) And (gp_ns105 <= 39.9) Then
            gp_ns105 = 0 * 4
        End If



        If (gp_agd106 >= 80) And (gp_agd106 <= 100) Then
            gp_agd106 = 4.0 * 4
        ElseIf (gp_agd106 >= 70) And (gp_agd106 <= 79.9) Then
            gp_agd106 = 3.5 * 4
        ElseIf (gp_agd106 >= 60) And (gp_agd106 <= 69.9) Then
            gp_agd106 = 3.0 * 4
        ElseIf (gp_agd106 >= 50) And (gp_agd106 <= 59.9) Then
            gp_agd106 = 2.5 * 4
        ElseIf (gp_agd106 >= 40) And (gp_agd106 <= 49.9) Then
            gp_agd106 = 2.0 * 4
        ElseIf (gp_agd106 >= 0) And (gp_agd106 <= 39.9) Then
            gp_agd106 = 0 * 4
        End If


        If (dbms201 >= 80) And (dbms201 <= 100) Then
            dbms201 = 4.0 * 5
        ElseIf (dbms201 >= 70) And (dbms201 <= 79.9) Then
            dbms201 = 3.5 * 5
        ElseIf (dbms201 >= 60) And (dbms201 <= 69.9) Then
            dbms201 = 3.0 * 5
        ElseIf (dbms201 >= 50) And (dbms201 <= 59.9) Then
            dbms201 = 2.5 * 5
        ElseIf (dbms201 >= 40) And (dbms201 <= 49.9) Then
            dbms201 = 2.0 * 5
        ElseIf (dbms201 >= 0) And (dbms201 <= 39.9) Then
            dbms201 = 0 * 5
        End If


        If (ui_ux202 >= 80) And (ui_ux202 <= 100) Then
            ui_ux202 = 4.0 * 3
        ElseIf (ui_ux202 >= 70) And (ui_ux202 <= 79.9) Then
            ui_ux202 = 3.5 * 3
        ElseIf (ui_ux202 >= 60) And (ui_ux202 <= 69.9) Then
            ui_ux202 = 3.0 * 3
        ElseIf (ui_ux202 >= 50) And (ui_ux202 <= 59.9) Then
            ui_ux202 = 2.5 * 3
        ElseIf (ui_ux202 >= 40) And (ui_ux202 <= 49.9) Then
            ui_ux202 = 2.0 * 3
        ElseIf (ui_ux202 >= 0) And (ui_ux202 <= 39.9) Then
            ui_ux202 = 0 * 3
        End If



        If (a_i204 >= 80) And (a_i204 <= 100) Then
            a_i204 = 4.0 * 5
        ElseIf (a_i204 >= 70) And (a_i204 <= 79.9) Then
            a_i204 = 3.5 * 5
        ElseIf (a_i204 >= 60) And (a_i204 <= 69.9) Then
            a_i204 = 3.0 * 5
        ElseIf (a_i204 >= 50) And (a_i204 <= 59.9) Then
            a_i204 = 2.5 * 5
        ElseIf (a_i204 >= 40) And (a_i204 <= 49.9) Then
            a_i204 = 2.0 * 5
        ElseIf (a_i204 >= 0) And (a_i204 <= 39.9) Then
            a_i204 = 0 * 5
        End If


        If (sqt205 >= 80) And (sqt205 <= 100) Then
            sqt205 = 4.0 * 3
        ElseIf (sqt205 >= 70) And (sqt205 <= 79.9) Then
            sqt205 = 3.5 * 3
        ElseIf (sqt205 >= 60) And (sqt205 <= 69.9) Then
            sqt205 = 3.0 * 3
        ElseIf (sqt205 >= 50) And (sqt205 <= 59.9) Then
            sqt205 = 2.5 * 3
        ElseIf (sqt205 >= 40) And (sqt205 <= 49.9) Then
            sqt205 = 2.0 * 3
        ElseIf (sqt205 >= 0) And (sqt205 <= 39.9) Then
            sqt205 = 0 * 3
        End If



        If (a_a206 >= 80) And (a_a206 <= 100) Then
            a_a206 = 4.0 * 4
        ElseIf (a_a206 >= 70) And (a_a206 <= 79.9) Then
            a_a206 = 3.5 * 4
        ElseIf (a_a206 >= 60) And (a_a206 <= 69.9) Then
            a_a206 = 3.0 * 4
        ElseIf (a_a206 >= 50) And (a_a206 <= 59.9) Then
            a_a206 = 2.5 * 4
        ElseIf (a_a206 >= 40) And (a_a206 <= 49.9) Then
            a_a206 = 2.0 * 4
        ElseIf (a_a206 >= 0) And (a_a206 <= 39.9) Then
            a_a206 = 0 * 4
        End If


        If (dev_op207 >= 80) And (dev_op207 <= 100) Then
            dev_op207 = 4.0 * 4
        ElseIf (a_a206 >= 70) And (dev_op207 <= 79.9) Then
            dev_op207 = 3.5 * 4
        ElseIf (a_a206 >= 60) And (dev_op207 <= 69.9) Then
            dev_op207 = 3.0 * 4
        ElseIf (dev_op207 >= 50) And (dev_op207 <= 59.9) Then
            dev_op207 = 2.5 * 4
        ElseIf (dev_op207 >= 40) And (dev_op207 <= 49.9) Then
            dev_op207 = 2.0 * 4
        ElseIf (dev_op207 >= 0) And (dev_op207 <= 39.9) Then
            dev_op207 = 0 * 4
        End If


        Console.WriteLine("=======================================================================================")
        first_t_c_u = 25
        first_t_g_p = gp_sdt101 + gp_mad102 + gp_sda103 + gp_wad104 + gp_ns105 + gp_agd106
        first_g_p_a = first_t_g_p / first_t_c_u

        Console.WriteLine("Total Course Unit for first semester = " + first_t_c_u.ToString)
        Console.WriteLine("Total Grade Point for first semester = " + first_t_g_p.ToString)
        Console.WriteLine("GRADE POINT AVERAGE FOR FIRST SEMESTER = " + first_g_p_a.ToString("f2"))
        Console.WriteLine("=======================================================================================")

        t_c_u = 24
        t_g_p = dbms201 + ui_ux202 + a_i204 + sqt205 + a_a206 + dev_op207
        second_g_p_a = t_g_p / t_c_u

        Console.WriteLine("Total Course Unit for second semester = " + t_c_u.ToString)
        Console.WriteLine("Total Grade Point for second semester = " + t_g_p.ToString)
        Console.WriteLine("GRADE POINT AVERAGE FOR SECON D SEMESTER = " + second_g_p_a.ToString("f2"))
        Console.WriteLine("=======================================================================================")

        totalg_p_a = first_g_p_a + second_g_p_a
        cgpa = totalg_p_a / 2
        Console.WriteLine("CGPA = " + cgpa.ToString)
        Console.WriteLine("=======================================================================================")
        If (cgpa >= 3.5) And (cgpa <= 4.0) Then
            Console.WriteLine("CLASS CATEGORY = DISTINCTION")
        ElseIf (cgpa >= 3.0) And (cgpa <= 3.49) Then
            Console.WriteLine("CLASS CATEGORY = UPPER CREDIT")
        ElseIf (cgpa >= 2.5) And (cgpa <= 2.99) Then
            Console.WriteLine("CLASS CATEGORY = LOWER CREDIT")
        ElseIf (cgpa >= 2.0) And (cgpa <= 2.49) Then
            Console.WriteLine("CLASS CATEGORY = PASS")
        Else
            Console.WriteLine("CLASS CATEGORY = FAIL")
        End If
    End Sub

End Module
