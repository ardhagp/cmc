
Namespace Database.Provider
    ''' <summary>
    ''' Merupakan attribut pelengkap koneksi database
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Options
        Public Enum Protocol
            ''' <summary>
            ''' Jenis protokol yang digunakan
            ''' </summary>
            ''' <remarks></remarks>
            TCP
            SOCKET
        End Enum

        Public Enum Encryption
            ''' <summary>
            ''' Jenis enkripsi untuk menjamin keamanan lalu lintas data
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 0
        End Enum

        Public Enum CharSet
            ''' <summary>
            ''' Character set yang umum digunakan
            ''' </summary>
            ''' <remarks></remarks>
            UTF8
        End Enum

        Public Enum IgnorePrepare
            ''' <summary>
            ''' Mode IgnorePrepare
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 2
        End Enum

        Public Enum SharedMemoryName
            ''' <summary>
            ''' Nama memory bagi pakai
            ''' </summary>
            ''' <remarks>Khusus MySQL</remarks>
            MYSQL = 1
        End Enum

        Public Enum CommandLogging
            ''' <summary>
            ''' Untuk pencatatan perintah database
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 0
        End Enum

        Public Enum Compression
            ''' <summary>
            ''' Mode kompresi data
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 0
        End Enum

        Public Enum Pooling
            ''' <summary>
            ''' Mode pooling
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 0
        End Enum

        Public Enum Direct
            ''' <summary>
            ''' Mode direct
            ''' </summary>
            ''' <remarks></remarks>
            Yes = 1
            No = 0
        End Enum
    End Class
End Namespace
