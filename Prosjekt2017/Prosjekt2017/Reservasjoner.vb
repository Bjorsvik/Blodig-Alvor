Public Class Reservasjoner

    Dim db As New Database()
    Dim ansatt As New Ansatt()
    Dim blodgiver As New Blodgiver()


    Public Sub oppdater()
        db.Query("DELETE * from Reservasjoner WHERE dato < GETDATE()-1")
    End Sub

    Public Function getAlleReservasjoner() As DataTable
        Return db.Query("SELECT * from Reservasjoner")
    End Function

    Public Sub reserver()

    End Sub

End Class
