Imports MySql.Data.MySqlClient
Public Class reset_finish
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    'Private isPasswordVisible As Boolean = False

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        If otp_txt.Text = "" Or new_password_txt.Text = "" Or confirm_password_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(otp_txt.Text) OrElse otp_txt.Text.Length <> 6 Then
            MessageBox.Show("ERROR! OTP must be a valid 6-digit number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If new_password_txt.Text = confirm_password_txt.Text Then
                Try
                    Dim connection = functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM staffs_tab WHERE otp=@otp AND staff_id=@staff_id", connection)
                    command.Parameters.AddWithValue("@staff_id", reset_password.staff_id)
                    command.Parameters.AddWithValue("@otp", otp_txt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.Close()

                        connection.Open()
                        command = New MySqlCommand("UPDATE staffs_tab SET password=@password WHERE staff_id=@staff_id", connection)

                        Dim hashedPassword As String = functions.HashPassword(new_password_txt.Text)
                        command.Parameters.AddWithValue("@password", hashedPassword)
                        command.Parameters.AddWithValue("@staff_id", reset_password.staff_id)
                        reader = command.ExecuteReader
                        connection.Close()

                        MessageBox.Show("SUCCESS! Password has been successfully updated", "PayRoll System Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        overlay.Show()
                        login_form.Show()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "PayRoll System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New password and confirm password don't match", "PayRoll System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub otp_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otp_txt.TextChanged

    End Sub

    Private Sub reset_finish_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        otpFam()
    End Sub

    Private Sub full_name_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles full_name_txt.Click

    End Sub
End Class