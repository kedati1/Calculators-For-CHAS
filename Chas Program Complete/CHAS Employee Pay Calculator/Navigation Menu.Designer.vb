<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.lblTitleMenu = New System.Windows.Forms.Label()
        Me.cmdExitMenu = New System.Windows.Forms.Button()
        Me.cmdCarLot = New System.Windows.Forms.Button()
        Me.cmdEmployeeCalculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitleMenu
        '
        Me.lblTitleMenu.AutoSize = True
        Me.lblTitleMenu.BackColor = System.Drawing.Color.White
        Me.lblTitleMenu.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleMenu.Location = New System.Drawing.Point(268, 38)
        Me.lblTitleMenu.Name = "lblTitleMenu"
        Me.lblTitleMenu.Size = New System.Drawing.Size(146, 31)
        Me.lblTitleMenu.TabIndex = 0
        Me.lblTitleMenu.Text = "Main Menu"
        '
        'cmdExitMenu
        '
        Me.cmdExitMenu.BackColor = System.Drawing.Color.Black
        Me.cmdExitMenu.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitMenu.ForeColor = System.Drawing.Color.White
        Me.cmdExitMenu.Location = New System.Drawing.Point(537, 40)
        Me.cmdExitMenu.Name = "cmdExitMenu"
        Me.cmdExitMenu.Size = New System.Drawing.Size(75, 31)
        Me.cmdExitMenu.TabIndex = 1
        Me.cmdExitMenu.Text = "Exit"
        Me.cmdExitMenu.UseVisualStyleBackColor = False
        '
        'cmdCarLot
        '
        Me.cmdCarLot.BackColor = System.Drawing.Color.Black
        Me.cmdCarLot.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCarLot.ForeColor = System.Drawing.Color.White
        Me.cmdCarLot.Location = New System.Drawing.Point(147, 171)
        Me.cmdCarLot.Name = "cmdCarLot"
        Me.cmdCarLot.Size = New System.Drawing.Size(366, 31)
        Me.cmdCarLot.TabIndex = 2
        Me.cmdCarLot.Text = "Used Car Lot Program"
        Me.cmdCarLot.UseVisualStyleBackColor = False
        '
        'cmdEmployeeCalculator
        '
        Me.cmdEmployeeCalculator.BackColor = System.Drawing.Color.Black
        Me.cmdEmployeeCalculator.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmployeeCalculator.ForeColor = System.Drawing.Color.White
        Me.cmdEmployeeCalculator.Location = New System.Drawing.Point(147, 220)
        Me.cmdEmployeeCalculator.Name = "cmdEmployeeCalculator"
        Me.cmdEmployeeCalculator.Size = New System.Drawing.Size(366, 31)
        Me.cmdEmployeeCalculator.TabIndex = 3
        Me.cmdEmployeeCalculator.Text = "Employee Pay Calculator Program"
        Me.cmdEmployeeCalculator.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(650, 389)
        Me.Controls.Add(Me.cmdEmployeeCalculator)
        Me.Controls.Add(Me.cmdCarLot)
        Me.Controls.Add(Me.cmdExitMenu)
        Me.Controls.Add(Me.lblTitleMenu)
        Me.Name = "frmMenu"
        Me.Text = "Navigation_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitleMenu As System.Windows.Forms.Label
    Friend WithEvents cmdExitMenu As System.Windows.Forms.Button
    Friend WithEvents cmdCarLot As System.Windows.Forms.Button
    Friend WithEvents cmdEmployeeCalculator As System.Windows.Forms.Button
End Class
