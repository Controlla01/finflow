Public Class staff_db_announcements
    Dim announcementFile As String = "announcements.txt"

    Private Sub staff_db_announcements_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAnnouncements()
    End Sub

    ' Save announcements to file
    Private Sub SaveAnnouncements()
        Dim announcements As New List(Of String)
        For Each item As String In ListBoxAnnouncements.Items
            announcements.Add(item)
        Next
        System.IO.File.WriteAllLines(announcementFile, announcements)
    End Sub

    ' Load announcements from file or create a new one if it doesn't exist
    Private Sub LoadAnnouncements()
        If Not System.IO.File.Exists(announcementFile) Then
            Dim defaultAnnouncements As String() = {
                "Welcome to the team!",
                "System maintenance scheduled for Friday at 10 PM.",
                "Company holiday on April 15th.",
                "New employee orientation on Monday at 9 AM.",
                "Quarterly performance review next Thursday.",
                "Team-building event on Saturday at 2 PM.",
                "Payday is on the 30th of this month.",
                "Annual meeting scheduled for May 5th.",
                "Customer appreciation week starts next Monday.",
                "Security upgrade happening this weekend."
            }
            System.IO.File.WriteAllLines(announcementFile, defaultAnnouncements)
        End If

        ListBoxAnnouncements.Items.Clear()
        Dim announcements() As String = System.IO.File.ReadAllLines(announcementFile)
        ListBoxAnnouncements.Items.AddRange(announcements)
    End Sub
   
    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim newAnnouncement As String = InputBox("Enter a new announcement:", "Add Announcement")
        If newAnnouncement.Trim() <> "" Then
            ListBoxAnnouncements.Items.Add(newAnnouncement)
            SaveAnnouncements() ' Save changes
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If ListBoxAnnouncements.SelectedIndex <> -1 Then
            Dim updatedAnnouncement As String = InputBox("Edit announcement:", "Edit Announcement", ListBoxAnnouncements.SelectedItem.ToString())
            If updatedAnnouncement.Trim() <> "" Then
                ListBoxAnnouncements.Items(ListBoxAnnouncements.SelectedIndex) = updatedAnnouncement
                SaveAnnouncements() ' Save changes
            End If
        Else
            MessageBox.Show("Please select an announcement to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_del.Click
        If ListBoxAnnouncements.SelectedIndex <> -1 Then
            ListBoxAnnouncements.Items.RemoveAt(ListBoxAnnouncements.SelectedIndex)
            SaveAnnouncements() ' Save changes
        Else
            MessageBox.Show("Please select an announcement to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button6.Click
        Me.Hide()
        overlay.Show()
        Staff_dashboard.Show()
    End Sub
End Class