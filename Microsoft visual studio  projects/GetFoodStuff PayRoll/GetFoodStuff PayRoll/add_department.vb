Imports System.Text.RegularExpressions
Public Class add_department

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub add_department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getDeptID()
        getStatus()
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If (dept_id_combo.Text = "SELECT DEPARTMENT" OrElse dept_id_combo.Text = "") Then
            MessageBox.Show("Fields Cannot be Empty")
        Else
            FetchDepartment()
        End If
    End Sub

    Private Sub create_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_btn.Click
        Dim answer = DialogResult
        If (dept_name_txt.Text = "") Or (status_combo.Text = "SELECT STATUS") Then
            MessageBox.Show("Fields Cannot be Empty")
        Else
            If (dept_id_combo.Text = "SELECT DEPARTMENT") Then
                answer = MessageBox.Show("Are you sure you want to save?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (answer = DialogResult.Yes) Then
                    If DeptCheck(dept_name_txt.Text) Then
                        MessageBox.Show("Department already exists by name!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        functions.RegisterDept()
                    End If
                End If
            Else
                answer = MessageBox.Show("Are you sure you want to update?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = DialogResult.Yes Then
                    If UpdateDeptCheck(dept_name_txt.Text) Then
                        MessageBox.Show("Department already exists by name!", "GetFoodStuff System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        functions.UpdateDepartment()
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Hide()
        overlay.Show()
        admin_dashboard.Show()
    End Sub

    Private Sub dept_id_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dept_id_combo.SelectedIndexChanged
        clearFunction2()
    End Sub
End Class