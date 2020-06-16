Imports System.ComponentModel

''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom combobox
''' </summary>
Public Class cbo
    Inherits System.Windows.Forms.ComboBox

    Public Sub New()
        InitializeComponent()
        MyBase.Font = globalFontLbl
        MyBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.DoubleBuffered = True
    End Sub
End Class
