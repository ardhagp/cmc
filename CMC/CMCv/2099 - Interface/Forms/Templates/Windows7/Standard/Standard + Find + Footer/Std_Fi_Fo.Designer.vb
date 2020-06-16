<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Std_Fi_Fo
    Inherits CMCv.Std_Fi

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
        Me.PnlBottomButton = New CMCv.pnl(Me.components)
        Me.imgLine = New System.Windows.Forms.PictureBox()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.imgLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.PnlBottomButton)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PnlBottomButton.Controls.Add(Me.imgLine)
        Me.PnlBottomButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 435)
        Me.PnlBottomButton.Name = "PnlBottomButton"
        Me.PnlBottomButton.Size = New System.Drawing.Size(784, 50)
        Me.PnlBottomButton.TabIndex = 996
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
        'frmStandard_FFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "frmStandard_FFC"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.imgLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents PnlBottomButton As pnl
    Friend WithEvents imgLine As Windows.Forms.PictureBox
End Class
