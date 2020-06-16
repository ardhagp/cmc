Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Namespace ImageEditor.Proccessor
    Public Class Compress
        Public Function OutputAsFile(ByVal File As String, ByVal SaveAs As String) As Boolean
            ' Get a bitmap.
            Dim _Success As Boolean = False
            Try
                Dim _Photo As New Bitmap(File)
                Dim _TmpPhoto As New Bitmap(_Photo)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim myEncoderParameters As New EncoderParameters(1)

                Dim _MemoryStream As New MemoryStream

                Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)

                myEncoderParameters.Param(0) = myEncoderParameter

                _TmpPhoto.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

                Dim _NewPhoto As New Bitmap(System.Drawing.Image.FromStream(_MemoryStream))

                '_NewPhoto = System.Drawing.Image.FromStream(_MemoryStream)
                _NewPhoto.Save(SaveAs, jpgEncoder, myEncoderParameters)
                _NewPhoto.Dispose()
                _MemoryStream.Dispose()
                _TmpPhoto.Dispose()
                _Photo.Dispose()
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            GC.Collect()

            Return _Success
        End Function

        ''' <summary>
        ''' Convert File Path to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        Public Function OutputAsImage(ByVal File As String) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim _Photo As New Bitmap(File)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim myEncoderParameters As New EncoderParameters(1)

                Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)
                myEncoderParameters.Param(0) = myEncoderParameter

                Dim _NewImage As System.Drawing.Image = Nothing

                Dim _MemoryStream = New MemoryStream()
                '_Photo.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                _Photo.Save(_MemoryStream, jpgEncoder, myEncoderParameters)
                'Dim _Byte = _MemoryStream.ToArray

                _NewImage = System.Drawing.Image.FromStream(_MemoryStream)

                GC.Collect()

                Return _NewImage
            Catch ex As Exception
                PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Filestream to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        Public Function OutputAsImage(ByVal File As FileStream) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim _NewImage As System.Drawing.Image = Nothing
                Dim _MemoryStream = New MemoryStream()

                _MemoryStream.SetLength(File.Length)
                File.Read(_MemoryStream.GetBuffer, 0, File.Length)

                _MemoryStream.Flush()
                File.Close()
                _MemoryStream.Close()

                _NewImage = System.Drawing.Image.FromStream(_MemoryStream)

                GC.Collect()

                Return _NewImage
            Catch ex As Exception
                PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Byte to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        Public Function OutputAsImage(ByVal File() As Byte) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim _NewImage As System.Drawing.Image = Nothing
                Dim _MemoryStream = New MemoryStream()

                _MemoryStream.Write(File, 0, File.Length)
                _MemoryStream.Seek(0, SeekOrigin.Begin)

                _NewImage = System.Drawing.Image.FromStream(_MemoryStream)

                GC.Collect()

                Return _NewImage
            Catch ex As Exception
                PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                Return Nothing
            End Try
        End Function

        Public Function OutputAsByte(ByVal File As String) As Byte()
            ' Get a bitmap.
            Dim _Photo As New Bitmap(File)
            Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

            ' Create an Encoder object based on the GUID
            ' for the Quality parameter category.
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.
            ' An EncoderParameters object has an array of EncoderParameter
            ' objects. In this case, there is only one
            ' EncoderParameter object in the array.
            Dim myEncoderParameters As New EncoderParameters(1)

            Dim myEncoderParameter As New EncoderParameter(myEncoder, 20&)
            myEncoderParameters.Param(0) = myEncoderParameter
            '_Photo.Save(SaveAs, jpgEncoder, myEncoderParameters)

            Dim _MemoryStream = New MemoryStream()
            _Photo.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim _Byte = _MemoryStream.ToArray

            GC.Collect()

            Return _Byte
        End Function

        Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

            Dim codec As ImageCodecInfo
            For Each codec In codecs
                If codec.FormatID = format.Guid Then
                    Return codec
                End If
            Next codec
            Return Nothing
        End Function
    End Class

    Public Class Editor
        Public Function Watermarker(ByVal Picture As System.Drawing.Image, ByVal Text As String) As System.Drawing.Image
            Try
                Dim bmp As Bitmap = New Bitmap(Picture)
                Dim _WaterText As String = Text
                Dim canvas As Graphics = Graphics.FromImage(bmp)
                Dim StringSizeF As SizeF,
    DesiredWidth As Single,
    DesiredWidth2 As Single,
    DesireHeight As Single,
    wmFont As Font,
    RequiredFontSize As Single,
    Ratio As Single

                wmFont = New Font("Verdana", 14, FontStyle.Bold)

                If bmp.Width > bmp.Height Then
                    DesiredWidth = bmp.Width * 0.5
                Else
                    DesiredWidth = bmp.Width * 0.5
                End If

                DesiredWidth2 = bmp.Width * 0.25
                DesireHeight = bmp.Height * 0.5

                StringSizeF = canvas.MeasureString(_WaterText, wmFont)
                Ratio = StringSizeF.Width / wmFont.SizeInPoints
                RequiredFontSize = DesiredWidth / Ratio

                wmFont = New Font("Verdana", RequiredFontSize, FontStyle.Bold)

                canvas.DrawString(_WaterText,
        wmFont,
        New SolidBrush(Color.FromArgb(128, 0, 0, 0)), DesiredWidth2 + 2, DesireHeight + 2)

                canvas.DrawString(_WaterText,
        wmFont,
        New SolidBrush(Color.FromArgb(128, 255, 255, 255)), DesiredWidth2, DesireHeight)

                bmp.SetResolution(96, 96)

                Return bmp
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

