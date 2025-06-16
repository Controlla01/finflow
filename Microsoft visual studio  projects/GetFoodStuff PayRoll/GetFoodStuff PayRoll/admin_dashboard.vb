Imports MySql.Data.MySqlClient
Imports System.IO
Public Class admin_dashboard

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_branch_btn.Click
        Me.Hide()
        overlay.Show()
        add_branch_form.Show()
    End Sub

    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_department_btn.Click
        Me.Hide()
        overlay.Show()
        add_department.Show()
    End Sub

    Private Sub add_staff_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_staff_btn.Click
        Me.Hide()
        overlay.Show()
        register_staff_form.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        dashDetails()

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Me.Close()
        overlay.Show()
        login_form.Show()
    End Sub

    Private Sub view_staff_payment_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_staff_payment_btn.Click
        Me.Hide()
        overlay.Show()
        view_staff_payment_form.Show()
    End Sub

    Private Sub salary_updates_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salary_updates_btn.Click
        Me.Hide()
        overlay.Show()
        view_staff_records.Show()
    End Sub

    Private Sub view_payrollbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_payrollbtn.Click
        Me.Hide()
        overlay.Show()
        payroll_gangan.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        overlay.Show()
        job_grade1.Show()
    End Sub

End Class