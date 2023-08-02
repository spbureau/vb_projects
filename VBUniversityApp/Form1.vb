' University Student App
' Simon Sakpla, 2023 (BIT 3)
' Form 

Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This closes the application window
    End Sub

    Private Sub OutputTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox.TextChanged

    End Sub

    Private Sub DisplyaMessageButton_Click(sender As Object, e As EventArgs) Handles DisplyaMessageButton.Click
        ' To display multiple lines in output with variable
        OutputTextBox.Text = "My name: " & NameTextBox.Text & ControlChars.NewLine &
            "Major: " & MajorTextBox.Text & ControlChars.NewLine &
            "Phone Number: " & PhoneTextBox.Text
    End Sub

    Private Sub GreyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreyRadioButton.CheckedChanged
        Me.BackColor = Color.Gray ' To set BackgroundColor to grey
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        Me.BackColor = Color.Red 'To set backcolor to red
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        Me.BackColor = Color.Blue ' to set backcolor to blue
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        Me.BackColor = Color.Green ' Set BAckcolor to green
    End Sub

    Private Sub BlackRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlackRadioButton.CheckedChanged
        Me.ForeColor = Color.Black 'Set ouput text color to black
    End Sub

    Private Sub WhiteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WhiteRadioButton.CheckedChanged
        Me.ForeColor = Color.White ' set output text color to white
    End Sub

    Private Sub MessageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MessageCheckBox.CheckedChanged
        ' controls the visibility of Output
        OutputTextBox.Visible = MessageCheckBox.Checked
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' To reset all values to default
        NameTextBox.Clear()
        MajorTextBox.Clear()
        PhoneTextBox.Clear()
        OutputTextBox.Clear()
        MessageCheckBox.Checked = True
        GreyRadioButton.Checked = True
        BlackRadioButton.Checked = True
        SunPictureBox.Visible = True
        SnowPictureBox.Visible = False
        StudentGroupBox.Visible = True

    End Sub

    Private Sub SunPictureBox_Click(sender As Object, e As EventArgs) Handles SunPictureBox.Click
        ' To show snow pic, hides sun pic
        SunPictureBox.Visible = False
        SnowPictureBox.Visible = True
    End Sub

    Private Sub SnowPictureBox_Click(sender As Object, e As EventArgs) Handles SnowPictureBox.Click
        ' To show SunPic and hide snow pic
        SunPictureBox.Visible = True
        SnowPictureBox.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentGroupBox.Visible = False
    End Sub
End Class
