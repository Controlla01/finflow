Public Class staff_db_schedules
        ' File path for saving and loading schedules
        Dim scheduleFile As String = "schedules.txt"

        Private Sub btnSaveSchedule_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveSchedule.Click
            SaveSchedules()
            MessageBox.Show("Schedules saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

    ' Load schedules from file or create a new one if it doesn't exist
    Private Sub LoadSchedules()
        If Not System.IO.File.Exists(scheduleFile) Then
            ' Default schedules for Monday to Friday
            Dim defaultSchedules As String() = {
                "Monday - Morning Shift: 8:00 AM - 12:00 PM",
                "Monday - Afternoon Shift: 1:00 PM - 5:00 PM",
                "Monday - Evening Shift: 6:00 PM - 10:00 PM",
                "Tuesday - Morning Shift: 8:00 AM - 12:00 PM",
                "Tuesday - Afternoon Shift: 1:00 PM - 5:00 PM",
                "Tuesday - Evening Shift: 6:00 PM - 10:00 PM",
                "Wednesday - Morning Shift: 8:00 AM - 12:00 PM",
                "Wednesday - Afternoon Shift: 1:00 PM - 5:00 PM",
                "Wednesday - Evening Shift: 6:00 PM - 10:00 PM",
                "Thursday - Morning Shift: 8:00 AM - 12:00 PM",
                "Thursday - Afternoon Shift: 1:00 PM - 5:00 PM",
                "Thursday - Evening Shift: 6:00 PM - 10:00 PM",
                "Friday - Morning Shift: 8:00 AM - 12:00 PM",
                "Friday - Afternoon Shift: 1:00 PM - 5:00 PM",
                "Friday - Evening Shift: 6:00 PM - 10:00 PM"
            }

            ' Save default schedules to file
            System.IO.File.WriteAllLines(scheduleFile, defaultSchedules)
        End If

        ' Read and display schedules in the ListBox
        ListBox1schedule.Items.Clear()
        Dim schedules() As String = System.IO.File.ReadAllLines(scheduleFile)
        ListBox1schedule.Items.AddRange(schedules)
    End Sub

        ' Save schedules to file
        Private Sub SaveSchedules()
            Dim schedules As New List(Of String)
        For Each item As String In ListBox1schedule.Items
            schedules.Add(item)
        Next
            System.IO.File.WriteAllLines(scheduleFile, schedules)
        End Sub

    Private Sub Guna2Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub

    Private Sub BtnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSort.Click
        Dim items As List(Of String) = ListBox1schedule.Items.Cast(Of String).ToList()
        items.Sort()
        ListBox1schedule.Items.Clear()
        For Each item In items
            ListBox1schedule.Items.Add(item)
        Next
        SaveSchedules() ' Save changes
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If ListBox1schedule.SelectedIndex <> -1 Then
            Dim updatedSchedule As String = InputBox("Edit schedule:", "Edit Schedule", ListBox1schedule.SelectedItem.ToString())
            If updatedSchedule.Trim() <> "" Then
                ListBox1schedule.Items(ListBox1schedule.SelectedIndex) = updatedSchedule
                SaveSchedules() ' Save changes
            End If
        Else
            MessageBox.Show("Please select a schedule to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim newSchedule As String = InputBox("Enter a new schedule:", "Add Schedule")
        If newSchedule.Trim() <> "" Then
            ListBox1schedule.Items.Add(newSchedule)
            SaveSchedules() ' Save changes
        End If
    End Sub

    Private Sub Btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_del.Click
        If ListBox1schedule.SelectedIndex <> -1 Then
            ListBox1schedule.Items.RemoveAt(ListBox1schedule.SelectedIndex)
            SaveSchedules() ' Save changes
        Else
            MessageBox.Show("Please select a schedule to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub staff_db_schedules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1schedule.Items.Add("Morning Staff Briefing - 8:00 AM")
        ListBox1schedule.Items.Add("Inventory Check - 10:00 AM")
        ListBox1schedule.Items.Add("Lunch Break - 1:00 PM")
        ListBox1schedule.Items.Add("Customer Service Training - 3:00 PM")
        ListBox1schedule.Items.Add("Stock Replenishment - 5:00 PM")
        ListBox1schedule.Items.Add("Closing Procedures - 8:00 PM")
        LoadSchedules()
    End Sub
End Class