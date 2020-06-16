Imports System.IO
Imports System.Windows.Forms

Public Class PDFVWR

    Private _LocalFS As FileStream
    Public Property LocalFS As FileStream
        Get
            Return _LocalFS
        End Get
        Set(value As FileStream)
            _LocalFS = value
        End Set
    End Property

    Private Sub PDFVWR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PDFContent.Dispose()
        Me.Close()
    End Sub

    Public Enum IsActive
        Enable = 1
        Disable = 0
    End Enum

    Public Sub PDFVWR_LoadDocument(ByVal FS As Object, ByVal FileName As String)
        PDFContent.Load(FS)
        'Dim lDocument As New Syncfusion.Pdf.PdfLoadedPage()
        'Dim lPage As Syncfusion.Pdf.PdfPageBase=
    End Sub

    Public Sub PDFVWR_EnableFileOpen(ByVal EnableProperties As IsActive)
        If EnableProperties = IsActive.Enable Then
            PDFContent.ToolbarSettings.OpenButton.IsEnabled = True
        Else
            PDFContent.ToolbarSettings.OpenButton.IsEnabled = False
        End If
    End Sub

    Public Sub PDFVWR_EnableFileSave(ByVal EnableProperties As IsActive)
        If EnableProperties = IsActive.Enable Then
            PDFContent.ToolbarSettings.SaveButton.IsEnabled = True
        Else
            PDFContent.ToolbarSettings.SaveButton.IsEnabled = False
        End If
    End Sub
End Class
