Public Class Blodlager
    Dim db As New Database()
    Public Sub New()
    End Sub

    Public Function getAlleBlod() As DataTable
        Return db.Query("SELECT * FROM Blodlager")
    End Function

    Public Function getAlleBlodProdukter()
        Return db.Query("SELECT DISTINCT blodtype AS Blodtype, SUM(plasma_poser) As Plasmaposer, SUM(plater_poser) As Plateposer, SUM(celler_poser) AS Celleposer FROM Blodtype
                         Join Blodplasma ON Blodtype.blodID = Blodplasma.blodID
                         Join Blodplater ON Blodtype.blodID = Blodplater.blodID
                         Join Blodceller ON Blodtype.blodID = Blodceller.blodID
                         GROUP BY blodtype
                         ORDER BY blodtype")
    End Function

    Public Function getAlleTilgjengeligeBlodPlasma()
        Return db.Query("SELECT blodtype, plasma_poser From Blodtype JOIN Blodplasma ON Blodtype.blodID = Blodplasma.blodID")
    End Function

    Public Function getAlleTilgjengeligeBlodceller()
        Return db.Query("SELECT * From (
    SELECT
    blodtype,
    celler_poser,
    Blodceller.dato As dato,
    DATEDIFF(Blodceller.dato, CURDATE()) As diffCeller
    
     FROM Blodtype
                         Join Blodceller ON Blodtype.blodID = Blodceller.blodID                   
    ) As innertable

    Where diffCeller < 7")
    End Function

    Public Function getAlleTilgjengeligeBlodplater()
        Return db.Query("SELECT * From (
    SELECT
    blodtype,
    plater_poser,
    Blodplater.dato As dato,
    DATEDIFF(Blodplater.dato, CURDATE()) As diffPlater
    
     FROM Blodtype
                         Join Blodplater ON Blodtype.blodID = Blodplater.blodID                   
    ) As innertable

    Where diffPlater < 30")
    End Function

    Public Function getLastBlodIDByResID(ByVal reservasjonsID As String) As DataTable
        Return db.Query("SELECT MAX(blodID) AS blodID FROM Blodtype
                         JOIN Reservasjon ON Blodtype.resID = Reservasjon.resID
                         Where Reservasjon.resID = '" & reservasjonsID & "'")
    End Function

    Public Sub leggInnBlodplasma(ByVal lagerID As Integer, ByVal blodID As Integer, ByVal plasmaposer As Integer)
        db.Query("INSERT INTO Blodplasma(lagerID, blodID, plasma_poser) VALUES ('" & lagerID & "', '" & blodID & "', '" & plasmaposer & "' )")
    End Sub

    Public Sub leggInnBlodlegeme(ByVal lagerID As Integer, ByVal blodID As Integer, ByVal celleposer As Integer, ByVal dato As String)
        db.Query("INSERT INTO Blodceller(lagerID, blodID, celler_poser, dato) VALUES ('" & lagerID & "', '" & blodID & "', '" & celleposer & "', '" & dato & "' )")
    End Sub

    Public Sub leggInnBlodplater(ByVal lagerID As Integer, ByVal blodID As Integer, ByVal plateposer As Integer, ByVal dato As String)
        db.Query("INSERT INTO Blodplater(lagerID, blodID, plater_poser, dato) VALUES ('" & lagerID & "', '" & blodID & "', '" & plateposer & "', '" & dato & "' )")
    End Sub

End Class