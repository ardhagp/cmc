Imports CMCv


Public Class frmErrorReporting
    'Private Catcher As New Catcher.Error.Fields
    Public ResumeNext As Boolean

    Private ERL As New Database.Engine.LocalDB

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal ErrorCatcher As Catcher.Error.Fields, Optional ByVal DBEngine As Database.Engine.LocalDB = Nothing)
        InitializeComponent()
        TxtErrorType.Text = TypeOfFaultiesConverter(ErrorCatcher)
        TxtErrorMessage.Text = ErrorCatcher.Message
        TxtErrorNumber.Text = ErrorCatcher.Number
        TxtAppBuild.Text = ErrorCatcher.AppVersion
        ChkErrorReporting.Enabled = ErrorCatcher.EnableErrorReporting
        ResumeNext = ErrorCatcher.ResumeNext
        If ErrorCatcher.SaveError = True Then
            If Not DBEngine Is Nothing Then
                ERL = DBEngine
                ERL.Open()
                ERL.SaveErrorData(ErrorCatcher)
            End If
        End If


        'Tbctl1.TabPages.RemoveByKey("tp_SystemInformation")

    End Sub

    Private Function TypeOfFaultiesConverter(ByVal ErrorCatcher As Catcher.Error.Fields) As String
        Dim Result As String = ""
        Select Case ErrorCatcher.Type
            Case 20010102
                Result = "SupportServiceDatabaseEngine"
            Case 200102
                Result = "SupportServiceSOAP"
            Case 200103
                Result = "SupportServiceWeb"
            Case 100100
                Result = "ApplicationRunTime"
        End Select

        Return Result
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        Me.Dispose()
        If ResumeNext = False Then

        End If
    End Sub
End Class
