﻿Imports MySql.Data.MySqlClient
Public Class Blodgiver
    Inherits Person
    Private db As New Database()

    Private passord As String

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

        MsgBox(personID)
        db.Query("INSERT INTO Blodgiver(personID, Bpassord) VALUES('" & personID & "', '" & passord & "' )")
    End Sub
    Public Function GetBruker(telefonSok As String) As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver ON Person.personID = Blodgiver.personID WHERE telefon = " & "'" & telefonSok & "'")
    End Function
    Public Function getAlleBlodgivere() As DataTable
        Return db.Query("SELECT * FROM Person JOIN Blodgiver ON Person.personID = Blodgiver.personID")
    End Function
    Public Function GetBrukeridByTelefon(ByVal tlf As Integer) As DataTable
        Return db.Query("SELECT personID FROM Person WHERE telefon = " & "'" & tlf & "'")
    End Function
End Class
