<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
    Inherits CMCv.frmStandard

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RulerBar = New TXTextControl.RulerBar()
        Me.Canvas = New TXTextControl.TextControl()
        Me.ButtonBar = New TXTextControl.ButtonBar()
        Me.StatusBar = New TXTextControl.StatusBar()
        Me.RulerBarVertical = New TXTextControl.RulerBar()
        Me.MnuTextEditor = New CMCv.mnu(Me.components)
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HTMLSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DraftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalRulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalRulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextFramemakerLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetMarkersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.INSERTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextWrappingBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FORMATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulletsAndNumberingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABcToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IIiIiiIvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IIiIiiIvToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BulletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StylesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TABLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColumnToTheLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnToTheRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripSeparator()
        Me.RowAboveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowBelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShiftCellsLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEntireRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEntireColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripSeparator()
        Me.MergeCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitCellsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripSeparator()
        Me.PropertiesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTextEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.MnuTextEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'SLFLogo
        '
        Me.SLFLogo.Image = Global.CMCv.My.Resources.Resources.TextEditor_001_90_FFFFFFFF_
        '
        'pnl_
        '
        Me.pnl_.Location = New System.Drawing.Point(0, 24)
        Me.pnl_.Size = New System.Drawing.Size(846, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Location = New System.Drawing.Point(0, 78)
        Me.SLFPanel.Size = New System.Drawing.Size(846, 357)
        '
        'RulerBar
        '
        Me.RulerBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.RulerBar.Location = New System.Drawing.Point(0, 106)
        Me.RulerBar.Name = "RulerBar"
        Me.RulerBar.Size = New System.Drawing.Size(846, 25)
        Me.RulerBar.TabIndex = 8
        '
        'Canvas
        '
        Me.Canvas.BorderStyle = TXTextControl.BorderStyle.FixedSingle
        Me.Canvas.ButtonBar = Me.ButtonBar
        Me.Canvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Canvas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Canvas.Location = New System.Drawing.Point(25, 131)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.PageMargins.Bottom = 100.0R
        Me.Canvas.PageMargins.Left = 40.0R
        Me.Canvas.PageMargins.Right = 40.0R
        Me.Canvas.PageMargins.Top = 100.0R
        Me.Canvas.PageSize.Height = 1169.03R
        Me.Canvas.PageSize.Width = 827.01R
        Me.Canvas.RulerBar = Me.RulerBar
        Me.Canvas.Size = New System.Drawing.Size(821, 304)
        Me.Canvas.StatusBar = Me.StatusBar
        Me.Canvas.TabIndex = 0
        Me.Canvas.VerticalRulerBar = Me.RulerBarVertical
        '
        'ButtonBar
        '
        Me.ButtonBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonBar.ButtonPositions = New TXTextControl.Button() {TXTextControl.Button.StyleComboBox, TXTextControl.Button.FontNameComboBox, TXTextControl.Button.FontSizeComboBox, TXTextControl.Button.FontBoldButton, TXTextControl.Button.FontItalicButton, TXTextControl.Button.FontUnderlineButton, TXTextControl.Button.AlignmentLeftButton, TXTextControl.Button.AlignmentCenteredButton, TXTextControl.Button.AlignmentRightButton, TXTextControl.Button.AlignmentJustifiedButton, TXTextControl.Button.ListBulletedButton, TXTextControl.Button.ListNumberedButton, TXTextControl.Button.ListStructuredButton, TXTextControl.Button.ZoomComboBox, TXTextControl.Button.ControlCharsButton, TXTextControl.Button.TabSelectionButton, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None, TXTextControl.Button.None}
        Me.ButtonBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonBar.Location = New System.Drawing.Point(0, 78)
        Me.ButtonBar.Name = "ButtonBar"
        Me.ButtonBar.Size = New System.Drawing.Size(846, 28)
        Me.ButtonBar.TabIndex = 10
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.SystemColors.Control
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar.Location = New System.Drawing.Point(0, 435)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(846, 22)
        Me.StatusBar.TabIndex = 11
        '
        'RulerBarVertical
        '
        Me.RulerBarVertical.Alignment = TXTextControl.RulerBarAlignment.Left
        Me.RulerBarVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.RulerBarVertical.Location = New System.Drawing.Point(0, 131)
        Me.RulerBarVertical.Name = "RulerBarVertical"
        Me.RulerBarVertical.Size = New System.Drawing.Size(25, 304)
        Me.RulerBarVertical.TabIndex = 12
        '
        'MnuTextEditor
        '
        Me.MnuTextEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.EDITToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.INSERTToolStripMenuItem, Me.FORMATToolStripMenuItem, Me.TABLEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MnuTextEditor.Location = New System.Drawing.Point(0, 0)
        Me.MnuTextEditor.Name = "MnuTextEditor"
        Me.MnuTextEditor.Size = New System.Drawing.Size(846, 24)
        Me.MnuTextEditor.TabIndex = 13
        Me.MnuTextEditor.Text = "Mnu1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.RecentFilesToolStripMenuItem, Me.ToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem2, Me.PageSetupToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.ToolStripMenuItem3, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem4, Me.HTMLSettingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "&FILE"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_newpage
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_open
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'RecentFilesToolStripMenuItem
        '
        Me.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem"
        Me.RecentFilesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RecentFilesToolStripMenuItem.Text = "&Recent Files"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_pagedialog
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PageSetupToolStripMenuItem.Text = "Pag&e Setup..."
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_printpreview
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(158, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_print
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(158, 6)
        '
        'HTMLSettingToolStripMenuItem
        '
        Me.HTMLSettingToolStripMenuItem.Name = "HTMLSettingToolStripMenuItem"
        Me.HTMLSettingToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.HTMLSettingToolStripMenuItem.Text = "HTML Settings..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+W"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripMenuItem5, Me.CutToolStripMenuItem, Me.CToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem6, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripMenuItem7, Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EDITToolStripMenuItem.Text = "&EDIT"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_undo
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_redo
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RedoToolStripMenuItem.Text = "R&edo"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(161, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_cut
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_copy
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C"
        Me.CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_paste
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(161, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_delete
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(161, 6)
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_find
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FindToolStripMenuItem.Text = "&Find"
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_replace
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H"
        Me.ReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ReplaceToolStripMenuItem.Text = "R&eplace"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageLayoutToolStripMenuItem, Me.DraftToolStripMenuItem, Me.ToolStripMenuItem8, Me.ToolbarToolStripMenuItem, Me.ButtonbarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.HorizontalRulerToolStripMenuItem, Me.VerticalRulerToolStripMenuItem, Me.ToolStripMenuItem9, Me.TextFramemakerLinesToolStripMenuItem, Me.TargetMarkersToolStripMenuItem, Me.ToolStripMenuItem10, Me.ZoomToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "&VIEW"
        '
        'PageLayoutToolStripMenuItem
        '
        Me.PageLayoutToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_pageviewprint
        Me.PageLayoutToolStripMenuItem.Name = "PageLayoutToolStripMenuItem"
        Me.PageLayoutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+1"
        Me.PageLayoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.PageLayoutToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PageLayoutToolStripMenuItem.Text = "&Page Layout"
        '
        'DraftToolStripMenuItem
        '
        Me.DraftToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_pageviewnormal
        Me.DraftToolStripMenuItem.Name = "DraftToolStripMenuItem"
        Me.DraftToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+2"
        Me.DraftToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.DraftToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DraftToolStripMenuItem.Text = "&Draft"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(198, 6)
        '
        'ToolbarToolStripMenuItem
        '
        Me.ToolbarToolStripMenuItem.Checked = True
        Me.ToolbarToolStripMenuItem.CheckOnClick = True
        Me.ToolbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolbarToolStripMenuItem.Name = "ToolbarToolStripMenuItem"
        Me.ToolbarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ToolbarToolStripMenuItem.Text = "&Toolbar"
        '
        'ButtonbarToolStripMenuItem
        '
        Me.ButtonbarToolStripMenuItem.Checked = True
        Me.ButtonbarToolStripMenuItem.CheckOnClick = True
        Me.ButtonbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ButtonbarToolStripMenuItem.Name = "ButtonbarToolStripMenuItem"
        Me.ButtonbarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ButtonbarToolStripMenuItem.Text = "&Button Bar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'HorizontalRulerToolStripMenuItem
        '
        Me.HorizontalRulerToolStripMenuItem.Checked = True
        Me.HorizontalRulerToolStripMenuItem.CheckOnClick = True
        Me.HorizontalRulerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HorizontalRulerToolStripMenuItem.Name = "HorizontalRulerToolStripMenuItem"
        Me.HorizontalRulerToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.HorizontalRulerToolStripMenuItem.Text = "Ho&rizontal Ruler"
        '
        'VerticalRulerToolStripMenuItem
        '
        Me.VerticalRulerToolStripMenuItem.Checked = True
        Me.VerticalRulerToolStripMenuItem.CheckOnClick = True
        Me.VerticalRulerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VerticalRulerToolStripMenuItem.Name = "VerticalRulerToolStripMenuItem"
        Me.VerticalRulerToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.VerticalRulerToolStripMenuItem.Text = "&Vertical Ruler"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(198, 6)
        '
        'TextFramemakerLinesToolStripMenuItem
        '
        Me.TextFramemakerLinesToolStripMenuItem.CheckOnClick = True
        Me.TextFramemakerLinesToolStripMenuItem.Name = "TextFramemakerLinesToolStripMenuItem"
        Me.TextFramemakerLinesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TextFramemakerLinesToolStripMenuItem.Text = "Text Frame &Marker Lines"
        '
        'TargetMarkersToolStripMenuItem
        '
        Me.TargetMarkersToolStripMenuItem.Name = "TargetMarkersToolStripMenuItem"
        Me.TargetMarkersToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.TargetMarkersToolStripMenuItem.Text = "Target Markers"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(198, 6)
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripMenuItem17, Me.ToolStripMenuItem18})
        Me.ZoomToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_zoom
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem12.Text = "&1  25%"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem13.Text = "&2  50%"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem14.Text = "&3  75%"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem15.Text = "&4  100%"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem16.Text = "&5  150%"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem17.Text = "&6  200%"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(114, 22)
        Me.ToolStripMenuItem18.Text = "&7  300%"
        '
        'INSERTToolStripMenuItem
        '
        Me.INSERTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.ToolStripMenuItem11, Me.ImageToolStripMenuItem, Me.ToolStripMenuItem19, Me.PageBreakToolStripMenuItem, Me.TextWrappingBreakToolStripMenuItem})
        Me.INSERTToolStripMenuItem.Name = "INSERTToolStripMenuItem"
        Me.INSERTToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.INSERTToolStripMenuItem.Text = "&INSERT"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_insertfile
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.FileToolStripMenuItem1.Text = "&File..."
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(179, 6)
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_image
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ImageToolStripMenuItem.Text = "&Image..."
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(179, 6)
        '
        'PageBreakToolStripMenuItem
        '
        Me.PageBreakToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_pagebreak
        Me.PageBreakToolStripMenuItem.Name = "PageBreakToolStripMenuItem"
        Me.PageBreakToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PageBreakToolStripMenuItem.Text = "Page &Break"
        '
        'TextWrappingBreakToolStripMenuItem
        '
        Me.TextWrappingBreakToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_insertlinebreak
        Me.TextWrappingBreakToolStripMenuItem.Name = "TextWrappingBreakToolStripMenuItem"
        Me.TextWrappingBreakToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.TextWrappingBreakToolStripMenuItem.Text = "Te&xt Wrapping Break"
        '
        'FORMATToolStripMenuItem
        '
        Me.FORMATToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharacterToolStripMenuItem, Me.ParagraphToolStripMenuItem, Me.BulletsAndNumberingToolStripMenuItem, Me.StylesToolStripMenuItem, Me.ToolStripMenuItem20, Me.TabsToolStripMenuItem, Me.ToolStripMenuItem21, Me.ImageToolStripMenuItem1})
        Me.FORMATToolStripMenuItem.Name = "FORMATToolStripMenuItem"
        Me.FORMATToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FORMATToolStripMenuItem.Text = "FOR&MAT"
        '
        'CharacterToolStripMenuItem
        '
        Me.CharacterToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_charactersettings
        Me.CharacterToolStripMenuItem.Name = "CharacterToolStripMenuItem"
        Me.CharacterToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CharacterToolStripMenuItem.Text = "&Character..."
        '
        'ParagraphToolStripMenuItem
        '
        Me.ParagraphToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_paragraphsettings
        Me.ParagraphToolStripMenuItem.Name = "ParagraphToolStripMenuItem"
        Me.ParagraphToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ParagraphToolStripMenuItem.Text = "&Paragraph..."
        '
        'BulletsAndNumberingToolStripMenuItem
        '
        Me.BulletsAndNumberingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PropertiesToolStripMenuItem, Me.IncreaseLevelToolStripMenuItem, Me.DecreaseLevelToolStripMenuItem, Me.ToolStripMenuItem22, Me.ToolStripMenuItem24, Me.ABCToolStripMenuItem, Me.ABcToolStripMenuItem1, Me.IIiIiiIvToolStripMenuItem, Me.IIiIiiIvToolStripMenuItem1, Me.BulletsToolStripMenuItem})
        Me.BulletsAndNumberingToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_listdialog
        Me.BulletsAndNumberingToolStripMenuItem.Name = "BulletsAndNumberingToolStripMenuItem"
        Me.BulletsAndNumberingToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.BulletsAndNumberingToolStripMenuItem.Text = "Bullets and &Numbering"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PropertiesToolStripMenuItem.Text = "&Properties..."
        '
        'IncreaseLevelToolStripMenuItem
        '
        Me.IncreaseLevelToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_indentincrease
        Me.IncreaseLevelToolStripMenuItem.Name = "IncreaseLevelToolStripMenuItem"
        Me.IncreaseLevelToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.IncreaseLevelToolStripMenuItem.Text = "&Increase Level"
        '
        'DecreaseLevelToolStripMenuItem
        '
        Me.DecreaseLevelToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_indentdecrease
        Me.DecreaseLevelToolStripMenuItem.Name = "DecreaseLevelToolStripMenuItem"
        Me.DecreaseLevelToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DecreaseLevelToolStripMenuItem.Text = "&Decrease Level"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(148, 6)
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem24.Text = "&1, 2, 3"
        '
        'ABCToolStripMenuItem
        '
        Me.ABCToolStripMenuItem.Name = "ABCToolStripMenuItem"
        Me.ABCToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ABCToolStripMenuItem.Text = "A, &B, C"
        '
        'ABcToolStripMenuItem1
        '
        Me.ABcToolStripMenuItem1.Name = "ABcToolStripMenuItem1"
        Me.ABcToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ABcToolStripMenuItem1.Text = "a, b, &c"
        '
        'IIiIiiIvToolStripMenuItem
        '
        Me.IIiIiiIvToolStripMenuItem.Name = "IIiIiiIvToolStripMenuItem"
        Me.IIiIiiIvToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.IIiIiiIvToolStripMenuItem.Text = "&I, II, III, IV"
        '
        'IIiIiiIvToolStripMenuItem1
        '
        Me.IIiIiiIvToolStripMenuItem1.Name = "IIiIiiIvToolStripMenuItem1"
        Me.IIiIiiIvToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.IIiIiiIvToolStripMenuItem1.Text = "i, ii, iii, i&v"
        '
        'BulletsToolStripMenuItem
        '
        Me.BulletsToolStripMenuItem.Name = "BulletsToolStripMenuItem"
        Me.BulletsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BulletsToolStripMenuItem.Text = "B&ullets"
        '
        'StylesToolStripMenuItem
        '
        Me.StylesToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_styledialog
        Me.StylesToolStripMenuItem.Name = "StylesToolStripMenuItem"
        Me.StylesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.StylesToolStripMenuItem.Text = "&Styles..."
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(193, 6)
        '
        'TabsToolStripMenuItem
        '
        Me.TabsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_tabs
        Me.TabsToolStripMenuItem.Name = "TabsToolStripMenuItem"
        Me.TabsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TabsToolStripMenuItem.Text = "&Tabs..."
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(193, 6)
        '
        'ImageToolStripMenuItem1
        '
        Me.ImageToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_image
        Me.ImageToolStripMenuItem1.Name = "ImageToolStripMenuItem1"
        Me.ImageToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.ImageToolStripMenuItem1.Text = "&Image..."
        '
        'TABLEToolStripMenuItem
        '
        Me.TABLEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.SelectToolStripMenuItem, Me.ToolStripMenuItem26, Me.MergeCellsToolStripMenuItem, Me.SplitCellsToolStripMenuItem, Me.SplitTableToolStripMenuItem, Me.GridLinesToolStripMenuItem, Me.ToolStripMenuItem27, Me.PropertiesToolStripMenuItem1})
        Me.TABLEToolStripMenuItem.Name = "TABLEToolStripMenuItem"
        Me.TABLEToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TABLEToolStripMenuItem.Text = "T&ABLE"
        '
        'InsertToolStripMenuItem1
        '
        Me.InsertToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableToolStripMenuItem1, Me.ToolStripMenuItem23, Me.ColumnToTheLeftToolStripMenuItem, Me.ColumnToTheRightToolStripMenuItem, Me.ToolStripMenuItem25, Me.RowAboveToolStripMenuItem, Me.RowBelowToolStripMenuItem})
        Me.InsertToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_table
        Me.InsertToolStripMenuItem1.Name = "InsertToolStripMenuItem1"
        Me.InsertToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.InsertToolStripMenuItem1.Text = "&Insert"
        '
        'TableToolStripMenuItem1
        '
        Me.TableToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_table
        Me.TableToolStripMenuItem1.Name = "TableToolStripMenuItem1"
        Me.TableToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.TableToolStripMenuItem1.Text = "&Table"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(184, 6)
        '
        'ColumnToTheLeftToolStripMenuItem
        '
        Me.ColumnToTheLeftToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_inserttablecolleft
        Me.ColumnToTheLeftToolStripMenuItem.Name = "ColumnToTheLeftToolStripMenuItem"
        Me.ColumnToTheLeftToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ColumnToTheLeftToolStripMenuItem.Text = "Column To The &Left"
        '
        'ColumnToTheRightToolStripMenuItem
        '
        Me.ColumnToTheRightToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_inserttablecolright
        Me.ColumnToTheRightToolStripMenuItem.Name = "ColumnToTheRightToolStripMenuItem"
        Me.ColumnToTheRightToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ColumnToTheRightToolStripMenuItem.Text = "Column To The &Right"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(184, 6)
        '
        'RowAboveToolStripMenuItem
        '
        Me.RowAboveToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_inserttablerowabove
        Me.RowAboveToolStripMenuItem.Name = "RowAboveToolStripMenuItem"
        Me.RowAboveToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RowAboveToolStripMenuItem.Text = "Row &Above"
        '
        'RowBelowToolStripMenuItem
        '
        Me.RowBelowToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_inserttablerowbelow
        Me.RowBelowToolStripMenuItem.Name = "RowBelowToolStripMenuItem"
        Me.RowBelowToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RowBelowToolStripMenuItem.Text = "Row &Below"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableToolStripMenuItem2, Me.ColumnToolStripMenuItem, Me.RowsToolStripMenuItem, Me.CelsToolStripMenuItem})
        Me.DeleteToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_deletetable
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.DeleteToolStripMenuItem1.Text = "&Delete"
        '
        'TableToolStripMenuItem2
        '
        Me.TableToolStripMenuItem2.Image = Global.CMCv.My.Resources.Resources.TED_16_deletetable
        Me.TableToolStripMenuItem2.Name = "TableToolStripMenuItem2"
        Me.TableToolStripMenuItem2.Size = New System.Drawing.Size(117, 22)
        Me.TableToolStripMenuItem2.Text = "&Table"
        '
        'ColumnToolStripMenuItem
        '
        Me.ColumnToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_deletetablecol
        Me.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem"
        Me.ColumnToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ColumnToolStripMenuItem.Text = "&Column"
        '
        'RowsToolStripMenuItem
        '
        Me.RowsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_deletetablerow
        Me.RowsToolStripMenuItem.Name = "RowsToolStripMenuItem"
        Me.RowsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RowsToolStripMenuItem.Text = "&Rows"
        '
        'CelsToolStripMenuItem
        '
        Me.CelsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShiftCellsLeftToolStripMenuItem, Me.DeleteEntireRowToolStripMenuItem, Me.DeleteEntireColumnToolStripMenuItem})
        Me.CelsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_deletetablecell
        Me.CelsToolStripMenuItem.Name = "CelsToolStripMenuItem"
        Me.CelsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CelsToolStripMenuItem.Text = "C&ells..."
        '
        'ShiftCellsLeftToolStripMenuItem
        '
        Me.ShiftCellsLeftToolStripMenuItem.Name = "ShiftCellsLeftToolStripMenuItem"
        Me.ShiftCellsLeftToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ShiftCellsLeftToolStripMenuItem.Text = "Shift Cells &Left"
        '
        'DeleteEntireRowToolStripMenuItem
        '
        Me.DeleteEntireRowToolStripMenuItem.Name = "DeleteEntireRowToolStripMenuItem"
        Me.DeleteEntireRowToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DeleteEntireRowToolStripMenuItem.Text = "Delete Entire &Row"
        '
        'DeleteEntireColumnToolStripMenuItem
        '
        Me.DeleteEntireColumnToolStripMenuItem.Name = "DeleteEntireColumnToolStripMenuItem"
        Me.DeleteEntireColumnToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.DeleteEntireColumnToolStripMenuItem.Text = "Delete Entire &Column"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableToolStripMenuItem3, Me.ColumnToolStripMenuItem1, Me.RowToolStripMenuItem, Me.CellsToolStripMenuItem})
        Me.SelectToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_selecttablerow
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SelectToolStripMenuItem.Text = "S&elect"
        '
        'TableToolStripMenuItem3
        '
        Me.TableToolStripMenuItem3.Image = Global.CMCv.My.Resources.Resources.TED_16_selecttable
        Me.TableToolStripMenuItem3.Name = "TableToolStripMenuItem3"
        Me.TableToolStripMenuItem3.Size = New System.Drawing.Size(117, 22)
        Me.TableToolStripMenuItem3.Text = "&Table"
        '
        'ColumnToolStripMenuItem1
        '
        Me.ColumnToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_selecttablecol
        Me.ColumnToolStripMenuItem1.Name = "ColumnToolStripMenuItem1"
        Me.ColumnToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ColumnToolStripMenuItem1.Text = "&Column"
        '
        'RowToolStripMenuItem
        '
        Me.RowToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_selecttablerow
        Me.RowToolStripMenuItem.Name = "RowToolStripMenuItem"
        Me.RowToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RowToolStripMenuItem.Text = "&Row"
        '
        'CellsToolStripMenuItem
        '
        Me.CellsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_selecttablecell
        Me.CellsToolStripMenuItem.Name = "CellsToolStripMenuItem"
        Me.CellsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CellsToolStripMenuItem.Text = "C&ells"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(133, 6)
        '
        'MergeCellsToolStripMenuItem
        '
        Me.MergeCellsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_mergetablecells
        Me.MergeCellsToolStripMenuItem.Name = "MergeCellsToolStripMenuItem"
        Me.MergeCellsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MergeCellsToolStripMenuItem.Text = "&Merge Cells"
        '
        'SplitCellsToolStripMenuItem
        '
        Me.SplitCellsToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_splittablecells
        Me.SplitCellsToolStripMenuItem.Name = "SplitCellsToolStripMenuItem"
        Me.SplitCellsToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SplitCellsToolStripMenuItem.Text = "&Split Cells"
        '
        'SplitTableToolStripMenuItem
        '
        Me.SplitTableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboveToolStripMenuItem, Me.BelowToolStripMenuItem})
        Me.SplitTableToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_splittable
        Me.SplitTableToolStripMenuItem.Name = "SplitTableToolStripMenuItem"
        Me.SplitTableToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SplitTableToolStripMenuItem.Text = "S&plit Table"
        '
        'AboveToolStripMenuItem
        '
        Me.AboveToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_splittableabove
        Me.AboveToolStripMenuItem.Name = "AboveToolStripMenuItem"
        Me.AboveToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.AboveToolStripMenuItem.Text = "&Above"
        '
        'BelowToolStripMenuItem
        '
        Me.BelowToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_splittablebelow
        Me.BelowToolStripMenuItem.Name = "BelowToolStripMenuItem"
        Me.BelowToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.BelowToolStripMenuItem.Text = "&Below"
        '
        'GridLinesToolStripMenuItem
        '
        Me.GridLinesToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_tablegridlines
        Me.GridLinesToolStripMenuItem.Name = "GridLinesToolStripMenuItem"
        Me.GridLinesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GridLinesToolStripMenuItem.Text = "&Grid Lines"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(133, 6)
        '
        'PropertiesToolStripMenuItem1
        '
        Me.PropertiesToolStripMenuItem1.Image = Global.CMCv.My.Resources.Resources.TED_16_tabledialog
        Me.PropertiesToolStripMenuItem1.Name = "PropertiesToolStripMenuItem1"
        Me.PropertiesToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.PropertiesToolStripMenuItem1.Text = "&Properties..."
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTextEditorToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "&HELP"
        '
        'AboutTextEditorToolStripMenuItem
        '
        Me.AboutTextEditorToolStripMenuItem.Image = Global.CMCv.My.Resources.Resources.TED_16_help
        Me.AboutTextEditorToolStripMenuItem.Name = "AboutTextEditorToolStripMenuItem"
        Me.AboutTextEditorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AboutTextEditorToolStripMenuItem.Text = "About CMC Text Editor"
        '
        'frmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(846, 479)
        Me.Controls.Add(Me.Canvas)
        Me.Controls.Add(Me.RulerBarVertical)
        Me.Controls.Add(Me.RulerBar)
        Me.Controls.Add(Me.ButtonBar)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MnuTextEditor)
        Me.KeyPreview = True
        Me.Name = "frmTextEditor"
        Me.Text = "Nama Form"
        Me.Controls.SetChildIndex(Me.MnuTextEditor, 0)
        Me.Controls.SetChildIndex(Me.StatusBar, 0)
        Me.Controls.SetChildIndex(Me.pnl_, 0)
        Me.Controls.SetChildIndex(Me.SLFPanel, 0)
        Me.Controls.SetChildIndex(Me.ButtonBar, 0)
        Me.Controls.SetChildIndex(Me.RulerBar, 0)
        Me.Controls.SetChildIndex(Me.RulerBarVertical, 0)
        Me.Controls.SetChildIndex(Me.Canvas, 0)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.MnuTextEditor.ResumeLayout(False)
        Me.MnuTextEditor.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents RulerBar As TXTextControl.RulerBar
    Friend WithEvents Canvas As TXTextControl.TextControl
    Friend WithEvents ButtonBar As TXTextControl.ButtonBar
    Friend WithEvents StatusBar As TXTextControl.StatusBar
    Friend WithEvents RulerBarVertical As TXTextControl.RulerBar
    Friend WithEvents MnuTextEditor As CMCv.mnu
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HTMLSettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INSERTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FORMATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TABLEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageLayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DraftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalRulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalRulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextFramemakerLinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TargetMarkersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageBreakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextWrappingBreakToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CharacterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BulletsAndNumberingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABcToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IIiIiiIvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IIiIiiIvToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BulletsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StylesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImageToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColumnToTheLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnToTheRightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RowAboveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowBelowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MergeCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitCellsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BelowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridLinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTextEditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShiftCellsLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEntireRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteEntireColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
