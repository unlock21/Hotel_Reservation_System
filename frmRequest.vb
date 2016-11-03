Imports HRS.Variable

Public Class frmRequest
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        getRequest()
    End Sub

    Private Sub frmRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setRequest()
    End Sub

    Function getRequest()
        If cbBed.Text = "No Preference" Then
            strBedType = "%"
        Else
            strBedType = cbBed.Text
        End If
        If cbLocation.Text = "No Preference" Then
            strRoomLocation = "%"
        Else
            strRoomLocation = cbLocation.Text
        End If
        boolRollawayBed = lbOptions.GetItemCheckState(0)
        boolCrib = lbOptions.GetItemCheckState(1)
        boolNearElevator = lbOptions.GetItemCheckState(2)
        boolEarlyCheckIn = lbOptions.GetItemCheckState(3)
        boolExtraTowels = lbOptions.GetItemCheckState(4)
        Me.Close()
        Return vbNull
    End Function

    Function setRequest()
        If strBedType = "%" Or strBedType = "" Then
            cbBed.Text = "No Preference"
        Else
            cbBed.Text = strBedType
        End If
        If strRoomLocation = "%" Or strRoomLocation = "" Then
            cbLocation.Text = "No Preference"
        Else
            cbLocation.Text = strRoomLocation
        End If
        If boolRollawayBed Then
            lbOptions.SetItemCheckState(0, CheckState.Checked)
        End If
        If boolCrib Then
            lbOptions.SetItemCheckState(1, CheckState.Checked)
        End If
        If boolNearElevator Then
            lbOptions.SetItemCheckState(2, CheckState.Checked)
        End If
        If boolEarlyCheckIn Then
            lbOptions.SetItemCheckState(3, CheckState.Checked)
        End If
        If boolExtraTowels Then
            lbOptions.SetItemCheckState(4, CheckState.Checked)
        End If
        Return vbNull
    End Function

End Class