'-------------------------------------------------------------------------------------------------------------
' module:			TX Text Control Words
' file:         DragDropHandler.vb
' description:	This file contains a class handling file drag & drop operations.
'
' copyright:		© Text Control GmbH, 1991-2013
' author:			T. Kummerow
'-----------------------------------------------------------------------------------------------------------

Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows


Public Enum ImageType
    UNKNOWN

    bmp
    jpg
    gif
    tif
    png
    emf
    wmf
End Enum

''' <summary>
''' Handles file drag &amp; drop operations.
''' </summary>
Class FileDragDropHandler
#Region "  Enumerations  "

    Public Enum DraggedFileType
        UNKNOWN
        Document
        Image
    End Enum

#End Region

#Region "  Class Properties  "

    ''' <summary>
    ''' Dragged / dropped file type. (Image, document etc.)
    ''' </summary>
    Public Property FileType() As DraggedFileType
        Get
            Return m_FileType
        End Get
        Private Set(ByVal value As DraggedFileType)
            m_FileType = value
        End Set
    End Property
    Private m_FileType As DraggedFileType

    ''' <summary>
    ''' Dragged image type.
    ''' </summary>
    Public Property ImageType() As ImageType
        Get
            Return m_ImageType
        End Get
        Private Set(ByVal value As ImageType)
            m_ImageType = value
        End Set
    End Property
    Private m_ImageType As ImageType

    ' Gets the name of the file handled through this drag&drop handler:
    Public Property FileName() As String
        Get
            Return m_FileName
        End Get
        Private Set(ByVal value As String)
            m_FileName = value
        End Set
    End Property
    Private m_FileName As String

    ' Gets the TXTextControl Streamtype of the file handled through this drag&drop handler:
    Public Property StreamType() As TXTextControl.StreamType
        Get
            Return m_StreamType
        End Get
        Private Set(ByVal value As TXTextControl.StreamType)
            m_StreamType = value
        End Set
    End Property
    Private m_StreamType As TXTextControl.StreamType

    ' Gets a value indicating whether something can be dropped:
    Public Property CanDrop() As Boolean
        Get
            Return m_CanDrop
        End Get
        Private Set(ByVal value As Boolean)
            m_CanDrop = value
        End Set
    End Property
    Private m_CanDrop As Boolean

#End Region

#Region "  Methods  "

    ' Resets the internal state of the drag & drop handler:
    Public Sub Reset()
        FileName = String.Empty
        StreamType = 0
        CanDrop = False
        FileType = DraggedFileType.UNKNOWN
        ImageType = ImageType.UNKNOWN
    End Sub

    Public Sub CheckDraggedFiles(ByVal fileList As String())
        Reset()

        If fileList IsNot Nothing Then
            ' Get first parameter from the list and check if it is a supported file type
            FileName = fileList(0)

            Select Case Path.GetExtension(FileName).ToLower()
                Case ".rtf"
                    FileType = DraggedFileType.Document
                    StreamType = TXTextControl.StreamType.RichTextFormat
                    Exit Select

                Case ".htm", ".html"
                    FileType = DraggedFileType.Document
                    StreamType = TXTextControl.StreamType.HTMLFormat
                    Exit Select
                Case Else

                    FileType = DraggedFileType.UNKNOWN
                    ImageType = ImageType.UNKNOWN
                    FileName = [String].Empty
                    Exit Select
            End Select

            If FileType <> DraggedFileType.UNKNOWN Then
                CanDrop = True
            End If
        End If
    End Sub

    ' Calculates a drag&drop effect depending on the allowed effects:
    Public Function GetDragDropEffect(ByVal allowedEffects As DragDropEffects) As DragDropEffects
        If (allowedEffects And DragDropEffects.Copy) = DragDropEffects.Copy Then
            Return DragDropEffects.Copy
        ElseIf (allowedEffects And DragDropEffects.Move) = DragDropEffects.Move Then
            Return DragDropEffects.Move
        Else
            Return DragDropEffects.None
        End If
    End Function

#End Region
End Class
