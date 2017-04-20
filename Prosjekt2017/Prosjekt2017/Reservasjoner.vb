Public Class Reservasjoner

    Dim db As New Database()
    Dim ansatt As New Ansatt()
    Dim blodgiver As New Blodgiver()

    Public Function getResValgtDato(ByVal resDato As String)
        Return db.Query("SELECT * from Reservasjon WHERE dato = '" & resDato & "'")
    End Function

    Public Function getPersResByPersID(ByVal personID As String) As DataTable
        Return db.Query("SELECT * from Reservasjon WHERE personID = '" & personID & "' AND dato >= NOW()")
    End Function

    Public Function getLastResID() As DataTable
        Return db.Query("SELECT MAX(resID) FROM Reservasjon")
    End Function

    Public Function getAlleTidspunkt() As DataTable
        Return db.Query("SELECT * from Tidspunkt")
    End Function

    Public Function getOpptattTimer(ByVal resDato) As DataTable
        Return db.Query("Select *
From Tidspunkt, Reservasjon
Where Tidspunkt.tidspunkt = Reservasjon.tidspunkt
And dato = '" & resDato & "'
And (SELECT COUNT(*) FROM Tidspunkt, Reservasjon
Where Tidspunkt.tidspunkt = Reservasjon.tidspunkt
And dato = '" & resDato & "') >=5
Group by Tidspunkt.tidspunkt")
    End Function

    Public Function getLastResIDByPersonID(personID As Integer) As DataTable
        Return db.Query("SELECT MAX(resID) As resID FROM Reservasjon JOIN Person ON Reservasjon.personID = Person.personID WHERE Person.personID = '" & personID & "'")
    End Function

    Public Sub reserver(ByVal dato As String, ByVal personID As Integer, ByVal tid As String)

        Dim resID As DataTable = getLastResID()
        Dim reservasjonID As String = ""
        Dim nextresID As Integer


        For Each id In resID.Rows
            reservasjonID = id(0).ToString()
        Next id

        If reservasjonID = "" Then
            reservasjonID = "0"
        End If

        nextresID = CInt(reservasjonID) + 1

        'MsgBox(CInt(reservasjonID))

        db.Query("INSERT INTO Reservasjon (resID, dato, personID, tidspunkt) VALUES ('" & nextresID & "', '" & dato & "', '" & personID & "', '" & tid & "');")
    End Sub


    Public Sub fyllCombobox(ByVal resDato, ByRef comboBox)
        Dim timer As DataTable = getAlleTidspunkt()
        Dim opptattTimer As DataTable = getOpptattTimer(resDato)
        Dim comboTimer As New ArrayList()
        Dim opptattArray As New ArrayList()
        Dim timeArray As New ArrayList()

        comboBox.DataSource = Nothing

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

        comboBox.DataSource = timeArray
        comboBox.DisplayMember = "Tidspunkt"
    End Sub

    Public Sub addReservasjon(ByRef ComboBox, ByVal personnummer, ByVal resDato)
        Dim personID As String = ""
        Dim tid As String = ComboBox.SelectedValue.ToString()


        Dim id As New DataTable()

        id = blodgiver.GetIDByPersonNr(personnummer)

        For Each rad In id.Rows
            personID = rad(0).ToString()
        Next rad
        Dim tempID As String = personID
        reserver(resDato, tempID, tid)
    End Sub

    Public Sub fyllDatagrid(ByVal idato As Date, ByRef Reservasjonskalender As Object, ByVal resDato As String, ByRef ResGrid As Object, ByVal reservasjonsTabell As DataTable)
        Dim resArray As New ArrayList()
        Dim dato As Date
        Dim persid As String
        Dim tidspunkt As String
        Dim resid As String
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

End Class
