Imports System.ComponentModel.Component

Public Class meb
    Inherits System.Windows.Forms.MaskedTextBox

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontTxt
        MyBase.Width = 206
        Me.SLFHarusDiisi = False
        Me.SLFHarusDiisiWarnaLatar = Drawing.Color.LightPink
        Me.SLFHarusDiisiWarnaLatarDefault = Drawing.Color.White
        Me.SLFHightlightSaatFokus = False
        Me.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.SLFPilihSemuaSaatFokus = False
    End Sub

#Region "Properti"
    Private _varHarusDiisi As Boolean
    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Maskeditbox harus diisi")> _
    Public Property SLFHarusDiisi As Boolean
        Get
            Return _varHarusDiisi
        End Get
        Set(value As Boolean)
            _varHarusDiisi = value
        End Set
    End Property

    Private _varHarusDiisiWarnaLatarDefault As System.Drawing.Color
    Private _varHarusDiisiWarnaLatar As System.Drawing.Color
    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Warna saat teksboks tidak diisi")> _
    Public Property SLFHarusDiisiWarnaLatar As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatar
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatar = value
        End Set
    End Property

    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Warna saat teksboks tidak diisi jika bernilai False")> _
    Public Property SLFHarusDiisiWarnaLatarDefault As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatarDefault
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatarDefault = value
        End Set
    End Property

    Private _varHightlightSaatFokus As Boolean
    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")> _
    Public Property SLFHightlightSaatFokus() As Boolean
        Get
            Return _varHightlightSaatFokus
        End Get
        Set(value As Boolean)
            _varHightlightSaatFokus = value
        End Set
    End Property

    Private _varHighlightSaatFokusWarna As System.Drawing.Color
    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Warna highlight")> _
    Public Property SLFHightlightSaatFokusWarna() As System.Drawing.Color
        Get
            Return _varHighlightSaatFokusWarna
        End Get
        Set(value As System.Drawing.Color)
            _varHighlightSaatFokusWarna = value
        End Set
    End Property

    Private _varPilihSemuaSaatFokus As Boolean
    <System.ComponentModel.Category("Text"), _
    System.ComponentModel.Description("Memilih semua teks saat fokus")> _
    Public Property SLFPilihSemuaSaatFokus() As Boolean
        Get
            Return _varPilihSemuaSaatFokus
        End Get
        Set(value As Boolean)
            _varPilihSemuaSaatFokus = value
        End Set
    End Property
#End Region

    Private _varFlagAutoSelect As Boolean
    Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        If Me.SLFPilihSemuaSaatFokus AndAlso (MouseButtons = Windows.Forms.MouseButtons.None) Then
            Me.SelectAll()
            _varFlagAutoSelect = True
        End If
        If Me.SLFHightlightSaatFokus Then
            MyBase.BackColor = Me.SLFHightlightSaatFokusWarna
        End If
        If Me.SLFPilihSemuaSaatFokus Then
            Me.Select(0, Me.Text.Length)
        End If
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        'If Me.SLFHightlightSaatFokus AndAlso Not Me.Focused AndAlso Not Me.SLFHarusDiisi Then
        '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
        'ElseIf Me.SLFHightlightSaatFokus AndAlso Not Me.Focused Then
        '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
        If Me.SLFHarusDiisi = True Then 'AndAlso Me.Text.Trim = "" Then
            MyBase.BackColor = Me.SLFHarusDiisiWarnaLatar
        Else
            MyBase.BackColor = Me.SLFHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If Me.SLFHightlightSaatFokus Then
            MyBase.BackColor = Me.SLFHightlightSaatFokusWarna
        End If
    End Sub

    Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Me.SLFHightlightSaatFokus And Not Me.Focused Then
            MyBase.BackColor = Me.SLFHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If Me.SLFPilihSemuaSaatFokus AndAlso (Not _varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
            _varFlagAutoSelect = True
            Me.SelectAll()
        End If
    End Sub
End Class
