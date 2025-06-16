Public Class view_staff_payment_form

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub view_staff_payment_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getJobGrade()
        getStaffID()
    End Sub

    Private Sub profile_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id_combo.SelectedIndexChanged
        GetSalary()
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        save_btn.Enabled = False

        If profile_id_combo.SelectedIndex = -1 Then
            MessageBox.Show("Please select a staff member.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            save_btn.Enabled = True
            Exit Sub
        End If

        If Not IsNumeric(bonus_txt.Text) OrElse Not IsNumeric(transport_allowance_txt.Text) OrElse Not IsNumeric(commission_txt.Text) Then
            MessageBox.Show("Bonus, Allowance, and Commission must be numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            save_btn.Enabled = True
            Exit Sub
        End If

        Try
            RegisterPayment()
            MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            save_btn.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            save_btn.Enabled = True
        End Try
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        If profile_id_combo.Text = "SELECT STAFF" OrElse String.IsNullOrWhiteSpace(profile_id_combo.Text) Then
            MessageBox.Show("Please select a valid staff profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            getJobGrade()
            fetchStaffrenumeration()
        End If

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub bonus_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles transport_allowance_txt.KeyPress, commission_txt.KeyPress, bonus_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MsgBox("Only numeric values are allowed!", vbExclamation, "Invalid Input")
        End If
    End Sub
End Class