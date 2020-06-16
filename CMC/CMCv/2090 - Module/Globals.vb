Module Globals
#Region "Font Globals"
    Public globalFontBtn As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
    Public globalFontTxt As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    Public globalFontLbl As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    Public globalFontDgn As New System.Drawing.Font("Verdana", 8, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
#End Region

#Region "Security Globals"
    Public Const _KEY As String = "bJF85;j1c?kW 99.W1Oln!?Wd d@4LERSYY$#f>v!/ >ALj}uRW^ZkKj}T0%`@(/"
    Public _SECEncrypt As New Security.Encrypt
    Public _SECDecrypt As New Security.Decrypt
#End Region

#Region "Class Globals"
    Public CBS As New ControlCodeBase
    Public _CFILEInfo As New OperatingSystem.File.Info

#End Region

#Region "Variabel Global"
    Public _randomcolor As New Random
    Public _varAutoTrim As Boolean
    Public _varHarusDiisi As Boolean

    Public SEC As New Security.Engine

    Public ERC As New frmErrorReporting
    Public ERL As New Database.Engine.LocalDB
    Public ErrorCatcher As New Catcher.Error.Fields

    Public _APPVer As String
#End Region

    Public Function GETAPPVERSION() As String
        _APPVer = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
        Return _APPVer
    End Function

    Public Function CREATESECURITY(ByVal IsEncrypt As Boolean, ByVal Message As String)
        Try
            SEC = New Security.Engine
            Dim SECAlgorithm As Security.Engine.Algorithm = Security.Engine.Algorithm.Rijndael
            Security.Engine.EncryptionAlgorithm = SECAlgorithm
            Security.Engine.Key = ""

            If IsEncrypt = True Then
                If Security.Engine.EncryptString(Message) Then
                    Message = Security.Engine.Content
                Else
                    Message = Security.Engine.CryptoException.Message
                End If
            Else
                Security.Engine.Content = Message
                If Security.Engine.DecryptString Then
                    Message = Security.Engine.Content
                Else
                    Message = Security.Engine.CryptoException.Message
                End If
            End If

            Return Message
        Catch ex As Exception
            Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
            PUSHERRORDATASHOW()
            Return Nothing
        End Try
    End Function

    Public Sub GETMACHINENAME()

    End Sub

    Public Sub PUSHERRORDATA(ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With ErrorCatcher
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
        End With
    End Sub

    Public Sub PUSHERRORDATASHOW()
        ERC = New frmErrorReporting(ErrorCatcher, )
        ERC.SLFNamaForm.Text = "Lady Bug (Error Catcher)"
        ERC.SLFSubNamaForm.Text = "Please check detail below and report to system administrator."
        ERC.ShowDialog()
        If ERC.ResumeNext = False Then
            Process.GetCurrentProcess.Kill()
        End If
        ERC.Dispose()
    End Sub
End Module
