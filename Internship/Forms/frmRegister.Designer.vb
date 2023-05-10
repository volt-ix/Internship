<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPermissions = New System.Windows.Forms.Label()
        Me.cmbPermissions = New System.Windows.Forms.ComboBox()
        Me.GvUsers = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblSystemPassword = New System.Windows.Forms.Label()
        Me.txtSystemPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserFName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserLName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserMailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserUsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSrc = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPermissions
        '
        Me.lblPermissions.AutoSize = True
        Me.lblPermissions.Location = New System.Drawing.Point(523, 445)
        Me.lblPermissions.Name = "lblPermissions"
        Me.lblPermissions.Size = New System.Drawing.Size(74, 16)
        Me.lblPermissions.TabIndex = 53
        Me.lblPermissions.Text = "Permission"
        '
        'cmbPermissions
        '
        Me.cmbPermissions.FormattingEnabled = True
        Me.cmbPermissions.Location = New System.Drawing.Point(623, 445)
        Me.cmbPermissions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPermissions.Name = "cmbPermissions"
        Me.cmbPermissions.Size = New System.Drawing.Size(348, 24)
        Me.cmbPermissions.TabIndex = 52
        '
        'GvUsers
        '
        Me.GvUsers.AllowUserToAddRows = False
        Me.GvUsers.AllowUserToDeleteRows = False
        Me.GvUsers.AutoGenerateColumns = False
        Me.GvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.UserMailDataGridViewTextBoxColumn, Me.UserUsernameDataGridViewTextBoxColumn, Me.Column1, Me.UserFName, Me.UserLName, Me.UserActive, Me.UserRoleID, Me.UserRoleName})
        Me.GvUsers.DataSource = Me.UsersBindingSrc
        Me.GvUsers.Location = New System.Drawing.Point(7, 9)
        Me.GvUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GvUsers.Name = "GvUsers"
        Me.GvUsers.ReadOnly = True
        Me.GvUsers.RowHeadersWidth = 51
        Me.GvUsers.RowTemplate.Height = 29
        Me.GvUsers.Size = New System.Drawing.Size(1128, 306)
        Me.GvUsers.TabIndex = 51
        '
        'BtnAdd
        '
        Me.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAdd.Location = New System.Drawing.Point(830, 477)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(136, 33)
        Me.BtnAdd.TabIndex = 50
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEdit.Location = New System.Drawing.Point(695, 477)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(129, 33)
        Me.BtnEdit.TabIndex = 49
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(556, 408)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 16)
        Me.lblRole.TabIndex = 48
        Me.lblRole.Text = "Role"
        '
        'cmbRoles
        '
        Me.cmbRoles.FormattingEnabled = True
        Me.cmbRoles.Location = New System.Drawing.Point(623, 405)
        Me.cmbRoles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Size = New System.Drawing.Size(348, 24)
        Me.cmbRoles.TabIndex = 47
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(977, 370)
        Me.chkShowPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(62, 20)
        Me.chkShowPassword.TabIndex = 46
        Me.chkShowPassword.Text = "Show"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'lblSystemPassword
        '
        Me.lblSystemPassword.AutoSize = True
        Me.lblSystemPassword.Location = New System.Drawing.Point(183, 485)
        Me.lblSystemPassword.Name = "lblSystemPassword"
        Me.lblSystemPassword.Size = New System.Drawing.Size(115, 16)
        Me.lblSystemPassword.TabIndex = 45
        Me.lblSystemPassword.Text = "System Password"
        '
        'txtSystemPassword
        '
        Me.txtSystemPassword.Location = New System.Drawing.Point(325, 485)
        Me.txtSystemPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSystemPassword.Name = "txtSystemPassword"
        Me.txtSystemPassword.Size = New System.Drawing.Size(348, 22)
        Me.txtSystemPassword.TabIndex = 44
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(623, 368)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(348, 22)
        Me.txtConfirmPassword.TabIndex = 43
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(623, 328)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(348, 22)
        Me.txtPassword.TabIndex = 42
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 445)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(348, 22)
        Me.txtEmail.TabIndex = 41
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(115, 405)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(348, 22)
        Me.txtUsername.TabIndex = 40
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLastName.Location = New System.Drawing.Point(115, 367)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(348, 22)
        Me.txtLastName.TabIndex = 39
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(115, 330)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(348, 22)
        Me.txtFirstName.TabIndex = 38
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(19, 405)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(70, 16)
        Me.lblUsername.TabIndex = 37
        Me.lblUsername.Text = "Username"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(695, 477)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(129, 33)
        Me.BtnCancel.TabIndex = 36
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(830, 477)
        Me.BtnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(136, 33)
        Me.BtnRegister.TabIndex = 35
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(475, 373)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(115, 16)
        Me.lblConfirmPassword.TabIndex = 34
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(532, 333)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblPassword.TabIndex = 33
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(48, 448)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "Email"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(15, 367)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(72, 16)
        Me.lblLastName.TabIndex = 31
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(14, 330)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(72, 16)
        Me.lblFirstName.TabIndex = 30
        Me.lblFirstName.Text = "First Name"
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(12, 477)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 33)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "UserUserID"
        Me.Column2.HeaderText = "UserID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "UserPass"
        Me.Column1.HeaderText = "UserPass"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'UserFName
        '
        Me.UserFName.DataPropertyName = "UserFName"
        Me.UserFName.HeaderText = "UserFName"
        Me.UserFName.MinimumWidth = 6
        Me.UserFName.Name = "UserFName"
        Me.UserFName.ReadOnly = True
        Me.UserFName.Width = 125
        '
        'UserLName
        '
        Me.UserLName.DataPropertyName = "UserLName"
        Me.UserLName.HeaderText = "UserLName"
        Me.UserLName.MinimumWidth = 6
        Me.UserLName.Name = "UserLName"
        Me.UserLName.ReadOnly = True
        Me.UserLName.Width = 125
        '
        'UserActive
        '
        Me.UserActive.DataPropertyName = "UserActive"
        Me.UserActive.HeaderText = "UserActive"
        Me.UserActive.MinimumWidth = 6
        Me.UserActive.Name = "UserActive"
        Me.UserActive.ReadOnly = True
        Me.UserActive.Width = 125
        '
        'UserRoleID
        '
        Me.UserRoleID.DataPropertyName = "UserRoleID"
        Me.UserRoleID.HeaderText = "UserRoleID"
        Me.UserRoleID.MinimumWidth = 6
        Me.UserRoleID.Name = "UserRoleID"
        Me.UserRoleID.ReadOnly = True
        Me.UserRoleID.Width = 125
        '
        'UserRoleName
        '
        Me.UserRoleName.DataPropertyName = "UserRoleName"
        Me.UserRoleName.HeaderText = "UserRoleName"
        Me.UserRoleName.MinimumWidth = 6
        Me.UserRoleName.Name = "UserRoleName"
        Me.UserRoleName.ReadOnly = True
        Me.UserRoleName.Width = 125
        '
        'UserMailDataGridViewTextBoxColumn
        '
        Me.UserMailDataGridViewTextBoxColumn.DataPropertyName = "UserMail"
        Me.UserMailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.UserMailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserMailDataGridViewTextBoxColumn.Name = "UserMailDataGridViewTextBoxColumn"
        Me.UserMailDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserMailDataGridViewTextBoxColumn.Width = 125
        '
        'UserUsernameDataGridViewTextBoxColumn
        '
        Me.UserUsernameDataGridViewTextBoxColumn.DataPropertyName = "UserUsername"
        Me.UserUsernameDataGridViewTextBoxColumn.HeaderText = "UserUsername"
        Me.UserUsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserUsernameDataGridViewTextBoxColumn.Name = "UserUsernameDataGridViewTextBoxColumn"
        Me.UserUsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserUsernameDataGridViewTextBoxColumn.Width = 125
        '
        'UsersBindingSrc
        '
        Me.UsersBindingSrc.DataSource = GetType(Internship.clsUsers)
        '
        'frmRegister
        '
        Me.AcceptButton = Me.BtnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1142, 699)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPermissions)
        Me.Controls.Add(Me.cmbPermissions)
        Me.Controls.Add(Me.GvUsers)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.cmbRoles)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.lblSystemPassword)
        Me.Controls.Add(Me.txtSystemPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "frmRegister"
        Me.Text = "frmRegister"
        CType(Me.GvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSrc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPermissions As Label
    Friend WithEvents cmbPermissions As ComboBox
    Friend WithEvents GvUsers As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRoles As ComboBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblSystemPassword As Label
    Friend WithEvents txtSystemPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents UsersBindingSrc As BindingSource
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents UserMailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserUsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents UserFName As DataGridViewTextBoxColumn
    Friend WithEvents UserLName As DataGridViewTextBoxColumn
    Friend WithEvents UserActive As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleID As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleName As DataGridViewTextBoxColumn
End Class
