Public Class Form1
    Dim firstno, secondo, result As Integer

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        If String.IsNullOrWhiteSpace(Firstno_txt.Text) OrElse
            String.IsNullOrWhiteSpace(Firstno_txt.Text) Then
            MessageBox.Show("Please enter a valid Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Firstno_txt.Focus()
            Return
        End If
        If Not Integer.TryParse(Firstno_txt.Text, firstno) Then
            MessageBox.Show("Please enter a valid Integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Firstno_txt.Focus()
            Return
        End If
        If Not Integer.TryParse(Secondno_txt.Text, secondo) Then
            MessageBox.Show("Please enter a valid Integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Secondno_txt.Focus()
            Return
            If secondo = 0 Then
                MessageBox.Show("Please enter a valid Integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        result = firstno Mod secondo

        results.Text = ("The modulus of " & firstno.ToString() & " % " & secondo.ToString() & ", is: " & result.ToString())
    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        Firstno_txt.Clear()
        Secondno_txt.Clear()
        results.Clear()
        Firstno_txt.Focus()

    End Sub

    Private Sub Firstno_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Secondno_txt.KeyPress, Firstno_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If CType(sender, TextBox).TextLength >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
