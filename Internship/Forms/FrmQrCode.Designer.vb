<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQrCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ptbQrCode = New System.Windows.Forms.PictureBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbMenus = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.ptbQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbQrCode
        '
        Me.ptbQrCode.Location = New System.Drawing.Point(16, 52)
        Me.ptbQrCode.Name = "ptbQrCode"
        Me.ptbQrCode.Size = New System.Drawing.Size(501, 222)
        Me.ptbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbQrCode.TabIndex = 1
        Me.ptbQrCode.TabStop = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(16, 290)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(153, 43)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDownload.FlatAppearance.BorderSize = 0
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(189, 290)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(153, 43)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(364, 290)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(153, 43)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cmbMenus
        '
        Me.cmbMenus.FormattingEnabled = True
        Me.cmbMenus.Location = New System.Drawing.Point(17, 22)
        Me.cmbMenus.Name = "cmbMenus"
        Me.cmbMenus.Size = New System.Drawing.Size(500, 24)
        Me.cmbMenus.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Red
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Location = New System.Drawing.Point(189, 351)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(153, 42)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FrmQrCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 405)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmbMenus)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.ptbQrCode)
        Me.Name = "FrmQrCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmQrCode"
        CType(Me.ptbQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptbQrCode As PictureBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents cmbMenus As ComboBox
    Friend WithEvents btnBack As Button
End Class
