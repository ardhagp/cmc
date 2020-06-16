Public Class frmDialogBox

#Region "Initialize"
    ''' <summary>
    ''' Custom Message Box
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Custom Message Box
    ''' </summary>
    ''' <param name="Message">Tuliskan pesan anda di sini</param>
    ''' <param name="Caption">Judul Form dan Caption</param>
    ''' <param name="MessageIcon">Jenis icon yang akan digunakan</param>
    ''' <param name="ButtonType">Tipe tombol yang akan digunakan</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Message As String, ByVal Caption As String, ByVal MessageIcon As MessageIcon, ByVal ButtonType As MessageTypes)

        ' This call is required by the designer.
        InitializeComponent()

        ' Event triggered by Message Icon.
        Select Case MessageIcon
            Case frmDialogBox.MessageIcon.Alert
                Me.SLFLogo.Image = My.Resources.Alert_001_90_FFFFFFFF_
                Me.SLFLogo.BackColor = System.Drawing.Color.Orange
                If Caption = String.Empty Then
                    Me.Text = "Alert"
                    SLFNamaForm.Text = "Alert"
                End If
            Case frmDialogBox.MessageIcon.Error
                Me.SLFLogo.Image = My.Resources.Error_002_90_FFFFFFFF_
                Me.SLFLogo.BackColor = System.Drawing.Color.Red
                If Caption = String.Empty Then
                    Me.Text = "Error"
                    SLFNamaForm.Text = "Error"
                End If
            Case frmDialogBox.MessageIcon.Information
                Me.SLFLogo.Image = My.Resources.Information_001_90_FFFFFFFF_
                Me.SLFLogo.BackColor = System.Drawing.Color.SteelBlue
                If Caption = String.Empty Then
                    Me.Text = "Information"
                    SLFNamaForm.Text = "Information"
                End If
            Case frmDialogBox.MessageIcon.Question
                Me.SLFLogo.Image = My.Resources.Question_001_90_FFFFFFFF_
                Me.SLFLogo.BackColor = System.Drawing.Color.DodgerBlue
                If Caption = String.Empty Then
                    Me.Text = "Question"
                    SLFNamaForm.Text = "Question"
                End If

        End Select

        ' Event triggered by Caption
        If Not Caption = String.Empty Then
            Me.Text = Caption.Trim
            SLFNamaForm.Text = Caption.Trim
        End If

        SLFSubNamaForm.Text = String.Empty

        ' Event triggered by Button type.
        Select Case ButtonType
            Case 1
                PnlBottomButton.Visible = False
                PnlBottomButtonYesNo.Visible = True
                PnlBottomButtonOkOnly.Visible = False
            Case 2
                PnlBottomButton.Visible = True
                PnlBottomButtonYesNo.Visible = False
                PnlBottomButtonOkOnly.Visible = False
            Case 3
                PnlBottomButton.Visible = False
                PnlBottomButtonYesNo.Visible = False
                PnlBottomButtonOkOnly.Visible = True
        End Select

        TxtMessage.Text = Message

    End Sub
#End Region

#Region "Variables"
    Public Enum MessageTypes
        YesNo = 1
        OkCancel = 2
        OkOnly = 3
    End Enum

    Public Enum MessageIcon
        Question = 1
        Alert = 2
        [Error] = 3
        Information = 4
    End Enum
#End Region

#Region "Component Events"
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnOkOnly_Click(sender As Object, e As EventArgs) Handles BtnOkOnly.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

#End Region

    Private Sub frmDialogBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtMessage_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
