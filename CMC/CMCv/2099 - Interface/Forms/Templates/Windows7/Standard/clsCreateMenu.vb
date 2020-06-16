Imports System.Windows.Forms

Namespace UI.View
    Public Class MenuStrip
        Private _MMSMenu As New CMCv.mnu
        Private _item() As ToolStripMenuItem
        Private _item_sub() As ToolStripMenuItem

        Public Event EventDataAddNew()
        Public Event EventDataEdit()
        Public Event EventDataDelete()
        Public Event EventDataRefresh()
        Public Event EventDataClose()
        Public Event EventToolsImport()
        Public Event EventToolsExport()
        Public Event EventToolsFind()
        Public Event EventToolsViewAttachment()
        Public Event EventFileSave()
        Public Event EventFileUndoAll()
        Public Event EventFileCancel()
        Public Event EventReportShow()

        Private _EventToolsViewAttachmentVisible As Boolean = False
        Private _EventToolsViewAttachmentChecked As Boolean = False

        Public Enum ShowItem
            Yes = 1
            No = 0
        End Enum


#Region "CreateMenu"
        ''' <summary>
        ''' Menampilkan menu subform
        ''' </summary>
        ''' <param name="FormName">Nama form dimana menu akan ditampilkan</param>
        ''' <remarks></remarks>
        Public Sub LoadIn(ByVal FormName As Form, Optional ByVal IsShown As Boolean = False)
            Dim _item_sep() As ToolStripSeparator

            ReDim _item(4)
            '_MMSMenu = New CMCv.mnu
            With _MMSMenu
                .Visible = IsShown
                .Font = New Drawing.Font("Segoe UI", 12)
            End With


            'Add menu RECORD
            _item(0) = New ToolStripMenuItem() With {.Name = "RECORD", .Text = "RECORD", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 1}
            _MMSMenu.Items.Add(_item(0))

            'Add menu TOOLS
            _item(1) = New ToolStripMenuItem() With {.Name = "TOOLS", .Text = "TOOLS", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            _MMSMenu.Items.Add(_item(1))

            'Add menu TOOLS
            _item(2) = New ToolStripMenuItem() With {.Name = "REPORTS", .Text = "REPORTS", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            _MMSMenu.Items.Add(_item(2))

            'Add menu FILE
            _item(3) = New ToolStripMenuItem() With {.Name = "FILE", .Text = "FILE", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            _MMSMenu.Items.Add(_item(3))

            For Each _item As ToolStripMenuItem In _MMSMenu.Items
                _item.Visible = False
            Next

            FormName.Controls.Add(_MMSMenu)

            ReDim _item_sub(12) 'normal items
            ReDim _item_sep(5) 'separator items

            For Each _s_item As ToolStripMenuItem In _MMSMenu.Items

                Select Case _s_item.Name
                    Case "RECORD"
                        'Insert "Add New..."
                        _item_sub(0) = New ToolStripMenuItem() With {.Name = "EventDataAddNew", .Text = "Add New...", .ShortcutKeys = Keys.Control + Keys.N, .ShortcutKeyDisplayString = "Ctrl+N"}
                        _s_item.DropDown.Items.Add(_item_sub(0))
                        AddHandler _item_sub(0).Click, AddressOf EventDataAddNew_Clicked

                        'Insert "Edit..."
                        _item_sub(1) = New ToolStripMenuItem() With {.Name = "EventDataEdit", .Text = "Edit...", .ShortcutKeys = Keys.Control + Keys.E, .ShortcutKeyDisplayString = "Ctrl+E"}
                        _s_item.DropDown.Items.Add(_item_sub(1))
                        AddHandler _item_sub(1).Click, AddressOf EventDataEdit_Clicked

                        'Insert "Delete..."
                        _item_sub(2) = New ToolStripMenuItem() With {.Name = "EventDataDelete", .Text = "Delete", .ShortcutKeys = Keys.Control + Keys.Delete, .ShortcutKeyDisplayString = "Ctrl+Del"}
                        _s_item.DropDown.Items.Add(_item_sub(2))
                        AddHandler _item_sub(2).Click, AddressOf EventDataDelete_Clicked

                        'Insert "Separator"
                        _item_sep(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                        _s_item.DropDown.Items.Add(_item_sep(0))

                        'Insert "Find"
                        _item_sub(3) = New ToolStripMenuItem() With {.Name = "EventToolsFind", .Text = "Find", .ShortcutKeys = Keys.Control + Keys.F, .ShortcutKeyDisplayString = "Ctrl+F"}
                        _s_item.DropDown.Items.Add(_item_sub(3))
                        AddHandler _item_sub(3).Click, AddressOf EventToolsFind_Clicked

                        'Insert "Refresh"
                        _item_sub(4) = New ToolStripMenuItem() With {.Name = "EventDataRefresh", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                        _s_item.DropDown.Items.Add(_item_sub(4))
                        AddHandler _item_sub(4).Click, AddressOf EventDataRefresh_Clicked

                        'Insert "Separator"
                        _item_sep(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                        _s_item.DropDown.Items.Add(_item_sep(1))

                        'Insert "Close"
                        _item_sub(5) = New ToolStripMenuItem() With {.Name = "EventDataClose", .Text = "Close", .ShortcutKeys = Keys.Control + Keys.F4, .ShortcutKeyDisplayString = "Ctrl+F4"}
                        _s_item.DropDown.Items.Add(_item_sub(5))
                        AddHandler _item_sub(5).Click, AddressOf EventDataClose_Clicked

                    Case "TOOLS"
                        'Insert "Import"
                        _item_sub(6) = New ToolStripMenuItem() With {.Name = "EventToolsImport", .Text = "Import...", .Enabled = False}
                        _s_item.DropDown.Items.Add(_item_sub(6))
                        AddHandler _item_sub(6).Click, AddressOf EventToolsImport_Clicked

                        'Insert "Export"
                        _item_sub(7) = New ToolStripMenuItem() With {.Name = "EventToolsExport", .Text = "Export...", .Enabled = False}
                        _s_item.DropDown.Items.Add(_item_sub(7))
                        AddHandler _item_sub(7).Click, AddressOf EventToolsExport_Clicked

                        'Insert "Separator"
                        _item_sep(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        _s_item.DropDown.Items.Add(_item_sep(2))

                        'Insert "ViewAttachment"
                        _item_sub(8) = New ToolStripMenuItem() With {.Name = "EventToolsViewAttachment", .Text = "Attachment Viewer", .Visible = False, .CheckOnClick = True, .Checked = False, .ShortcutKeys = Keys.Alt + Keys.P, .ShortcutKeyDisplayString = "Alt+P"}
                        _s_item.DropDown.Items.Add(_item_sub(8))
                        AddHandler _item_sub(8).Click, AddressOf EventToolsViewAttachment_Clicked
                    Case "FILE"
                        'Insert "Save"
                        _item_sub(9) = New ToolStripMenuItem() With {.Name = "EventToolsSave", .Text = "Save", .ShortcutKeys = Keys.Control + Keys.S, .ShortcutKeyDisplayString = "Ctrl+S"}
                        _s_item.DropDown.Items.Add(_item_sub(9))
                        AddHandler _item_sub(9).Click, AddressOf EventFileSave_Clicked

                        'Insert "Undo All"
                        _item_sub(10) = New ToolStripMenuItem() With {.Name = "EventToolsUndoAll", .Text = "Undo All", .ShortcutKeys = Keys.Control + Keys.Z, .ShortcutKeyDisplayString = "Ctrl+Z"}
                        _s_item.DropDown.Items.Add(_item_sub(10))
                        AddHandler _item_sub(10).Click, AddressOf EventFileUndoAll_Clicked

                        'Insert "Separator"
                        _item_sep(3) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        _s_item.DropDown.Items.Add(_item_sep(3))

                        'Insert "Close"
                        _item_sub(11) = New ToolStripMenuItem() With {.Name = "EventFileCancel", .Text = "Cancel", .ShortcutKeys = Keys.Control + Keys.F4, .ShortcutKeyDisplayString = "Ctrl+F4"}
                        _s_item.DropDown.Items.Add(_item_sub(11))
                        AddHandler _item_sub(11).Click, AddressOf EventFileCancel_Clicked
                    Case "REPORTS"
                        'Insert "Report"
                        _item_sub(12) = New ToolStripMenuItem() With {.Name = "EventReportsShow", .Text = "Generate...", .ShortcutKeys = Keys.Control + Keys.L, .ShortcutKeyDisplayString = "Ctrl+L"}
                        _s_item.DropDown.Items.Add(_item_sub(12))
                        AddHandler _item_sub(12).Click, AddressOf EventReportsView_Clicked
                End Select
            Next
        End Sub
#End Region

#Region "Events"
        Private Sub EventDataAddNew_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataAddNew()
            End If
        End Sub

        Private Sub EventDataEdit_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataEdit()
            End If
        End Sub

        Private Sub EventDataDelete_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataDelete()
            End If
        End Sub

        Private Sub EventDataRefresh_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataRefresh()
            End If
        End Sub

        Private Sub EventDataClose_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataClose()
            End If
        End Sub

        Private Sub EventToolsImport_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsImport()
            End If
        End Sub

        Private Sub EventToolsExport_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsExport()
            End If
        End Sub

        Private Sub EventToolsFind_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsFind()
            End If
        End Sub

        Private Sub EventToolsViewAttachment_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsViewAttachment()
            End If
        End Sub

        Private Sub EventFileSave_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileSave()
            End If
        End Sub

        Private Sub EventFileUndoAll_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileUndoAll()
            End If
        End Sub

        Private Sub EventFileCancel_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileCancel()
            End If
        End Sub

        Public Sub EventReportsView_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventReportShow()
            End If
        End Sub
#End Region

#Region "Subs Collections"
        Public Function Visible(ByVal MenuName As String) As Boolean
            Dim _IsVisible As Boolean = False

            Try
                For Each SubMenu As Object In _item_sub
                    If SubMenu.Name = MenuName Then
                        _IsVisible = _EventToolsViewAttachmentVisible
                        SubMenu.Visible = _EventToolsViewAttachmentVisible
                    End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return _IsVisible
        End Function

        Public Sub Visible(ByVal MenuName As String, ByVal Value As ShowItem)
            Try
                For Each SubMenu As Object In _item_sub
                    If SubMenu.Name = MenuName Then
                        SubMenu.Visible = Value
                        _EventToolsViewAttachmentVisible = Value
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Function Checked(ByVal MenuName As String) As Boolean
            Dim _IsChecked As Boolean = False
            Try
                For Each SubMenu As Object In _item_sub
                    If SubMenu.name = MenuName Then
                        _IsChecked = _EventToolsViewAttachmentChecked
                        SubMenu.Checked = _EventToolsViewAttachmentChecked
                    End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return _IsChecked
        End Function

        Public Sub Checked(ByVal MenuName As String, ByVal Value As ShowItem)
            Try
                For Each SubMenu As Object In _item_sub
                    If SubMenu.Name = MenuName Then
                        SubMenu.Checked = Value
                        _EventToolsViewAttachmentChecked = Value
                        Exit Sub
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub ShowMenuDATA(Optional ByVal Value As ShowItem = False)
            _item(0).Visible = Value
        End Sub

        Public Sub ShowMenuTOOLS(Optional ByVal Value As ShowItem = False)
            _item(1).Visible = Value
        End Sub

        Public Sub ShowMenuREPORTS(Optional ByVal Value As ShowItem = False)
            _item(2).Visible = Value
        End Sub

        Public Sub ShowMenuFILE(Optional ByVal Value As ShowItem = False)
            _item(3).Visible = Value
        End Sub
#End Region


    End Class

    Public Class ContextMenu
        Private _CSMenu As New ContextMenuStrip
        Private _item() As ToolStripMenuItem

#Region "Public Events"
        Public Event ContextCopy()
#End Region

        Public Sub LoadInGrid(ByVal Grid As dgn)

            'Dim _item_sub() As ToolStripMenuItem

            _CSMenu = New ContextMenuStrip
            ReDim _item(1)

            _CSMenu.Visible = True

            _item(0) = New ToolStripMenuItem() With {.Name = "COPYCELL", .Text = "Copy"}
            _CSMenu.Items.Add(_item(0))
            AddHandler _item(0).Click, AddressOf ContextCopy_Clicked
            Grid.ContextMenuStrip = _CSMenu


        End Sub

#Region "Context Menu Events"
        Private Sub ContextCopy_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent ContextCopy()
            End If
        End Sub
#End Region

    End Class
End Namespace
