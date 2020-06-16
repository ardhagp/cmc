
' Copyright 2012 Herman Schoenfeld, Sphere 10 Software
'
' Licensed under the Apache License, Version 2.0 (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.

Imports System.ComponentModel
Imports System.Windows.Forms

Namespace VisualInheritanceFixer

    ''' <summary>
    ''' This component allows you to modify a base forms ToolStrip. 
    ''' Microsoft has intentionally added this limitation due to the complexities it could not overcome. This component simply works around
    ''' those limitations by allowing you to merge a (hidden) tool strip on the sub form with the readonly inherited base form.
    ''' </summary>
    Public Class MTS
        Inherits ToolStrip
        'Private _fixer As ToolStripVisualInheritanceFixer 'original
        Private _fixer As New ToolStripVisualInheritanceFixer

        Public Sub New()
            '_fixer = New ToolStripVisualInheritanceFixer 'original
            MyBase.New() 'mycode
            _fixer.ToolStrip = Me
        End Sub

        Protected Overrides Sub InitLayout()
            MyBase.InitLayout()
            Visible = False
        End Sub


        ''' <summary>
        ''' The base form's menu strip.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        <Description("Set this to the base forms ToolStrip. If you can't find it, make sure it's modifer is set to to 'protected' or greater.")> _
        <Category("Behavior")> _
        Public Property InheritedToolStrip() As ToolStrip
            Get
                Return TryCast(_fixer.InheritedToolStrip, ToolStrip)
            End Get
            Set(value As ToolStrip)
                _fixer.InheritedToolStrip = TryCast(value, ToolStrip)
            End Set
        End Property

    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
