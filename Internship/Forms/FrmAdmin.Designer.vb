<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.BtnGoBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbtnInactive = New System.Windows.Forms.RadioButton()
        Me.RbtnActive = New System.Windows.Forms.RadioButton()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnStore = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.LvRoles = New System.Windows.Forms.ListBox()
        Me.RolesBindingSrc = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RolesBindingSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGoBack
        '
        Me.BtnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnGoBack.Location = New System.Drawing.Point(15, 141)
        Me.BtnGoBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGoBack.Name = "BtnGoBack"
        Me.BtnGoBack.Size = New System.Drawing.Size(105, 30)
        Me.BtnGoBack.TabIndex = 21
        Me.BtnGoBack.Text = "Back"
        Me.BtnGoBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "IsActive?"
        '
        'RbtnInactive
        '
        Me.RbtnInactive.AutoSize = True
        Me.RbtnInactive.Location = New System.Drawing.Point(478, 111)
        Me.RbtnInactive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbtnInactive.Name = "RbtnInactive"
        Me.RbtnInactive.Size = New System.Drawing.Size(46, 20)
        Me.RbtnInactive.TabIndex = 19
        Me.RbtnInactive.Text = "No"
        Me.RbtnInactive.UseVisualStyleBackColor = True
        '
        'RbtnActive
        '
        Me.RbtnActive.AutoSize = True
        Me.RbtnActive.Checked = True
        Me.RbtnActive.Location = New System.Drawing.Point(421, 111)
        Me.RbtnActive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RbtnActive.Name = "RbtnActive"
        Me.RbtnActive.Size = New System.Drawing.Size(52, 20)
        Me.RbtnActive.TabIndex = 18
        Me.RbtnActive.TabStop = True
        Me.RbtnActive.Text = "Yes"
        Me.RbtnActive.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Location = New System.Drawing.Point(421, 141)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 30)
        Me.BtnAdd.TabIndex = 17
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEdit.Location = New System.Drawing.Point(310, 141)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(105, 30)
        Me.BtnEdit.TabIndex = 16
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(310, 141)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 30)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnStore
        '
        Me.BtnStore.Location = New System.Drawing.Point(423, 141)
        Me.BtnStore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStore.Name = "BtnStore"
        Me.BtnStore.Size = New System.Drawing.Size(105, 30)
        Me.BtnStore.TabIndex = 14
        Me.BtnStore.Text = "Store"
        Me.BtnStore.UseVisualStyleBackColor = True
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(15, 109)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 16)
        Me.lblRole.TabIndex = 13
        Me.lblRole.Text = "Role"
        '
        'txtRole
        '
        Me.txtRole.Location = New System.Drawing.Point(60, 107)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(264, 22)
        Me.txtRole.TabIndex = 12
        '
        'LvRoles
        '
        Me.LvRoles.DataSource = Me.RolesBindingSrc
        Me.LvRoles.DisplayMember = "RoleRolesName"
        Me.LvRoles.FormattingEnabled = True
        Me.LvRoles.ItemHeight = 16
        Me.LvRoles.Location = New System.Drawing.Point(15, 13)
        Me.LvRoles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LvRoles.Name = "LvRoles"
        Me.LvRoles.Size = New System.Drawing.Size(510, 84)
        Me.LvRoles.TabIndex = 11
        '
        'RolesBindingSrc
        '
        Me.RolesBindingSrc.DataSource = GetType(Internship.clsRoles)
        '
        'FrmAdmin
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnGoBack
        Me.ClientSize = New System.Drawing.Size(543, 515)
        Me.Controls.Add(Me.BtnGoBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbtnInactive)
        Me.Controls.Add(Me.RbtnActive)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnStore)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.LvRoles)
        Me.Name = "FrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAdmin"
        CType(Me.RolesBindingSrc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGoBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RbtnInactive As RadioButton
    Friend WithEvents RbtnActive As RadioButton
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnStore As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents LvRoles As ListBox
    Friend WithEvents RolesBindingSrc As BindingSource
End Class
