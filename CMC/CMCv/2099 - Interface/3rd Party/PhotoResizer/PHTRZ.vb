Public Class PHTRZ
    Private _IMG_Compressor As New CMCv.ImageEditor.Proccessor.Compress
    Private _FILEHandler As New CMCv.OperatingSystem.File.Info
    Public Event Done()

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
        RaiseEvent Done()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try
            If TxtLoad.Text = String.Empty Then
                SLFStatusLabel.Text = "Please pick one of your photo first."
                Exit Sub
            ElseIf _FILEHandler.IsExists(TxtLoad.Text) = False Then
                SLFStatusLabel.Text = "Your photo does not exist. Please recheck your file."
                Exit Sub
            End If

            If _IMG_Compressor.OutputAsFile(TxtLoad.Text, TxtSave.Text) = False Then
                SLFStatusLabel.Text = "Error occured while resizing. Compressing failed."
                Exit Sub
            End If

            TxtLoad.Text = String.Empty
            TxtSave.Text = String.Empty
            PctbxPhoto.Image = Nothing

            SLFStatusLabel.Text = "PHTRZ successfully compressed your photo."

            If ChkAddNew.Checked = False Then
                Me.Close()
                RaiseEvent Done()
            End If



        Catch ex As Exception
            SLFStatusLabel.Text = "Error occured while resizing. Compressing failed."
        End Try

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        SLFStatusLabel.Text = ""

        OfdLoad.Title = "PHTRZ - Photo Resizer"
        OfdLoad.FileName = ""
        OfdLoad.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdLoad.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtLoad.Text = OfdLoad.FileName
            PctbxPhoto.ImageLocation = OfdLoad.FileName

            If (TxtLoad.Text.Contains(".jpg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpg", "_PHTRZ.jpg")
            ElseIf (TxtLoad.Text.Contains(".jpeg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpeg", "_PHTRZ.jpeg")
            Else
                TxtSave.Text = TxtLoad.Text
            End If

        End If
    End Sub

    Private Sub TxtLoad_TextChanged(sender As Object, e As EventArgs) Handles TxtLoad.TextChanged
        If TxtLoad.Text IsNot String.Empty Then
            If (TxtLoad.Text.Contains(".jpg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpg", "_PHTRZ.jpg")
            ElseIf (TxtLoad.Text.Contains(".jpeg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpeg", "_PHTRZ.jpeg")
            Else
                TxtSave.Text = TxtLoad.Text
            End If
        End If
    End Sub

    Private Sub TxtSave_TextChanged(sender As Object, e As EventArgs) Handles TxtSave.TextChanged

    End Sub

    Private Sub PHTRZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkSaveAsACopy.Checked = True
    End Sub

    Private Sub ChkSaveAsACopy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSaveAsACopy.CheckedChanged
        If TxtLoad.Text IsNot String.Empty Then
            If (TxtLoad.Text.Contains(".jpg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpg", "_PHTRZ.jpg")
            ElseIf (TxtLoad.Text.Contains(".jpeg") = True) And (ChkSaveAsACopy.Checked = True) Then
                TxtSave.Text = TxtLoad.Text.Replace(".jpeg", "_PHTRZ.jpeg")
            Else
                TxtSave.Text = TxtLoad.Text
            End If
        End If
    End Sub
End Class
