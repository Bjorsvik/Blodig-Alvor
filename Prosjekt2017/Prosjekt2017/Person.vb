﻿Public Class Person
    Private db As New Database()

    Private fornavn As String
    Private etternavn As String
    Private fodselsdato As String
    Private telefon As Integer
    Private adresse As String
    Private postnummer As Integer
    Private epost As String

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
        db.Query("UPDATE Person SET fornavn = '" & fornavn & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Sub endreEtternavn(etternavn As String)
        db.Query("UPDATE Person SET etternavn = '" & etternavn & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Sub endreFodselsdato(fodselsdato As String)
        db.Query("UPDATE Person SET fodselsdato = '" & fodselsdato & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Sub endreTelefon(telefon As Integer)
        db.Query("UPDATE Person SET telefon = '" & telefon & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Sub endreAdresse(adresse As String)
        db.Query("UPDATE Person SET adresse = '" & adresse & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Sub endrePostnummer(postnummer As String)
        db.Query("UPDATE Person SET postnummer = '" & postnummer & "' WHERE telefon = '" & PubVar.telefon & "'")
    End Sub
    Public Function GetTelefon() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver WHERE Person.personID = Blodgiver.personID AND telefon = " & "'" & PubVar.telefon & "'")
    End Function

    Public Function getLastPersonID() As DataTable
        Return db.Query("SELECT MAX(personID) FROM Person")
    End Function
End Class
