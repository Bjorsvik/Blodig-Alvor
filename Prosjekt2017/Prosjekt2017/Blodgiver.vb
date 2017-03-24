Imports MySql.Data.MySqlClient
Public Class Blodgiver
    Inherits Person
    Private db As New Database()

    Private passord As String
    Private globaltelefon As String = PubVar.telefon

    Public Sub New()
    End Sub

    Public Sub New(passord As String, ByVal fornavn As String, ByVal etternavn As String, ByVal fodselsdato As String, ByVal telefon As Integer,
                   ByVal adresse As String, ByVal postnummer As Integer, ByVal epost As String)
        MyBase.New(fornavn, etternavn, fodselsdato, telefon, adresse, postnummer, epost)
        Me.passord = passord
    End Sub

    Public Sub regBlodgiver()
        regPerson()
        Dim pID As DataTable = getLastPersonID()
        Dim personID As String = ""

        For Each id In pID.Rows
            personID = id(0).ToString()
        Next id

        db.Query("INSERT INTO Blodgiver(personID) VALUES('" & personID & "')")
        BlodgiverPassord()
    End Sub
    Public Function BlodgiverPassord()
        Return db.Query("INSERT INTO Blodgiver(Bpassord) VALUES('" & passord & "')")
    End Function
    Public Function GetBruker(telefonSok As String) As DataTable
        Return db.Query("SELECT * From Blodgiver WHERE telefon = " & "'" & telefonSok & "'")
    End Function


    Public Function GetBrukeridByTelefon() As DataTable
        Return db.Query("SELECT brukerid FROM Blodgiver WHERE telefon = " & "'" & globaltelefon & "'")
    End Function
End Class
