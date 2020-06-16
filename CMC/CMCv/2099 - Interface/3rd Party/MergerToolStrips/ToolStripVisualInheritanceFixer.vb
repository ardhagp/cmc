
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

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms

Namespace VisualInheritanceFixer

    ''' <summary>
    ''' This component allows you to modify a base forms ToolStrip by merging a (hidden) tool strip on the sub-form. 
    ''' It is a work-around for Microsoft's intentionally added limitation (as they could not figure out this simple work-around).
    ''' </summary>
    Public Class ToolStripVisualInheritanceFixer
        Inherits Component
        Private _toolStrip As ToolStrip
        Private _inheritedToolStrip As ToolStrip
        Private _visibilityChangedHandler As EventHandler
        Private _layoutHandler As LayoutEventHandler
        Private Const ClonedTag As String = "__$$Cloned"

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Private Sub New(container As IContainer)
            If container IsNot Nothing Then
                container.Add(Me)
            End If
            _toolStrip = Nothing
            _inheritedToolStrip = Nothing
            _visibilityChangedHandler = New EventHandler(AddressOf _toolStrip_VisibleChanged)
            _layoutHandler = New LayoutEventHandler(AddressOf _toolStrip_Layout)
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' The base form's tool strip. Set base forms ToolStrip's modifer to 'protected' if you cannot see find it here
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        <Description("The base form's tool strip. If you can't find it, make sure the base forms ToolStrip has it's modifer to 'protected' (or greater)")> _
        <Category("Behavior")> _
        Public Property InheritedToolStrip() As ToolStrip
            Get
                Return _inheritedToolStrip
            End Get
            Set(value As ToolStrip)
                _inheritedToolStrip = value
            End Set
        End Property

        ''' <summary>
        ''' The tool strip on this form to be merged with the inherited tool strip.
        ''' </summary>
        <Description("The tool strip on this form to be merged with the inherited tool strip")> _
        <Category("Behavior")> _
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)> _
        Public Property ToolStrip() As ToolStrip
            Get
                Return _toolStrip
            End Get
            Set(value As ToolStrip)
                If _toolStrip IsNot Nothing Then
                    '_toolStrip.VisibleChanged -= _visibilityChangedHandler
                    '_toolStrip.Layout -= _layoutHandler
                    _toolStrip.Visible = True
                End If
                _toolStrip = value
                If _toolStrip IsNot Nothing Then
                    '_toolStrip.VisibleChanged += _visibilityChangedHandler
                    '_toolStrip.Layout += _layoutHandler
                    _toolStrip.Visible = False
                End If
            End Set
        End Property

        Private ReadOnly Property CanMerge() As Boolean
            Get
                Return ToolStrip IsNot Nothing AndAlso InheritedToolStrip IsNot Nothing
            End Get
        End Property

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' At runtime this merges ToolStrip with InheritedToolStrip. At design-time, only a clone of ToolStrip is merged (to prefect designer serialization problems)
        ''' </summary>
        Private Sub MergeWithInheritedToolStrip()
            Dim sourceMenuStrip As ToolStrip
            If Not IsDesignMode() Then
                sourceMenuStrip = ToolStrip
            Else
                Dim lastMergedItems As New List(Of ToolStripItem)()
                For Each item As ToolStripItem In InheritedToolStrip.Items
                    If TypeOf item.Tag Is String AndAlso DirectCast(item.Tag, String) = ClonedTag Then
                        lastMergedItems.Add(item)
                    End If
                Next
                For Each item As ToolStripItem In lastMergedItems
                    InheritedToolStrip.Items.Remove(item)
                Next
                sourceMenuStrip = BasicClone(ToolStrip)
            End If

            ' .NET already provided the functionality to merge tool strips, so we just use that!
            ToolStripManager.Merge(sourceMenuStrip, InheritedToolStrip)
        End Sub

        ''' <summary>
        ''' This just clones a toolstrip and it's items. It is written for our purposes here. For general 
        ''' use setting of its state should be done similar to the below method.
        ''' </summary>
        ''' <param name="original">ToolStrip be be cloned</param>
        ''' <returns>The cloned ToolStrip</returns>
        Private Shared Function BasicClone(original As ToolStrip) As ToolStrip
            Dim clone__1 As New ToolStrip()
            For Each item As ToolStripItem In original.Items
                Dim clonedItem As ToolStripItem = Clone(item)
                If clonedItem IsNot Nothing Then
                    clone__1.Items.Add(clonedItem)
                End If
            Next
            Return clone__1
        End Function

        ''' <summary>
        ''' Clones a ToolStripItem using reflection.
        ''' </summary>
        ''' <param name="original">The original item to be cloned.</param>
        ''' <returns>Cloned tool strip item (or null if original has no default constructor)</returns>
        Private Shared Function Clone(original As ToolStripItem) As ToolStripItem
            Dim clone__1 As ToolStripItem = Nothing
            If TypeOf original Is ICloneable Then
                clone__1 = DirectCast(DirectCast(original, ICloneable).Clone(), ToolStripItem)
            Else
                If original.[GetType]().GetConstructor(New Type(-1) {}) IsNot Nothing Then
                    clone__1 = DirectCast(Activator.CreateInstance(original.[GetType]()), ToolStripItem)
                    Dim fis As FieldInfo() = original.[GetType]().GetFields(BindingFlags.FlattenHierarchy Or BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic)
                    For Each fi As FieldInfo In fis
                        Dim fieldValue As Object = fi.GetValue(original)
                        If fi.FieldType.[Namespace] <> original.[GetType]().[Namespace] Then
                            fi.SetValue(clone__1, fieldValue)
                        End If
                    Next
                    Dim pis As PropertyInfo() = original.[GetType]().GetProperties(BindingFlags.FlattenHierarchy Or BindingFlags.Instance Or BindingFlags.[Public] Or BindingFlags.NonPublic)
                    For Each pi As PropertyInfo In pis
                        If pi.Name = "Owner" OrElse pi.Name = "OwnerItem" Then
                            ' We ignore these properties as they cause problems
                            Continue For
                        End If
                        If pi.CanWrite Then
                            pi.SetValue(clone__1, pi.GetValue(original, Nothing), Nothing)
                        End If
                    Next
                    clone__1.Tag = ClonedTag
                    clone__1.Visible = True
                End If
            End If
            Return clone__1
        End Function

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                'enabling code above can cause system error
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
            'enabling code above can cause system error
        End Sub

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub


        Private Function IsDesignMode() As Boolean
            ' .NET framework doesn't provide proper support for design mode checking, so we do it here manually
            Return System.Diagnostics.Process.GetCurrentProcess().ProcessName = "devenv"
        End Function

#Region "Handlers"

        Private Sub _toolStrip_Layout(sender As Object, e As LayoutEventArgs)
            If Not IsDesignMode() AndAlso CanMerge Then
                MergeWithInheritedToolStrip()
            End If
        End Sub

        Private Sub _toolStrip_VisibleChanged(sender As Object, e As EventArgs)
            If InheritedToolStrip IsNot Nothing AndAlso IsDesignMode() AndAlso Not ToolStrip.Visible AndAlso CanMerge Then
                MergeWithInheritedToolStrip()
            End If
        End Sub

#End Region

        Private Sub ToolStripVisualInheritanceFixer_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

        End Sub
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
