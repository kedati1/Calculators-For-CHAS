Public Class frmEmployeeCalc

    Private Sub CmdExit_Click(sender As Object, e As EventArgs) Handles CmdExit.Click
        End
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim HoursWorked As Decimal
        Dim AdditionalHoursPay As Decimal
        Dim AdditionalHoursWork As Decimal
        Dim Grosspay As Decimal
        Dim PensionAmount As Decimal
        Dim TaxablePay As Decimal
        Dim Tax As Decimal
        Dim Netpay As Decimal
        Dim Excess As Decimal
        Dim PayPerHour As Decimal

        Const NoTax As Integer = 0
        Const LowerTax As Decimal = 0.25
        Const HigherTax As Decimal = 0.4
        Const PensionValue As Decimal = 0.05
        Const StudentPay As Decimal = 6.5
        Const MechanicPay As Integer = 25
        Const MinderPay As Integer = 38
        Const TaxLawyerPay As Integer = 75
        Const AdditionalMultiplier As Decimal = 1.5
        Const BaseHours As Integer = 40
        Const LowerTaxPayBoundary As Integer = 200
        Const MidTaxPayBoundary As Integer = 600 - 200
        Const HigherTaxPayBoundary As Integer = 600

        'Input  This is the information the user will be adding to the system.
        HoursWorked = CDec(txtHoursWorked.Text)

        If cmboPayGrade.SelectedIndex = 0 Then
            PayPerHour = StudentPay
        ElseIf cmboPayGrade.SelectedIndex = 1 Then
            PayPerHour = MechanicPay
        ElseIf cmboPayGrade.SelectedIndex = 2 Then
            PayPerHour = MinderPay
        ElseIf cmboPayGrade.SelectedIndex = 3 Then
            PayPerHour = TaxLawyerPay
        Else
            MsgBox("Please select a paygrade")
        End If

        'Process  These are the calculations to work out the totals. 
        If HoursWorked > 40 Then
            AdditionalHoursPay = PayPerHour * AdditionalMultiplier
            AdditionalHoursWork = HoursWorked - BaseHours
            Grosspay = PayPerHour * BaseHours + AdditionalHoursPay * AdditionalHoursWork
        Else
            Grosspay = PayPerHour * HoursWorked
        End If
        'Implemented a MsgBox to display an error message if neither button has been selected.
        If rdoYes.Checked Then
            PensionAmount = Grosspay * PensionValue
            TaxablePay = Grosspay - PensionAmount
        ElseIf rdoNo.Checked Then
            PensionAmount = 0
            TaxablePay = Grosspay - PensionAmount
        Else
            MsgBox("Please select whether you want to apply for the pension or not")
        End If

        If TaxablePay < 201 Then
            Tax = NoTax
        ElseIf TaxablePay < 601 Then
            Excess = TaxablePay - LowerTaxPayBoundary
            Tax = LowerTax * Excess
        Else
            Excess = TaxablePay - HigherTaxPayBoundary
            Tax = LowerTax * MidTaxPayBoundary + HigherTax * Excess
        End If
        Netpay = (Grosspay - PensionAmount) - Tax

        'output   The totals being formatted to currency so they can be displayed on the program.
        txtGrossPay.Text = FormatCurrency(Grosspay)
        txtTaxablePay.Text = FormatCurrency(TaxablePay)
        txtPensionTotal.Text = FormatCurrency(PensionAmount)
        txtTaxTotal.Text = FormatCurrency(Tax)
        txtNetPay.Text = FormatCurrency(Netpay)
    End Sub

    Private Sub cmdMainMenu_Click(sender As Object, e As EventArgs) Handles cmdMainMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class
