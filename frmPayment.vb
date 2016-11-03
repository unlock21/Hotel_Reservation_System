Imports System.Text.RegularExpressions
Imports HRS.Variable
Imports HRS.frmMain

Public Class frmPayment
    Private Sub rbCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbCard.CheckedChanged
        gbCard.Enabled = True
        gbCash.Enabled = False
        gbMembership.Enabled = False

        ' Auto Fill Name and Card On File
        tbCardName.Text = strFirstName + " " + strLastName
        mbCardNumber.Text = strCreditCard
    End Sub

    Private Sub rbCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbCash.CheckedChanged
        gbCard.Enabled = False
        gbCash.Enabled = True
        gbMembership.Enabled = False
    End Sub

    Private Sub rbRewardPoints_CheckedChanged(sender As Object, e As EventArgs) Handles rbRewardPoints.CheckedChanged
        gbCard.Enabled = False
        gbCash.Enabled = False
        gbMembership.Enabled = True
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Total Amount
        Dim doubleTotal As Double = Math.Round(intPrice + (intPrice * 0.075), 2)
        lblRoomAmount.Text = "Room: " & intPrice
        lblTaxAmount.Text = "Tax: " & Math.Round(intPrice * 0.075, 2)
        lblTotal.Text = "Total: " & doubleTotal

        ' Set Cash Mask
        mbCashAmount.Mask = Regex.Replace(lblTotal.Text.Replace("Total: ", "$#"), "[0-9]", "#")

        ' Set Defalt Payment Method
        If strPaymentMethod = "" Then

        ElseIf strPaymentMethod.ToLower Like "*card*" Then
            rbCard.Checked = True
        ElseIf strPaymentMethod.ToLower Like "*cash*" Then
            rbCash.Checked = True
        ElseIf strPaymentMethod.ToLower Like "*memb*" Then
            rbRewardPoints.Checked = True
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Check Input
        If (gbCash.Enabled = False) Or (gbCash.Enabled = True And mbCashAmount.Text.Replace("$", "").Trim() >= lblTotal.Text.Replace("Total: ", "")) Then
            If (gbCard.Enabled = False) Or (gbCard.Enabled = True And mbCardNumber.Text.Length = 19 And mbCSV.Text.Length = 3 And (Not tbCardName.Text = "")) Then
                If (gbMembership.Enabled = False) Or (gbMembership.Enabled = True And mbMemberID.Text.Length = 16) Then
                    ' Store Payment Type
                    If rbCard.Checked = True Then
                        strPaymentMethod = "Card"
                        strCreditCard = mbCardNumber.Text & vbNewLine & "Credit Card Number: " & vbTab & vbTab & strCreditCard
                    ElseIf rbCash.Checked = True Then
                        strPaymentMethod = "Cash"
                        strCreditCard = "NULL"
                    ElseIf rbRewardPoints.Checked = True Then
                        strPaymentMethod = "Member"
                        strCreditCard = "NULL"
                    End If

                    gbCard.Enabled = False
                    gbCash.Enabled = False
                    gbMembership.Enabled = False

                    If strBedType = "%" Then
                        strBedType = "No Preference"
                    End If

                    If strRoomLocation = "%" Then
                        strRoomLocation = "No Preference"
                    End If

                    strConfirmation = MsgBox("First Name: " & vbTab & vbTab & strFirstName & vbNewLine _
                           & "Last Name: " & vbTab & vbTab & strLastName & vbNewLine _
                           & "Phone Number: " & vbTab & vbTab & strPhoneNumber & vbNewLine _
                           & "Number of Guest: " & vbTab & vbTab & intNumGuest & vbNewLine _
                           & "Number of Room(s): " & vbTab & intNumRoom & vbNewLine _
                           & "Number of Night(s): " & vbTab & vbTab & intDuration & vbNewLine _
                           & "Check in Date: " & vbTab & vbTab & dtCheckIn & vbNewLine _
                           & "Check out Date: " & vbTab & vbTab & dtCheckOut & vbNewLine _
                           & "Room Number: " & vbTab & vbTab & intRoomNumber & vbNewLine _
                           & "Bed Type: " & vbTab & vbTab & vbTab & strBedType & vbNewLine _
                           & "Room Location: " & vbTab & vbTab & strRoomLocation & vbNewLine _
                           & "Rollaway Bed: " & vbTab & vbTab & Convert.ToInt32(boolRollawayBed) & vbNewLine _
                           & "Crib: " & vbTab & vbTab & vbTab & Convert.ToInt32(boolCrib) & vbNewLine _
                           & "Near Elevator :" & vbTab & vbTab & Convert.ToInt32(boolNearElevator) & vbNewLine _
                           & "Early Check-In :" & vbTab & vbTab & Convert.ToInt32(boolEarlyCheckIn) & vbNewLine _
                           & "Extra Paper Towels :" & vbTab & vbTab & Convert.ToInt32(boolExtraTowels) & vbNewLine _
                           & "Payment Type: " & vbTab & vbTab & strPaymentMethod, vbYesNo, "Confirmation")

                    If strBedType = "No Preference" Then
                        strBedType = "%"
                    End If

                    If strRoomLocation = "No Preference" Then
                        strRoomLocation = "%"
                    End If

                    If rbCard.Checked = True Then
                        strPaymentMethod = "Card"
                        strCreditCard = mbCardNumber.Text
                    End If

                    strPaymentMethod = "'" & strPaymentMethod & "'"
                    Console.Write(strPaymentMethod)

                    If strConfirmation = "6" Then
                        Console.WriteLine(mbCashAmount.Text.Replace("$", "").Replace(" ", "") - lblTotal.Text.Replace("Total: ", ""))
                        If rbCash.Checked = True Then
                            MsgBox("Change Due: " & (mbCashAmount.Text.Replace("$", "").Replace(" ", "") - lblTotal.Text.Replace("Total: ", "")))
                        End If
                        openSQLConnection()
                        If boolisNew Then
                            readQuery("INSERT INTO HRS.dbo.Customer_T1(Timestamp, FirstName, LastName, PhoneNumber, NumberOfGuest, NumberOfRoom, NumberOfNight, CheckInDate, CheckOutDate, RoomNumber, BedType, RoomLocation, RollawayBed, Crib, NearElevator, EarlyCheckIn, ExtraTowels, PaymentMethod, CreditCardNumber) VALUES(" &
                                  "'" & getDate() & "', '" & strFirstName & "', '" & strLastName & "', '" & strPhoneNumber & "', " & intNumGuest & ", " & intNumRoom & ", " & intDuration & ", '" & dtCheckIn & "', '" & dtCheckOut & "', " & intRoomNumber & ", '" & strBedType & "', '" & strRoomLocation & "', " & Convert.ToInt32(boolRollawayBed) & ", " & Convert.ToInt32(boolCrib) & ", " & Convert.ToInt32(boolNearElevator) & ", " & Convert.ToInt32(boolEarlyCheckIn) & ", " & Convert.ToInt32(boolExtraTowels) & ", " & strPaymentMethod & ", '" & strCreditCard & "')")
                        Else
                            readQuery("Update HRS.dbo.Customer_T1 Set Timestamp = '" & getDate() & "', FirstName = '" & strFirstName & "', LastName = '" & strLastName & "', NumberOfGuest = " & intNumGuest & ", NumberOfRoom = " & intNumRoom & ", NumberOfNight = " & intDuration & ", CheckInDate = '" & dtCheckIn & "', CheckOutDate = '" & dtCheckOut & "', RoomNumber = " & intRoomNumber & ", BedType = '" & strBedType & "', RoomLocation = '" & strRoomLocation & "', RollawayBed = " & Convert.ToInt16(boolRollawayBed) & ", Crib = " & Convert.ToInt16(boolCrib) & ", NearElevator = " & Convert.ToInt16(boolNearElevator) & ", EarlyCheckIn = " & Convert.ToInt16(boolEarlyCheckIn) & ", ExtraTowels = " & Convert.ToInt16(boolExtraTowels) & ", PaymentMethod = " & strPaymentMethod & ", CreditCardNumber = '" & strCreditCard & "' WHERE PhoneNumber = '" & strPhoneNumber & "'")
                        End If
                        closeSQLConnection()
                        frmMain.clearCustomer()
                        frmMain.ActiveForm.Focus()
                        Me.Close()
                    End If
                End If
                End If
        End If
    End Sub
End Class