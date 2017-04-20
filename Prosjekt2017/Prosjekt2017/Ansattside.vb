﻿Imports MySql.Data.MySqlClient
Public Class Ansattside
    Dim Postnr As New Postnummer()
    Dim Blodlager As New Blodlager()
    Dim blodgiver As New Blodgiver()
    Dim person As New Person()
    Dim res As New Reservasjoner()
    Dim ansatt As New Ansatt()
    Dim personID As String = "0"


    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visAlleBlodplasma()
        visAlleBlodCeller()
        visAlleBlodplater()
        Reservasjonskalender.MinDate = Date.Now

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
        Dim personIDTab As New DataTable
        Dim blodIDTab As New DataTable
        Dim resIDTab As New DataTable

        personIDTab = person.getPersonID(personnummer)

        For Each row In personIDTab.Rows
            pID = row("personID")
            blodtype = row("blodtype")

        Next

        'MsgBox(pID)

        resIDTab = res.getLastResIDByPersonID(pID)

        For Each row In resIDTab.Rows
            rID = row("resID")
        Next

        'MsgBox(rID)

        Blodlager.leggInnBlodposer(blodtype, blodposer, rID)
        MessageBox.Show("Blodpose har blitt lagt inn", "Fullført")




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

        personIDTab = person.getPersonID(personnummer)

        For Each row In personIDTab.Rows
            pID = row("personID")

        Next

        'MsgBox(pID)

        resIDTab = res.getLastResIDByPersonID(pID)

        For Each row In resIDTab.Rows
            rID = row("resID")
        Next

        'MsgBox(rID)

        blodIDTab = Blodlager.getLastBlodIDByResID(rID)

        For Each row In blodIDTab.Rows
            bID = row("blodID")
        Next

        'MsgBox(bID)

        Dim celleposer As Integer = cboBlodlegeme.Text
        Dim plasmaposer As Integer = cboBlodplasma.Text
        Dim plateposer As Integer = cboBlodplater.Text
        Dim dato As String = Date.Now.ToString("yyyy-MM-dd")

        MsgBox("Celleposer:" & celleposer)
        MsgBox("Plasmaposer:" & plasmaposer)
        MsgBox("Plateposer:" & plateposer)

        'MsgBox(dato)

        Blodlager.leggInnBlodlegeme(lagerID, bID, celleposer, dato)
        Blodlager.leggInnBlodplasma(lagerID, bID, plasmaposer)
        Blodlager.leggInnBlodplater(lagerID, bID, plateposer, dato)



    End Sub

    Private Sub skrivUtBlodProdukter()
        Dim ant_plasmaposer As Integer = cboBlodplasma.Text
        Dim ant_celleposer As Integer = cboBlodlegeme.Text
        Dim ant_plateposer As Integer = cboBlodplater.Text
        Dim blodtype As String = cboBlod.Text

        Blodlager.skrivUtBlodceller(ant_celleposer, blodtype)
        Blodlager.skrivUtBlodplater(ant_plateposer, blodtype)
        Blodlager.skrivUtBlodplasma(ant_plasmaposer, blodtype)
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


        brukerTab = blodgiver.GetBruker(txtSok.Text)

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

        brukerTab = blodgiver.GetBruker(txtSok.Text)

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")
            blodtype = row("blodtype")

            blodgiver.endreFornavn(txtFornavn.Text)
            blodgiver.endreEtternavn(txtEtternavn.Text)
            blodgiver.endreFodselsdato(txtFodselsdato.Text)
            blodgiver.endreTelefon(txtTelefon.Text)
            blodgiver.endreAdresse(txtAdresse.Text)
            blodgiver.endrePostnummer(txtPostnummer.Text)
            blodgiver.endreBlodtype(cboBlodType.Text)

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

        blodPlasmaTab = Blodlager.getAlleTilgjengeligeBlodPlasma()



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

        blodPlaterTab = Blodlager.getAlleTilgjengeligeBlodplater
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

        blodCellerTab = Blodlager.getAlleTilgjengeligeBlodceller
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
        Dim idato As Date = Reservasjonskalender.SelectionRange.Start
        Dim resDato As String = idato.ToString("yyyy-MM-dd")
        Dim reservasjonsTabell As New DataTable
        Dim resArray As New ArrayList()
        Dim dato As Date
        Dim persid As String
        Dim tidspunkt As String
        Dim resid As String
        reservasjonsTabell = res.getResValgtDato(resDato)
        ResGrid.Rows.Clear()

        'MsgBox(dbDato)

        For Each reserv In reservasjonsTabell.Rows()
            resid = reserv(0).ToString
            dato = reserv(1).ToString
            persid = reserv(2).ToString
            tidspunkt = reserv(3).ToString
            ResGrid.Rows.Add(dato.ToString("yyyy-MM-dd"), tidspunkt, persid, resid)
        Next

        res.fyllCombobox(resDato, ComboBox1)



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

    Private Sub ResGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResGrid.CellContentClick
        If e.ColumnIndex <> 4 Then
            Exit Sub
        End If

        Dim resID As Integer
        If e.ColumnIndex = 4 Then

            resID = ResGrid.Rows(e.RowIndex).Cells(3).Value
            ansatt.slettResAvResID(resID)
            MsgBox(resID)

            ResGrid.Rows.RemoveAt(e.RowIndex)


        End If
    End Sub

    Private Sub personnummer_TextChanged(sender As Object, e As EventArgs) Handles personnummer.TextChanged
        personnummer.MaxLength = 11
        If personnummer.TextLength = 11 Then
            Dim IDTab As New DataTable()

            IDTab = blodgiver.GetIDByPersonNr(personnummer.Text)

            For Each row In IDTab.Rows
                personID = row(0)
                MsgBox(personID)
            Next row

            If personID = "0" Then
                MsgBox("Personnummeret du søker etter eksisterer ikke")
            End If

        End If
    End Sub
End Class