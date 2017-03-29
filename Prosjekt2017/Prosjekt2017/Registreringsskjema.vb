Imports MySql.Data.MySqlClient
Public Class Registreringsskjema
    Dim postnr As New Postnummer()
    Private Sub Registreringsskjema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FixedString As String = ToUpperFirst(txtFornavn.Text)
        If txtFornavn.Text <> FixedString Then txtFornavn.Text = FixedString

        txtPostnummer.MaxLength = 4
    End Sub

    'Funksjon for uppercase for registrering
    Public Function ToUpperFirst(Value As String) As String

        If Value <> "" Then
            Dim FirstChar As String = Value.Chars(0).ToString
            Dim Rest As String = Value.Remove(0, 1)
            Return FirstChar.ToUpper & Rest.ToLower
        Else
            Return ""
        End If
    End Function

    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim passord = txtPassord.Text
        Dim bpassord = txtBekreftPassord.Text

        If bpassord = passord Then
            Dim nyBruker As New Blodgiver(txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, txtFodselsdato.Text, txtPersonnummer.Text,
                                         txtTlf.Text, txtAdresse.Text, txtPostnummer.Text, txtEpost.Text)
            nyBruker.regBlodgiver()

            Me.Close()
        Else
            MsgBox("Passordene er ikke like")
        End If


    End Sub

    Private Sub txtPostnummer_TextChanged(sender As Object, e As EventArgs) Handles txtPostnummer.TextChanged

        If txtPostnummer.TextLength = 4 Then
            visPoststed()
        End If
    End Sub

    Private Sub visPoststed()

        Dim postnummerTab As New DataTable()

        Dim poststed As String

        postnummerTab = postnr.GetPoststed(txtPostnummer.Text)

        For Each row In postnummerTab.Rows
            poststed = row("poststed")

            lbPoststed.Text = poststed
        Next row

    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        'txtPassord.PasswordChar = "*"
    End Sub
    Private Sub txtBekreftPassord_TextChanged(sender As Object, e As EventArgs) Handles txtBekreftPassord.TextChanged
        'txtBekreftPassord.PasswordChar = "*"
    End Sub

    Private Sub txtFornavn_TextChanged(sender As Object, e As EventArgs) Handles txtFornavn.TextChanged
        txtFornavn.Text = ToUpperFirst(txtFornavn.Text)
        txtFornavn.Select(txtFornavn.Text.Length, 0)
    End Sub

    Private Sub txtEtternavn_TextChanged(sender As Object, e As EventArgs) Handles txtEtternavn.TextChanged
        txtEtternavn.Text = ToUpperFirst(txtEtternavn.Text)
        txtEtternavn.Select(txtEtternavn.Text.Length, 0)
    End Sub
End Class