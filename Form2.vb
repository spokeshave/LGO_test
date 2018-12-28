Public Class Form2

    Private Sub RoofProgressBarTimer_Tick(sender As Object, e As EventArgs) Handles RoofProgressBarTimer.Tick
        RoofProgressBar.Increment(1) 'Roof takes 57 seconds to open or close. Progress bar maximum is set to 57 and this increments the progress bar every second
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoofProgressBarTimer.Enabled = True
    End Sub

    Private Sub RoofProgressBar_Click(sender As Object, e As EventArgs) Handles RoofProgressBar.Click

    End Sub
End Class