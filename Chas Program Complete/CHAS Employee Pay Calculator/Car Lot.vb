Public Class frmCarLot


    Private Sub cmdMainMenu_Click(sender As Object, e As EventArgs) Handles cmdMainMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub cmdExitCar_Click(sender As Object, e As EventArgs) Handles cmdExitCar.Click
        End
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click

        Dim Yr As Integer
        Dim OPrice As Decimal
        Dim DPrice As Decimal
        Dim FDPrice As Decimal
        Const HighMile As Decimal = 0.9
        Const NoMOT As Decimal = 0.9
        Const NoLogBook As Decimal = 0.8
        Const YrDeduction As Decimal = 0.8
        Const CurrentYear As Decimal = 2018

        'Input defined by the user
        Yr = CInt(txtYear.Text)
        OPrice = CDec(txtStartPrice.Text)
        DPrice = OPrice

        'Depreciation of price based on the Car Age at a rate of 10% per year
        Do While Yr < CurrentYear
            Yr = Yr + 1
            DPrice = DPrice * YrDeduction
        Loop
        FDPrice = DPrice

        'Check list to apply depreciated prices in a compounded order.
        If rdoMileageYes.Checked Then
            FDPrice = FDPrice * HighMile
        End If
        If rdoMOTNo.Checked Then
            FDPrice = FDPrice * NoMOT
        End If
        If rdoLogBookNo.Checked Then
            FDPrice = FDPrice * NoLogBook
        End If
        'Output the Final Depreciated Price (after the compounded discounts are applied)
        'And the output for the Discounted Price after the Car Age has been applied.
        txtFinalPrice.Text = FormatCurrency(FDPrice)
        txtDepreciatedPrice.Text = FormatCurrency(DPrice)
    End Sub
End Class