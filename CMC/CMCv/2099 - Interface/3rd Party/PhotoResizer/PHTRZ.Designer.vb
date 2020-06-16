<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PHTRZ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PHTRZ))
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlLoad = New CMCv.pnl(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtLoad = New CMCv.txt(Me.components)
        Me.BtnLoad = New CMCv.btn(Me.components)
        Me.PnlSave = New CMCv.pnl(Me.components)
        Me.ChkSaveAsACopy = New CMCv.chk(Me.components)
        Me.TxtSave = New CMCv.txt(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.PctbxPhoto = New CMCv.pctbx(Me.components)
        Me.OfdLoad = New System.Windows.Forms.OpenFileDialog()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.PnlLoad.SuspendLayout()
        Me.PnlSave.SuspendLayout()
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'SLFLogo
        '
        Me.SLFLogo.Image = Global.CMCv.My.Resources.Resources.Resize_001_90_FFFFFFFF_
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.TlpMain)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TlpMain, 0)
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
        Me.BtnClose.Location = New System.Drawing.Point(545, 6)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(439, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.OrangeRed
        Me.ChkAddNew.Location = New System.Drawing.Point(260, 14)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(173, 25)
        Me.ChkAddNew.TabIndex = 6
        Me.ChkAddNew.Text = "Resize another photo"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'TlpMain
        '
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.PnlLoad, 0, 0)
        Me.TlpMain.Controls.Add(Me.PnlSave, 0, 2)
        Me.TlpMain.Controls.Add(Me.PctbxPhoto, 0, 1)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(0, 0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 3
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TlpMain.Size = New System.Drawing.Size(657, 353)
        Me.TlpMain.TabIndex = 996
        '
        'PnlLoad
        '
        Me.PnlLoad.Controls.Add(Me.Lbl1)
        Me.PnlLoad.Controls.Add(Me.TxtLoad)
        Me.PnlLoad.Controls.Add(Me.BtnLoad)
        Me.PnlLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlLoad.Location = New System.Drawing.Point(3, 3)
        Me.PnlLoad.Name = "PnlLoad"
        Me.PnlLoad.Size = New System.Drawing.Size(651, 50)
        Me.PnlLoad.TabIndex = 0
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(9, 15)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(118, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.Text = "Original Picture"
        '
        'TxtLoad
        '
        Me.TxtLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLoad.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtLoad.Location = New System.Drawing.Point(133, 12)
        Me.TxtLoad.MaxLength = 255
        Me.TxtLoad.Name = "TxtLoad"
        Me.TxtLoad.ReadOnly = True
        Me.TxtLoad.Size = New System.Drawing.Size(403, 29)
        Me.TxtLoad.SLFAutoTrim = False
        Me.TxtLoad.SLFHarusDiisi = False
        Me.TxtLoad.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtLoad.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtLoad.SLFHightlightSaatFokus = False
        Me.TxtLoad.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtLoad.SLFIsBlank = True
        Me.TxtLoad.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtLoad.SLFPilihSemuaSaatFokus = False
        Me.TxtLoad.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtLoad.SLFSQLText = ""
        Me.TxtLoad.SLFTanpaSpasi = False
        Me.TxtLoad.SLFValidasiField = Nothing
        Me.TxtLoad.TabIndex = 1
        Me.TxtLoad.Tag = "txt"
        '
        'BtnLoad
        '
        Me.BtnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoad.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnLoad.FlatAppearance.BorderSize = 2
        Me.BtnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoad.ForeColor = System.Drawing.Color.White
        Me.BtnLoad.Location = New System.Drawing.Point(542, 5)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(100, 40)
        Me.BtnLoad.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnLoad.SLFTampilkanFocusBorder = False
        Me.BtnLoad.SLFValidasiSemuaInput = False
        Me.BtnLoad.SLFValidasiSemuaInputTag = Nothing
        Me.BtnLoad.TabIndex = 0
        Me.BtnLoad.Text = "&Load"
        Me.BtnLoad.UseVisualStyleBackColor = False
        '
        'PnlSave
        '
        Me.PnlSave.Controls.Add(Me.ChkSaveAsACopy)
        Me.PnlSave.Controls.Add(Me.TxtSave)
        Me.PnlSave.Controls.Add(Me.Lbl2)
        Me.PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlSave.Location = New System.Drawing.Point(3, 300)
        Me.PnlSave.Name = "PnlSave"
        Me.PnlSave.Size = New System.Drawing.Size(651, 50)
        Me.PnlSave.TabIndex = 1
        '
        'ChkSaveAsACopy
        '
        Me.ChkSaveAsACopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSaveAsACopy.AutoSize = True
        Me.ChkSaveAsACopy.BackColor = System.Drawing.Color.Transparent
        Me.ChkSaveAsACopy.Enabled = False
        Me.ChkSaveAsACopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSaveAsACopy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkSaveAsACopy.Location = New System.Drawing.Point(542, 13)
        Me.ChkSaveAsACopy.Name = "ChkSaveAsACopy"
        Me.ChkSaveAsACopy.Size = New System.Drawing.Size(92, 25)
        Me.ChkSaveAsACopy.TabIndex = 2
        Me.ChkSaveAsACopy.TabStop = False
        Me.ChkSaveAsACopy.Text = "As a copy"
        Me.ChkSaveAsACopy.UseVisualStyleBackColor = False
        '
        'TxtSave
        '
        Me.TxtSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSave.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtSave.Location = New System.Drawing.Point(132, 12)
        Me.TxtSave.MaxLength = 255
        Me.TxtSave.Name = "TxtSave"
        Me.TxtSave.Size = New System.Drawing.Size(404, 29)
        Me.TxtSave.SLFAutoTrim = False
        Me.TxtSave.SLFHarusDiisi = False
        Me.TxtSave.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtSave.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtSave.SLFHightlightSaatFokus = False
        Me.TxtSave.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtSave.SLFIsBlank = True
        Me.TxtSave.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtSave.SLFPilihSemuaSaatFokus = False
        Me.TxtSave.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtSave.SLFSQLText = ""
        Me.TxtSave.SLFTanpaSpasi = False
        Me.TxtSave.SLFValidasiField = Nothing
        Me.TxtSave.TabIndex = 4
        Me.TxtSave.Tag = "txt"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(64, 15)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(62, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 0
        Me.Lbl2.Text = "Save To"
        '
        'PctbxPhoto
        '
        Me.PctbxPhoto.BackColor = System.Drawing.Color.Transparent
        Me.PctbxPhoto.BackgroundImage = Global.CMCv.My.Resources.Resources.Resize_001_90_FFFFFFFF_
        Me.PctbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PctbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), System.Drawing.Image)
        Me.PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), System.Drawing.Image)
        Me.PctbxPhoto.Location = New System.Drawing.Point(3, 59)
        Me.PctbxPhoto.Name = "PctbxPhoto"
        Me.PctbxPhoto.Size = New System.Drawing.Size(651, 235)
        Me.PctbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctbxPhoto.SLFTampilkanBorder = False
        Me.PctbxPhoto.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.PctbxPhoto.TabIndex = 2
        Me.PctbxPhoto.TabStop = False
        '
        'OfdLoad
        '
        Me.OfdLoad.FileName = "OpenFileDialog1"
        '
        'PHTRZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "PHTRZ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.TlpMain.ResumeLayout(False)
        Me.PnlLoad.ResumeLayout(False)
        Me.PnlLoad.PerformLayout()
        Me.PnlSave.ResumeLayout(False)
        Me.PnlSave.PerformLayout()
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As btn
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents BtnSave As btn
    Friend WithEvents TlpMain As Windows.Forms.TableLayoutPanel
    Friend WithEvents PnlLoad As pnl
    Friend WithEvents PnlSave As pnl
    Friend WithEvents PctbxPhoto As pctbx
    Friend WithEvents BtnLoad As btn
    Friend WithEvents Lbl1 As lbl
    Friend WithEvents TxtLoad As txt
    Friend WithEvents TxtSave As txt
    Friend WithEvents Lbl2 As lbl
    Friend WithEvents OfdLoad As Windows.Forms.OpenFileDialog
    Friend WithEvents ChkSaveAsACopy As chk
End Class
