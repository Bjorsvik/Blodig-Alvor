Public Class Ansattside

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KalenderGivning.MaxSelectionCount = 1 'Kalender for blodgivning
    End Sub

    'Sub-en under er for "Blodgivning"
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
        lblOversiktRes.Text = "Reservasjoner for: " & KalenderGivning.SelectionRange.Start.ToString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class