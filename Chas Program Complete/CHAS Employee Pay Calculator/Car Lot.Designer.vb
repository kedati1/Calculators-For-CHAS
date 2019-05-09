<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLot
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
        Me.lblTitleCarLot = New System.Windows.Forms.Label()
        Me.cmdExitCar = New System.Windows.Forms.Button()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdMainMenu = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtStartPrice = New System.Windows.Forms.TextBox()
        Me.lblStartPrice = New System.Windows.Forms.Label()
        Me.lblCarMileage = New System.Windows.Forms.Label()
        Me.lblMileageYes = New System.Windows.Forms.Label()
        Me.lblMileageNo = New System.Windows.Forms.Label()
        Me.rdoMileageYes = New System.Windows.Forms.RadioButton()
        Me.rdoMileageNo = New System.Windows.Forms.RadioButton()
        Me.lblCarMOT = New System.Windows.Forms.Label()
        Me.lblCarMOTYes = New System.Windows.Forms.Label()
        Me.lblCarMOTNo = New System.Windows.Forms.Label()
        Me.rdoMOTYes = New System.Windows.Forms.RadioButton()
        Me.rdoMOTNo = New System.Windows.Forms.RadioButton()
        Me.lblLogBook = New System.Windows.Forms.Label()
        Me.lblLogBookYes = New System.Windows.Forms.Label()
        Me.lblLogBookNo = New System.Windows.Forms.Label()
        Me.rdoLogBookYes = New System.Windows.Forms.RadioButton()
        Me.rdoLogBookNo = New System.Windows.Forms.RadioButton()
        Me.lblDepreciatedPrice = New System.Windows.Forms.Label()
        Me.txtDepreciatedPrice = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.txtFinalPrice = New System.Windows.Forms.TextBox()
        Me.grpRdoMileage = New System.Windows.Forms.GroupBox()
        Me.grpRdoMOT = New System.Windows.Forms.GroupBox()
        Me.grpRdoLogBook = New System.Windows.Forms.GroupBox()
        Me.grpRdoMileage.SuspendLayout()
        Me.grpRdoMOT.SuspendLayout()
        Me.grpRdoLogBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitleCarLot
        '
        Me.lblTitleCarLot.AutoSize = True
        Me.lblTitleCarLot.BackColor = System.Drawing.Color.White
        Me.lblTitleCarLot.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCarLot.Location = New System.Drawing.Point(243, 28)
        Me.lblTitleCarLot.Name = "lblTitleCarLot"
        Me.lblTitleCarLot.Size = New System.Drawing.Size(239, 31)
        Me.lblTitleCarLot.TabIndex = 1
        Me.lblTitleCarLot.Text = "Chas's Used Car Lot"
        '
        'cmdExitCar
        '
        Me.cmdExitCar.BackColor = System.Drawing.Color.Black
        Me.cmdExitCar.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitCar.ForeColor = System.Drawing.Color.White
        Me.cmdExitCar.Location = New System.Drawing.Point(612, 52)
        Me.cmdExitCar.Name = "cmdExitCar"
        Me.cmdExitCar.Size = New System.Drawing.Size(75, 30)
        Me.cmdExitCar.TabIndex = 2
        Me.cmdExitCar.Text = "Exit"
        Me.cmdExitCar.UseVisualStyleBackColor = False
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Black
        Me.cmdCalculate.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.White
        Me.cmdCalculate.Location = New System.Drawing.Point(323, 247)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(96, 30)
        Me.cmdCalculate.TabIndex = 3
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'cmdMainMenu
        '
        Me.cmdMainMenu.BackColor = System.Drawing.Color.Black
        Me.cmdMainMenu.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMainMenu.ForeColor = System.Drawing.Color.White
        Me.cmdMainMenu.Location = New System.Drawing.Point(612, 428)
        Me.cmdMainMenu.Name = "cmdMainMenu"
        Me.cmdMainMenu.Size = New System.Drawing.Size(96, 55)
        Me.cmdMainMenu.TabIndex = 4
        Me.cmdMainMenu.Text = "Return to Menu"
        Me.cmdMainMenu.UseVisualStyleBackColor = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Black
        Me.lblYear.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(40, 75)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(150, 22)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year of Registration"
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(64, 112)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 29)
        Me.txtYear.TabIndex = 6
        '
        'txtStartPrice
        '
        Me.txtStartPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartPrice.Location = New System.Drawing.Point(64, 184)
        Me.txtStartPrice.Name = "txtStartPrice"
        Me.txtStartPrice.Size = New System.Drawing.Size(100, 29)
        Me.txtStartPrice.TabIndex = 7
        '
        'lblStartPrice
        '
        Me.lblStartPrice.AutoSize = True
        Me.lblStartPrice.BackColor = System.Drawing.Color.Black
        Me.lblStartPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartPrice.ForeColor = System.Drawing.Color.White
        Me.lblStartPrice.Location = New System.Drawing.Point(40, 159)
        Me.lblStartPrice.Name = "lblStartPrice"
        Me.lblStartPrice.Size = New System.Drawing.Size(138, 22)
        Me.lblStartPrice.TabIndex = 8
        Me.lblStartPrice.Text = "Original Car Price"
        '
        'lblCarMileage
        '
        Me.lblCarMileage.AutoSize = True
        Me.lblCarMileage.BackColor = System.Drawing.Color.Black
        Me.lblCarMileage.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMileage.ForeColor = System.Drawing.Color.White
        Me.lblCarMileage.Location = New System.Drawing.Point(12, 234)
        Me.lblCarMileage.Name = "lblCarMileage"
        Me.lblCarMileage.Size = New System.Drawing.Size(244, 22)
        Me.lblCarMileage.TabIndex = 10
        Me.lblCarMileage.Text = "Does the Car Have High Mileage?"
        '
        'lblMileageYes
        '
        Me.lblMileageYes.AutoSize = True
        Me.lblMileageYes.BackColor = System.Drawing.Color.Black
        Me.lblMileageYes.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileageYes.ForeColor = System.Drawing.Color.White
        Me.lblMileageYes.Location = New System.Drawing.Point(60, 266)
        Me.lblMileageYes.Name = "lblMileageYes"
        Me.lblMileageYes.Size = New System.Drawing.Size(35, 22)
        Me.lblMileageYes.TabIndex = 11
        Me.lblMileageYes.Text = "Yes"
        '
        'lblMileageNo
        '
        Me.lblMileageNo.AutoSize = True
        Me.lblMileageNo.BackColor = System.Drawing.Color.Black
        Me.lblMileageNo.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMileageNo.ForeColor = System.Drawing.Color.White
        Me.lblMileageNo.Location = New System.Drawing.Point(164, 266)
        Me.lblMileageNo.Name = "lblMileageNo"
        Me.lblMileageNo.Size = New System.Drawing.Size(32, 22)
        Me.lblMileageNo.TabIndex = 12
        Me.lblMileageNo.Text = "No"
        '
        'rdoMileageYes
        '
        Me.rdoMileageYes.AutoSize = True
        Me.rdoMileageYes.Location = New System.Drawing.Point(18, 12)
        Me.rdoMileageYes.Name = "rdoMileageYes"
        Me.rdoMileageYes.Size = New System.Drawing.Size(14, 13)
        Me.rdoMileageYes.TabIndex = 13
        Me.rdoMileageYes.TabStop = True
        Me.rdoMileageYes.UseVisualStyleBackColor = True
        '
        'rdoMileageNo
        '
        Me.rdoMileageNo.AutoSize = True
        Me.rdoMileageNo.Location = New System.Drawing.Point(123, 11)
        Me.rdoMileageNo.Name = "rdoMileageNo"
        Me.rdoMileageNo.Size = New System.Drawing.Size(14, 13)
        Me.rdoMileageNo.TabIndex = 14
        Me.rdoMileageNo.TabStop = True
        Me.rdoMileageNo.UseVisualStyleBackColor = True
        '
        'lblCarMOT
        '
        Me.lblCarMOT.AutoSize = True
        Me.lblCarMOT.BackColor = System.Drawing.Color.Black
        Me.lblCarMOT.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMOT.ForeColor = System.Drawing.Color.White
        Me.lblCarMOT.Location = New System.Drawing.Point(12, 322)
        Me.lblCarMOT.Name = "lblCarMOT"
        Me.lblCarMOT.Size = New System.Drawing.Size(285, 22)
        Me.lblCarMOT.TabIndex = 15
        Me.lblCarMOT.Text = "Does the Car have an MOT Certificate?"
        '
        'lblCarMOTYes
        '
        Me.lblCarMOTYes.AutoSize = True
        Me.lblCarMOTYes.BackColor = System.Drawing.Color.Black
        Me.lblCarMOTYes.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMOTYes.ForeColor = System.Drawing.Color.White
        Me.lblCarMOTYes.Location = New System.Drawing.Point(60, 361)
        Me.lblCarMOTYes.Name = "lblCarMOTYes"
        Me.lblCarMOTYes.Size = New System.Drawing.Size(35, 22)
        Me.lblCarMOTYes.TabIndex = 16
        Me.lblCarMOTYes.Text = "Yes"
        '
        'lblCarMOTNo
        '
        Me.lblCarMOTNo.AutoSize = True
        Me.lblCarMOTNo.BackColor = System.Drawing.Color.Black
        Me.lblCarMOTNo.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarMOTNo.ForeColor = System.Drawing.Color.White
        Me.lblCarMOTNo.Location = New System.Drawing.Point(164, 361)
        Me.lblCarMOTNo.Name = "lblCarMOTNo"
        Me.lblCarMOTNo.Size = New System.Drawing.Size(32, 22)
        Me.lblCarMOTNo.TabIndex = 17
        Me.lblCarMOTNo.Text = "No"
        '
        'rdoMOTYes
        '
        Me.rdoMOTYes.AutoSize = True
        Me.rdoMOTYes.Location = New System.Drawing.Point(25, 11)
        Me.rdoMOTYes.Name = "rdoMOTYes"
        Me.rdoMOTYes.Size = New System.Drawing.Size(14, 13)
        Me.rdoMOTYes.TabIndex = 18
        Me.rdoMOTYes.TabStop = True
        Me.rdoMOTYes.UseVisualStyleBackColor = True
        '
        'rdoMOTNo
        '
        Me.rdoMOTNo.AutoSize = True
        Me.rdoMOTNo.Location = New System.Drawing.Point(129, 11)
        Me.rdoMOTNo.Name = "rdoMOTNo"
        Me.rdoMOTNo.Size = New System.Drawing.Size(14, 13)
        Me.rdoMOTNo.TabIndex = 19
        Me.rdoMOTNo.TabStop = True
        Me.rdoMOTNo.UseVisualStyleBackColor = True
        '
        'lblLogBook
        '
        Me.lblLogBook.AutoSize = True
        Me.lblLogBook.BackColor = System.Drawing.Color.Black
        Me.lblLogBook.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogBook.ForeColor = System.Drawing.Color.White
        Me.lblLogBook.Location = New System.Drawing.Point(34, 421)
        Me.lblLogBook.Name = "lblLogBook"
        Me.lblLogBook.Size = New System.Drawing.Size(241, 22)
        Me.lblLogBook.TabIndex = 20
        Me.lblLogBook.Text = "Is there a Log Book with the Car?"
        '
        'lblLogBookYes
        '
        Me.lblLogBookYes.AutoSize = True
        Me.lblLogBookYes.BackColor = System.Drawing.Color.Black
        Me.lblLogBookYes.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogBookYes.ForeColor = System.Drawing.Color.White
        Me.lblLogBookYes.Location = New System.Drawing.Point(60, 459)
        Me.lblLogBookYes.Name = "lblLogBookYes"
        Me.lblLogBookYes.Size = New System.Drawing.Size(35, 22)
        Me.lblLogBookYes.TabIndex = 21
        Me.lblLogBookYes.Text = "Yes"
        '
        'lblLogBookNo
        '
        Me.lblLogBookNo.AutoSize = True
        Me.lblLogBookNo.BackColor = System.Drawing.Color.Black
        Me.lblLogBookNo.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogBookNo.ForeColor = System.Drawing.Color.White
        Me.lblLogBookNo.Location = New System.Drawing.Point(169, 459)
        Me.lblLogBookNo.Name = "lblLogBookNo"
        Me.lblLogBookNo.Size = New System.Drawing.Size(32, 22)
        Me.lblLogBookNo.TabIndex = 22
        Me.lblLogBookNo.Text = "No"
        '
        'rdoLogBookYes
        '
        Me.rdoLogBookYes.AutoSize = True
        Me.rdoLogBookYes.Location = New System.Drawing.Point(17, 11)
        Me.rdoLogBookYes.Name = "rdoLogBookYes"
        Me.rdoLogBookYes.Size = New System.Drawing.Size(14, 13)
        Me.rdoLogBookYes.TabIndex = 23
        Me.rdoLogBookYes.TabStop = True
        Me.rdoLogBookYes.UseVisualStyleBackColor = True
        '
        'rdoLogBookNo
        '
        Me.rdoLogBookNo.AutoSize = True
        Me.rdoLogBookNo.Location = New System.Drawing.Point(128, 10)
        Me.rdoLogBookNo.Name = "rdoLogBookNo"
        Me.rdoLogBookNo.Size = New System.Drawing.Size(14, 13)
        Me.rdoLogBookNo.TabIndex = 24
        Me.rdoLogBookNo.TabStop = True
        Me.rdoLogBookNo.UseVisualStyleBackColor = True
        '
        'lblDepreciatedPrice
        '
        Me.lblDepreciatedPrice.AutoSize = True
        Me.lblDepreciatedPrice.BackColor = System.Drawing.Color.Black
        Me.lblDepreciatedPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepreciatedPrice.ForeColor = System.Drawing.Color.White
        Me.lblDepreciatedPrice.Location = New System.Drawing.Point(449, 208)
        Me.lblDepreciatedPrice.Name = "lblDepreciatedPrice"
        Me.lblDepreciatedPrice.Size = New System.Drawing.Size(136, 22)
        Me.lblDepreciatedPrice.TabIndex = 25
        Me.lblDepreciatedPrice.Text = "Depreciated Price"
        '
        'txtDepreciatedPrice
        '
        Me.txtDepreciatedPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepreciatedPrice.Location = New System.Drawing.Point(591, 205)
        Me.txtDepreciatedPrice.Name = "txtDepreciatedPrice"
        Me.txtDepreciatedPrice.Size = New System.Drawing.Size(148, 29)
        Me.txtDepreciatedPrice.TabIndex = 26
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.BackColor = System.Drawing.Color.Black
        Me.lblFinalPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.ForeColor = System.Drawing.Color.White
        Me.lblFinalPrice.Location = New System.Drawing.Point(417, 288)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(168, 22)
        Me.lblFinalPrice.TabIndex = 27
        Me.lblFinalPrice.Text = "Final Discounted Price"
        '
        'txtFinalPrice
        '
        Me.txtFinalPrice.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalPrice.Location = New System.Drawing.Point(591, 285)
        Me.txtFinalPrice.Name = "txtFinalPrice"
        Me.txtFinalPrice.Size = New System.Drawing.Size(148, 29)
        Me.txtFinalPrice.TabIndex = 28
        '
        'grpRdoMileage
        '
        Me.grpRdoMileage.Controls.Add(Me.rdoMileageNo)
        Me.grpRdoMileage.Controls.Add(Me.rdoMileageYes)
        Me.grpRdoMileage.Location = New System.Drawing.Point(52, 287)
        Me.grpRdoMileage.Name = "grpRdoMileage"
        Me.grpRdoMileage.Size = New System.Drawing.Size(160, 30)
        Me.grpRdoMileage.TabIndex = 30
        Me.grpRdoMileage.TabStop = False
        '
        'grpRdoMOT
        '
        Me.grpRdoMOT.Controls.Add(Me.rdoMOTNo)
        Me.grpRdoMOT.Controls.Add(Me.rdoMOTYes)
        Me.grpRdoMOT.Location = New System.Drawing.Point(44, 388)
        Me.grpRdoMOT.Name = "grpRdoMOT"
        Me.grpRdoMOT.Size = New System.Drawing.Size(160, 30)
        Me.grpRdoMOT.TabIndex = 31
        Me.grpRdoMOT.TabStop = False
        '
        'grpRdoLogBook
        '
        Me.grpRdoLogBook.Controls.Add(Me.rdoLogBookNo)
        Me.grpRdoLogBook.Controls.Add(Me.rdoLogBookYes)
        Me.grpRdoLogBook.Location = New System.Drawing.Point(52, 484)
        Me.grpRdoLogBook.Name = "grpRdoLogBook"
        Me.grpRdoLogBook.Size = New System.Drawing.Size(160, 30)
        Me.grpRdoLogBook.TabIndex = 32
        Me.grpRdoLogBook.TabStop = False
        '
        'frmCarLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(759, 525)
        Me.Controls.Add(Me.grpRdoLogBook)
        Me.Controls.Add(Me.grpRdoMOT)
        Me.Controls.Add(Me.grpRdoMileage)
        Me.Controls.Add(Me.txtFinalPrice)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.txtDepreciatedPrice)
        Me.Controls.Add(Me.lblDepreciatedPrice)
        Me.Controls.Add(Me.lblLogBookNo)
        Me.Controls.Add(Me.lblLogBookYes)
        Me.Controls.Add(Me.lblLogBook)
        Me.Controls.Add(Me.lblCarMOTNo)
        Me.Controls.Add(Me.lblCarMOTYes)
        Me.Controls.Add(Me.lblCarMOT)
        Me.Controls.Add(Me.lblMileageNo)
        Me.Controls.Add(Me.lblMileageYes)
        Me.Controls.Add(Me.lblCarMileage)
        Me.Controls.Add(Me.lblStartPrice)
        Me.Controls.Add(Me.txtStartPrice)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmdMainMenu)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.cmdExitCar)
        Me.Controls.Add(Me.lblTitleCarLot)
        Me.Name = "frmCarLot"
        Me.Text = " Chas's Used Car Lot"
        Me.grpRdoMileage.ResumeLayout(False)
        Me.grpRdoMileage.PerformLayout()
        Me.grpRdoMOT.ResumeLayout(False)
        Me.grpRdoMOT.PerformLayout()
        Me.grpRdoLogBook.ResumeLayout(False)
        Me.grpRdoLogBook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitleCarLot As System.Windows.Forms.Label
    Friend WithEvents cmdExitCar As System.Windows.Forms.Button
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents cmdMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtStartPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblStartPrice As System.Windows.Forms.Label
    Friend WithEvents lblCarMileage As System.Windows.Forms.Label
    Friend WithEvents lblMileageYes As System.Windows.Forms.Label
    Friend WithEvents lblMileageNo As System.Windows.Forms.Label
    Friend WithEvents rdoMileageYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMileageNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblCarMOT As System.Windows.Forms.Label
    Friend WithEvents lblCarMOTYes As System.Windows.Forms.Label
    Friend WithEvents lblCarMOTNo As System.Windows.Forms.Label
    Friend WithEvents rdoMOTYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMOTNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblLogBook As System.Windows.Forms.Label
    Friend WithEvents lblLogBookYes As System.Windows.Forms.Label
    Friend WithEvents lblLogBookNo As System.Windows.Forms.Label
    Friend WithEvents rdoLogBookYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLogBookNo As System.Windows.Forms.RadioButton
    Friend WithEvents lblDepreciatedPrice As System.Windows.Forms.Label
    Friend WithEvents txtDepreciatedPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalPrice As System.Windows.Forms.Label
    Friend WithEvents txtFinalPrice As System.Windows.Forms.TextBox
    Friend WithEvents grpRdoMileage As System.Windows.Forms.GroupBox
    Friend WithEvents grpRdoMOT As System.Windows.Forms.GroupBox
    Friend WithEvents grpRdoLogBook As System.Windows.Forms.GroupBox
End Class
