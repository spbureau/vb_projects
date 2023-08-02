Public Class Form1
    Private Sub DisplayButton1_Click(sender As Object, e As EventArgs) Handles DisplayButton1.Click
        NameTextBox.Text = "Simon Peters Sakpla"
        MajorTextBox.Text = "BIT option"
    End Sub

    Private Sub DisplayButton2_Click(sender As Object, e As EventArgs) Handles DisplayButton2.Click
        NameTextBox.Text = "Blessing Blay"
        MajorTextBox.Text = "BIT option"
    End Sub

    Private Sub DisplayButton3_Click(sender As Object, e As EventArgs) Handles DisplayButton3.Click
        NameTextBox.Text = "Sweet Melanin"
        MajorTextBox.Text = "Supply Chain option"
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        NameTextBox.Clear()
        MajorTextBox.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
