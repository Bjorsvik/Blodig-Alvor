
﻿Public Class Ansattside
    Dim Blodlager As New Blodlager()

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")

        KalenderGivning.MaxSelectionCount = 1 'Kalender for blodgivning
    End Sub

    'Sub-en under er for "Blodgivning"
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
        lblOversiktRes.Text = "Reservasjoner for: " & KalenderGivning.SelectionRange.Start.ToString
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

    Private Sub Lageroppdatering_Click(sender As Object, e As EventArgs) Handles Lageroppdatering.Click
        'Dim blodtype As String = cbBestill1.SelectedItem.ToString()
        'Dim teller As Integer = CInt(tellerAntallUtstyr.Value())
        'Dim vareTab As New DataTable()
        'Dim vareid As String
        'Dim utstyrTab As New DataTable()
        'Dim salgspris As String = 0
        'Dim innkjopspris As String = 0

        'vareTab = Vare.getVareIDByVarenavn(varenavn)
        'For Each row In vareTab.Rows
        '    vareid = row(0).ToString()
        'Next row

        'utstyrTab = utstyr.getUtstyrByID(vareid)
        'For Each rad In utstyrTab.Rows
        '    salgspris = rad("pris")
        '    innkjopspris = rad("innkjopspris")
        'Next rad


        'For i As Integer = 0 To teller - 1
        '    utstyr.regUtstyr(varenavn, salgspris, "0", innkjopspris)
        'Next i
    End Sub
End Class