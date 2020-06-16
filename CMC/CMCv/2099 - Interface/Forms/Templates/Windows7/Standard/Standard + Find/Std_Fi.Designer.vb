<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Std_Fi
    Inherits CMCv.frmStandard

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
        Me.PnlFind = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.LblFind = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.PnlFind.SuspendLayout()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.PnlFind)
        '
        'PnlFind
        '
        Me.PnlFind.Controls.Add(Me.BtnClear)
        Me.PnlFind.Controls.Add(Me.LblFind)
        Me.PnlFind.Controls.Add(Me.TxtFind)
        Me.PnlFind.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlFind.Location = New System.Drawing.Point(0, 0)
        Me.PnlFind.Name = "PnlFind"
        Me.PnlFind.Size = New System.Drawing.Size(784, 46)
        Me.PnlFind.TabIndex = 801
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Red
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(262, 3)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 40)
        Me.BtnClear.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClear.SLFTampilkanFocusBorder = False
        Me.BtnClear.SLFValidasiSemuaInput = False
        Me.BtnClear.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClear.TabIndex = 801
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'LblFind
        '
        Me.LblFind.AutoSize = True
        Me.LblFind.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblFind.Location = New System.Drawing.Point(12, 13)
        Me.LblFind.Name = "LblFind"
        Me.LblFind.Size = New System.Drawing.Size(40, 21)
        Me.LblFind.SLFCustomElipsis = False
        Me.LblFind.TabIndex = 5
        Me.LblFind.Text = "Find"
        '
        'TxtFind
        '
        Me.TxtFind.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtFind.Location = New System.Drawing.Point(63, 10)
        Me.TxtFind.MaxLength = 255
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(193, 29)
        Me.TxtFind.SLFAutoTrim = False
        Me.TxtFind.SLFHarusDiisi = False
        Me.TxtFind.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtFind.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtFind.SLFHightlightSaatFokus = False
        Me.TxtFind.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtFind.SLFIsBlank = True
        Me.TxtFind.SLFIsSearchBox = True
        Me.TxtFind.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtFind.SLFPilihSemuaSaatFokus = False
        Me.TxtFind.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFind.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFind.SLFSQLText = Nothing
        Me.TxtFind.SLFTanpaSpasi = False
        Me.TxtFind.SLFValidasiField = Nothing
        Me.TxtFind.TabIndex = 800
        Me.TxtFind.Tag = "txt"
        '
        'frmStandard_Find
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "frmStandard_Find"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents PnlFind As pnl
    Public WithEvents BtnClear As btn
    Public WithEvents LblFind As lbl
    Public WithEvents TxtFind As txt
End Class
