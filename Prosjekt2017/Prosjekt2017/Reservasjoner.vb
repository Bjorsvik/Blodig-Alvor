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
    Public Function getAlleTidspunkt() As DataTable
        Return db.Query("SELECT * from Tidspunkt")
    End Function
    Public Function getMuligeTidspunkt(ByVal resdato) As DataTable
        Return db.Query("")
    End Function

    Public Sub reserver(ByVal dato As String, ByVal personID As Integer)

        Dim resID As DataTable = getLastResID()
        Dim reservasjonID As String = ""
        Dim nextresID As Integer


        For Each id In resID.Rows
            reservasjonID = id(0).ToString()
        Next id

        If reservasjonID = "" Then
            reservasjonID = "0"
        End If

        nextresID = CInt(reservasjonID) + 1

        'MsgBox(CInt(reservasjonID))

        db.Query("INSERT INTO Reservasjon (resID, dato, personID) VALUES ('" & nextresID & "', '" & dato & "', '" & personID & "');")
    End Sub

End Class
