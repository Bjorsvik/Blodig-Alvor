Public Class Ansatt
    Dim db As New Database
    Dim Abrukernavn = PubVar.ansattBruker

    Public Sub New()

    End Sub

    Public Function getAlleAnsatt() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Ansatt ON Person.personID = Ansatt.personID")
    End Function
End Class
