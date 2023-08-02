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
        btnClickhere = New Button()
        lblHelloWorld = New Label()
        BtnSurname = New Button()
        lblSurname = New Label()
        Label2 = New Label()
        BtnOtherNames = New Button()
        lblOtherNames = New Label()
        SuspendLayout()
        ' 
        ' btnClickhere
        ' 
        btnClickhere.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnClickhere.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClickhere.ForeColor = Color.White
        btnClickhere.Location = New Point(32, 121)
        btnClickhere.Name = "btnClickhere"
        btnClickhere.Size = New Size(151, 51)
        btnClickhere.TabIndex = 0
        btnClickhere.Text = "Click here"
        btnClickhere.UseVisualStyleBackColor = False
        ' 
        ' lblHelloWorld
        ' 
        lblHelloWorld.AutoSize = True
        lblHelloWorld.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblHelloWorld.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblHelloWorld.Location = New Point(308, 130)
        lblHelloWorld.Name = "lblHelloWorld"
        lblHelloWorld.Size = New Size(50, 25)
        lblHelloWorld.TabIndex = 1
        lblHelloWorld.Text = "@@"
        ' 
        ' BtnSurname
        ' 
        BtnSurname.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnSurname.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSurname.ForeColor = Color.White
        BtnSurname.Location = New Point(32, 192)
        BtnSurname.Name = "BtnSurname"
        BtnSurname.Size = New Size(210, 51)
        BtnSurname.TabIndex = 2
        BtnSurname.Text = "Show Surname"
        BtnSurname.UseVisualStyleBackColor = False
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblSurname.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblSurname.Location = New Point(308, 206)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(50, 25)
        lblSurname.TabIndex = 3
        lblSurname.Text = "@@"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(32, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 30)
        Label2.TabIndex = 4
        Label2.Text = "Click Buttons to Show Output"
        ' 
        ' BtnOtherNames
        ' 
        BtnOtherNames.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnOtherNames.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnOtherNames.ForeColor = Color.White
        BtnOtherNames.Location = New Point(32, 261)
        BtnOtherNames.Name = "BtnOtherNames"
        BtnOtherNames.Size = New Size(210, 51)
        BtnOtherNames.TabIndex = 5
        BtnOtherNames.Text = "Show other names"
        BtnOtherNames.UseVisualStyleBackColor = False
        ' 
        ' lblOtherNames
        ' 
        lblOtherNames.AutoSize = True
        lblOtherNames.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblOtherNames.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        lblOtherNames.Location = New Point(308, 275)
        lblOtherNames.Name = "lblOtherNames"
        lblOtherNames.Size = New Size(50, 25)
        lblOtherNames.TabIndex = 6
        lblOtherNames.Text = "@@"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(769, 450)
        Controls.Add(lblOtherNames)
        Controls.Add(BtnOtherNames)
        Controls.Add(Label2)
        Controls.Add(lblSurname)
        Controls.Add(BtnSurname)
        Controls.Add(lblHelloWorld)
        Controls.Add(btnClickhere)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickhere As Button
    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents BtnSurname As Button
    Friend WithEvents lblSurname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOtherNames As Button
    Friend WithEvents lblOtherNames As Label
End Class
