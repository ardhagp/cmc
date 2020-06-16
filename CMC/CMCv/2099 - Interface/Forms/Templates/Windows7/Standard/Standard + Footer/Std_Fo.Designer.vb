<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Std_Fo
    Inherits CMCv.frmStandard

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
        Me.PnlBottomButton = New CMCv.pnl(Me.components)
        Me.imgLine = New System.Windows.Forms.PictureBox()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.imgLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.AutoScroll = False
        Me.SLFPanel.Controls.Add(Me.PnlBottomButton)
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PnlBottomButton.Controls.Add(Me.imgLine)
        Me.PnlBottomButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 435)
        Me.PnlBottomButton.Name = "PnlBottomButton"
        Me.PnlBottomButton.Size = New System.Drawing.Size(784, 50)
        Me.PnlBottomButton.TabIndex = 995
        '
        'imgLine
        '
        Me.imgLine.BackColor = System.Drawing.Color.Orange
        Me.imgLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.imgLine.Location = New System.Drawing.Point(0, 0)
        Me.imgLine.Name = "imgLine"
        Me.imgLine.Size = New System.Drawing.Size(784, 4)
        Me.imgLine.TabIndex = 0
        Me.imgLine.TabStop = False
        '
        'frmStandard_FC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "frmStandard_FC"
        Me.ShowInTaskbar = False
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.imgLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents PnlBottomButton As CMCv.pnl
    Friend WithEvents imgLine As System.Windows.Forms.PictureBox

End Class
