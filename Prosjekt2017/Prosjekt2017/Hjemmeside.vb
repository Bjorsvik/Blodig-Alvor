Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Hjemmeside
    'Oppretter en mysql connection til databasen
    Private tilkobling As MySqlConnection

    Private Sub Hjemmeside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTelefon.Hide()
        lbPassord.Hide()
        txtTelefon.Hide()
        txtPassord.Hide()
        btnLogginn.Hide()
        btnRegistrer.Hide()

        'tilkoblingingen blir koblet direkte sånn at brukeren har tilgang til databasen ved oppstart
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
    End Sub

    Private Sub Registreringsknapp_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Registreringsskjema.Show()
    End Sub

    Private Sub Logginnknapp_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click
        Dim passord = txtPassord.Text
        Dim telefon = txtTelefon.Text
        PubVar.telefon = telefon

        Dim sqlSporringBruker = "SELECT * from Blodgiver where telefon=@telefon " & "AND passord=@passord"

        Dim sql As New MySqlCommand(sqlSporringBruker, tilkobling)
        sql.Parameters.AddWithValue("@telefon", telefon)
        sql.Parameters.AddWithValue("@passord", passord)

        Dim READER As MySqlDataReader
        READER = sql.ExecuteReader
        If READER.Read Then
            MsgBox("Brukeren er logget på")
            READER.Close()
            Me.Hide()
            minside.Show()
        End If

    End Sub
    Private Sub Hjemmeside_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        txtPassord.PasswordChar = "*"
    End Sub

    Private Sub btnBlodgiver_Click(sender As Object, e As EventArgs) Handles btnBlodgiver.Click
        lbTelefon.Show()
        lbPassord.Show()
        btnBlodgiver.Hide()
        btnAnsatt.Hide()
        txtTelefon.Show()
        txtPassord.Show()
        btnLogginn.Show()
        btnRegistrer.Show()
    End Sub

    Private Sub btnAnsatt_Click(sender As Object, e As EventArgs) Handles btnAnsatt.Click
        lbTelefon.Show()
        lbPassord.Show()
        btnBlodgiver.Hide()
        btnAnsatt.Hide()
        txtTelefon.Show()
        txtPassord.Show()
        btnLogginn.Show()
        btnRegistrer.Hide()
    End Sub
End Class
