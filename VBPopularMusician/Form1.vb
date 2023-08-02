Public Class Form1
    Private Sub NameButton_Click(sender As Object, e As EventArgs) Handles NameButton.Click
        NameLabel.Text = "Livingstone Etse Satekla"

    End Sub

    Private Sub LocationButton_Click(sender As Object, e As EventArgs) Handles LocationButton.Click
        LocationLabel.Text = "Accra Ghana"
    End Sub

    Private Sub PopularSongButton_Click(sender As Object, e As EventArgs) Handles PopularSongButton.Click
        SongLabel.Text = "Into The Future"
    End Sub

    Private Sub ShowAllButton_Click(sender As Object, e As EventArgs) Handles ShowAllButton.Click
        NameLabel.Text = "Livingstone Etse Satekla"
        LocationLabel.Text = "Accra, Ghana"
        SongLabel.Text = "Into The Future"
        AwardLabel.Text = "VGMA Artiste of the Year 2015"
        NicknameLabel.Text = "Stonebwoy (1GAD)"
        ProfilePicture.Visible = True
    End Sub

    Private Sub AwardButton_Click(sender As Object, e As EventArgs) Handles AwardButton.Click
        AwardLabel.Text = "VGMA Artiste of the Year 2015"
    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click
        NameLabel.Text = ""
        LocationLabel.Text = ""
        SongLabel.Text = ""
        AwardLabel.Text = ""
        NicknameLabel.Text = ""
        ProfilePicture.Visible = False
    End Sub

    Private Sub ProfilePicture_Click(sender As Object, e As EventArgs) Handles ProfilePicture.Click
        If ProfilePicture.Visible = False Then
            ProfilePicture.Visible = True
        Else
            ProfilePicture.Visible = True
        End If


    End Sub
End Class
