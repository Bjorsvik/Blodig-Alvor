Imports MySql.Data.MySqlClient
Public Class Ansattside
    Private tilkobling As MySqlConnection
    Dim Blodlager As New Blodlager()

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")

    End Sub
    Private Sub Ansattside_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Lager_Click(sender As Object, e As EventArgs) Handles Lager.Click
        Dim blodlagerTab As New DataTable()
        Dim blodtypeTab As New DataTable()

        Dim blodtype As String
        Dim blodplasma As String
        Dim blodlegeme As String
        Dim blodplater As String

        gridBlodlager.Rows.Clear()
        blodlagerTab = Blodlager.getAlleBlod()

        For Each row In blodlagerTab.Rows

            blodplasma = row("blodplasma")
            blodlegeme = row("blodlegeme")
            blodplater = row("blodplater")

            blodtypeTab = Blodlager.getAlleBlod
            For Each rad In blodtypeTab.Rows
                blodtype = rad("blodtype")
                gridBlodlager.Rows.Add(blodtype, blodplasma, blodlegeme, blodplater)
            Next rad

        Next row
    End Sub


    'Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
    '    Dim SDA As New MySqlDataAdapter
    '    Dim dbDataset As New DataTable
    '    Dim bSource As New BindingSource
    '    Try
    '        tilkobling.Open()
    '        Dim tuddle As String = "'"
    '        Dim telefon As String = txtSok.Text
    '        telefon = tuddle & telefon & tuddle
    '        Dim Query As String
    '        Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, Blodgiver.postnummer, Postnummer.poststed from Blodgiver JOIN Postnummer ON Postnummer.postnummer = Blodgiver.postnummer WHERE Blodgiver.telefon = " & telefon
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