Imports MySql.Data.MySqlClient
Public Class Registreringsskjema
    Private tilkobling As MySqlConnection
    Private Sub Registreringsskjema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()

        txtPostnummer.MaxLength = 4
    End Sub
    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim brukernavn = txtBrukernavn.Text
        Dim passord = txtPassord.Text
        Dim bpassord = txtBekreftPassord.Text
        Dim fornavn = txtFornavn.Text
        Dim etternavn = txtEtternavn.Text
        Dim fodselsdato = txtFodselsdato.Text
        Dim telefon = txtTlf.Text
        Dim adresse = txtAdresse.Text
        Dim postnummer = txtPostnummer.Text
        Dim epost = txtEpost.Text


        If bpassord = passord Then
            Dim sqlSporring = "insert into blodgiver (brukernavn, passord, fornavn, etternavn, fodselsdato,
                           telefon, adresse, postnummer, epost) values (@brukernavn, @passord, @fornavn, 
                           @etternavn, @fodselsdato, @telefon, @adresse, @postnummer, @epost)"

            Dim sqlSporringBrukernavn = "select * from blodgiver where brukernavn=@brukernavn"

            Dim sqlRegistrer As New MySqlCommand(sqlSporring, tilkobling)

            Dim sqlSjekk As New MySqlCommand(sqlSporringBrukernavn, tilkobling)
            sqlSjekk.Parameters.AddWithValue("@brukernavn", brukernavn)


            Dim reader = sqlSjekk.ExecuteReader()
            If reader.HasRows Then
                MsgBox("Brukernavnet er tatt")
                reader.Close()
            Else
                reader.Close()
                sqlRegistrer.Parameters.AddWithValue("@brukernavn", brukernavn)
                sqlRegistrer.Parameters.AddWithValue("@passord", passord)
                sqlRegistrer.Parameters.AddWithValue("@fornavn", fornavn)
                sqlRegistrer.Parameters.AddWithValue("@etternavn", etternavn)
                sqlRegistrer.Parameters.AddWithValue("@fodselsdato", fodselsdato)
                sqlRegistrer.Parameters.AddWithValue("@telefon", telefon)
                sqlRegistrer.Parameters.AddWithValue("@adresse", adresse)
                sqlRegistrer.Parameters.AddWithValue("@postnummer", postnummer)
                sqlRegistrer.Parameters.AddWithValue("@epost", epost)
                sqlRegistrer.ExecuteNonQuery()
                Me.Close()
            End If
        Else
            MsgBox("Passordene er ikke like")
        End If

    End Sub

    Private Sub txtPassord_TextChanged(sender As Object, e As EventArgs) Handles txtPassord.TextChanged
        'txtPassord.PasswordChar = "*"
    End Sub

    Private Sub Registreringsskjema_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtBekreftPassord_TextChanged(sender As Object, e As EventArgs) Handles txtBekreftPassord.TextChanged
        'txtBekreftPassord.PasswordChar = "*"
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbEpost.Click

    End Sub
End Class