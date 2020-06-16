Public Class Rpt_Bsc
    Private Sub Rpt_Bsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Rv_.RefreshReport()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
