Imports HRS.Variable
Imports System.Data.SqlClient

Public Class frmRoomSelector

    Private Sub frmRoomSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Convert boolean to int
        Dim intNearElevator As Integer
        If boolNearElevator = False Then
            intNearElevator = 0
        Else
            intNearElevator = 1
        End If

        ' Configure label based on number of rooms selected
        lblRoomSelect.Text = lblRoomSelect.Text.Replace("N", intNumRoom.ToString())

        ' Query SQL for avalible rooms
        openSQLConnection()
        Dim readerUpdate As SqlDataReader = readQuery("UPDATE Room_T1 SET Room_T1.Occupied = 0 FROM Room_T1 LEFT JOIN Customer_T1 ON Room_T1.RoomNumber = Customer_T1.RoomNumber WHERE NOT ('3/11/16' BETWEEN Customer_T1.CheckInDate AND Customer_T1.CheckOutDate)")
        readerUpdate.Close()
        readerUpdate = readQuery("UPDATE Room_T1 SET Room_T1.Occupied = 1 FROM Room_T1 LEFT JOIN Customer_T1 ON Room_T1.RoomNumber = Customer_T1.RoomNumber WHERE ('" & dtCheckIn & "' BETWEEN Customer_T1.CheckInDate AND Customer_T1.CheckOutDate)")
        'Console.WriteLine("UPDATE Room_T1 SET Room_T1.Occupied = 1 FROM Room_T1 LEFT JOIN Customer_T1 ON Room_T1.RoomNumber = Customer_T1.RoomNumber WHERE ('" & dtCheckIn & "' BETWEEN Customer_T1.CheckInDate AND Customer_T1.CheckOutDate)")
        readerUpdate.Close()
        'Console.WriteLine("SELECT Room_T1.RoomNumber, Room_T1.BedType, Room_T1.isNearElevator, Room_T1.Price FROM Room_T1 LEFT JOIN Customer_T1 ON Room_T1.RoomNumber = Customer_T1.RoomNumber WHERE Occupied = 0 AND (Room_T1.isNearElevator = 1 OR Room_T1.isNearElevator = " & intNearElevator & ")")
        Dim reader As SqlDataReader = readQuery("SELECT Room_T1.RoomNumber, Room_T1.BedType, Room_T1.isNearElevator, Room_T1.Price FROM Room_T1 LEFT JOIN Customer_T1 ON Room_T1.RoomNumber = Customer_T1.RoomNumber WHERE Occupied = 0 AND (Room_T1.isNearElevator = 1 OR Room_T1.isNearElevator = " & intNearElevator & ")")
        Do While reader.Read()
            Dim ITEM As New ListViewItem(reader.GetInt32(0))
            ITEM.SubItems.Add(reader.GetString(1).Replace(Chr(34), ""))
            ITEM.SubItems.Add(reader.GetBoolean(2))
            ITEM.SubItems.Add(reader.GetInt32(3))
            lvRoomSelect.Items.Add(ITEM)
        Loop
        reader.Close()
        closeSQLConnection()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If intNumRoom = lvRoomSelect.CheckedIndices.Count Then
            For x As Integer = 0 To lvRoomSelect.CheckedItems.Count - 1
                intRoomNumber = lvRoomSelect.CheckedItems(x).Text ' Room Number
                intPrice += lvRoomSelect.CheckedItems(x).SubItems(3).Text ' Price
            Next
            frmPayment.Show()
            Me.Close()
        ElseIf intNumRoom = 0 Then
            MsgBox("Please select more than 0 on previous window.")
        Else
            MsgBox("Please select only " & intNumRoom & " room(s) or change total on previous window.")
        End If
    End Sub
End Class