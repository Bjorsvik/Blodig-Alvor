Public Class Ansattside

    Private Sub Ansattside_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.MaxSelectionCount = 1
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Label1.Text = "Reservasjoner for: " & MonthCalendar1.SelectionRange.Start.ToString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class