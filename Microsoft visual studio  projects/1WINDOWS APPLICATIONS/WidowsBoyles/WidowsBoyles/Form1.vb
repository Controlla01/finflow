Public Class Form1

    Private Sub ShowInputError()
        MsgBox("Abeg fill all input fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub p1_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1_radio.CheckedChanged
        If (p1_radio.Checked = True) Then
            p1_txt.Enabled = False
            p1_txt.Text = "?"
        Else
            p1_txt.Enabled = True
            p1_txt.Text = ""
        End If
    End Sub

    Private Sub v1_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v1_radio.CheckedChanged
        If (v1_radio.Checked = True) Then
            v1_txt.Enabled = False
            v1_txt.Text = "?"
        Else
            v1_txt.Enabled = True
            v1_txt.Text = ""
        End If
    End Sub

    Private Sub p2_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2_radio.CheckedChanged
        If (p2_radio.Checked = True) Then
            p2_txt.Enabled = False
            p2_txt.Text = "?"
        Else
            p2_txt.Enabled = True
            p2_txt.Text = ""
        End If
    End Sub

    Private Sub v2_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v2_radio.CheckedChanged
        If (v2_radio.Checked = True) Then
            v2_txt.Enabled = False
            v2_txt.Text = "?"
        Else
            v2_txt.Enabled = True
            v2_txt.Text = ""
        End If
    End Sub

    Private Sub NumericTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v2_txt.KeyPress, v1_txt.KeyPress, p2_txt.KeyPress, p1_txt.KeyPress
        Dim Textbox As TextBox = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            Return
        ElseIf e.KeyChar = "."c Then
            If Textbox.Text.Contains(".") Then
                e.Handled = True
            End If
            Return
        ElseIf Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Dim p1, p2, v1, v2, result As Double

        Double.TryParse(p1_txt.Text, p1)
        Double.TryParse(v1_txt.Text, v1)
        Double.TryParse(p2_txt.Text, p2)
        Double.TryParse(v2_txt.Text, v2)

        Select Case True
            Case p1_radio.Checked
                result = (v2 * p2) / v1
                result = Math.Round(result, 2)
                result_txt.Text = "P1 = " & result & " ka"
            Case v1_radio.Checked
                result = (v2 * p2) / p1
                result = Math.Round(result, 2)
                result_txt.Text = "V1 = " & result & " ka"
            Case p2_radio.Checked
                result = (v1 * p1) / v2
                result = Math.Round(result, 2)
                result_txt.Text = "P2 = " & result & " ka"
            Case v2_radio.Checked
                result = (v1 * p1) / p2
                result = Math.Round(result, 2)
                result_txt.Text = "V2 = " & result & " ka"
        End Select

    End Sub

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        p1_txt.Text = ""
        v1_txt.Text = ""
        p2_txt.Text = ""
        v2_txt.Text = ""
        result_txt.Text = ""
    End Sub

    Private Sub result_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result_txt.Click

    End Sub
End Class
