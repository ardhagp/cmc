<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ULbl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ULbl))
        Me.UHead = New CMCv.pctbx(Me.components)
        Me.UText = New CMCv.lbl(Me.components)
        Me.tmr_ = New System.Windows.Forms.Timer(Me.components)
        CType(Me.UHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UHead
        '
        Me.UHead.BackColor = System.Drawing.Color.DarkGray
        Me.UHead.Dock = System.Windows.Forms.DockStyle.Left
        Me.UHead.ErrorImage = CType(resources.GetObject("UHead.ErrorImage"), System.Drawing.Image)
        Me.UHead.InitialImage = CType(resources.GetObject("UHead.InitialImage"), System.Drawing.Image)
        Me.UHead.Location = New System.Drawing.Point(0, 0)
        Me.UHead.Name = "UHead"
        Me.UHead.Size = New System.Drawing.Size(10, 29)
        Me.UHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UHead.SLFTampilkanBorder = False
        Me.UHead.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.UHead.TabIndex = 0
        Me.UHead.TabStop = False
        '
        'UText
        '
        Me.UText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UText.BackColor = System.Drawing.Color.Transparent
        Me.UText.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UText.Location = New System.Drawing.Point(10, 0)
        Me.UText.Name = "UText"
        Me.UText.Size = New System.Drawing.Size(137, 29)
        Me.UText.SLFCustomElipsis = False
        Me.UText.TabIndex = 1
        Me.UText.Text = "Text"
        Me.UText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmr_
        '
        '
        'ULbl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.UHead)
        Me.Controls.Add(Me.UText)
        Me.Name = "ULbl"
        Me.Size = New System.Drawing.Size(150, 29)
        CType(Me.UHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UHead As pctbx
    Friend WithEvents UText As lbl
    Friend WithEvents tmr_ As Windows.Forms.Timer
End Class
