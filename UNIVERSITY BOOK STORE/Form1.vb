Public Class Form1
    'Module Level Variable
    Private Total_Quantity As Integer
    Private Total_Sales As Decimal

    Private Sub Compute_btn_Click(sender As Object, e As EventArgs) Handles Compute_btn.Click
        Try
            'Input
            'Declare Constant
            '7.25% Sales Tax Rate
            Const Tax_Rate As Decimal = 0.0725

            'Declare Variables and Convert Values From Textbox Controls to Memory Variables
            Dim Price As Decimal
            Dim Quantity As Integer
            Dim Subtotal As Decimal
            Dim SalesTax As Decimal
            Dim Total_due As Decimal

            Price = Decimal.Parse(Price_textbox.Text, Globalization.NumberStyles.Currency)
            Quantity = Integer.Parse(Quantity_textbox.Text, Globalization.NumberStyles.Number)

            'Process- Computing Values
            'Subtotal = Quantity * Price
            Subtotal = Quantity * Price

            'Sales Tax = Subtotal * Tax Rate
            SalesTax = Subtotal * Tax_Rate

            'Total_due = SalesTax + Subtotal
            Total_due = SalesTax + Subtotal

            'Output
            Subtotal_textbox.Text = Subtotal.ToString("C")
            SalesTax_textbox.Text = SalesTax.ToString("C")
            Totaldue_textbox.Text = Total_due.ToString("c")

            'This is to help know the amount of money we have from 
            Total_Quantity = Total_Quantity + Quantity
            Total_Sales = Total_Sales + Total_due


            'Enable/disable btn
            Compute_btn.Enabled = False
            Reset_btn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(
                "You cannot use an alphabet in the Price or Quantity textbox", "Data Entry Error!!",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Price_textbox.Focus()

        End Try

    End Sub

    Private Sub Reset_btn_Click(sender As Object, e As EventArgs) Handles Reset_btn.Click
        Booktitle_textbox.Clear()
        ISBN_textbox.Clear()
        Price_textbox.Clear()
        Quantity_textbox.Clear()
        Subtotal_textbox.Clear()
        SalesTax_textbox.Clear()
        Totaldue_textbox.Clear()
        Compute_btn.Enabled = True
    End Sub

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs) Handles Exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Totals_btn_Click(sender As Object, e As EventArgs) Handles Totals_btn.Click
        Try
            Dim Avg_Sales As Decimal = Total_Sales / Total_Quantity
            Dim Message As String = "Total Sales:" & Total_Sales.ToString("C") &
            ControlChars.NewLine &
            "Average Sales:" & Avg_Sales.ToString("C") &
             ControlChars.NewLine &
            "Total Quantity:" & Total_Quantity.ToString("C")
            MessageBox.Show(Message, "Totals", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch exArithmetic As ArithmeticException
            MessageBox.Show("No books sold yet", "Error!!", MessageBoxButtons.OK)

        Catch ex As Exception
            MessageBox.Show("This is an unknown error", "Error!!", MessageBoxButtons.OK)


        End Try
    End Sub
End Class
