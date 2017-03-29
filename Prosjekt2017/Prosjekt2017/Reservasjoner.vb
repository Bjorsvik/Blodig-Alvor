Public Class Reservasjoner

    Dim db As New Database()
    Dim ansatt As New Ansatt()
    Dim blodgiver As New Blodgiver()


    Public Sub getGjeldendeReservasjoner()
        db.Query("SELECT * from Reservasjoner WHERE dato >= GETDATE()")
    End Sub

    Public Function getAlleReservasjoner() As DataTable
        Return db.Query("SELECT * from Reservasjoner")
    End Function
    Public Function getLastResID() As DataTable
        Return db.Query("SELECT MAX(resID) FROM Reservasjon")
    End Function

    Public Sub reserver(ByVal Dato As String, ByVal personID As Integer)

        Dim resID As DataTable = getLastResID()
        Dim reservasjonID As String = ""


        For Each id In resID.Rows
            reservasjonID = id(0).ToString()
        Next id

        If reservasjonID = "" Then
            reservasjonID = "0"
        End If

        MsgBox(CInt(reservasjonID))

        db.Query("INSERT INTO Reservasjon (resID, dato, personID) VALUES ('" & CInt(reservasjonID) & "', '" & Dato & "', '" & personID & "');")
    End Sub

End Class
