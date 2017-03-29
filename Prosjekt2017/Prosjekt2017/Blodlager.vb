Public Class Blodlager
    Dim db As New Database()
    Public Sub New()
    End Sub

    Public Function getAlleBlod() As DataTable
        Return db.Query("SELECT * FROM Blodlager")
    End Function


    'Public Function getAlleBlodtypeA()
    '    Return db.Query("SELECT DISTINCT blodtype, SUM(plasma_poser) AS PlasmaPoser, SUM(plater_poser) AS PlatePoser, SUM(celler_poser) AS CellePoser FROM Blodtype
    '                     JOIN Blodplasma ON Blodtype.blodID = Blodplasma.blodID
    '                     JOIN Blodplater ON Blodtype.blodID = Blodplater.blodID
    '                     JOIN Blodceller ON Blodtype.blodID = Blodceller.blodID
    '                     WHERE Blodtype.blodtype = 'A'")
    'End Function

    Public Function getAlleBlodProdukter()
        Return db.Query("SELECT DISTINCT blodtype AS Blodtype, SUM(plasma_poser) As Plasmaposer, SUM(plater_poser) As Plateposer, SUM(celler_poser) AS Celleposer FROM Blodtype
                         Join Blodplasma ON Blodtype.blodID = Blodplasma.blodID
                         Join Blodplater ON Blodtype.blodID = Blodplater.blodID
                         Join Blodceller ON Blodtype.blodID = Blodceller.blodID
                         GROUP BY blodtype
                         ORDER BY blodtype")
    End Function

    Public Function getLastBlodIDByPersonID(ByVal personID As String)
        Return db.Query("SELECT MAX(blodID) AS blodID FROM Blodtype
                         JOIN Reservasjon ON Blodtype.resID = Reservasjon.resID
                         JOIN Person ON Reservasjon.personID = Person.personID
                         Where Person.personID = '" & personID & "'")
    End Function
    Private Sub leggInnBlodProdukter()
    End Sub
End Class