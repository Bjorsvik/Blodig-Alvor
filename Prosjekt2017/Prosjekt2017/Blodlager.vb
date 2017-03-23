Imports MySql.Data.MySqlClient
Public Class Blodlager
    Dim db As New Database()

    Dim blodtype As String
    Dim blodplasma As Integer = 0
    Dim blodplater As Integer = 0
    Dim blodlegeme As Integer = 0
    Public Function getAlleBlod() As DataTable
        Return db.Query("SELECT * FROM Blodlager")
    End Function

    Public Sub regBlod()
        db.Query("INSERT INTO Blodlager (blodtype, blodplasma, blodplater, blodlegeme) VALUES ('" & blodtype & "', '" & blodplasma & "', '" & blodplater & "' , '" & blodlegeme & "')")
    End Sub
End Class
