Public Class Validering

    Public Sub New()

    End Sub
    Public Function ValidereTall(tall As String) As Boolean
        If IsNumeric(tall) Then
            Return True

        Else
            Return False
        End If
    End Function

    Public Function ValidereUtfylt(tekst As String) As Boolean
        If tekst = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidereEmail(email As String) As Boolean
        If email.Contains("@") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidereTelefon(telefonnummer As String) As Boolean
        If telefonnummer.Length = 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValiderePersonnummer(personnummer As String) As Boolean
        If personnummer.Length = 11 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
