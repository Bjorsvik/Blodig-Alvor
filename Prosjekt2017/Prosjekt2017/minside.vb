Imports MySql.Data.MySqlClient
Public Class minside
    Dim bg As New Blodgiver()
    Dim postnr As New Postnummer()
    Dim res As New Reservasjoner
    Dim resDato As String
    Dim fornavn As String
    Dim etternavn As String
    Dim fodselsdato As String
    Dim personnummer As String
    Dim telefon As Integer
    Dim adresse As String
    Dim postnummer As Integer
    Dim personID As Integer


    Private Sub minside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim personnummer = PubVar.personnummer

        visBruker()
        visPoststed()

        MonthCalendar1.MinDate = Date.Today() 'Gjør slik at dato fra fortiden ikke kan velges

        'Henter karantene.
        Dim karanteneTabell As DataTable = bg.getKarantene(personID)
        Dim karantene As New ArrayList()
        Dim k As Date

        For Each i In karanteneTabell.Rows
            karantene.Add(i(0).ToString)
        Next
        k = (karantene(0))
        'MsgBox(k.ToString)

        If Date.Today() < k Then
            MonthCalendar1.MinDate = k
        End If

        'henter livstid.
        Dim livstidTabell As DataTable = bg.getLivstid(personID)
        Dim livstid As New ArrayList()
        Dim li As Boolean

        For Each i In livstidTabell.Rows
            livstid.Add(i(0).ToString)
        Next
        li = (livstid(0))
        'MsgBox(li.ToString)
        If li = True Then
            MonthCalendar1.Hide()
            Label4.Show()
            ComboBox1.Hide()
            MsgBox("Din karantene for å gi blod er på livstid")
            MsgBox("Du vil nå bli logget ut")
            Me.Close()
        End If


    End Sub
    Private Sub btnEndreInfo_Click(sender As Object, e As EventArgs) Handles btnEndreInfo.Click
        endreInfo()
        visBruker()
        visPoststed()
    End Sub

    Private Sub visBruker()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        brukerTab = bg.GetPersonnummer()

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            personnummer = row("personnummer")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")
            personID = row("personID")

            txtFornavn.Text = fornavn
            txtEtternavn.Text = etternavn
            txtFodselsdato.Text = fodselsdato
            txtPersonnummer.Text = personnummer
            txtTelefon.Text = telefon
            txtAdresse.Text = adresse
            txtPostnummer.Text = postnummer
            lbPersonID.Text = personID

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

    Private Sub endreInfo()
        Dim brukerTab As New DataTable()
        Dim postnummere As New DataTable()

        brukerTab = bg.GetPersonnummer()

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            fodselsdato = row("fodselsdato")
            personnummer = row("personnummer")
            telefon = row("telefon")
            adresse = row("adresse")
            postnummer = row("postnummer")

            bg.endreFornavn(txtFornavn.Text)
            bg.endreEtternavn(txtEtternavn.Text)
            bg.endreFodselsdato(txtFodselsdato.Text)
            bg.endreTelefon(txtTelefon.Text)
            bg.endreAdresse(txtAdresse.Text)
            bg.endrePostnummer(txtPostnummer.Text)

        Next row
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim personID As String
        Dim tid As String = ComboBox1.SelectedValue.ToString()


        Dim id As New DataTable()

        id = bg.GetIDByPersonNr(personnummer)

        For Each rad In id.Rows
            personID = rad(0).ToString()
        Next rad
        Dim tempID As Integer = CInt(personID)
        res.reserver(resDato, tempID, tid)
        'MsgBox(tid)


    End Sub

    Private Sub btnSkjema_Click(sender As Object, e As EventArgs) Handles btnSkjema.Click
        egenerklering.Show()
    End Sub

    Public Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim dato As New Date()
        dato = MonthCalendar1.SelectionRange.Start
        resDato = dato.Year & "-" & dato.Month & "-" & dato.Day
        Dim timer As DataTable = res.getAlleTidspunkt()
        Dim opptattTimer As DataTable = res.getOpptattTimer(resDato)
        Dim comboTimer As New ArrayList()
        Dim opptattArray As New ArrayList()
        Dim timeArray As New ArrayList()


        ComboBox1.DataSource = Nothing
        'MsgBox(opptattTimer.ToString)

        ' For Each time In timer.Rows
        '    For Each opptatt In opptattTimer.Rows
        '   If time(0).ToString <> opptatt(0).ToString Then
        ' If comboTimer.Contains(time(0).ToString) = False Then
        '  comboTimer.Add(time(0).ToString)
        ' End If
        'End If
        'Next
        'Next
        For Each time In timer.Rows
            timeArray.Add(time(0).ToString)
        Next
        For Each opptatt In opptattTimer.Rows
            opptattArray.Add(opptatt(0).ToString)
        Next

        'MsgBox(opptattArray.Count.ToString)
        For i = 0 To opptattArray.Count - 1
            If timeArray.Contains(opptattArray(i).ToString) Then
                timeArray.Remove(opptattArray(i).ToString)
            End If
        Next


        'If opptattTimer.Rows.Count < 1 Then
        '    ComboBox1.DataSource = timer
        'Else
        '    ComboBox1.DataSource = comboTimer
        'End If

        ComboBox1.DataSource = timeArray
        ComboBox1.DisplayMember = "Tidspunkt"
    End Sub

    'Private Sub visBrukeren()
    '    Dim SDA As New MySqlDataAdapter
    '    Dim dbDataset As New DataTable
    '    Dim bSource As New BindingSource
    '    Try
    '        tilkobling.Open()
    '        Dim tuddle As String = "'"
    '        Dim telefondb As String = tuddle & telefon & tuddle
    '        Dim Query As String
    '        Query = "SELECT fornavn, etternavn, adresse, telefon, fodselsdato, Blodgiver.postnummer, Postnummer.poststed from Blodgiver JOIN Postnummer ON Postnummer.postnummer = Blodgiver.postnummer WHERE Blodgiver.telefon = " & telefondb
    '        Dim command As New MySqlCommand(Query, tilkobling)
    '        SDA.SelectCommand = command
    '        SDA.Fill(dbDataset)
    '        bSource.DataSource = dbDataset
    '        DataGridView1.DataSource = bSource
    '        SDA.Update(dbDataset)

    '        tilkobling.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        tilkobling.Dispose()
    '    End Try
    'End Sub
End Class