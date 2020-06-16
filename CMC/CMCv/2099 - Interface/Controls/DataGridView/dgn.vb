Imports System.ComponentModel
Imports System.Reflection

''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Datagridview dengan warna random dan nomor urut baris.
''' </summary>
''' <remarks></remarks>
Public Class dgn
    Public Event SLF_Selected()
    'Public Event SLF_NewGridColor()

    Public Sub New()
        InitializeComponent()
        'MyBase.AlternatingRowsDefaultCellStyle.BackColor = CBS.WarnaAcakBaru(190, 190, 190, 255, 255, 255)
        MyBase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        MyBase.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        MyBase.ColumnHeadersHeight = 43
        MyBase.Font = globalFontDgn
        MyBase.EnableHeadersVisualStyles = False
        MyBase.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
        MyBase.ColumnHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.YellowGreen
        MyBase.ColumnHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
        MyBase.RowHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.RowHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
        MyBase.RowHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.Yellow
        MyBase.RowHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
        MyBase.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        MyBase.StandardTab = True
        MyBase.BorderStyle = Windows.Forms.BorderStyle.None
        MyBase.DoubleBuffered = True
    End Sub


    Private _varGunakanNomorBaris As Boolean
    Public Property SLFGunakanNomorBaris() As Boolean
        Get
            Return _varGunakanNomorBaris
        End Get
        Set(ByVal value As Boolean)
            _varGunakanNomorBaris = value
        End Set
    End Property

    Private _varGroupFirstRows As Boolean
    Public Property SLFGroupFirstRows As Boolean
        Get
            Return _varGroupFirstRows
        End Get
        Set(value As Boolean)
            _varGroupFirstRows = value
        End Set
    End Property

    Private Function RGB(p1 As Integer) As System.Drawing.Color
        Throw New NotImplementedException
    End Function

    Private Sub dgn_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
        If SLFGroupFirstRows = True Then
            If e.RowIndex > 0 And e.ColumnIndex = 0 Then
                If MyBase.Item(0, e.RowIndex - 1).Value = e.Value Then
                    e.Value = String.Empty
                    'MyBase.AdvancedCellBorderStyle.Top = Windows.Forms.DataGridViewAdvancedCellBorderStyle.None
                    'MyBase.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
                ElseIf e.RowIndex < MyBase.Rows.Count - 1 Then

                End If
            End If

        End If
    End Sub

    Private Sub dgn_CellMouseDown(sender As Object, e As Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.CellMouseDown
        If (e.Button = Windows.Forms.MouseButtons.Right) Or (e.Button = Windows.Forms.MouseButtons.Left) Then
            Try
                MyBase.CurrentCell = Me(e.ColumnIndex, e.RowIndex)
                RaiseEvent SLF_Selected()
            Catch ex As Exception
                'do nothing
            End Try
        End If
    End Sub

    Public Enum eGETNewColor
        Yes
        No
    End Enum

    Public Sub SLF_GETNewColor()
        Call GENERATENewColor()
    End Sub

    Private Sub dgn_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Call GENERATENewColor()
    End Sub

    Private Sub dgn_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        RaiseEvent SLF_Selected()
    End Sub

    Private Sub GENERATENewColor()
        MyBase.AlternatingRowsDefaultCellStyle.BackColor = CBS.WarnaAcakBaru(190, 255, 190, 255, 90, 190)
    End Sub
End Class

