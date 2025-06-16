Imports MySql.Data.MySqlClient
Imports System.IO
Public Class view_staff_records

    Private Sub view_staff_records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewAllStaffRecords()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Show()
        admin_dashboard.Show()
    End Sub
End Class