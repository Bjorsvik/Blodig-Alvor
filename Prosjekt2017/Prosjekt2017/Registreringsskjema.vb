Imports MySql.Data.MySqlClient
Public Class Registreringsskjema
    Private tilkobling As MySqlConnection
    Private Sub Registreringsskjema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FixedString As String = ToUpperFirst(txtFornavn.Text)
        If txtFornavn.Text <> FixedString Then txtFornavn.Text = FixedString

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()

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
            Dim nyBruker As New Bruker(txtPassord.Text, txtFornavn.Text, txtEtternavn.Text, txtFodselsdato.Text,
                                         txtTlf.Text, txtAdresse.Text, txtPostnummer.Text, txtEpost.Text)
            nyBruker.regBruker()
            Me.Close()
        Else
            MsgBox("Passordene er ikke like")
        End If


    End Sub

    Private Sub txtPostnummer_TextChanged(sender As Object, e As EventArgs) Handles txtPostnummer.TextChanged

        If txtPostnummer.TextLength = 4 Then

            Dim READER As MySqlDataReader
            Try
                Dim postnummer As Integer = txtPostnummer.Text
                Dim tuddle As String = "'"
                Dim Query As String
                Query = "SELECT poststed from Postnummer WHERE postnummer = " & tuddle & postnummer & tuddle
                Dim command As New MySqlCommand(Query, tilkobling)
                READER = command.ExecuteReader

                If READER.Read() Then
                    lbPoststed.Text = READER.GetString(0)
                End If

                tilkobling.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                tilkobling.Open()
            End Try
        End If
    End Sub

    Private Sub txtFornavn_TextChanged(sender As Object, e As EventArgs) Handles txtFornavn.TextChanged
        txtFornavn.Text = ToUpperFirst(txtFornavn.Text)
        txtFornavn.Select(txtFornavn.Text.Length, 0)
    End Sub

    Private Sub txtEtternavn_TextChanged(sender As Object, e As EventArgs) Handles txtEtternavn.TextChanged
        txtEtternavn.Text = ToUpperFirst(txtEtternavn.Text)
        txtEtternavn.Select(txtEtternavn.Text.Length, 0)
    End Sub
    Private Sub Registreringsskjema_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        'txtPassord.PasswordChar = "*"
    End Sub
    Private Sub txtBekreftPassord_TextChanged(sender As Object, e As EventArgs) Handles txtBekreftPassord.TextChanged
        'txtBekreftPassord.PasswordChar = "*"
    End Sub
End Class