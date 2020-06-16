Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.Drawing

Public Class PageSetup
    Public Shared Sub pageSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs, ByVal tc As TXTextControl.TextControl, ByVal fh As FileHandler)
        Dim psd As New PageSetupDialog()
        psd.Document = New PrintDocument()

        tc.PageUnit = TXTextControl.MeasuringUnit.CentiInch

        psd.EnableMetric = True
        psd.PageSettings.PaperSize = GetTxPaperSize(tc.Selection.SectionFormat.PageSize, tc.Selection.SectionFormat.Landscape)

        Dim mrgDlg As Margins = psd.PageSettings.Margins
        Dim mrgTX As TXTextControl.PageMargins = tc.Selection.SectionFormat.PageMargins
        mrgDlg.Top = CInt(mrgTX.Top)
        mrgDlg.Right = CInt(mrgTX.Right)
        mrgDlg.Bottom = CInt(mrgTX.Bottom)
        mrgDlg.Left = CInt(mrgTX.Left)

        psd.PageSettings.Landscape = tc.Selection.SectionFormat.Landscape

        If psd.ShowDialog() = DialogResult.OK Then
            mrgDlg = psd.PageSettings.Margins

            mrgTX.Top = mrgDlg.Top
            mrgTX.Right = mrgDlg.Right
            mrgTX.Bottom = mrgDlg.Bottom
            mrgTX.Left = mrgDlg.Left

            ' Temporarily set page orientation to portrait so the 
            ' page size is set correctly
            tc.Selection.SectionFormat.Landscape = False

            tc.Selection.SectionFormat.PageSize.Height = psd.PageSettings.PaperSize.Height
            tc.Selection.SectionFormat.PageSize.Width = psd.PageSettings.PaperSize.Width
            tc.Selection.SectionFormat.Landscape = psd.PageSettings.Landscape

            fh.DocumentDirty = True
        End If
    End Sub

    ''' <summary>
    ''' Find a paper size that matches Text Control's current page size settings.  
    ''' </summary>
    Private Shared Function GetTxPaperSize(ByVal pgSize As TXTextControl.PageSize, ByVal bLandscape As Boolean) As PaperSize
        Const nTolerance As Integer = 1

        Dim pdoc As New PrintDocument()

        ' Swap values if Landscape.
        If bLandscape Then
            pgSize = New TXTextControl.PageSize(pgSize.Height, pgSize.Width)
        End If
        ' swap
        ' Find a matching page size in the printer's paper size collection
        For Each ps As PaperSize In pdoc.PrinterSettings.PaperSizes
            If (Math.Abs(ps.Height - Math.Round(pgSize.Height)) <= nTolerance) AndAlso (Math.Abs(ps.Width - Math.Round(pgSize.Width)) <= nTolerance) Then
                Return ps
            End If
        Next

        Return Nothing
    End Function

End Class
