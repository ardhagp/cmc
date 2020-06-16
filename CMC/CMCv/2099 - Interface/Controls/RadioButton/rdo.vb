Imports System.ComponentModel

Public Class rdo
    Inherits System.Windows.Forms.RadioButton

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontLbl
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.DoubleBuffered = True
    End Sub
End Class
