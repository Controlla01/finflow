Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=autosystem_db")
        Return conn
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim regex As New Regex("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$")

        If String.IsNullOrEmpty(email) Then
            Return False
        End If

        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function

    Public Sub clearFunction()
        main.full_name_txt.Text = ""
        main.email_txt.Text = ""
        main.phone_number_txt.Text = ""
        main.profile_id_txt.Text = "SELECT USER"
        main.PictureBox.Image = Nothing
    End Sub

    Public Sub clearFunction2()
        main.full_name_txt.Text = ""
        main.email_txt.Text = ""
        main.phone_number_txt.Text = ""
        main.PictureBox.Image = Nothing
    End Sub

    Function passport()
        Dim msstream As New System.IO.MemoryStream()
        main.PictureBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()
        Return arrimage
    End Function

    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counter_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counter_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function

    Function RegistrationemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email=@email", connection)
        command.Parameters.AddWithValue("@email", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function UpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email=@email AND user_id!=@user_id", connection)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@user_id", main.profile_id_txt.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Public Sub deleteUser()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "DELETE FROM users_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_txt.SelectedValue)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Delete Successful!")
            clearFunction()
            GetRecordCount()
            getUserIds()
        Catch ex As Exception
            MessageBox.Show("User Delete Failed:: " & ex.Message)
        End Try
    End Sub

    Public Sub Registration()
        'allow passport to save
        passport()
        Dim userId = "USER" + Now.ToString("yyyyMMddss") & functions.countId("USER")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO users_tab (user_id, full_name, email, phone_number, passport, created_time) VALUES (@user_id,@full_name,@email,@phone_number,@passport,NOW())"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", userId)
            Command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email", main.email_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)
            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("User Registration successful!")
            clearFunction()
            GetRecordCount()
        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub
    Public Sub getUserIds()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("user_id") = ""
        defaultRow("full_name") = "SELECT USER"
        defaultRow("email") = ""
        defaultRow("phone_number") = ""
        defaultRow("created_time") = Date.Now
        defaultRow("updated_time") = Date.Now
        DT.Rows.InsertAt(defaultRow, 0)

        main.profile_id_txt.DataSource = DT
        main.profile_id_txt.DisplayMember = "full_name"
        main.profile_id_txt.ValueMember = "user_id"
    End Sub
    Public Sub fetchUser()
        Try
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM users_tab WHERE user_id=@user_id", connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_txt.SelectedValue)
            reader = command.ExecuteReader
            reader.Read()

            main.full_name_txt.Text = reader("full_name")
            main.email_txt.Text = reader("email")
            main.phone_number_txt.Text = reader("phone_number")
            arrimage = reader("passport")
            mstream = New MemoryStream(arrimage)
            main.PictureBox.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Public Sub GetRecordCount()
        Dim connection = functions.connection
        Dim query As String

        connection.Open()
        query = "SELECT COUNT(*) FROM users_tab"
        command = New MySqlCommand(query, connection)
        main.record_count_label.Text = command.ExecuteScalar()
        records.record_count_label.Text = command.ExecuteScalar()
        connection.Close()
    End Sub

    Public Sub Updated()
        functions.passport()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE users_tab SET full_name=@full_name,email=@email,phone_number=@phone_number,passport=@passport WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id_txt.SelectedValue)
            command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text)
            command.Parameters.AddWithValue("@email", main.email_txt.Text)
            command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful!")
            clearFunction()
            getUserIds()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    Public Sub SetupDataGridView()
        ' Add columns
        records.record_dataGridView.Columns.Add("sn", "S/N")
        records.record_dataGridView.Columns.Add("user_id", "USER ID")
        records.record_dataGridView.Columns.Add("full_name", "FULLNAME")
        records.record_dataGridView.Columns.Add("email", "EMAIL ADDRESS")
        records.record_dataGridView.Columns.Add("phone_number", "PHONE NUMBER")

        ' Add an image column
        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.Name = "passport"
        imgColumn.HeaderText = "PASSPORT"
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        records.record_dataGridView.Columns.Add(imgColumn)

    End Sub

    Public Sub FetchUserData()
        SetupDataGridView()
        Try
            Dim connection = functions.connection

            connection.Open()
            Dim query As String = "SELECT * FROM users_tab"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim sn As String = reader("sn").ToString()
                    Dim user_id As String = reader("user_id").ToString()
                    Dim full_name As String = reader("full_name").ToString()
                    Dim email As String = reader("email").ToString()
                    Dim phone_number As String = reader("phone_number").ToString()

                    Dim img As Image = Nothing
                    If reader("passport") IsNot DBNull.Value Then
                        Dim profileImage As Byte() = CType(reader("passport"), Byte())
                        If profileImage.Length > 0 Then
                            img = Image.FromStream(New MemoryStream(profileImage))
                        End If
                    End If

                    ' Add the row to DataGridView
                    records.record_dataGridView.Rows.Add(sn, user_id, full_name, email, phone_number, img)
                End While
                connection.Close()
            Else
                MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
