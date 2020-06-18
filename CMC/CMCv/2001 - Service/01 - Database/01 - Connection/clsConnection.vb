Imports CMCv.Database.Provider

Namespace Database.Connect
    ''' <summary>
    ''' Database connection string untuk berbagai provider
    ''' </summary>
    ''' <remarks></remarks>
    Friend Interface IMSAccess2003Connections
#Region "OLEDB"
        ''' <summary>
        ''' Koneksi database Access 2003 menggunakan OLEDB
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoft_OLEDB_Standard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String)
#End Region

#Region "ODBC"
        ''' <summary>
        ''' Koneksi database Access 2003 Standard
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoft_ODBC_Standard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String)
#End Region
    End Interface

    Friend Interface IMSSQLServer2008Connections
#Region ".NET Standard"

        ''' <summary>
        ''' Koneksi SQL Server 2008 Standard
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MS_SQL2008_Standard(ByVal ServerAddress As String, ByVal DatabaseName As String, ByVal Username As String, ByVal Password As String)

        ''' <summary>
        ''' Koneksi SQL Server 2008 Trusted Connection
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MS_SQL2008_TrustedConnection(ByVal ServerAddress As String, ByVal DatabaseName As String)
#End Region
    End Interface

    Friend Interface IMySQLConnections
#Region "ODBC51"
        ''' <summary>
        ''' Konksi database ODBC51 Standard
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <param name="Database">Database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_ODBC51_Standard(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET InactivatingPreparedStatement"

        ''' <summary>
        ''' Koneksi database MySQL .NET Inactivating Prepared Statement
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <param name="Database">Database</param>
        ''' <param name="IgnorePrepare">Ignore Prepare</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_InactivatingPreparedStatement(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal IgnorePrepare As Options.IgnorePrepare) As String
#End Region

#Region ".NET NamedPipes"

        ''' <summary>
        ''' Koneksi database MySQL .NET Named Pipes
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Passoword</param>
        ''' <param name="Database">Database</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MySQL_NET_NamedPipes(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String)
#End Region

#Region ".NET NetworkProtocol"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress">IP or Hostname</param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Protocol"></param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function MySQL_NET_NetworkProtocol(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Protocol As Options.Protocol) As String
#End Region

#Region ".NET Standard"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_Standard(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET SpcifyingCharacterSet"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="CharSet"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_SpecifyingCharacterSet(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal CharSet As Options.CharSet) As String
#End Region

#Region ".NET SpecifyingCommandTimeout"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Timeout"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_SpecifyingCommandTimeout(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Timeout As Integer) As String
#End Region

#Region ".NET SpecifyingPort"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Port"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_SpecifyingPort(ByVal ServerAddress As String, ByVal Port As Integer, ByVal Username As String, ByVal Password As String, ByVal Database As String) As String
#End Region

#Region ".NET SpecifyingSharedMemoryName"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="SharedMemoryName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_SpecifyingSharedMemoryName(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal SharedMemoryName As Options.SharedMemoryName) As String
#End Region

#Region ".NET UsingEncryption"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Encryption"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_UsingEncryption(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Encryption As Options.Encryption) As String
#End Region

#Region ".NET UsingEncryptionAlternative"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <param name="Database"></param>
        ''' <param name="Encrypt"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function MySQL_NET_UsingEncryptionAlternative(ByVal ServerAddress As String, ByVal Username As String, ByVal Password As String, ByVal Database As String, ByVal Encrypt As Options.Encryption) As String
#End Region

    End Interface

    Friend Interface ILocalDBConnections
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function LocalDB_AutomaticInstance(Optional SQLVersionis2014Above As Boolean = False) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDB_AttachDB(ByVal DBFileName As String, Optional SQLVersionis2014Above As Boolean = False) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="InstanceName"></param>
        ''' <returns></returns>
        Function LocalDB_SpecifiedInstance(ByVal InstanceName As String, Optional SQLVersionis2014Above As Boolean = False) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDB_InitialCatalog(ByVal DBFileName As String, Optional SQLVersionis2014Above As Boolean = False) As String

    End Interface

    '-----------------------------------------------------------------------------
    Public Class MSAccess2003Connection
        Implements IMSAccess2003Connections
        ''' <summary>
        ''' Koneksi database Access 2003
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Function Microsoft_ODBC_Standard(DatabasePath As String, Username As String, Password As String) As Object Implements IMSAccess2003Connections.Microsoft_ODBC_Standard
            _RESULT = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & DatabasePath & ";Uid=" & Username & ";Pwd=" & Password & ";"
            Return _RESULT
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DatabasePath"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Microsoft_OLEDB_Standard(DatabasePath As String, Username As String, Password As String) As Object Implements IMSAccess2003Connections.Microsoft_OLEDB_Standard
            _RESULT = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";User Id=" & Username & ";Password=" & Password & ";"
            Return _RESULT
        End Function
    End Class

    Public Class MSSQLServer2008Connection
        Implements IMSSQLServer2008Connections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="DatabaseName"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MS_SQL2008_Standard(ServerAddress As String, ByVal DatabaseName As String, Username As String, Password As String) As Object Implements IMSSQLServer2008Connections.MS_SQL2008_Standard
            _RESULT = "Server = " & ServerAddress.Trim & "; Database = " & DatabaseName & "; User Id = " & Username.Trim & "; Password = " & Password & ";"
            Return _RESULT
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="DatabaseName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MS_SQL2008_TrustedConnection(ServerAddress As String, DatabaseName As String) As Object Implements IMSSQLServer2008Connections.MS_SQL2008_TrustedConnection
            _RESULT = "Server = " & ServerAddress.Trim & "; Database = " & DatabaseName & "; Trusted_Connection = True;"
            Return _RESULT
        End Function
    End Class

    Public Class MySQLConnection
        Implements IMySQLConnections

        Public Function MySQL_NET_InactivatingPreparedStatement(ServerAddress As String, Username As String, Password As String, Database As String, IgnorePrepare As Options.IgnorePrepare) As String Implements IMySQLConnections.MySQL_NET_InactivatingPreparedStatement
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_NamedPipes(ServerAddress As String, Username As String, Password As String, Database As String) As Object Implements IMySQLConnections.MySQL_NET_NamedPipes
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_NetworkProtocol(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String, Protocol As Options.Protocol) As String Implements IMySQLConnections.MySQL_NET_NetworkProtocol
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_SpecifyingCharacterSet(ServerAddress As String, Username As String, Password As String, Database As String, CharSet As Options.CharSet) As String Implements IMySQLConnections.MySQL_NET_SpecifyingCharacterSet
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_SpecifyingCommandTimeout(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String, Timeout As Integer) As String Implements IMySQLConnections.MySQL_NET_SpecifyingCommandTimeout
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_SpecifyingPort(ServerAddress As String, Port As Integer, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQL_NET_SpecifyingPort
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_SpecifyingSharedMemoryName(ServerAddress As String, Username As String, Password As String, Database As String, SharedMemoryName As Options.SharedMemoryName) As String Implements IMySQLConnections.MySQL_NET_SpecifyingSharedMemoryName
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_Standard(ServerAddress As String, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQL_NET_Standard
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_UsingEncryption(ServerAddress As String, Username As String, Password As String, Database As String, Encryption As Options.Encryption) As String Implements IMySQLConnections.MySQL_NET_UsingEncryption
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_NET_UsingEncryptionAlternative(ServerAddress As String, Username As String, Password As String, Database As String, Encrypt As Options.Encryption) As String Implements IMySQLConnections.MySQL_NET_UsingEncryptionAlternative
            Throw New NotImplementedException()
        End Function

        Public Function MySQL_ODBC51_Standard(ServerAddress As String, Username As String, Password As String, Database As String) As String Implements IMySQLConnections.MySQL_ODBC51_Standard
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class LocalDBConnection
        Implements ILocalDBConnections
        Private _ServerAddress As String = Nothing

        Public Function LocalDB_AttachDB(DBFileName As String, Optional SQLVersionis2014Above As Boolean = False) As String Implements ILocalDBConnections.LocalDB_AttachDB
            If SQLVersionis2014Above = False Then
                _ServerAddress = "Server=(localdb)\v11.0;"
            Else
                _ServerAddress = "Server=(LocalDb)\MSSQLLocalDB;"
            End If

            _RESULT = _ServerAddress + "Integrated Security=true;AttachDbFileName=" & DBFileName & ";"

            Return _RESULT
        End Function

        Public Function LocalDB_AutomaticInstance(Optional SQLVersionis2014Above As Boolean = False) As String Implements ILocalDBConnections.LocalDB_AutomaticInstance
            If SQLVersionis2014Above = False Then
                _ServerAddress = "Server=(localdb)\v11.0;"
            Else
                _ServerAddress = "Server=(LocalDb)\MSSQLLocalDB;"
            End If

            _RESULT = _ServerAddress + "Integrated Security=true;"

            Return _RESULT
        End Function

        Public Function LocalDB_SpecifiedInstance(InstanceName As String, Optional SQLVersionis2014Above As Boolean = False) As String Implements ILocalDBConnections.LocalDB_SpecifiedInstance
            _RESULT = "Server=(localdb)\" & InstanceName & ";Integrated Security=true;"
            Return _RESULT
        End Function

        Public Function LocalDB_InitialCatalog(DBFileName As String, Optional SQLVersionis2014Above As Boolean = False) As String Implements ILocalDBConnections.LocalDB_InitialCatalog
            If SQLVersionis2014Above = False Then
                _ServerAddress = "Server=(localdb)\v11.0;"
            Else
                _ServerAddress = "Server=(LocalDb)\MSSQLLocalDB;"
            End If

            _RESULT = _ServerAddress + "Integrated Security=true;AttachDbFileName=" & DBFileName & ";Encrypt=False; TrustServerCertificate=False;"
            Return _RESULT
        End Function
    End Class
End Namespace
