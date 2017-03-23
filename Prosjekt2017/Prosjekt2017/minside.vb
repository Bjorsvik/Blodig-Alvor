Imports MySql.Data.MySqlClient
Public Class minside
    Private tilkobling As MySqlConnection
    Dim bruker As New Bruker()

    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        Dim telefon = PubVar.telefon

        visBrukeren()

    End Sub

    Private Sub visBrukeren()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            tilkobling.Open()
            Dim tuddle As String = "'"
            Dim telefondb As String = tuddle & telefon & tuddle
            Dim Query As String
            Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, Blodgiver.postnummer, Postnummer.poststed from Blodgiver JOIN Postnummer ON Postnummer.postnummer = Blodgiver.postnummer WHERE Blodgiver.telefon = " & telefondb
            Dim command As New MySqlCommand(Query, tilkobling)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataset)

            tilkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.Dispose()
        End Try
    End Sub

    Private Sub tabBrukerinfo_Click(sender As Object, e As EventArgs) Handles tabBrukerinfo.Click

    End Sub
End Class