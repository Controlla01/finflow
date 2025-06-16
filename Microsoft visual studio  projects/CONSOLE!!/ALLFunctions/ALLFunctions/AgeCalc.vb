Module AgeCalc

    Sub AgeCalc()
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

        While Not Integer.TryParse(Console.ReadLine(), birthYear)
            Console.WriteLine("Invalid year.")
            Console.WriteLine("")
        End While
        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH MONTH (1-12)")
        While Not Integer.TryParse(Console.ReadLine(), birthMonth) Or (birthMonth > 12) Or (birthMonth < 1)
            Console.WriteLine("Invalid Month. Re-enter correctly please.")
            Console.WriteLine("")
        End While

        DaysInMonth = DateTime.DaysInMonth(birthYear, birthMonth)

        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH DAY ")
        While Not Integer.TryParse(Console.ReadLine(), birthDay) Or (birthDay < 1) Or (birthDay > DaysInMonth)
            Console.WriteLine("Invalid day. Re-Enter day correctly please.")
            Console.WriteLine("")
        End While

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

    End Sub

End Module
