Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class job_grade1

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit_btn.Click
        If (job_grade_name_txt.Text = "") Then
            MessageBox.Show("Provide job grade to continue")
        ElseIf (basic_salary_txt.Text.Trim() = "") Then
            MessageBox.Show("Provide basic salary to continue")
        ElseIf (tax_txt.Text = "") Then
            MessageBox.Show("Provide tax percentage to continue")
        ElseIf (cmbJobGrade.Text = "SELECT JOB GRADE") Then
            If jobgradeCheck(job_grade_name_txt.Text) Then
                MessageBox.Show("Job grade already exist by name")
                clearFunction()
            Else
                RegisterJobgrade()
                getJobGradeID()
            End If
        Else
            If UpdateJobGradeCheck(job_grade_name_txt.Text) Then
                MessageBox.Show("Job grade already exist")
            Else
                UpdateJobGrade()
            End If
        End If
    End Sub

    Private Sub calculatetotal()

        Dim basic_salary As Decimal = Val(basic_salary_txt.Text)
        Dim bonus As Decimal = Val(bonus_txt.Text)
        Dim commission As Decimal = Val(commission_txt.Text)
        Dim allowance As Decimal = Val(allowance_txt.Text)
        Dim tax As Decimal = Val(tax_txt.Text)
        Dim tax_percent As Decimal = (tax / 100) * basic_salary
        Dim total As Decimal = (basic_salary + bonus + commission + allowance) - tax_percent
        net_salary.Text = total.ToString("N2")
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (cmbJobGrade.Text = "SELECT JOB GRADE") Then
            MessageBox.Show("Select a Staff to Job Grade")
        Else
            FetchJobGrade()
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub job_grade1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getJobGradeID()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Hide()
        admin_dashboard.Show()
    End Sub

    Private Sub basic_salary_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles basic_salary_txt.TextChanged
        calculatetotal()
    End Sub

    Private Sub allowance_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allowance_txt.TextChanged
        calculatetotal()
    End Sub

    Private Sub bonus_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bonus_txt.TextChanged
        calculatetotal()
    End Sub

    Private Sub commission_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles commission_txt.TextChanged
        calculatetotal()
    End Sub
End Class