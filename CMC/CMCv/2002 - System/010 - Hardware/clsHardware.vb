Imports System.Management
Imports System.Windows.Forms

Namespace Sys.Hardware
    Public Class Keyboard
        Public Function Installed() As Integer

            Try
                Dim _Result As Integer = 0

                Dim searcher As New ManagementObjectSearcher(
                    "root\CIMV2",
                    "SELECT * FROM Win32_Keyboard")

                For Each queryObj As ManagementObject In searcher.Get()
                    _Result += 1
                Next
            Catch err As ManagementException
                MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                _RESULT = 0
            End Try
            Return _RESULT
        End Function
    End Class
End Namespace
