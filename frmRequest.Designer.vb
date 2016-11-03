<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequest
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
        Me.gbRoomPref = New System.Windows.Forms.GroupBox()
        Me.cbLocation = New System.Windows.Forms.ComboBox()
        Me.lbOptions = New System.Windows.Forms.CheckedListBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.cbBed = New System.Windows.Forms.ComboBox()
        Me.lblBed = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.gbRoomPref.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRoomPref
        '
        Me.gbRoomPref.Controls.Add(Me.cbLocation)
        Me.gbRoomPref.Controls.Add(Me.lbOptions)
        Me.gbRoomPref.Controls.Add(Me.lblLocation)
        Me.gbRoomPref.Controls.Add(Me.cbBed)
        Me.gbRoomPref.Controls.Add(Me.lblBed)
        Me.gbRoomPref.Location = New System.Drawing.Point(43, 15)
        Me.gbRoomPref.Name = "gbRoomPref"
        Me.gbRoomPref.Size = New System.Drawing.Size(142, 205)
        Me.gbRoomPref.TabIndex = 0
        Me.gbRoomPref.TabStop = False
        Me.gbRoomPref.Text = "Room Preference"
        '
        'cbLocation
        '
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.Items.AddRange(New Object() {"No Preference", "Upper Floors", "Lower Floors"})
        Me.cbLocation.Location = New System.Drawing.Point(7, 78)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(121, 21)
        Me.cbLocation.TabIndex = 1
        Me.cbLocation.Text = "No Preference"
        '
        'lbOptions
        '
        Me.lbOptions.FormattingEnabled = True
        Me.lbOptions.Items.AddRange(New Object() {"Rollaway Bed", "Crib", "Near Elevator", "Early Check-In", "Extra Towels"})
        Me.lbOptions.Location = New System.Drawing.Point(7, 105)
        Me.lbOptions.Name = "lbOptions"
        Me.lbOptions.Size = New System.Drawing.Size(120, 94)
        Me.lbOptions.TabIndex = 2
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(7, 61)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(79, 13)
        Me.lblLocation.TabIndex = 2
        Me.lblLocation.Text = "Room Location"
        '
        'cbBed
        '
        Me.cbBed.DisplayMember = "BedType"
        Me.cbBed.FormattingEnabled = True
        Me.cbBed.Items.AddRange(New Object() {"No Preference", "1 King Bed", "2 Queen Beds", "2 Full Beds"})
        Me.cbBed.Location = New System.Drawing.Point(7, 37)
        Me.cbBed.Name = "cbBed"
        Me.cbBed.Size = New System.Drawing.Size(121, 21)
        Me.cbBed.TabIndex = 0
        Me.cbBed.Text = " No Preference"
        Me.cbBed.ValueMember = "BedType"
        '
        'lblBed
        '
        Me.lblBed.AutoSize = True
        Me.lblBed.Location = New System.Drawing.Point(7, 20)
        Me.lblBed.Name = "lblBed"
        Me.lblBed.Size = New System.Drawing.Size(26, 13)
        Me.lblBed.TabIndex = 0
        Me.lblBed.Text = "Bed"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(77, 226)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmRequest
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 265)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.gbRoomPref)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRequest"
        Me.ShowIcon = False
        Me.Text = "Request"
        Me.gbRoomPref.ResumeLayout(False)
        Me.gbRoomPref.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbRoomPref As GroupBox
    Friend WithEvents lbOptions As CheckedListBox
    Friend WithEvents cbBed As ComboBox
    Friend WithEvents lblBed As Label
    Friend WithEvents cbLocation As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnSubmit As Button
End Class
