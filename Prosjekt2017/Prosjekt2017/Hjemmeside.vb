Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Hjemmeside
    'Oppretter en mySQL-connection til databasen.
    Dim bruker As New Bruker()

    Private Sub Hjemmeside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTelefon.Hide()
        lbPassord.Hide()
        txtTelefon.Hide()
        txtPassord.Hide()
        btnLogginn.Hide()
        btnRegistrer.Hide()
    End Sub
    Private Sub SetDefault(ByVal btnLogginn As Button)
        Me.AcceptButton = btnLogginn
    End Sub

    Private Sub Registreringsknapp_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Registreringsskjema.Show()
    End Sub

    Private Sub Logginnknapp_Click(sender As Object, e As EventArgs) Handles btnLogginn.Click

        Dim telefon = txtTelefon.Text
        Dim passord = txtPassord.Text
        PubVar.telefon = telefon

        Dim brukerTabell As New DataTable
        Dim sjekkPassord As String
        Dim sjekkTelefon As String
        Dim brukerid As String
        Dim riktigPass As Boolean = False

        brukerTabell = bruker.getAlleBrukere
        For Each row In brukerTabell.Rows
            sjekkTelefon = row("telefon")
            sjekkPassord = row("passord")
            brukerid = row("brukerid")

            If telefon = sjekkTelefon And passord = sjekkPassord Then

                riktigPass = True

                txtTelefon.Clear()
                txtPassord.Clear()
                Me.Hide()
                MsgBox("Velkommen til minside!")
                minside.Show()
            End If
        Next row

        If riktigPass = False Then
            MsgBox("Feil brukernavn eller passord")
        End If

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

        txtTelefon.Select()
        PubVar.brukerType = "Blodgiver"
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

        txtTelefon.Select()
        PubVar.brukerType = "Blodgiver" ' <- Endre til "Ansatt" når databasetabellen er klar.
    End Sub
End Class
