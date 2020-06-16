<Drawing.ToolboxBitmap(GetType(dgn), "dgn.ico")>
Partial Class dgn
    Inherits System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgn
        '
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColumnHeadersHeight = 42
        Me.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private Sub dgn_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Me.EditingControlShowing
        'If DgnItem.CurrentCell.ColumnIndex = 9 Or DgnItem.CurrentCell.ColumnIndex = 10 Or DgnItem.CurrentCell.ColumnIndex = 11 Or DgnItem.CurrentCell.ColumnIndex = 12 And Not e.Control Is Nothing Then
        '    Dim tb As TextBox = CType(e.Control, TextBox)
        '    '---add an event handler to the TextBox control---
        '    AddHandler tb.KeyPress, AddressOf DgnItem_KeyPress
        'End If
    End Sub

    Private Sub dgn_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        '        If (Not (Char.IsDigit(e.KeyChar) Or _
        'Char.IsControl(e.KeyChar))) Then
        '            e.Handled = True
        '        End If
    End Sub

    Private Sub dgn_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Me.RowPostPaint
        'If _varGunakanNomorBaris Then
        If Me.SLFGunakanNomorBaris Then
            ' get the row number in leading zero format, 
            '  where the width of the number = the width of the maximum number
            Dim RowNumWidth As Integer = Me.RowCount.ToString().Length
            Dim RowNumber As String = RowNumWidth
            'StringBuilder(RowNumber = New StringBuilder(RowNumWidth))
            'RowNumber.Append(e.RowIndex + 1)
            RowNumber &= e.RowIndex + 1
            'While (RowNumber.Length < RowNumWidth)
            '    RowNumber.Insert(0, "0")
            'End While


            ' get the size of the row number string
            'SizeF(Sz = e.Graphics.MeasureString(RowNumber.ToString(), Me.Font))
            Dim Sz As System.Drawing.SizeF = e.Graphics.MeasureString(RowNumber.ToString(), Me.Font)

            ' adjust the width of the column that contains the row header cells 
            If Me.RowHeadersWidth < (Sz.Width + 20) Then
                Me.RowHeadersWidth = (Sz.Width + 20)
            End If
            'If (Me.RowHeadersWidth < (Int())(Sz.Width + 20)) Then
            '    Me.RowHeadersWidth = (Int())(Sz.Width + 20)

            ' draw the row number6
            e.Graphics.DrawString(e.RowIndex + 1, Me.Font, System.Drawing.SystemBrushes.ControlText, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2))
            'Else
            '    e.Graphics.DrawString("", Me.Font, SystemBrushes.ControlText, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - Sz.Height) / 2))
        End If

        MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        'MyBase.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(192, 192, 255)
        'MyBase.AlternatingRowsDefaultCellStyle.BackColor = CBS.WarnaAcakBaru(190, 255, 190, 255, 255, 255)
        MyBase.AllowUserToResizeRows = False
        MyBase.MultiSelect = False
        MyBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class
