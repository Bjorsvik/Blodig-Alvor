Imports MySql.Data.MySqlClient

Public Class egenerklering
    Private tilkobling As MySqlConnection
    Private Sub egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_23;Uid=g_oops_23;Pwd=3d4CcHvg")
        tilkobling.Open()
        lblDato.Text = Date.Now
    End Sub
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
#Region "bolk4"
        Dim spm41 As String
        If rb411.Checked Then
            spm41 = 1
        Else
            spm41 = 0
        End If
        Dim bolk4 As String = spm41
#End Region
#Region "bolk5"
        Dim spm51 As String
        Dim spm52 As String
        Dim spm53 As String
        Dim spm54 As String
        Dim spm55 As String
        Dim spm56 As String
        Dim spm57 As String
        Dim spm58 As String
        Dim spm59 As String
        Dim spm510 As String
        Dim spm511 As String
        Dim spm512 As String
        Dim spm513 As String
        Dim spm514 As String
        Dim spm515 As String

        If rb511.Checked Then
            spm51 = 1
        Else
            spm51 = 0
        End If
        If rb521.Checked Then
            spm52 = 1
        Else
            spm52 = 0
        End If
        If rb531.Checked Then
            spm53 = 1
        Else
            spm53 = 0
        End If
        If rb541.Checked Then
            spm54 = 1
        Else
            spm54 = 0
        End If
        If rb551.Checked Then
            spm55 = 1
        Else
            spm55 = 0
        End If
        If rb561.Checked Then
            spm56 = 1
        Else
            spm56 = 0
        End If
        If rb571.Checked Then
            spm57 = 1
        Else
            spm57 = 0
        End If
        If rb581.Checked Then
            spm58 = 1
        Else
            spm58 = 0
        End If
        If rb591.Checked Then
            spm59 = 1
        Else
            spm59 = 0
        End If
        If rb5101.Checked Then
            spm510 = 1
        Else
            spm510 = 0
        End If
        If rb5111.Checked Then
            spm511 = 1
        Else
            spm511 = 0
        End If
        If rb5121.Checked Then
            spm512 = 1
        Else
            spm512 = 0
        End If
        If rb5131.Checked Then
            spm513 = 1
        Else
            spm513 = 0
        End If
        If rb5141.Checked Then
            spm514 = 1
        Else
            spm514 = 0
        End If
        If rb5151.Checked Then
            spm515 = 1
        Else
            spm515 = 0
        End If
        Dim bolk5 As String = spm51 + spm52 + spm53 + spm54 + spm55 + spm56 + spm57 + spm58 + spm59 + spm510 + spm511 + spm512 + spm513 + spm514 + spm515
#End Region
#Region "bolk6"
        Dim spm61 As String
        Dim spm62 As String
        Dim spm63 As String
        Dim spm64 As String
        Dim spm65 As String
        Dim spm66 As String
        Dim spm67 As String

        If rb611.Checked Then
            spm61 = 1
        Else
            spm61 = 0
        End If
        If rb621.Checked Then
            spm62 = 1
        Else
            spm62 = 0
        End If
        If rb631.Checked Then
            spm63 = 1
        Else
            spm63 = 0
        End If
        If rb631.Checked Then
            spm64 = 1
        Else
            spm64 = 0
        End If
        If rb651.Checked Then
            spm65 = 1
        Else
            spm65 = 0
        End If
        If rb661.Checked Then
            spm66 = 1
        Else
            spm66 = 0
        End If
        If rb671.Checked Then
            spm67 = 1
        Else
            spm67 = 0
        End If
        Dim bolk6 As String = spm61 + spm62 + spm63 + spm64 + spm65 + spm66 + spm67
#End Region

        Dim sqlSporring = "insert into Egenerklering_blodgiver (bolk1, bolk2, bolk3, bolk4, bolk5, bolk6) values (@bolk1, @bolk2, @bolk3, @bolk4, @bolk5, @bolk6)"
        Dim sqlbolk1 As New MySqlCommand(sqlSporring, tilkobling)

        sqlbolk1.Parameters.AddWithValue("@bolk1", bolk1)
        sqlbolk1.Parameters.AddWithValue("@bolk2", bolk2)
        sqlbolk1.Parameters.AddWithValue("@bolk3", bolk3)
        sqlbolk1.Parameters.AddWithValue("@bolk4", bolk4)
        sqlbolk1.Parameters.AddWithValue("@bolk5", bolk5)
        sqlbolk1.Parameters.AddWithValue("@bolk6", bolk6)
        sqlbolk1.ExecuteNonQuery()
    End Sub
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        listbox1_egenerklering.Show()
    End Sub
End Class