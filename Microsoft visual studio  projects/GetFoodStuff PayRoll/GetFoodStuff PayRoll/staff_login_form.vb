Imports MySql.Data.MySqlClient
Imports System.IO
Public Class staff_login_form
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public login_staff_id, login_role_id, login_status_id As String
    Private isPasswordVisible As Boolean = False

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        overlay.Close()
        Me.Close()
    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        If (email_address_txt.Text = "") Or (password_txt.Text = "") Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_address_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = functions.connection
            Dim hashedPassword As String = HashPassword(password_txt.Text.Trim())

            Try

                connection.Open()

                Command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address AND password=@password", connection)
                Command.Parameters.AddWithValue("@email_address", email_address_txt.Text.Trim())
                Command.Parameters.AddWithValue("@password", hashedPassword)
                reader = Command.ExecuteReader
                reader.Read()

                If reader.HasRows Then

                    login_staff_id = reader("staff_id")
                    login_status_id = reader("status_id")
                    login_role_id = reader("role_id")

                    connection.Close()

                    If login_status_id = 1 Then
                        connection.Open()
                        Command = New MySqlCommand("UPDATE staffs_tab SET last_login=NOW() WHERE staff_id=@Staff_id", connection)
                        Command.Parameters.AddWithValue("@Staff_id", login_staff_id)
                        Command.ExecuteNonQuery()
                        connection.Close()

                        Me.Hide()
                        overlay.Show()
                        Staff_dashboard.Show()
                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "Payroll System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show("Invalid email address or password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If

        loginClearFunction()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        overlay.Show()
        staff_reset_password.Show()
    End Sub
End Class