Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class staff_salary_update

    Public Sub LoadJobLevels()
        Try
            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "SELECT job_grade_id, job_grade_name FROM job_grade_tab;"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            job_level_combo.DataSource = table
            job_level_combo.DisplayMember = "job_grade_name"
            job_level_combo.ValueMember = "job_grade_id"

            connection.Close()
        Catch ex As Exception
            MsgBox("Error loading job levels: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub job_level_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles job_level_combo.SelectedIndexChanged
        Try
            Dim selectedJobGrade As String = job_level_combo.SelectedValue.ToString()
            MsgBox("Selected Job Grade: " & selectedJobGrade)
            Dim connection As New MySqlConnection(functions.connection.ToString)
            connection.Open()

            Dim query As String = "SELECT s.staff_id, s.fullname, s.job_grade_id, j.basic_salary, j.job_grade_name FROM staffs_tab s JOIN job_grade_tab j ON s.job_grade_id = j.job_grade_id WHERE s.job_grade_id = @jobGradeId"

            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@jobGrade", selectedJobGrade)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvBulkSalary.DataSource = dt

            If dt.Rows.Count > 0 Then
                dgvBulkSalary.DataSource = dt
            Else
                MsgBox("No staff found for this job level!", vbExclamation, "No Data")
                dgvBulkSalary.DataSource = Nothing
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox("Error loading staff records: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub staff_salary_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadJobLevels()
        dgvBulkSalary.DataSource = Nothing
        dgvBulkSalary.Rows.Clear()
    End Sub
End Class