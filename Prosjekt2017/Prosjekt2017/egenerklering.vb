Imports MySql.Data.MySqlClient

Public Class egenerklering
    Private tilkobling As MySqlConnection
    Private Sub egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
        lblDato.Text = Date.Now.ToString("yyyy-mm-dd")

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim sqlSporring = "insert into Egenerklering (sporsmal, ja, nei) values (@sporsmal, @ja, @nei)"
    '    Dim sqlSendInfo As New MySqlCommand(sqlSporring, tilkobling)
    '    Dim sporsmalEpost As String = ""
    '    sqlSendInfo.Parameters.AddWithValue("@sporsmal", "Tillater du at blodbanken sender deg epost(Innkalling, timepåminning, eventuelt annen viktig informasjon)?")
    '    sqlSendInfo.Parameters.AddWithValue("@nei", rbEpostNei.Checked)
    '    sqlSendInfo.Parameters.AddWithValue("@ja", rbEpostJa.Checked)


    '    sqlSendInfo.ExecuteNonQuery()
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

#Region "bolk1"

        Dim spm11 As String
        Dim spm12 As String
        Dim spm13 As String
        Dim spm14 As String

        If rb111.Checked Then
            spm11 = 1
        Else
            spm11 = 0
        End If
        If rb121.Checked Then
            spm12 = 1
        Else
            spm12 = 0
        End If
        If rb111.Checked Then
            spm13 = 1
        Else
            spm13 = 0
        End If
        If rb121.Checked Then
            spm14 = 1
        Else
            spm14 = 0
        End If
        Dim bolk1 As String = spm11 + spm12 + spm13 + spm14

#End Region
#Region "bolk2"

        Dim spm21 As String
        Dim spm22 As String
        Dim spm23 As String
        Dim spm24 As String
        Dim spm25 As String
        Dim spm26 As String

        If rb211.Checked Then
            spm21 = 1
        Else
            spm21 = 0
        End If
        If rb221.Checked Then
            spm22 = 1
        Else
            spm22 = 0
        End If
        If rb231.Checked Then
            spm23 = 1
        Else
            spm23 = 0
        End If
        If rb231.Checked Then
            spm24 = 1
        Else
            spm24 = 0
        End If
        If rb251.Checked Then
            spm25 = 1
        Else
            spm25 = 0
        End If
        If rb261.Checked Then
                    spm26 = 1
                Else
                    spm26 = 0
                End If
        Dim bolk2 As String = spm11 + spm12 + spm13 + spm14 + spm25 + spm26

#End Region
#Region "bolk3"
        Dim spm31 As String
        Dim spm32 As String
        Dim spm33 As String
        Dim spm34 As String
        Dim spm35 As String
        Dim spm36 As String
        Dim spm37 As String
        Dim spm38 As String
        Dim spm39 As String
        Dim spm310 As String

        If rb311.Checked Then
            spm31 = 1
        Else
            spm31 = 0
        End If
        If rb321.Checked Then
            spm32 = 1
        Else
            spm32 = 0
        End If
        If rb231.Checked Then
            spm33 = 1
        Else
            spm33 = 0
        End If
        If rb341.Checked Then
            spm34 = 1
        Else
            spm34 = 0
        End If
        If rb351.Checked Then
            spm35 = 1
        Else
            spm35 = 0
        End If
        If rb361.Checked Then
            spm36 = 1
        Else
            spm36 = 0
        End If
        If rb371.Checked Then
            spm37 = 1
        Else
            spm37 = 0
        End If
        If rb381.Checked Then
            spm38 = 1
        Else
            spm38 = 0
        End If
        If rb391.Checked Then
            spm39 = 1
        Else
            spm39 = 0
        End If
        If rb3101.Checked Then
            spm310 = 1
        Else
            spm310 = 0
        End If
        Dim bolk3 As String = spm31 + spm32 + spm33 + spm34 + spm35 + spm36 + spm37 + spm38 + spm39 + spm310
#End Region





        Dim sqlSporring1 = "insert into Egenerklering_blodgiver (bolk1, bolk2, bolk3) values (@bolk1, @bolk2, @bolk3)"
        Dim sqlbolk1 As New MySqlCommand(sqlSporring1, tilkobling)

        sqlbolk1.Parameters.AddWithValue("@bolk1", bolk1)
        sqlbolk1.Parameters.AddWithValue("@bolk2", bolk2)
        sqlbolk1.Parameters.AddWithValue("@bolk3", bolk3)
        sqlbolk1.ExecuteNonQuery()
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        listbox1_egenerklering.Show()
    End Sub
End Class