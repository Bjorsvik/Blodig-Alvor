Imports MySql.Data.MySqlClient
Public Class Bruker
    Private passord As String
    Private fornavn As String
    Private etternavn As String
    Private fodselsdato As String
    Private telefon As Integer
    Private adresse As String
    Private postnummer As Integer
    Private epost As String

    Public Sub New(passord As String, fornavn As String, etternavn As String, fodselsdato As String,
                   telefon As Integer, adresse As String, postnummer As Integer, epost As String)
        Me.passord = passord
        Me.fornavn = fornavn
        Me.etternavn = etternavn
        Me.fodselsdato = fodselsdato
        Me.telefon = telefon
        Me.adresse = adresse
        Me.postnummer = postnummer
        Me.epost = epost

        Dim tilkobling As MySqlConnection
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()

        Dim sqlSporring = "insert into Blodgiver (passord, fornavn, etternavn, fodselsdato,
                           telefon, adresse, postnummer, epost) values (@passord, @fornavn, 
                           @etternavn, @fodselsdato, @telefon, @adresse, @postnummer, @epost)"

        Dim sqlSporringBrukernavn = "select * from Blodgiver where telefon=@telefon"

        Dim sqlRegistrer As New MySqlCommand(sqlSporring, tilkobling)

        Dim sqlSjekk As New MySqlCommand(sqlSporringBrukernavn, tilkobling)
        sqlSjekk.Parameters.AddWithValue("@telefon", telefon)


        Dim reader = sqlSjekk.ExecuteReader()
        If reader.HasRows Then
            MsgBox("Personnummer er i bruk")
            reader.Close()
        Else
            reader.Close()
            sqlRegistrer.Parameters.AddWithValue("@passord", passord)
            sqlRegistrer.Parameters.AddWithValue("@fornavn", fornavn)
            sqlRegistrer.Parameters.AddWithValue("@etternavn", etternavn)
            sqlRegistrer.Parameters.AddWithValue("@fodselsdato", fodselsdato)
            sqlRegistrer.Parameters.AddWithValue("@telefon", telefon)
            sqlRegistrer.Parameters.AddWithValue("@adresse", adresse)
            sqlRegistrer.Parameters.AddWithValue("@postnummer", postnummer)
            sqlRegistrer.Parameters.AddWithValue("@epost", epost)
            sqlRegistrer.ExecuteNonQuery()
            reader.Close()
        End If

    End Sub
End Class
