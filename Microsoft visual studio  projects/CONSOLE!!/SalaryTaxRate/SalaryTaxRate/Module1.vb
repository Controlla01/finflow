Module Module1

    Sub Main()
        Dim staff_salary, tax, salary_after_tax, percentage, tax_percent As Double
        Console.WriteLine("THIS SOFTWARE  CALCULATES STAFF SALARY TAX RATE")
        Console.WriteLine()

        Console.WriteLine()

        Console.WriteLine("Enter staff salary")
        staff_salary = Console.ReadLine()

        Console.WriteLine()

        Console.WriteLine("Enter Percentage")
        percentage = Console.ReadLine()

        tax_percent = percentage * 0.01

        tax = staff_salary * tax_percent
        salary_after_tax = staff_salary - tax


        Console.WriteLine()

        Console.WriteLine("Deducted Tax @" + "" + percentage.ToString + "% Rate = " + tax.ToString + "NGN")

        Console.WriteLine()

        Console.WriteLine("Balance = " + "" + salary_after_tax.ToString + "NGN")



        Console.ReadLine()


    End Sub

End Module
