Public Class Person
    Private db As New Database()

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
    Public Sub New(fornavn As String, etternavn As String, fodselsdato As String,
                   telefon As Integer, adresse As String, postnummer As Integer, epost As String)


        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.fodselsdato = fodselsdato
        Me.telefon = telefon
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.epost = epost

    End Sub
    Public Sub regPerson()
        db.Query("INSERT INTO Person(fornavn, etternavn, telefon, epost, postnummer, adresse, fodselsdato) VALUES('" & fornavn & "', '" & etternavn &
                 "', '" & telefon & "', '" & epost & "', '" & postnummer & "', '" & adresse & "', '" & fodselsdato & "')")
    End Sub
    Public Sub endreFornavn(fornavn As String)
        db.Query("UPDATE Person SET fornavn = '" & fornavn & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreEtternavn(etternavn As String)
        db.Query("UPDATE Person SET etternavn = '" & etternavn & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreFodselsdato(fodselsdato As String)
        db.Query("UPDATE Person SET fodselsdato = '" & fodselsdato & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreTelefon(telefon As Integer)
        db.Query("UPDATE Person SET telefon = '" & telefon & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endreAdresse(adresse As String)
        db.Query("UPDATE Person SET adresse = '" & adresse & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Sub endrePostnummer(postnummer As String)
        db.Query("UPDATE Person SET postnummer = '" & postnummer & "' WHERE telefon = " & globaltelefon)
    End Sub
    Public Function GetTelefon() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver WHERE Person.personID = Blodgiver.personID AND telefon = " & "'" & globaltelefon & "'")
    End Function

    Public Function getLastPersonID() As DataTable
        Return db.Query("SELECT MAX(personID) FROM Person")
    End Function

    Public Function getAlleBrukere() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver ON Person.personID = Blodgiver.personID")
    End Function
End Class
