Public Class MainForm
    Private Sub btnCalculateAge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculateAge.Click
        Dim birthYear, birthMonth, birthDay As Integer

        If Not Integer.TryParse(txtBirthYear.Text, birthYear) OrElse birthYear <= 0 OrElse birthYear > DateTime.Now.Year Then
            MessageBox.Show("Please enter a valid birth year.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthYear.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtBirthMonth.Text, birthMonth) OrElse birthMonth < 1 OrElse birthMonth > 12 Then
            MessageBox.Show("Please enter a valid birth month (1-12).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthMonth.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtBirthDay.Text, birthDay) OrElse birthDay < 1 OrElse birthDay > DateTime.DaysInMonth(birthYear, birthMonth) Then
            MessageBox.Show("Please enter a valid birth day.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthDay.Focus()
            Exit Sub
        End If

        Dim today As DateTime = DateTime.Now
        Dim birthDate As New DateTime(birthYear, birthMonth, birthDay)
        If birthDate > today Then
            MessageBox.Show("Birth date cannot be in the future.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If

        Dim ageYears As Integer = today.Year - birthDate.Year
        Dim ageMonths As Integer = today.Month - birthDate.Month
        Dim ageDays As Integer = today.Day - birthDate.Day

        If ageMonths < 0 Then
            ageYears -= 1
            ageMonths += 12
        End If

        If ageDays < 0 Then
            ageMonths -= 1
            Dim previousMonth As DateTime = today.AddMonths(-1)
            ageDays += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month)
        End If

        years_txt.Text = ageYears
        months_txt.Text = ageMonths
        days_txt.Text = ageDays

    End Sub

    Private Sub txtBirthYear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBirthYear.KeyPress, txtBirthMonth.KeyPress, txtBirthDay.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    
    Private Sub Clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_btn.Click
        txtBirthYear.Text = ""
        txtBirthMonth.Text = ""
        txtBirthDay.Text = ""
    End Sub

    Private Sub txtBirthMonth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBirthMonth.TextChanged

    End Sub
End Class