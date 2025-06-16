Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class staff_reset_password
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public staff_id, fullname, email_address, status_id As String

    Private Sub next_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_btn.Click
        If email_address_txt.Text = "" Then
            MessageBox.Show("This field cannot be empty. Kindly fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_address_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try

                reader = functions.StaffemailCheck(email_address_txt.Text)
                If reader.HasRows Then
                    staff_id = reader("staff_id")
                    Dim status_id = reader("status_id")
                    fullname = reader("fullname")
                    email_address = reader("email_address")

                    If status_id = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = functions.connection

                        connection.Open()
                        Command = New MySqlCommand("UPDATE staffs_tab SET otp=@otp WHERE staff_id=@staff_id", connection)
                        Command.Parameters.AddWithValue("@staff_id", staff_id)
                        Command.Parameters.AddWithValue("@otp", otp)
                        reader = Command.ExecuteReader
                        connection.Close()

                        functions.loginClearFunction()
                        Me.Hide()
                        overlay.Show()
                        staff_reset_finish.Show()

                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "PayRoll System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email Address not Found!", "PayRoll System Software", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        overlay.Close()
        Me.Close()
    End Sub
End Class