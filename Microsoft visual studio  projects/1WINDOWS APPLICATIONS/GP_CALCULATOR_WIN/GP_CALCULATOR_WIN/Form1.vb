Public Class Form1
    Private Sub close_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
    'PAGES

    Private Sub second_semester_calc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_semester_calc_btn.Click
        second_semester_Panel.Show()
        first_semester_Panel.Hide()
    End Sub

    Private Sub first_semester_calc_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_semester_calc_btn.Click
        first_semester_Panel.Show()
        second_semester_Panel.Hide()
    End Sub

    'FIRST SEMESTER

    Dim gp_sdt101 As Double
    Dim gp_mad102 As Double
    Dim gp_sda103 As Double
    Dim gp_wad104 As Double
    Dim gp_ns105 As Double
    Dim gp_agd106 As Double
    Dim totalGradePointsFirst As Double
    Dim totalCourseUnitsFirst As Double = 25
    Dim gpaFirst As Double


    Dim gp_dbms201 As Double
    Dim gp_uiux202 As Double
    Dim gp_ai204 As Double
    Dim gp_sqt205 As Double
    Dim gp_aa206 As Double
    Dim gp_devop207 As Double
    Dim totalGradePointsSecond As Double
    Dim totalCourseUnitsSecond As Double = 24
    Dim gpaSecond As Double

    Private Sub calcFirst_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcFirst_btn.Click
        If Not ValidateInputsFirst() Then Return

        ' Calculate Grade Points
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

    Private Sub calcSecond_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcSecond_btn.Click
        If Not ValidateInputsSecond() Then Return

        ' Calculate Grade Points
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
        GPASecond_txt.Text = "Grade Point Average: " & gpaSecond.ToString("F2")
        GradeClassSecond_txt.Text = "Grade Classification: " & GetGradeClassification(gpaSecond)
    End Sub

    ' Validate Inputs for First Semester
    Private Function ValidateInputsFirst() As Boolean
        Return ValidateInput(SDT101_txt.Text, "SDT101") AndAlso
               ValidateInput(MAD102_txt.Text, "MAD102") AndAlso
               ValidateInput(SDA103_txt.Text, "SDA103") AndAlso
               ValidateInput(WAD104_txt.Text, "WAD104") AndAlso
               ValidateInput(NS105_txt.Text, "NS105") AndAlso
               ValidateInput(AGD106_txt.Text, "AGD106")
    End Function

    ' Validate Inputs for Second Semester
    Private Function ValidateInputsSecond() As Boolean
        Return ValidateInput(DBMS201_txt.Text, "DBMS201") AndAlso
               ValidateInput(UIUX202_txt.Text, "UIUX202") AndAlso
               ValidateInput(AI204_txt.Text, "AI204") AndAlso
               ValidateInput(SQT205_txt.Text, "SQT205") AndAlso
               ValidateInput(AA206_txt.Text, "AA20") AndAlso
                ValidateInput(DevOp207_txt.Text, "DevOp207")
    End Function

    Private Function ValidateInput(ByVal input As String, ByVal course As String) As Boolean
        ' Check for empty input
        If String.IsNullOrWhiteSpace(input) Then
            MessageBox.Show("Please enter a score for {course}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check for non-numeric characters
        If Not IsNumeric(input) Then
            MessageBox.Show("Invalid score for {courses}. Only numeric values are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Check for length greater than 3 digits
        If input.Length > 3 Then
            MessageBox.Show("Invalid score for {course}. The score cannot exceed three digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ' Calculate Grade Points
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

    ' Get Grade Classification
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

    ' Clear All Fields for First Semester
    Private Sub ClearFirst_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFirst_btn.Click
        SDT101_txt.Text = ""
        MAD102_txt.Text = ""
        SDA103_txt.Text = ""
        WAD104_txt.Text = ""
        NS105_txt.Text = ""
        AGD106_txt.Text = ""
        TotalGPFirst_txt.Text = ""
        GPAFirst_txt.Text = ""
        GradeClassFirst_txt.Text = ""
    End Sub

    ' Clear All Fields for Second Semester
    Private Sub ClearSecond_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSecond_btn.Click
        DBMS201_txt.Text = ""
        UIUX202_txt.Text = ""
        AI204_txt.Text = ""
        SQT205_txt.Text = ""
        AA206_txt.Text = ""
        DevOp207_txt.Text = ""
        TotalGPSecond_txt.Text = ""
        GPASecond_txt.Text = ""
        GradeClassSecond_txt.Text = ""
    End Sub

    Private Sub DBMS201_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UIUX202_txt.KeyPress, SQT205_txt.KeyPress, DevOp207_txt.KeyPress, DBMS201_txt.KeyPress, AI204_txt.KeyPress, AA206_txt.KeyPress
        Dim Textbox As TextBox = CType(sender, TextBox)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            Textbox.Focus()
        End If

        ' Check for length greater than 3 digits
        If Textbox.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid score for {course}. The score cannot exceed three digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textbox.Focus()
        End If
    End Sub

    Private Sub SDT101_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WAD104_txt.KeyPress, SDT101_txt.KeyPress, SDA103_txt.KeyPress, NS105_txt.KeyPress, MAD102_txt.KeyPress, AGD106_txt.KeyPress
        Dim Textbox As TextBox = CType(sender, TextBox)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Incorrect Input. Input can't be alphabets, symbols.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            Textbox.Focus()
        End If

        ' Check for length greater than 3 digits
        If Textbox.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Invalid score for {course}. The score cannot exceed three digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textbox.Focus()
        End If
    End Sub

    Private Sub SDT101_txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WAD104_txt.Leave, SDT101_txt.Leave, SDA103_txt.Leave, NS105_txt.Leave, MAD102_txt.Leave, AGD106_txt.Leave
        Dim Textbox As TextBox = CType(sender, TextBox)
        Dim score As Integer
        If Not Integer.TryParse(TextBox.Text, score) OrElse score < 0 OrElse score > 100 Then
            MessageBox.Show("Invalid score for {course}. Enter a score between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox.Focus()
        End If
    End Sub

    Private Sub DevOp207_txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UIUX202_txt.Leave, SQT205_txt.Leave, DevOp207_txt.Leave, DBMS201_txt.Leave, AI204_txt.Leave, AA206_txt.Leave
        Dim Textbox As TextBox = CType(sender, TextBox)
        Dim score As Integer
        If Not Integer.TryParse(Textbox.Text, score) OrElse score < 0 OrElse score > 100 Then
            MessageBox.Show("Invalid score for {course}. Enter a score between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Textbox.Focus()
        End If
    End Sub

   
    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class