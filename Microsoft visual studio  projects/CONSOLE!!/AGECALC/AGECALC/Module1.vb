Module Module1

    Sub Main()
        Dim toMonth, toDay, birthDay, birthMonth, birthYear, Days_InMonth As Integer
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
            If Not Integer.TryParse(Console.ReadLine(), birthMonth) Then
                Console.WriteLine("Invalid.")
            ElseIf (birthMonth < 1) Or (birthMonth > 12) Then
                Console.WriteLine("Invalid birth date. Month must be between 1 and 12.")
                End
            End If
        End If

        Days_InMonth = DateTime.DaysInMonth(birthYear, birthMonth)

        Console.WriteLine("")
        Console.WriteLine("ENTER  YOUR BIRTH DAY (1-31)")
        If Not Integer.TryParse(Console.ReadLine(), birthDay) Then
            Console.WriteLine("Invalid.")
        ElseIf (birthDay < 1) Or (birthDay > Days_InMonth) Then
            Console.WriteLine("Invalid birth date. Day must be between 1 and your birthMonth.")
        ElseIf (birthMonth = 2) And (birthDay < Days_InMonth Or birthDay > Days_InMonth) Then

            Console.WriteLine("Invalid birth date. Day must be between 1 and your birthMonth.")
            End
        End If

        Console.WriteLine("")


        Console.WriteLine("  You're " & ageYear.ToString + " years  " & ageMonth.ToString + " months  " & ageDayy.ToString + " days old today ")



        ageYear = toYear - birthYear
        ageMonth = toMonth - birthMonth
        ageDayy = toDay - birthDay

        If (todayDate.Month >= birthMonth) Then
            ageMonth = todayDate.Month - birthMonth
        Else
            ageMonth = 12 + todayDate.Month - birthMonth
            toYear -= 1
        End If

        If (todayDate.Day >= birthDay) Then
            ageDayy = todayDate.Day - birthDay
        Else
            ageMonth -= 1
            ageDayy = DateTime.DaysInMonth(birthYear, birthMonth) + todayDate.Day - birthDay
        End If

        If (ageMonth < 0) Then
            ageMonth = 11
            ageYear -= 1
        End If


        Console.WriteLine("")
        Console.WriteLine("")





        Console.ReadLine()
    End Sub

End Module
