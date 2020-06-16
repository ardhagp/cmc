<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmErrorReporting
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
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.Tbctl1 = New CMCv.tbctl(Me.components)
        Me.tp_ApplicationFault = New System.Windows.Forms.TabPage()
        Me.Lbl4 = New CMCv.lbl(Me.components)
        Me.TxtAppBuild = New CMCv.txt(Me.components)
        Me.TxtErrorNumber = New CMCv.txt(Me.components)
        Me.Lbl3 = New CMCv.lbl(Me.components)
        Me.TxtErrorMessage = New CMCv.txt(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.TxtErrorType = New CMCv.txt(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.tp_SystemInformation = New System.Windows.Forms.TabPage()
        Me.ChkErrorReporting = New CMCv.chk(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Tbctl1.SuspendLayout()
        Me.tp_ApplicationFault.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkErrorReporting)
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 409)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkErrorReporting, 0)
        '
        'SLFLogo
        '
        Me.SLFLogo.BackColor = System.Drawing.Color.Red
        Me.SLFLogo.Image = Global.CMCv.My.Resources.Resources.Error_001_90_FFFFFFFF_
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Tbctl1)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 459)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Tbctl1, 0)
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
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Tbctl1
        '
        Me.Tbctl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbctl1.Controls.Add(Me.tp_ApplicationFault)
        Me.Tbctl1.Controls.Add(Me.tp_SystemInformation)
        Me.Tbctl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Tbctl1.Location = New System.Drawing.Point(12, 6)
        Me.Tbctl1.Name = "Tbctl1"
        Me.Tbctl1.SelectedIndex = 0
        Me.Tbctl1.Size = New System.Drawing.Size(633, 401)
        Me.Tbctl1.TabIndex = 1
        '
        'tp_ApplicationFault
        '
        Me.tp_ApplicationFault.Controls.Add(Me.Lbl4)
        Me.tp_ApplicationFault.Controls.Add(Me.TxtAppBuild)
        Me.tp_ApplicationFault.Controls.Add(Me.TxtErrorNumber)
        Me.tp_ApplicationFault.Controls.Add(Me.Lbl3)
        Me.tp_ApplicationFault.Controls.Add(Me.TxtErrorMessage)
        Me.tp_ApplicationFault.Controls.Add(Me.Lbl2)
        Me.tp_ApplicationFault.Controls.Add(Me.TxtErrorType)
        Me.tp_ApplicationFault.Controls.Add(Me.Lbl1)
        Me.tp_ApplicationFault.Location = New System.Drawing.Point(4, 30)
        Me.tp_ApplicationFault.Name = "tp_ApplicationFault"
        Me.tp_ApplicationFault.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_ApplicationFault.Size = New System.Drawing.Size(625, 367)
        Me.tp_ApplicationFault.TabIndex = 0
        Me.tp_ApplicationFault.Text = "Application Fault"
        Me.tp_ApplicationFault.UseVisualStyleBackColor = True
        '
        'Lbl4
        '
        Me.Lbl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl4.Location = New System.Drawing.Point(254, 308)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(134, 21)
        Me.Lbl4.SLFCustomElipsis = False
        Me.Lbl4.TabIndex = 7
        Me.Lbl4.Text = "Application Build :"
        '
        'TxtAppBuild
        '
        Me.TxtAppBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtAppBuild.BackColor = System.Drawing.Color.White
        Me.TxtAppBuild.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAppBuild.Location = New System.Drawing.Point(254, 332)
        Me.TxtAppBuild.MaxLength = 255
        Me.TxtAppBuild.Name = "TxtAppBuild"
        Me.TxtAppBuild.ReadOnly = True
        Me.TxtAppBuild.Size = New System.Drawing.Size(206, 29)
        Me.TxtAppBuild.SLFAutoTrim = False
        Me.TxtAppBuild.SLFHarusDiisi = False
        Me.TxtAppBuild.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtAppBuild.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtAppBuild.SLFHightlightSaatFokus = False
        Me.TxtAppBuild.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtAppBuild.SLFIsBlank = True
        Me.TxtAppBuild.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtAppBuild.SLFPilihSemuaSaatFokus = False
        Me.TxtAppBuild.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtAppBuild.SLFSQLText = Nothing
        Me.TxtAppBuild.SLFTanpaSpasi = False
        Me.TxtAppBuild.SLFValidasiField = Nothing
        Me.TxtAppBuild.TabIndex = 6
        Me.TxtAppBuild.Tag = "txt"
        '
        'TxtErrorNumber
        '
        Me.TxtErrorNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtErrorNumber.BackColor = System.Drawing.Color.White
        Me.TxtErrorNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtErrorNumber.Location = New System.Drawing.Point(6, 332)
        Me.TxtErrorNumber.MaxLength = 255
        Me.TxtErrorNumber.Name = "TxtErrorNumber"
        Me.TxtErrorNumber.ReadOnly = True
        Me.TxtErrorNumber.Size = New System.Drawing.Size(242, 29)
        Me.TxtErrorNumber.SLFAutoTrim = False
        Me.TxtErrorNumber.SLFHarusDiisi = False
        Me.TxtErrorNumber.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtErrorNumber.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtErrorNumber.SLFHightlightSaatFokus = False
        Me.TxtErrorNumber.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtErrorNumber.SLFIsBlank = True
        Me.TxtErrorNumber.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtErrorNumber.SLFPilihSemuaSaatFokus = False
        Me.TxtErrorNumber.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtErrorNumber.SLFSQLText = Nothing
        Me.TxtErrorNumber.SLFTanpaSpasi = False
        Me.TxtErrorNumber.SLFValidasiField = Nothing
        Me.TxtErrorNumber.TabIndex = 5
        Me.TxtErrorNumber.Tag = "txt"
        '
        'Lbl3
        '
        Me.Lbl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl3.Location = New System.Drawing.Point(6, 308)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(114, 21)
        Me.Lbl3.SLFCustomElipsis = False
        Me.Lbl3.TabIndex = 4
        Me.Lbl3.Text = "Error Number :"
        '
        'TxtErrorMessage
        '
        Me.TxtErrorMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtErrorMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtErrorMessage.Location = New System.Drawing.Point(6, 83)
        Me.TxtErrorMessage.MaxLength = 255
        Me.TxtErrorMessage.Multiline = True
        Me.TxtErrorMessage.Name = "TxtErrorMessage"
        Me.TxtErrorMessage.Size = New System.Drawing.Size(613, 222)
        Me.TxtErrorMessage.SLFAutoTrim = False
        Me.TxtErrorMessage.SLFHarusDiisi = False
        Me.TxtErrorMessage.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtErrorMessage.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtErrorMessage.SLFHightlightSaatFokus = False
        Me.TxtErrorMessage.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtErrorMessage.SLFIsBlank = True
        Me.TxtErrorMessage.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtErrorMessage.SLFPilihSemuaSaatFokus = False
        Me.TxtErrorMessage.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtErrorMessage.SLFSQLText = Nothing
        Me.TxtErrorMessage.SLFTanpaSpasi = False
        Me.TxtErrorMessage.SLFValidasiField = Nothing
        Me.TxtErrorMessage.TabIndex = 3
        Me.TxtErrorMessage.Tag = "txt"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(6, 59)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(78, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "Message :"
        '
        'TxtErrorType
        '
        Me.TxtErrorType.BackColor = System.Drawing.Color.White
        Me.TxtErrorType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtErrorType.Location = New System.Drawing.Point(6, 27)
        Me.TxtErrorType.MaxLength = 255
        Me.TxtErrorType.Name = "TxtErrorType"
        Me.TxtErrorType.ReadOnly = True
        Me.TxtErrorType.Size = New System.Drawing.Size(242, 29)
        Me.TxtErrorType.SLFAutoTrim = False
        Me.TxtErrorType.SLFHarusDiisi = False
        Me.TxtErrorType.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtErrorType.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtErrorType.SLFHightlightSaatFokus = False
        Me.TxtErrorType.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtErrorType.SLFIsBlank = True
        Me.TxtErrorType.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtErrorType.SLFPilihSemuaSaatFokus = False
        Me.TxtErrorType.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtErrorType.SLFSQLText = Nothing
        Me.TxtErrorType.SLFTanpaSpasi = False
        Me.TxtErrorType.SLFValidasiField = Nothing
        Me.TxtErrorType.TabIndex = 1
        Me.TxtErrorType.Tag = "txt"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(6, 3)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(49, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Type :"
        '
        'tp_SystemInformation
        '
        Me.tp_SystemInformation.Location = New System.Drawing.Point(4, 30)
        Me.tp_SystemInformation.Name = "tp_SystemInformation"
        Me.tp_SystemInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_SystemInformation.Size = New System.Drawing.Size(752, 393)
        Me.tp_SystemInformation.TabIndex = 1
        Me.tp_SystemInformation.Text = "Your System Information"
        Me.tp_SystemInformation.UseVisualStyleBackColor = True
        '
        'ChkErrorReporting
        '
        Me.ChkErrorReporting.AutoSize = True
        Me.ChkErrorReporting.BackColor = System.Drawing.Color.Transparent
        Me.ChkErrorReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkErrorReporting.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkErrorReporting.Location = New System.Drawing.Point(298, 15)
        Me.ChkErrorReporting.Name = "ChkErrorReporting"
        Me.ChkErrorReporting.Size = New System.Drawing.Size(241, 25)
        Me.ChkErrorReporting.TabIndex = 1
        Me.ChkErrorReporting.Text = "Report this error to Developer?"
        Me.ChkErrorReporting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkErrorReporting.UseVisualStyleBackColor = True
        Me.ChkErrorReporting.Visible = False
        '
        'frmErrorReporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 535)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(673, 574)
        Me.Name = "frmErrorReporting"
        Me.ShowInTaskbar = True
        Me.TopMost = True
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Tbctl1.ResumeLayout(False)
        Me.tp_ApplicationFault.ResumeLayout(False)
        Me.tp_ApplicationFault.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents Tbctl1 As CMCv.tbctl
    Friend WithEvents tp_ApplicationFault As System.Windows.Forms.TabPage
    Friend WithEvents tp_SystemInformation As System.Windows.Forms.TabPage
    Friend WithEvents TxtErrorNumber As CMCv.txt
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents TxtErrorMessage As CMCv.txt
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents TxtErrorType As CMCv.txt
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents TxtAppBuild As CMCv.txt
    Friend WithEvents ChkErrorReporting As CMCv.chk

End Class
