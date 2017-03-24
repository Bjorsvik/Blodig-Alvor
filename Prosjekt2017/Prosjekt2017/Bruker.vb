Imports MySql.Data.MySqlClient
Public Class Bruker
    Private db As New Database()

    Private passord As String
    Private fornavn As String
    Private etternavn As String
    Private fodselsdato As String
    Private telefon As Integer
    Private adresse As String
    Private postnummer As Integer
    Private epost As String
    Private globaltelefon As String = PubVar.telefon

    Public Sub New()
    End Sub

    Public Sub New(passord As String, fornavn As String, etternavn As String, fodselsdato As String,
                   telefon As Integer, adresse As String, postnummer As Integer, epost As String)
        Me.passord = passord
        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.fodselsdato = fodselsdato
        Me.telefon = telefon
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.epost = epost
    End Sub

    Public Sub regBruker()
        db.Query("INSERT INTO Blodgiver(fornavn, etternavn, telefon, epost, postnummer, adresse, fodselsdato, passord) VALUES('" & fornavn & "', '" & etternavn &
                 "', '" & telefon & "', '" & epost & "', '" & postnummer & "', '" & adresse & "', '" & fodselsdato & "',  '" & passord & "')")
    End Sub
    Public Sub endreFornavn(fornavn As String)
        db.Query("UPDATE Blodgiver SET fornavn = '" & fornavn & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreEtternavn(etternavn As String)
        db.Query("UPDATE Blodgiver SET etternavn = '" & etternavn & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreFodselsdato(fodselsdato As String)
        db.Query("UPDATE Blodgiver SET fodselsdato = '" & fodselsdato & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreTelefon(telefon As Integer)
        db.Query("UPDATE Blodgiver SET telefon = '" & telefon & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreAdresse(adresse As String)
        db.Query("UPDATE Blodgiver SET adresse = '" & adresse & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endrePostnummer(postnummer As String)
        db.Query("UPDATE Blodgiver SET postnummer = '" & postnummer & "' WHERE telefon = " & globaltelefon)
    End Sub

    Public Function getAlleBrukere() As DataTable
        Return db.Query("SELECT * FROM Blodgiver")
    End Function

    Public Function GetTelefon() As DataTable
        Return db.Query("SELECT * From Blodgiver WHERE telefon = " & "'" & globaltelefon & "'")
    End Function

    Public Function GetBrukeridByTelefon() As DataTable
        Return db.Query("SELECT brukerid FROM Blodgiver WHERE telefon = " & "'" & globaltelefon & "'")
    End Function
End Class
