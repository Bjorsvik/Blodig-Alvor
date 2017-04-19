Public Class Ansatt
    Dim db As New Database
    Dim Abrukernavn = PubVar.ansattBruker

    Public Function getAlleAnsatt() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Ansatt ON Person.personID = Ansatt.personID")
    End Function

    Public Sub endreReservasjon()

    End Sub

End Class
