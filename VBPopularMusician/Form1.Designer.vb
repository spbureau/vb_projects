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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        NameLabel = New Label()
        AwardLabel = New Label()
        SongLabel = New Label()
        LocationLabel = New Label()
        NicknameLabel = New Label()
        NameButton = New Button()
        LocationButton = New Button()
        PopularSongButton = New Button()
        AwardButton = New Button()
        ShowAllButton = New Button()
        ClearAllButton = New Button()
        ProfilePicture = New PictureBox()
        Label12 = New Label()
        CType(ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(43, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 25)
        Label1.TabIndex = 0
        Label1.Text = "Who is this Musician?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Peru
        Label2.Location = New Point(43, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 17)
        Label2.TabIndex = 1
        Label2.Text = "Click below to reveal artist information..."
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        NameLabel.Location = New Point(158, 126)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(17, 21)
        NameLabel.TabIndex = 2
        NameLabel.Text = "*"
        ' 
        ' AwardLabel
        ' 
        AwardLabel.AutoSize = True
        AwardLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        AwardLabel.Location = New Point(158, 285)
        AwardLabel.Name = "AwardLabel"
        AwardLabel.Size = New Size(17, 21)
        AwardLabel.TabIndex = 4
        AwardLabel.Text = "*"
        ' 
        ' SongLabel
        ' 
        SongLabel.AutoSize = True
        SongLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SongLabel.Location = New Point(158, 227)
        SongLabel.Name = "SongLabel"
        SongLabel.Size = New Size(17, 21)
        SongLabel.TabIndex = 5
        SongLabel.Text = "*"
        ' 
        ' LocationLabel
        ' 
        LocationLabel.AutoSize = True
        LocationLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LocationLabel.Location = New Point(158, 176)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New Size(17, 21)
        LocationLabel.TabIndex = 7
        LocationLabel.Text = "*"
        ' 
        ' NicknameLabel
        ' 
        NicknameLabel.AutoSize = True
        NicknameLabel.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        NicknameLabel.Location = New Point(411, 219)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New Size(21, 20)
        NicknameLabel.TabIndex = 8
        NicknameLabel.Text = "..."
        ' 
        ' NameButton
        ' 
        NameButton.BackColor = SystemColors.HighlightText
        NameButton.Location = New Point(26, 119)
        NameButton.Name = "NameButton"
        NameButton.Size = New Size(104, 44)
        NameButton.TabIndex = 12
        NameButton.Text = "Show Name"
        NameButton.UseVisualStyleBackColor = False
        ' 
        ' LocationButton
        ' 
        LocationButton.BackColor = SystemColors.HighlightText
        LocationButton.Location = New Point(26, 169)
        LocationButton.Name = "LocationButton"
        LocationButton.Size = New Size(104, 44)
        LocationButton.TabIndex = 13
        LocationButton.Text = "Show Location"
        LocationButton.UseVisualStyleBackColor = False
        ' 
        ' PopularSongButton
        ' 
        PopularSongButton.BackColor = SystemColors.HighlightText
        PopularSongButton.Location = New Point(26, 219)
        PopularSongButton.Name = "PopularSongButton"
        PopularSongButton.Size = New Size(104, 45)
        PopularSongButton.TabIndex = 14
        PopularSongButton.Text = "Show Popular Song"
        PopularSongButton.UseVisualStyleBackColor = False
        ' 
        ' AwardButton
        ' 
        AwardButton.BackColor = SystemColors.HighlightText
        AwardButton.Location = New Point(26, 278)
        AwardButton.Name = "AwardButton"
        AwardButton.Size = New Size(104, 44)
        AwardButton.TabIndex = 15
        AwardButton.Text = "Show Award"
        AwardButton.UseVisualStyleBackColor = False
        ' 
        ' ShowAllButton
        ' 
        ShowAllButton.BackColor = SystemColors.HighlightText
        ShowAllButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ShowAllButton.ForeColor = Color.Navy
        ShowAllButton.Location = New Point(26, 339)
        ShowAllButton.Name = "ShowAllButton"
        ShowAllButton.Size = New Size(104, 44)
        ShowAllButton.TabIndex = 16
        ShowAllButton.Text = "Show All"
        ShowAllButton.UseVisualStyleBackColor = False
        ' 
        ' ClearAllButton
        ' 
        ClearAllButton.BackColor = Color.Chocolate
        ClearAllButton.Location = New Point(204, 339)
        ClearAllButton.Name = "ClearAllButton"
        ClearAllButton.Size = New Size(75, 44)
        ClearAllButton.TabIndex = 17
        ClearAllButton.Text = "Clear All"
        ClearAllButton.UseVisualStyleBackColor = False
        ' 
        ' ProfilePicture
        ' 
        ProfilePicture.Image = CType(resources.GetObject("ProfilePicture.Image"), Image)
        ProfilePicture.Location = New Point(387, 12)
        ProfilePicture.Name = "ProfilePicture"
        ProfilePicture.Size = New Size(194, 185)
        ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        ProfilePicture.TabIndex = 18
        ProfilePicture.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Navy
        Label12.Location = New Point(43, 79)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 21)
        Label12.TabIndex = 19
        Label12.Text = "Profile"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(593, 450)
        Controls.Add(Label12)
        Controls.Add(ProfilePicture)
        Controls.Add(ClearAllButton)
        Controls.Add(ShowAllButton)
        Controls.Add(AwardButton)
        Controls.Add(PopularSongButton)
        Controls.Add(LocationButton)
        Controls.Add(NameButton)
        Controls.Add(NicknameLabel)
        Controls.Add(LocationLabel)
        Controls.Add(SongLabel)
        Controls.Add(AwardLabel)
        Controls.Add(NameLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AwardLabel As Label
    Friend WithEvents SongLabel As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents NicknameLabel As Label
    Friend WithEvents NameButton As Button
    Friend WithEvents LocationButton As Button
    Friend WithEvents PopularSongButton As Button
    Friend WithEvents AwardButton As Button
    Friend WithEvents ShowAllButton As Button
    Friend WithEvents ClearAllButton As Button
    Friend WithEvents ProfilePicture As PictureBox
    Friend WithEvents Label12 As Label
End Class
