Public Class Form1
    Dim gp_sdt101 As Double
    Dim gp_mad102 As Double
    Dim gp_sda103 As Double
    Dim gp_wad104 As Double
    Dim gp_ns105 As Double
    Dim gp_agd106 As Double
    Dim totalGradePoints As Double
    Dim totalCourseUnits As Double = 25
    Dim gpa As Double

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click

        If String.IsNullOrWhiteSpace(SDT101score.Text) OrElse _
           String.IsNullOrWhiteSpace(MAD102acore.Text) OrElse _
           String.IsNullOrWhiteSpace(SDA103score.Text) OrElse _
           String.IsNullOrWhiteSpace(WAD104score.Text) OrElse _
           String.IsNullOrWhiteSpace(TextBoxgagaa.Text) OrElse _
           String.IsNullOrWhiteSpace(AGD106score.Text) Then
            MessageBox.Show("Please enter scores for all subjects.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If Not Double.TryParse(SDT101score.Text, gp_sdt101) OrElse gp_sdt101 < 0 OrElse gp_sdt101 > 100 Then

            SDT101score.Focus()
            Return
        End If
        If Not Double.TryParse(MAD102acore.Text, gp_mad102) OrElse gp_mad102 < 0 OrElse gp_mad102 > 100 Then
            MessageBox.Show("Invalid Input!s ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MAD102acore.Focus()
            Return
        End If
        If Not Double.TryParse(SDA103score.Text, gp_sda103) OrElse gp_sda103 < 0 OrElse gp_sda103 > 100 Then
            MessageBox.Show("Invalid Input!x ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SDA103score.Focus()
            Return
        End If
        If Not Double.TryParse(WAD104score.Text, gp_wad104) OrElse gp_wad104 < 0 OrElse gp_wad104 > 100 Then
            MessageBox.Show("Invalid Input!c ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            WAD104score.Focus()
            Return
        End If
        If Not Double.TryParse(TextBoxgagaa.Text, gp_ns105) OrElse gp_ns105 < 0 OrElse gp_ns105 > 100 Then
            MessageBox.Show("Invalid Input!v ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxgagaa.Focus()
            Return
        End If
        If Not Double.TryParse(AGD106score.Text, gp_agd106) OrElse gp_agd106 < 0 OrElse gp_agd106 > 100 Then
            MessageBox.Show("Invalid Input!a ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AGD106score.Focus()
            Return
        End If

        gp_sdt101 = CalculateGradePoints(gp_sdt101, 4)
        gp_mad102 = CalculateGradePoints(gp_mad102, 4)
        gp_sda103 = CalculateGradePoints(gp_sda103, 5)
        gp_wad104 = CalculateGradePoints(gp_wad104, 4)
        gp_ns105 = CalculateGradePoints(gp_ns105, 4)
        gp_agd106 = CalculateGradePoints(gp_agd106, 4)

        totalGradePoints = gp_sdt101 + gp_mad102 + gp_sda103 + gp_wad104 + gp_ns105 + gp_agd106
        gpa = totalGradePoints / totalCourseUnits

        totalGradePoints = gp_sdt101 + gp_mad102 + gp_sda103 + gp_wad104 + gp_ns105 + gp_agd106
        gpa = totalGradePoints / totalCourseUnits

        TotalGP_txt.Text = "Total Grade Points: " & totalGradePoints
        TotalGpaa_txt.Text = "Grade Point Average: " & gpa
        GradeClassification_txt.Text = "Grade Classification: " & GetGradeClassification()
        TotalCourseUit_txt.Text = "Total CourseUnits: " & totalCourseUnits
    End Sub

    Private Function CalculateGradePoints(ByVal score As Double, ByVal courseUnit As Double) As Double
        Dim gradePoint As Double

        If score >= 80 Then
            gradePoint = 4.0
        ElseIf score >= 70 Then
            gradePoint = 3.5
        ElseIf score >= 60 Then
            gradePoint = 3.0
        ElseIf score >= 50 Then
            gradePoint = 2.5
        ElseIf score >= 40 Then
            gradePoint = 2.0
        Else
            gradePoint = 0
        End If
        Return gradePoint * courseUnit
    End Function

    Private Function GetGradeClassification() As String
        If gpa >= 3.5 Then
            Return "DISTINCTION"
        ElseIf gpa >= 3.0 Then
            Return "UPPER CREDIT"
        ElseIf gpa >= 2.5 Then
            Return "LOWER CREDIT"
        ElseIf gpa >= 2.0 Then
            Return "PASS"
        Else
            Return "FAIL"
        End If
    End Function

    Private Sub Clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_txt.Click
        SDT101score.Text = ""
        MAD102acore.Text = ""
        SDA103score.Text = ""
        WAD104score.Text = ""
        TextBoxgagaa.Text = ""
        AGD106score.Text = ""
        TotalGP_txt.Text = ""
        TotalGpaa_txt.Text = ""
        GradeClassification_txt.Text = ""
    End Sub

    Private Sub SDT101_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WAD104_txt.KeyPress, TextBox5.KeyPress, SDT101_txt.KeyPress, SDA103_txt.KeyPress, MAD102_txt.KeyPress, AGD106_txt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Invalid Input!Q ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If CType(sender, TextBox).TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid Input!1 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class