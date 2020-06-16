Imports System.ComponentModel

''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom checkbox
''' </summary>
Public Class chk
    Inherits System.Windows.Forms.CheckBox

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontLbl
        MyBase.BackColor = Drawing.Color.Transparent
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.DoubleBuffered = True
    End Sub

End Class
