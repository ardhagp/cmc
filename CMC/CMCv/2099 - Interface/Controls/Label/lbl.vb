Imports System.ComponentModel
Imports System.Windows.Forms

Public Class lbl
    Inherits System.Windows.Forms.Label

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontTxt
        Me.SLFCustomElipsis = False
        'Me.SLFTypeOfElipsis = TextFormatFlags.Default
        MyBase.DoubleBuffered = True
    End Sub

    Private _varCustomElipsis As Boolean
    Public Property SLFCustomElipsis As Boolean
        Get
            Return _varCustomElipsis
        End Get
        Set(value As Boolean)
            _varCustomElipsis = value
        End Set
    End Property

    'Private _varTypeOfElipsis As TextFormatFlags
    'Public Property SLFTypeOfElipsis As TextFormatFlags
    '    Get
    '        Return _varTypeOfElipsis
    '    End Get
    '    Set(value As TextFormatFlags)
    '        _varTypeOfElipsis = value
    '    End Set
    'End Property

    Private Sub lbl_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

    End Sub


End Class
