Imports MySql.Data.MySqlClient

Public Class egenerklering
    Private tilkobling As MySqlConnection
    Dim bruker As New Blodgiver()
    Dim personID As Integer
    Dim liste As ArrayList
    Dim db As New Database()
    Dim dato As New Date()
    Dim dbDato As String

    Private Sub egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim personnummer = PubVar.personnummer
        visBrukerEgenerklering()
        dato = Date.Now
        dbDato = dato.Year & "-" & dato.Month & "-" & dato.Day
        lblDato.Text = dato
        Me.Show()
        Label1.Select() 'Får formen til å loade øverst på siden
    End Sub
    'Legger inn navn, etternavn og brukernummer i formen automatisk
    Private Sub visBrukerEgenerklering()
        Dim brukerTab As New DataTable()

        Dim fornavn As String
        Dim etternavn As String

        brukerTab = bruker.GetPersonnummer()

        For Each row In brukerTab.Rows

            fornavn = row("fornavn")
            etternavn = row("etternavn")
            personID = row("personID")

            lblFornavn.Text = fornavn
            lblEtternavn.Text = etternavn
            lblPersonID.Text = personID
        Next row
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSendInn.Click


        If chkSjekk.Checked Then

#Region "varsling_epost"
            Dim spmEpost As String
            If rbEpostJa.Checked Then
                spmEpost = 1
            Else
                spmEpost = 0
            End If

            Dim varsling_epost As String = spmEpost
#End Region 'Vi har valgt å dele inn spørsmålene i bolker.
#Region "varsling_sms"
            Dim spmSMS As String
            If rbSMSJa.Checked Then
                spmSMS = 1
            Else
                spmSMS = 0
            End If

            Dim varsling_sms As String = spmSMS
#End Region   'Vi regner en ny bolk for hver tjukke overskrift.
            '#Region "bolk1"

            '            Dim spm11, spm12, spm13, spm14, spm15, spm16 As String

            '            If rb111.Checked Then
            '                spm11 = 1
            '            Else
            '                spm11 = 0
            '            End If
            '            If rb121.Checked Then
            '                spm12 = 1
            '            Else
            '                spm12 = 0
            '            End If
            '            If rb131.Checked Then
            '                spm13 = 1
            '            Else
            '                spm13 = 0
            '            End If
            '            If rb141.Checked Then
            '                spm14 = 1
            '            Else
            '                spm14 = 0
            '            End If
            '            If rb151.Checked Then
            '                spm15 = 1
            '            Else
            '                spm15 = 0
            '            End If
            '            If rb161.Checked Then
            '                spm16 = 1
            '            Else
            '                spm16 = 0
            '            End If
            '            Dim bolk1 As String = spm11 + spm12 + spm13 + spm14 + spm15 + spm16

            '#End Region          'Vi starter med venstre side nedover før vi hopper
            '#Region "bolk2"

            '            Dim spm21, spm22, spm23, spm24, spm25 As String

            '            If rb211.Checked Then
            '                spm21 = 1
            '            Else
            '                spm21 = 0
            '            End If
            '            If rb221.Checked Then
            '                spm22 = 1
            '            Else
            '                spm22 = 0
            '            End If
            '            If rb231.Checked Then
            '                spm23 = 1
            '            Else
            '                spm23 = 0
            '            End If
            '            If rb241.Checked Then
            '                spm24 = 1
            '            Else
            '                spm24 = 0
            '            End If
            '            If rb251.Checked Then
            '                spm25 = 1
            '            Else
            '                spm25 = 0
            '            End If

            '            Dim bolk2 As String = spm21 + spm22 + spm23 + spm24 + spm25

            '#End Region          'Vi starter med venstre side nedover før vi hopper
            '#Region "bolk3"
            '            Dim spm31, spm32, spm33, spm34, spm35, spm36, spm37, spm38, spm39, spm310 As String

            '            If rb311.Checked Then
            '                spm31 = 1
            '            Else
            '                spm31 = 0
            '            End If
            '            If rb321.Checked Then
            '                spm32 = 1
            '            Else
            '                spm32 = 0
            '            End If
            '            If rb231.Checked Then
            '                spm33 = 1
            '            Else
            '                spm33 = 0
            '            End If
            '            If rb341.Checked Then
            '                spm34 = 1
            '            Else
            '                spm34 = 0
            '            End If
            '            If rb351.Checked Then
            '                spm35 = 1
            '            Else
            '                spm35 = 0
            '            End If
            '            If rb361.Checked Then
            '                spm36 = 1
            '            Else
            '                spm36 = 0
            '            End If
            '            If rb371.Checked Then
            '                spm37 = 1
            '            Else
            '                spm37 = 0
            '            End If
            '            If rb381.Checked Then
            '                spm38 = 1
            '            Else
            '                spm38 = 0
            '            End If
            '            If rb391.Checked Then
            '                spm39 = 1
            '            Else
            '                spm39 = 0
            '            End If
            '            If rb3101.Checked Then
            '                spm310 = 1
            '            Else
            '                spm310 = 0
            '            End If
            '            Dim bolk3 As String = spm31 + spm32 + spm33 + spm34 + spm35 + spm36 + spm37 + spm38 + spm39 + spm310
            '#End Region          'over på høyreside.
            '#Region "bolk4"
            '            Dim spm41 As String
            '            If rb411.Checked Then
            '                spm41 = 1
            '            Else
            '                spm41 = 0
            '            End If
            '            Dim bolk4 As String = spm41
            '#End Region          'Radioknappene er navngitt etter bolk, spørsmål, ja (1) og nei (2).
            '#Region "bolk5"
            '            Dim spm51, spm52, spm53, spm54, spm55, spm56, spm57, spm58, spm59,
            '                spm510, spm511, spm512, spm513, spm514, spm515 As String

            '            If rb511.Checked Then
            '                spm51 = 1
            '            Else
            '                spm51 = 0
            '            End If
            '            If rb521.Checked Then
            '                spm52 = 1
            '            Else
            '                spm52 = 0
            '            End If
            '            If rb531.Checked Then
            '                spm53 = 1
            '            Else
            '                spm53 = 0
            '            End If
            '            If rb541.Checked Then
            '                spm54 = 1
            '            Else
            '                spm54 = 0
            '            End If
            '            If rb551.Checked Then
            '                spm55 = 1
            '            Else
            '                spm55 = 0
            '            End If
            '            If rb561.Checked Then
            '                spm56 = 1
            '            Else
            '                spm56 = 0
            '            End If
            '            If rb571.Checked Then
            '                spm57 = 1
            '            Else
            '                spm57 = 0
            '            End If
            '            If rb581.Checked Then
            '                spm58 = 1
            '            Else
            '                spm58 = 0
            '            End If
            '            If rb591.Checked Then
            '                spm59 = 1
            '            Else
            '                spm59 = 0
            '            End If
            '            If rb5101.Checked Then
            '                spm510 = 1
            '            Else
            '                spm510 = 0
            '            End If
            '            If rb5111.Checked Then
            '                spm511 = 1
            '            Else
            '                spm511 = 0
            '            End If
            '            If rb5121.Checked Then
            '                spm512 = 1
            '            Else
            '                spm512 = 0
            '            End If
            '            If rb5131.Checked Then
            '                spm513 = 1
            '            Else
            '                spm513 = 0
            '            End If
            '            If rb5141.Checked Then
            '                spm514 = 1
            '            Else
            '                spm514 = 0
            '            End If
            '            If rb5151.Checked Then
            '                spm515 = 1
            '            Else
            '                spm515 = 0
            '            End If
            '            Dim bolk5 As String = spm51 + spm52 + spm53 + spm54 + spm55 + spm56 + spm57 + spm58 + spm59 + spm510 + spm511 + spm512 + spm513 + spm514 + spm515
            '#End Region          'Ja-kanppen på første spørsmål i første bolk for derfor rb111.
            '#Region "bolk6"
            '            Dim spm61, spm62, spm63, spm64, spm65, spm66, spm67 As String

            '            If rb611.Checked Then
            '                spm61 = 1
            '            Else
            '                spm61 = 0
            '            End If
            '            If rb621.Checked Then
            '                spm62 = 1
            '            Else
            '                spm62 = 0
            '            End If
            '            If rb631.Checked Then
            '                spm63 = 1
            '            Else
            '                spm63 = 0
            '            End If
            '            If rb631.Checked Then
            '                spm64 = 1
            '            Else
            '                spm64 = 0
            '            End If
            '            If rb651.Checked Then
            '                spm65 = 1
            '            Else
            '                spm65 = 0
            '            End If
            '            If rb661.Checked Then
            '                spm66 = 1
            '            Else
            '                spm66 = 0
            '            End If
            '            If rb671.Checked Then
            '                spm67 = 1
            '            Else
            '                spm67 = 0
            '            End If
            '            Dim bolk6 As String = spm61 + spm62 + spm63 + spm64 + spm65 + spm66 + spm67
            '#End Region          'Første tallet står for bolk, andre tallet står for spørsmål og tredje tall står for ja.
            '#Region "bolk7"
            '            Dim spm71, spm72, spm73, spm74 As String

            '            If rb711.Checked Then
            '                spm71 = 1
            '            Else
            '                spm71 = 0
            '            End If
            '            If rb721.Checked Then
            '                spm72 = 1
            '            Else
            '                spm72 = 0
            '            End If
            '            If rb731.Checked Then
            '                spm73 = 1
            '            Else
            '                spm73 = 0
            '            End If
            '            If rb741.Checked Then
            '                spm74 = 1
            '            Else
            '                spm74 = 0
            '            End If
            '            Dim bolk7 As String = spm71 + spm72 + spm73 + spm74
            '#End Region
            '#Region "bolk8"
            '            Dim spm81 As String

            '            If rb711.Checked Then
            '                rb811.Checked = False
            '            End If
            '            If rb811.Checked Then
            '                spm81 = 1
            '            Else
            '                spm81 = 0
            '            End If
            '            Dim bolk8 As String = spm81
            '#End Region
            '#Region "bolk9"
            '            Dim spm91, spm92, spm93, spm94, spm95, spm96, spm97, spm98, spm99, spm910 As String

            '            If rb911.Checked Then
            '                spm91 = 1
            '            Else
            '                spm91 = 0
            '            End If
            '            If rb921.Checked Then
            '                spm92 = 1
            '            Else
            '                spm92 = 0
            '            End If
            '            If rb931.Checked Then
            '                spm93 = 1
            '            Else
            '                spm93 = 0
            '            End If
            '            If rb941.Checked Then
            '                spm94 = 1
            '            Else
            '                spm94 = 0
            '            End If
            '            If rb951.Checked Then
            '                spm95 = 1
            '            Else
            '                spm95 = 0
            '            End If
            '            If rb961.Checked Then
            '                spm96 = 1
            '            Else
            '                spm96 = 0
            '            End If
            '            If rb371.Checked Then
            '                spm97 = 1
            '            Else
            '                spm97 = 0
            '            End If
            '            If rb981.Checked Then
            '                spm98 = 1
            '            Else
            '                spm98 = 0
            '            End If
            '            If rb991.Checked Then
            '                spm99 = 1
            '            Else
            '                spm99 = 0
            '            End If
            '            If rb9101.Checked Then
            '                spm910 = 1
            '            Else
            '                spm910 = 0
            '            End If
            '            Dim bolk9 As String = spm91 + spm92 + spm93 + spm94 + spm95 + spm96 + spm97 + spm98 + spm99 + spm910
            '#End Region

            Dim liste As String = ""

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Panel Then
                    For Each valg In ctrl.Controls.OfType(Of RadioButton)
                        If DirectCast(valg, RadioButton).Checked Then
                            liste += "1"
                        Else
                            liste += "0"
                        End If
                    Next
                End If
            Next

            'MsgBox(spmListe)

#Region "karantene"
            Dim karantene As Integer
            If rb811.Checked Or rb511.Checked Or rb521.Checked Or rb531.Checked Or rb541.Checked Or
                rb551.Checked Or rb561.Checked Or rb571.Checked Or rb581.Checked Or rb591.Checked Or
                rb5101.Checked Or rb5111.Checked Or rb5121.Checked Or rb5131.Checked Or rb5141.Checked Or
                rb5151.Checked Or rb911.Checked Or rb921.Checked Then
                karantene = 1000000 'Utestenges

            ElseIf rb411.Checked Then
                karantene = 730 'To års karantene

            ElseIf rb311.Checked Or rb311.Checked Or rb321.Checked Or rb331.Checked Or rb341.Checked Or
                        rb351.Checked Or rb361.Checked Or rb371.Checked Or rb381.Checked Or rb311.Checked Or
                        rb311.Checked Or rb711.Checked Or rb721.Checked Then
                karantene = 365

            ElseIf rb311.Checked Or rb321.Checked Or rb331.Checked Or rb341.Checked Or rb351.Checked Or
                rb361.Checked Or rb371.Checked Or rb381.Checked Or rb391.Checked Or rb3101.Checked Or
                rb611.Checked Or rb621.Checked Or rb631.Checked Or rb641.Checked Or rb651.Checked Or
                rb661.Checked Or rb671.Checked Or rb741.Checked Then

                karantene = 183 'Halvt års karantene

            ElseIf rb211.Checked Or rb212.Checked Or rb231.Checked Or rb241.Checked Or rb251.Checked Then
                karantene = 28
                End If
#End Region
            db.Query("Insert into Egenerklering (dato, varsling_epost, varsling_sms, bolk1, personID, karantene) values (" & dbDato & ", " & spmEpost & ", " & spmSMS & ", '" & liste & "', " & personID & ", " & karantene & ");")

            'db.Query("insert into Egenerklering (dato, varsling_epost, varsling_sms, bolk1, bolk2, bolk3, bolk4, bolk5, bolk6, bolk7, bolk8, bolk9, personID, karantene) 
            '               values (CURDATE(), @varsling_epost, @varsling_sms, @bolk1, @bolk2, @bolk3, @bolk4, @bolk5, @bolk6, @bolk7, @bolk8, @bolk9, @personID, DATE_ADD(CURDATE(), INTERVAL + @karantene DAY))")

            'Dim sqlbolker As New MySqlCommand(sqlSporring, tilkobling)

            'sqlbolker.Parameters.AddWithValue("@varsling_epost", varsling_epost)
            'sqlbolker.Parameters.AddWithValue("@varsling_sms", varsling_sms)
            'sqlbolker.Parameters.AddWithValue("@bolk1", bolk1)
            'sqlbolker.Parameters.AddWithValue("@bolk2", bolk2)
            'sqlbolker.Parameters.AddWithValue("@bolk3", bolk3)
            'sqlbolker.Parameters.AddWithValue("@bolk4", bolk4)
            'sqlbolker.Parameters.AddWithValue("@bolk5", bolk5)
            'sqlbolker.Parameters.AddWithValue("@bolk6", bolk6)
            'sqlbolker.Parameters.AddWithValue("@bolk7", bolk7)
            'sqlbolker.Parameters.AddWithValue("@bolk8", bolk8)
            'sqlbolker.Parameters.AddWithValue("@bolk9", bolk9)
            'sqlbolker.Parameters.AddWithValue("@personID", personID)
            'sqlbolker.Parameters.AddWithValue("@karantene", karantene)


            'sqlbolker.ExecuteNonQuery()
            MsgBox("Din egenerklæring er nå registrert.")
                Me.Close()
            Else
                MsgBox("Du må bekrefte at du har lest informasjonen øverst i spørreskjemaet", MsgBoxStyle.Information)
        End If
    End Sub
    'Knappen som sender inn spørreskjemaet
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        listbox1_egenerklering.Show()
        'Denne knappen åpner formen listbox1_egenerklering
    End Sub
    ''Denne suben gjør at når man trykker på en av radioknappene i bolk7 (besvares av kvinner)
    'vil det ikke være mulig å trykke på noen av spørsmålene i bolk 8 (besvares av menn)
    Private Sub rb711_CheckedChanged(sender As Object, e As EventArgs) Handles rb711.CheckedChanged,
        rb712.CheckedChanged, rb721.CheckedChanged, rb722.CheckedChanged, rb731.CheckedChanged,
        rb732.CheckedChanged, rb741.CheckedChanged, rb741.CheckedChanged

        If rb711.Checked = True Or rb712.Checked = True Or rb811.Checked = True Or
            rb721.Checked = True Or rb722.Checked = True Or rb731.Checked = True Or
            rb732.Checked = True Or rb741.Checked = True Or rb742.Checked = True Then

            rb811.Enabled = False
            rb812.Enabled = False
        End If

    End Sub
    'Denne suben gjør at når man trykker på en av radioknappene i bolk8 (besvares av herrer)
    'vil det ikke være mulig å trykke på noen av spørsmålene i bolk 7 (besvares av kvinner)
    Private Sub rb811_CheckedChanged(sender As Object, e As EventArgs) Handles rb811.CheckedChanged, rb812.CheckedChanged
        If rb811.Checked = True Or rb812.Checked Then
            rb711.Enabled = False
            rb712.Enabled = False
            rb721.Enabled = False
            rb722.Enabled = False
            rb731.Enabled = False
            rb732.Enabled = False
            rb741.Enabled = False
            rb742.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class