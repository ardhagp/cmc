Public Class frmStandard

    Private Sub frmStandard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            GC.Collect()
            Me.Text = SLFNamaForm.Text
            Me.KeyPreview = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
        End Try
    End Sub

    Private Sub frmStandard_FormClosed(sender As Object, e As Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not SLFStatusLabel.IsDisposed Then
            SLFStatusLabel.Text = ""
        End If
    End Sub

    Private Sub frmStandard_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GC.Collect()
        GC.Collect(GC.MaxGeneration)
    End Sub

    Private Sub frmStandard_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        SLFNamaForm.Width = pnl_.Width - 111
        SLFSubNamaForm.Width = pnl_.Width - 134
    End Sub

    Private Sub frmStandard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' This Function still not working 
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckTextInputs() As Integer
        Dim _Violation As Integer = 0
        Dim AllTxt As New List(Of Windows.Forms.Control)
        For Each _Txt As CMCv.txt In FindControlRecursive(AllTxt, Me, GetType(CMCv.txt))
            If _Txt.SLFHarusDiisi = True AndAlso _Txt.SLFSQLText = String.Empty Then
                _Violation += 1
            End If
        Next

        Return _Violation
    End Function

    ''' <summary>
    ''' This function still not working
    ''' </summary>
    ''' <param name="list"></param>
    ''' <param name="Parent"></param>
    ''' <param name="CtrlType"></param>
    ''' <returns></returns>
    Private Shared Function FindControlRecursive(ByVal list As List(Of Windows.Forms.Control), ByVal Parent As Windows.Forms.Control, ByVal CtrlType As System.Type) As List(Of Windows.Forms.Control)
        If Parent Is Nothing Then Return list
        If Parent.GetType Is CtrlType Then
            list.Add(Parent)
        End If

        For Each child As Windows.Forms.Control In Parent.Controls
            FindControlRecursive(list, child, CtrlType)
        Next

        Return list
    End Function

    Public Sub CheckAllControls()
        Dim _AllControls As Windows.Forms.Control = Me.GetNextControl(Me, True)

        Do Until _AllControls Is Nothing
            _AllControls.Focus()
            _AllControls = Me.GetNextControl(_AllControls, True)
        Loop
    End Sub
End Class
