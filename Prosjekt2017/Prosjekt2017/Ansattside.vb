Imports MySql.Data.MySqlClient
Public Class Ansattside
    Private tilkobling As MySqlConnection

    Dim Postnr As New Postnummer()

    Dim Blodlager As New Blodlager()
    Dim Bruker As New Blodgiver()
    Dim Blodprodukter As New Blodlager()
    Dim BlodposeInsert As New Blodlager()
    Dim BlodInsert As New Blodlager()
    Dim BlodUtskrift As New Blodlager()
    Dim blodID As New Blodlager()

    Dim personID As New Person()
    Dim res As New Reservasjoner()


    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visAlleBlodplasma()
        visAlleBlodCeller()
        visAlleBlodplater()
    End Sub
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        leggTilBlodProdukter()
        visAlleBlodplasma()
        visAlleBlodplater()
        visAlleBlodCeller()
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

    Private Sub LeggtilBlod()
        Dim personnummer As String = txtPersonnr.Text
        Dim pID As String = ""
        Dim blodtype As String = ""
        Dim bID As String = ""
        Dim rID As String = ""
        Dim blodposer As Integer = numBlodmengde.Text
        Dim personIDTab As New Datatable 
        Dim blodIDTab As New DataTable
        Dim resIDTab As New DataTable

        personIDTab = personID.getPersonID(personnummer)

        For Each row In personIDTab.Rows
            pID = row("personID")
            blodtype = row("blodtype")

        Next
        MsgBox(pID)

        resIDTab = res.getLastResIDByPersonID(pID)

        For Each row In resIDTab.Rows
            rID = row("resID")
        Next

        MsgBox(rID)

        BlodposeInsert.leggInnBlodposer(blodtype, blodposer, rID)





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

        'resIDTab = resID.getLastResIDByPersonID(pID)

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
        Dim ant_plasmaposer As Integer = cboBlodplasma.Text
        Dim ant_celleposer As Integer = cboBlodlegeme.Text
        Dim ant_plateposer As Integer = cboBlodplater.Text
        Dim blodtype As String = cboBlod.Text

        BlodUtskrift.skrivUtBlodceller(ant_celleposer, blodtype)
        BlodUtskrift.skrivUtBlodplater(ant_plateposer, blodtype)
        BlodUtskrift.skrivUtBlodplasma(ant_plasmaposer, blodtype)
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

    Private Sub visAlleBlodplasma()
        Dim blodPlasmaTab As New DataTable()

        Dim blodtype As String
        Dim blodplasma As String

        gridBlodplasma.Rows.Clear()

        blodPlasmaTab = Blodprodukter.getAlleTilgjengeligeBlodPlasma()



        For Each row In blodPlasmaTab.Rows
            blodtype = row("blodtype")
            blodplasma = row("Plasmaposer")

            gridBlodplasma.Rows.Add(blodtype, blodplasma)

        Next row

    End Sub

    Private Sub visAlleBlodplater()
        Dim blodPlaterTab As New DataTable()

        Dim blodtype As String
        Dim blodplater As String

        gridBlodplater.Rows.Clear()

        blodPlaterTab = Blodprodukter.getAlleTilgjengeligeBlodplater
        For Each row In blodPlaterTab.Rows
            blodtype = row("blodtype")
            blodplater = row("PlaterPoser")

            gridBlodplater.Rows.Add(blodtype, blodplater)
        Next row

    End Sub

    Private Sub visAlleBlodCeller()
        Dim blodCellerTab As New DataTable()

        Dim blodtype As String
        Dim blodceller As String

        gridBlodceller.Rows.Clear()

        blodCellerTab = Blodprodukter.getAlleTilgjengeligeBlodceller
        For Each row In blodCellerTab.Rows
            blodtype = row("blodtype")
            blodceller = row("Cellerposer")

            gridBlodceller.Rows.Add(blodtype, blodceller)
        Next row
    End Sub

    Private Sub btnSkrivUt_Click(sender As Object, e As EventArgs) Handles btnSkrivUt.Click
        skrivUtBlodProdukter()
        visAlleBlodCeller()
        visAlleBlodplasma()
        visAlleBlodplater()
    End Sub

    Private Sub btnBlodgivning_Click(sender As Object, e As EventArgs) Handles btnBlodgivning.Click
        LeggtilBlod()
    End Sub

    Private Sub Reservasjonskalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Reservasjonskalender.DateChanged
        Dim resDato As Date = Reservasjonskalender.SelectionRange.Start
        Dim dbDato As String = resDato.ToString("yyyy-MM-dd")
        Dim reservasjonsTabell As New DataTable
        Dim resArray As New ArrayList()
        Dim dato As Date
        Dim persid As String
        Dim tidspunkt As String
        Dim resid As String
        reservasjonsTabell = res.getResValgtDato(dbDato)
        ResGrid.Rows.Clear()

        'MsgBox(dbDato)

        For Each reserv In reservasjonsTabell.Rows()
            resid = reserv(0).ToString
            dato = reserv(1).ToString
            persid = reserv(2).ToString
            tidspunkt = reserv(3).ToString
            ResGrid.Rows.Add(dato.ToString("yyyy-MM-dd"), tidspunkt, persid, resid)
        Next




    End Sub

    Private Sub btnLogUt_Click(sender As Object, e As EventArgs) Handles btnLogUt.Click
        Me.Close()
        Hjemmeside.lbInput.Hide()
        Hjemmeside.lbPassord.Hide()
        Hjemmeside.txtInput.Hide()
        Hjemmeside.txtPassord.Hide()
        Hjemmeside.btnLogginn.Hide()
        Hjemmeside.btnRegistrer.Hide()
        Hjemmeside.btnBlodgiver.Show()
        Hjemmeside.btnAnsatt.Show()
        Hjemmeside.Show()
    End Sub
End Class