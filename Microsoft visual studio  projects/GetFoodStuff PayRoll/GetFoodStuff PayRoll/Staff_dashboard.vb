Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Staff_dashboard

    Private Sub refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_btn.Click

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt")
    End Sub

    Private Sub Staff_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        staffdashDetails()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub btnMySchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMySchedule.Click
        Me.Hide()
        overlay.Show()
        staff_db_schedules.Show()
    End Sub

    Private Sub btnAnnouncements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnouncements.Click
        Me.Hide()
        overlay.Show()
        staff_db_announcements.Show()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Me.Hide()
        overlay.Show()
        staff_db_reports.Show()
    End Sub

    Private Sub btnStaff_payments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaff_payments.Click
        Me.Hide()
        overlay.Show()
        staffs_payroll_form.Show()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim response As DialogResult
        response = MessageBox.Show("Are you sure you want to log out?.", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Me.Hide()
            staff_login_form.Show()
        End If
    End Sub
End Class