Public Class staff_db_reports
    Dim reportFile As String = "reports.txt"


    Private Sub staff_db_reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    ' Save reports to file
    Private Sub SaveReports()
        Dim reports As New List(Of String)
        For Each item As String In ListBoxReports.Items
            reports.Add(item)
        Next
        System.IO.File.WriteAllLines(reportFile, reports)
    End Sub

    ' Load reports from file or create a new one if it doesn't exist
    Private Sub LoadReports()
        If Not System.IO.File.Exists(reportFile) Then
            Dim defaultReports As String() = {
                "Monthly Sales Report - March 2025",
                "Employee Attendance Report - Q1 2025",
                "Customer Feedback Summary - April 2025",
                "Inventory Stock Analysis - April 2025",
                "Project Completion Report - March 2025",
                "Financial Budget Report - 2025 Year-End",
                "Weekly Task Summary - Week 12",
                "Safety Compliance Report - March 2025",
                "Marketing Performance Report - Q1 2025",
                "HR Recruitment Report - March 2025"
            }
            System.IO.File.WriteAllLines(reportFile, defaultReports)
        End If

        ListBoxReports.Items.Clear()
        Dim reports() As String = System.IO.File.ReadAllLines(reportFile)
        ListBoxReports.Items.AddRange(reports)
    End Sub

    Private Sub Guna2Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If ListBoxReports.SelectedIndex <> -1 Then
            Dim updatedReport As String = InputBox("Edit report:", "Edit Report", ListBoxReports.SelectedItem.ToString())
            If updatedReport.Trim() <> "" Then
                ListBoxReports.Items(ListBoxReports.SelectedIndex) = updatedReport
                SaveReports() ' Save changes
            End If
        Else
            MessageBox.Show("Please select a report to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim newReport As String = InputBox("Enter a new report:", "Add Report")
        If newReport.Trim() <> "" Then
            ListBoxReports.Items.Add(newReport)
            SaveReports() ' Save changes
        End If
    End Sub

    Private Sub Btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_del.Click
        If ListBoxReports.SelectedIndex <> -1 Then
            ListBoxReports.Items.RemoveAt(ListBoxReports.SelectedIndex)
            SaveReports() ' Save changes
        Else
            MessageBox.Show("Please select a report to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub
End Class