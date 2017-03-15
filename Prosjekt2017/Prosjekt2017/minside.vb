Imports MySql.Data.MySqlClient
Public Class minside
    Private tilkobling As MySqlConnection

    Private Function reArrangeDatatable(ByVal dt As DataTable) As DataTable
        Dim newTable As New DataTable
        newTable.Columns.AddRange(New DataColumn() {New DataColumn(dt.Columns(0).ColumnName), New DataColumn(dt.Columns(1).ColumnName)})
        For x As Integer = 0 To dt.Rows.Count - 1
            newTable.Rows.Add(dt.Rows(x).Item(0), dt.Rows(x).Item(1))
            newTable.Rows.Add(dt.Rows(x).Item(2), dt.Rows(x).Item(3))
        Next

        Return newTable

    End Function

    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        Dim brukernavn = PubVar.brukernavndb

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Try
            tilkobling.Open()
            Dim tuddle As String = "'"
            Dim brukernavndb As String = tuddle & brukernavn & tuddle
            Dim Query As String
            Dim datagrid
            Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, blodgiver.postnummer, Postnummer.poststed from blodgiver JOIN Postnummer ON Postnummer.postnummer = blodgiver.postnummer WHERE blodgiver.brukernavn = " & brukernavndb
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