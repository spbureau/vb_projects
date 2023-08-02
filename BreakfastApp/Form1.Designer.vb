<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Breakfast
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Breakfast))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnFood1 = New System.Windows.Forms.Button()
        Me.btnFood2 = New System.Windows.Forms.Button()
        Me.btnSelectBreakfast = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFood1 = New System.Windows.Forms.PictureBox()
        Me.picFood2 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDoneMessage = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.picFood1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFood2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(255, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(215, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Breakfast Selection"
        '
        'btnFood1
        '
        Me.btnFood1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFood1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood1.Location = New System.Drawing.Point(118, 364)
        Me.btnFood1.Name = "btnFood1"
        Me.btnFood1.Size = New System.Drawing.Size(119, 33)
        Me.btnFood1.TabIndex = 1
        Me.btnFood1.Text = "Food 1"
        Me.btnFood1.UseVisualStyleBackColor = False
        '
        'btnFood2
        '
        Me.btnFood2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFood2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood2.Location = New System.Drawing.Point(500, 364)
        Me.btnFood2.Name = "btnFood2"
        Me.btnFood2.Size = New System.Drawing.Size(114, 33)
        Me.btnFood2.TabIndex = 2
        Me.btnFood2.Text = "Food 2"
        Me.btnFood2.UseVisualStyleBackColor = False
        '
        'btnSelectBreakfast
        '
        Me.btnSelectBreakfast.BackColor = System.Drawing.Color.Silver
        Me.btnSelectBreakfast.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectBreakfast.Location = New System.Drawing.Point(280, 364)
        Me.btnSelectBreakfast.Name = "btnSelectBreakfast"
        Me.btnSelectBreakfast.Size = New System.Drawing.Size(168, 33)
        Me.btnSelectBreakfast.TabIndex = 3
        Me.btnSelectBreakfast.Text = "Select Breakfast"
        Me.btnSelectBreakfast.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(280, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picFood1
        '
        Me.picFood1.Image = CType(resources.GetObject("picFood1.Image"), System.Drawing.Image)
        Me.picFood1.Location = New System.Drawing.Point(48, 100)
        Me.picFood1.Name = "picFood1"
        Me.picFood1.Size = New System.Drawing.Size(264, 236)
        Me.picFood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFood1.TabIndex = 5
        Me.picFood1.TabStop = False
        '
        'picFood2
        '
        Me.picFood2.Image = CType(resources.GetObject("picFood2.Image"), System.Drawing.Image)
        Me.picFood2.Location = New System.Drawing.Point(407, 100)
        Me.picFood2.Name = "picFood2"
        Me.picFood2.Size = New System.Drawing.Size(267, 236)
        Me.picFood2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFood2.TabIndex = 6
        Me.picFood2.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(144, 56)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(413, 23)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Choose breakfast type and click Select Breakfast"
        '
        'lblDoneMessage
        '
        Me.lblDoneMessage.AutoSize = True
        Me.lblDoneMessage.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoneMessage.Location = New System.Drawing.Point(276, 430)
        Me.lblDoneMessage.Name = "lblDoneMessage"
        Me.lblDoneMessage.Size = New System.Drawing.Size(182, 23)
        Me.lblDoneMessage.TabIndex = 8
        Me.lblDoneMessage.Text = "Enjoy your breakfast"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(372, 465)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 33)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Breakfast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(701, 500)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblDoneMessage)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picFood2)
        Me.Controls.Add(Me.picFood1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectBreakfast)
        Me.Controls.Add(Me.btnFood2)
        Me.Controls.Add(Me.btnFood1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Breakfast"
        Me.Text = "Breakfast"
        CType(Me.picFood1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFood2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnFood1 As Button
    Friend WithEvents btnFood2 As Button
    Friend WithEvents btnSelectBreakfast As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picFood1 As PictureBox
    Friend WithEvents picFood2 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblDoneMessage As Label
    Friend WithEvents btnNext As Button
End Class
