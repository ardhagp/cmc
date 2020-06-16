Namespace Catcher.Error
    Public Structure Fields
        Public Property Type As TypeOfFaulties
        Public Property Message As String
        Public Property Number As String
        Public Property AppVersion As String
        Public Property EnableErrorReporting As Boolean
        Public Property SaveError As Boolean
        Public Property ResumeNext As Boolean
        Public Property InternalStackTrace As String

        Public Enum TypeOfFaulties
            SupportServiceDatabaseEngine = 20010102
            SupportServiceSOAP = 200102
            SupportServiceWeb = 200103
            ApplicationRunTime = 100100
        End Enum
    End Structure
End Namespace