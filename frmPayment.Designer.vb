<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayment
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
        Me.gbCard = New System.Windows.Forms.GroupBox()
        Me.lblCSV = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.tbCardName = New System.Windows.Forms.TextBox()
        Me.lblNameOnCard = New System.Windows.Forms.Label()
        Me.mbCSV = New System.Windows.Forms.MaskedTextBox()
        Me.mbCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.gbPaymentMethod = New System.Windows.Forms.GroupBox()
        Me.rbRewardPoints = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbCard = New System.Windows.Forms.RadioButton()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.gbAmount = New System.Windows.Forms.GroupBox()
        Me.lblRoomAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.gbCash = New System.Windows.Forms.GroupBox()
        Me.mbCashAmount = New System.Windows.Forms.MaskedTextBox()
        Me.lblCashAmount = New System.Windows.Forms.Label()
        Me.gbMembership = New System.Windows.Forms.GroupBox()
        Me.mbMemberID = New System.Windows.Forms.MaskedTextBox()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.gbCard.SuspendLayout()
        Me.gbPaymentMethod.SuspendLayout()
        Me.gbAmount.SuspendLayout()
        Me.gbCash.SuspendLayout()
        Me.gbMembership.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCard
        '
        Me.gbCard.Controls.Add(Me.lblCSV)
        Me.gbCard.Controls.Add(Me.lblCardNumber)
        Me.gbCard.Controls.Add(Me.tbCardName)
        Me.gbCard.Controls.Add(Me.lblNameOnCard)
        Me.gbCard.Controls.Add(Me.mbCSV)
        Me.gbCard.Controls.Add(Me.mbCardNumber)
        Me.gbCard.Enabled = False
        Me.gbCard.Location = New System.Drawing.Point(169, 12)
        Me.gbCard.Name = "gbCard"
        Me.gbCard.Size = New System.Drawing.Size(200, 126)
        Me.gbCard.TabIndex = 0
        Me.gbCard.TabStop = False
        Me.gbCard.Text = "Credit Card / Debit Card"
        '
        'lblCSV
        '
        Me.lblCSV.AutoSize = True
        Me.lblCSV.Location = New System.Drawing.Point(154, 65)
        Me.lblCSV.Name = "lblCSV"
        Me.lblCSV.Size = New System.Drawing.Size(28, 13)
        Me.lblCSV.TabIndex = 5
        Me.lblCSV.Text = "CSV"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(6, 65)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(69, 13)
        Me.lblCardNumber.TabIndex = 4
        Me.lblCardNumber.Text = "Card Number"
        '
        'tbCardName
        '
        Me.tbCardName.Location = New System.Drawing.Point(6, 33)
        Me.tbCardName.Name = "tbCardName"
        Me.tbCardName.Size = New System.Drawing.Size(167, 20)
        Me.tbCardName.TabIndex = 3
        '
        'lblNameOnCard
        '
        Me.lblNameOnCard.AutoSize = True
        Me.lblNameOnCard.Location = New System.Drawing.Point(6, 16)
        Me.lblNameOnCard.Name = "lblNameOnCard"
        Me.lblNameOnCard.Size = New System.Drawing.Size(75, 13)
        Me.lblNameOnCard.TabIndex = 2
        Me.lblNameOnCard.Text = "Name on Card"
        '
        'mbCSV
        '
        Me.mbCSV.Location = New System.Drawing.Point(157, 81)
        Me.mbCSV.Mask = "###"
        Me.mbCSV.Name = "mbCSV"
        Me.mbCSV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(94)
        Me.mbCSV.Size = New System.Drawing.Size(33, 20)
        Me.mbCSV.TabIndex = 1
        '
        'mbCardNumber
        '
        Me.mbCardNumber.Location = New System.Drawing.Point(9, 81)
        Me.mbCardNumber.Mask = "#### #### #### ####"
        Me.mbCardNumber.Name = "mbCardNumber"
        Me.mbCardNumber.Size = New System.Drawing.Size(142, 20)
        Me.mbCardNumber.TabIndex = 0
        '
        'gbPaymentMethod
        '
        Me.gbPaymentMethod.Controls.Add(Me.rbRewardPoints)
        Me.gbPaymentMethod.Controls.Add(Me.rbCash)
        Me.gbPaymentMethod.Controls.Add(Me.rbCard)
        Me.gbPaymentMethod.Location = New System.Drawing.Point(12, 12)
        Me.gbPaymentMethod.Name = "gbPaymentMethod"
        Me.gbPaymentMethod.Size = New System.Drawing.Size(151, 100)
        Me.gbPaymentMethod.TabIndex = 1
        Me.gbPaymentMethod.TabStop = False
        Me.gbPaymentMethod.Text = "Select Payment Method"
        '
        'rbRewardPoints
        '
        Me.rbRewardPoints.AutoSize = True
        Me.rbRewardPoints.Location = New System.Drawing.Point(7, 66)
        Me.rbRewardPoints.Name = "rbRewardPoints"
        Me.rbRewardPoints.Size = New System.Drawing.Size(99, 17)
        Me.rbRewardPoints.TabIndex = 2
        Me.rbRewardPoints.TabStop = True
        Me.rbRewardPoints.Text = "Rewards Points"
        Me.rbRewardPoints.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(6, 43)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(49, 17)
        Me.rbCash.TabIndex = 1
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "Cash"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbCard
        '
        Me.rbCard.AutoSize = True
        Me.rbCard.Location = New System.Drawing.Point(7, 20)
        Me.rbCard.Name = "rbCard"
        Me.rbCard.Size = New System.Drawing.Size(113, 17)
        Me.rbCard.TabIndex = 0
        Me.rbCard.TabStop = True
        Me.rbCard.Text = "Credit / Debit Card"
        Me.rbCard.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(11, 219)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(151, 65)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'gbAmount
        '
        Me.gbAmount.Controls.Add(Me.lblRoomAmount)
        Me.gbAmount.Controls.Add(Me.lblTaxAmount)
        Me.gbAmount.Controls.Add(Me.lblTotal)
        Me.gbAmount.Location = New System.Drawing.Point(11, 119)
        Me.gbAmount.Name = "gbAmount"
        Me.gbAmount.Size = New System.Drawing.Size(152, 94)
        Me.gbAmount.TabIndex = 3
        Me.gbAmount.TabStop = False
        Me.gbAmount.Text = "Amount:"
        '
        'lblRoomAmount
        '
        Me.lblRoomAmount.AutoSize = True
        Me.lblRoomAmount.Location = New System.Drawing.Point(6, 18)
        Me.lblRoomAmount.Name = "lblRoomAmount"
        Me.lblRoomAmount.Size = New System.Drawing.Size(38, 13)
        Me.lblRoomAmount.TabIndex = 2
        Me.lblRoomAmount.Text = "Room:"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Location = New System.Drawing.Point(6, 41)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(28, 13)
        Me.lblTaxAmount.TabIndex = 1
        Me.lblTaxAmount.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(7, 64)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(37, 13)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total: "
        '
        'gbCash
        '
        Me.gbCash.Controls.Add(Me.mbCashAmount)
        Me.gbCash.Controls.Add(Me.lblCashAmount)
        Me.gbCash.Enabled = False
        Me.gbCash.Location = New System.Drawing.Point(169, 145)
        Me.gbCash.Name = "gbCash"
        Me.gbCash.Size = New System.Drawing.Size(200, 68)
        Me.gbCash.TabIndex = 1
        Me.gbCash.TabStop = False
        Me.gbCash.Text = "Cash Sale"
        '
        'mbCashAmount
        '
        Me.mbCashAmount.Location = New System.Drawing.Point(6, 36)
        Me.mbCashAmount.Mask = "$"
        Me.mbCashAmount.Name = "mbCashAmount"
        Me.mbCashAmount.Size = New System.Drawing.Size(118, 20)
        Me.mbCashAmount.TabIndex = 5
        '
        'lblCashAmount
        '
        Me.lblCashAmount.AutoSize = True
        Me.lblCashAmount.Location = New System.Drawing.Point(9, 20)
        Me.lblCashAmount.Name = "lblCashAmount"
        Me.lblCashAmount.Size = New System.Drawing.Size(70, 13)
        Me.lblCashAmount.TabIndex = 0
        Me.lblCashAmount.Text = "Cash Amount"
        '
        'gbMembership
        '
        Me.gbMembership.Controls.Add(Me.mbMemberID)
        Me.gbMembership.Controls.Add(Me.lblMemberID)
        Me.gbMembership.Enabled = False
        Me.gbMembership.Location = New System.Drawing.Point(169, 220)
        Me.gbMembership.Name = "gbMembership"
        Me.gbMembership.Size = New System.Drawing.Size(200, 64)
        Me.gbMembership.TabIndex = 2
        Me.gbMembership.TabStop = False
        Me.gbMembership.Text = "Rewards Points"
        '
        'mbMemberID
        '
        Me.mbMemberID.Location = New System.Drawing.Point(6, 32)
        Me.mbMemberID.Mask = "####-###-####-##"
        Me.mbMemberID.Name = "mbMemberID"
        Me.mbMemberID.Size = New System.Drawing.Size(118, 20)
        Me.mbMemberID.TabIndex = 9
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Location = New System.Drawing.Point(9, 16)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(72, 13)
        Me.lblMemberID.TabIndex = 8
        Me.lblMemberID.Text = "Memership ID"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 297)
        Me.Controls.Add(Me.gbMembership)
        Me.Controls.Add(Me.gbCash)
        Me.Controls.Add(Me.gbAmount)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.gbPaymentMethod)
        Me.Controls.Add(Me.gbCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayment"
        Me.ShowIcon = False
        Me.Text = "Payment"
        Me.gbCard.ResumeLayout(False)
        Me.gbCard.PerformLayout()
        Me.gbPaymentMethod.ResumeLayout(False)
        Me.gbPaymentMethod.PerformLayout()
        Me.gbAmount.ResumeLayout(False)
        Me.gbAmount.PerformLayout()
        Me.gbCash.ResumeLayout(False)
        Me.gbCash.PerformLayout()
        Me.gbMembership.ResumeLayout(False)
        Me.gbMembership.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCard As GroupBox
    Friend WithEvents lblCSV As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents tbCardName As TextBox
    Friend WithEvents lblNameOnCard As Label
    Friend WithEvents mbCSV As MaskedTextBox
    Friend WithEvents mbCardNumber As MaskedTextBox
    Friend WithEvents gbPaymentMethod As GroupBox
    Friend WithEvents rbRewardPoints As RadioButton
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbCard As RadioButton
    Friend WithEvents btnCheckout As Button
    Friend WithEvents gbAmount As GroupBox
    Friend WithEvents lblRoomAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents gbCash As GroupBox
    Friend WithEvents mbCashAmount As MaskedTextBox
    Friend WithEvents lblCashAmount As Label
    Friend WithEvents gbMembership As GroupBox
    Friend WithEvents mbMemberID As MaskedTextBox
    Friend WithEvents lblMemberID As Label
End Class
