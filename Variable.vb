Imports System.Data.SqlClient

Module Variable

    Function getDate()
        Return DateTime.UtcNow
    End Function

    Dim sqlConnection As New SqlConnection("Data Source=sdf1.zapto.org, 49170;Initial Catalog=HRS;Persist Security Info=True;User ID=sa;Password=Abc123")

    Function openSQLConnection()
        sqlConnection.Open()
        Return vbNull
    End Function

    Function readQuery(ByVal query As String)
        Dim cmd As New SqlCommand
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection
        Return cmd.ExecuteReader()
    End Function

    Function closeSQLConnection()
        sqlConnection.Close()
        Return vbNull
    End Function

    Public Property boolisNew() As Boolean
    Dim isNotClear As Boolean = True
    Public Property boolisNotClear() As Boolean
        Get
            Return isNotClear
        End Get
        Set(value As Boolean)
            If value = False Then
                isNotClear = False
            End If
        End Set
    End Property
    Public Property strFirstName() As String
    Public Property strLastName() As String
    Public Property strPhoneNumber() As String
    Public Property dtCheckIn() As Date
    Public Property dtCheckOut() As Date
    Public Property intDuration() As Integer
    Public Property intNumGuest() As Integer
    Public Property intNumRoom() As Integer
    Public Property strBedType() As String
    Public Property intRoomNumber() As Integer
    Public Property intPrice() As Integer
    Public Property strRoomLocation() As String
    Public Property boolRollawayBed() As Boolean
    Public Property boolCrib() As Boolean
    Public Property boolNearElevator() As Boolean
    Public Property boolEarlyCheckIn() As Boolean
    Public Property boolExtraTowels() As Boolean
    Public Property strPaymentMethod() As String
    Public Property strCreditCard() As String
    Public Property strConfirmation() As String

End Module
