Imports MySql.Data.MySqlClient
Public Class minside
    Private tilkobling As MySqlConnection
    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=kietmn;Uid=kietmn;Pwd=t8kt7tKw")
        Dim brukernavn = PubVar.brukernavndb

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            tilkobling.Open()
            Dim tuddle As String = "'"
            Dim brukernavndb As String = tuddle & brukernavn & tuddle
            Dim Query As String
            Query = "select fornavn, etternavn, adresse, telefon, fodselsdato from blodgiver where blodgiver.brukernavn = " & brukernavndb
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class