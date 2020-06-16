Namespace Database.Adapter.MSSQL2008.Display
    Public Structure Request
        Public Property Query As String
        Public Property DataGrid As dgn
        Public Property StatusBar As stt
        Public Property Dropdown As cbo
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    End Structure
End Namespace

Namespace Database.Adapter.MSSQL2008
    Public Structure Execute
        Public Property Query As String
    End Structure
End Namespace
