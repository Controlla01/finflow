Module Module1

    Sub Main()
        Dim staff_salary, amount_deducted, availale_balance As Double
        Console.WriteLine("THIS SOFTWARE PERFORMS 5% TAX DEDUCTION FROM STAFF SALARY")
        Console.WriteLine()

        Console.WriteLine()

        Console.WriteLine("Input staff salary(#)")
        staff_salary = Console.ReadLine()
        amount_deducted = staff_salary * 0.05

        availale_balance = staff_salary - amount_deducted

        Console.WriteLine()

        Console.WriteLine("balance = #" + availale_balance.ToString)



        Console.ReadLine()


    End Sub

End Module
