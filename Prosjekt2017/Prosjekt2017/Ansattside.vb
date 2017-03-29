Imports MySql.Data.MySqlClient
Public Class Ansattside
    Private tilkobling As MySqlConnection
    Dim Blodlager As New Blodlager()
    Dim Bruker As New Blodgiver()
    Dim postnr As New Postnummer()

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        visBruker()
        visPoststed()
    End Sub

    Private Sub btnEndreInfo_Click(sender As Object, e As EventArgs) Handles btnEndreInfo.Click
        endreInfo()
        visBruker()
        visPoststed()
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
        PubVar.personnummer = txtSok.Text

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
    Private Sub visPoststed()

        Dim postnummerTab As New DataTable()

        Dim poststed As String

        postnummerTab = postnr.GetPoststed(txtPostnummer.Text)

        For Each row In postnummerTab.Rows
            poststed = row("poststed")

            lbPoststed.Text = poststed
        Next row

    End Sub

    Private Sub Innkalling_Click(sender As Object, e As EventArgs) Handles Innkalling.Click
    End Sub
End Class