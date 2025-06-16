Public Class Form1
    Dim firstno, secondno, result As Double


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        If firstno_txt.Text = "" And secondno_txt.Text = "" Then
            MsgBox("All fileds are required")
        Else
            firstno = firstno_txt.Text
            secondno = secondno_txt.Text

            results_txt.Text = firstno / secondno
        End If

    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        firstno_txt.Text = ""
        secondno_txt.Text = ""

        results_txt.Text = ""
    End Sub
End Class
