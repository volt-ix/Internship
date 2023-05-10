<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissions
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnStore = New System.Windows.Forms.Button()
        Me.txtPermissions = New System.Windows.Forms.TextBox()
        Me.LvPermissions = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnGoBack
        '
        Me.BtnGoBack.Location = New System.Drawing.Point(12, 337)
        Me.BtnGoBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGoBack.Name = "BtnGoBack"
        Me.BtnGoBack.Size = New System.Drawing.Size(105, 30)
        Me.BtnGoBack.TabIndex = 31
        Me.BtnGoBack.Text = "Back"
        Me.BtnGoBack.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(420, 337)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 30)
        Me.BtnAdd.TabIndex = 27
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(307, 337)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(105, 30)
        Me.BtnEdit.TabIndex = 26
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(307, 337)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 30)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnStore
        '
        Me.BtnStore.Location = New System.Drawing.Point(420, 337)
        Me.BtnStore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStore.Name = "BtnStore"
        Me.BtnStore.Size = New System.Drawing.Size(105, 30)
        Me.BtnStore.TabIndex = 24
        Me.BtnStore.Text = "Store"
        Me.BtnStore.UseVisualStyleBackColor = True
        '
        'txtPermissions
        '
        Me.txtPermissions.Location = New System.Drawing.Point(12, 303)
        Me.txtPermissions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPermissions.Name = "txtPermissions"
        Me.txtPermissions.Size = New System.Drawing.Size(299, 22)
        Me.txtPermissions.TabIndex = 23
        '
        'LvPermissions
        '
        Me.LvPermissions.FormattingEnabled = True
        Me.LvPermissions.ItemHeight = 16
        Me.LvPermissions.Location = New System.Drawing.Point(12, 11)
        Me.LvPermissions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LvPermissions.Name = "LvPermissions"
        Me.LvPermissions.Size = New System.Drawing.Size(513, 276)
        Me.LvPermissions.TabIndex = 22
        '
        'frmPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 382)
        Me.Controls.Add(Me.BtnGoBack)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnStore)
        Me.Controls.Add(Me.txtPermissions)
        Me.Controls.Add(Me.LvPermissions)
        Me.Name = "frmPermissions"
        Me.Text = "frmPermissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGoBack As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnStore As Button
    Friend WithEvents txtPermissions As TextBox
    Friend WithEvents LvPermissions As ListBox
End Class
