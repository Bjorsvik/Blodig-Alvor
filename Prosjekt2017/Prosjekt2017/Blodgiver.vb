Imports MySql.Data.MySqlClient
Public Class Blodgiver
    Inherits Person
    Private db As New Database()

    Private passord As String

    Public Sub New()
    End Sub

    Public Sub New(passord As String, ByVal fornavn As String, ByVal etternavn As String, ByVal fodselsdato As String, ByVal personnummer As String, ByVal telefon As Integer,
                   ByVal adresse As String, ByVal postnummer As Integer, ByVal epost As String)
        MyBase.New(fornavn, etternavn, fodselsdato, personnummer, telefon, adresse, postnummer, epost)
        Me.passord = passord
    End Sub

    Public Sub regBlodgiver()
        regPerson()
        Dim pID As DataTable = getLastPersonID()
        Dim personID As String = ""

        For Each id In pID.Rows
            personID = id(0).ToString()
        Next id

        MsgBox(personID)
        db.Query("INSERT INTO Blodgiver(personID, Bpassord) VALUES('" & personID & "', '" & passord & "' )")
    End Sub
    Public Function GetBruker(personnummer As String) As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver ON Person.personID = Blodgiver.personID WHERE personnummer = " & "'" & personnummer & "'")
    End Function
    Public Function getAlleBlodgivere() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver ON Person.personID = Blodgiver.personID")
    End Function
    Public Function GetBrukeridByTelefon(ByVal personnummer As String) As DataTable
        Return db.Query("SELECT personID FROM Person WHERE personnummer = " & "'" & personnummer & "'")
    End Function
    'Public Function getpersonIDbyPassord(ByVal bPassord As Integer) As DataTable
    '    Return db.Query("SELECT personID FROM blodgiver WHERE personID = " & "'" & bPassord & "'")
    'End Function
End Class
