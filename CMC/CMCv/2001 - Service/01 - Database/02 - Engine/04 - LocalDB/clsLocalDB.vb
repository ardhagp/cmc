Imports System.Windows.Forms

Namespace Database.Engine
    Public Class LocalDB
        Private _CS(2) As String
        Private _FilePath(2) As String

        Private _CONN(2) As SqlClient.SqlConnection
        Private _CMD(2) As SqlClient.SqlCommand
        Private _DR(2) As SqlClient.SqlDataReader

        Private _LocalDB As New Connect.LocalDBConnection

        Public Function CheckDBCatalog() As Boolean
            Try
                Dim _DBPath As String = Nothing
                Dim _DBExists(3) As Boolean

                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Resources")

                _DBPath = Application.StartupPath & "\Resources\CATALOG.mdf"
                If _CFILEInfo.IsExists(_DBPath) Then
                    _DBExists(1) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.catalog, True)
                    _DBExists(1) = False
                End If

                _DBPath = Application.StartupPath & "\Resources\DEV_CATALOG.mdf"
                If _CFILEInfo.IsExists(_DBPath) Then
                    _DBExists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.dev_catalog, True)
                    _DBExists(2) = False
                End If

                _DBPath = Application.StartupPath & "\Resources\ERRLOG.mdf"
                If _CFILEInfo.IsExists(_DBPath) Then
                    _DBExists(3) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.errlog, True)
                    _DBExists(3) = False
                End If

                If (_DBExists(1) = True And _DBExists(3) = True) Or (_DBExists(2) = True And _DBExists(3) = True) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                If CheckDBCatalog() = False Then
                    Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration not found", 0, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Exit Sub
                End If

                If IsProductionMode = True Then
                    _FilePath(0) = Application.StartupPath & "\Resources\CATALOG.mdf"
                Else
                    _FilePath(0) = Application.StartupPath & "\Resources\DEV_CATALOG.mdf"
                End If

                Dim _FileInfo As New OperatingSystem.File.Info

                If _FileInfo.IsExists(_FilePath(0)) Then
                    _CS(0) = _LocalDB.LocalDB_InitialCatalog(_FilePath(0))

                    _CONN(1) = New SqlClient.SqlConnection(_CS(0)) 'OleDb.OleDbConnection(_CS(0))
                    _CONN(1).Open()
                    'Else
                    '    GoTo FileNotFound
                End If

                _FilePath(1) = Application.StartupPath & "\Resources\ERRLOG.mdf"

                If _FileInfo.IsExists(_FilePath(1)) Then
                    _CS(1) = _LocalDB.LocalDB_InitialCatalog(_FilePath(1))

                    _CONN(2) = New SqlClient.SqlConnection(_CS(1))
                    _CONN(2).Open()
                    'Else
                    '    GoTo FileNotFound
                End If
                'FileNotFound:
                '                MsgBox("One of your components has been missing", MsgBoxStyle.OkOnly, "Ingrid Supporting App")
                'Application.Exit()
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                _DR(1) = GETDATAROW("SELECT LIST.DATABASENAME, LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.SERVERPORT FROM LIST WHERE LIST.DEFAULTCONNECTION =1;", _CONN(1), _CMD(0))

                Fields.DatabaseName = _DR(1).GetString(0)
                Fields.ServerAddress = _DR(1).GetString(1)
                Fields.Username = _DR(1).GetString(2)
                Fields.Password = _SECDecrypt.Rijndael(_DR(1).GetString(3))
                Fields.Port = _DR(1).GetValue(4)

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Try
                Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');", _CONN(1), _CMD(1))
            Catch ex As Exception
                PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        Private Function GETDATAROW(ByVal Query As String, ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand) As SqlClient.SqlDataReader
            Try
                MyCommand = New SqlClient.SqlCommand
                MyCommand.Connection = MyConnection
                MyCommand.CommandType = CommandType.Text
                MyCommand.CommandText = Query

                'MyCommand = New SqlClient.SqlCommand(Query, MyConnection)
                _DR(0) = MyCommand.ExecuteReader

                If _DR(0).HasRows Then
                    _DR(0).Read()
                End If

                Return _DR(0)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        Public Sub GETDATATABLE(ByVal DBR As Adapter.LocalDB.Display.Request, ByVal TableName As String)

            Dim _DA(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim _DS As New DataSet
                Dim _BS As New BindingSource

                If (_CMD(1) Is Nothing) Then 'Or (_CMD = Nothing) Then
                    _CMD(1) = New SqlClient.SqlCommand
                End If

                _CMD(1).Connection = _CONN(1)
                _CMD(1).CommandType = CommandType.Text
                _CMD(1).CommandTimeout = 30

                'DBR.Query = "USE " & _FilePath(0) & " " & DBR.Query

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

        Private Sub PUSHDATA(ByVal Query As String, ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand)
            Try
                MyCommand = New SqlClient.SqlCommand
                MyCommand.Connection = MyConnection
                MyCommand.CommandType = CommandType.Text
                MyCommand.CommandText = Query
                MyCommand.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub Close()
            _CONN(1).Close()
            _CONN(2).Close()
            _CONN(1).Dispose()
            _CONN(2).Dispose()
        End Sub
    End Class
End Namespace
