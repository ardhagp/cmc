'-------------------------------------------------------------------------------------------------------------
' module:			TX Text Control Words
' file:           FileHandler_Toolbar.vb
' description:	This file contains the parts of the class handling file operations which are only needed
'                 in the toolbar demos.
'
' copyright:		© Text Control GmbH, 1991-2013
' author:			T. Kummerow
'-----------------------------------------------------------------------------------------------------------

Imports System
Imports System.IO
Imports System.Windows.Forms


Partial Public Class FileHandler
    Private _clientMenu As ToolStripMenuItem

    Public WriteOnly Property RecentFilesMenuItem() As ToolStripMenuItem
        Set(ByVal value As ToolStripMenuItem)
            _clientMenu = value
        End Set
    End Property

    Public Sub UpdateMenu()
        Dim i As Integer
        ' Clear current menu
        For i = _clientMenu.DropDownItems.Count - 1 To 0 Step -1
            _clientMenu.DropDownItems.RemoveAt(i)
        Next
        ' Check all recent files if they still exist
        CheckFiles()
        ' Setup Recent files menu
        For i = 0 To _fileList.Count - 1
            Dim mnuItm As ToolStripItem = New ToolStripMenuItem()
            mnuItm.Text = Path.GetFileName(_fileList(i))
            mnuItm.Tag = _fileList(i)
            AddHandler mnuItm.Click, AddressOf mnuItm_Click

            _clientMenu.DropDownItems.Add(mnuItm)
        Next
        ' Insert Clear menu entry
        If _clientMenu.DropDownItems.Count >= 1 Then
            _clientMenu.Enabled = True
            _clientMenu.DropDownItems.Add("-")
            Dim clearListItm As New ToolStripMenuItem("Clear list")
            _clientMenu.DropDownItems.Add(clearListItm)
            AddHandler clearListItm.Click, AddressOf clearListItm_Click
        Else
            _clientMenu.Enabled = False
        End If
    End Sub

    Private Sub mnuItm_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Result As System.Windows.Forms.DialogResult

        If _bDocumentDirty Then
            Result = MessageBox.Show("Save changes to " & DocumentFileName & "?", "Question", MessageBoxButtons.YesNoCancel)
            If Result = DialogResult.Yes Then
                FileSave()
            End If
        End If
        Dim itm As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        Dim pos As Integer = itm.GetCurrentParent().Items.IndexOf(itm)
        If pos >= 0 AndAlso pos < _fileList.Count Then
            DocumentFileName = itm.Tag.ToString()
            FileOpen()
        End If
    End Sub

    Private Sub clearListItm_Click(ByVal sender As Object, ByVal e As EventArgs)
        _fileList.Clear()
        UpdateMenu()
    End Sub
End Class
