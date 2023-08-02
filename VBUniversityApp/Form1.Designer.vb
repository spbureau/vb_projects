<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        NameTextBox = New TextBox()
        StudentGroupBox = New GroupBox()
        PhoneTextBox = New MaskedTextBox()
        MajorTextBox = New TextBox()
        PhoneLabel = New Label()
        NameLabel = New Label()
        MajorLabel = New Label()
        OutputTextBox = New TextBox()
        OutputLabel = New Label()
        BackgroundGroupBox = New GroupBox()
        GreenRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        RedRadioButton = New RadioButton()
        GreyRadioButton = New RadioButton()
        TextBoxGroupBox = New GroupBox()
        WhiteRadioButton = New RadioButton()
        BlackRadioButton = New RadioButton()
        MessageCheckBox = New CheckBox()
        SunPictureBox = New PictureBox()
        SnowPictureBox = New PictureBox()
        DisplyaMessageButton = New Button()
        ResetButton = New Button()
        ExitButton = New Button()
        ToolTip = New ToolTip(components)
        Button1 = New Button()
        StudentGroupBox.SuspendLayout()
        BackgroundGroupBox.SuspendLayout()
        TextBoxGroupBox.SuspendLayout()
        CType(SunPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(SnowPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NameTextBox.ForeColor = SystemColors.ActiveCaptionText
        NameTextBox.Location = New Point(85, 30)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(250, 29)
        NameTextBox.TabIndex = 1
        ToolTip.SetToolTip(NameTextBox, "Enter student name")
        ' 
        ' StudentGroupBox
        ' 
        StudentGroupBox.Controls.Add(PhoneTextBox)
        StudentGroupBox.Controls.Add(MajorTextBox)
        StudentGroupBox.Controls.Add(PhoneLabel)
        StudentGroupBox.Controls.Add(NameLabel)
        StudentGroupBox.Controls.Add(MajorLabel)
        StudentGroupBox.Controls.Add(NameTextBox)
        StudentGroupBox.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StudentGroupBox.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        StudentGroupBox.Location = New Point(37, 24)
        StudentGroupBox.Name = "StudentGroupBox"
        StudentGroupBox.Size = New Size(341, 164)
        StudentGroupBox.TabIndex = 1
        StudentGroupBox.TabStop = False
        StudentGroupBox.Text = "Student Information"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneTextBox.ForeColor = SystemColors.ActiveCaptionText
        PhoneTextBox.Location = New Point(85, 121)
        PhoneTextBox.Mask = "(999) 000-0000"
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(250, 29)
        PhoneTextBox.TabIndex = 5
        ToolTip.SetToolTip(PhoneTextBox, "Enter Phone number")
        ' 
        ' MajorTextBox
        ' 
        MajorTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MajorTextBox.ForeColor = SystemColors.ActiveCaptionText
        MajorTextBox.Location = New Point(85, 74)
        MajorTextBox.Name = "MajorTextBox"
        MajorTextBox.Size = New Size(250, 29)
        MajorTextBox.TabIndex = 3
        ToolTip.SetToolTip(MajorTextBox, "Enter Major here")
        ' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneLabel.ForeColor = SystemColors.ActiveCaptionText
        PhoneLabel.Location = New Point(6, 122)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(57, 21)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "Phone:"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NameLabel.ForeColor = SystemColors.ActiveCaptionText
        NameLabel.Location = New Point(8, 32)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(55, 21)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        ' 
        ' MajorLabel
        ' 
        MajorLabel.AutoSize = True
        MajorLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MajorLabel.ForeColor = SystemColors.ActiveCaptionText
        MajorLabel.Location = New Point(6, 78)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New Size(54, 21)
        MajorLabel.TabIndex = 2
        MajorLabel.Text = "Major:"
        ' 
        ' OutputTextBox
        ' 
        OutputTextBox.Location = New Point(122, 194)
        OutputTextBox.Multiline = True
        OutputTextBox.Name = "OutputTextBox"
        OutputTextBox.ReadOnly = True
        OutputTextBox.Size = New Size(256, 80)
        OutputTextBox.TabIndex = 3
        ' 
        ' OutputLabel
        ' 
        OutputLabel.AutoSize = True
        OutputLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OutputLabel.Location = New Point(38, 198)
        OutputLabel.Name = "OutputLabel"
        OutputLabel.Size = New Size(62, 21)
        OutputLabel.TabIndex = 2
        OutputLabel.Text = "Output:"
        ' 
        ' BackgroundGroupBox
        ' 
        BackgroundGroupBox.Controls.Add(GreenRadioButton)
        BackgroundGroupBox.Controls.Add(BlueRadioButton)
        BackgroundGroupBox.Controls.Add(RedRadioButton)
        BackgroundGroupBox.Controls.Add(GreyRadioButton)
        BackgroundGroupBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackgroundGroupBox.ForeColor = Color.Blue
        BackgroundGroupBox.Location = New Point(485, 37)
        BackgroundGroupBox.Name = "BackgroundGroupBox"
        BackgroundGroupBox.Size = New Size(153, 151)
        BackgroundGroupBox.TabIndex = 4
        BackgroundGroupBox.TabStop = False
        BackgroundGroupBox.Text = "Background"
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GreenRadioButton.Location = New Point(28, 123)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(70, 25)
        GreenRadioButton.TabIndex = 3
        GreenRadioButton.Text = "Green"
        ToolTip.SetToolTip(GreenRadioButton, "Set background color to green")
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BlueRadioButton.Location = New Point(28, 90)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(58, 25)
        BlueRadioButton.TabIndex = 2
        BlueRadioButton.Text = "Blue"
        ToolTip.SetToolTip(BlueRadioButton, "Set background color to blue")
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RedRadioButton.Location = New Point(28, 56)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(55, 25)
        RedRadioButton.TabIndex = 1
        RedRadioButton.Text = "Red"
        ToolTip.SetToolTip(RedRadioButton, "Set background color to red")
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreyRadioButton
        ' 
        GreyRadioButton.AutoSize = True
        GreyRadioButton.Checked = True
        GreyRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GreyRadioButton.Location = New Point(28, 23)
        GreyRadioButton.Name = "GreyRadioButton"
        GreyRadioButton.Size = New Size(61, 25)
        GreyRadioButton.TabIndex = 0
        GreyRadioButton.TabStop = True
        GreyRadioButton.Text = "Grey"
        ToolTip.SetToolTip(GreyRadioButton, "Set background color to grey")
        GreyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TextBoxGroupBox
        ' 
        TextBoxGroupBox.Controls.Add(WhiteRadioButton)
        TextBoxGroupBox.Controls.Add(BlackRadioButton)
        TextBoxGroupBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxGroupBox.ForeColor = Color.Blue
        TextBoxGroupBox.Location = New Point(485, 206)
        TextBoxGroupBox.Name = "TextBoxGroupBox"
        TextBoxGroupBox.Size = New Size(153, 68)
        TextBoxGroupBox.TabIndex = 5
        TextBoxGroupBox.TabStop = False
        TextBoxGroupBox.Text = "Text Color"
        ' 
        ' WhiteRadioButton
        ' 
        WhiteRadioButton.AutoSize = True
        WhiteRadioButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        WhiteRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WhiteRadioButton.Location = New Point(28, 43)
        WhiteRadioButton.Name = "WhiteRadioButton"
        WhiteRadioButton.Size = New Size(69, 25)
        WhiteRadioButton.TabIndex = 1
        WhiteRadioButton.Text = "White"
        ToolTip.SetToolTip(WhiteRadioButton, "Set text color to white")
        WhiteRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlackRadioButton
        ' 
        BlackRadioButton.AutoSize = True
        BlackRadioButton.Checked = True
        BlackRadioButton.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BlackRadioButton.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BlackRadioButton.Location = New Point(28, 18)
        BlackRadioButton.Name = "BlackRadioButton"
        BlackRadioButton.Size = New Size(64, 25)
        BlackRadioButton.TabIndex = 0
        BlackRadioButton.TabStop = True
        BlackRadioButton.Text = "Black"
        ToolTip.SetToolTip(BlackRadioButton, "Set text color to black")
        BlackRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MessageCheckBox
        ' 
        MessageCheckBox.AutoSize = True
        MessageCheckBox.Checked = True
        MessageCheckBox.CheckState = CheckState.Checked
        MessageCheckBox.Location = New Point(122, 280)
        MessageCheckBox.Name = "MessageCheckBox"
        MessageCheckBox.Size = New Size(109, 19)
        MessageCheckBox.TabIndex = 0
        MessageCheckBox.Text = "Message Visible"
        ToolTip.SetToolTip(MessageCheckBox, "Show/Hide Output")
        MessageCheckBox.UseVisualStyleBackColor = True
        ' 
        ' SunPictureBox
        ' 
        SunPictureBox.Image = My.Resources.Resources.sun
        SunPictureBox.Location = New Point(122, 320)
        SunPictureBox.Name = "SunPictureBox"
        SunPictureBox.Size = New Size(70, 68)
        SunPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        SunPictureBox.TabIndex = 7
        SunPictureBox.TabStop = False
        ToolTip.SetToolTip(SunPictureBox, "change to sunny")
        ' 
        ' SnowPictureBox
        ' 
        SnowPictureBox.Image = My.Resources.Resources.snow
        SnowPictureBox.Location = New Point(221, 320)
        SnowPictureBox.Name = "SnowPictureBox"
        SnowPictureBox.Size = New Size(78, 69)
        SnowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        SnowPictureBox.TabIndex = 8
        SnowPictureBox.TabStop = False
        ToolTip.SetToolTip(SnowPictureBox, "Change to snow")
        ' 
        ' DisplyaMessageButton
        ' 
        DisplyaMessageButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DisplyaMessageButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DisplyaMessageButton.ForeColor = Color.White
        DisplyaMessageButton.Location = New Point(393, 316)
        DisplyaMessageButton.Name = "DisplyaMessageButton"
        DisplyaMessageButton.Size = New Size(122, 52)
        DisplyaMessageButton.TabIndex = 6
        DisplyaMessageButton.Text = "Display &Message"
        ToolTip.SetToolTip(DisplyaMessageButton, "Display Message in OutputBox")
        DisplyaMessageButton.UseVisualStyleBackColor = False
        ' 
        ' ResetButton
        ' 
        ResetButton.BackColor = Color.Gray
        ResetButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ResetButton.ForeColor = Color.White
        ResetButton.Location = New Point(534, 316)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(104, 32)
        ResetButton.TabIndex = 7
        ResetButton.Text = "&Reset"
        ToolTip.SetToolTip(ResetButton, "Reset all values")
        ResetButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.Red
        ExitButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.White
        ExitButton.Location = New Point(534, 363)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(104, 32)
        ExitButton.TabIndex = 8
        ExitButton.Text = "E&xit"
        ToolTip.SetToolTip(ExitButton, "Click to close window")
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(404, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 25)
        Button1.TabIndex = 9
        Button1.Text = "HIDE"
        ToolTip.SetToolTip(Button1, "Hide students box")
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(740, 407)
        Controls.Add(Button1)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(DisplyaMessageButton)
        Controls.Add(SnowPictureBox)
        Controls.Add(SunPictureBox)
        Controls.Add(MessageCheckBox)
        Controls.Add(TextBoxGroupBox)
        Controls.Add(BackgroundGroupBox)
        Controls.Add(OutputLabel)
        Controls.Add(OutputTextBox)
        Controls.Add(StudentGroupBox)
        Name = "Form1"
        Text = "9"
        StudentGroupBox.ResumeLayout(False)
        StudentGroupBox.PerformLayout()
        BackgroundGroupBox.ResumeLayout(False)
        BackgroundGroupBox.PerformLayout()
        TextBoxGroupBox.ResumeLayout(False)
        TextBoxGroupBox.PerformLayout()
        CType(SunPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(SnowPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents StudentGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents MajorLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents PhoneTextBox As MaskedTextBox
    Friend WithEvents BackgroundGroupBox As GroupBox
    Friend WithEvents GreyRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents TextBoxGroupBox As GroupBox
    Friend WithEvents WhiteRadioButton As RadioButton
    Friend WithEvents BlackRadioButton As RadioButton
    Friend WithEvents MessageCheckBox As CheckBox
    Friend WithEvents SunPictureBox As PictureBox
    Friend WithEvents SnowPictureBox As PictureBox
    Friend WithEvents DisplyaMessageButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Button1 As Button
End Class
