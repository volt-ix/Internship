<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistory
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
        Me.BtnGoBack = New System.Windows.Forms.Button()
        Me.LvHistory = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'BtnGoBack
        '
        Me.BtnGoBack.Location = New System.Drawing.Point(12, 313)
        Me.BtnGoBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGoBack.Name = "BtnGoBack"
        Me.BtnGoBack.Size = New System.Drawing.Size(134, 40)
        Me.BtnGoBack.TabIndex = 3
        Me.BtnGoBack.Text = "Go Back"
        Me.BtnGoBack.UseVisualStyleBackColor = True
        '
        'LvHistory
        '
        Me.LvHistory.HideSelection = False
        Me.LvHistory.Location = New System.Drawing.Point(12, 13)
        Me.LvHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LvHistory.Name = "LvHistory"
        Me.LvHistory.Size = New System.Drawing.Size(634, 279)
        Me.LvHistory.TabIndex = 2
        Me.LvHistory.UseCompatibleStateImageBehavior = False
        Me.LvHistory.View = System.Windows.Forms.View.List
        '
        'FrmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 366)
        Me.Controls.Add(Me.BtnGoBack)
        Me.Controls.Add(Me.LvHistory)
        Me.Name = "FrmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHistory"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnGoBack As Button
    Friend WithEvents LvHistory As ListView
End Class
