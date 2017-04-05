Imports MySql.Data.MySqlClient
Public Class Ansattside
    Private tilkobling As MySqlConnection

    Dim Postnr As New Postnummer()

    Dim Blodlager As New Blodlager()
    Dim Bruker As New Blodgiver()
    Dim Blodprodukter As New Blodlager()
    Dim BlodInsert As New Blodlager()
    Dim blodID As New Blodlager()

    Dim personID As New Person()
    Dim resID As New Reservasjoner()


    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visAlleBlodprodukter()
    End Sub
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        leggTilBlodProdukter()
        visAlleBlodprodukter()
    End Sub
    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        visBruker()
        visPoststed()
    End Sub

    Private Sub btnEndreInfo_Click(sender As Object, e As EventArgs) Handles btnEndreInfo.Click
        endreInfo()
        visBruker()
        visPoststed()
    End Sub

    Private Sub leggTilBlodProdukter()
        Dim personnummer As String = txtLagerPersonnummer.Text
        Dim pID As String = ""
        Dim bID As String = ""
        Dim rID As String = ""
        Dim lagerID As Integer = "1"
        Dim personIDTab As New DataTable
        Dim blodIDTab As New DataTable
        Dim resIDTab As New DataTable

        personIDTab = personID.getPersonID(personnummer)

        For Each row In personIDTab.Rows
            pID = row("personID")

        Next
        MsgBox(pID)

        resIDTab = resID.getLastResIDByPersonID(pID)

        For Each row In resIDTab.Rows
            rID = row("resID")
        Next

        MsgBox(rID)

        blodIDTab = blodID.getLastBlodIDByResID(rID)

        For Each row In blodIDTab.Rows
            bID = row("blodID")
        Next

        MsgBox(bID)

        Dim celleposer As Integer = cboBlodlegeme.Text
        Dim plasmaposer As Integer = cboBlodplasma.Text
        Dim plateposer As Integer = cboBlodplater.Text
        Dim dato As String = Date.Now.ToString("yyyy-MM-dd")

        MsgBox("Celleposer:" & celleposer)
        MsgBox("Plasmaposer:" & plasmaposer)
        MsgBox("Plateposer:" & plateposer)
        MsgBox(dato)

        BlodInsert.leggInnBlodlegeme(lagerID, bID, celleposer, dato)
        BlodInsert.leggInnBlodplasma(lagerID, bID, plasmaposer)
        BlodInsert.leggInnBlodplater(lagerID, bID, plateposer, dato)



    End Sub

    Private Sub skrivUtBlodProdukter()

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
        Dim blodtype As String


        brukerTab = Bruker.GetBruker(txtSok.Text)

        For Each row In brukerTab.Rows
            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")
            blodtype = row("blodtype")

            txtFornavn.Text = fornavn
            txtEtternavn.Text = etternavn
            txtFodselsdato.Text = fodselsdato
            txtTelefon.Text = telefon
            txtAdresse.Text = adresse
            txtPostnummer.Text = postnummer
            cboBlodType.Text = blodtype

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
        Dim blodtype As String

        brukerTab = Bruker.GetBruker(txtSok.Text)

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")
            blodtype = row("blodtype")

            Bruker.endreFornavn(txtFornavn.Text)
            Bruker.endreEtternavn(txtEtternavn.Text)
            Bruker.endreFodselsdato(txtFodselsdato.Text)
            Bruker.endreTelefon(txtTelefon.Text)
            Bruker.endreAdresse(txtAdresse.Text)
            Bruker.endrePostnummer(txtPostnummer.Text)
            Bruker.endreBlodtype(cboBlodType.Text)

        Next row
    End Sub
    Private Sub visPoststed()

        Dim postnummerTab As New DataTable()

        Dim poststed As String

        postnummerTab = Postnr.GetPoststed(txtPostnummer.Text)

        For Each row In postnummerTab.Rows
            poststed = row("poststed")

            lbPoststed.Text = poststed
        Next row

    End Sub

    Private Sub visAlleBlodprodukter()
        Dim blodproduktTab As New DataTable()
        Dim blodtype As String
        Dim blodplasma As String
        Dim blodplater As String
        Dim blodceller As String

        gridBlodlager.Rows.Clear()

        blodproduktTab = Blodprodukter.getAlleBlodProdukter()
        For Each row In blodproduktTab.Rows
            blodtype = row("Blodtype")
            blodplasma = row("Plasmaposer")
            blodplater = row("Plateposer")
            blodceller = row("Celleposer")

            gridBlodlager.Rows.Add(blodtype, blodplasma, blodplater, blodceller)

        Next row
    End Sub

End Class