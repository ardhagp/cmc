<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStandard
    Inherits CMCv.Blank

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandard))
        Me.pnl_ = New CMCv.pnl(Me.components)
        Me.SLFNamaForm = New CMCv.lbl(Me.components)
        Me.SLFSubNamaForm = New CMCv.lbl(Me.components)
        Me.SLFLogo = New CMCv.pctbx(Me.components)
        Me.SLFStatus = New CMCv.stt(Me.components)
        Me.SLFStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLFPanel = New CMCv.pnl(Me.components)
        Me.pnl_.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SLFStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_
        '
        Me.pnl_.AutoSize = True
        Me.pnl_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnl_.BackColor = System.Drawing.Color.Black
        Me.pnl_.Controls.Add(Me.SLFNamaForm)
        Me.pnl_.Controls.Add(Me.SLFSubNamaForm)
        Me.pnl_.Controls.Add(Me.SLFLogo)
        Me.pnl_.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_.Location = New System.Drawing.Point(0, 0)
        Me.pnl_.Name = "pnl_"
        Me.pnl_.Size = New System.Drawing.Size(784, 54)
        Me.pnl_.TabIndex = 999
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SLFNamaForm.AutoSize = True
        Me.SLFNamaForm.BackColor = System.Drawing.Color.Transparent
        Me.SLFNamaForm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.SLFNamaForm.ForeColor = System.Drawing.Color.White
        Me.SLFNamaForm.Location = New System.Drawing.Point(50, -1)
        Me.SLFNamaForm.Name = "SLFNamaForm"
        Me.SLFNamaForm.Size = New System.Drawing.Size(148, 32)
        Me.SLFNamaForm.SLFCustomElipsis = False
        Me.SLFNamaForm.TabIndex = 997
        Me.SLFNamaForm.Text = "Nama Form"
        Me.SLFNamaForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SLFSubNamaForm.AutoSize = True
        Me.SLFSubNamaForm.BackColor = System.Drawing.Color.Transparent
        Me.SLFSubNamaForm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLFSubNamaForm.ForeColor = System.Drawing.Color.White
        Me.SLFSubNamaForm.Location = New System.Drawing.Point(70, 30)
        Me.SLFSubNamaForm.Name = "SLFSubNamaForm"
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(108, 15)
        Me.SLFSubNamaForm.SLFCustomElipsis = False
        Me.SLFSubNamaForm.TabIndex = 996
        Me.SLFSubNamaForm.Text = "Sub Deskripsi Form"
        '
        'SLFLogo
        '
        Me.SLFLogo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.SLFLogo.ErrorImage = CType(resources.GetObject("SLFLogo.ErrorImage"), System.Drawing.Image)
        Me.SLFLogo.InitialImage = CType(resources.GetObject("SLFLogo.InitialImage"), System.Drawing.Image)
        Me.SLFLogo.Location = New System.Drawing.Point(2, 3)
        Me.SLFLogo.Name = "SLFLogo"
        Me.SLFLogo.Size = New System.Drawing.Size(48, 48)
        Me.SLFLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SLFLogo.SLFTampilkanBorder = False
        Me.SLFLogo.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.SLFLogo.TabIndex = 0
        Me.SLFLogo.TabStop = False
        '
        'SLFStatus
        '
        Me.SLFStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLFStatusLabel})
        Me.SLFStatus.Location = New System.Drawing.Point(0, 539)
        Me.SLFStatus.Name = "SLFStatus"
        Me.SLFStatus.Size = New System.Drawing.Size(784, 22)
        Me.SLFStatus.TabIndex = 994
        Me.SLFStatus.Text = "Stt1"
        '
        'SLFStatusLabel
        '
        Me.SLFStatusLabel.Name = "SLFStatusLabel"
        Me.SLFStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'SLFPanel
        '
        Me.SLFPanel.AutoScroll = True
        Me.SLFPanel.AutoSize = True
        Me.SLFPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SLFPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SLFPanel.Location = New System.Drawing.Point(0, 54)
        Me.SLFPanel.Name = "SLFPanel"
        Me.SLFPanel.Size = New System.Drawing.Size(784, 485)
        Me.SLFPanel.TabIndex = 7
        '
        'frmStandard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SLFPanel)
        Me.Controls.Add(Me.SLFStatus)
        Me.Controls.Add(Me.pnl_)
        Me.Name = "frmStandard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SLFStatus.ResumeLayout(False)
        Me.SLFStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents SLFLogo As CMCv.pctbx
    Public WithEvents SLFSubNamaForm As CMCv.lbl
    Public WithEvents SLFNamaForm As CMCv.lbl
    Public WithEvents SLFStatus As CMCv.stt
    Public WithEvents pnl_ As CMCv.pnl
    Friend WithEvents SLFStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents SLFPanel As CMCv.pnl
End Class
