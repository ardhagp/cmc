Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class pctbx
    Inherits System.Windows.Forms.PictureBox
    'Private initimg As New System.Drawing.Image

    Public Sub New()
        InitializeComponent()
        MyBase.BackColor = Drawing.Color.White
        MyBase.InitialImage = My.Resources.Loading_001_24_FFFFFFFF_
        MyBase.ErrorImage = My.Resources.FailToLoad_001_24_FFFFFFFF_
        MyBase.SizeMode = PictureBoxSizeMode.Zoom
        'MyBase.Image = My.Resources.pctbxinitial
        Me.SLFTampilkanBorder = False
        Me.SLFWarnaBorder = Color.DodgerBlue
        MyBase.DoubleBuffered = True
    End Sub

    Private _varTampilkanBorder As Boolean
    Public Property SLFTampilkanBorder As Boolean
        Get
            Return _varTampilkanBorder
        End Get
        Set(value As Boolean)
            _varTampilkanBorder = value
        End Set
    End Property

    Private _varWarnaBorder As Color
    Public Property SLFWarnaBorder As Color
        Get
            Return _varWarnaBorder
        End Get
        Set(value As Color)
            _varWarnaBorder = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        If Me.SLFTampilkanBorder = True Then
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Me.SLFWarnaBorder, ButtonBorderStyle.Outset)
        End If
        MyBase.OnPaint(pe)
    End Sub
End Class
