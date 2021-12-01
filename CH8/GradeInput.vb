Public Class frmGradeInput

    Private Sub GradeInput_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'When the form is activated this will display what is current saved in the arrays
        DisplayStudentNames()
        DisplayTestScores()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Clicking the button will run all the functions to store what is in the text boxes
        StoreStudentNames()
        StoreScores1()
        StoreScores2()
        StoreScores3()
        StoreScores4()
        StoreScores5()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes this instance of the form
        Me.Close()
    End Sub

    Private Sub ResetStudentData()
        Dim intStudentIndex As Integer
        Dim intScoreIndex As Integer
        'Empties the student name array
        For intStudentIndex = 0 To (g_strStudents.Length - 1)
            g_strStudents(intStudentIndex) = String.Empty
        Next
        'Sets all of the scores to zero in the test score arrays
        For intScoreIndex = 0 To g_intMAX_TESTSCORES
            g_sngScores1(intScoreIndex) = 0
            g_sngScores2(intScoreIndex) = 0
            g_sngScores3(intScoreIndex) = 0
            g_sngScores4(intScoreIndex) = 0
            g_sngScores5(intScoreIndex) = 0
        Next

    End Sub
    Sub StoreStudentNames()
        'Saves the txt boxes into the the proper array index posistions
        g_strStudents(0) = txtStudent1.Text
        g_strStudents(1) = txtStudent2.Text
        g_strStudents(2) = txtStudent3.Text
        g_strStudents(3) = txtStudent4.Text
        g_strStudents(4) = txtStudent5.Text
    End Sub

    Sub StoreScores1()
        'validates all the test scores to be numeric and between 0 and 100 then enters them into the array
        If Single.TryParse(txtS1S1.Text, g_sngScores1(0)) And
                g_sngScores1(0) >= 0 And g_sngScores1(0) <= 100 Then

            If Single.TryParse(txtS1S2.Text, g_sngScores1(1)) And
                     g_sngScores1(1) >= 0 And g_sngScores1(1) <= 100 Then

                If Single.TryParse(txtS1S3.Text, g_sngScores1(2)) And
                        g_sngScores1(2) >= 0 And g_sngScores1(2) <= 100 Then

                    If Single.TryParse(txtS1S4.Text, g_sngScores1(3)) And
                            g_sngScores1(3) >= 0 And g_sngScores1(3) <= 100 Then
                    Else
                        MessageBox.Show("Student # 1: " & txtStudent1.Text & ControlChars.CrLf &
                                        "The fourth test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                    End If
                Else
                    MessageBox.Show("Student # 1: " & txtStudent1.Text & ControlChars.CrLf &
                                        "The third test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                End If
            Else
                MessageBox.Show("Student # 1: " & txtStudent1.Text & ControlChars.CrLf &
                                        "The second test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
            End If
        Else
            MessageBox.Show("Student # 1: " & txtStudent1.Text & ControlChars.CrLf &
                                        "The first test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
        End If
    End Sub
    Sub StoreScores2()
        'validates all the test scores to be numeric and between 0 and 100 then enters them into the array
        If Single.TryParse(txtS2S1.Text, g_sngScores2(0)) And
                g_sngScores2(0) >= 0 And g_sngScores2(0) <= 100 Then

            If Single.TryParse(txtS2S2.Text, g_sngScores2(1)) And
                     g_sngScores2(1) >= 0 And g_sngScores2(1) <= 100 Then

                If Single.TryParse(txtS2S3.Text, g_sngScores2(2)) And
                        g_sngScores2(2) >= 0 And g_sngScores2(2) <= 100 Then

                    If Single.TryParse(txtS2S4.Text, g_sngScores2(3)) And
                            g_sngScores2(3) >= 0 And g_sngScores2(3) <= 100 Then
                    Else
                        MessageBox.Show("Student # 2:  " & txtStudent2.Text & ControlChars.CrLf &
                                        "The fourth test score must be a numberbetween 0 And 100.",
                                        "Invalid Test Score")
                    End If
                Else
                    MessageBox.Show("Student # 2:  " & txtStudent2.Text & ControlChars.CrLf &
                                        "The third test score must be a numberbetween 0 And 100.",
                                        "Invalid Test Score")
                End If
            Else
                MessageBox.Show("Student # 2:  " & txtStudent2.Text & ControlChars.CrLf &
                                        "The second test score must be a numberbetween 0 And 100.",
                                        "Invalid Test Score")
            End If
        Else
            MessageBox.Show("Student # 2:  " & txtStudent2.Text & ControlChars.CrLf &
                                        "The first test score must be a numberbetween 0 And 100.",
                                        "Invalid Test Score")
        End If
    End Sub

    Sub StoreScores3()
        'validates all the test scores to be numeric and between 0 and 100 then enters them into the array
        If Single.TryParse(txtS3S1.Text, g_sngScores3(0)) And
                g_sngScores3(0) >= 0 And g_sngScores3(0) <= 100 Then

            If Single.TryParse(txtS3S2.Text, g_sngScores3(1)) And
                     g_sngScores3(1) >= 0 And g_sngScores3(1) <= 100 Then

                If Single.TryParse(txtS3S3.Text, g_sngScores3(2)) And
                        g_sngScores3(2) >= 0 And g_sngScores3(2) <= 100 Then

                    If Single.TryParse(txtS3S4.Text, g_sngScores3(3)) And
                            g_sngScores3(3) >= 0 And g_sngScores3(3) <= 100 Then
                    Else
                        MessageBox.Show("Student # 3: " & txtStudent3.Text & ControlChars.CrLf &
                                        "The fourth test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                    End If
                Else
                    MessageBox.Show("Student # 3: " & txtStudent3.Text & ControlChars.CrLf &
                                        "The third test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                End If
            Else
                MessageBox.Show("Student # 3: " & txtStudent3.Text & ControlChars.CrLf &
                                        "The second test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
            End If
        Else
            MessageBox.Show("Student # 3: " & txtStudent3.Text & ControlChars.CrLf &
                                        "The first test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
        End If
    End Sub

    Sub StoreScores4()
        'validates all the test scores to be numeric and between 0 and 100 then enters them into the array
        If Single.TryParse(txtS4S1.Text, g_sngScores4(0)) And
                g_sngScores4(0) >= 0 And g_sngScores4(0) <= 100 Then

            If Single.TryParse(txtS4S2.Text, g_sngScores4(1)) And
                     g_sngScores4(1) >= 0 And g_sngScores4(1) <= 100 Then

                If Single.TryParse(txtS4S3.Text, g_sngScores4(2)) And
                        g_sngScores4(2) >= 0 And g_sngScores4(2) <= 100 Then

                    If Single.TryParse(txtS4S4.Text, g_sngScores4(3)) And
                            g_sngScores4(3) >= 0 And g_sngScores4(3) <= 100 Then
                    Else
                        MessageBox.Show("Student # 4: " & txtStudent4.Text & ControlChars.CrLf &
                                        "The fourth test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                    End If
                Else
                    MessageBox.Show("Student # 4: " & txtStudent4.Text & ControlChars.CrLf &
                                        "The third test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                End If
            Else
                MessageBox.Show("Student # 4: " & txtStudent4.Text & ControlChars.CrLf &
                                        "The second test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
            End If
        Else
            MessageBox.Show("Student # 4: " & txtStudent4.Text & ControlChars.CrLf &
                                        "The first test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
        End If
    End Sub

    Sub StoreScores5()
        'validates all the test scores to be numeric and between 0 and 100 then enters them into the array
        If Single.TryParse(txtS5S1.Text, g_sngScores5(0)) And
                g_sngScores5(0) >= 0 And g_sngScores5(0) <= 100 Then

            If Single.TryParse(txtS5S2.Text, g_sngScores5(1)) And
                     g_sngScores5(1) >= 0 And g_sngScores5(1) <= 100 Then

                If Single.TryParse(txtS5S3.Text, g_sngScores5(2)) And
                        g_sngScores5(2) >= 0 And g_sngScores5(2) <= 100 Then

                    If Single.TryParse(txtS5S4.Text, g_sngScores5(3)) And
                            g_sngScores5(3) >= 0 And g_sngScores5(3) <= 100 Then
                    Else
                        MessageBox.Show("Student # 5: " & txtStudent5.Text & ControlChars.CrLf &
                                        "The fourth test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                    End If
                Else
                    MessageBox.Show("Student # 5: " & txtStudent5.Text & ControlChars.CrLf &
                                        "The third test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
                End If
            Else
                MessageBox.Show("Student # 5: " & txtStudent5.Text & ControlChars.CrLf &
                                        "The second test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
            End If
        Else
            MessageBox.Show("Student # 5: " & txtStudent5.Text & ControlChars.CrLf &
                                        "The first test score must be a numberbetween 0 and 100.",
                                        "Invalid Test Score")
        End If
    End Sub

    Sub DisplayStudentNames()
        'Function to display current student names in the array into the text boxes
        txtStudent1.Text = g_strStudents(0).ToString()
        txtStudent2.Text = g_strStudents(1).ToString()
        txtStudent3.Text = g_strStudents(2).ToString()
        txtStudent4.Text = g_strStudents(3).ToString()
        txtStudent5.Text = g_strStudents(4).ToString()
    End Sub

    Sub DisplayTestScores()
        'Function to display current scores in the array into the text boxes
        txtS1S1.Text = g_sngScores1(0).ToString()
        txtS1S2.Text = g_sngScores1(1).ToString()
        txtS1S3.Text = g_sngScores1(2).ToString()
        txtS1S4.Text = g_sngScores1(3).ToString()

        txtS2S1.Text = g_sngScores2(0).ToString()
        txtS2S2.Text = g_sngScores2(1).ToString()
        txtS2S3.Text = g_sngScores2(2).ToString()
        txtS2S4.Text = g_sngScores2(3).ToString()

        txtS3S1.Text = g_sngScores3(0).ToString()
        txtS3S2.Text = g_sngScores3(1).ToString()
        txtS3S3.Text = g_sngScores3(2).ToString()
        txtS3S4.Text = g_sngScores3(3).ToString()

        txtS4S1.Text = g_sngScores4(0).ToString()
        txtS4S2.Text = g_sngScores4(1).ToString()
        txtS4S3.Text = g_sngScores4(2).ToString()
        txtS4S4.Text = g_sngScores4(3).ToString()

        txtS5S1.Text = g_sngScores5(0).ToString()
        txtS5S2.Text = g_sngScores5(1).ToString()
        txtS5S3.Text = g_sngScores5(2).ToString()
        txtS5S4.Text = g_sngScores5(3).ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim intResult As Integer =
        MessageBox.Show("Warning: All Previous data will be lost.", "Reset Data",
                             MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        'if Ok is pressed all arrays and text boxes are cleared
        If intResult = DialogResult.OK Then
            'Resets the Arrays
            ResetStudentData()

            'Clears the Text boxes
            txtStudent1.Clear()
            txtStudent2.Clear()
            txtStudent3.Clear()
            txtStudent4.Clear()
            txtStudent5.Clear()

            txtS1S1.Clear()
            txtS1S2.Clear()
            txtS1S3.Clear()
            txtS1S4.Clear()

            txtS2S1.Clear()
            txtS2S2.Clear()
            txtS2S3.Clear()
            txtS2S4.Clear()

            txtS3S1.Clear()
            txtS3S2.Clear()
            txtS3S3.Clear()
            txtS3S4.Clear()

            txtS4S1.Clear()
            txtS4S2.Clear()
            txtS4S3.Clear()
            txtS4S4.Clear()

            txtS5S1.Clear()
            txtS5S2.Clear()
            txtS5S3.Clear()
            txtS5S4.Clear()

            'Gives focus to the first text box
            txtStudent1.Focus()

        End If

    End Sub
End Class