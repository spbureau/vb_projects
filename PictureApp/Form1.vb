Public Class Form1
    Private Sub btnClickhere_Click(sender As Object, e As EventArgs) Handles btnClickhere.Click
        lblHelloWorld.Text = "Hello World"
    End Sub

    Private Sub BtnSurname_Click(sender As Object, e As EventArgs) Handles BtnSurname.Click
        lblSurname.Text = "Your surname is SAKPLA!"
    End Sub

    Private Sub BtnOtherNames_Click(sender As Object, e As EventArgs) Handles BtnOtherNames.Click
        lblOtherNames.Text = "Simon Peters"
    End Sub
End Class
