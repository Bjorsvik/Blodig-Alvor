Imports MySql.Data.MySqlClient
Public Class minside
    Dim bruker As New Blodgiver()
    Dim postnr As New Postnummer()

    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim telefon = PubVar.telefon

        visBruker()
        visPoststed()

        DateTimePicker1.MinDate = Date.Today() 'Gjør slik at dato fra fortiden ikke kan velges.

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

        Dim postnummerTab As New DataTable()

        Dim poststed As String

        postnummerTab = postnr.GetPoststed(txtPostnummer.Text)

        For Each row In postnummerTab.Rows
            poststed = row("poststed")

            lbPoststed.Text = poststed
        Next row

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

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim blodgiver As New Blodgiver
        Dim personID As String
        Dim res As New Reservasjoner
        Dim dato As New Date()
        Dim resDato As Date
        Dim id As New DataTable()

        id = blodgiver.GetBrukeridByTelefon(45464856)

        For Each rad In id.Rows
            personID = rad(0).ToString()
        Next rad

        Dim tempID As Integer = CInt(personID)
        dato = DateTimePicker1.Value()
        resDato = dato.Year & "-" & dato.Month & "-" & dato.Day
        res.reserver(resDato, tempID)
        MsgBox(resDato.ToString)

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