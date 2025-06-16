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
        If Not Integer.TryParse(Console.ReadLine(), birthDay) Or (birthDay < 1) Or (birthDay > Days_InMonth) Then
            Console.WriteLine("Invalid birth date. Day must be between 1 and your birthMonth .")
            End
        End If

        Console.WriteLine("")

        ageYear = toYear - birthYear
        ageMonth = toMonth - birthMonth
        ageDayy = toDay - birthDay

        If (birthYear > toYear) And (birthMonth > 12) And (birthDay > Days_InMonth) Then
            Console.WriteLine("Error! Invalid Year, Month, and Day Of Birth")
        ElseIf (birthYear <= 0) Then
            Console.WriteLine("Error! Invalid Year Of Birth")
        ElseIf (birthMonth > 12) Or (birthMonth <= 0) Then
            Console.WriteLine("Error! Invalid Month Of Birth")

        Else

            If (birthMonth = 1 Or 3 Or 5 Or 7 Or 8 Or 10 Or 12) And (birthDay > Days_InMonth) Or (birthDay <= 8) Then
            Else
                Console.WriteLine("Error! Invalid Day Of Birth")
                If (birthMonth = 2) And (birthDay > Days_InMonth) Or (birthDay <= 0) Then
                Else
                    Console.WriteLine("Error! Invalid Day Of Birth")
                    If (birthMonth = 4 Or 6 Or 9 Or 11) And (birthDay > Days_InMonth) Or (birthDay <= 0) Then
                    Else
                        Console.WriteLine("Error! Invalid Day Of Birth")

                        If (birthYear = toYear) And (birthMonth = toMonth) And (birthDay > toDay) Then
                            Console.WriteLine("Error! Invalid Day Of Birth")
                        ElseIf (birthYear = toYear) And (birthMonth > toMonth) Then
                            Console.WriteLine("Error! Invalid Month Of Birth")
                        ElseIf (birthYear > toYear) Or (birthYear <= 0) Then


                            Console.WriteLine("Error! Invalid Year Of Birth")
                        Else
                            If (birthMonth = toMonth) And (birthDay > toDay) Then
                                ageYear = toYear - birthYear - 1
                            ElseIf (birthMonth > toMonth) Then
                                ageYear = toYear - birthYear - 1
                            Else : ageYear = toYear - birthYear
                            End If

                            If (toMonth > birthMonth) And (birthDay > toDay) Then
                                ageMonth = toMonth - birthMonth - 1
                            ElseIf (birthDay > toDay) And (toMonth = birthMonth) Then
                                ageMonth = 12 - 1
                            ElseIf (birthMonth > toMonth) Then
                                ageMonth = toMonth + 12 - birthMonth - 1
                            Else : ageMonth = toMonth - birthMonth
                            End If

                            If (birthDay < toDay) And (birthMonth > toMonth) Then
                                ageDayy = toDay - birthDay
                            ElseIf (birthDay > toDay) And (birthMonth < toMonth) Then
                                ageDayy = Days_InMonth - birthDay + toDay - 1
                            ElseIf (birthDay > toDay) And (birthMonth = toMonth) Then
                                ageDayy = Days_InMonth - birthDay + toDay - 1
                            ElseIf (birthDay > toDay) And (birthMonth > toMonth) Then
                                ageDayy = Days_InMonth - birthDay + toDay - 1
                            ElseIf (birthDay > toDay) Then
                                ageDayy = birthDay - toDay
                            Else : ageDayy = toDay - birthDay
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Console.WriteLine(" You're " & ageYear.ToString + " years  " & ageMonth.ToString + " months  " & ageDayy.ToString + " days old today")

        Console.ReadLine()

    End Sub

End Module
