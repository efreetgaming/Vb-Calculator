<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl4 = New Label()
        Label1 = New Label()
        btnClear = New Button()
        txtScreen = New TextBox()
        btnClearAll = New Button()
        btnBackSpace = New Button()
        btnPlus = New Button()
        btnEqual = New Button()
        btnPoint = New Button()
        btnZero = New Button()
        btnMinus = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        btnThree = New Button()
        btnTwo = New Button()
        btnOne = New Button()
        btnSix = New Button()
        btnFive = New Button()
        btnFour = New Button()
        btnNine = New Button()
        btnEight = New Button()
        btnSeven = New Button()
        lblNumOne = New Label()
        lblNumTwo = New Label()
        lblOperator = New Label()
        SuspendLayout()
        ' 
        ' lbl4
        ' 
        lbl4.Location = New Point(607, 307)
        lbl4.Margin = New Padding(5, 0, 5, 0)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(171, 46)
        lbl4.TabIndex = 51
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 173)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 30)
        Label1.TabIndex = 50
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 25F)
        btnClear.Location = New Point(410, 221)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(189, 164)
        btnClear.TabIndex = 46
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtScreen
        ' 
        txtScreen.Font = New Font("Segoe UI", 45F)
        txtScreen.Location = New Point(19, 39)
        txtScreen.Margin = New Padding(3, 4, 3, 4)
        txtScreen.Name = "txtScreen"
        txtScreen.Size = New Size(770, 147)
        txtScreen.TabIndex = 45
        txtScreen.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Font = New Font("Segoe UI", 25F)
        btnClearAll.Location = New Point(216, 221)
        btnClearAll.Margin = New Padding(3, 4, 3, 4)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(189, 164)
        btnClearAll.TabIndex = 44
        btnClearAll.Text = "CE"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' btnBackSpace
        ' 
        btnBackSpace.Font = New Font("Segoe UI", 25F)
        btnBackSpace.Location = New Point(21, 221)
        btnBackSpace.Margin = New Padding(3, 4, 3, 4)
        btnBackSpace.Name = "btnBackSpace"
        btnBackSpace.Size = New Size(189, 164)
        btnBackSpace.TabIndex = 43
        btnBackSpace.Text = "⌫"
        btnBackSpace.UseVisualStyleBackColor = True
        ' 
        ' btnPlus
        ' 
        btnPlus.Font = New Font("Segoe UI", 25F)
        btnPlus.Location = New Point(605, 897)
        btnPlus.Margin = New Padding(3, 4, 3, 4)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(189, 164)
        btnPlus.TabIndex = 42
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Font = New Font("Segoe UI", 25F)
        btnEqual.Location = New Point(410, 897)
        btnEqual.Margin = New Padding(3, 4, 3, 4)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(189, 164)
        btnEqual.TabIndex = 41
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' btnPoint
        ' 
        btnPoint.Font = New Font("Segoe UI", 25F)
        btnPoint.Location = New Point(216, 897)
        btnPoint.Margin = New Padding(3, 4, 3, 4)
        btnPoint.Name = "btnPoint"
        btnPoint.Size = New Size(189, 164)
        btnPoint.TabIndex = 40
        btnPoint.Text = "."
        btnPoint.UseVisualStyleBackColor = True
        ' 
        ' btnZero
        ' 
        btnZero.Font = New Font("Segoe UI", 25F)
        btnZero.Location = New Point(21, 897)
        btnZero.Margin = New Padding(3, 4, 3, 4)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(189, 164)
        btnZero.TabIndex = 39
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = True
        ' 
        ' btnMinus
        ' 
        btnMinus.Font = New Font("Segoe UI", 25F)
        btnMinus.Location = New Point(605, 729)
        btnMinus.Margin = New Padding(3, 4, 3, 4)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(189, 164)
        btnMinus.TabIndex = 38
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Segoe UI", 25F)
        btnMultiply.Location = New Point(605, 561)
        btnMultiply.Margin = New Padding(3, 4, 3, 4)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(189, 164)
        btnMultiply.TabIndex = 37
        btnMultiply.Text = "X"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Segoe UI", 25F)
        btnDivide.Location = New Point(605, 391)
        btnDivide.Margin = New Padding(3, 4, 3, 4)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(189, 164)
        btnDivide.TabIndex = 36
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Font = New Font("Segoe UI", 25F)
        btnThree.Location = New Point(410, 729)
        btnThree.Margin = New Padding(3, 4, 3, 4)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(189, 164)
        btnThree.TabIndex = 35
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Font = New Font("Segoe UI", 25F)
        btnTwo.Location = New Point(216, 729)
        btnTwo.Margin = New Padding(3, 4, 3, 4)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(189, 164)
        btnTwo.TabIndex = 34
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnOne
        ' 
        btnOne.Font = New Font("Segoe UI", 25F)
        btnOne.Location = New Point(21, 729)
        btnOne.Margin = New Padding(3, 4, 3, 4)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(189, 164)
        btnOne.TabIndex = 33
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnSix
        ' 
        btnSix.Font = New Font("Segoe UI", 25F)
        btnSix.Location = New Point(410, 561)
        btnSix.Margin = New Padding(3, 4, 3, 4)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(189, 164)
        btnSix.TabIndex = 32
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Font = New Font("Segoe UI", 25F)
        btnFive.Location = New Point(216, 561)
        btnFive.Margin = New Padding(3, 4, 3, 4)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(189, 164)
        btnFive.TabIndex = 31
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Font = New Font("Segoe UI", 25F)
        btnFour.Location = New Point(21, 561)
        btnFour.Margin = New Padding(3, 4, 3, 4)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(189, 164)
        btnFour.TabIndex = 30
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnNine
        ' 
        btnNine.Font = New Font("Segoe UI", 25F)
        btnNine.Location = New Point(410, 391)
        btnNine.Margin = New Padding(3, 4, 3, 4)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(189, 164)
        btnNine.TabIndex = 29
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = True
        ' 
        ' btnEight
        ' 
        btnEight.Font = New Font("Segoe UI", 25F)
        btnEight.Location = New Point(216, 391)
        btnEight.Margin = New Padding(3, 4, 3, 4)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(189, 164)
        btnEight.TabIndex = 28
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = True
        ' 
        ' btnSeven
        ' 
        btnSeven.Font = New Font("Segoe UI", 25F)
        btnSeven.Location = New Point(21, 391)
        btnSeven.Margin = New Padding(3, 4, 3, 4)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(189, 164)
        btnSeven.TabIndex = 27
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = True
        ' 
        ' lblNumOne
        ' 
        lblNumOne.Location = New Point(21, 23)
        lblNumOne.Margin = New Padding(5, 0, 5, 0)
        lblNumOne.Name = "lblNumOne"
        lblNumOne.Size = New Size(171, 46)
        lblNumOne.TabIndex = 47
        ' 
        ' lblNumTwo
        ' 
        lblNumTwo.Location = New Point(21, 99)
        lblNumTwo.Margin = New Padding(5, 0, 5, 0)
        lblNumTwo.Name = "lblNumTwo"
        lblNumTwo.Size = New Size(171, 46)
        lblNumTwo.TabIndex = 48
        ' 
        ' lblOperator
        ' 
        lblOperator.Location = New Point(233, 23)
        lblOperator.Margin = New Padding(5, 0, 5, 0)
        lblOperator.Name = "lblOperator"
        lblOperator.Size = New Size(171, 46)
        lblOperator.TabIndex = 49
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(813, 1084)
        Controls.Add(lbl4)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(txtScreen)
        Controls.Add(btnClearAll)
        Controls.Add(btnBackSpace)
        Controls.Add(btnPlus)
        Controls.Add(btnEqual)
        Controls.Add(btnPoint)
        Controls.Add(btnZero)
        Controls.Add(btnMinus)
        Controls.Add(btnMultiply)
        Controls.Add(btnDivide)
        Controls.Add(btnThree)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(btnSix)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnNine)
        Controls.Add(btnEight)
        Controls.Add(btnSeven)
        Controls.Add(lblNumOne)
        Controls.Add(lblNumTwo)
        Controls.Add(lblOperator)
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtScreen As TextBox
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents lblNumOne As Label
    Friend WithEvents lblNumTwo As Label
    Friend WithEvents lblOperator As Label

End Class
