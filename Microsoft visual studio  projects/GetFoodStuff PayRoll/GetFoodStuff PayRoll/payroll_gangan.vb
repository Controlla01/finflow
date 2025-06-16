Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class payroll_gangan

    Private Sub payroll_gangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentYear As Integer = DateTime.Now.Year
        Dim startYear As Integer = 2024
        Dim endYear As Integer = Math.Max(currentYear + 2, 2027)

        cmbMonth.Items.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        cmbMonth.SelectedIndex = DateTime.Now.Month - 1
        
        For year As Integer = startYear To endYear
            cmbYear.Items.Add(year)
        Next
        cmbYear.SelectedItem = currentYear

        cmbMonth.Items.Insert(0, "-- Select Month --")
        cmbMonth.SelectedIndex = 0

        cmbYear.Items.Insert(0, "-- Select Year --")
        cmbYear.SelectedIndex = 0

        DisableActionButtons()

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        CheckMonthYearSelection()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        CheckMonthYearSelection()
    End Sub

    Private Sub CheckMonthYearSelection()
        If cmbMonth.SelectedIndex > 0 AndAlso cmbYear.SelectedIndex > 0 Then
            EnableActionButtons()
        Else
            DisableActionButtons()
        End If
    End Sub

    Private Sub DisableActionButtons()
        btnRunPayroll.Enabled = False
        btnSavePayroll.Enabled = False
        btnOverride.Enabled = False
    End Sub

    Private Sub EnableActionButtons()
        btnRunPayroll.Enabled = True
        btnSavePayroll.Enabled = True
        btnOverride.Enabled = True
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        admin_dashboard.Show()
    End Sub

    Private Sub btnRunPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRunPayroll.Click
        RunPayroll()
    End Sub

    Private Sub btnSavePayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePayroll.Click
        If cmbMonth.SelectedIndex = -1 Or cmbYear.SelectedIndex = -1 Then
            MessageBox.Show("Please select Month and Year to proceed.", "Missing Selection", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation)
        End If
        SavePayroll()
    End Sub

    Private Sub SavePayroll()
        Dim connection = functions.connection
        Try
            connection.Open()

            Dim month_id As Integer = cmbMonth.SelectedIndex
            Dim year_id As Integer = cmbYear.SelectedItem
            Dim selectedDate As New DateTime(year_id, month_id, 1)

            If selectedDate > DateTime.Now.AddMonths(6) Then
                MsgBox("You cannot schedule payroll more than 6 months ahead.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim checkQuery As String = "SELECT COUNT(*) FROM payroll_tab WHERE month_id = @month_id AND year_id = @year_id"
            Dim checkCmd As New MySqlCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@month_id", month_id)
            checkCmd.Parameters.AddWithValue("@year_id", year_id)
            Dim existingPayroll As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            If existingPayroll > 0 Then
                MsgBox("Payroll for this month and year has already been saved.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim payroll_id As String = "PAY" & functions.countId("PAY00")

            Dim sumQuery As String = "SELECT SUM(b.basic_salary + b.bonus + b.commission + b.transport_allowance - b.tax) AS total_payment FROM staffs_tab a, job_grade_tab b WHERE a.job_grade_id = b.job_grade_id AND a.status_id = 1"
            Dim sumCommand As New MySqlCommand(sumQuery, connection)
            Dim totalSum As Object = sumCommand.ExecuteScalar()
            Dim totalPayment As Decimal = If(IsDBNull(totalSum), 0, Convert.ToDecimal(totalSum))

            Dim insertPayroll As String = "INSERT INTO payroll_tab (payroll_id, month_id, year_id, total_payment, status_id, created_at, updated_at) VALUES (@payroll_id, @month_id, @year_id, @total_payment, @status_id, NOW(), NOW())"
            Dim cmdPayroll As New MySqlCommand(insertPayroll, connection)
            cmdPayroll.Parameters.AddWithValue("@payroll_id", payroll_id)
            cmdPayroll.Parameters.AddWithValue("@month_id", month_id)
            cmdPayroll.Parameters.AddWithValue("@year_id", year_id)
            cmdPayroll.Parameters.AddWithValue("@total_payment", totalPayment)
            cmdPayroll.Parameters.AddWithValue("@status_id", 3) ' 
            cmdPayroll.ExecuteNonQuery()

            Dim insertHistory As String = "INSERT INTO payroll_history_tab (payroll_id, staff_id, month_id, year_id, basic_salary, bonus, commission, transport_allowance, tax, net_salary, status_id, created_at, updated_at) SELECT @payroll_id, a.staff_id, @month_id, @year_id, b.basic_salary, b.bonus, b.commission, b.transport_allowance, b.tax, (b.basic_salary + b.bonus + b.commission + b.transport_allowance - b.tax), 3, NOW(), NOW() FROM staffs_tab a, job_grade_tab b WHERE a.job_grade_id = b.job_grade_id AND a.status_id = 1"
        Dim cmdHistory As New MySqlCommand(insertHistory, connection)
        cmdHistory.Parameters.AddWithValue("@payroll_id", payroll_id)
        cmdHistory.Parameters.AddWithValue("@month_id", month_id)
        cmdHistory.Parameters.AddWithValue("@year_id", year_id)
        cmdHistory.ExecuteNonQuery()

        MsgBox("Success!! Payroll has been scheduled for " & cmbMonth.Text & " " & year_id & vbCrLf &
               "Total Scheduled Payment: ₦" & totalPayment.ToString("N2"), MsgBoxStyle.Information)

        dgvPayroll.ReadOnly = True

    Catch ex As Exception
        MsgBox("Error saving payroll: " & ex.Message, MsgBoxStyle.Critical)
    Finally
        connection.Close()
        End Try
    End Sub

    Private Sub RunPayroll()
        Dim connection = functions.connection
        Try
            connection.Open()

            Dim month_id As Integer = cmbMonth.SelectedIndex
            Dim year_id As Integer = cmbYear.SelectedItem

            Dim checkQuery As String = "SELECT COUNT(*) FROM payroll_tab WHERE month_id = @month_id AND year_id = @year_id"
            Dim checkCmd As New MySqlCommand(checkQuery, connection)
            checkCmd.Parameters.AddWithValue("@month_id", month_id)
            checkCmd.Parameters.AddWithValue("@year_id", year_id)
            Dim alreadyRun As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            Dim dt As New DataTable()

            If alreadyRun > 0 Then
                Dim result As DialogResult = MessageBox.Show(
                    "Payroll already exists for this period." & vbCrLf &
                    "Do you want to OVERRIDE and generate new payroll?",
                    "Override Payroll",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    Dim deleteHistory As New MySqlCommand("DELETE FROM payroll_history_tab WHERE month_id = @month_id AND year_id = @year_id", connection)
                    deleteHistory.Parameters.AddWithValue("@month_id", month_id)
                    deleteHistory.Parameters.AddWithValue("@year_id", year_id)
                    deleteHistory.ExecuteNonQuery()

                    Dim deletePayroll As New MySqlCommand("DELETE FROM payroll_tab WHERE month_id = @month_id AND year_id = @year_id", connection)
                    deletePayroll.Parameters.AddWithValue("@month_id", month_id)
                    deletePayroll.Parameters.AddWithValue("@year_id", year_id)
                    deletePayroll.ExecuteNonQuery()

                    MsgBox("Old payroll removed. Generating new payroll...", MsgBoxStyle.Information)

                ElseIf result = DialogResult.No Then
                    Dim historyQuery As String = "SELECT h.staff_id, s.fullname, h.basic_salary, h.bonus, h.commission, h.transport_allowance, h.tax, h.net_salary, ss.status_name FROM payroll_history_tab h, staffs_tab s, setup_status_tab ss WHERE h.month_id = @month_id AND h.year_id = @year_id AND h.staff_id = s.staff_id AND h.status_id = ss.status_id"
                    Dim historyCmd As New MySqlCommand(historyQuery, connection)
                    historyCmd.Parameters.AddWithValue("@month_id", month_id)
                    historyCmd.Parameters.AddWithValue("@year_id", year_id)
                    Dim tableLoader As New MySqlDataAdapter(historyCmd)
                    tableLoader.Fill(dt)

                    Dim updateStatusCmd As New MySqlCommand("UPDATE payroll_tab SET status_id = 4, updated_at = NOW() WHERE month_id = @month_id AND year_id = @year_id", connection)
                    updateStatusCmd.Parameters.AddWithValue("@month_id", month_id)
                    updateStatusCmd.Parameters.AddWithValue("@year_id", year_id)
                    updateStatusCmd.ExecuteNonQuery()

                    Dim updateHistoryStatus As New MySqlCommand("UPDATE payroll_history_tab SET status_id = 4, updated_at = NOW() WHERE month_id = @month_id AND year_id = @year_id", connection)
                    updateHistoryStatus.Parameters.AddWithValue("@month_id", month_id)
                    updateHistoryStatus.Parameters.AddWithValue("@year_id", year_id)
                    updateHistoryStatus.ExecuteNonQuery()

                    MsgBox("This payroll was already run. Status updated to SUCCESSFUL. Showing existing records.")
                    dgvPayroll.DataSource = dt
                    dgvPayroll.Columns("status_name").HeaderText = "Status"
                    Exit Sub
                Else
                    MsgBox("Action cancelled.")
                    Exit Sub
                End If
            End If

            ' Generate fresh payroll (either first time or after override)
            Dim payrollQuery As String = "SELECT a.staff_id, a.fullname, b.basic_salary, b.job_grade_name, COALESCE(b.bonus, 0) AS bonus, COALESCE(b.commission, 0) AS commission, COALESCE(b.transport_allowance, 0) AS transport_allowance, COALESCE(b.tax, 0) AS tax, (b.basic_salary + COALESCE(b.bonus, 0) + COALESCE(b.commission, 0) + COALESCE(b.transport_allowance, 0) - COALESCE(b.tax, 0)) AS net_salary, 'Pending' AS status_name FROM staffs_tab a, job_grade_tab b WHERE(A.job_grade_id = b.job_grade_id) AND a.status_id = 1"

            Dim payrollCmd As New MySqlCommand(payrollQuery, connection)
            Dim tableLoaderNew As New MySqlDataAdapter(payrollCmd)
            tableLoaderNew.Fill(dt)

            MsgBox("Generated payroll preview for " & cmbMonth.Text & " " & year_id & ". Not yet saved.")

            dgvPayroll.DataSource = dt
            dgvPayroll.Columns("status_name").HeaderText = "Status"

            clearFunction()
            getJobGradeID()

            Dim staffCount As Integer = dgvPayroll.Rows.Count
            If dgvPayroll.AllowUserToAddRows Then staffCount -= 1

            Dim totalPayment As Decimal = 0
            For Each row As DataRow In dt.Rows
                totalPayment += Convert.ToDecimal(If(row("net_salary"), 0))
            Next
            lblTotalPayment.Text = "Total Salaries this month for (" & staffCount & " Staff): ₦" & totalPayment.ToString("N2")

        Catch ex As Exception
            MsgBox("Error generating payroll: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ClearForm()
        dgvPayroll.DataSource = Nothing
        lblTotalPayment.Text = ""
        cmbMonth.Text = "SELECT MONTH"
        cmbYear.Text = "SELECT YEAR"
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        admin_dashboard.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

End Class