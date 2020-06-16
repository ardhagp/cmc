Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Reflection
Imports System.Threading
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class frmTextEditor
    Friend _fileHandler As FileHandler
    Friend _fileDragDrop As FileDragDropHandler
    Private _bLoadFileOnCreate As Boolean = False
    Private _customColors As New List(Of Integer)()
    Private _objSel As TXTextControl.FrameBase
    ' Currently selected object
    Private Const ExpressEditionInfoMessage As String = "Not available in Express Edition."

    Public Sub New()
        InitializeComponent()

        Canvas.ButtonBar = ButtonBar
        Canvas.RulerBar = RulerBar
        Canvas.VerticalRulerBar = RulerBarVertical
        Canvas.StatusBar = StatusBar

        _fileHandler = New FileHandler(Me, Canvas)
        _fileDragDrop = New FileDragDropHandler()

        Dim A4Size As Size
        A4Size.Width = 827
        A4Size.Height = 1169
        Canvas.PageSize.Width = A4Size.Width
        Canvas.PageSize.Height = A4Size.Height
        Canvas.Size = A4Size
    End Sub

    Public Sub UpdateSaveStatus()
        '_toolStrip.Items("toolStripSave").Enabled = _fileHandler.DocumentDirty
        'mnuFile.DropDownItems(4).Enabled = _fileHandler.DocumentDirty
    End Sub

    Private Sub frmTextEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If _fileHandler.DocumentDirty Then
            Dim dlgRes As System.Windows.Forms.DialogResult = MessageBox.Show("Save changes to " & Convert.ToString(_fileHandler.DocumentTitle) & "?", "Question", MessageBoxButtons.YesNoCancel)
            If dlgRes = System.Windows.Forms.DialogResult.Yes Then
                _fileHandler.FileSave()
                If _fileHandler.DocumentFileName = "" Then
                    e.Cancel = True
                End If
            ElseIf dlgRes = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
        SaveAppSettings()
    End Sub

    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        _fileHandler.RecentFilesMenuItem = RecentFilesToolStripMenuItem

        Me.Text = My.Application.Info.ProductName & " Text Editor"

        If _bLoadFileOnCreate Then
            If Not _fileHandler.FileOpen() Then
                Return
            End If
            If _fileHandler.DocumentFileName <> "" Then
                Me.Text = Me.ProductName.ToString() & " - " & Convert.ToString(_fileHandler.DocumentTitle)
            End If
        End If

        _fileHandler.DocumentDirty = True

        Canvas.Focus()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        FileNew()
    End Sub

    Public Sub FileNew()
        If _fileHandler.DocumentDirty Then
            Select Case MessageBox.Show("Save changes to " & Convert.ToString(_fileHandler.DocumentTitle) & "?", "Question", MessageBoxButtons.YesNoCancel)
                Case System.Windows.Forms.DialogResult.Cancel
                    Return
                Case System.Windows.Forms.DialogResult.Yes
                    _fileHandler.FileSave()
                    If _fileHandler.DocumentFileName = "" Then
                        Return
                    End If
                    Exit Select
                Case System.Windows.Forms.DialogResult.No
                    Exit Select
            End Select
        End If
        _fileHandler.DocumentFileName = ""
        Canvas.ResetContents()
        Me.Text = My.Application.Info.ProductName & " Text Editor"
        'Me.Text = Me.ProductName.ToString() & " - " & Convert.ToString(_fileHandler.DocumentTitle)
        _fileHandler.DocumentDirty = False
    End Sub

    Public Sub FileOpen()
        Dim Result As System.Windows.Forms.DialogResult

        If _fileHandler.DocumentDirty Then
            Result = MessageBox.Show("Save changes to " & Convert.ToString(_fileHandler.DocumentTitle) & "?", "Question", MessageBoxButtons.YesNoCancel)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                _fileHandler.FileSave()
                If _fileHandler.DocumentFileName = "" Then
                    Return
                End If
            ElseIf Result = System.Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        End If

        _fileHandler.DocumentFileName = ""
        _fileHandler.FileOpen()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        FileOpen()
    End Sub

    Private Sub Canvas_Click(sender As Object, e As EventArgs) Handles Canvas.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        FileSave()
    End Sub

    Public Sub FileSave()
        Try
            _fileHandler.FileSave()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error when saving document", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        FileSaveAs()
    End Sub

    Public Sub FileSaveAs()
        Try
            _fileHandler.FileSaveAs(TXTextControl.StreamType.RichTextFormat)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error when saving document", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        PageSetup.pageSetup_Click(sender, e, Canvas, _fileHandler)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreview()
    End Sub

    Public Sub PrintPreview()
        Canvas.PrintPreview(ProductName & " - " & Convert.ToString(_fileHandler.DocumentTitle))
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Print()
    End Sub

    Public Sub Print()
        Canvas.Print(ProductName & " - " & Convert.ToString(_fileHandler.DocumentTitle))
    End Sub


    Private Sub HTMLSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLSettingToolStripMenuItem.Click
        Dim HTMLOptionsDialog As New FrmHTMLOptions(_fileHandler)
        HTMLOptionsDialog.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Canvas.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Canvas.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Canvas.Cut()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        Canvas.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Canvas.Paste()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Canvas.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Canvas.SelectAll()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Canvas.Find()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Canvas.Replace()
    End Sub

    Private Sub VIEWToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.DropDownOpening
        DraftToolStripMenuItem.Checked = (Canvas.ViewMode = TXTextControl.ViewMode.Normal)
        PageLayoutToolStripMenuItem.Checked = (Canvas.ViewMode = TXTextControl.ViewMode.PageView)
        'mnuView_Toolbar.Checked = SLFMenu.Visible
        ButtonbarToolStripMenuItem.Checked = ButtonBar.Visible
        StatusBarToolStripMenuItem.Checked = StatusBar.Visible
        HorizontalRulerToolStripMenuItem.Checked = RulerBar.Visible
        VerticalRulerToolStripMenuItem.Checked = RulerBarVertical.Visible
        TextFramemakerLinesToolStripMenuItem.Checked = Canvas.TextFrameMarkerLines
        TargetMarkersToolStripMenuItem.Checked = Canvas.DocumentTargetMarkers
    End Sub

    Private Sub PageLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageLayoutToolStripMenuItem.Click
        Canvas.ViewMode = TXTextControl.ViewMode.PageView
    End Sub

    Private Sub DraftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DraftToolStripMenuItem.Click
        Canvas.ViewMode = TXTextControl.ViewMode.Normal
    End Sub

    Private Sub ButtonbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonbarToolStripMenuItem.Click
        ButtonBar.Visible = Not ButtonBar.Visible
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        StatusBar.Visible = Not StatusBar.Visible
    End Sub

    Private Sub HorizontalRulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalRulerToolStripMenuItem.Click
        RulerBar.Visible = Not RulerBar.Visible
    End Sub

    Private Sub VerticalRulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalRulerToolStripMenuItem.Click
        RulerBarVertical.Visible = Not RulerBarVertical.Visible
    End Sub

    Private Sub TextFramemakerLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFramemakerLinesToolStripMenuItem.Click
        Canvas.TextFrameMarkerLines = Not Canvas.TextFrameMarkerLines
    End Sub

    Private Sub TargetMarkersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TargetMarkersToolStripMenuItem.Click
        Canvas.DocumentTargetMarkers = Not Canvas.DocumentTargetMarkers
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click

    End Sub

    Private Sub ZoomToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.DropDownOpening
        ToolStripMenuItem12.Checked = (Canvas.ZoomFactor = 25)
        ToolStripMenuItem13.Checked = (Canvas.ZoomFactor = 50)
        ToolStripMenuItem14.Checked = (Canvas.ZoomFactor = 75)
        ToolStripMenuItem15.Checked = (Canvas.ZoomFactor = 100)
        ToolStripMenuItem16.Checked = (Canvas.ZoomFactor = 150)
        ToolStripMenuItem17.Checked = (Canvas.ZoomFactor = 200)
        ToolStripMenuItem18.Checked = (Canvas.ZoomFactor = 300)
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Canvas.ZoomFactor = 25
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        Canvas.ZoomFactor = 50
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        Canvas.ZoomFactor = 75
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        Canvas.ZoomFactor = 100
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        Canvas.ZoomFactor = 150
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        Canvas.ZoomFactor = 200
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        Canvas.ZoomFactor = 300
    End Sub

    Private Sub VIEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        Try
            _fileHandler.Insert()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ProductName)
        End Try
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Dim imageNew As New TXTextControl.Image()
        Canvas.Images.Add(imageNew, TXTextControl.HorizontalAlignment.Left, -1, TXTextControl.ImageInsertionMode.DisplaceText)
    End Sub

    Private Sub PageBreakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageBreakToolStripMenuItem.Click
        Dim dpi As Integer = CInt(1440 / Canvas.CreateGraphics().DpiX)

        Canvas.Selection.Text = vbFormFeed
        Canvas.ScrollLocation = New Point(Canvas.ScrollLocation.X, CInt(Canvas.InputPosition.Location.Y - (Canvas.Selection.SectionFormat.PageMargins.Top * dpi)))
    End Sub

    Private Sub TextWrappingBreakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextWrappingBreakToolStripMenuItem.Click
        Canvas.Selection.Text = vbVerticalTab
    End Sub

    Private Sub CharacterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CharacterToolStripMenuItem.Click
        If Canvas.FontDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub ParagraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagraphToolStripMenuItem.Click
        If Canvas.ParagraphFormatDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        If Canvas.ListFormatDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub BulletsAndNumberingToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles BulletsAndNumberingToolStripMenuItem.DropDownOpening
        IncreaseLevelToolStripMenuItem.Enabled = ((Canvas.Selection.ListFormat.Type <> TXTextControl.ListType.None)) AndAlso (Canvas.Selection.ListFormat.Level < TXTextControl.ListFormat.MaxLevel)
        DecreaseLevelToolStripMenuItem.Enabled = ((Canvas.Selection.ListFormat.Type <> TXTextControl.ListType.None)) AndAlso (Canvas.Selection.ListFormat.Level > 1)

        CheckListMenuItem()
    End Sub

    Private Sub IncreaseLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseLevelToolStripMenuItem.Click
        Canvas.Selection.ListFormat.Level += 1
        Canvas.Selection.IncreaseIndent()
    End Sub

    Private Sub DecreaseLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseLevelToolStripMenuItem.Click
        If Canvas.Selection.ListFormat.Level >= 2 Then
            Canvas.Selection.ListFormat.Level -= 1
            Canvas.Selection.DecreaseIndent()
        End If
    End Sub

    Private Sub BulletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulletsToolStripMenuItem.Click
        If BulletsToolStripMenuItem.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Bulleted
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        If ToolStripMenuItem24.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Numbered
        Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.ArabicNumbers
    End Sub

    Private Sub ABCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABCToolStripMenuItem.Click
        If ABCToolStripMenuItem.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Numbered
        Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.CapitalLetters
    End Sub

    Private Sub ABcToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABcToolStripMenuItem1.Click
        If ABcToolStripMenuItem1.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Numbered
        Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.Letters
    End Sub

    Private Sub IIiIiiIvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IIiIiiIvToolStripMenuItem.Click
        If IIiIiiIvToolStripMenuItem.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Numbered
        Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.RomanNumbers
    End Sub

    Private Sub IIiIiiIvToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IIiIiiIvToolStripMenuItem1.Click
        If IIiIiiIvToolStripMenuItem1.Checked Then
            Canvas.Selection.ListFormat.Type = TXTextControl.ListType.None
            Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.None
            Return
        End If

        Canvas.Selection.ListFormat.Type = TXTextControl.ListType.Numbered
        Canvas.Selection.ListFormat.NumberFormat = TXTextControl.NumberFormat.SmallRomanNumbers
    End Sub

    Private Sub StylesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StylesToolStripMenuItem.Click
        If Canvas.FormattingStylesDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub TabsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabsToolStripMenuItem.Click
        If Canvas.TabDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub ImageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem1.Click
        If Canvas.ImageAttributesDialog() = System.Windows.Forms.DialogResult.OK Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Private Sub FORMATToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FORMATToolStripMenuItem.DropDownOpening
        ImageToolStripMenuItem1.Enabled = (Canvas.Images.GetItem() IsNot Nothing)
        TextFramemakerLinesToolStripMenuItem.Checked = Canvas.TextFrameMarkerLines
        TargetMarkersToolStripMenuItem.Checked = Canvas.DocumentTargetMarkers
    End Sub

    Private Sub TABLEToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles TABLEToolStripMenuItem.DropDownOpening
        Dim ThisTable As TXTextControl.Table = Canvas.Tables.GetItem()

        PropertiesToolStripMenuItem1.Enabled = (ThisTable IsNot Nothing)
        GridLinesToolStripMenuItem.Checked = Canvas.Tables.GridLines

        If ThisTable IsNot Nothing Then
            DeleteToolStripMenuItem1.Enabled = True
            SplitTableToolStripMenuItem.Enabled = ThisTable.CanSplit
            MergeCellsToolStripMenuItem.Enabled = ThisTable.CanMergeCells
            SplitCellsToolStripMenuItem.Enabled = ThisTable.CanSplitCells
            SelectToolStripMenuItem.Enabled = True
        Else
            SplitTableToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem1.Enabled = False
            MergeCellsToolStripMenuItem.Enabled = False
            SplitCellsToolStripMenuItem.Enabled = False
            SelectToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem1.Click
        Canvas.TableFormatDialog()
    End Sub

    Private Sub GridLinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GridLinesToolStripMenuItem.Click
        Canvas.Tables.GridLines = Not Canvas.Tables.GridLines
    End Sub

    Private Sub DeleteToolStripMenuItem1_DropDownOpening(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.DropDownOpening
        Dim tableAtInputPosition As TXTextControl.Table = Canvas.Tables.GetItem()

        If tableAtInputPosition Is Nothing Then
            TableToolStripMenuItem2.Enabled = False
            ColumnToolStripMenuItem.Enabled = False
            RowsToolStripMenuItem.Enabled = False
            CelsToolStripMenuItem.Enabled = False
        Else
            TableToolStripMenuItem2.Enabled = tableAtInputPosition.Columns.CanRemove
            ColumnToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanRemove
            RowsToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanRemove
            CelsToolStripMenuItem.Enabled = tableAtInputPosition.Cells.CanRemove
            DeleteEntireColumnToolStripMenuItem.Enabled = tableAtInputPosition.Columns.CanRemove
            DeleteEntireRowToolStripMenuItem.Enabled = tableAtInputPosition.Rows.CanRemove
        End If
    End Sub

    Private Sub SplitTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitTableToolStripMenuItem.Click
        Dim tableAtInputPosition As TXTextControl.Table = Canvas.Tables.GetItem()

        If tableAtInputPosition Is Nothing Then
            AboveToolStripMenuItem.Enabled = False
            BelowToolStripMenuItem.Enabled = False
        Else
            AboveToolStripMenuItem.Enabled = True
            BelowToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub MergeCellsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MergeCellsToolStripMenuItem.Click
        Canvas.Tables.GetItem().MergeCells()
    End Sub

    Private Sub SplitCellsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitCellsToolStripMenuItem.Click
        Canvas.Tables.GetItem().SplitCells()
    End Sub

    Private Sub TableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem1.Click
        InsertTable()
    End Sub

    Private Sub ColumnToTheLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToTheLeftToolStripMenuItem.Click
        Canvas.Tables.GetItem().Columns.Add(TXTextControl.TableAddPosition.Before)
    End Sub

    Private Sub SelectToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles SelectToolStripMenuItem.DropDownOpening
        Dim tableAtInputPosition As TXTextControl.Table = Nothing
        Dim rowAtInputPosition As TXTextControl.TableRow = Nothing
        Dim cellAtInputPosition As TXTextControl.TableCell = Nothing
        Dim columnAtInputPosition As TXTextControl.TableColumn = Nothing

        tableAtInputPosition = Canvas.Tables.GetItem()
        If tableAtInputPosition IsNot Nothing Then
            rowAtInputPosition = tableAtInputPosition.Rows.GetItem()
            cellAtInputPosition = tableAtInputPosition.Cells.GetItem()
            columnAtInputPosition = tableAtInputPosition.Columns.GetItem()
        End If

        TableToolStripMenuItem3.Enabled = (tableAtInputPosition IsNot Nothing)
        RowToolStripMenuItem.Enabled = (rowAtInputPosition IsNot Nothing)
        CellsToolStripMenuItem.Enabled = (cellAtInputPosition IsNot Nothing)
        ColumnToolStripMenuItem1.Enabled = (columnAtInputPosition IsNot Nothing)
    End Sub

    Private Sub TableToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem3.Click
        Canvas.Tables.GetItem().[Select]()
    End Sub

    Private Sub ColumnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem1.Click
        Canvas.Tables.GetItem().Columns.GetItem().[Select]()
    End Sub

    Private Sub RowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowToolStripMenuItem.Click
        Canvas.Tables.GetItem().Rows.GetItem().[Select]()
    End Sub

    Private Sub CellsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CellsToolStripMenuItem.Click
        Canvas.Tables.GetItem().Cells.GetItem().[Select]()
    End Sub

    Private Sub AboveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboveToolStripMenuItem.Click
        Canvas.Tables.GetItem().Split(TXTextControl.TableAddPosition.Before)
    End Sub

    Private Sub BelowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BelowToolStripMenuItem.Click
        Canvas.Tables.GetItem().Split(TXTextControl.TableAddPosition.After)
    End Sub

    Private Sub TableToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TableToolStripMenuItem2.Click
        Canvas.Tables.Remove()
    End Sub

    Private Sub ColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem.Click
        Canvas.Tables.GetItem().Columns.Remove()
    End Sub

    Private Sub RowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowsToolStripMenuItem.Click
        Canvas.Tables.GetItem().Rows.Remove()
    End Sub

    Private Sub ShiftCellsLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShiftCellsLeftToolStripMenuItem.Click
        Canvas.Tables.GetItem().Cells.Remove()
    End Sub

    Private Sub DeleteEntireRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEntireRowToolStripMenuItem.Click
        Canvas.Tables.GetItem().Rows.Remove()
    End Sub

    Private Sub DeleteEntireColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEntireColumnToolStripMenuItem.Click
        Canvas.Tables.GetItem().Columns.Remove()
    End Sub

    Private Sub FILEToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.DropDownOpening
        _fileHandler.InitRecentFiles()
    End Sub

#Region " Enumerations "

    Private Enum TXEdition
        Unknown
        Standard
        Professional
        Enterprise
        Server
        Trial
    End Enum
    ' enum TXEdition
#End Region


#Region " Helpers "

    Private Function ColorToBGR(ByVal color As Color) As Integer
        Return color.B << 16 Or color.G << 8 Or color.R
    End Function

    Private Function GetTXEdition() As TXEdition
        Dim strVersionString As String = Canvas.GetVersionString()
        If strVersionString.Contains(TXEdition.Standard.ToString()) Then
            Return TXEdition.Standard
        ElseIf strVersionString.Contains(TXEdition.Professional.ToString()) Then
            Return TXEdition.Professional
        ElseIf strVersionString.Contains(TXEdition.Enterprise.ToString()) Then
            Return TXEdition.Enterprise
        ElseIf strVersionString.Contains(TXEdition.Server.ToString()) Then
            Return TXEdition.Server
        ElseIf strVersionString.Contains(TXEdition.Trial.ToString()) Then
            Return TXEdition.Trial
        End If

        Return TXEdition.Unknown
    End Function

    Private Function GetSelectedObjInsMode() As TXTextControl.FrameInsertionMode
        If _objSel Is Nothing Then
            Return TXTextControl.FrameInsertionMode.AsCharacter
        End If
        Return _objSel.InsertionMode And Not (TXTextControl.FrameInsertionMode.MoveWithText Or TXTextControl.FrameInsertionMode.FixedOnPage)
    End Function

    Private Sub SetSelectedObjectInsertionMode(ByVal mnuItem As Object, ByVal insMode As TXTextControl.FrameInsertionMode)
        Dim mi As ToolStripMenuItem = TryCast(mnuItem, ToolStripMenuItem)
        If (mi Is Nothing) OrElse mi.Checked Then
            Return
        End If

        ' Set new insertion mode
        SetObjectInsertionMode(_objSel, insMode)
        mi.Checked = True
    End Sub

    Private Sub SetObjectInsertionMode(ByVal obj As TXTextControl.FrameBase, ByVal insMode As TXTextControl.FrameInsertionMode)
        If obj Is Nothing Then
            Return
        End If

        ' If new insertion mode is "as character" discard previous insertion mode flags
        If insMode = TXTextControl.FrameInsertionMode.AsCharacter Then
            obj.InsertionMode = insMode
            Return
        End If

        ' Get current insertion mode flags
        Dim insModeFlags As TXTextControl.FrameInsertionMode = (obj.InsertionMode And (TXTextControl.FrameInsertionMode.FixedOnPage Or TXTextControl.FrameInsertionMode.MoveWithText))

        ' If currently no insertion mode flags are set, set to "move with text"
        If insModeFlags = DirectCast(0, TXTextControl.FrameInsertionMode) Then
            insModeFlags = TXTextControl.FrameInsertionMode.MoveWithText
        End If

        ' Combine new insertion mode with current insertion mode flags
        obj.InsertionMode = insModeFlags Or insMode
    End Sub

    Friend Sub UpdateCurrentObject()
        GetSelectedObject()
    End Sub

    Friend Sub GetSelectedObject()
        Try
            _objSel = Canvas.Frames.GetItem()
        Catch
        End Try
    End Sub

    Private Sub InsertTable()
        If Canvas.Tables.Add() Then
            _fileHandler.DocumentDirty = True
        End If
    End Sub

    Public Sub UpdateGUIState()
        '    _toolStrip.Items("toolStripCut").Enabled = Me.CanCopy
        '    _toolStrip.Items("toolStripCopy").Enabled = Me.CanCopy
        '    _toolStrip.Items("toolStripPaste").Enabled = Me.CanPaste
        '    _toolStrip.Items("toolStripDelete").Enabled = Me.CanCopy
        '    _toolStrip.Items("toolStripUndo").Enabled = Me.CanUndo
        '    _toolStrip.Items("toolStripRedo").Enabled = Me.CanRedo
    End Sub

    Private Sub CheckListMenuItem()
        ' Uncheck all list items
        For Each obj In FORMATToolStripMenuItem.DropDownItems
            Dim item = TryCast(obj, ToolStripMenuItem)
            If item Is Nothing Then
                Continue For
            End If

            item.Checked = False
        Next

        Select Case Canvas.Selection.ListFormat.Type
            Case TXTextControl.ListType.Bulleted
                BulletsAndNumberingToolStripMenuItem.Checked = True
                Return

            Case TXTextControl.ListType.None
                Return
        End Select

        Select Case Canvas.Selection.ListFormat.NumberFormat
            Case TXTextControl.NumberFormat.ArabicNumbers
                ToolStripMenuItem24.Checked = True
                Exit Select

            Case TXTextControl.NumberFormat.CapitalLetters
                ABCToolStripMenuItem.Checked = True
                Exit Select

            Case TXTextControl.NumberFormat.Letters
                ABcToolStripMenuItem1.Checked = True
                Exit Select

            Case TXTextControl.NumberFormat.RomanNumbers
                IIiIiiIvToolStripMenuItem.Checked = True
                Exit Select

            Case TXTextControl.NumberFormat.SmallRomanNumbers
                IIiIiiIvToolStripMenuItem1.Checked = True
                Exit Select
        End Select
    End Sub

#End Region

#Region " Form methods and functions "
    Private Sub LoadAppSettings()
        ' Take over initial resizing
        Me.StartPosition = FormStartPosition.Manual

        ' Resize form
        'Me.Size = My.Settings.Default.LastWindowSize
        'Me.Location = My.Settings.Default.LastWindowPos
        'Me.WindowState = My.Settings.Default.LastWindowState

    End Sub

    Private Sub SaveAppSettings()
        ' Store location and size data, using RestoreBounds to remember normal position if minimized or maximized

        'If Me.WindowState = FormWindowState.Normal Then
        '    My.Settings.Default.LastWindowPos = Me.Location
        '    My.Settings.Default.LastWindowSize = Me.Size
        'Else
        '    My.Settings.Default.LastWindowPos = Me.RestoreBounds.Location
        '    My.Settings.Default.LastWindowSize = Me.RestoreBounds.Size
        'End If
        'My.Settings.Default.LastWindowState = Me.WindowState
        'My.Settings.Default.Save()
    End Sub

#End Region

    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click

    End Sub

    Private Sub EDITToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.DropDownOpening
        UndoToolStripMenuItem.Enabled = Canvas.CanUndo
        RedoToolStripMenuItem.Enabled = Canvas.CanRedo
        CutToolStripMenuItem.Enabled = Canvas.CanCopy
        CToolStripMenuItem.Enabled = Canvas.CanCopy
        PasteToolStripMenuItem.Enabled = Canvas.CanPaste

        UndoToolStripMenuItem.Text = "Undo " + Canvas.UndoActionName
        RedoToolStripMenuItem.Text = "Redo " + Canvas.RedoActionName
    End Sub
End Class
