<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.chkPassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCredential = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkPassword
        '
        Me.chkPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkPassword.AutoSize = True
        Me.chkPassword.Location = New System.Drawing.Point(384, 75)
        Me.chkPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Size = New System.Drawing.Size(122, 20)
        Me.chkPassword.TabIndex = 12
        Me.chkPassword.Text = "show password"
        Me.chkPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username or Email"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(165, 75)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(214, 22)
        Me.txtPassword.TabIndex = 10
        '
        'txtCredential
        '
        Me.txtCredential.Location = New System.Drawing.Point(165, 35)
        Me.txtCredential.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCredential.Name = "txtCredential"
        Me.txtCredential.Size = New System.Drawing.Size(341, 22)
        Me.txtCredential.TabIndex = 8
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(227, 109)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(152, 44)
        Me.BtnLogin.TabIndex = 11
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 171)
        Me.Controls.Add(Me.chkPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtCredential)
        Me.Controls.Add(Me.BtnLogin)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkPassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtCredential As TextBox
    Friend WithEvents BtnLogin As Button
End Class
