Imports MySql.Data.MySqlClient
Public Class Registreringsskjema
    Private tilkobling As MySqlConnection
    Private Sub Registreringsskjema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=kietmn;Uid=kietmn;Pwd=t8kt7tKw")
        tilkobling.Open()
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


        If bpassord = passord Then
            Dim sqlSporring = "insert into blodgiver (brukernavn, passord, fornavn, etternavn, fodselsdato,
                           telefon, adresse, postnummer) values (@brukernavn, @passord, @fornavn, 
                           @etternavn, @fodselsdato, @telefon, @adresse, @postnummer)"

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
        'If txtPostnummer.TextLength = 4 Then
        'Dim sqlSporringPoststed = "SELECT poststed FROM postnummer JOIN blodgiver ON blodgiver.postnummer = postnummer.postnummer"
        'Dim sqlSjekk As New MySqlCommand(sqlSporringPoststed, tilkobling)
        'Dim reader = sqlSjekk.ExecuteReader()
        'If reader.HasRows Then
        'lbPoststed.Text = reader.ToString
        'reader.Close()
        'End If
        'End If
    End Sub
End Class