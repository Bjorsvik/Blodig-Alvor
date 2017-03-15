﻿Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Hjemmeside
    'Oppretter en mysql connection til databasen
    Private tilkobling As MySqlConnection

    Private Sub Hjemmeside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tilkoblingingen blir koblet direkte sånn at brukeren har tilgang til databasen ved oppstart
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
    End Sub

    Private Sub Registreringsknapp_Click(sender As Object, e As EventArgs) Handles Registreringsknapp.Click
        Registreringsskjema.Show()
    End Sub

    Private Sub Logginnknapp_Click(sender As Object, e As EventArgs) Handles Logginnknapp.Click
        Dim brukernavn = txtBrukernavn.Text
        Dim passord = txtPassord.Text
        brukernavndb = txtBrukernavn.Text

        Dim sqlSporringBruker = "select * from blodgiver where brukernavn=@brukernavn " & "and passord=@passord"

        Dim sql As New MySqlCommand(sqlSporringBruker, tilkobling)
        sql.Parameters.AddWithValue("@brukernavn", brukernavn)
        sql.Parameters.AddWithValue("passord", passord)

        Dim reader = sql.ExecuteReader()
        If reader.HasRows Then
            MsgBox("Brukeren er logget på")
            reader.Close()
            Me.Hide()
            minside.Show()

        End If

    End Sub

    Public Sub LogginnknappPublic_Click(sender As Object, e As EventArgs) Handles Logginnknapp.Click
        Dim brukernavnd As String = txtBrukernavn.Text

    End Sub
    Private Sub Hjemmeside_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        txtPassord.PasswordChar = "*"
    End Sub
End Class
