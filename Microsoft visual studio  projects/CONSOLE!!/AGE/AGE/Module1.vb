Module Module1

    Sub Main()
        Dim toMonth, toDay, birthDay, birthMonth, birthYear, DaysInMonth As Integer
        Dim todayDate As DateTime = DateTime.Now
        Dim toYear As Integer = toYear - birthYear
        Dim ageYear, ageMonth, ageDayy As Integer


        Console.WriteLine("")
        Console.WriteLine("THIS SOFTWARE WORKS AS AN AGE CALCULATOR")
        Console.WriteLine("==========================================")
        Console.WriteLine("")

        todayDate = Date.Now()
        toDay = Date.Now.Day()
        toMonth = Date.Now.Month()
        toYear = Date.Now.Year()

        Console.WriteLine("                     TODAY's DATE = " + todayDate.ToString)
        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH YEAR (YYYY)")

        'While Not Integer.TryParse(Console.ReadLine(), birthYear) OrElse (birthYear > toYear) OrElse (birthYear <= 0)
        'Console.WriteLine("INVALID YEAR! Re-Enter year for the last time(Don't be a goat abeg).")
        'End While

        If Not Integer.TryParse(Console.ReadLine(), birthYear) Then
            Console.WriteLine("Invalid year.")
            Console.WriteLine("")
            Console.WriteLine("Re-Enter year for the last time(Don't be a goat abeg).")
            If Not Integer.TryParse(Console.ReadLine(), birthYear) Then
                Console.WriteLine("Invalid.")
                End
            End If
        End If

        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH MONTH (1-12)")
        If Not Integer.TryParse(Console.ReadLine(), birthMonth) Or (birthMonth > 12) Or (birthMonth < 1) Then
            Console.WriteLine("Invalid Month.")
            Console.WriteLine("")
            Console.WriteLine("Re-Enter month for the last time.")
            If Not Integer.TryParse(Console.ReadLine, birthMonth) Or (birthMonth < 1) Or (birthMonth > 12) Then
                Console.WriteLine("Invalid birth month. Month must be between 1 and 12.")
                Console.ReadLine()
                End
            End If
        End If

        DaysInMonth = DateTime.DaysInMonth(birthYear, birthMonth)

        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH DAY ")
        If Not Integer.TryParse(Console.ReadLine(), birthDay) Or (birthDay < 1) Or (birthDay > DaysInMonth) Then
            Console.WriteLine("Invalid day. Re-Enter day for the last time.")
            Console.WriteLine("")
            Console.WriteLine("RE-ENTER YOUR BIRTH DAY")
            If Not Integer.TryParse(Console.ReadLine, birthDay) Or (birthDay < 1) Or (birthDay > DaysInMonth) Then
                Console.WriteLine("Invalid birth date.")
                Console.ReadLine()
                End
            End If
        End If

        Console.WriteLine()


        ageYear = toYear - birthYear
        ageMonth = toMonth - birthMonth
        ageDayy = toDay - birthDay

        If (toMonth >= birthMonth) Then
            ageMonth = toMonth - birthMonth
        Else
            ageMonth = 12 + toMonth - birthMonth
            ageYear -= 1
        End If

        If (toDay >= birthDay) Then
            ageDayy = toDay - birthDay
        Else
            ageMonth -= 1
            ageDayy = DateTime.DaysInMonth(birthYear, birthMonth) + toDay - birthDay
        End If

        If (ageMonth < 0) Then
            ageMonth = 11
            ageYear -= 1
        End If

        If birthYear >= toYear And birthMonth < toMonth And birthDay < toDay Then
            Console.WriteLine("Invalid Input!.")
            Console.ReadLine()
            End
        End If


        If birthYear >= toYear And birthMonth >= toMonth And birthDay >= toDay Then
            Console.WriteLine("Invalid Input.!!")
            Console.ReadLine()

            End
        End If

        

        Console.WriteLine(" You're " & ageYear.ToString + " years  " & ageMonth.ToString + " months  " & ageDayy.ToString + " days old today")
        Console.ReadLine()

    End Sub

End Module
