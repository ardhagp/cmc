<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhotoViewer
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
        Me.Imgs_ = New Syncfusion.Windows.Forms.Tools.ImageStreamer()
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
        Me.SLFPanel.Controls.Add(Me.Imgs_)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Imgs_, 0)
        '
        'Imgs_
        '
        Me.Imgs_.AllowDragging = True
        Me.Imgs_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Imgs_.InternalBackColor = System.Drawing.Color.Transparent
        Me.Imgs_.Location = New System.Drawing.Point(0, 0)
        Me.Imgs_.Name = "Imgs_"
        Me.Imgs_.Size = New System.Drawing.Size(784, 435)
        Me.Imgs_.TabIndex = 1
        Me.Imgs_.TextAnimationDirection = Syncfusion.Windows.Forms.Tools.ImageStreamer.TextStreamDirection.RightToLeft
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
        Me.BtnClose.Location = New System.Drawing.Point(672, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PhotoViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "PhotoViewer"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Imgs_ As Syncfusion.Windows.Forms.Tools.ImageStreamer
    Public WithEvents BtnClose As btn
End Class
