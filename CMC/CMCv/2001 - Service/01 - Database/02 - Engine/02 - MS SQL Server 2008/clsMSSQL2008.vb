Imports System.Windows.Forms

Namespace Database.Engine
    Public Class MSSQL2008
        Private _CS(1) As String
        Private _FilePath(1) As String

        Private _CONN(1) As SqlClient.SqlConnection
        Private _CMD(1) As SqlClient.SqlCommand
        Private _Adapter As SqlClient.SqlDataAdapter

        Private _MSSQL2008 As New Connect.MSSQLServer2008Connection

        Public Enum DatabaseID
            DbDefault
            DbCustom
        End Enum

        Public Function Open(ByVal Fields As Properties.Fields, Optional ByVal Splash As Form = Nothing) As Boolean
            Dim _Success As Boolean = False
            Try
                _CONN(1) = New SqlClient.SqlConnection(_MSSQL2008.MS_SQL2008_Standard(Fields.ServerAddress, Fields.DatabaseName, Fields.Username, Fields.Password))
                _CONN(1).Open()
                _Success = True
                'Catch ex As Exception
                '    If Splash IsNot Nothing Then
                '        Splash.Close()
                '    End If
                '    _Success = False
                '    Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
                '    Call PUSHERRORDATASHOW()
            Catch ex As SqlClient.SqlException
                If Splash IsNot Nothing Then
                    Splash.Close()
                End If
                _Success = False
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, True, True)
                Call PUSHERRORDATASHOW()
            End Try
            Return _Success
        End Function

        Public Function GETDATAROW(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp") As SqlClient.SqlDataReader ', ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand) As SqlClient.SqlDataReader
            Dim _DR(1) As SqlClient.SqlDataReader

            Try
                '_CMD(2).Connection = _CONN(1)
                '_CMD(2).CommandType = CommandType.Text
                '_CMD(2).CommandText = Query 

                Dim _CMD_0 As New SqlClient.SqlCommand

                Query = "USE " & DatabaseName & " " & Query

                _CMD_0 = New SqlClient.SqlCommand(Query, _CONN(1))
                _DR(1) = _CMD_0.ExecuteReader(CommandBehavior.CloseConnection)

                If _DR(1).HasRows Then
                    _DR(1).Read()
                End If

                Return _DR(1)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Function GETVALUE(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp") As Object
            Try
                Dim _ROWValue As Object

                _CMD(1) = New SqlClient.SqlCommand
                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text
                _CMD(1).CommandTimeout = 30

                Query = "USE " & DatabaseName & " " & Query

                _CMD(1).CommandText = Query

                _ROWValue = _CMD(1).ExecuteScalar

                Return _ROWValue
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Function GETDATASET(ByVal DBR As Adapter.MSSQL2008.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp") As DataSet
            Dim _DA(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim _DS As New DataSet
                Dim _BS As New BindingSource

                If IsNothing(_CMD(1)) Then
                    _CMD(1) = New SqlClient.SqlCommand
                End If

                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text
                _CMD(1).CommandTimeout = 30

                DBR.Query = "USE " & DatabaseName & " " & DBR.Query

                _CMD(1).CommandText = DBR.Query

                _DA(1) = New SqlClient.SqlDataAdapter(_CMD(1))
                _DA(1).Fill(_DS, TableName)

                _BS = New BindingSource(_DS, TableName)

                Return _DS
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Sub GETDATATABLE(ByVal DBR As Adapter.MSSQL2008.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp")

            Dim _DA(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim _DS As New DataSet
                Dim _BS As New BindingSource

                If (_CMD(1) Is Nothing) Then
                    _CMD(1) = New SqlClient.SqlCommand
                End If

                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text
                _CMD(1).CommandTimeout = 30

                DBR.Query = "USE " & DatabaseName & " " & DBR.Query

                _CMD(1).CommandText = DBR.Query

                _DA(1) = New SqlClient.SqlDataAdapter(_CMD(1))
                _DA(1).Fill(_DS, TableName)

                _BS = New BindingSource(_DS, TableName)
                If (DBR.DataGrid Is Nothing) = False Then
                    DBR.DataGrid.DataSource = _BS
                End If
                If (DBR.Dropdown Is Nothing) = False Then
                    DBR.Dropdown.DataSource = _BS
                End If
                If (DBR.StatusBar Is Nothing) = False Then
                    If Not DBR.StatusBar.Items.Count = 0 Then
                        DBR.StatusBar.Items(0).Text = _BS.Count & " Row(s)"
                    End If
                End If
                If (DBR.Chart Is Nothing) = False Then
                    DBR.Chart.DataSource = _BS
                End If

            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub PUSHDATA(ByVal Query As String, Optional ByVal DatabaseName As String = "db_universe_erp")
            Try
                _CMD(1) = New SqlClient.SqlCommand
                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text

                Query = "USE " & DatabaseName & " " & Query

                _CMD(1).CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)
                _CMD(1).ExecuteNonQuery()
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "0", ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Function PUSHIMAGE(ByVal CMD As SqlClient.SqlCommand) As Boolean
            Dim _Success As Boolean = False

            Try
                _CMD(1) = New SqlClient.SqlCommand

                If CMD IsNot Nothing Then
                    _CMD(1) = CMD
                End If

                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text

                _CMD(1).ExecuteNonQuery()

                _Success = True
            Catch ex As Exception
                _Success = False
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try

            Return _Success
        End Function

        Public Function FILLDATASET(ByVal Query As String, ByVal DataSetName As DataSet, ByVal TableName As String, Optional ByVal DatabaseName As String = "db_universe_erp") As DataSet
            GC.Collect()

            Try
                _CMD(1) = New SqlClient.SqlCommand
                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text

                Query = "USE " & DatabaseName & " " & Query

                _CMD(1).CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)
                _Adapter = New SqlClient.SqlDataAdapter(_CMD(1))
                _Adapter.Fill(DataSetName, TableName)

            Catch ex As Exception
                DataSetName = Nothing

                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, False, False)
            End Try

            Return DataSetName
        End Function

        Public Sub Close()
            _CONN(1).Close()
            '_CONN(2).Close()
            _CONN(1).Dispose()
            '_CONN(2).Dispose()
        End Sub
    End Class

End Namespace
