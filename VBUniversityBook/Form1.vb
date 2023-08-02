' University Book App
' Wed, Aug. 2, 2023
' By Simon S. Peters

Public Class Form1
    ' Declare model-level variables and constants
    Private totalQuantity As Integer
    Private totalSales As Decimal

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub computeButton_Click(sender As Object, e As EventArgs) Handles computeButton.Click
        Try
            ' Input 

            ' Declares constants
            ' 7.25 percent sale tax rate
            Const SALES_TAX_RATE As Single = 0.0725


            ' Declare variables 
            Dim priceDecimal As Decimal
            Dim quantityInteger As Integer
            Dim subTotal As Decimal
            Dim salesTax As Decimal
            Dim totalDue As Decimal

            ' Declare variables and Convert values from textbox controls to memory
            priceDecimal = Decimal.Parse(priceTextBox.Text, Globalization.NumberStyles.Currency)
            quantityInteger = Integer.Parse(quantityTextBox.Text, Globalization.NumberStyles.Number)

            ' Process - Compute values
            ' SubTotal = price * quantity of books
            subTotal = priceDecimal * quantityInteger

            ' Sales Tax = Sub Total *times sales tax rate
            salesTax = Decimal.Round(Convert.ToDecimal(subTotal * SALES_TAX_RATE), 2)

            ' Total Due = Sub Total plus sales tax
            totalDue = subTotal + salesTax

            ' Display output, formatted as currency
            subTotalTextBox.Text = subTotal.ToString("C")
            salesTaxTextBox.Text = salesTax.ToString("N")
            totalDueTextBox.Text = totalDue.ToString("C")

            ' Disable/Enable buttons
            computeButton.Enabled = False
            ResetButton.Enabled = True

            ' Accumulate Total Sales and Total Quantity
            totalQuantity += quantityInteger
            totalSales += totalDue

        Catch ex As Exception
            MessageBox.Show("Enter correct Price and Quantity values", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            quantityTextBox.Focus()
            priceTextBox.Focus()

        End Try

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' Clear All TextBox values
        bookTitleTextBox.Clear()
        isbnTextBox.Clear()
        priceTextBox.Clear()
        quantityTextBox.Clear()
        subTotalTextBox.Clear()
        salesTaxTextBox.Clear()
        totalDueTextBox.Clear()

        'Enable Compute button
        computeButton.Enabled = True
        ResetButton.Enabled = False
        ' Set focus to book title Textbox
        bookTitleTextBox.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() ' to close form
    End Sub

    Private Sub TotalsButton_Click(sender As Object, e As EventArgs) Handles TotalsButton.Click
        Try
            ' display total sales, total books sold, and average book value in msgbox
            Dim averaeSales As Decimal
            averaeSales = totalSales / totalQuantity

            ' total message string to display when totals button is clicked
            Dim totalsMessage As String = "Book Title: " & bookTitleTextBox.Text & ControlChars.NewLine &
                "ISBN: " & isbnTextBox.Text & ControlChars.NewLine &
                "Total Sales: " & totalSales.ToString("C") & ControlChars.NewLine &
                "Total Quantity: " & totalQuantity.ToString() & ControlChars.NewLine &
                "Average Book price: " & averaeSales.ToString("C")
            MessageBox.Show(totalsMessage, "Totals & Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch exArithmeticException As ArithmeticException
            MessageBox.Show("No books sold yet", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unknown error", "System error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
