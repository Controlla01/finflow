Module Functions
    Public Function CalculateGradePoints(ByVal score As Double, ByVal unit As Double) As Double
        Dim gradePoint As Double

        If (score >= 80) Then
            gradePoint = 4.0
        ElseIf (score >= 70) Then
            gradePoint = 3.5
        ElseIf (score >= 60) Then
            gradePoint = 3.0
        ElseIf (score >= 50) Then
            gradePoint = 2.5
        ElseIf (score >= 40) Then
            gradePoint = 2.0
        Else
            gradePoint = 0
        End If

        Return gradePoint * unit
    End Function

    Public Function GetGradeClassification(ByVal gpa As Double) As String
        If (gpa >= 3.5) Then
            Return "DISTINCTION"
        ElseIf (gpa >= 3.0) Then
            Return "UPPER CREDIT"
        ElseIf (gpa >= 2.5) Then
            Return "LOWER CREDIT"
        ElseIf (gpa >= 2.0) Then
            Return "PASS"
        Else
            Return "FAIL"
        End If
    End Function

    Public Function ValidateInputs(ByVal inputs() As TextBox) As Boolean
        For Each input As TextBox In inputs
            If String.IsNullOrWhiteSpace(input.Text) OrElse Not IsNumeric(input.Text) OrElse Convert.ToDouble(input.Text) < 0 OrElse Convert.ToDouble(input.Text) > 100 Then
                MessageBox.Show("Invalid input in {input.Name}. Please enter a score between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next
        Return True
    End Function

End Module
