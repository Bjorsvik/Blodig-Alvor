Imports MySql.Data.MySqlClient

Public Class egenerklering
    Private tilkobling As MySqlConnection
    Private Sub egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlSporring = "insert into Egenerklering (sporsmal, ja, nei) values (@sporsmal, @ja, @nei)"
        Dim sqlSendinfo As New MySqlCommand(sqlSporring, tilkobling)

        Dim sporsmalEpost As String = ""
        Dim sporsmalSMS As String = ""

        sqlSendinfo.Parameters.AddWithValue("@sporsmalEpost", "Tillater du at blodbanken sender deg epost(Innkalling, timepåminning, eventuelt annen viktig informasjon)?")
        sqlSendinfo.Parameters.AddWithValue("@nei", chkEpostNei.Checked)
        sqlSendinfo.Parameters.AddWithValue("@ja", chkEpostJa.Checked)

        sqlSendinfo.Parameters.AddWithValue("@sporsmalSMS", "Tillater du at blodbanken sender deg SMS(Innkalling, timepåminning, eventuelt annen viktig informasjon)?")
        sqlSendinfo.Parameters.AddWithValue("@neiSMS", chkSMSNei.Checked)
        sqlSendinfo.Parameters.AddWithValue("@jaSMS", chkSMSJa.Checked)



        sqlSendinfo.ExecuteNonQuery()


    End Sub
End Class