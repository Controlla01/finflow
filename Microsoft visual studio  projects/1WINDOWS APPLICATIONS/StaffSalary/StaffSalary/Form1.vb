Public Class Form1
    Dim percentage As Double
    Private Sub salary_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salary_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "-" Then
                If salary_txt.SelectionStart <> 0 OrElse salary_txt.Text.Contains("-") Then
                    e.Handled = True
                End If
            ElseIf e.KeyChar = "." Then
                If salary_txt.Text.Contains(".") Then
                    e.Handled = True
                End If
            Else
                e.Handled = True
                MsgBox("Wrong Input")
            End If
        End If
    End Sub

    Private Sub percentage_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles percentage_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "-" Then
                If percentage_txt.SelectionStart <> 0 OrElse percentage_txt.Text.Contains("-") Then
                    e.Handled = True
                End If
            ElseIf e.KeyChar = "." Then
                If percentage_txt.Text.Contains(".") Then
                    e.Handled = True
                End If
            Else
                e.Handled = True
                MsgBox("Wrong Input")
            End If
        End If
    End Sub

    Private Sub calculate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_btn.Click
        If salary_txt.Text = "" Or percentage_txt.Text = "" Then
            MsgBox("Fill the Empty space")
        ElseIf percentage_txt.Text > 100 Or percentage_txt.Text < 1 Then
            MsgBox("Percentage must be less than 100")
        Else
            percentage = percentage_txt.Text / 100

            deducted_txt.Text = salary_txt.Text * percentage

            balance_txt.Text = salary_txt.Text - deducted_txt.Text
        End If
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        salary_txt.Text = ""
        percentage_txt.Text = ""
        deducted_txt.Text = ""
        balance_txt.Text = ""
    End Sub
End Class
