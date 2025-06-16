Public Class Form1
    Dim input, product As Integer
    Dim factorial As Integer = 1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click

        If String.IsNullOrWhiteSpace(fac_txt.Text) Then
            MessageBox.Show("Please enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            fac_txt.Focus()
            Return
        End If

        If Not Integer.TryParse(fac_txt.Text, input) OrElse input < 1 OrElse input > 11 Then
            MessageBox.Show("Invalid Number! Can't accept digits more than eleven(11) nor less than one(1). ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        For i As Integer = 1 To input
            product = factorial
            factorial *= i
            ListBoxResults.Items.Add(i.ToString() & " x " & product.ToString() & " = " & factorial.ToString())
        Next
        ListBoxResults.Items.Add("Factorial of " & input.ToString() & " (" & input.ToString() & "!) = " & factorial.ToString())
    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        fac_txt.Text = ""
        ListBoxResults.Items.Clear()
        fac_txt.Focus()
    End Sub

    Private Sub fac_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fac_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If CType(sender, TextBox).TextLength >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fac_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fac_txt.TextChanged

    End Sub

    Private Sub ListBoxResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxResults.SelectedIndexChanged

    End Sub
End Class
