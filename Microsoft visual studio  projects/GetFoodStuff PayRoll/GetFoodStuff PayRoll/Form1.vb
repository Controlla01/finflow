Imports MySql.Data.MySqlClient
Public Class home_page

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub min_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min_btn.Click
    End Sub

    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        overlay.Show()
        register_staff_form.Show()
    End Sub

    Private Sub admin_login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_btn.Click
        overlay.Show()
        login_form.Show()
        admin_login_btn.Hide()
        user_login_btn.Hide()

    End Sub

    Private Sub home_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Me.Show()
        admin_login_btn.Show()
        user_login_btn.Show()
    End Sub

    Private Sub user_login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_login_btn.Click
        overlay.Show()
        staff_login_form.Show()
        admin_login_btn.Hide()
        user_login_btn.Hide()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2GradientPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class
