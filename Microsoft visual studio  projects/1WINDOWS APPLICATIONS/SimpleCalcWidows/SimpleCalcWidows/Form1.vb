Public Class Form1

    Dim firstno, secondno As Double
    Dim operators As String

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        firstno_txt.Text = ""
        secondno_txt.Text = ""
        result_txt.Text = ""
        operator_label.Text = ""
    End Sub

    Private Sub summation_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles summation_btn.Click
        operators = "+"
        operator_label.Text = "+"
    End Sub

    Private Sub difference_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles difference_btn.Click
        operators = "-"
        operator_label.Text = "-"
    End Sub

    Private Sub product_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles product_btn.Click
        operators = "*"
        operator_label.Text = "x"
    End Sub

    Private Sub fraction_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraction_btn.Click
        operators = "/"
        operator_label.Text = "/"
    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        If secondno_txt.Text = "" Or firstno_txt.Text = "" Then
            MsgBox("Please fill the empty spaces.")

        ElseIf operator_label.Text = "" Then
            MsgBox("Kindly select an operator")
        Else
            firstno = firstno_txt.Text
            secondno = secondno_txt.Text
            If operators = "+" Then
                result_txt.Text = firstno + secondno
            ElseIf operators = "-" Then
                result_txt.Text = firstno - secondno
            ElseIf operators = "*" Then
                result_txt.Text = firstno * secondno
            ElseIf operators = "/" Then
                If secondno = 0 Then
                    MsgBox("Cannot divide by zero, Apply.")
                Else
                    result_txt.Text = firstno / secondno
                End If
            End If

            End If
    End Sub

    Private Sub firstno_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles firstno_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "-" Then
                If firstno_txt.SelectionStart <> 0 OrElse firstno_txt.Text.Contains("-") Then
                    e.Handled = True
                    MsgBox("Incorrect Digit.")
                End If
            ElseIf e.KeyChar = "." Then
                If firstno_txt.Text.Contains(".") Then
                    e.Handled = True
                    MsgBox("Incorrect Digit.")
                End If
            Else
                e.Handled = True
                MsgBox("Incorrect Digit.")
            End If
        End If
    End Sub

    Private Sub secondno_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles secondno_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            If e.KeyChar = "_" Then
                If secondno_txt.SelectionStart <> 0 OrElse secondno_txt.Text.Contains("-") Then
                    e.Handled = True
                    MsgBox("Incorrect Digit.")
                End If
            ElseIf e.KeyChar = "." Then
                If secondno_txt.Text.Contains(".") Then
                    e.Handled = True
                    MsgBox("Incorrect Digit.")
                End If
            Else
                e.Handled = True
                MsgBox("Incorrect Digit.")
            End If
        End If
    End Sub


End Class