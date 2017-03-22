Imports MySql.Data.MySqlClient
Public Class minside
    Private tilkobling As MySqlConnection

    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call CenterToScreen()
        'Me.FormBorderStyle = BorderStyle.None
        'Me.WindowState = FormWindowState.Maximized

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        Dim telefon = PubVar.telefon

        Try
            Dim ReaderFnavn As MySqlDataReader
            Dim ReaderEnavn As MySqlDataReader
            Dim ReaderFodselsdato As MySqlDataReader
            Dim ReaderTelefon As MySqlDataReader
            Dim ReaderEpost As MySqlDataReader
            Dim ReaderAdresse As MySqlDataReader
            Dim ReaderPostnummer As MySqlDataReader
            Dim ReaderPoststed As MySqlDataReader

            tilkobling.Open()
            Dim tuddle As String = "'"

            Dim QueryFnavn, QueryEnavn, QueryFodselsdato, QueryTelefon, QueryEpost, QueryAdresse, QueryPostnummer, QueryPoststed As String
            QueryFnavn = "SELECT fornavn FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryEnavn = "SELECT etternavn FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryFodselsdato = "SELECT fodselsdato FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryTelefon = "SELECT telefon FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryEpost = "SELECT epost FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryAdresse = "SELECT adresse FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryPostnummer = "SELECT postnummer FROM Blodgiver WHERE telefon = " & tuddle & telefon & tuddle
            QueryPoststed = "SELECT Postnummer.poststed FROM Blodgiver JOIN Postnummer ON Postnummer.postnummer = Blodgiver.postnummer WHERE telefon = " & tuddle & telefon & tuddle
            Dim CommandFNavn As New MySqlCommand(QueryFnavn, tilkobling)
            Dim CommandEnavn As New MySqlCommand(QueryEnavn, tilkobling)
            Dim CommandFodselsdato As New MySqlCommand(QueryFodselsdato, tilkobling)
            Dim CommandTelefon As New MySqlCommand(QueryTelefon, tilkobling)
            Dim CommandEpost As New MySqlCommand(QueryEpost, tilkobling)
            Dim CommandAdresse As New MySqlCommand(QueryAdresse, tilkobling)
            Dim CommandPostnummer As New MySqlCommand(QueryPostnummer, tilkobling)
            Dim CommandPoststed As New MySqlCommand(QueryPoststed, tilkobling)

            ReaderFnavn = CommandFNavn.ExecuteReader
            If ReaderFnavn.Read() Then
                lbFornavn.Text = ReaderFnavn.GetString(0)
                ReaderFnavn.Close()
            End If

            ReaderEnavn = CommandEnavn.ExecuteReader
            If ReaderEnavn.Read() Then
                lbEtternavn.Text = ReaderEnavn.GetString(0)
                ReaderEnavn.Close()
            End If

            ReaderFodselsdato = CommandFodselsdato.ExecuteReader
            If ReaderFodselsdato.Read() Then
                lbFodselsdato.Text = ReaderFodselsdato.GetString(0)
                ReaderFodselsdato.Close()
            End If

            ReaderTelefon = CommandTelefon.ExecuteReader
            If ReaderTelefon.Read() Then
                lbTelefon.Text = ReaderTelefon.GetString(0)
                ReaderTelefon.Close()
            End If

            ReaderEpost = CommandEpost.ExecuteReader
            If ReaderEpost.Read() Then
                lbEpost.Text = ReaderEpost.GetString(0)
                ReaderEpost.Close()
            End If

            ReaderAdresse = CommandAdresse.ExecuteReader
            If ReaderAdresse.Read() Then
                lbAdresse.Text = ReaderAdresse.GetString(0)
                ReaderAdresse.Close()
            End If

            ReaderPostnummer = CommandPostnummer.ExecuteReader
            If ReaderPostnummer.Read() Then
                lbPostnummer.Text = ReaderPostnummer.GetString(0)
                ReaderPostnummer.Close()
            End If

            ReaderPoststed = CommandPoststed.ExecuteReader
            If ReaderPoststed.Read() Then
                lbPoststed.Text = ReaderPoststed.GetString(0)
                ReaderPoststed.Close()
            End If

            tilkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.Dispose()
        End Try



        'Datagridview
        'Dim SDA As New MySqlDataAdapter
        'Dim dbDataset As New DataTable
        'Dim bSource As New BindingSource
        'Try
        '    tilkobling.Open()
        '    Dim tuddle As String = "'"
        '    Dim brukernavndb As String = tuddle & brukernavn & tuddle
        '    Dim Query As String
        '    Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, blodgiver.postnummer, Postnummer.poststed from blodgiver JOIN Postnummer ON Postnummer.postnummer = blodgiver.postnummer WHERE blodgiver.brukernavn = " & brukernavndb
        '    Dim command As New MySqlCommand(Query, tilkobling)
        '    SDA.SelectCommand = command
        '    SDA.Fill(dbDataset)
        '    bSource.DataSource = dbDataset
        '    DataGridView1.DataSource = bSource
        '    SDA.Update(dbDataset)

        '    tilkobling.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    tilkobling.Dispose()
        'End Try

    End Sub
End Class