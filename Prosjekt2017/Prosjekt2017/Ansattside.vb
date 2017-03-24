Imports MySql.Data.MySqlClient
Public Class Ansattside
    Private tilkobling As MySqlConnection
    Dim Blodlager As New Blodlager()
    Dim Bruker As New Blodgiver()

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")

    End Sub
    Private Sub Ansattside_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub
    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        visBruker()
    End Sub

    Private Sub btnOppdater_Click(sender As Object, e As EventArgs) Handles btnOppdater.Click
        endreInfo()
        visBruker()
    End Sub

    Private Sub Lager_Click(sender As Object, e As EventArgs) Handles Lager.Click
        Dim blodlagerTab As New DataTable()
        Dim blodtypeTab As New DataTable()

        Dim blodtype As String
        Dim blodplasma As String
        Dim blodlegeme As String
        Dim blodplater As String

        gridBlodlager.Rows.Clear()
        blodlagerTab = Blodlager.getAlleBlod()

        For Each row In blodlagerTab.Rows

            blodplasma = row("blodplasma")
            blodlegeme = row("blodlegeme")
            blodplater = row("blodplater")

            blodtypeTab = Blodlager.getAlleBlod
            For Each rad In blodtypeTab.Rows
                blodtype = rad("blodtype")
                gridBlodlager.Rows.Add(blodtype, blodplasma, blodlegeme, blodplater)
            Next rad

        Next row
    End Sub

    Private Sub visBruker()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        Dim fornavn As String
        Dim etternavn As String
        Dim fodselsdato As Date
        Dim telefon As Integer
        Dim adresse As String
        Dim postnummer As Integer


        brukerTab = Bruker.GetBruker(txtSok.Text)

        For Each row In brukerTab.Rows
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")

            txtFornavn.Text = fornavn
            txtEtternavn.Text = etternavn
            txtFodselsdato.Text = fodselsdato
            txtTelefon.Text = telefon
            txtAdresse.Text = adresse
            txtPostnummer.Text = postnummer

        Next row

    End Sub

    Private Sub endreInfo()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        Dim fornavn As String
        Dim etternavn As String
        Dim fodselsdato As Date
        Dim telefon As Integer
        Dim adresse As String
        Dim postnummer As Integer

        brukerTab = Bruker.GetBruker(txtSok.Text)

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")

            Bruker.endreFornavn(txtFornavn.Text)
            Bruker.endreEtternavn(txtEtternavn.Text)
            Bruker.endreFodselsdato(txtFodselsdato.Text)
            Bruker.endreTelefon(txtTelefon.Text)
            Bruker.endreAdresse(txtAdresse.Text)
            Bruker.endrePostnummer(txtPostnummer.Text)

        Next row
    End Sub


End Class