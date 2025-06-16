Public Class Form1
    Private Sub btnUnitConverter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnitConverter.Click
        Dim convert As Double

        Try
            If Not Double.TryParse(TextBox1.Text, convert) Then
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Focus()
                Return
            End If

            Select Case cmbUnit.Text
                Case "Celsius to Fahrenheit"
                    convert = (9 / 5) * Double.Parse(TextBox1.Text) + 32
                    TextBox2.Text = convert.ToString("F2") & " Fahrenheit"
                Case "Fahrenheit to Celsius"
                    convert = (Double.Parse(TextBox1.Text) - 32) * 5 / 9
                    TextBox2.Text = convert.ToString("F2") & " Celsius"
                Case "Miles to Kilometres"
                    convert = Double.Parse(TextBox1.Text) * 1.60934
                    TextBox2.Text = convert.ToString("F2") & " Kilometres"
                Case "Kilometres to Miles"
                    convert = Double.Parse(TextBox1.Text) / 1.60934
                    TextBox2.Text = convert.ToString("F2") & " Miles"
                Case "Centimeters to Meters"
                    convert = Double.Parse(TextBox1.Text) / 100
                    TextBox2.Text = convert.ToString("F2") & " Meters"
                Case Else
                    MessageBox.Show("Please select a valid conversion type from the dropdown.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select

        Catch ex As Exception
            MessageBox.Show("An error occurred during the conversion: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbUnit.Items.Clear()
        cmbUnit.Items.Add("Celsius to Fahrenheit")
        cmbUnit.Items.Add("Fahrenheit to Celsius")
        cmbUnit.Items.Add("Miles to Kilometres")
        cmbUnit.Items.Add("Kilometres to Miles")
        cmbUnit.Items.Add("Centimeters to Meters")
        cmbUnit.Text = "Choose One"
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbUnit.Text = "Choose One"
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
    End Sub
End Class