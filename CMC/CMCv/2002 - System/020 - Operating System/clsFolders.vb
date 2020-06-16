Namespace OperatingSystem
    Public Class Folder
        Public Function Exists(ByVal FolderPath As String) As Boolean
            Dim _FExists As New IO.DirectoryInfo(FolderPath)
            Return _FExists.Exists
        End Function
    End Class
End Namespace

