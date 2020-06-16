<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpt_Bsc
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Rv_ = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Rv_)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Rv_, 0)
        '
        'Rv_
        '
        Me.Rv_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rv_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rv_.Location = New System.Drawing.Point(0, 0)
        Me.Rv_.Name = "Rv_"
        Me.Rv_.Size = New System.Drawing.Size(784, 435)
        Me.Rv_.TabIndex = 996
        Me.Rv_.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
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
        Me.BtnClose.Location = New System.Drawing.Point(672, 6)
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
        'Rpt_Bsc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "Rpt_Bsc"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Rv_ As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BtnClose As btn
End Class
