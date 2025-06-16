Public Class Form1
    Dim FirstNo, SecondNo As Double

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        FirstNo = FirstNo_txt.Text
        SecondNo = SecondNo_txt.Text

        Result_txt.Text = FirstNo - SecondNo

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        FirstNo_txt.Text = ""
        SecondNo_txt.Text = ""

        Result_txt.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondNo_txt.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstNo_txt.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

End Class
