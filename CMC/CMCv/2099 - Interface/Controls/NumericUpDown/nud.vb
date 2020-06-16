Imports System.ComponentModel

Public Class nud
    Inherits System.Windows.Forms.NumericUpDown

    Public Sub New()
        InitializeComponent()
        MyBase.Height = 23
        MyBase.Width = 206
        MyBase.Font = globalFontTxt
        Me.SLFHightlightSaatFokus = False
        Me.SLFHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.SLFPilihSemuaSaatFokus = False
        MyBase.DoubleBuffered = True
    End Sub

#Region "Properti"
    <Category("Text"), _
Description("Potong spasi kiri-kanan secara otomatis saat lost focus")> _
    Public Property SLFAutoTrim() As Boolean
        Get
            Return _varAutoTrim
        End Get
        Set(value As Boolean)
            _varAutoTrim = value
        End Set
    End Property

    <Category("Text"), _
    Description("Teksboks harus diisi")> _
    Public Property SLFHarusDiisi As Boolean
        Get
            Return _varHarusDiisi
        End Get
        Set(value As Boolean)
            _varHarusDiisi = value
        End Set
    End Property

    Private _varHightlightSaatFokus As Boolean
    <Category("Text"), _
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")> _
    Public Property SLFHightlightSaatFokus() As Boolean
        Get
            Return _varHightlightSaatFokus
        End Get
        Set(value As Boolean)
            _varHightlightSaatFokus = value
        End Set
    End Property

    Private _varHighlightSaatFokusWarna As System.Drawing.Color
    <Category("Text"), _
    Description("Warna highlight")> _
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
End Class
