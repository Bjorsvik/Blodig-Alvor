Public Class Reservasjoner

    Dim db As New Database()
    Dim ansatt As New Ansatt()
    Dim blodgiver As New Blodgiver()


    Public Function getGjeldendeReservasjoner()
        Return db.Query("SELECT * from Reservasjon WHERE dato >= GETDATE()")
    End Function

    Public Function getResValgtDato(ByVal resDato As String)
        Return db.Query("SELECT * from Reservasjon WHERE dato = '" & resDato & "'")
    End Function

    Public Function getAlleReservasjoner() As DataTable
        Return db.Query("SELECT * from Reservasjon")
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

End Class
