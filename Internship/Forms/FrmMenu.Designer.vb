<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnManageRoles = New System.Windows.Forms.Button()
        Me.BtnPermissions = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnCreateUser = New System.Windows.Forms.Button()
        Me.btnProductsPage = New System.Windows.Forms.Button()
        Me.btnQrCode = New System.Windows.Forms.Button()
        Me.btnCreateMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLogOut.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLogOut.Location = New System.Drawing.Point(210, 775)
        Me.BtnLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(136, 36)
        Me.BtnLogOut.TabIndex = 12
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnDashboard.Location = New System.Drawing.Point(7, 520)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(537, 81)
        Me.BtnDashboard.TabIndex = 10
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'BtnManageRoles
        '
        Me.BtnManageRoles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnManageRoles.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnManageRoles.Location = New System.Drawing.Point(7, 93)
        Me.BtnManageRoles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnManageRoles.Name = "BtnManageRoles"
        Me.BtnManageRoles.Size = New System.Drawing.Size(537, 81)
        Me.BtnManageRoles.TabIndex = 11
        Me.BtnManageRoles.Text = "Manage Roles"
        Me.BtnManageRoles.UseVisualStyleBackColor = True
        '
        'BtnPermissions
        '
        Me.BtnPermissions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPermissions.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnPermissions.Location = New System.Drawing.Point(7, 178)
        Me.BtnPermissions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnPermissions.Name = "BtnPermissions"
        Me.BtnPermissions.Size = New System.Drawing.Size(537, 81)
        Me.BtnPermissions.TabIndex = 9
        Me.BtnPermissions.Text = "Create Permissions"
        Me.BtnPermissions.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHistory.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnHistory.Location = New System.Drawing.Point(7, 435)
        Me.BtnHistory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(537, 81)
        Me.BtnHistory.TabIndex = 8
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnProducts
        '
        Me.BtnProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProducts.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnProducts.Location = New System.Drawing.Point(7, 263)
        Me.BtnProducts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(537, 81)
        Me.BtnProducts.TabIndex = 7
        Me.BtnProducts.Text = "Manage Products"
        Me.BtnProducts.UseVisualStyleBackColor = True
        '
        'BtnCreateUser
        '
        Me.BtnCreateUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateUser.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.BtnCreateUser.Location = New System.Drawing.Point(7, 8)
        Me.BtnCreateUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCreateUser.Name = "BtnCreateUser"
        Me.BtnCreateUser.Size = New System.Drawing.Size(537, 81)
        Me.BtnCreateUser.TabIndex = 6
        Me.BtnCreateUser.Text = "Create User"
        Me.BtnCreateUser.UseVisualStyleBackColor = True
        '
        'btnProductsPage
        '
        Me.btnProductsPage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProductsPage.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.btnProductsPage.Location = New System.Drawing.Point(7, 350)
        Me.btnProductsPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProductsPage.Name = "btnProductsPage"
        Me.btnProductsPage.Size = New System.Drawing.Size(537, 81)
        Me.btnProductsPage.TabIndex = 7
        Me.btnProductsPage.Text = "Products Page"
        Me.btnProductsPage.UseVisualStyleBackColor = True
        '
        'btnQrCode
        '
        Me.btnQrCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQrCode.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.btnQrCode.Location = New System.Drawing.Point(7, 605)
        Me.btnQrCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQrCode.Name = "btnQrCode"
        Me.btnQrCode.Size = New System.Drawing.Size(537, 81)
        Me.btnQrCode.TabIndex = 10
        Me.btnQrCode.Text = "Create Qr Code"
        Me.btnQrCode.UseVisualStyleBackColor = True
        '
        'btnCreateMenu
        '
        Me.btnCreateMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateMenu.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.btnCreateMenu.Location = New System.Drawing.Point(7, 690)
        Me.btnCreateMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateMenu.Name = "btnCreateMenu"
        Me.btnCreateMenu.Size = New System.Drawing.Size(537, 81)
        Me.btnCreateMenu.TabIndex = 10
        Me.btnCreateMenu.Text = "Create Menu"
        Me.btnCreateMenu.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 816)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.btnCreateMenu)
        Me.Controls.Add(Me.btnQrCode)
        Me.Controls.Add(Me.BtnDashboard)
        Me.Controls.Add(Me.BtnManageRoles)
        Me.Controls.Add(Me.BtnPermissions)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.btnProductsPage)
        Me.Controls.Add(Me.BtnProducts)
        Me.Controls.Add(Me.BtnCreateUser)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogOut As Button
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnManageRoles As Button
    Friend WithEvents BtnPermissions As Button
    Friend WithEvents BtnHistory As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnCreateUser As Button
    Friend WithEvents btnProductsPage As Button
    Friend WithEvents btnQrCode As Button
    Friend WithEvents btnCreateMenu As Button
End Class
