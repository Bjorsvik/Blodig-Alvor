Imports MySql.Data.MySqlClient

Public Class egenerklering
    Private tilkobling As MySqlConnection
    Private Sub egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSporring = "insert into Egenerklering (sporsmal, ja, nei) values (@sporsmal, @ja, @nei)"
        Dim sqlSendInfo As New MySqlCommand(sqlSporring, tilkobling)
        Dim sporsmalEpost As String = ""
        sqlSendInfo.Parameters.AddWithValue("@sporsmal", "Tillater du at blodbanken sender deg epost(Innkalling, timepåminning, eventuelt annen viktig informasjon)?")
        sqlSendInfo.Parameters.AddWithValue("@nei", rbEpostNei.Checked)
        sqlSendInfo.Parameters.AddWithValue("@ja", rbEpostJa.Checked)


        sqlSendInfo.ExecuteNonQuery()

    End Sub
End Class