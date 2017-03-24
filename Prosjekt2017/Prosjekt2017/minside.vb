﻿Imports MySql.Data.MySqlClient
Public Class minside
    Private tilkobling As MySqlConnection
    Dim bruker As New Bruker()

    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        Dim telefon = PubVar.telefon

        visBruker()
        visPoststed()

    End Sub
    Private Sub btnEndreInfo_Click(sender As Object, e As EventArgs) Handles btnEndreInfo.Click
        endreInfo()
        visBruker()
        visPoststed()
    End Sub

    Private Sub visBruker()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        Dim fornavn As String
        Dim etternavn As String
        Dim fodselsdato As Date
        Dim telefon As Integer
        Dim adresse As String
        Dim postnummer As Integer

        brukerTab = bruker.GetTelefon()

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")

            txtFornavn.Text = fornavn
            txtEtternavn.Text = etternavn
            txtFodselsdato.Text = fodselsdato
            txtTelefon.Text = telefon
            txtAdresse.Text = adresse
            txtPostnummer.Text = postnummer


        Next row



    End Sub

    Private Sub visPoststed()
        If txtPostnummer.TextLength = 4 Then

            Dim READER As MySqlDataReader
            Try
                tilkobling.Open()
                Dim postnummer As String = txtPostnummer.Text
                Dim tuddle As String = "'"
                Dim Query As String
                Query = "SELECT poststed from Postnummer WHERE postnummer = " & tuddle & postnummer & tuddle
                Dim command As New MySqlCommand(Query, tilkobling)
                READER = command.ExecuteReader

                If READER.Read() Then
                    lbPoststed.Text = READER.GetString(0)
                End If

                tilkobling.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                tilkobling.Dispose()
            End Try

        End If
    End Sub

    Private Sub endreInfo()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        Dim fornavn As String
        Dim etternavn As String
        Dim fodselsdato As Date
        Dim telefon As Integer
        Dim adresse As String
        Dim postnummer As Integer

        brukerTab = bruker.GetTelefon()

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")

            bruker.endreFornavn(txtFornavn.Text)
            bruker.endreEtternavn(txtEtternavn.Text)
            bruker.endreFodselsdato(txtFodselsdato.Text)
            bruker.endreTelefon(txtTelefon.Text)
            bruker.endreAdresse(txtAdresse.Text)
            bruker.endrePostnummer(txtPostnummer.Text)

        Next row
    End Sub

    'Private Sub visBrukeren()
    '    Dim SDA As New MySqlDataAdapter
    '    Dim dbDataset As New DataTable
    '    Dim bSource As New BindingSource
    '    Try
    '        tilkobling.Open()
    '        Dim tuddle As String = "'"
    '        Dim telefondb As String = tuddle & telefon & tuddle
    '        Dim Query As String
    '        Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, Blodgiver.postnummer, Postnummer.poststed from Blodgiver JOIN Postnummer ON Postnummer.postnummer = Blodgiver.postnummer WHERE Blodgiver.telefon = " & telefondb
    '        Dim command As New MySqlCommand(Query, tilkobling)
    '        SDA.SelectCommand = command
    '        SDA.Fill(dbDataset)
    '        bSource.DataSource = dbDataset
    '        DataGridView1.DataSource = bSource
    '        SDA.Update(dbDataset)

    '        tilkobling.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        tilkobling.Dispose()
    '    End Try
    'End Sub
End Class