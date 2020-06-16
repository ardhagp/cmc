'-------------------------------------------------------------------------------------------------------------
' module:			TX Text Control Words
'	file:		    FileHandler.vb
' description:	This file contains a class handling file operations.
'
' copyright:		© Text Control GmbH, 1991-2013
' author:			T. Kummerow
'-----------------------------------------------------------------------------------------------------------

Imports System
Imports System.Collections.Specialized
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms


''' <summary>
''' Handles file operations.
''' </summary>
Partial Public Class FileHandler
#Region " Constructor "

    Public Sub New(ByVal mainWindow__1 As frmTextEditor, ByVal textControl__2 As TXTextControl.TextControl)
        MainWindow = mainWindow__1
        _fileList = My.Settings.MRUFiles
        _nMaxFiles = 5
        TextControl = textControl__2

        DocumentFileName = ""
        PDFCertFilePath = ""
        PDFCertPasswd = ""
        PDFUserPassword = ""
        PDFMasterPassword = ""
        CSSFileName = ""

        PDFDocumentAccessPermissions = TXTextControl.DocumentAccessPermissions.AllowAll
        PDFImportSettings = TXTextControl.PDFImportSettings.GenerateTextFrames
    End Sub
#End Region

#Region "  Fields  "

    Const DefaultExportTypes As TXTextControl.StreamType = TXTextControl.StreamType.AdobePDF Or TXTextControl.StreamType.AdobePDFA Or TXTextControl.StreamType.CascadingStylesheet
    Const DefaultSaveTypes As TXTextControl.StreamType = TXTextControl.StreamType.All Or TXTextControl.StreamType.InternalUnicodeFormat And Not DefaultExportTypes And Not TXTextControl.StreamType.XMLFormat
    Const DefaultInsertTypes As TXTextControl.StreamType = TXTextControl.StreamType.All And Not DefaultExportTypes And Not TXTextControl.StreamType.XMLFormat
    Const DefaultLoadTypes As TXTextControl.StreamType = TXTextControl.StreamType.All And Not TXTextControl.StreamType.XMLFormat And Not TXTextControl.StreamType.CascadingStylesheet

    Private _documentStreamType As TXTextControl.StreamType

    Private _fileList As StringCollection
    Private _nMaxFiles As Integer

    Private _bDocumentDirty As Boolean
    Private _bCanUndo As Boolean

#End Region

#Region "  Properties  "

    Public Property MainWindow() As frmTextEditor
        Get
            Return m_MainWindow
        End Get
        Set(ByVal value As frmTextEditor)
            m_MainWindow = value
        End Set
    End Property
    Private m_MainWindow As frmTextEditor

    Public Property TextControl() As TXTextControl.TextControl
        Get
            Return m_TextControl
        End Get
        Private Set(ByVal value As TXTextControl.TextControl)
            m_TextControl = value
        End Set
    End Property
    Private m_TextControl As TXTextControl.TextControl

    Public Property SuspendChangeEvents() As Boolean
        Get
            Return m_SuspendChangeEvents
        End Get
        Set(ByVal value As Boolean)
            m_SuspendChangeEvents = value
        End Set
    End Property
    Private m_SuspendChangeEvents As Boolean

    Public Property DocumentFileName() As String
        Get
            Return m_DocumentFileName
        End Get
        Set(ByVal value As String)
            m_DocumentFileName = value
        End Set
    End Property
    Private m_DocumentFileName As String

    Public ReadOnly Property DocumentTitle() As String
        Get
            If DocumentFileName <> "" Then
                Return DocumentFileName
            Else
                Return "[untitled]"
            End If
        End Get
    End Property


    Public Property DocumentDirty() As Boolean
        Get
            Return _bDocumentDirty
        End Get
        Set(ByVal value As Boolean)
            SetDocumentDirty(value)
        End Set
    End Property

    Public Property CSSFileName() As String
        Get
            Return m_CSSFileName
        End Get
        Set(ByVal value As String)
            m_CSSFileName = value
        End Set
    End Property
    Private m_CSSFileName As String

    Public Property CSSSaveMode() As TXTextControl.CssSaveMode
        Get
            Return m_CSSSaveMode
        End Get
        Set(ByVal value As TXTextControl.CssSaveMode)
            m_CSSSaveMode = value
        End Set
    End Property
    Private m_CSSSaveMode As TXTextControl.CssSaveMode

    Public Property PDFMasterPassword() As String
        Get
            Return m_PDFMasterPassword
        End Get
        Set(ByVal value As String)
            m_PDFMasterPassword = value
        End Set
    End Property
    Private m_PDFMasterPassword As String

    Public Property PDFUserPassword() As String
        Get
            Return m_PDFUserPassword
        End Get
        Set(ByVal value As String)
            m_PDFUserPassword = value
        End Set
    End Property
    Private m_PDFUserPassword As String

    Public Property PDFCertFilePath() As String
        Get
            Return m_PDFCertFilePath
        End Get
        Set(ByVal value As String)
            m_PDFCertFilePath = value
        End Set
    End Property
    Private m_PDFCertFilePath As String

    Public Property PDFCertPasswd() As String
        Get
            Return m_PDFCertPasswd
        End Get
        Set(ByVal value As String)
            m_PDFCertPasswd = value
        End Set
    End Property
    Private m_PDFCertPasswd As String

    Public Property PDFDocumentAccessPermissions() As TXTextControl.DocumentAccessPermissions
        Get
            Return m_PDFDocumentAccessPermissions
        End Get
        Set(ByVal value As TXTextControl.DocumentAccessPermissions)
            m_PDFDocumentAccessPermissions = value
        End Set
    End Property
    Private m_PDFDocumentAccessPermissions As TXTextControl.DocumentAccessPermissions

    Public Property PDFImportSettings() As TXTextControl.PDFImportSettings
        Get
            Return m_PDFImportSettings
        End Get
        Set(ByVal value As TXTextControl.PDFImportSettings)
            m_PDFImportSettings = value
        End Set
    End Property
    Private m_PDFImportSettings As TXTextControl.PDFImportSettings

    Public ReadOnly Property PrintDocumentName() As String
        Get
            Return Convert.ToString(MainWindow.ProductName) & " – " & DocumentTitle
        End Get
    End Property

    Public WriteOnly Property CanUndo() As Boolean
        Set(ByVal value As Boolean)
            _bCanUndo = value
        End Set
    End Property
#End Region

#Region "  File methods and functions  "

    ''' <summary>
    ''' Handles the dirty flag for the current document and adds / removes the star (*)
    ''' </summary>
    ''' <param name="isDirty">Document is dirty</param>
    Private Sub SetDocumentDirty(ByVal isDirty As Boolean)
        If SuspendChangeEvents Then Exit Sub
        SetDocDirtyWinForms(isDirty)
    End Sub

    Public Function FileOpen() As Boolean
        Dim bSucceeded As Boolean = False

        Dim ls = New TXTextControl.LoadSettings() With { _
           .ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord, _
           .PDFImportSettings = PDFImportSettings _
        }


        Try
            'if there is no file name, open a dialog to load a document
            If DocumentFileName = "" Then
                TextControl.Load(DefaultLoadTypes, ls)
            Else
                Select Case Path.GetExtension(DocumentFileName).ToLower()
                    Case ".rtf"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.RichTextFormat, ls)
                        Exit Select

                    Case ".doc"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.MSWord, ls)
                        Exit Select

                    Case ".docx"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.WordprocessingML, ls)
                        Exit Select

                    Case ".txt"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.PlainText, ls)
                        Exit Select

                    Case ".htm", ".html"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.HTMLFormat, ls)
                        Exit Select

                    Case ".pdf"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.AdobePDF, ls)
                        Exit Select

                    Case ".tx"
                        TextControl.Load(DocumentFileName, TXTextControl.StreamType.InternalUnicodeFormat, ls)
                        Exit Select

                End Select
            End If

            If ls.LoadedFile <> "" Then
                DocumentFileName = ls.LoadedFile
                _documentStreamType = ls.LoadedStreamType
                _bDocumentDirty = False
                CSSFileName = ls.CssFileName
                CSSSaveMode = TXTextControl.CssSaveMode.None
                AddRecentFile(DocumentFileName)
                bSucceeded = True
                MainWindow.Text = PrintDocumentName
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, "Error loading document.", MessageBoxButtons.OK, MessageBoxIcon.[Error])

            bSucceeded = False
        End Try
        Return bSucceeded
    End Function

    Public Sub FileSave()
        Dim saveSettings = New TXTextControl.SaveSettings()
        saveSettings.CssFileName = CSSFileName
        saveSettings.CssSaveMode = CSSSaveMode

        If DocumentFileName IsNot Nothing AndAlso DocumentFileName <> "" Then
            ' save with same name and type
            TextControl.Save(DocumentFileName, _documentStreamType, saveSettings)
        Else
            ' save as..
            TextControl.Save(DefaultSaveTypes, saveSettings)
        End If

        If saveSettings.SavedFile <> "" Then
            DocumentFileName = saveSettings.SavedFile
            _documentStreamType = saveSettings.SavedStreamType
            _bDocumentDirty = False
            MainWindow.Text = PrintDocumentName
            AddRecentFile(DocumentFileName)
        End If
    End Sub

    Public Sub FileSaveAs(ByVal streamType As TXTextControl.StreamType)
        Dim ls = New TXTextControl.LoadSettings() With { _
           .ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord _
        }

        Dim sdfd = New SaveDocumentFileDialog() With { _
           .SelectedFileType = streamType _
        }
        If Not sdfd.ShowDialog() Then
            Return
        End If

        ' Export pdf:
        If (sdfd.SelectedFileType And (TXTextControl.StreamType.AdobePDF Or TXTextControl.StreamType.AdobePDFA)) <> 0 Then
            Export(sdfd.SelectedFileType, sdfd.FileName)
            Return
        End If

        Dim saveSettings = New TXTextControl.SaveSettings()

        saveSettings.CssFileName = CSSFileName
        saveSettings.CssSaveMode = CSSSaveMode

        TextControl.Save(sdfd.FileName, sdfd.SelectedFileType, saveSettings)

        If saveSettings.SavedFile <> "" Then
            DocumentFileName = saveSettings.SavedFile

            If _documentStreamType <> saveSettings.SavedStreamType Then
                If saveSettings.SavedStreamType = TXTextControl.StreamType.HTMLFormat OrElse saveSettings.SavedStreamType = TXTextControl.StreamType.PlainText OrElse saveSettings.SavedStreamType = TXTextControl.StreamType.PlainAnsiText Then
                    If MessageBox.Show("Some formatting features are possibly not supported by the used save format." & vbCrLf & "These features may be lost or degraded when you reload this document." & vbCrLf & "Click OK to reload the document anyway." & vbCrLf & "To keep all formatting features, click Cancel, and then save the file in another file format.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                        ' reload file if saved in a different format
                        TextControl.ResetContents()
                        TextControl.Load(saveSettings.SavedFile, saveSettings.SavedStreamType, ls)
                    End If
                End If

                _documentStreamType = saveSettings.SavedStreamType
            End If

            _bDocumentDirty = False
            MainWindow.Text = PrintDocumentName
            AddRecentFile(DocumentFileName)
        End If
    End Sub

    Private Sub Export(ByVal streamType As TXTextControl.StreamType, ByVal fileName As String)
        Dim saveSettings = New TXTextControl.SaveSettings() With { _
           .UserPassword = PDFUserPassword, _
           .MasterPassword = PDFMasterPassword, _
           .DocumentAccessPermissions = PDFDocumentAccessPermissions _
        }

        PDFCertFilePath = PDFCertFilePath.Trim()

        ' Load digital signature file if selected
        If PDFCertFilePath <> [String].Empty Then
            Try
                Dim cert = New X509Certificate2(PDFCertFilePath, PDFCertPasswd)
                saveSettings.DigitalSignature = New TXTextControl.DigitalSignature(cert, Nothing)
            Catch
                MessageBox.Show("Please check digital signature settings in the PDF options dialog.", MainWindow.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End Try
        End If

        Try
            If fileName.Length > 0 Then
                Select Case streamType
                    Case TXTextControl.StreamType.AdobePDF
                        TextControl.Save(fileName, TXTextControl.StreamType.AdobePDF, saveSettings)
                        Exit Select

                    Case TXTextControl.StreamType.AdobePDFA
                        If Not TextControl.FontSettings.EmbeddableFontsOnly Then
                            MessageBox.Show("Exporting to PDF/A is currently not possible because the PDF/A-Setting has not been enabled." & vbCrLf & "The PDF/A-Setting can be enabled at 'Options' → 'PDF Settings' → 'Export Settings'" & vbCrLf & "The export process will now be canceled.", "Exporting to PDF/A not possible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return
                        End If
                        TextControl.Save(fileName, TXTextControl.StreamType.AdobePDFA, saveSettings)
                        Exit Select
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MainWindow.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub Insert()
        Dim ls = New TXTextControl.LoadSettings() With { _
           .ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord _
        }
        TextControl.Selection.Load(DefaultInsertTypes, ls)
        If ls IsNot Nothing AndAlso ls.LoadedFile <> "" Then
            _bDocumentDirty = True
        End If
    End Sub

#End Region

#Region "  Recent file handling  "

    ''' <summary>
    ''' Adds a new file path to the top of the list
    ''' </summary>
    Private Sub AddRecentFile(ByVal filePath As String)
        _fileList.Insert(0, filePath)

        For i As Integer = _fileList.Count - 1 To 1 Step -1
            For j As Integer = 0 To i - 1
                If _fileList(i) = _fileList(j) Then
                    _fileList.RemoveAt(i)
                    Exit For
                End If
            Next
        Next
        TrimList()
        UpdateMenu()
    End Sub

    Private Sub TrimList()
        For bynd As Integer = _fileList.Count - 1 To _nMaxFiles Step -1
            _fileList.RemoveAt(bynd)
        Next
    End Sub

    Public Sub InitRecentFiles()
        _fileList = My.Settings.MRUFiles
        _nMaxFiles = 5
        UpdateMenu()
    End Sub

    Private Sub CheckFiles()
        For i As Integer = 0 To _fileList.Count - 1
            If Not File.Exists(_fileList(i)) Then
                _fileList.Remove(_fileList(i))

            End If
        Next
    End Sub

#End Region

#Region "  Helpers  "


    Public Delegate Sub InvokeDelegate()

    Private Sub RemoveAsteriskFromWindowTitle()
        If MainWindow.Text.EndsWith("*") Then
            MainWindow.Text = MainWindow.Text.Remove(MainWindow.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub AddAsteriskToWindowTitle()
        If Not MainWindow.Text.EndsWith("*") Then
            MainWindow.Text = Convert.ToString(MainWindow.Text) & "*"
        End If
    End Sub

    Private Sub UpdateMainFormSaveStatus()
        'frmTextEditor.UpdateSaveStatus()
    End Sub

    Private Sub SetDocDirtyWinForms(ByVal isDirty As Boolean)
        If MainWindow.IsDisposed Then
            Return
        End If

        If Not TextControl.CanUndo Then
            _bDocumentDirty = False
            MainWindow.Invoke(New InvokeDelegate(AddressOf RemoveAsteriskFromWindowTitle))
        Else
            If isDirty Then
                _bDocumentDirty = True
                MainWindow.Invoke(New InvokeDelegate(AddressOf AddAsteriskToWindowTitle))
            Else
                _bDocumentDirty = False
            End If
        End If

        MainWindow.Invoke(New InvokeDelegate(AddressOf UpdateMainFormSaveStatus))
    End Sub
#End Region
End Class
