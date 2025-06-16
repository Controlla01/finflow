Public Class Form1
    Dim FirstNo, SecondNo As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate_btn.Click
        FirstNo = FirstNo_txt.Text
        SecondNo = SecondNo_txt.Text

        Result_txt.Text = FirstNo + SecondNo
    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        FirstNo_txt.Text = ""
        SecondNo_txt.Text = ""

        Result_txt.Text = ""
    End Sub
End Class
