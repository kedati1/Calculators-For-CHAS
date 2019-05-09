Public Class frmMenu

    Private Sub cmdExitMenu_Click(sender As Object, e As EventArgs) Handles cmdExitMenu.Click
        End
    End Sub

    Private Sub cmdCarLot_Click(sender As Object, e As EventArgs) Handles cmdCarLot.Click
        'Displays Car Lot Program and hides the Navigation Menu
        frmCarLot.Show()
        Me.Hide()
    End Sub

    Private Sub cmdEmployeeCalculator_Click(sender As Object, e As EventArgs) Handles cmdEmployeeCalculator.Click
        'Displays the Employee Calculator Program and hides the Navigation Menu
        frmEmployeeCalc.Show()
        Me.Hide()
    End Sub
End Class