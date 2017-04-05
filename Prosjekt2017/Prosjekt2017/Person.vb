Public Class Person
    Private db As New Database()

    Private fornavn As String
    Private etternavn As String
    Private fodselsdato As String
    Private personnummer As String
    Private telefon As Integer
    Private adresse As String
    Private postnummer As Integer
    Private epost As String

    Public Sub New()

    End Sub
    Public Sub New(fornavn As String, etternavn As String, fodselsdato As String, personnummer As String,
                   telefon As Integer, adresse As String, postnummer As Integer, epost As String)


        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.fodselsdato = fodselsdato
        Me.personnummer = personnummer
        Me.telefon = telefon
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.epost = epost

    End Sub
    Public Sub regPerson()
        db.Query("INSERT INTO Person(fornavn, etternavn, fodselsdato, telefon, epost, postnummer, adresse, personnummer) VALUES('" & fornavn & "', '" & etternavn &
                 "', '" & fodselsdato & "', '" & telefon & "', '" & epost & "', '" & postnummer & "', '" & adresse & "', '" & personnummer & "')")
    End Sub
    Public Sub endreFornavn(fornavn As String)
        db.Query("UPDATE Person SET fornavn = '" & fornavn & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endreEtternavn(etternavn As String)
        db.Query("UPDATE Person SET etternavn = '" & etternavn & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endreFodselsdato(fodselsdato As String)
        db.Query("UPDATE Person SET fodselsdato = '" & fodselsdato & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endrePersonnummer(etternavn As String)
        db.Query("UPDATE Person SET personnummer = '" & personnummer & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endreTelefon(telefon As Integer)
        db.Query("UPDATE Person SET telefon = '" & telefon & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endreAdresse(adresse As String)
        db.Query("UPDATE Person SET adresse = '" & adresse & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endrePostnummer(postnummer As String)
        db.Query("UPDATE Person SET postnummer = '" & postnummer & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub
    Public Sub endreBlodtype(blodtype As String)
        db.Query("UPDATE Person SET blodtype = '" & blodtype & "' WHERE personnummer = '" & PubVar.personnummer & "'")
    End Sub

    Public Function GetPersonnummer() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver WHERE Person.personID = Blodgiver.personID AND personnummer = " & "'" & PubVar.personnummer & "'")
    End Function

    Public Function getLastPersonID() As DataTable
        Return db.Query("SELECT MAX(personID) FROM Person")
    End Function

    Public Function getPersonID(ByVal personnummer As String) As DataTable
        Return db.Query("SELECT personID FROM Person WHERE personnummer = '" & personnummer & "'")
    End Function
End Class
