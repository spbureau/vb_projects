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
        NameLabel = New Label()
        MajorLabel = New Label()
        NameTextBox = New TextBox()
        MajorTextBox = New TextBox()
        Label3 = New Label()
        DisplayButton1 = New Button()
        DisplayButton2 = New Button()
        DisplayButton3 = New Button()
        ExitButton = New Button()
        PrintButton = New Button()
        ResetButton = New Button()
        SuspendLayout()
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NameLabel.Location = New Point(35, 66)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(112, 21)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Student Name:"
        ' 
        ' MajorLabel
        ' 
        MajorLabel.AutoSize = True
        MajorLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MajorLabel.Location = New Point(35, 112)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New Size(125, 21)
        MajorLabel.TabIndex = 1
        MajorLabel.Text = "Academic Major:"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(206, 68)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.ReadOnly = True
        NameTextBox.Size = New Size(247, 23)
        NameTextBox.TabIndex = 2
        ' 
        ' MajorTextBox
        ' 
        MajorTextBox.Location = New Point(206, 110)
        MajorTextBox.Name = "MajorTextBox"
        MajorTextBox.ReadOnly = True
        MajorTextBox.Size = New Size(247, 23)
        MajorTextBox.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(165, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 30)
        Label3.TabIndex = 4
        Label3.Text = "University Student"
        ' 
        ' DisplayButton1
        ' 
        DisplayButton1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayButton1.ForeColor = Color.Navy
        DisplayButton1.Location = New Point(96, 212)
        DisplayButton1.Name = "DisplayButton1"
        DisplayButton1.Size = New Size(75, 60)
        DisplayButton1.TabIndex = 5
        DisplayButton1.Text = "Display Student #1"
        DisplayButton1.UseVisualStyleBackColor = True
        ' 
        ' DisplayButton2
        ' 
        DisplayButton2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayButton2.ForeColor = Color.Navy
        DisplayButton2.Location = New Point(246, 212)
        DisplayButton2.Name = "DisplayButton2"
        DisplayButton2.Size = New Size(75, 60)
        DisplayButton2.TabIndex = 6
        DisplayButton2.Text = "Display Student #2"
        DisplayButton2.UseVisualStyleBackColor = True
        ' 
        ' DisplayButton3
        ' 
        DisplayButton3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DisplayButton3.ForeColor = Color.Navy
        DisplayButton3.Location = New Point(378, 212)
        DisplayButton3.Name = "DisplayButton3"
        DisplayButton3.Size = New Size(75, 60)
        DisplayButton3.TabIndex = 7
        DisplayButton3.Text = "Display Student #3"
        DisplayButton3.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        ExitButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.White
        ExitButton.Location = New Point(96, 312)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 50)
        ExitButton.TabIndex = 8
        ExitButton.Text = "Exit Form"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' PrintButton
        ' 
        PrintButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PrintButton.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        PrintButton.Location = New Point(378, 312)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(75, 50)
        PrintButton.TabIndex = 9
        PrintButton.Text = "Print Form"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.BackColor = Color.Gray
        ResetButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ResetButton.ForeColor = Color.White
        ResetButton.Location = New Point(246, 312)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(75, 50)
        ResetButton.TabIndex = 10
        ResetButton.Text = "Reset Form"
        ResetButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(593, 428)
        Controls.Add(ResetButton)
        Controls.Add(PrintButton)
        Controls.Add(ExitButton)
        Controls.Add(DisplayButton3)
        Controls.Add(DisplayButton2)
        Controls.Add(DisplayButton1)
        Controls.Add(Label3)
        Controls.Add(MajorTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(MajorLabel)
        Controls.Add(NameLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents MajorLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DisplayButton1 As Button
    Friend WithEvents DisplayButton2 As Button
    Friend WithEvents DisplayButton3 As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ResetButton As Button
End Class
