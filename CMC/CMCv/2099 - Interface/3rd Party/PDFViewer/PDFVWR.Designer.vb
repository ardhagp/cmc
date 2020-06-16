<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDFVWR
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PdfViewerPrinterSettings1 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFVWR))
        Dim TextSearchSettings1 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.PDFContent = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.PDFContent)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PDFContent, 0)
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(545, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PDFContent
        '
        Me.PDFContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDFContent.EnableContextMenu = True
        Me.PDFContent.EnableNotificationBar = True
        Me.PDFContent.HorizontalScrollOffset = 0
        Me.PDFContent.IsBookmarkEnabled = True
        Me.PDFContent.Location = New System.Drawing.Point(0, 0)
        Me.PDFContent.Name = "PDFContent"
        Me.PDFContent.PageBorderThickness = 1
        PdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings1.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings1.PrintLocation"), System.Drawing.PointF)
        Me.PDFContent.PrinterSettings = PdfViewerPrinterSettings1
        Me.PDFContent.ReferencePath = Nothing
        Me.PDFContent.ScrollDisplacementValue = 0
        Me.PDFContent.ShowHorizontalScrollBar = True
        Me.PDFContent.ShowToolBar = True
        Me.PDFContent.ShowVerticalScrollBar = True
        Me.PDFContent.Size = New System.Drawing.Size(657, 353)
        Me.PDFContent.SpaceBetweenPages = 8
        Me.PDFContent.TabIndex = 997
        TextSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings1.HighlightAllInstance = True
        TextSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PDFContent.TextSearchSettings = TextSearchSettings1
        Me.PDFContent.VerticalScrollOffset = 0
        Me.PDFContent.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016White
        Me.PDFContent.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitWidth
        '
        'PDFVWR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.KeyPreview = True
        Me.Name = "PDFVWR"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BtnClose As btn
    Public WithEvents PDFContent As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
End Class
