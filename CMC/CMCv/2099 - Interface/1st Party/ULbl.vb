Imports System.Windows.Forms

Public Class ULbl
    Private iLoop As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MyBase.DoubleBuffered = True
        Me.UText.Height = Me.Height
        Me.SLFTextAdjuster = False
        Me.SLFText = "Text"
        Me.SLFTextBorder = False
        Me.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
    End Sub

    Private _varText As String
    <System.ComponentModel.Description("This text will show on label
"), System.ComponentModel.Editor(GetType(System.ComponentModel.Design.MultilineStringEditor), GetType(System.Drawing.Design.UITypeEditor))>
    Public Property SLFText As String
        Get
            Return _varText
        End Get
        Set(value As String)
            _varText = value
            Call GantiText(value)
        End Set
    End Property

    Private Sub GantiText(ByVal _value As String)
        UText.Text = _value
    End Sub

    Private _varTextBorder As Boolean
    <System.ComponentModel.Description("This show text border
")>
    Public Property SLFTextBorder As Boolean
        Get
            Return _varTextBorder
        End Get
        Set(value As Boolean)
            _varTextBorder = value
            Call GantiTextBorder(value)
        End Set
    End Property

    Private Sub GantiTextBorder(ByVal _value As Boolean)
        If _value = True Then
            UText.BorderStyle = BorderStyle.FixedSingle
        Else
            UText.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private _varReadjustText As Boolean
    <System.ComponentModel.Description("Enable this to readjust text
")>
    Public Property SLFTextAdjuster As Boolean
        Get
            Return _varReadjustText
        End Get
        Set(value As Boolean)
            _varReadjustText = value
            Call ReadjustText(value)
        End Set
    End Property

    Private Sub ReadjustText(ByVal _value As Boolean)
        If _value = True Then
            tmr_.Enabled = True
        Else
            tmr_.Enabled = False
        End If
    End Sub

    Private _varWarnaLabel As ControlCodeBase.enuJenisLabel
    <System.ComponentModel.Description("Color options")>
    Public Property SLFWarnaLabel() As ControlCodeBase.enuJenisLabel
        Get
            Return _varWarnaLabel
        End Get
        Set(value As ControlCodeBase.enuJenisLabel)
            _varWarnaLabel = value
            GantiWarnaLabel(value)
        End Set
    End Property

    Private Sub GantiWarnaLabel(ByVal _valEnuJenisTombol As ControlCodeBase.enuJenisLabel)
        Select Case _valEnuJenisTombol
            Case ControlCodeBase.enuJenisLabel.Green
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                UHead.BackColor = Drawing.Color.LimeGreen
                MyBase.BackColor = Drawing.Color.MintCream
            Case ControlCodeBase.enuJenisLabel.Red
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                UHead.BackColor = Drawing.Color.Red
                MyBase.BackColor = Drawing.Color.MistyRose
            Case ControlCodeBase.enuJenisLabel.Default
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                UHead.BackColor = Drawing.Color.RoyalBlue
                MyBase.BackColor = Drawing.Color.AliceBlue
            Case ControlCodeBase.enuJenisLabel.Yellow
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                UHead.BackColor = Drawing.Color.DarkOrange
                MyBase.BackColor = Drawing.Color.Moccasin
            Case ControlCodeBase.enuJenisLabel.Grey
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                UHead.BackColor = Drawing.Color.DarkGray
                MyBase.BackColor = Drawing.Color.WhiteSmoke
            Case ControlCodeBase.enuJenisLabel.Custom
                UText.ForeColor = Drawing.Color.Black
                UText.BackColor = Drawing.Color.Transparent
                'UHead.BackColor = System.Drawing.Color.Orange
                'MyBase.BackColor = Drawing.Color.Black
        End Select
    End Sub

    Private Sub ULbl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        UText.Height = Me.Height
    End Sub

    Private Sub tmr__Tick(sender As Object, e As EventArgs) Handles tmr_.Tick
        If iLoop < 10 Then
            UText.Height = Me.Height
            tmr_.Enabled = False
            iLoop = 0
        Else
            tmr_.Enabled = False
            iLoop = 0
        End If
    End Sub
End Class
