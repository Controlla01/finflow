Imports System.Text.RegularExpressions
Public Class add_branch_form

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub create_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_btn.Click
        Dim answer = DialogResult
        If (branch_name_txt.Text = "") Then
            MessageBox.Show("Provide branch name to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (branch_email_address_txt.Text = "") Then
            MessageBox.Show("Provide branch email address to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (branch_phone_number.Text = "") Then
            MessageBox.Show("Provide branch phone number to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (branch_address.Text = "") Then
            MessageBox.Show("Provide branch address to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (status_combo.Text = "SELECT STATUS") Then
            MessageBox.Show("Select status to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(branch_email_address_txt.Text) Then
            MessageBox.Show("Input correct email format to continue", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (branch_id_combo.Text = "SELECT BRANCH") Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (answer = DialogResult.Yes) Then
                    If branchCheck(branch_name_txt.Text) Then
                        MessageBox.Show("Branch already exists by name!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf (functions.branchemailCheck(branch_email_address_txt.Text)) Then
                        MessageBox.Show("Email Address already Exist, Kindly Enter a new Email Address to Continue!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                        Return
                    Else
                        functions.RegisterBranch()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    If UpdateBranchCheck(branch_name_txt.Text) Then
                        MessageBox.Show("Branch already exists by name!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf (functions.branchUpdateemailCheck(branch_email_address_txt.Text)) Then
                        MessageBox.Show("Email Address is already Exist, Kindly Enter a new Email Address to Continue!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        functions.UpdateBranch()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub add_branch_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getBranchID()
        getStatus()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (branch_id_combo.Text = "SELECT BRANCH" OrElse branch_id_combo.Text = "") Then
            MessageBox.Show("Select a Branch to fetch")
        Else
            FetchBranch()
        End If

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub branch_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles branch_id_combo.SelectedIndexChanged
        clearFunction2()
    End Sub

    Private Sub branch_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles branch_name_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) AndAlso Not e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub branch_phone_number_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles branch_phone_number.KeyPress
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

    Private Sub branch_email_address_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles branch_email_address_txt.TextChanged
        Dim match As Match = Regex.Match(branch_email_address_txt.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)")
        If match.Success AndAlso branch_email_address_txt.Text.Length > match.Value.Length Then
            branch_email_address_txt.Text = match.Value ' Prevent further input
            MessageBox.Show("Can't accept any further value", "Email input verificaton", MessageBoxButtons.OK, MessageBoxIcon.Error)
            branch_email_address_txt.SelectionStart = branch_email_address_txt.Text.Length ' Keep cursor at end
        End If
    End Sub

End Class