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
End Class
