<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHTMLOptions
    Inherits CMCv.Blank

    ''Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing AndAlso components IsNot Nothing Then
    '        components.Dispose()
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnOK = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.Gbx1 = New CMCv.gbx(Me.components)
        Me.TxtStylesheetFile = New CMCv.txt(Me.components)
        Me.lblStylesheetFile = New CMCv.lbl(Me.components)
        Me.optSaveButDoNotOverwriteExistingFile = New CMCv.rdo(Me.components)
        Me.optSaveStylesheetInSeperateFile = New CMCv.rdo(Me.components)
        Me.optInlineStylesheet = New CMCv.rdo(Me.components)
        Me.optNoStylesheet = New CMCv.rdo(Me.components)
        Me.Gbx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnOK.FlatAppearance.BorderSize = 2
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Location = New System.Drawing.Point(218, 210)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(100, 40)
        Me.BtnOK.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnOK.SLFTampilkanFocusBorder = False
        Me.BtnOK.SLFValidasiSemuaInput = False
        Me.BtnOK.SLFValidasiSemuaInputTag = Nothing
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "&OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(112, 210)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Gbx1
        '
        Me.Gbx1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx1.Controls.Add(Me.TxtStylesheetFile)
        Me.Gbx1.Controls.Add(Me.lblStylesheetFile)
        Me.Gbx1.Controls.Add(Me.optSaveButDoNotOverwriteExistingFile)
        Me.Gbx1.Controls.Add(Me.optSaveStylesheetInSeperateFile)
        Me.Gbx1.Controls.Add(Me.optInlineStylesheet)
        Me.Gbx1.Controls.Add(Me.optNoStylesheet)
        Me.Gbx1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Gbx1.Location = New System.Drawing.Point(12, 12)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.Size = New System.Drawing.Size(306, 192)
        Me.Gbx1.TabIndex = 2
        Me.Gbx1.TabStop = False
        Me.Gbx1.Text = "HTML stylesheet save options"
        '
        'TxtStylesheetFile
        '
        Me.TxtStylesheetFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtStylesheetFile.Location = New System.Drawing.Point(6, 146)
        Me.TxtStylesheetFile.MaxLength = 255
        Me.TxtStylesheetFile.Name = "TxtStylesheetFile"
        Me.TxtStylesheetFile.Size = New System.Drawing.Size(294, 29)
        Me.TxtStylesheetFile.SLFAutoTrim = False
        Me.TxtStylesheetFile.SLFHarusDiisi = False
        Me.TxtStylesheetFile.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtStylesheetFile.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtStylesheetFile.SLFHightlightSaatFokus = False
        Me.TxtStylesheetFile.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtStylesheetFile.SLFPilihSemuaSaatFokus = False
        Me.TxtStylesheetFile.SLFTanpaSpasi = False
        Me.TxtStylesheetFile.SLFValidasiField = Nothing
        Me.TxtStylesheetFile.TabIndex = 5
        Me.TxtStylesheetFile.Tag = "txt"
        '
        'lblStylesheetFile
        '
        Me.lblStylesheetFile.AutoSize = True
        Me.lblStylesheetFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblStylesheetFile.Location = New System.Drawing.Point(6, 122)
        Me.lblStylesheetFile.Name = "lblStylesheetFile"
        Me.lblStylesheetFile.Size = New System.Drawing.Size(108, 21)
        Me.lblStylesheetFile.TabIndex = 4
        Me.lblStylesheetFile.Text = "Stylesheet file:"
        '
        'optSaveButDoNotOverwriteExistingFile
        '
        Me.optSaveButDoNotOverwriteExistingFile.AutoSize = True
        Me.optSaveButDoNotOverwriteExistingFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSaveButDoNotOverwriteExistingFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.optSaveButDoNotOverwriteExistingFile.Location = New System.Drawing.Point(6, 94)
        Me.optSaveButDoNotOverwriteExistingFile.Name = "optSaveButDoNotOverwriteExistingFile"
        Me.optSaveButDoNotOverwriteExistingFile.Size = New System.Drawing.Size(288, 25)
        Me.optSaveButDoNotOverwriteExistingFile.TabIndex = 3
        Me.optSaveButDoNotOverwriteExistingFile.TabStop = True
        Me.optSaveButDoNotOverwriteExistingFile.Text = "Sa&ve but do not overwrite existing file"
        Me.optSaveButDoNotOverwriteExistingFile.UseVisualStyleBackColor = True
        '
        'optSaveStylesheetInSeperateFile
        '
        Me.optSaveStylesheetInSeperateFile.AutoSize = True
        Me.optSaveStylesheetInSeperateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSaveStylesheetInSeperateFile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.optSaveStylesheetInSeperateFile.Location = New System.Drawing.Point(6, 72)
        Me.optSaveStylesheetInSeperateFile.Name = "optSaveStylesheetInSeperateFile"
        Me.optSaveStylesheetInSeperateFile.Size = New System.Drawing.Size(238, 25)
        Me.optSaveStylesheetInSeperateFile.TabIndex = 2
        Me.optSaveStylesheetInSeperateFile.TabStop = True
        Me.optSaveStylesheetInSeperateFile.Text = "&Save stylesheet in seperate file"
        Me.optSaveStylesheetInSeperateFile.UseVisualStyleBackColor = True
        '
        'optInlineStylesheet
        '
        Me.optInlineStylesheet.AutoSize = True
        Me.optInlineStylesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optInlineStylesheet.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.optInlineStylesheet.Location = New System.Drawing.Point(6, 50)
        Me.optInlineStylesheet.Name = "optInlineStylesheet"
        Me.optInlineStylesheet.Size = New System.Drawing.Size(138, 25)
        Me.optInlineStylesheet.TabIndex = 1
        Me.optInlineStylesheet.TabStop = True
        Me.optInlineStylesheet.Text = "&Inline stylesheet"
        Me.optInlineStylesheet.UseVisualStyleBackColor = True
        '
        'optNoStylesheet
        '
        Me.optNoStylesheet.AutoSize = True
        Me.optNoStylesheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optNoStylesheet.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.optNoStylesheet.Location = New System.Drawing.Point(6, 28)
        Me.optNoStylesheet.Name = "optNoStylesheet"
        Me.optNoStylesheet.Size = New System.Drawing.Size(121, 25)
        Me.optNoStylesheet.TabIndex = 0
        Me.optNoStylesheet.TabStop = True
        Me.optNoStylesheet.Text = "&No stylesheet"
        Me.optNoStylesheet.UseVisualStyleBackColor = True
        '
        'FrmHTMLOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(330, 262)
        Me.Controls.Add(Me.Gbx1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "FrmHTMLOptions"
        Me.Gbx1.ResumeLayout(False)
        Me.Gbx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOK As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents Gbx1 As CMCv.gbx
    Friend WithEvents optSaveButDoNotOverwriteExistingFile As CMCv.rdo
    Friend WithEvents optSaveStylesheetInSeperateFile As CMCv.rdo
    Friend WithEvents optInlineStylesheet As CMCv.rdo
    Friend WithEvents optNoStylesheet As CMCv.rdo
    Friend WithEvents TxtStylesheetFile As CMCv.txt
    Friend WithEvents lblStylesheetFile As CMCv.lbl

End Class
