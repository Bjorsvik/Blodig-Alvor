Imports MySql.Data.MySqlClient
Public Class Postnummer
    Dim db As New Database

    Public Sub New()
    End Sub
    Public Function GetPoststed(postnummer As Integer) As DataTable
        Return db.Query("SELECT poststed From Postnummer WHERE postnummer = " & "'" & postnummer & "'")
    End Function
End Class
