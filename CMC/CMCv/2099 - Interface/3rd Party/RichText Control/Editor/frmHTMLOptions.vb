'-------------------------------------------------------------------------------------------------------------
' module:			TX Text Control Words
' file:         FrmHTMLOptions.vb
'
' copyright:		© Text Control GmbH, 1991-2012
' author:			T. Kummerow
'-----------------------------------------------------------------------------------------------------------

Public Class FrmHTMLOptions
    'Inherits System.Windows.Forms.Form
    Friend GroupBox1 As System.Windows.Forms.GroupBox
    'Friend txtStylesheetFile As System.Windows.Forms.TextBox
    'Friend lblStylesheetFile As System.Windows.Forms.Label
    'Friend WithEvents optSaveButDoNotOverwriteExistingFile As System.Windows.Forms.RadioButton
    'Friend WithEvents optSaveStylesheetInSeperateFile As System.Windows.Forms.RadioButton
    'Friend WithEvents optInlineStylesheet As System.Windows.Forms.RadioButton
    'Friend WithEvents optNoStylesheet As System.Windows.Forms.RadioButton
    'Friend WithEvents cmdCancel As System.Windows.Forms.Button
    'Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend _fileHandler As FileHandler
    'Private components As System.ComponentModel.Container = Nothing

    Public Sub New(ByVal fileHandler As FileHandler)
        InitializeComponent()
        _fileHandler = fileHandler
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub BtnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        _fileHandler.CSSFileName = txtStylesheetFile.Text

        If optNoStylesheet.Checked Then
            _fileHandler.CSSSaveMode = TXTextControl.CssSaveMode.None
        ElseIf optInlineStylesheet.Checked Then
            _fileHandler.CSSSaveMode = TXTextControl.CssSaveMode.Inline
        ElseIf optSaveStylesheetInSeperateFile.Checked Then
            _fileHandler.CSSSaveMode = TXTextControl.CssSaveMode.OverwriteFile
        Else
            _fileHandler.CSSSaveMode = TXTextControl.CssSaveMode.CreateFile
        End If

        Close()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub optNoStylesheet_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optNoStylesheet.CheckedChanged
        EnableFilename(False)
    End Sub

    Private Sub optInlineStylesheet_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optInlineStylesheet.CheckedChanged
        EnableFilename(False)
    End Sub

    Private Sub optSaveStylesheetInSeperateFile_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optSaveStylesheetInSeperateFile.CheckedChanged
        EnableFilename(True)
    End Sub

    Private Sub optSaveButDoNotOverwriteExistingFile_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optSaveButDoNotOverwriteExistingFile.CheckedChanged
        EnableFilename(True)
    End Sub

    Private Sub EnableFilename(ByVal Enable As Boolean)
        lblStylesheetFile.Enabled = Enable
        txtStylesheetFile.Enabled = Enable
    End Sub

    Private Sub frmHTMLOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtStylesheetFile.Text = _fileHandler.CSSFileName

        Select Case _fileHandler.CSSSaveMode
            Case TXTextControl.CssSaveMode.None
                optNoStylesheet.Checked = True
                Exit Select
            Case TXTextControl.CssSaveMode.Inline
                optInlineStylesheet.Checked = True
                Exit Select
            Case TXTextControl.CssSaveMode.OverwriteFile
                optSaveStylesheetInSeperateFile.Checked = True
                Exit Select
            Case TXTextControl.CssSaveMode.CreateFile
                optSaveButDoNotOverwriteExistingFile.Checked = True
                Exit Select
        End Select
    End Sub
End Class
