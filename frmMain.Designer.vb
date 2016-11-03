<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.cbNumGuest = New System.Windows.Forms.ComboBox()
        Me.lblNumGuest = New System.Windows.Forms.Label()
        Me.lblNumRoom = New System.Windows.Forms.Label()
        Me.cbNumRoom = New System.Windows.Forms.ComboBox()
        Me.dpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.mbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnFindCustomer = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbNumGuest
        '
        Me.cbNumGuest.FormattingEnabled = True
        Me.cbNumGuest.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbNumGuest.Location = New System.Drawing.Point(41, 195)
        Me.cbNumGuest.Name = "cbNumGuest"
        Me.cbNumGuest.Size = New System.Drawing.Size(100, 21)
        Me.cbNumGuest.TabIndex = 4
        Me.cbNumGuest.Text = "0"
        '
        'lblNumGuest
        '
        Me.lblNumGuest.AutoSize = True
        Me.lblNumGuest.Location = New System.Drawing.Point(41, 178)
        Me.lblNumGuest.Name = "lblNumGuest"
        Me.lblNumGuest.Size = New System.Drawing.Size(87, 13)
        Me.lblNumGuest.TabIndex = 1
        Me.lblNumGuest.Text = "Number of Guest"
        '
        'lblNumRoom
        '
        Me.lblNumRoom.AutoSize = True
        Me.lblNumRoom.Location = New System.Drawing.Point(41, 220)
        Me.lblNumRoom.Name = "lblNumRoom"
        Me.lblNumRoom.Size = New System.Drawing.Size(92, 13)
        Me.lblNumRoom.TabIndex = 3
        Me.lblNumRoom.Text = "Number of Rooms"
        '
        'cbNumRoom
        '
        Me.cbNumRoom.FormattingEnabled = True
        Me.cbNumRoom.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbNumRoom.Location = New System.Drawing.Point(41, 237)
        Me.cbNumRoom.Name = "cbNumRoom"
        Me.cbNumRoom.Size = New System.Drawing.Size(100, 21)
        Me.cbNumRoom.TabIndex = 5
        Me.cbNumRoom.Text = "0"
        '
        'dpCheckIn
        '
        Me.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpCheckIn.Location = New System.Drawing.Point(159, 35)
        Me.dpCheckIn.MinDate = New Date(2016, 3, 1, 0, 0, 0, 0)
        Me.dpCheckIn.Name = "dpCheckIn"
        Me.dpCheckIn.Size = New System.Drawing.Size(102, 20)
        Me.dpCheckIn.TabIndex = 6
        Me.dpCheckIn.Value = New Date(2016, 3, 1, 21, 37, 0, 0)
        '
        'dpCheckOut
        '
        Me.dpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpCheckOut.Location = New System.Drawing.Point(159, 74)
        Me.dpCheckOut.MinDate = New Date(2016, 3, 3, 0, 0, 0, 0)
        Me.dpCheckOut.Name = "dpCheckOut"
        Me.dpCheckOut.Size = New System.Drawing.Size(102, 20)
        Me.dpCheckOut.TabIndex = 7
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Location = New System.Drawing.Point(159, 19)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(76, 13)
        Me.lblCheckIn.TabIndex = 6
        Me.lblCheckIn.Text = "Check-In Date"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Location = New System.Drawing.Point(159, 58)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(84, 13)
        Me.lblCheckOut.TabIndex = 7
        Me.lblCheckOut.Text = "Check-Out Date"
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(176, 235)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(85, 23)
        Me.btnCheck.TabIndex = 9
        Me.btnCheck.Text = "Find Rooms"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'mbPhoneNumber
        '
        Me.mbPhoneNumber.Location = New System.Drawing.Point(41, 36)
        Me.mbPhoneNumber.Mask = "(000) 000-0000"
        Me.mbPhoneNumber.Name = "mbPhoneNumber"
        Me.mbPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.mbPhoneNumber.TabIndex = 0
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(41, 19)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(41, 136)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 14
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(41, 95)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "First Name"
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(41, 112)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tbFirstName.TabIndex = 2
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(41, 153)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(100, 20)
        Me.tbLastName.TabIndex = 3
        '
        'btnRequest
        '
        Me.btnRequest.Enabled = False
        Me.btnRequest.Location = New System.Drawing.Point(176, 206)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(85, 23)
        Me.btnRequest.TabIndex = 8
        Me.btnRequest.Text = "Request"
        Me.btnRequest.UseVisualStyleBackColor = True
        '
        'btnFindCustomer
        '
        Me.btnFindCustomer.Location = New System.Drawing.Point(49, 62)
        Me.btnFindCustomer.Name = "btnFindCustomer"
        Me.btnFindCustomer.Size = New System.Drawing.Size(85, 23)
        Me.btnFindCustomer.TabIndex = 1
        Me.btnFindCustomer.Text = "Find Customer"
        Me.btnFindCustomer.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 295)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFindCustomer)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.mbPhoneNumber)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.dpCheckOut)
        Me.Controls.Add(Me.dpCheckIn)
        Me.Controls.Add(Me.lblNumRoom)
        Me.Controls.Add(Me.cbNumRoom)
        Me.Controls.Add(Me.lblNumGuest)
        Me.Controls.Add(Me.cbNumGuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Reservation System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbNumGuest As ComboBox
    Friend WithEvents lblNumGuest As Label
    Friend WithEvents lblNumRoom As Label
    Friend WithEvents cbNumRoom As ComboBox
    Friend WithEvents dpCheckIn As DateTimePicker
    Friend WithEvents dpCheckOut As DateTimePicker
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents mbPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents btnRequest As Button
    Friend WithEvents btnFindCustomer As Button
    Friend WithEvents btnClear As Button
End Class
