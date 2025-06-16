Public Class records

    Private Sub recordsview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles recordsview.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    
    Private Sub records_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getUserIds()
        GetRecordCount()
        FetchUserData()
    End Sub
End Class