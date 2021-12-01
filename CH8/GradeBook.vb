Public Class frmGradeBook

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Displays the edit grade form
        DisplayInputForm()
    End Sub

    Sub DisplayInputForm()
        'Funcion will dispay an istance of the stundent grade input form
        Dim frmInput As New frmGradeInput
        frmInput.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes out the program
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        DisplayStudentNames()
        DisplayTestAverages()
        DisplayLetterGrades()
    End Sub

    Sub DisplayStudentNames()
        lblStudent1.Text = g_strStudents(0).ToString()
        lblStudent2.Text = g_strStudents(1).ToString()
        lblStudent3.Text = g_strStudents(2).ToString()
        lblStudent4.Text = g_strStudents(3).ToString()
        lblStudent5.Text = g_strStudents(4).ToString()
    End Sub

    Sub DisplayTestAverages()
        lblAverage1.Text = (Average(g_sngScores1)).ToString("N2")
        lblAverage2.Text = (Average(g_sngScores2)).ToString("N2")
        lblAverage3.Text = (Average(g_sngScores3)).ToString("N2")
        lblAverage4.Text = (Average(g_sngScores4)).ToString("N2")
        lblAverage5.Text = (Average(g_sngScores5)).ToString("N2")
    End Sub

    Sub DisplayLetterGrades()
        Dim sngStudentAverages() As Single = {Average(g_sngScores1), Average(g_sngScores2), Average(g_sngScores3), Average(g_sngScores4), Average(g_sngScores5)}
        Dim intCount As Integer = 0
        For intCount = 0 To (sngStudentAverages.Length - 1)
            Select Case sngStudentAverages(intCount)
                Case Is >= 90
                    g_strGrades(intCount) = "A"
                Case 80 To 89
                    g_strGrades(intCount) = "B"
                Case 70 To 79
                    g_strGrades(intCount) = "C"
                Case 60 To 69
                    g_strGrades(intCount) = "D"
                Case Else
                    g_strGrades(intCount) = "F"
            End Select
        Next

        lblGrade1.Text = g_strGrades(0).ToString()
        lblGrade2.Text = g_strGrades(1).ToString()
        lblGrade3.Text = g_strGrades(2).ToString()
        lblGrade4.Text = g_strGrades(3).ToString()
        lblGrade5.Text = g_strGrades(4).ToString()
    End Sub

    Function Total(ByVal sngValues() As Single) As Single
        Dim sngTotal As Single = 0
        Dim intCount As Integer

        For intCount = 0 To g_intMAX_TESTSCORES
            sngTotal += sngValues(intCount)
        Next

        Return sngTotal
    End Function

    Function Average(ByVal sngValues() As Single) As Single
        Dim sngTotal As Single = Total(sngValues)
        Dim intNumValues As Integer = sngValues.Length

        Return sngTotal / intNumValues
    End Function
End Class
