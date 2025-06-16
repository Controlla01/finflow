Imports MySql.Data.MySqlClient
Public Class main
    Dim connection = functions.connection
    Dim query As String
    Dim arrimage() As Byte
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getUserIds()
        GetRecordCount()


        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try
        index.Show()
    End Sub
    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub


    Private Sub view_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_users.Click
        Me.Hide()
        records.Show()
        Me.ShowInTaskbar = False

    End Sub


    Private Sub picture_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picture_btn.Click
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        Dim answer As DialogResult
        If (full_name_txt.Text = "") Then
            MessageBox.Show("Full Name field cannot be empty. Kindly fill to proceed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (email_txt.Text = "") Then
            MessageBox.Show("The Email field cannot be empty. Kindly fill to proceed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address. Kindly correct to proceed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (phone_number_txt.Text = "") Then
            MessageBox.Show("Phone number field cannot be empty. Kindly fill to proceed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (phone_number_txt.Text > 11) Then
            MessageBox.Show("Phone number field cannot be more than 11. Kindly re-fill to proceed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf PictureBox.Image Is Nothing Then
            MessageBox.Show("Kindly upload a passport to continue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id_txt.Text = "SELECT USER") Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    If functions.RegistrationemailCheck(email_txt.Text) Then
                        MessageBox.Show("Email Address already Exists, Kindly Enter a new Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        functions.Registration()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    If functions.UpdateemailCheck(email_txt.Text) Then
                        MessageBox.Show("Email Address already Exists, Kindly Enter another Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        functions.Updated()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub full_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles full_name_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " "c Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can only be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            full_name_txt.Focus()
        End If
    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phone_number_txt.Focus()
        End If
    End Sub

    Private Sub email_txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_txt.Leave
        

    End Sub

    'Private Sub email_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email_txt.KeyPress
    'Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
    'If Not System.Text.RegularExpressions.Regex.IsMatch(email_txt.Text, emailPattern) Then
    'MessageBox.Show("Invalid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'email_txt.Focus()
    'End If
    'End Sub

    Private Sub profile_id_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id_txt.SelectedIndexChanged

    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        Try
            If profile_id_txt.Text = "SELECT USER" Then
                MessageBox.Show("Please select a valid user before fetching the profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            fetchUser()

        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub del_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_btn.Click
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to delete?", "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmation = DialogResult.Yes Then
            If (profile_id_txt.Text = "SELECT USER") Then
                MessageBox.Show("Please select a user before deleting the profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                deleteUser()
            End If
        End If
    End Sub

    Private Sub profile_id_txt_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_id_txt.SelectedValueChanged
        clearFunction2()
    End Sub
End Class
