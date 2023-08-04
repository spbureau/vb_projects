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
        Me.SaleInfoBtn = New System.Windows.Forms.GroupBox()
        Me.Totaldue_textbox = New System.Windows.Forms.TextBox()
        Me.SalesTax_textbox = New System.Windows.Forms.TextBox()
        Me.Subtotal_textbox = New System.Windows.Forms.TextBox()
        Me.Quantity_textbox = New System.Windows.Forms.TextBox()
        Me.Price_textbox = New System.Windows.Forms.TextBox()
        Me.ISBN_textbox = New System.Windows.Forms.TextBox()
        Me.Booktitle_textbox = New System.Windows.Forms.TextBox()
        Me.Totaldue_btn = New System.Windows.Forms.Label()
        Me.SalesTax_btn = New System.Windows.Forms.Label()
        Me.Subtotal_btn = New System.Windows.Forms.Label()
        Me.Quantity_btn = New System.Windows.Forms.Label()
        Me.Price_btn = New System.Windows.Forms.Label()
        Me.ISBN_btn = New System.Windows.Forms.Label()
        Me.Booktitle_btn = New System.Windows.Forms.Label()
        Me.Compute_btn = New System.Windows.Forms.Button()
        Me.Reset_btn = New System.Windows.Forms.Button()
        Me.Totals_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.SaleInfoBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaleInfoBtn
        '
        Me.SaleInfoBtn.Controls.Add(Me.Totaldue_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.SalesTax_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.Subtotal_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.Quantity_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.Price_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.ISBN_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.Booktitle_textbox)
        Me.SaleInfoBtn.Controls.Add(Me.Totaldue_btn)
        Me.SaleInfoBtn.Controls.Add(Me.SalesTax_btn)
        Me.SaleInfoBtn.Controls.Add(Me.Subtotal_btn)
        Me.SaleInfoBtn.Controls.Add(Me.Quantity_btn)
        Me.SaleInfoBtn.Controls.Add(Me.Price_btn)
        Me.SaleInfoBtn.Controls.Add(Me.ISBN_btn)
        Me.SaleInfoBtn.Controls.Add(Me.Booktitle_btn)
        Me.SaleInfoBtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaleInfoBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SaleInfoBtn.Location = New System.Drawing.Point(33, 24)
        Me.SaleInfoBtn.Name = "SaleInfoBtn"
        Me.SaleInfoBtn.Size = New System.Drawing.Size(590, 341)
        Me.SaleInfoBtn.TabIndex = 0
        Me.SaleInfoBtn.TabStop = False
        Me.SaleInfoBtn.Text = "Textbook Sale Information"
        '
        'Totaldue_textbox
        '
        Me.Totaldue_textbox.Location = New System.Drawing.Point(110, 311)
        Me.Totaldue_textbox.Name = "Totaldue_textbox"
        Me.Totaldue_textbox.ReadOnly = True
        Me.Totaldue_textbox.Size = New System.Drawing.Size(302, 23)
        Me.Totaldue_textbox.TabIndex = 13
        '
        'SalesTax_textbox
        '
        Me.SalesTax_textbox.Location = New System.Drawing.Point(110, 255)
        Me.SalesTax_textbox.Name = "SalesTax_textbox"
        Me.SalesTax_textbox.ReadOnly = True
        Me.SalesTax_textbox.Size = New System.Drawing.Size(246, 23)
        Me.SalesTax_textbox.TabIndex = 12
        '
        'Subtotal_textbox
        '
        Me.Subtotal_textbox.Location = New System.Drawing.Point(110, 214)
        Me.Subtotal_textbox.Name = "Subtotal_textbox"
        Me.Subtotal_textbox.ReadOnly = True
        Me.Subtotal_textbox.Size = New System.Drawing.Size(280, 23)
        Me.Subtotal_textbox.TabIndex = 11
        '
        'Quantity_textbox
        '
        Me.Quantity_textbox.Location = New System.Drawing.Point(110, 169)
        Me.Quantity_textbox.Name = "Quantity_textbox"
        Me.Quantity_textbox.Size = New System.Drawing.Size(302, 23)
        Me.Quantity_textbox.TabIndex = 10
        '
        'Price_textbox
        '
        Me.Price_textbox.Location = New System.Drawing.Point(110, 119)
        Me.Price_textbox.Name = "Price_textbox"
        Me.Price_textbox.Size = New System.Drawing.Size(264, 23)
        Me.Price_textbox.TabIndex = 9
        '
        'ISBN_textbox
        '
        Me.ISBN_textbox.Location = New System.Drawing.Point(110, 74)
        Me.ISBN_textbox.Name = "ISBN_textbox"
        Me.ISBN_textbox.Size = New System.Drawing.Size(348, 23)
        Me.ISBN_textbox.TabIndex = 8
        '
        'Booktitle_textbox
        '
        Me.Booktitle_textbox.AcceptsReturn = True
        Me.Booktitle_textbox.Location = New System.Drawing.Point(131, 23)
        Me.Booktitle_textbox.Name = "Booktitle_textbox"
        Me.Booktitle_textbox.Size = New System.Drawing.Size(370, 23)
        Me.Booktitle_textbox.TabIndex = 7
        '
        'Totaldue_btn
        '
        Me.Totaldue_btn.AutoSize = True
        Me.Totaldue_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Totaldue_btn.Location = New System.Drawing.Point(6, 311)
        Me.Totaldue_btn.Name = "Totaldue_btn"
        Me.Totaldue_btn.Size = New System.Drawing.Size(72, 17)
        Me.Totaldue_btn.TabIndex = 6
        Me.Totaldue_btn.Text = "Total Due:"
        '
        'SalesTax_btn
        '
        Me.SalesTax_btn.AutoSize = True
        Me.SalesTax_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.SalesTax_btn.Location = New System.Drawing.Point(6, 258)
        Me.SalesTax_btn.Name = "SalesTax_btn"
        Me.SalesTax_btn.Size = New System.Drawing.Size(68, 17)
        Me.SalesTax_btn.TabIndex = 5
        Me.SalesTax_btn.Text = "Sales Tax:"
        '
        'Subtotal_btn
        '
        Me.Subtotal_btn.AutoSize = True
        Me.Subtotal_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Subtotal_btn.Location = New System.Drawing.Point(6, 214)
        Me.Subtotal_btn.Name = "Subtotal_btn"
        Me.Subtotal_btn.Size = New System.Drawing.Size(63, 17)
        Me.Subtotal_btn.TabIndex = 4
        Me.Subtotal_btn.Text = "Subtotal:"
        '
        'Quantity_btn
        '
        Me.Quantity_btn.AutoSize = True
        Me.Quantity_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Quantity_btn.Location = New System.Drawing.Point(6, 169)
        Me.Quantity_btn.Name = "Quantity_btn"
        Me.Quantity_btn.Size = New System.Drawing.Size(65, 17)
        Me.Quantity_btn.TabIndex = 3
        Me.Quantity_btn.Text = "Quantity:"
        '
        'Price_btn
        '
        Me.Price_btn.AutoSize = True
        Me.Price_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Price_btn.Location = New System.Drawing.Point(18, 119)
        Me.Price_btn.Name = "Price_btn"
        Me.Price_btn.Size = New System.Drawing.Size(41, 17)
        Me.Price_btn.TabIndex = 2
        Me.Price_btn.Text = "Price:"
        '
        'ISBN_btn
        '
        Me.ISBN_btn.AutoSize = True
        Me.ISBN_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ISBN_btn.Location = New System.Drawing.Point(-3, 80)
        Me.ISBN_btn.Name = "ISBN_btn"
        Me.ISBN_btn.Size = New System.Drawing.Size(102, 17)
        Me.ISBN_btn.TabIndex = 1
        Me.ISBN_btn.Text = "ISBN (Identify):"
        '
        'Booktitle_btn
        '
        Me.Booktitle_btn.AutoSize = True
        Me.Booktitle_btn.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Booktitle_btn.Location = New System.Drawing.Point(6, 29)
        Me.Booktitle_btn.Name = "Booktitle_btn"
        Me.Booktitle_btn.Size = New System.Drawing.Size(74, 17)
        Me.Booktitle_btn.TabIndex = 0
        Me.Booktitle_btn.Text = "Book Title:"
        '
        'Compute_btn
        '
        Me.Compute_btn.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compute_btn.Location = New System.Drawing.Point(33, 384)
        Me.Compute_btn.Name = "Compute_btn"
        Me.Compute_btn.Size = New System.Drawing.Size(116, 41)
        Me.Compute_btn.TabIndex = 1
        Me.Compute_btn.Text = "Compute"
        Me.Compute_btn.UseVisualStyleBackColor = True
        '
        'Reset_btn
        '
        Me.Reset_btn.Enabled = False
        Me.Reset_btn.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_btn.Location = New System.Drawing.Point(197, 385)
        Me.Reset_btn.Name = "Reset_btn"
        Me.Reset_btn.Size = New System.Drawing.Size(116, 41)
        Me.Reset_btn.TabIndex = 2
        Me.Reset_btn.Text = "Reset"
        Me.Reset_btn.UseVisualStyleBackColor = True
        '
        'Totals_btn
        '
        Me.Totals_btn.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totals_btn.Location = New System.Drawing.Point(346, 385)
        Me.Totals_btn.Name = "Totals_btn"
        Me.Totals_btn.Size = New System.Drawing.Size(116, 41)
        Me.Totals_btn.TabIndex = 3
        Me.Totals_btn.Text = "Totals"
        Me.Totals_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_btn.Location = New System.Drawing.Point(491, 384)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(116, 41)
        Me.Exit_btn.TabIndex = 4
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(651, 437)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Totals_btn)
        Me.Controls.Add(Me.Reset_btn)
        Me.Controls.Add(Me.Compute_btn)
        Me.Controls.Add(Me.SaleInfoBtn)
        Me.Name = "Form1"
        Me.Text = "VB University Book Store"
        Me.SaleInfoBtn.ResumeLayout(False)
        Me.SaleInfoBtn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaleInfoBtn As GroupBox
    Friend WithEvents Booktitle_btn As Label
    Friend WithEvents Totaldue_btn As Label
    Friend WithEvents SalesTax_btn As Label
    Friend WithEvents Subtotal_btn As Label
    Friend WithEvents Quantity_btn As Label
    Friend WithEvents Price_btn As Label
    Friend WithEvents ISBN_btn As Label
    Friend WithEvents SalesTax_textbox As TextBox
    Friend WithEvents Subtotal_textbox As TextBox
    Friend WithEvents Quantity_textbox As TextBox
    Friend WithEvents Price_textbox As TextBox
    Friend WithEvents ISBN_textbox As TextBox
    Friend WithEvents Booktitle_textbox As TextBox
    Friend WithEvents Totaldue_textbox As TextBox
    Friend WithEvents Compute_btn As Button
    Friend WithEvents Reset_btn As Button
    Friend WithEvents Totals_btn As Button
    Friend WithEvents Exit_btn As Button
End Class
