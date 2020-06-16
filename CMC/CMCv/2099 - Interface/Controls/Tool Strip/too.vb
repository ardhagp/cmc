Imports System.ComponentModel

'System.Design.dll required
<Designer(GetType(System.Windows.Forms.Design.ControlDesigner))> _
Public Class too
    Inherits System.Windows.Forms.ToolStrip

    Private Sub New()
        InitializeComponent()
        MyBase.DoubleBuffered = True
    End Sub
End Class
