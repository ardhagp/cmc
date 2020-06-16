Imports System.Text

Namespace Security
    Public Class Encrypt

        Private Function RandomString() As String
            Dim r As New Random
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
            Dim sb As New StringBuilder
            Dim cnt As Integer = r.Next(15, 33)
            For i As Integer = 1 To cnt
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.Substring(idx, 1))
            Next
            Return sb.ToString()
        End Function

        Public Function MD5(Optional ByVal Message As String = "") As String
            Dim _EMessage As String = String.Empty
            Dim _GUID As String = String.Empty

            Security.Engine.EncryptionAlgorithm = Engine.Algorithm.MD5
            Security.Engine.Encoding = Engine.EncodingType.HEX

            If Message = String.Empty Then
                _GUID = System.Guid.NewGuid.ToString
                _EMessage = CStr(Now) & RandomString() & _GUID
                Security.Engine.GenerateHash(_EMessage)
            Else
                Security.Engine.GenerateHash(Message)
            End If

            Return Security.Engine.Content
        End Function

        'Public Function MD55(Optional ByVal Message As String = "") As String
        '    Dim _EMessage As String = String.Empty
        '    Dim _MD5 As System.Security.Cryptography.MD5

        '    If Message = String.Empty Then

        '    End If


        'End Function

        Public Function Rijndael(ByVal Message As String) As String
            Dim _EMessage As String = String.Empty

            Security.Engine.EncryptionAlgorithm = Engine.Algorithm.Rijndael
            Security.Engine.Encoding = Engine.EncodingType.HEX
            Security.Engine.Key = _KEY

            If Security.Engine.EncryptString(Message) Then
                Return Security.Engine.Content
            Else
                Return String.Empty
            End If

        End Function
    End Class

    Public Class Decrypt

        Public Function Rijndael(ByVal Message As String) As String
            Security.Engine.EncryptionAlgorithm = Engine.Algorithm.Rijndael
            Security.Engine.Encoding = Engine.EncodingType.HEX
            Security.Engine.Key = _KEY
            Security.Engine.Content = Message

            If Security.Engine.DecryptString Then
                Return Security.Engine.Content
            Else
                Return String.Empty
            End If

        End Function
    End Class
End Namespace

