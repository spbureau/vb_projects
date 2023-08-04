<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TotalsButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.isbnTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.quantityTextBox = New System.Windows.Forms.TextBox()
        Me.subTotalTextBox = New System.Windows.Forms.TextBox()
        Me.salesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalDueTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.totalDueTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.salesTaxTextBox)
        Me.GroupBox1.Controls.Add(Me.subTotalTextBox)
        Me.GroupBox1.Controls.Add(Me.quantityTextBox)
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Controls.Add(Me.isbnTextBox)
        Me.GroupBox1.Controls.Add(Me.bookTitleTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ExitButton)
        Me.GroupBox1.Controls.Add(Me.TotalsButton)
        Me.GroupBox1.Controls.Add(Me.ComputeButton)
        Me.GroupBox1.Controls.Add(Me.ResetButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Textbook Sale Information"
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComputeButton.ForeColor = System.Drawing.Color.Black
        Me.ComputeButton.Location = New System.Drawing.Point(143, 354)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(88, 33)
        Me.ComputeButton.TabIndex = 1
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(276, 354)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 33)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'TotalsButton
        '
        Me.TotalsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalsButton.ForeColor = System.Drawing.Color.Black
        Me.TotalsButton.Location = New System.Drawing.Point(397, 354)
        Me.TotalsButton.Name = "TotalsButton"
        Me.TotalsButton.Size = New System.Drawing.Size(75, 33)
        Me.TotalsButton.TabIndex = 2
        Me.TotalsButton.Text = "&Totals"
        Me.TotalsButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitButton.ForeColor = System.Drawing.Color.Black
        Me.ExitButton.Location = New System.Drawing.Point(512, 354)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 33)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Book Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ISBN (Indentifier):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SubTotal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Sales Tax:"
        '
        'bookTitleTextBox
        '
        Me.bookTitleTextBox.Location = New System.Drawing.Point(143, 45)
        Me.bookTitleTextBox.Name = "bookTitleTextBox"
        Me.bookTitleTextBox.Size = New System.Drawing.Size(242, 27)
        Me.bookTitleTextBox.TabIndex = 10
        '
        'isbnTextBox
        '
        Me.isbnTextBox.Location = New System.Drawing.Point(143, 82)
        Me.isbnTextBox.Name = "isbnTextBox"
        Me.isbnTextBox.Size = New System.Drawing.Size(242, 27)
        Me.isbnTextBox.TabIndex = 11
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(143, 123)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(149, 27)
        Me.priceTextBox.TabIndex = 12
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(143, 166)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(149, 27)
        Me.quantityTextBox.TabIndex = 13
        '
        'subTotalTextBox
        '
        Me.subTotalTextBox.Location = New System.Drawing.Point(143, 213)
        Me.subTotalTextBox.Name = "subTotalTextBox"
        Me.subTotalTextBox.ReadOnly = True
        Me.subTotalTextBox.Size = New System.Drawing.Size(149, 27)
        Me.subTotalTextBox.TabIndex = 15
        '
        'salesTaxTextBox
        '
        Me.salesTaxTextBox.Location = New System.Drawing.Point(143, 264)
        Me.salesTaxTextBox.Name = "salesTaxTextBox"
        Me.salesTaxTextBox.ReadOnly = True
        Me.salesTaxTextBox.Size = New System.Drawing.Size(149, 27)
        Me.salesTaxTextBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total Due:"
        '
        'totalDueTextBox
        '
        Me.totalDueTextBox.Location = New System.Drawing.Point(143, 308)
        Me.totalDueTextBox.Name = "totalDueTextBox"
        Me.totalDueTextBox.ReadOnly = True
        Me.totalDueTextBox.Size = New System.Drawing.Size(149, 27)
        Me.totalDueTextBox.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "University BookStore"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalsButton As Button
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents salesTaxTextBox As TextBox
    Friend WithEvents subTotalTextBox As TextBox
    Friend WithEvents quantityTextBox As TextBox
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents isbnTextBox As TextBox
    Friend WithEvents bookTitleTextBox As TextBox
    Friend WithEvents totalDueTextBox As TextBox
    Friend WithEvents Label8 As Label
End Class
