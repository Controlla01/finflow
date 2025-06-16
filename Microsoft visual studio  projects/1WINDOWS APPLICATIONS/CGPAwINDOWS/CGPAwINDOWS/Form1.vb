Public Class Form1


    ' Variables for GPA calculations
        Dim gp_sdt101, gp_mad102, gp_sda103, gp_wad104, gp_ns105, gp_agd106 As Double
        Dim totalGradePointsFirst As Double
        Dim totalCourseUnitsFirst As Double = 25
        Dim gpaFirst As Double

        Dim gp_dbms201, gp_uiux202, gp_ai204, gp_sqt205, gp_aa206, gp_devop207 As Double
        Dim totalGradePointsSecond As Double
        Dim totalCourseUnitsSecond As Double = 24
        Dim gpaSecond As Double

        Dim cgpa As Double

        ' First Semester GPA Calculation
        Private Sub calcFirst_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calcFirst_btn.Click
            If Not ValidateInputsFirst() Then Return

            ' Calculate Grade Points for First Semester
        gp_sdt101 = CalculateGradePoints(Convert.ToDouble(SDT101_txt.Text), 4)
        gp_mad102 = CalculateGradePoints(Convert.ToDouble(MAD102_txt.Text), 4)
        gp_sda103 = CalculateGradePoints(Convert.ToDouble(SDA103_txt.Text), 5)
        gp_wad104 = CalculateGradePoints(Convert.ToDouble(WAD104_txt.Text), 4)
        gp_ns105 = CalculateGradePoints(Convert.ToDouble(NS105_txt.Text), 4)
        gp_agd106 = CalculateGradePoints(Convert.ToDouble(AGD106_txt.Text), 4)

        totalGradePointsFirst = gp_sdt101 + gp_mad102 + gp_sda103 + gp_wad104 + gp_ns105 + gp_agd106
        gpaFirst = totalGradePointsFirst / totalCourseUnitsFirst

        txtCourseUnitsFirst.Text = "Total Course Units: " & totalCourseUnitsFirst.ToString("F2")
        TotalGPFirst_txt.Text = "Total Grade Points: " & totalGradePointsFirst.ToString("F2")
        GPAFirst_txt.Text = "Grade Point Average: " & gpaFirst.ToString("F2")
        GradeClassFirst_txt.Text = "Grade Classification: " & GetGradeClassification(gpaFirst)
    End Sub

    ' Second Semester GPA Calculation
    Private Sub calcSecond_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calcSecond_btn.Click
        If Not ValidateInputsSecond() Then Return

        ' Calculate Grade Points for Second Semester
        gp_dbms201 = CalculateGradePoints(Convert.ToDouble(DBMS201_txt.Text), 5)
        gp_uiux202 = CalculateGradePoints(Convert.ToDouble(UIUX202_txt.Text), 3)
        gp_ai204 = CalculateGradePoints(Convert.ToDouble(AI204_txt.Text), 5)
        gp_sqt205 = CalculateGradePoints(Convert.ToDouble(SQT205_txt.Text), 3)
        gp_aa206 = CalculateGradePoints(Convert.ToDouble(AA206_txt.Text), 4)
        gp_devop207 = CalculateGradePoints(Convert.ToDouble(DevOp207_txt.Text), 4)

        totalGradePointsSecond = gp_dbms201 + gp_uiux202 + gp_ai204 + gp_sqt205 + gp_aa206 + gp_devop207
        gpaSecond = totalGradePointsSecond / totalCourseUnitsSecond

        txtTotalCourseUnits2.Text = "Total Course Units: " & totalCourseUnitsSecond.ToString("F2")
        TotalGPSecond_txt.Text = "Total Grade Points: " & totalGradePointsSecond.ToString("F2")
        Guna2TextBox1.Text = "Grade Point Average: " & gpaSecond.ToString("F2")
        GradeClassSecond_txt.Text = "Grade Classification: " & GetGradeClassification(gpaSecond)
    End Sub

    ' CGPA Calculation
    Private Sub calcCGPA_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calcCGPA_btn.Click
        If gpaFirst = 0 Or gpaSecond = 0 Then
            MessageBox.Show("Please calculate both semester GPAs first.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        cgpa = (gpaFirst + gpaSecond) / 2
        CGPA_txt.Text = "Cumulative GPA: " & cgpa.ToString("F2")
        CGPAClass_txt.Text = "Class Category: " & GetGradeClassification(cgpa)
    End Sub

    ' Shared Functions
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

    Private Function GetGradeClassification(ByVal gpa As Double) As String
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

    ' Input Validation
    Private Function ValidateInputsFirst() As Boolean
        Return ValidateInput(SDT101_txt.Text, "SDT101") AndAlso
               ValidateInput(MAD102_txt.Text, "MAD102") AndAlso
               ValidateInput(SDA103_txt.Text, "SDA103") AndAlso
               ValidateInput(WAD104_txt.Text, "WAD104") AndAlso
               ValidateInput(NS105_txt.Text, "NS105") AndAlso
               ValidateInput(AGD106_txt.Text, "AGD106")
    End Function

        Private Function ValidateInputsSecond() As Boolean
            Return ValidateInput(DBMS201_txt.Text, "DBMS201") AndAlso
                   ValidateInput(UIUX202_txt.Text, "UIUX202") AndAlso
                   ValidateInput(AI204_txt.Text, "AI204") AndAlso
                   ValidateInput(SQT205_txt.Text, "SQT205") AndAlso
                   ValidateInput(AA206_txt.Text, "AA206") AndAlso
                   ValidateInput(DevOp207_txt.Text, "DevOp207")
        End Function

        Private Function ValidateInput(ByVal input As String, ByVal course As String) As Boolean
            If String.IsNullOrWhiteSpace(input) OrElse Not IsNumeric(input) OrElse Convert.ToDouble(input) < 0 OrElse Convert.ToDouble(input) > 100 Then
            MessageBox.Show("Invalid input for {course}. Please enter a valid numeric score between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Return True
        End Function
End Class