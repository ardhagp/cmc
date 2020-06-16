'-------------------------------------------------------------------------------------------------------------
' module:			TX Text Control Words
'	file:				TextControlEvents.vb
'
' copyright:		© Text Control GmbH, 1991-2013
' author:			T. Kummerow
'-----------------------------------------------------------------------------------------------------------

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Diagnostics
Imports System.Reflection
Imports TXTextControl.DataVisualization


Partial Public Class FormMain
    Inherits frmTextEditor

#Region "  Event Handlers  "

    Private Sub TextControl_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Canvas.GotFocus
        UpdateGUIState()
    End Sub

    Private Sub TextControl_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles Canvas.Changed
        _fileHandler.DocumentDirty = True
        UpdateGUIState()
    End Sub

    Private Sub TextControl_InputPositionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Canvas.InputPositionChanged
        UpdateGUIState()
    End Sub

    Private Sub TextControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Canvas.KeyDown
        HandleKeyDownEvent(e)
    End Sub


    Private Sub TextControl_ImageDeleted(ByVal sender As Object, ByVal e As TXTextControl.ImageEventArgs) Handles Canvas.ImageDeleted
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_TextFrameDeleted(ByVal sender As Object, ByVal e As TXTextControl.TextFrameEventArgs) Handles Canvas.TextFrameDeleted
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_BarcodeDeleted(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.BarcodeEventArgs) Handles Canvas.BarcodeDeleted
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_ChartDeleted(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.ChartEventArgs) Handles Canvas.ChartDeleted
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_BarcodeSelected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.BarcodeEventArgs) Handles Canvas.BarcodeSelected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_BarcodeDeselected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.BarcodeEventArgs) Handles Canvas.BarcodeDeselected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_ChartSelected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.ChartEventArgs) Handles Canvas.ChartSelected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_ChartDeselected(ByVal sender As Object, ByVal e As TXTextControl.DataVisualization.ChartEventArgs) Handles Canvas.ChartDeselected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_ImageSelected(ByVal sender As Object, ByVal e As TXTextControl.ImageEventArgs) Handles Canvas.ImageSelected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_ImageDeselected(ByVal sender As Object, ByVal e As TXTextControl.ImageEventArgs) Handles Canvas.ImageDeselected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_TextFrameSelected(ByVal sender As Object, ByVal e As TXTextControl.TextFrameEventArgs) Handles Canvas.TextFrameSelected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_TextFrameDeselected(ByVal sender As Object, ByVal e As TXTextControl.TextFrameEventArgs) Handles Canvas.TextFrameDeselected
        UpdateCurrentObject()
    End Sub

    Private Sub TextControl_DocumentLinkClicked(ByVal sender As Object, ByVal e As TXTextControl.DocumentLinkEventArgs) Handles Canvas.DocumentLinkClicked
        e.DocumentLink.DocumentTarget.ScrollTo()
    End Sub

    Private Sub TextControl_HypertextLinkClicked(ByVal sender As Object, ByVal e As TXTextControl.HypertextLinkEventArgs) Handles Canvas.HypertextLinkClicked
        OpenHyperLink(e.HypertextLink.Target)
    End Sub

    Private Sub TextControl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles Canvas.DragDrop
        If _fileDragDrop.CanDrop Then
            Select Case _fileDragDrop.FileType
                Case FileDragDropHandler.DraggedFileType.Document
                    OpenDroppedDocument()
                    Exit Select

                Case FileDragDropHandler.DraggedFileType.Image
                    InsertDroppedImage(e)
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub TextControl_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles Canvas.DragEnter
        _fileDragDrop.Reset()
        _fileDragDrop.CheckDraggedFiles(DirectCast(e.Data.GetData(DataFormats.FileDrop), String()))
    End Sub

    Private Sub TextControl_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles Canvas.DragOver
        If _fileDragDrop.CanDrop Then
            e.Effect = _fileDragDrop.GetDragDropEffect(e.AllowedEffect)
        End If
    End Sub


#End Region

#Region "  Helpers  "

    Private Sub HandleKeyDownEvent(ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Insert
                ' Toggle insertion mode
                If e.Control OrElse e.Alt OrElse e.Shift Then
                    Exit Select
                End If
                Canvas.InsertionMode = If(Canvas.InsertionMode = TXTextControl.InsertionMode.Insert, TXTextControl.InsertionMode.Overwrite, TXTextControl.InsertionMode.Insert)
                Exit Select

            Case Keys.A
                If Not e.Control OrElse e.Alt OrElse e.Shift Then
                    Exit Select
                End If
                ' Ctrl-A: Select all
                Canvas.SelectAll()
                Exit Select

            Case Keys.S
                If Not e.Control OrElse e.Alt OrElse e.Shift Then
                    Exit Select
                End If
                ' Ctrl-S: save
                Try
                    _fileHandler.FileSave()
                Catch exc As Exception
                    MessageBox.Show(exc.Message, "Error saving document", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
                Exit Select

            Case Keys.O
                If Not e.Control OrElse e.Alt OrElse e.Shift Then
                    Exit Select
                End If

                ' Ctrl-O: open
                If _fileHandler.DocumentDirty AndAlso Not FileSaveQuestion() Then
                    Return
                End If

                _fileHandler.DocumentFileName = String.Empty
                _fileHandler.FileOpen()
                Exit Select

            Case Keys.F
                If Not e.Control OrElse e.Alt OrElse e.Shift Then
                    Exit Select
                End If

                ' Ctrl-F: search
                Canvas.Find()
                Exit Select
        End Select
    End Sub

    Private Function FileSaveQuestion() As Boolean
        Dim resultMsgBox As DialogResult

        resultMsgBox = MessageBox.Show("Save changes to " + _fileHandler.DocumentTitle & "?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Select Case resultMsgBox
            Case DialogResult.Yes
                _fileHandler.FileSave()
                If _fileHandler.DocumentFileName = "" Then
                    Return False
                End If
                Exit Select

            Case DialogResult.Cancel
                Return False
        End Select

        Return True
    End Function

    Private Sub OpenHyperLink(ByVal strTarget As String)
        If strTarget = "" Then
            Return
        ElseIf Not strTarget.StartsWith("http") AndAlso Not strTarget.StartsWith("ftp") AndAlso Not strTarget.StartsWith("mailto") Then
            strTarget = "http://" & strTarget
        End If

        Try
            System.Diagnostics.Process.Start(strTarget)
        Catch ex As Exception
            Dim msg As String = ex.Message
            If Not msg.EndsWith(".") Then
                msg += "."
            End If
            MessageBox.Show("Could not open hyperlink. " & msg, "Hyperlink", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub OpenDroppedDocument()
        If _fileHandler.DocumentDirty Then
            Dim result As DialogResult = MessageBox.Show("Save changes to " + _fileHandler.DocumentTitle & "?", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                _fileHandler.FileSave()
            ElseIf result = DialogResult.Cancel Then
                Return
            End If
        End If
        _fileHandler.DocumentFileName = _fileDragDrop.FileName
        _fileHandler.FileOpen()
    End Sub

    Private Sub InsertDroppedImage(ByVal e As DragEventArgs)
        Try
            ' Get pixel position of mouse cursor inside Text Control
            Dim posCursor As Point = Canvas.PointToClient(Cursor.Position)

            ' Get bounding rectangle of the first character of the paragraph
            ' the image was dropped over
            Dim par As TXTextControl.Paragraph = Canvas.Paragraphs.GetItem(posCursor)
            Dim charParStart As TXTextControl.TextChar = Canvas.TextChars(par.Start)
            Dim rPar As Rectangle = If((charParStart IsNot Nothing), charParStart.Bounds, New Rectangle())

            ' Get bounding rectangle of the character the image was dropped over
            Dim txChar As TXTextControl.TextChar = Canvas.TextChars.GetItem(posCursor, True)
            Dim rChar As Rectangle = If((txChar IsNot Nothing), txChar.Bounds, New Rectangle())

            ' Calculate image position relative to paragraph position
            Dim posImg = New Point(rChar.Left - rPar.Left + rChar.Width, rChar.Top - rPar.Top)

            ' Insert image anchored to paragraph
            Dim txImg = New TXTextControl.Image() With { _
               .FileName = _fileDragDrop.FileName _
            }
            Canvas.Images.Add(txImg, posImg, par.Start, TXTextControl.ImageInsertionMode.DisplaceText)
        Catch exc As Exception
            MessageBox.Show(exc.Message, ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

#End Region
End Class
