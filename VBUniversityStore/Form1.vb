Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' To close form or application
        Me.Close()
    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        ' INPUT
        ' Declare constants
        Const SalesTaxRate As Decimal = 0.0725

        ' Declare variables
        Dim price As Decimal
        Dim quantity As Integer
        Dim subtotal As Decimal
        Dim salestax As Decimal
        Dim TotalDue As Decimal


        ' Converting values from textbox controls to memory variables
        price = Decimal.Parse(priceTextBox.Text, Globalization.NumberStyles.Currency)
        quantity = Integer.Parse(quantityTextBox.Text, Globalization.NumberStyles.Number)

        ' Process - Computing value
        ' Subtotal = quantity times price
        subtotal = quantity * price

        ' sales tax = sales tax rate times the subtotal minus discount amount
        salestax = SalesTaxRate * subtotal

        'Total due is the subtotal minus discount amount plus sales tax 
        TotalDue = subtotal + salestax

        ' Output - To display computed values in their textboxes
        subTotalTextBox.Text = subtotal.ToString("C")
        salesTaxTextBox.Text = salestax.ToString("C")
        totalDueTextBox.Text = TotalDue.ToString("C")

        'Enable/Disable Button
        'disabling compute button when you click compute
        ComputeButton.Enabled = False

        'enabling reset button when compute button is clicked
        ResetButton.Enabled = True


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetButton.Enabled = False ' to disable reset button when clicked
        'reset button to clear all the textboxes values

        bookTitleTextBox.Clear()
        isbnTextBox.Clear()
        priceTextBox.Clear()
        quantityTextBox.Clear()
        subTotalTextBox.Clear()
        salesTaxTextBox.Clear()
        totalDueTextBox.Clear()

        'enabling compute button back when reset button is clicked
        ComputeButton.Enabled = True
    End Sub
End Class
