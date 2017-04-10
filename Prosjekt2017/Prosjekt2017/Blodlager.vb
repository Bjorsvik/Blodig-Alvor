Public Class Blodlager
    Dim db As New Database()
    Public Sub New()
    End Sub

    Public Function getAlleBlod() As DataTable
        Return db.Query("SELECT * FROM Blodlager")
    End Function
    Public Sub leggInnBlodposer(blodtype As String, blodposer As Integer, resID As Integer)
        db.Query("INSERT INTO Blodtype(blodtype, blodposer, resID) Values ('" & blodtype & "', '" & blodposer & "', '" & resID & "')")
    End Sub


    Public Function getAlleBlodProdukter()
        Return db.Query("Select DISTINCT blodtype As Blodtype, SUM(plasma_poser) As Plasmaposer, SUM(plater_poser) As Plateposer, SUM(celler_poser) AS Celleposer FROM Blodtype
                         Join Blodplasma ON Blodtype.blodID = Blodplasma.blodID
                         Join Blodplater ON Blodtype.blodID = Blodplater.blodID
                         Join Blodceller ON Blodtype.blodID = Blodceller.blodID
                         GROUP BY blodtype
                         ORDER BY blodtype")
    End Function

    Public Sub skrivUtBlodplasma(antall As Integer, blodtype As String)
        db.Query("UPDATE Blodplasma JOIN Blodtype ON Blodplasma.blodID = Blodtype.blodID
                  SET plasma_poser = plasma_poser - " & antall & " WHERE blodtype = '" & blodtype & "'")
    End Sub

    Public Sub skrivUtBlodplater(antall As Integer, blodtype As String)
        db.Query("UPDATE Blodplater JOIN Blodtype ON Blodplater.blodID = Blodtype.blodID
                  SET plater_poser = plater_poser - " & antall & " WHERE blodtype = '" & blodtype & "'")
    End Sub

    Public Sub skrivUtBlodceller(antall As Integer, blodtype As String)
        db.Query("UPDATE Blodceller JOIN Blodtype ON Blodceller.blodID = Blodtype.blodID
                  SET celler_poser = celler_poser - " & antall & " WHERE blodtype = '" & blodtype & "'")
    End Sub

    Public Function getAlleTilgjengeligeBlodPlasma() As DataTable
        Return db.Query("SELECT blodtype, SUM(plasma_poser) As Plasmaposer From Blodtype JOIN Blodplasma ON Blodtype.blodID = Blodplasma.blodID
                         Group By blodtype")
    End Function

    Public Function getAlleTilgjengeligeBlodceller() As DataTable
        Return db.Query("SELECT * From (
    SELECT
    blodtype,
    SUM(celler_poser) As Cellerposer,
    Blodceller.dato As dato,
    DATEDIFF(Blodceller.dato, CURDATE()) As diffCeller
    
     FROM Blodtype
                         Join Blodceller ON Blodtype.blodID = Blodceller.blodID  
    Group By blodtype                 
    ) As innertable

    Where diffCeller < 36")
    End Function

    Public Function getAlleTilgjengeligeBlodplater() As DataTable
        Return db.Query("SELECT * From (
    SELECT
    blodtype,
    SUM(plater_poser) As Platerposer,
    Blodplater.dato As dato,
    DATEDIFF(Blodplater.dato, CURDATE()) As diffPlater
    
     FROM Blodtype
                         Join Blodplater ON Blodtype.blodID = Blodplater.blodID  
     Group By blodtype                 
    ) As innertable
    Where diffPlater < 8")
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