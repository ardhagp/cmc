Namespace OperatingSystem.File
    Public Class Info
        ''' <summary>
        ''' Fungsi untuk memastikan bahwa file ada.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Boolean</returns>
        Public Function IsExists(ByVal FilePath As String) As Boolean
            Dim _FExists As New IO.FileInfo(FilePath)
            Return _FExists.Exists
        End Function

        ''' <summary>
        ''' Fungsi untuk menghitung besar suatu file.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Double</returns>
        Public Function Size(ByVal FilePath As String) As Double
            Dim _FSize As New IO.FileInfo(FilePath)
            Return _FSize.Length
        End Function
    End Class

    Public Class Upload
        ''' <summary>
        ''' Fungsi untuk memeriksa ukuran maksimum file yang dapat diunggah.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <param name="MaxSize">Ukuran file maksimum (dalam Megabyte)</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsAllowedSize(ByVal FilePath As String, ByVal MaxSize As Double, Optional ByVal ShowNativeDialog As Boolean = False) As Boolean

            Dim _File As New Info

            Dim _IsAllowed As Boolean = False
            Dim size As String() = {"B", "KB", "MB", "GB", "TB"}
            Dim _PhotoLength As Double = _File.Size(FilePath)
            Dim _OriginalPhotoLength As Double = _PhotoLength
            Dim _Order As Integer = 0
            Dim _MaximumOrder As Integer = 0

            If MaxSize = 0 Then
                _IsAllowed = True
                Return _IsAllowed
                Exit Function
            End If

            While (_PhotoLength >= 1024 And size.Length - 1)
                _Order += 1
                _PhotoLength = _PhotoLength / 1024
            End While

            Dim _MaximumPhotoLength As Double = ((1024 ^ 2) * MaxSize) '1 indicate 1000KB or 1MB
            Dim _MaximumPhotoLengthDisplay As Double = _MaximumPhotoLength

            While (_MaximumPhotoLengthDisplay >= 1024 And size.Length - 1)
                _MaximumOrder += 1
                _MaximumPhotoLengthDisplay = _MaximumPhotoLengthDisplay / 1024
            End While

            If _OriginalPhotoLength > _MaximumPhotoLength Then
                Dim _ErrorBox As New CMCv.frmDialogBox("Your file size is : " & String.Format("{0:0.##} {1}", _PhotoLength, size(_Order)) & ", above the size that we can tolerate." & vbCrLf & "Please pick your file size under " & String.Format("{0:0.##} {1}", _MaximumPhotoLengthDisplay, size(_MaximumOrder)) & " and then try again.", "Limit Exceeded", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                If ShowNativeDialog = True Then
                    _ErrorBox.ShowDialog()
                    _ErrorBox.Dispose()
                End If
                _IsAllowed = False
            Else
                _IsAllowed = True
            End If

            Return _IsAllowed
        End Function
    End Class
End Namespace
