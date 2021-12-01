Public Class MainForm
    Private Sub btnInd_Click(sender As Object, e As EventArgs) Handles btnInd.Click
        'Creates an instance of the individual plan form
        Dim frmIndividual As New IndividualForm
        'Displays the form in Modal Style
        frmIndividual.ShowDialog()
    End Sub

    Private Sub btnFam_Click(sender As Object, e As EventArgs) Handles btnFam.Click
        'Creates an instance of the Family plan form
        Dim frmFamily As New FamilyForm
        'Displays the form in Modal Style
        frmFamily.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program
        Me.Close()
    End Sub
End Class
