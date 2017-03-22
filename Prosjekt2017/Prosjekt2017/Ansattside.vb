Public Class Ansattside

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KalenderGivning.MaxSelectionCount = 1
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
        lblOversiktRes.Text = "Reservasjoner for: " & KalenderGivning.SelectionRange.Start.ToString
    End Sub
End Class