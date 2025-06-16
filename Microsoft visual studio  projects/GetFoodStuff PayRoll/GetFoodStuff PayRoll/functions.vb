Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim mstream As New MemoryStream
    Dim arrimage() As Byte
    Dim query As String
    'for connection to the dbF
    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=payroll_db")
        Return conn
    End Function

    'to count users in and from the database
    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counters_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counters_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function

    Public Sub GetRecordCount()
        Dim connection = functions.connection
        Dim query As String

        connection.Open()
        query = "SELECT COUNT(*) FROM staffs_tab"
        command = New MySqlCommand(query, connection)
        admin_dashboard.total_employee_lbl.Text = command.ExecuteScalar()
        connection.Close()
    End Sub

    Public Sub GetRecordCountBranch()
        Dim connection = functions.connection
        Dim querie As String

        connection.Open()
        querie = "SELECT COUNT(*) FROM branch_tab"
        command = New MySqlCommand(querie, connection)
        admin_dashboard.branch_count_lbl.Text = command.ExecuteScalar()
        connection.Close()
    End Sub

    'passport
    Function passport()
        Dim msstream As New System.IO.MemoryStream()
        register_staff_form.passport.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()
        Return arrimage
    End Function

    'to check email_address in good mail format
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ng|edu)$"
        Return Regex.IsMatch(email, emailPattern)
    End Function

    'check if email exist in the table
    Function StaffemailCheck(ByVal email_address As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email_address)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    'to insert into the database
    Public Sub Registration()

        functions.passport()

        Dim staffId = "STAFF" + Now.ToString("yyyyMMddss") & functions.countId("STAFF")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO staffs_tab (staff_id, fullname, email_address, phone_number, passport, role_id, status_id, branch_id, department_id, job_grade_id, created_time) VALUES (@staff_id, @fullname, @email_address, @phone_number, @passport, @role_id, @status_id,  @branch_id, @department_id, @job_grade_id, NOW())"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", staffId)
            Command.Parameters.AddWithValue("@fullname", register_staff_form.fullname_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", register_staff_form.email_address_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", register_staff_form.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)
            Command.Parameters.AddWithValue("@role_id", register_staff_form.role_combo.SelectedValue)
            Command.Parameters.AddWithValue("@status_id", register_staff_form.status_combo.SelectedValue)
            Command.Parameters.AddWithValue("@branch_id", register_staff_form.branch_combo.SelectedValue)
            Command.Parameters.AddWithValue("@department_id", register_staff_form.department_combo.SelectedValue)
            Command.Parameters.AddWithValue("@job_grade_id", register_staff_form.job_grade_combo.SelectedValue)

            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("User Registration successful!")

            'GetRecordCount()
            clearFunction()
            getStaffID()

        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub

    'to fetch role 
    Public Sub getRole()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("role_id") = 0
            defaultRow("role_name") = "SELECT ROLE"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.role_combo.DataSource = DT
            register_staff_form.role_combo.DisplayMember = "role_name"
            register_staff_form.role_combo.ValueMember = "role_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch status
    Public Sub getStatus()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_status_tab WHERE status_id IN (1,2);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("status_id") = 0
            defaultRow("status_name") = "SELECT STATUS"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.status_combo.DataSource = DT
            register_staff_form.status_combo.DisplayMember = "status_name"
            register_staff_form.status_combo.ValueMember = "status_id"

            add_branch_form.status_combo.DataSource = DT
            add_branch_form.status_combo.DisplayMember = "status_name"
            add_branch_form.status_combo.ValueMember = "status_id"

            add_department.status_combo.DataSource = DT
            add_department.status_combo.DisplayMember = "status_name"
            add_department.status_combo.ValueMember = "status_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch branch
    Public Sub getBranch()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM branch_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("branch_id") = 0
            defaultRow("branch_name") = "SELECT BRANCH"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.branch_combo.DataSource = DT
            register_staff_form.branch_combo.DisplayMember = "branch_name"
            register_staff_form.branch_combo.ValueMember = "branch_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch JobGrade
    Public Sub getJobGrade()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM job_grade_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("job_grade_id") = 0
            defaultRow("job_grade_name") = "SELECT JOB GRADE"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.job_grade_combo.DataSource = DT
            register_staff_form.job_grade_combo.DisplayMember = "job_grade_name"
            register_staff_form.job_grade_combo.ValueMember = "job_grade_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading job grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch department
    Public Sub getDepartment()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM department_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("department_id") = 0
            defaultRow("department_name") = "SELECT DEPARTMENT"
            DT.Rows.InsertAt(defaultRow, 0)

            register_staff_form.department_combo.DataSource = DT
            register_staff_form.department_combo.DisplayMember = "department_name"
            register_staff_form.department_combo.ValueMember = "department_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading department: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to clear all inputs
    Public Sub clearFunction()
        'clear for staff
        register_staff_form.fullname_txt.Clear()
        register_staff_form.email_address_txt.Clear()
        register_staff_form.phone_number_txt.Clear()
        register_staff_form.status_combo.Text = "SELECT STATUS"
        register_staff_form.role_combo.Text = "SELECT ROLE"
        register_staff_form.branch_combo.Text = "SELECT BRANCH"
        register_staff_form.department_combo.Text = "SELECT DEPARTMENT"
        register_staff_form.job_grade_combo.Text = "SELECT JOB GRADE"
        register_staff_form.profile_id_combo.Text = "SELECT STAFF"
        register_staff_form.passport.Image = Nothing

        'clear for job grade
        job_grade1.job_grade_name_txt.Clear()
        job_grade1.basic_salary_txt.Clear()
        job_grade1.commission_txt.Clear()
        job_grade1.bonus_txt.Clear()
        job_grade1.allowance_txt.Clear()
        job_grade1.net_salary.Clear()
        job_grade1.tax_txt.Clear()

        If job_grade1.cmbJobGrade.Items.Count > 0 Then
            job_grade1.cmbJobGrade.SelectedIndex = 0
        End If


        'clear for branches
        add_branch_form.branch_name_txt.Clear()
        add_branch_form.branch_email_address_txt.Clear()
        add_branch_form.branch_phone_number.Clear()
        add_branch_form.branch_address.Clear()
        add_branch_form.status_combo.Text = "SELECT STATUS"
        add_branch_form.branch_id_combo.Text = "SELECT BRANCH"

        'clear department
        add_department.dept_name_txt.Clear()
        add_department.status_combo.Text = "SELECT STATUS"
        add_department.dept_id_combo.Text = "SELECT DEPARTMENT"

        'clear staff pay
        view_staff_payment_form.tax_percent_txt.Clear()
        view_staff_payment_form.transport_allowance_txt.Clear()
        view_staff_payment_form.commission_txt.Clear()
        view_staff_payment_form.basic_salary_txt.Clear()
        view_staff_payment_form.bonus_txt.Clear()
        view_staff_payment_form.total_txt.Clear()
        view_staff_payment_form.profile_id_combo.Text = "SELECT STAFF"
        view_staff_payment_form.ComboBox1.Text = "SELECT JOB GRADE"

    End Sub

    Public Sub clearFunction2()
        'clear for staff
        register_staff_form.fullname_txt.Clear()
        register_staff_form.email_address_txt.Clear()
        register_staff_form.phone_number_txt.Clear()
        register_staff_form.status_combo.Text = "SELECT STATUS"
        register_staff_form.role_combo.Text = "SELECT ROLE"
        register_staff_form.branch_combo.Text = "SELECT BRANCH"
        register_staff_form.department_combo.Text = "SELECT DEPARTMENT"
        register_staff_form.job_grade_combo.Text = "SELECT JOB GRADE"
        register_staff_form.passport.Image = Nothing

        'clear for branches
        add_branch_form.branch_name_txt.Clear()
        add_branch_form.branch_email_address_txt.Clear()
        add_branch_form.branch_phone_number.Clear()
        add_branch_form.branch_address.Clear()
        add_branch_form.status_combo.Text = "SELECT STATUS"

        'clear department
        add_department.dept_name_txt.Clear()
        add_department.status_combo.Text = "SELECT STATUS"

    End Sub

    'to protect password
    Public Function HashPassword(ByVal defaultPassword As String) As String
        Using md5 As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(defaultPassword)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using
    End Function

    'check fetch staff details
    Function getStaffProfile(ByVal staff_id As String)
        Dim connection = functions.connection
        connection.Open()
        Dim command As New MySqlCommand("SELECT a.fullname, a.last_login, a.passport, b.role_name  FROM staffs_tab a, setup_role_tab b WHERE staff_id=@staff_id AND a.role_id=b.role_id", connection)
        command.Parameters.AddWithValue("@staff_id", staff_id)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            Dim role_name As String = reader("role_name").ToString()
            Dim fullname As String = reader("fullname").ToString()
            Dim last_login As DateTime = Convert.ToDateTime(reader("last_login"))
            Dim arrimage As Byte() = CType(reader("passport"), Byte())

            connection.Close()
            Return Tuple.Create(fullname, last_login, arrimage, role_name)
        Else

            connection.Close()
            Return Nothing
        End If
    End Function

    Public Sub loginClearFunction()
        login_form.email_address_txt.Clear()
        login_form.password_txt.Clear()
    End Sub

    Public Sub getStaffID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        If (login_form.login_role_id = 3) Then
            command = New MySqlCommand("SELECT * FROM staffs_tab   ", connection)
            DT.Load(command.ExecuteReader)
        Else

            command = New MySqlCommand("SELECT * FROM staffs_tab where role_id IN (1,2) ", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("staff_id") = ""
            defaultRow("role_id") = 0
            defaultRow("status_id") = 0
            defaultRow("fullname") = "SELECT STAFF"
            defaultRow("email_address") = ""
            defaultRow("phone_number") = ""
            defaultRow("branch_id") = ""
            defaultRow("department_id") = ""
            defaultRow("phone_number") = ""

            defaultRow("password") = ""
            defaultRow("otp") = 0
            DT.Rows.InsertAt(defaultRow, 0)
        End If

        register_staff_form.profile_id_combo.DataSource = DT
        register_staff_form.profile_id_combo.DisplayMember = "fullname"
        register_staff_form.profile_id_combo.ValueMember = "staff_id"

        view_staff_payment_form.profile_id_combo.DataSource = DT
        view_staff_payment_form.profile_id_combo.DisplayMember = "fullname"
        view_staff_payment_form.profile_id_combo.ValueMember = "staff_id"
    End Sub

    Public Sub getBranchID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM branch_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("branch_id") = ""
        defaultRow("branch_name") = "SELECT BRANCH"
        defaultRow("branch_email_address") = ""
        defaultRow("branch_phone_number") = ""
        defaultRow("branch_address") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        add_branch_form.branch_id_combo.DataSource = DT
        add_branch_form.branch_id_combo.DisplayMember = "branch_name"
        add_branch_form.branch_id_combo.ValueMember = "branch_id"

    End Sub

    Public Sub getDeptID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM department_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("department_id") = ""
        defaultRow("department_name") = "SELECT DEPARTMENT"
        DT.Rows.InsertAt(defaultRow, 0)

        add_department.dept_id_combo.DataSource = DT
        add_department.dept_id_combo.DisplayMember = "department_name"
        add_department.dept_id_combo.ValueMember = "department_id"

    End Sub

    'to fetch staff
    Public Sub StaffFetching()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.*, b.role_name, c.status_name,d.branch_name, e.department_name, f.job_grade_name FROM staffs_tab a, setup_role_tab b, setup_status_tab c,branch_tab d, department_tab e, job_grade_tab f WHERE a.status_id=c.status_id AND a.role_id=b.role_id AND a.branch_id=d.branch_id AND a.department_id= e.department_id AND a.job_grade_id=f.job_grade_id AND staff_id=@staff_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            Dim arrimage() As Byte

            register_staff_form.fullname_txt.Text = reader("fullname")
            register_staff_form.phone_number_txt.Text = reader("phone_number")
            register_staff_form.email_address_txt.Text = reader("email_address")
            register_staff_form.role_combo.Text = (reader("role_name"))
            register_staff_form.role_combo.SelectedValue = reader("role_id")
            register_staff_form.status_combo.Text = (reader("status_name"))
            register_staff_form.status_combo.SelectedValue = reader("status_id")
            register_staff_form.branch_combo.Text = (reader("branch_name"))
            register_staff_form.branch_combo.SelectedValue = reader("branch_id")
            register_staff_form.department_combo.Text = (reader("department_name"))
            register_staff_form.department_combo.SelectedValue = reader("department_id")
            register_staff_form.job_grade_combo.SelectedValue = reader("job_grade_id")

            arrimage = reader("passport")

            Dim mstream = New MemoryStream(arrimage)
            register_staff_form.passport.Image = Image.FromStream(mstream)
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub fetchStaffrenumeration2()
        Try
            Dim connection = functions.connection
            connection.Open()


            query = "SELECT a.fullname, a.passport, b.basic_salary, c.transport_allowance, c.bonus, c.commission FROM staffs_tab a, job_grade_tab b , staff_payment_tab c WHERE a.staff_id=@staff_id AND a.job_grade_id=b.job_grade_id AND a.staff_id=c.staff_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", staff_login_form.login_staff_id)
            reader = Command.ExecuteReader

            If reader.Read() Then
                Dim arrimage() As Byte
                Dim basic_salary, bonus, commission, transport_allowance, tax_amount, taxPercentage As Double

                basic_salary = If(IsDBNull(reader("basic_salary")), 0, reader("basic_salary"))
                bonus = If(IsDBNull(reader("bonus")), 0, reader("bonus"))
                commission = If(IsDBNull(reader("commission")), 0, reader("commission"))
                transport_allowance = If(IsDBNull(reader("transport_allowance")), 0, reader("transport_allowance"))

                If Not String.IsNullOrWhiteSpace(job_grade1.tax_txt.Text) Then
                    Double.TryParse(job_grade1.tax_txt.Text, taxPercentage)
                End If

                tax_amount = (taxPercentage / 100) * basic_salary

                staffs_payroll_form.basic_salary_txt.Text = FormatCurrencyyy(basic_salary)
                staffs_payroll_form.bonus_txt.Text = FormatCurrencyyy(bonus)
                staffs_payroll_form.commission_txt.Text = FormatCurrencyyy(commission)
                staffs_payroll_form.transport_allowance_txt.Text = FormatCurrencyyy(transport_allowance)
                staffs_payroll_form.tax_percent_txt.Text = FormatCurrencyyy(tax_amount)
                staffs_payroll_form.total_txt.Text = FormatCurrencyyy((basic_salary + bonus + commission + transport_allowance) - tax_amount)

                If Not IsDBNull(reader("passport")) Then
                    arrimage = CType(reader("passport"), Byte())
                    Dim mstream As New MemoryStream(arrimage)
                    staffs_payroll_form.passport.Image = Image.FromStream(mstream)
                End If
            Else
                staffs_payroll_form.basic_salary_txt.Clear()
                staffs_payroll_form.bonus_txt.Clear()
                staffs_payroll_form.commission_txt.Clear()
                staffs_payroll_form.transport_allowance_txt.Clear()
                staffs_payroll_form.tax_percent_txt.Clear()
                staffs_payroll_form.total_txt.Clear()
                staffs_payroll_form.passport.Image = Nothing

                MsgBox("No renumeration record found for this staff. Please enter details and save.", vbExclamation, "No Record Found")
            End If

        Catch ex As Exception
            MsgBox("Error fetching renumeration details: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Function FormatCurrencyyy(ByVal value As Object) As String
        Return Format(CDec(value), "#,##0.00")
    End Function


    'check fetch staff renumeration details
    Public Sub fetchStaffrenumeration()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.fullname, a.passport, b.job_grade_name, b.basic_salary, c.bonus, c.commission, c.transport_allowance  FROM staffs_tab a, job_grade_tab b , staff_payment_tab c WHERE a.staff_id=@staff_id AND a.job_grade_id=b.job_grade_id AND a.staff_id=c.staff_id;"

            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@staff_id", view_staff_payment_form.profile_id_combo.SelectedValue)
            reader = Command.ExecuteReader()

            If reader.Read() Then
                Dim arrimage() As Byte
                Dim basic_salary, bonus, commission, transport_allowance, tax_amount, taxPercentage As Double

                basic_salary = If(IsDBNull(reader("basic_salary")), 0, reader("basic_salary"))
                bonus = If(IsDBNull(reader("bonus")), 0, reader("bonus"))
                commission = If(IsDBNull(reader("commission")), 0, reader("commission"))
                transport_allowance = If(IsDBNull(reader("transport_allowance")), 0, reader("transport_allowance"))

                If Not String.IsNullOrWhiteSpace(job_grade1.tax_txt.Text) Then
                    Double.TryParse(job_grade1.tax_txt.Text, taxPercentage)
                End If

                tax_amount = (taxPercentage / 100) * basic_salary

                view_staff_payment_form.basic_salary_txt.Text = FormatCurrencyy(basic_salary)
                view_staff_payment_form.bonus_txt.Text = FormatCurrencyy(bonus)
                view_staff_payment_form.commission_txt.Text = FormatCurrencyy(commission)
                view_staff_payment_form.transport_allowance_txt.Text = FormatCurrencyy(transport_allowance)
                view_staff_payment_form.tax_percent_txt.Text = FormatCurrencyy(tax_amount)
                view_staff_payment_form.total_txt.Text = FormatCurrencyy((basic_salary + bonus + commission + transport_allowance) - tax_amount)

                view_staff_payment_form.ComboBox1.SelectedIndex = -1
                view_staff_payment_form.ComboBox1.Text = reader("job_grade_name").ToString()

                If Not IsDBNull(reader("passport")) Then
                    arrimage = CType(reader("passport"), Byte())
                    Dim mstream As New MemoryStream(arrimage)
                    view_staff_payment_form.passport.Image = Image.FromStream(mstream)
                End If
            Else
                view_staff_payment_form.basic_salary_txt.Clear()
                view_staff_payment_form.bonus_txt.Clear()
                view_staff_payment_form.commission_txt.Clear()
                view_staff_payment_form.transport_allowance_txt.Clear()
                view_staff_payment_form.tax_percent_txt.Clear()
                view_staff_payment_form.total_txt.Clear()
                view_staff_payment_form.passport.Image = Nothing
                view_staff_payment_form.ComboBox1.SelectedIndex = -1

                MsgBox("No renumeration record found for this staff. Please enter details and save.", vbExclamation, "No Record Found")
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox("Error fetching renumeration details: " & ex.Message, vbCritical, "Error")
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Function FormatCurrencyy(ByVal value As Object) As String
        Return Format(CDec(value), "#,##0.00")
    End Function

    'to fetch branch
    Public Sub FetchBranch()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.*, b.status_name FROM branch_tab a, setup_status_tab b WHERE a.status_id=b.status_id AND branch_id=@branch_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            add_branch_form.branch_name_txt.Text = reader("branch_name")
            add_branch_form.branch_email_address_txt.Text = reader("branch_email_address")
            add_branch_form.branch_phone_number.Text = reader("branch_phone_number")
            add_branch_form.branch_address.Text = reader("branch_address")
            add_branch_form.status_combo.Text = (reader("status_name"))
            add_branch_form.status_combo.SelectedValue = reader("status_id")


            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'to fetch department
    Public Sub FetchDepartment()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT a.*, b.status_name FROM department_tab a, setup_status_tab b WHERE a.status_id=b.status_id AND department_id=@department_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            add_department.dept_name_txt.Text = reader("department_name")
            add_department.status_combo.Text = (reader("status_name"))


            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Function DeptCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT department_name FROM department_tab WHERE department_name = @department_name", connection)
        command.Parameters.AddWithValue("@department_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function UpdateDeptCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT department_name FROM department_tab WHERE department_name=@department_name AND department_id!=@department_id", connection)
        command.Parameters.AddWithValue("@department_name", name)
        command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    'to register branch
    Public Sub RegisterBranch()

        Dim branchId = "BRANCH" & functions.countId("BRANCH")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO branch_tab (branch_id, branch_name, branch_email_address, branch_phone_number, branch_address, status_id) VALUES (@branch_id, @branch_name, @branch_email_address, @branch_phone_number, @branch_address, @status_id)"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@branch_id", branchId)
            Command.Parameters.AddWithValue("@branch_name", add_branch_form.branch_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@branch_email_address", add_branch_form.branch_email_address_txt.Text)
            Command.Parameters.AddWithValue("@branch_phone_number", add_branch_form.branch_phone_number.Text)
            Command.Parameters.AddWithValue("@branch_address", add_branch_form.branch_address.Text.ToUpper())
            Command.Parameters.AddWithValue("@status_id", add_branch_form.status_combo.SelectedValue)


            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Branch Registration successful !")

            clearFunction()
            getBranchID()

        Catch ex As Exception
            MsgBox("Branch Registration failed: " & ex.Message)
        End Try
    End Sub

    'to register department
    Public Sub RegisterDept()

        Dim deptId = "DEPT00" & functions.countId("DEPT00")

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "INSERT INTO department_tab (department_id, department_name, status_id) VALUES (@department_id, @department_name, @status_id)"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@department_id", deptId)
            Command.Parameters.AddWithValue("@department_name", add_department.dept_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@status_id", add_department.status_combo.SelectedValue)


            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Department Registration successful Registration successful!")

            clearFunction()
            getDeptID()

        Catch ex As Exception
            MsgBox("User Registration failed: " & ex.Message)
        End Try
    End Sub

    'to update staff
    Public Sub UpdateStaff()
        functions.passport()
        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE staffs_tab SET fullname=@fullname,email_address=@email_address,phone_number=@phone_number,role_id=@role_id,status_id=@status_id,branch_id=@branch_id,department_id=@department_id,job_grade_id=@job_grade_id,passport=@passport WHERE staff_id=@staff_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@fullname", register_staff_form.fullname_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@email_address", register_staff_form.email_address_txt.Text)
            command.Parameters.AddWithValue("@phone_number", register_staff_form.phone_number_txt.Text)
            command.Parameters.AddWithValue("@branch_id", register_staff_form.branch_combo.SelectedValue)
            command.Parameters.AddWithValue("@role_id", register_staff_form.role_combo.SelectedValue)
            command.Parameters.AddWithValue("@status_id", register_staff_form.status_combo.SelectedValue)
            command.Parameters.AddWithValue("@department_id", register_staff_form.department_combo.SelectedValue)
            command.Parameters.AddWithValue("@job_grade_id", register_staff_form.job_grade_combo.SelectedValue)
            command.Parameters.AddWithValue("@passport", arrimage)
            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful !")
            clearFunction()
            getStaffID()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    'to update branch
    Public Sub UpdateBranch()

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE branch_tab SET branch_name=@branch_name, branch_email_address=@branch_email_address, branch_phone_number=@branch_phone_number,branch_address=@branch_address, status_id=@status_id WHERE branch_id=@branch_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@branch_name", add_branch_form.branch_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@branch_email_address", add_branch_form.branch_email_address_txt.Text)
            command.Parameters.AddWithValue("@branch_phone_number", add_branch_form.branch_phone_number.Text)
            command.Parameters.AddWithValue("@branch_address", add_branch_form.branch_address.Text.ToUpper)
            command.Parameters.AddWithValue("@status_id", add_branch_form.status_combo.SelectedValue)

            reader = command.ExecuteReader
            connection.Close()

            MsgBox("User Update Successful !")
            clearFunction()
            getBranchID()
        Catch ex As Exception
            MessageBox.Show("User Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    'to update department
    Public Sub UpdateDepartment()

        Try
            Dim connection = functions.connection
            Dim query As String

            connection.Open()
            query = "UPDATE department_tab SET department_name=@department_name, status_id=@status_id WHERE department_id=@department_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@department_id", add_department.dept_id_combo.SelectedValue)
            command.Parameters.AddWithValue("@department_name", add_department.dept_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@status_id", add_department.status_combo.SelectedValue)

            reader = command.ExecuteReader
            connection.Close()

            MsgBox("Department Update Successful !")
            clearFunction()
            getDeptID()
        Catch ex As Exception
            MessageBox.Show("Department Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    'check for email duplication or reuse in database
    Function RegistrationemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    'check for email duplication or resuse during update
    Function UpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staffs_tab WHERE email_address=@email_address AND staff_id!=@staff_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@staff_id", register_staff_form.profile_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Public Sub LoadTotalPayment()
        Dim connection = functions.connection
        Try
            connection.Open()

            Dim month_id As Integer = DateTime.Now.Month
            Dim year_id As Integer = DateTime.Now.Year

            Dim query As String = "SELECT total_payment FROM(payroll_tab) WHERE month_id = @month_id AND year_id = @year_id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@month_id", month_id)
            cmd.Parameters.AddWithValue("@year_id", year_id)

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                admin_dashboard.lblTotalPayment.Text = "₦" & Convert.ToDecimal(result).ToString("N2")
            Else
                admin_dashboard.lblTotalPayment.Text = "₦0.00"
            End If

        Catch ex As Exception
            admin_dashboard.lblTotalPayment.Text = "Error"
            MsgBox("Error loading total payment: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub dashDetails()
        GetRecordCount()
        GetRecordCountBranch()
        LoadTotalPayment()


        Dim result = functions.getStaffProfile(login_form.login_staff_id)
        Dim arrimage() As Byte = result.item3
        Dim hour As Integer = DateTime.Now.Hour
        Dim greeting As String = "Hello"
        If hour > 12 Then
            greeting = "Boboyi, Good Day"
        Else
            greeting = "Good Evening"
        End If
        admin_dashboard.lblAdminGreeting.Text = greeting & ", " & result.item1.ToString
        admin_dashboard.role_id_lbl.Text = result.item4.ToString
        admin_dashboard.staff_fullname_lbl.Text = result.item1.ToString
        admin_dashboard.last_login_lbl.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        admin_dashboard.admin_passport.Image = Image.FromStream(mstream)

    End Sub

    Public Sub staffdashDetails()

        Dim result = functions.getStaffProfile(staff_login_form.login_staff_id)
        Dim arrimage() As Byte = result.item3

        Staff_dashboard.role_id_lbl.Text = result.item4.ToString
        Staff_dashboard.staff_fullname_lbl.Text = result.item1.ToString
        Staff_dashboard.last_login_lbl.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        Staff_dashboard.admin_passport.Image = Image.FromStream(mstream)

        Dim hour As Integer = DateTime.Now.Hour
        Dim greeting As String = "Hello"

        If hour > 12 Then
            greeting = "Boboyi, Good Day"
        Else
            greeting = "Good Evening"
        End If
        Staff_dashboard.lblAdminGreeting.Text = greeting & ", " & result.item1.ToString
    End Sub

    Public Sub GetSalary()

        Dim connection = functions.connection
        connection.Open()

        query = "SELECT a.basic_salary FROM  job_grade_tab a, staffs_tab b  WHERE a.job_grade_id = b.job_grade_id AND b.staff_id = @staff_id;"
        Dim Command = New MySqlCommand(query, connection)
        Command.Parameters.AddWithValue("@staff_id", view_staff_payment_form.profile_id_combo.SelectedValue)
        reader = Command.ExecuteReader

        If reader.Read() Then
            If Not IsDBNull(reader("basic_salary")) Then
                view_staff_payment_form.basic_salary_txt.Text = reader("basic_salary").ToString()
            Else
                view_staff_payment_form.basic_salary_txt.Text = "0"
            End If
        Else

            view_staff_payment_form.basic_salary_txt.Text = "No Data"
        End If

        reader.Close()
        connection.Close()

    End Sub

    Public Sub RegisterPayment()

        Dim staff_payment_id As String = "SP00" & functions.countId("SP00")
        Try
            Dim connection = functions.connection
            Dim query As String


            connection.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM staff_payment_tab WHERE staff_id = @staff_id"
            Dim checkCommand As New MySqlCommand(checkQuery, connection)
            checkCommand.Parameters.AddWithValue("@staff_id", view_staff_payment_form.profile_id_combo.SelectedValue)

            Dim recordExists As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

            Dim confirmationMessage As String
            If recordExists > 0 Then
                confirmationMessage = "Are you sure you want to update this record?"
            Else
                confirmationMessage = "Are you sure you want to save this record?"
            End If

            Dim response As MsgBoxResult = MsgBox(confirmationMessage, vbYesNo + vbQuestion, "Confirm Action")
            If response = vbNo Then
                connection.Close()
                Exit Sub
            End If

            If recordExists > 0 Then
                query = "UPDATE staff_payment_tab SET transport_allowance = @transport_allowance, bonus = @bonus, commission = @commission, tax = @tax WHERE staff_id = @staff_id"
            Else
                query = "INSERT INTO staff_payment_tab (staff_payment_id, staff_id, transport_allowance, bonus, commission, tax) VALUES (@staff_payment_id, @staff_id, @transport_allowance, @bonus, @commission, @tax);"
            End If

            Dim Command As New MySqlCommand(query, connection)
            If recordExists = 0 Then Command.Parameters.AddWithValue("@staff_payment_id", staff_payment_id)
            Command.Parameters.AddWithValue("@staff_id", view_staff_payment_form.profile_id_combo.SelectedValue)
            Command.Parameters.AddWithValue("@bonus", ConvertToDecimal(view_staff_payment_form.bonus_txt.Text))
            Command.Parameters.AddWithValue("@commission", ConvertToDecimal(view_staff_payment_form.commission_txt.Text))
            Command.Parameters.AddWithValue("@tax", ConvertToDecimal(view_staff_payment_form.tax_percent_txt.Text))
            Command.Parameters.AddWithValue("@transport_allowance", ConvertToDecimal(view_staff_payment_form.transport_allowance_txt.Text))

            Command.ExecuteNonQuery()
            connection.Close()

            If recordExists > 0 Then
                MsgBox("Staff's Renumeration Updated successfully!", vbInformation, "Success")
            Else
                MsgBox("Staff's Renumeration Registration successful!", vbInformation, "Success")
            End If

            FormatTextFields()

            clearFunction()
            getBranchID()

        Catch ex As Exception
            MsgBox("Staff's Renumeration Operation failed: " & ex.Message, vbCritical, "Error")
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Function ConvertToDecimal(ByVal value As String) As Decimal
        Dim result As Decimal
        Decimal.TryParse(value, Globalization.NumberStyles.Currency, Globalization.CultureInfo.InvariantCulture, result)
        Return result
    End Function

    Public Sub FormatTextFields()
        view_staff_payment_form.bonus_txt.Text = FormatCurrency(view_staff_payment_form.bonus_txt.Text)
        view_staff_payment_form.commission_txt.Text = FormatCurrency(view_staff_payment_form.commission_txt.Text)
        view_staff_payment_form.tax_percent_txt.Text = FormatCurrency(view_staff_payment_form.tax_percent_txt.Text)
        view_staff_payment_form.transport_allowance_txt.Text = FormatCurrency(view_staff_payment_form.transport_allowance_txt.Text)
    End Sub

    Function FormatCurrency(ByVal value As Object) As String
        Return Format(CDec(value), "#,##0.00")
    End Function

    'REGISTER JOB GRDAE
    Public Sub RegisterJobgrade()

        Dim JobGradegId = "JG00" & functions.countId("JG00")

        Try
            Dim connection = functions.connection
            Dim query As String

            Dim basic_salary, bonus, commission, allowance, tax, net_salary, tax_rate As Decimal

            basic_salary = ToDecimal(job_grade1.basic_salary_txt.Text)
            commission = ToDecimal(job_grade1.commission_txt.Text)
            bonus = ToDecimal(job_grade1.bonus_txt.Text)
            allowance = ToDecimal(job_grade1.allowance_txt.Text)
            tax_rate = ToDecimal(job_grade1.tax_txt.Text)
            tax = (tax_rate / 100) * basic_salary
            net_salary = (basic_salary + commission + bonus + allowance) - tax



            connection.Open()
            query = "INSERT INTO job_grade_tab (job_grade_id, job_grade_name, basic_salary, transport_allowance, bonus, commission, tax, net_salary, updated_time) VALUES (@job_grade_id, @job_grade_name, @basic_salary, @transport_allowance, @bonus, @commission, @tax, @net_salary, NOW())"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@job_grade_id", JobGradegId)
            Command.Parameters.AddWithValue("@job_grade_name", job_grade1.job_grade_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@basic_salary", basic_salary)
            Command.Parameters.AddWithValue("@transport_allowance", allowance)
            Command.Parameters.AddWithValue("@bonus", bonus)
            Command.Parameters.AddWithValue("@commission", commission)
            Command.Parameters.AddWithValue("@tax", tax_rate)
            Command.Parameters.AddWithValue("@net_salary", net_salary)


            reader = Command.ExecuteReader
            connection.Close()

            MsgBox("Job Grade Registration successful !")

            'GetRecordCount()
            clearFunction()
            getJobGradeID()

        Catch ex As Exception
            MsgBox("Job Grade Registration failed: " & ex.Message)
        End Try
    End Sub

    Function ToDecimal(ByVal value As String) As Decimal
        If IsNumeric(value) Then
            Return Convert.ToDecimal(value)
        Else
            Return 0
        End If
    End Function

    Public Sub UpdateJobGrade()

        Try
            Dim connection = functions.connection
            Dim query As String

            Dim basic_salary, bonus, commission, allowance, tax, net_salary, tax_rate As Decimal

            basic_salary = ToDecimal(job_grade1.basic_salary_txt.Text)
            commission = ToDecimal(job_grade1.commission_txt.Text)
            bonus = ToDecimal(job_grade1.bonus_txt.Text)
            allowance = ToDecimal(job_grade1.allowance_txt.Text)
            tax_rate = ToDecimal(job_grade1.tax_txt.Text)
            tax = (tax_rate / 100) * basic_salary
            net_salary = (basic_salary + commission + bonus + allowance) - tax

            connection.Open()
            query = "UPDATE job_grade_tab SET job_grade_name=@job_grade_name, basic_salary=@basic_salary, transport_allowance=@transport_allowance,bonus=@bonus,commission=@commission,tax=@tax,net_salary =@net_salary  WHERE job_grade_id=@job_grade_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@job_grade_id", job_grade1.cmbJobGrade.SelectedValue)
            command.Parameters.AddWithValue("@job_grade_name", job_grade1.job_grade_name_txt.Text.ToUpper)
            command.Parameters.AddWithValue("@basic_salary", basic_salary)
            command.Parameters.AddWithValue("@transport_allowance", allowance)
            command.Parameters.AddWithValue("@bonus", bonus)
            command.Parameters.AddWithValue("@commission", commission)
            command.Parameters.AddWithValue("@tax", tax_rate)
            command.Parameters.AddWithValue("@net_salary", net_salary)


            reader = command.ExecuteReader
            connection.Close()

            MsgBox("Job Grade Update Successful !")
            clearFunction()
            getJobGradeID()
        Catch ex As Exception
            MessageBox.Show("Job Grade Upadate Failed:: " & ex.Message)
        End Try
    End Sub

    Public Sub getJobGradeID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM job_grade_tab  ", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("job_grade_id") = ""
        defaultRow("job_grade_name") = "SELECT JOB GRADE"
        'defaultRow("basic_salary") = 0.0

        DT.Rows.InsertAt(defaultRow, 0)

        job_grade1.cmbJobGrade.DataSource = DT
        job_grade1.cmbJobGrade.DisplayMember = "job_grade_name"
        job_grade1.cmbJobGrade.ValueMember = "job_grade_id"
        connection.Close()
    End Sub

    Public Sub FetchJobGrade()
        Try
            Dim connection = functions.connection
            connection.Open()

            query = "SELECT job_grade_name, basic_salary, transport_allowance, bonus, commission, tax, net_salary FROM job_grade_tab WHERE job_grade_id=@job_grade_id;"
            Dim Command = New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@job_grade_id", job_grade1.cmbJobGrade.SelectedValue)
            reader = Command.ExecuteReader
            reader.Read()

            job_grade1.job_grade_name_txt.Text = reader("job_grade_name")
            job_grade1.basic_salary_txt.Text = reader("basic_salary")
            job_grade1.allowance_txt.Text = reader("transport_allowance")
            job_grade1.bonus_txt.Text = reader("bonus")
            job_grade1.commission_txt.Text = reader("commission")
            job_grade1.net_salary.Text = reader("net_salary")
            job_grade1.tax_txt.Text = reader("tax")

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function jobgradeCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT job_grade_name FROM job_grade_tab WHERE job_grade_name = @job_grade_name", connection)
        command.Parameters.AddWithValue("@job_grade_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function UpdateJobGradeCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT job_grade_name FROM job_grade_tab WHERE job_grade_name=@job_grade_name AND job_grade_id!=@job_grade_id", connection)
        command.Parameters.AddWithValue("@job_grade_name", name)
        command.Parameters.AddWithValue("@job_grade_id", job_grade1.cmbJobGrade.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Public Sub ViewAllStaffRecords()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection


            Dim command As New MySqlCommand("SELECT a.staff_id, a.fullname, b.role_name, c.status_name, d.branch_name, e.department_name, f.job_grade_name FROM staffs_tab a, setup_role_tab b, setup_status_tab c, branch_tab d, department_tab e, job_grade_tab f WHERE  a.role_id = b.role_id AND a.status_id = c.status_id AND a.branch_id = d.branch_id AND a.department_id = e.department_id AND a.job_grade_id = f.job_grade_id;", connection)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)

            view_staff_records.staff_record.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staff_id").ToString())
                listItem.SubItems.Add(row("fullname").ToString())
                listItem.SubItems.Add(row("role_name").ToString())
                listItem.SubItems.Add(row("status_name").ToString())
                listItem.SubItems.Add(row("branch_name").ToString())
                listItem.SubItems.Add(row("department_name").ToString())
                listItem.SubItems.Add(row("job_grade_name").ToString())

                view_staff_records.staff_record.Items.Add(listItem)
                sn = sn + 1
            Next
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function OtpResetFetch(ByVal emaill As String)
        Dim email As String = reset_password.email_address_txt.Text
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT fullname, email_address FROM staffs_tab WHERE email_address =@email_address;", connection)
        command.Parameters.AddWithValue("@email_address", email)
        reader = command.ExecuteReader
        reader.Read()

        Dim fullname = reader("fullname")
        Dim email_address = reader("email_address")
        connection.close()
        Return Tuple.Create(fullname, email_address)
    End Function

    Public Sub otpFam()
        Dim result = functions.OtpResetFetch(reset_password.email_address_txt.Text)
        reset_finish.full_name_txt.Text = result.item1.ToString.ToUpper
        reset_finish.email_address_txt.Text = result.item2.ToString
    End Sub

    Function branchemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT branch_email_address FROM branch_tab WHERE branch_email_address=@branch_email_address", connection)
        command.Parameters.AddWithValue("@branch_email_address", email)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function branchUpdateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM branch_tab WHERE branch_email_address=@branch_email_address AND branch_id!=@branch_id", connection)
        command.Parameters.AddWithValue("@branch_email_address", email)
        command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmail = reader.Read()
        connection.Close()
        Return validateEmail
    End Function

    Function branchCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT branch_name FROM branch_tab WHERE branch_name = @branch_name", connection)
        command.Parameters.AddWithValue("@branch_name", name)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function

    Function UpdateBranchCheck(ByVal name As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT branch_name FROM branch_tab WHERE branch_name=@branch_name AND branch_id!=@branch_id", connection)
        command.Parameters.AddWithValue("@branch_name", name)
        command.Parameters.AddWithValue("@branch_id", add_branch_form.branch_id_combo.SelectedValue)
        reader = command.ExecuteReader
        Dim validateJB = reader.Read()
        connection.Close()
        Return validateJB
    End Function
End Module