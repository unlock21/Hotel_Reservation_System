Imports System.Data.SqlClient
Imports HRS.frmRequest


Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Minimum Value as Today for CheckIn
        dpCheckIn.MinDate = DateTime.Today.ToShortDateString
    End Sub

    Private Sub dpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dpCheckIn.ValueChanged
        ' Set Minimum Value Based on dpCheckIn for CheckOut
        ' Defaulting to a 1 night stay
        dpCheckOut.MinDate = dpCheckIn.Value.AddDays(1)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        For Each Control In Me.Controls
            If Control.Text = "" Then
                boolisNotClear = False
            End If
        Next
        If boolisNotClear = True Then
            strFirstName = tbFirstName.Text
            strLastName = tbLastName.Text
            strPhoneNumber = mbPhoneNumber.Text
            intNumGuest = cbNumGuest.Text
            intNumRoom = cbNumRoom.Text
            dtCheckIn = dpCheckIn.Value
            dtCheckOut = dpCheckOut.Value
            Dim Difference As Double = ((dtCheckOut.ToFileTime) - (dtCheckIn.ToFileTime))
            intDuration = (Date.FromFileTime(Difference).DayOfYear)

            ' Close frmRequest if open
            frmRequest.btnSubmit.PerformClick()

            ' Check for Guest Number
            If intNumGuest = 0 Then
                MsgBox("Please select more than 0 guests before moving on.")
            Else
                frmRoomSelector.Show()
            End If

            ' Check for Room Number
            If intNumRoom = 0 Then
                MsgBox("Please select more than 0 rooms before moving on.")
            Else
                frmRoomSelector.Show()
            End If
        End If

    End Sub

    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click
        getCustomer()
        setCustomer()
    End Sub

    Private Sub mbPhoneNumber_Validated(sender As Object, e As EventArgs) Handles mbPhoneNumber.Validated
        getCustomer()
        setCustomer()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        frmRequest.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCustomer()
    End Sub

    Function clearCustomer()
        ' Gets customer data for DB ID 1 and sets | Empty Object
        mbPhoneNumber.Text = "(111) 111-1111"
        getCustomer()
        setCustomer()
        mbPhoneNumber.Clear()

        intPrice = 0
        intRoomNumber = 0

        ' Reset Check In/Out
        dpCheckIn.MinDate = DateTime.Today.ToShortDateString
        dpCheckIn.Text = DateTime.Today.ToShortDateString
        dpCheckOut.MinDate = dpCheckIn.Value.AddDays(1)
        dpCheckOut.Text = dpCheckIn.Value.AddDays(1)

        mbPhoneNumber.Focus()
        Return vbNull
    End Function

    Function getCustomer()
        openSQLConnection()
        Dim reader As SqlDataReader = readQuery("SELECT FirstName, LastName, NumberofGuest, NumberofRoom, BedType, RoomLocation, RollawayBed, Crib, NearElevator, EarlyCheckIn, ExtraTowels, PaymentMethod, CreditCardNumber, NumberofNight, PhoneNumber FROM HRS.dbo.Customer_T1 WHERE Customer_T1.PhoneNumber='" & mbPhoneNumber.Text & "'")
        boolisNew = True
        Do While reader.Read()
            If mbPhoneNumber.Text = reader.GetString(14) Then
                strFirstName = reader.GetString(0).Trim()
                strLastName = reader.GetString(1).Trim()
                intNumGuest = reader.GetInt32(2)
                intNumRoom = reader.GetInt32(3)
                strBedType = reader.GetString(4)
                strRoomLocation = reader.GetString(5).Trim()
                boolRollawayBed = reader.GetBoolean(6)
                boolCrib = reader.GetBoolean(7)
                boolNearElevator = reader.GetBoolean(8)
                boolEarlyCheckIn = reader.GetBoolean(9)
                boolExtraTowels = reader.GetBoolean(10)
                strPaymentMethod = reader.GetString(11)
                If strPaymentMethod.ToLower() Like "*Card*" Then
                    strCreditCard = reader.GetString(12)
                End If
                intDuration = reader.GetSqlInt32(13)
                boolisNew = False
            End If
        Loop
        reader.Close()
        closeSQLConnection()
        If boolisNew = True Then
            strBedType = "%"
            strRoomLocation = "%"
        End If
        btnRequest.Enabled = True
        btnCheck.Enabled = True
        dpCheckOut.MinDate = dpCheckIn.Value.AddDays(intDuration)
        Return vbNull
    End Function

    Function setCustomer()
        tbFirstName.Text = strFirstName
        tbLastName.Text = strLastName
        cbNumGuest.Text = intNumGuest
        cbNumRoom.Text = intNumRoom
        Return vbNull
    End Function
End Class
