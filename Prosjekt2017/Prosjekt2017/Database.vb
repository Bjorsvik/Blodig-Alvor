Imports MySql.Data.MySqlClient

Public Class Database

    Private connectionOK As Boolean = True
    Private connString As String = "Server=mysql.stud.iie.ntnu.no;" _
                                        & "Database=g_oops_23;" _
                                        & "Uid=g_oops_23;" _
                                        & "Pwd=3d4CcHvg;" _
                                        & "Convert Zero Datetime=True;" '12345

    Private tilkobling As New MySqlConnection

    'Spørring mot databasen,returnerer dataen.
    Public Function Query(ByVal sql As String) As DataTable

        tilkobling.ConnectionString = connString

        Dim myData As New DataTable

        If connectionOK = False Then
            'MsgBox("ikke ok")
        End If

        If connectionOK Then
            'MsgBox("conecction ok")
        End If

        Try
            tilkobling.Open()

            Dim myCommand As New MySqlCommand
            Dim myAdapter As New MySqlDataAdapter

            myCommand.Connection = tilkobling
            myCommand.CommandText = sql

            'MsgBox(connectionOK)

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)

            tilkobling.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error connecting to database" &
                myerror.Message)
        Finally
            tilkobling.Dispose()
        End Try

        Return myData
    End Function

End Class
