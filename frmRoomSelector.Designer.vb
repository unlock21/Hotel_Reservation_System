<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomSelector
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
        Me.lblRoomSelect = New System.Windows.Forms.Label()
        Me.lvRoomSelect = New System.Windows.Forms.ListView()
        Me.chRoomNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chBedType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNearElevator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRoomSelect
        '
        Me.lblRoomSelect.AutoSize = True
        Me.lblRoomSelect.Location = New System.Drawing.Point(12, 9)
        Me.lblRoomSelect.Name = "lblRoomSelect"
        Me.lblRoomSelect.Size = New System.Drawing.Size(118, 13)
        Me.lblRoomSelect.TabIndex = 1
        Me.lblRoomSelect.Text = "Please select N room(s)"
        '
        'lvRoomSelect
        '
        Me.lvRoomSelect.CheckBoxes = True
        Me.lvRoomSelect.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chRoomNumber, Me.chBedType, Me.chNearElevator, Me.chPrice})
        Me.lvRoomSelect.FullRowSelect = True
        Me.lvRoomSelect.GridLines = True
        Me.lvRoomSelect.Location = New System.Drawing.Point(26, 29)
        Me.lvRoomSelect.Name = "lvRoomSelect"
        Me.lvRoomSelect.Size = New System.Drawing.Size(329, 185)
        Me.lvRoomSelect.TabIndex = 0
        Me.lvRoomSelect.UseCompatibleStateImageBehavior = False
        Me.lvRoomSelect.View = System.Windows.Forms.View.Details
        '
        'chRoomNumber
        '
        Me.chRoomNumber.Text = "Room Number"
        Me.chRoomNumber.Width = 97
        '
        'chBedType
        '
        Me.chBedType.Text = "Bed Type"
        Me.chBedType.Width = 80
        '
        'chNearElevator
        '
        Me.chNearElevator.Text = "Near Elevator"
        Me.chNearElevator.Width = 86
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(268, 229)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(83, 32)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Rooms"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'frmRoomSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 277)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lvRoomSelect)
        Me.Controls.Add(Me.lblRoomSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRoomSelector"
        Me.ShowIcon = False
        Me.Text = "Room Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRoomSelect As Label
    Friend WithEvents lvRoomSelect As ListView
    Friend WithEvents chRoomNumber As ColumnHeader
    Friend WithEvents chBedType As ColumnHeader
    Friend WithEvents chNearElevator As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents btnSelect As Button
End Class
