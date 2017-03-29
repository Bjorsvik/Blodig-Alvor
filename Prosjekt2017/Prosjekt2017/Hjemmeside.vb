Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Hjemmeside
    'Oppretter en mySQL-connection til databasen.
    Dim bruker As New Blodgiver()
    Dim ansatt As New Ansatt()


    Private Sub Hjemmeside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbInput.Hide()
        lbPassord.Hide()
        txtInput.Hide()
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
        Dim passord = txtPassord.Text
        Dim brukertype As String = PubVar.brukerType

        If PubVar.brukerType = "Blodgiver" Then
            Dim personnummer As String = txtInput.Text
            PubVar.personnummer = personnummer

            Dim brukerTabell As New DataTable
            Dim sjekkPassord As String
            Dim sjekkPersonnummer As String
            Dim riktigPass As Boolean = False

            brukerTabell = bruker.getAlleBlodgivere
            For Each row In brukerTabell.Rows
                sjekkPersonnummer = row("personnummer")
                sjekkPassord = row("Bpassord")

                If personnummer = sjekkPersonnummer And passord = sjekkPassord Then

                    riktigPass = True

                    txtInput.Clear()
                    txtPassord.Clear()
                    Me.Hide()
                    MsgBox("Velkommen til minside!")
                    minside.Show()
                End If

            Next row

            If riktigPass = False Then
                MsgBox("Feil brukernavn eller passord")
            End If

        Else
            Dim Abrukernavn As String = txtInput.Text
            PubVar.ansattBruker = txtInput.Text

            Dim ansattTabell As New DataTable
            Dim sjekkAbrukernavn As String
            Dim sjekkApassord As String
            Dim riktigPass As Boolean = False

            ansattTabell = ansatt.getAlleAnsatt
            For Each row In ansattTabell.Rows
                sjekkAbrukernavn = row("Abrukernavn")
                sjekkApassord = row("Apassord")

                If Abrukernavn = sjekkAbrukernavn And passord = sjekkApassord Then

                    riktigPass = True

                    txtInput.Clear()
                    txtPassord.Clear()
                    Me.Hide()
                    MsgBox("Velkommen til minside!")
                    Ansattside.Show()
                End If

            Next row

        End If

    End Sub

    Private Sub btnBlodgiver_Click(sender As Object, e As EventArgs) Handles btnBlodgiver.Click
        lbInput.Show()
        lbPassord.Show()
        btnBlodgiver.Hide()
        btnAnsatt.Hide()
        txtInput.Show()
        txtPassord.Show()
        btnLogginn.Show()
        btnRegistrer.Show()

        txtInput.Select()
        lbInput.Text = "Telefon"
        PubVar.brukerType = "Blodgiver"
    End Sub

    Private Sub btnAnsatt_Click(sender As Object, e As EventArgs) Handles btnAnsatt.Click
        lbInput.Show()
        lbPassord.Show()
        btnBlodgiver.Hide()
        btnAnsatt.Hide()
        txtInput.Show()
        txtPassord.Show()
        btnLogginn.Show()
        btnRegistrer.Hide()

        txtInput.Select()
        lbInput.Text = "Brukernavn"
        PubVar.brukerType = "Ansatt" ' <- Endre til "Ansatt" når databasetabellen er klar.
    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        txtPassord.PasswordChar = "*"
    End Sub
End Class
