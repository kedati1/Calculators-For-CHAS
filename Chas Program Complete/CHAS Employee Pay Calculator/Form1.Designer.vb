<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeCalc
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.lblPayGrade = New System.Windows.Forms.Label()
        Me.lblPension = New System.Windows.Forms.Label()
        Me.lblYes = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.lblPensionTotal = New System.Windows.Forms.Label()
        Me.lblTaxable = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblTaxTotal = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtPensionTotal = New System.Windows.Forms.TextBox()
        Me.txtTaxablePay = New System.Windows.Forms.TextBox()
        Me.txtTaxTotal = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.cmboPayGrade = New System.Windows.Forms.ComboBox()
        Me.rdoYes = New System.Windows.Forms.RadioButton()
        Me.rdoNo = New System.Windows.Forms.RadioButton()
        Me.cmdMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Perpetua", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(270, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(257, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Employee Pay Calculator"
        '
        'CmdExit
        '
        Me.CmdExit.BackColor = System.Drawing.Color.Black
        Me.CmdExit.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.Color.White
        Me.CmdExit.Location = New System.Drawing.Point(672, 42)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 30)
        Me.CmdExit.TabIndex = 1
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = False
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.BackColor = System.Drawing.Color.Black
        Me.lblHoursWorked.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursWorked.ForeColor = System.Drawing.Color.White
        Me.lblHoursWorked.Location = New System.Drawing.Point(21, 79)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(236, 22)
        Me.lblHoursWorked.TabIndex = 2
        Me.lblHoursWorked.Text = "Input Hours Worked This Week"
        '
        'lblPayGrade
        '
        Me.lblPayGrade.AutoSize = True
        Me.lblPayGrade.BackColor = System.Drawing.Color.Black
        Me.lblPayGrade.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayGrade.ForeColor = System.Drawing.Color.White
        Me.lblPayGrade.Location = New System.Drawing.Point(70, 156)
        Me.lblPayGrade.Name = "lblPayGrade"
        Me.lblPayGrade.Size = New System.Drawing.Size(128, 22)
        Me.lblPayGrade.TabIndex = 3
        Me.lblPayGrade.Text = "Select Pay Grade"
        '
        'lblPension
        '
        Me.lblPension.AutoSize = True
        Me.lblPension.BackColor = System.Drawing.Color.Black
        Me.lblPension.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPension.ForeColor = System.Drawing.Color.White
        Me.lblPension.Location = New System.Drawing.Point(12, 307)
        Me.lblPension.Name = "lblPension"
        Me.lblPension.Size = New System.Drawing.Size(308, 22)
        Me.lblPension.TabIndex = 4
        Me.lblPension.Text = "Do you want to contribute to the Pension?"
        '
        'lblYes
        '
        Me.lblYes.AutoSize = True
        Me.lblYes.BackColor = System.Drawing.Color.Black
        Me.lblYes.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYes.ForeColor = System.Drawing.Color.White
        Me.lblYes.Location = New System.Drawing.Point(36, 338)
        Me.lblYes.Name = "lblYes"
        Me.lblYes.Size = New System.Drawing.Size(35, 22)
        Me.lblYes.TabIndex = 5
        Me.lblYes.Text = "Yes"
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.BackColor = System.Drawing.Color.Black
        Me.lblNo.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.White
        Me.lblNo.Location = New System.Drawing.Point(177, 338)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(32, 22)
        Me.lblNo.TabIndex = 6
        Me.lblNo.Text = "No"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.Black
        Me.cmdCalculate.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.White
        Me.cmdCalculate.Location = New System.Drawing.Point(343, 213)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(96, 30)
        Me.cmdCalculate.TabIndex = 7
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'lblPensionTotal
        '
        Me.lblPensionTotal.AutoSize = True
        Me.lblPensionTotal.BackColor = System.Drawing.Color.Black
        Me.lblPensionTotal.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPensionTotal.ForeColor = System.Drawing.Color.White
        Me.lblPensionTotal.Location = New System.Drawing.Point(469, 196)
        Me.lblPensionTotal.Name = "lblPensionTotal"
        Me.lblPensionTotal.Size = New System.Drawing.Size(162, 22)
        Me.lblPensionTotal.TabIndex = 8
        Me.lblPensionTotal.Text = "Pension Contribution"
        '
        'lblTaxable
        '
        Me.lblTaxable.AutoSize = True
        Me.lblTaxable.BackColor = System.Drawing.Color.Black
        Me.lblTaxable.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxable.ForeColor = System.Drawing.Color.White
        Me.lblTaxable.Location = New System.Drawing.Point(536, 248)
        Me.lblTaxable.Name = "lblTaxable"
        Me.lblTaxable.Size = New System.Drawing.Size(95, 22)
        Me.lblTaxable.TabIndex = 9
        Me.lblTaxable.Text = "Taxable Pay"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.BackColor = System.Drawing.Color.Black
        Me.lblGrossPay.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.ForeColor = System.Drawing.Color.White
        Me.lblGrossPay.Location = New System.Drawing.Point(552, 144)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(79, 22)
        Me.lblGrossPay.TabIndex = 10
        Me.lblGrossPay.Text = "Gross Pay"
        '
        'lblTaxTotal
        '
        Me.lblTaxTotal.AutoSize = True
        Me.lblTaxTotal.BackColor = System.Drawing.Color.Black
        Me.lblTaxTotal.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxTotal.ForeColor = System.Drawing.Color.White
        Me.lblTaxTotal.Location = New System.Drawing.Point(594, 305)
        Me.lblTaxTotal.Name = "lblTaxTotal"
        Me.lblTaxTotal.Size = New System.Drawing.Size(37, 22)
        Me.lblTaxTotal.TabIndex = 11
        Me.lblTaxTotal.Text = "Tax"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.BackColor = System.Drawing.Color.Black
        Me.lblNetPay.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.ForeColor = System.Drawing.Color.White
        Me.lblNetPay.Location = New System.Drawing.Point(565, 361)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(66, 22)
        Me.lblNetPay.TabIndex = 12
        Me.lblNetPay.Text = "Net Pay"
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursWorked.Location = New System.Drawing.Point(25, 113)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(232, 29)
        Me.txtHoursWorked.TabIndex = 13
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(641, 144)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(147, 29)
        Me.txtGrossPay.TabIndex = 14
        '
        'txtPensionTotal
        '
        Me.txtPensionTotal.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPensionTotal.Location = New System.Drawing.Point(641, 196)
        Me.txtPensionTotal.Name = "txtPensionTotal"
        Me.txtPensionTotal.Size = New System.Drawing.Size(147, 29)
        Me.txtPensionTotal.TabIndex = 15
        '
        'txtTaxablePay
        '
        Me.txtTaxablePay.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxablePay.Location = New System.Drawing.Point(641, 248)
        Me.txtTaxablePay.Name = "txtTaxablePay"
        Me.txtTaxablePay.Size = New System.Drawing.Size(147, 29)
        Me.txtTaxablePay.TabIndex = 16
        '
        'txtTaxTotal
        '
        Me.txtTaxTotal.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxTotal.Location = New System.Drawing.Point(641, 305)
        Me.txtTaxTotal.Name = "txtTaxTotal"
        Me.txtTaxTotal.Size = New System.Drawing.Size(147, 29)
        Me.txtTaxTotal.TabIndex = 17
        '
        'txtNetPay
        '
        Me.txtNetPay.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(641, 361)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(147, 29)
        Me.txtNetPay.TabIndex = 18
        '
        'cmboPayGrade
        '
        Me.cmboPayGrade.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboPayGrade.FormattingEnabled = True
        Me.cmboPayGrade.Items.AddRange(New Object() {"Student", "Mechanic", "Minder", "Tax Lawyer"})
        Me.cmboPayGrade.Location = New System.Drawing.Point(74, 186)
        Me.cmboPayGrade.Name = "cmboPayGrade"
        Me.cmboPayGrade.Size = New System.Drawing.Size(121, 30)
        Me.cmboPayGrade.TabIndex = 19
        '
        'rdoYes
        '
        Me.rdoYes.AutoSize = True
        Me.rdoYes.Location = New System.Drawing.Point(44, 374)
        Me.rdoYes.Name = "rdoYes"
        Me.rdoYes.Size = New System.Drawing.Size(14, 13)
        Me.rdoYes.TabIndex = 20
        Me.rdoYes.TabStop = True
        Me.rdoYes.UseVisualStyleBackColor = True
        '
        'rdoNo
        '
        Me.rdoNo.AutoSize = True
        Me.rdoNo.Location = New System.Drawing.Point(186, 374)
        Me.rdoNo.Name = "rdoNo"
        Me.rdoNo.Size = New System.Drawing.Size(14, 13)
        Me.rdoNo.TabIndex = 21
        Me.rdoNo.TabStop = True
        Me.rdoNo.UseVisualStyleBackColor = True
        '
        'cmdMainMenu
        '
        Me.cmdMainMenu.BackColor = System.Drawing.Color.Black
        Me.cmdMainMenu.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMainMenu.ForeColor = System.Drawing.Color.White
        Me.cmdMainMenu.Location = New System.Drawing.Point(664, 429)
        Me.cmdMainMenu.Name = "cmdMainMenu"
        Me.cmdMainMenu.Size = New System.Drawing.Size(103, 60)
        Me.cmdMainMenu.TabIndex = 22
        Me.cmdMainMenu.Text = "Return to Main Menu"
        Me.cmdMainMenu.UseVisualStyleBackColor = False
        '
        'frmEmployeeCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(791, 501)
        Me.Controls.Add(Me.cmdMainMenu)
        Me.Controls.Add(Me.rdoNo)
        Me.Controls.Add(Me.rdoYes)
        Me.Controls.Add(Me.cmboPayGrade)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtTaxTotal)
        Me.Controls.Add(Me.txtTaxablePay)
        Me.Controls.Add(Me.txtPensionTotal)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblTaxTotal)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblTaxable)
        Me.Controls.Add(Me.lblPensionTotal)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblYes)
        Me.Controls.Add(Me.lblPension)
        Me.Controls.Add(Me.lblPayGrade)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmEmployeeCalc"
        Me.Text = "Employee Pay Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents lblPayGrade As System.Windows.Forms.Label
    Friend WithEvents lblPension As System.Windows.Forms.Label
    Friend WithEvents lblYes As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents lblPensionTotal As System.Windows.Forms.Label
    Friend WithEvents lblTaxable As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblTaxTotal As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents txtPensionTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxablePay As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents cmboPayGrade As System.Windows.Forms.ComboBox
    Friend WithEvents rdoYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNo As System.Windows.Forms.RadioButton
    Friend WithEvents cmdMainMenu As System.Windows.Forms.Button

End Class
