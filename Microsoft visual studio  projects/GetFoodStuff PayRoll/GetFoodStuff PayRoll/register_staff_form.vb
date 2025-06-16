Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class register_staff_form

    Private Sub register_staff_form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        overlay.Close()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Dim answer = DialogResult
        If (fullname_txt.Text = "") Then
            MessageBox.Show("Fullname cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fullname_txt.Focus()
        ElseIf (email_address_txt.Text = "") Then
            MessageBox.Show("Email cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_address_txt.Focus()
        ElseIf (phone_number_txt.Text = "") Then
            MessageBox.Show("Phone Number cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phone_number_txt.Focus()
        ElseIf Not IsValidEmail(email_address_txt.Text) Then
            MessageBox.Show("INPUT CORRECT EMAIL FORMAT TO CONTINUE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (passport.Image Is Nothing) Then
            MessageBox.Show("SELECT PASSPORT", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (status_combo.Text = "SELECT STATUS") Then
            MessageBox.Show("SELECT A STATUS", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (role_combo.Text = "SELECT ROLE") Then
            MessageBox.Show("SELECT A ROLE", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (branch_combo.Text = "SELECT BRANCH") Then
            MessageBox.Show("SELECT A BRANCH", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (department_combo.Text = "SELECT DEPARTMENT") Then
            MessageBox.Show("SELECT A DEPARTMENT", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id_combo.Text = "SELECT STAFF") Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (answer = DialogResult.Yes) Then
                    If (functions.RegistrationemailCheck(email_address_txt.Text)) Then
                        MessageBox.Show("Email Address already Exist, Kindly Enter a new Email Address to Continue!", "PayRoll System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                        Return
                    Else
                        functions.Registration()
                        dashDetails()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (answer = DialogResult.Yes) Then
                    If (functions.UpdateemailCheck(email_address_txt.Text)) Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "PayRoll System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        functions.UpdateStaff()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passport_btn.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub register_staff_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getStaffID()
        getRole()
        getStatus()
        getBranch()
        getDepartment()
        getJobGrade()
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub


    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Hide()
        admin_dashboard.Show()
    End Sub

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        login_form.Show()
    End Sub

    Private Sub profile_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id_combo.SelectedIndexChanged
        clearFunction2()
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (profile_id_combo.Text = "SELECT STAFF") Then
            MessageBox.Show("Select a staff to fetch!", "Payroll System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            StaffFetching()
        End If
    End Sub

    Private Sub fullname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        Dim gunaTextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter positive whole numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If gunaTextBox.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Mobile number cannot exceed 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Sub email_address_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_address_txt.TextChanged
        Dim match As Match = Regex.Match(email_address_txt.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)")
        If match.Success AndAlso email_address_txt.Text.Length > match.Value.Length Then
            email_address_txt.Text = match.Value ' Prevent further input
            MessageBox.Show("Can't accept any further value", "Email input verificaton", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_address_txt.SelectionStart = email_address_txt.Text.Length ' Keep cursor at end
        End If
    End Sub

End Class