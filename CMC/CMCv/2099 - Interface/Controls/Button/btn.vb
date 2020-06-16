'Imports System
'Imports System.Drawing
'Imports System.Windows.Forms
'Imports System.Windows.Forms.VisualStyles
Imports System.ComponentModel


''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom button
''' </summary>
''' <remarks></remarks>
Public Class btn
    Inherits System.Windows.Forms.Button
    Public Event ValidasiBerhasil()

    Public Sub New()
        InitializeComponent()
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.FlatAppearance.BorderSize = 2
        'MyBase.BackColor = System.Drawing.Color.Orange
        MyBase.Size = New System.Drawing.Size(100, 40)
        MyBase.Cursor = System.Windows.Forms.Cursors.Hand
        MyBase.Font = globalFontBtn
        'Me.SLFTampilkanBorder = False
        Me.SLFTampilkanFocusBorder = False
        Me.SLFJenisTombol = ControlCodeBase.enuJenisTombol.Default
        MyBase.DoubleBuffered = True
    End Sub

    Private _varJenisTombol As ControlCodeBase.enuJenisTombol
    <Category("Text"), _
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")> _
    Public Property SLFJenisTombol() As ControlCodeBase.enuJenisTombol
        Get
            Return _varJenisTombol
        End Get
        Set(value As ControlCodeBase.enuJenisTombol)
            _varJenisTombol = value
            GantiWarnaTombol(value)
        End Set
    End Property

    Private _varValidasiSemuaInput As Boolean
    <Category("Text"), _
    Description("Memvalidasi semua input telah diisi")> _
    Public Property SLFValidasiSemuaInput() As Boolean
        Get
            Return _varValidasiSemuaInput
        End Get
        Set(value As Boolean)
            _varValidasiSemuaInput = value
        End Set
    End Property

    Private _varValidasiSemuaInputTag As String
    <Category("Text"), _
    Description("Teksboks dengan Tag ini yang akan divalidasi")> _
    Public Property SLFValidasiSemuaInputTag() As String
        Get
            Return _varValidasiSemuaInputTag
        End Get
        Set(value As String)
            _varValidasiSemuaInputTag = value
        End Set
    End Property

    'Private _varStatusTeks As String
    '<Category("Text"), _
    'Description("Teks yang ditampilkan pada bilah status")> _
    'Public Property SLFStatusTeks() As String
    '    Get
    '        Return _varStatusTeks
    '    End Get
    '    Set(value As String)
    '        _varStatusTeks = value
    '    End Set
    'End Property

    'Private _varStatusTeksKomponen As CMCv.stt
    '<Category("Text"), _
    'Description("Tulisan yang tampil di status")> _
    'Public Property SLFStatusTeksKomponen(Optional ByVal KomponenStatus As CMCv.stt = Nothing) As CMCv.stt
    '    Get
    '        Return _varStatusTeksKomponen
    '    End Get
    '    Set(value As CMCv.stt)
    '        _varStatusTeksKomponen = value
    '    End Set
    'End Property

    ''' <summary>
    ''' Ganti warna tombol.
    ''' </summary>
    ''' <param name="_valEnuJenisTombol">Enumerasi jenis tombol.</param>
    Private Sub GantiWarnaTombol(ByVal _valEnuJenisTombol As ControlCodeBase.enuJenisTombol)
        Select Case _valEnuJenisTombol
            Case ControlCodeBase.enuJenisTombol.Yes
                MyBase.BackColor = Drawing.Color.LimeGreen
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.No
                MyBase.BackColor = Drawing.Color.Red
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.Default
                MyBase.BackColor = Drawing.Color.RoyalBlue
                MyBase.ForeColor = Drawing.Color.White
            Case ControlCodeBase.enuJenisTombol.Warning
                MyBase.BackColor = Drawing.Color.Yellow
                MyBase.ForeColor = Drawing.Color.Black
            Case ControlCodeBase.enuJenisTombol.Custom
                'MyBase.BackColor = System.Drawing.Color.Orange
                'MyBase.ForeColor = Drawing.Color.Black
        End Select
    End Sub

    Private Sub btn_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
        If Me.FlatStyle = Windows.Forms.FlatStyle.Flat Then
            MyBase.FlatAppearance.BorderColor = CBS.AmbilWarna(MyBase.BackColor, ControlCodeBase.enuOpasitasWarna.Darker, 60)
            MyBase.FlatAppearance.MouseOverBackColor = CBS.AmbilWarna(MyBase.BackColor, ControlCodeBase.enuOpasitasWarna.Lighter, 20)
        End If
    End Sub

    Private _varTampilkanFocusBorder As Boolean = False
    Protected Overrides ReadOnly Property ShowFocusCues() As Boolean
        Get
            Return _varTampilkanFocusBorder
        End Get
    End Property

    Public Property SLFTampilkanFocusBorder() As Boolean
        Get
            Return _varTampilkanFocusBorder
        End Get
        Set(value As Boolean)
            _varTampilkanFocusBorder = value
        End Set
    End Property

    'Private _varTampilkanBorder As Boolean = False
    'Public Property SLFTampilkanBorder() As Boolean
    '    Get
    '        Return _varTampilkanBorder
    '    End Get
    '    Set(value As Boolean)
    '        _varTampilkanBorder = value
    '    End Set
    'End Property

    'Protected Overrides Sub OnPaint(pe As System.Windows.Forms.PaintEventArgs)
    '    MyBase.OnPaint(pe)
    '    If SLFTampilkanBorder = True Then
    '        pe.Graphics.DrawRectangle(New System.Drawing.Pen(BackColor, 5), ClientRectangle)
    '    Else
    '        pe.Graphics.DrawRectangle(New System.Drawing.Pen(BackColor, 0), ClientRectangle)
    '    End If
    'End Sub


    'Private _varRenderer As VisualStyleRenderer
    'Private _varButtonBgColor As System.Drawing.Color
    'Protected Overrides Sub OnPaint(pevent As System.Windows.Forms.PaintEventArgs)
    '    MyBase.OnPaint(pevent)
    'If Me.Focused AndAlso Application.RenderWithVisualStyles AndAlso Me.FlatStyle = FlatStyle.Standard Then
    '    If _varRenderer Is Nothing Then
    '        Dim elem As VisualStyleElement
    '        elem = VisualStyleElement.Button.PushButton.Normal
    '        _varRenderer = New VisualStyleRenderer(elem.ClassName, elem.Part, Int(PushButtonState.Normal))
    '        Dim rc As Rectangle
    '        rc = _varRenderer.GetBackgroundContentRectangle(pevent.Graphics, New Rectangle(0, 0, Me.Width, Me.Height))
    '        rc.Height -= 1
    '        rc.Width -= 1
    '        _varButtonBgColor = MyBase.BackColor
    '        Using p As New Pen(_varButtonBgColor)
    '            pevent.Graphics.DrawRectangle(p, rc)
    '        End Using

    '    End If
    'End If
    'End Sub

    'Public Overrides Sub NotifyDefault(value As Boolean)
    '    MyBase.NotifyDefault(False)
    'End Sub

    'Private Sub btn_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
    '    _varStatusTeksKomponen.Text = _varStatusTeks
    'End Sub
End Class
