﻿Imports MySql.Data.MySqlClient
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

    Public Function GetIDByPersonNr(ByVal personnummer As String) As DataTable
        Return db.Query("SELECT personID FROM Person WHERE personnummer = " & "'" & personnummer & "'")
    End Function
    Public Sub addKarantene(ByVal dbKDato As Date, ByVal personID As Integer)
        db.Query("UPDATE Blodgiver SET karantene = '" & dbKDato.ToString("yyyy-MM-dd") & "' WHERE personID = '" & personID & "'")
    End Sub

    Public Sub addLivstid(ByVal personID As Integer)
        db.Query("UPDATE Blodgiver SET livstid = True Where personID = '" & personID & "'")
    End Sub

    Public Sub registrerEgenerklering(ByVal dbDato As Date, spmEpost As Boolean, spmSMS As Boolean, controllListe As String, personID As Integer)
        db.Query("Insert into Egenerklering (dato, varsling_epost, varsling_sms, bolk1, personID) values ('" & dbDato.ToString("yyyy-MM-dd") & "', " & spmEpost & ", " & spmSMS & ", '" & controllListe & "', " & personID & ");")
    End Sub

    Public Function getKarantene(ByVal personID As Integer)
        Return db.Query("SELECT karantene from Blodgiver Where personID = '" & personID & "'")
    End Function

    Public Function getLivstid(ByVal personID As Integer)
        Return db.Query("SELECT livstid from Blodgiver WHERE personID = '" & personID & "'")
    End Function
    'db.Query("Insert into Egenerklering (dato, varsling_epost, varsling_sms, bolk1, personID, karanteneID) values ('" & dbDato.ToString("yyyy-MM-dd") & "', " & spmEpost & ", " & spmSMS & ", '" & liste & "', " & personID & ");")

    'Public Function getHistorikkByPersonID()

    'End Function
End Class
