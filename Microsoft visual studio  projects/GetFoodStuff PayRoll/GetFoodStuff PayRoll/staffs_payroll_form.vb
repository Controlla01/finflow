Public Class staffs_payroll_form

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub

    Private Sub staffs_payroll_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fetchStaffrenumeration2()
    End Sub

    Private Sub Guna2Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button6.Click
        Me.Close()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub

    Private Sub basic_salary_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles basic_salary_txt.TextChanged

    End Sub
End Class