Imports MySql.Data.MySqlClient

Public Class frmRegister
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim isAdd As Boolean
    Dim isEdit As Boolean
    Public Shared beforeRegisterUsername As String
    Dim chk1 As New CheckBox

    Public Enum Users
        UserID
        Email
        Username
        Password
        Fname
        Lname
        Active
        RolesID
        RoleName
    End Enum

    Private Sub FrmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UsersBindingSrc.DataSource = Nothing
        UsersBindingSrc.DataSource = GetUsers(False)

        Try
            FillCmb(cmbRoles, "roles", "RoleName")
        Catch
        End Try
        Try
            FillCmb(cmbPermissions, "permissions", "Description")
        Catch
        End Try     'Fills

        MdlCommon.connect()

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
        txtSystemPassword.UseSystemPasswordChar = True
        txtSystemPassword.Hide()
        lblSystemPassword.Hide()

        StopEditUser()
        GvUsersClick()

        isAdd = False
        isEdit = False

        Try
            Try
                MdlCommon.conn.Close()
                MdlCommon.connect()

                Dim cmdPermission As MySqlCommand
                Dim sqlPermission As String

                sqlPermission = "Select * from permissions"

                cmdPermission = New MySqlCommand(sqlPermission, conn)

                Dim adapter As New MySqlDataAdapter(cmdPermission)
                Dim table As New DataTable()
                adapter.Fill(table)

                Dim Permissioncount As Integer = table.Rows.Count
            Catch ex As Exception

            End Try 'get rowCount of permissions

            Try
                MdlCommon.conn.Close()
                MdlCommon.connect()

                Dim i As Integer
                Dim posTop As Integer = 430
                Dim posLeft As Integer = 20

                Dim theCmdPermission As MySqlCommand
                Dim rdrPermission As MySqlDataReader
                Dim theSqlPermission As String

                theSqlPermission = "Select * from permissions"

                theCmdPermission = New MySqlCommand(theSqlPermission, conn)

                rdrPermission = theCmdPermission.ExecuteReader()

                Dim theIndex As Integer = 0

                If rdrPermission.HasRows Then
                    While rdrPermission.Read
                        chk1 = New CheckBox
                        Me.Controls.Add(chk1)
                        With chk1
                            .Top = posTop
                            .Left = posLeft
                            .Name = "chk" & rdrPermission.Item("Description")
                            .Text = rdrPermission.Item("Description")
                        End With
                        posLeft += 120
                        theIndex += 1

                        If theIndex = 6 Then
                            posLeft = 20
                            posTop += 30
                            theIndex = 0
                        End If

                    End While
                End If
            Catch ex As Exception

            End Try 'checkboxes code

            MdlCommon.conn.Close()

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try  'add checkboxes

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
            AddHandler checkBox.CheckedChanged, AddressOf checkboxhandling
        Next

        Try
            MdlCommon.GlobalVariablesReset()
        Catch
        End Try
    End Sub
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click

        If txtFirstName.Text = "" Then
            txtFirstName.Focus()
            MsgBox("Enter First Name")
            Exit Sub
        End If
        If txtLastName.Text = "" Then
            txtLastName.Focus()
            MsgBox("Enter Last Name")
            Exit Sub
        End If
        If txtUsername.Text = "" Then
            txtUsername.Focus()
            MsgBox("Enter Username")
            Exit Sub
        End If
        If txtEmail.Text = "" Then
            txtEmail.Focus()
            MsgBox("Enter Email Name")
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            txtPassword.Focus()
            MsgBox("Enter Password Name")
            Exit Sub
        End If
        If txtConfirmPassword.Text = "" Then
            txtConfirmPassword.Focus()
            MsgBox("Confirm Password")
            Exit Sub
        End If
        If (txtPassword.Text = txtConfirmPassword.Text) Then
            'continue
        Else
            MsgBox("Confirm Password does not match with your password!")
        End If

        If txtSystemPassword.Text = "" Then
            MsgBox("System password required: ")
            lblSystemPassword.Show()
            txtSystemPassword.Show()
            Exit Sub
        End If

        Try
            cmd = New MySqlCommand("select * from systempasswords where SystemPasswordID = 1", conn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()
            If (rdr.HasRows) Then
                While rdr.Read
                    Dim adminPasswordCheck As String = rdr.Item("AdminPassword")

                    If txtSystemPassword.Text = adminPasswordCheck Then
                        'continue
                    Else
                        MsgBox("wrong admin password, please type again!")
                        Exit Sub
                    End If

                End While
            End If

            MdlCommon.conn.Close()
            connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            connect()
            MsgBox(ex.Message)
        End Try 'admin password check

        Dim UserID As String
        Dim thecmd As MySqlCommand
        Dim therdr As MySqlDataReader
        Dim thesql As String

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            thesql = "select ID from users where Username = '" + txtUsername.Text + "'"

            thecmd = New MySqlCommand(thesql, conn)
            thecmd.CommandType = CommandType.Text
            therdr = thecmd.ExecuteReader()

            If (therdr.HasRows) Then
                While therdr.Read
                    UserID = therdr.Item("ID")
                End While
            End If

            MdlCommon.conn.Close()
            connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            connect()
            MsgBox(ex.Message)
        End Try 'get UserID

        Dim RolesID As String
        Dim thecmdRoles As MySqlCommand
        Dim therdrRoles As MySqlDataReader
        Dim thesqlRoles As String

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            thesqlRoles = "select RolesID from roles where RoleName = '" + cmbRoles.Text + "'"

            thecmdRoles = New MySqlCommand(thesqlRoles, conn)
            thecmdRoles.CommandType = CommandType.Text
            therdrRoles = thecmdRoles.ExecuteReader()

            If (therdrRoles.HasRows) Then
                While therdrRoles.Read
                    RolesID = therdrRoles.Item("RolesID")
                End While
            End If

            MdlCommon.conn.Close()
            connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            connect()
            MsgBox(ex.Message)
        End Try 'get RolesID

        Dim PermissionsID As String
        Dim thecmdPermissions As MySqlCommand
        Dim therdrPermissions As MySqlDataReader
        Dim thesqlPermissions As String

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            thesqlPermissions = "select PermissionID from permissions where Description = '" + cmbPermissions.Text + "'"

            thecmdPermissions = New MySqlCommand(thesqlPermissions, conn)
            thecmdPermissions.CommandType = CommandType.Text
            therdrPermissions = thecmdPermissions.ExecuteReader()

            If (therdrPermissions.HasRows) Then
                While therdrPermissions.Read
                    PermissionsID = therdrPermissions.Item("PermissionID")
                End While
            End If

            MdlCommon.conn.Close()
            connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            connect()
            MsgBox(ex.Message)
        End Try 'get PermissionID

        Dim cmd2 As MySqlCommand
        Dim rdr2 As MySqlDataReader

        beforeRegisterUsername = txtUsername.Text

        If (isAdd) Then
            Try
                cmd2 = New MySqlCommand("INSERT INTO Users (Email, Username, Password, Fname, Lname,Active,RolesID,PermissionID)
                                VALUES ('" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "',
                                '" + txtLastName.Text + "', 1," + RolesID + "," + PermissionsID + ");", conn)
                GlobalVariables.isAddRegistered = True
                GlobalVariables.isEditRegistered = False

            Catch ex As Exception

            End Try
        ElseIf (isEdit) Then
            Dim rowIndex As Integer = GvUsers.CurrentRow.Index
            Dim TheUserID As String
            Try
                TheUserID = GvUsers.Item(Users.UserID, rowIndex).Value

                cmd2 = New MySqlCommand("update Users set Email = '" + txtEmail.Text + "',Username='" + txtUsername.Text + "',Password='" + txtPassword.Text + "',Fname='" + txtFirstName.Text + "'
                                       ,Lname='" + txtLastName.Text + "',Active = 1,RolesID =" + RolesID + ",PermissionID =" + PermissionsID + "  where ID = " + TheUserID + ";", conn)

                GlobalVariables.isEditRegistered = True
                GlobalVariables.isAddRegistered = False

            Catch ex As Exception

            End Try
        End If

        Try
            rdr2 = cmd2.ExecuteReader()
            MsgBox("Register complete")
            MdlCommon.conn.Close()

            MdlCommon.connect()
            MdlHistory.fillLvHistory()
            MdlCommon.conn.Close()

            Me.Hide()
            frmLogin.Show()
        Catch ex As Exception
            MsgBox("there is already an account with this username or email")
            MdlCommon.conn.Close()
            Exit Sub
        End Try

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim thesqlAddPermissions As String
            Dim thereaderPermission As MySqlDataReader
            Dim thecommandPermission As MySqlCommand

            Dim cmdCheckPermissions As MySqlCommand
            Dim sqlCheckPermissions As String
            Dim storePermission

            Dim i As Integer = 1

            For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))

                sqlCheckPermissions = "select * from userpermission where UserID=" & UserID & " and PermissionID=" & i & ""

                cmdCheckPermissions = New MySqlCommand(sqlCheckPermissions, conn)

                Dim adapter As New MySqlDataAdapter(cmdCheckPermissions)
                Dim table As New DataTable()

                adapter.Fill(table)

                storePermission = table.Rows.Count

                MdlCommon.conn.Close()
                MdlCommon.connect()

                If storePermission = 0 Then
                    If checkBox.Checked = True Then
                        thesqlAddPermissions = "insert into userpermission (UserID,PermissionID) VALUES (" & UserID & "," & i & ")"
                        thecommandPermission = New MySqlCommand(thesqlAddPermissions, conn)
                        thereaderPermission = thecommandPermission.ExecuteReader()
                        MsgBox("Permission Inserted")
                    End If
                ElseIf storePermission > 0 Then
                    If checkBox.Checked = False Then
                        thesqlAddPermissions = "Delete From userpermission where PermissionID=" & i & ""
                        thecommandPermission = New MySqlCommand(thesqlAddPermissions, conn)
                        thereaderPermission = thecommandPermission.ExecuteReader()
                        MsgBox("Permission Deleted")
                    End If
                End If

                MdlCommon.conn.Close()
                MdlCommon.connect()

                i += 1
            Next

        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
        End Try 'add permissions

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
        Next

        isAdd = False
        isEdit = False
        StopEditUser()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        StopEditUser()
        GvUsersClick()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Access("createUser") Then
            EditUser()
            txtEmail.Text = ""
            txtFirstName.Text = ""
            txtLastName.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""
            txtUsername.Text = ""
            cmbRoles.SelectedIndex = 0
            cmbPermissions.SelectedIndex = 0
            isAdd = True
            isEdit = False
            If Access("putPermission") Then
                For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
                    checkBox.Enabled = True
                Next
            End If
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Access("updateUser") Then
            EditUser()
            isAdd = False
            isEdit = True

        End If
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs)
        FrmMenu.Show()
        Me.Close()
    End Sub

    Public Sub GvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GvUsers.CellContentClick
        GvUsersClick()
    End Sub
    Public Sub GvUsersClick()
        If GvUsers.RowCount = 0 Then
            Exit Sub
        End If
        Dim rowIndex As Integer = GvUsers.CurrentRow.Index

        Try
            txtUsername.Text = GvUsers.Item(Users.Username, rowIndex).Value
            txtFirstName.Text = GvUsers.Item(Users.Fname, rowIndex).Value
            txtLastName.Text = GvUsers.Item(Users.Lname, rowIndex).Value
            txtEmail.Text = GvUsers.Item(Users.Email, rowIndex).Value
            txtPassword.Text = GvUsers.Item(Users.Password, rowIndex).Value
            txtConfirmPassword.Text = GvUsers.Item(Users.Password, rowIndex).Value
        Catch ex As Exception

        End Try

        If (GvUsers.Item(Users.RolesID, rowIndex).Value = 1) Then
            cmbRoles.SelectedIndex = 0
        ElseIf (GvUsers.Item(Users.RolesID, rowIndex).Value = 2) Then
            cmbRoles.SelectedIndex = 1
        End If

        Dim storeUserID As Integer

        Try
            For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
                checkBox.Checked = False
            Next

            Dim cmdUserID As MySqlCommand
            Dim rdrUserID As MySqlDataReader
            Dim sqlUserID As String

            MdlCommon.conn.Close()
            MdlCommon.connect()


            sqlUserID = "select * from users where Username='" + txtUsername.Text + "'"

            cmdUserID = New MySqlCommand(sqlUserID, MdlCommon.conn)
            cmdUserID.CommandType = CommandType.Text
            rdrUserID = cmdUserID.ExecuteReader()

            If rdrUserID.HasRows Then
                While rdrUserID.Read
                    storeUserID = rdrUserID.Item("ID")
                End While
            End If
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get UserID

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()


            Dim cmdGetPermissions As MySqlCommand
            Dim rdrGetPermissions As MySqlDataReader
            Dim sqlGetPermissions As String

            Dim chkName As String

            sqlGetPermissions = "SELECT * FROM userpermission up join permissions p on p.PermissionID=up.PermissionID where up.UserID=" & storeUserID

            cmdGetPermissions = New MySqlCommand(sqlGetPermissions, conn)

            rdrGetPermissions = cmdGetPermissions.ExecuteReader()

            If rdrGetPermissions.HasRows Then
                While rdrGetPermissions.Read
                    chkName = "chk" & rdrGetPermissions.Item("Description")
                    Dim ctl1 As Control = Me.Controls.Find(chkName, True).FirstOrDefault

                    If Not IsNothing(ctl1) AndAlso TypeOf (ctl1) Is CheckBox Then
                        Dim cb1 As Boolean = True
                        DirectCast(ctl1, CheckBox).Checked = cb1
                    End If


                End While
            End If

            MdlCommon.conn.Close()

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'check checkboxes code

    End Sub

    Public Sub FillCmb(cmb As ComboBox, TableName As String, Item As String)
        Dim COMMAND As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql As String

        Try
            connect()

            sql = "select * from " + TableName + ""

            COMMAND = New MySqlCommand(sql, conn)
            COMMAND.CommandType = CommandType.Text
            reader = COMMAND.ExecuteReader()

            If (reader.HasRows) Then
                While (reader.Read)
                    cmb.Items.Add(reader.Item(Item))
                End While
            End If

            conn.Close()
            cmb.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub EditUser()
        BtnCancel.Show()
        BtnRegister.Show()
        BtnEdit.Hide()
        BtnAdd.Hide()
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtPassword.ReadOnly = False
        txtUsername.ReadOnly = False
        txtEmail.ReadOnly = False
        txtConfirmPassword.ReadOnly = False
        cmbRoles.Enabled = True
        cmbPermissions.Enabled = True
        GvUsers.Enabled = False

        If (Access("putPermission")) Then
            For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
                checkBox.Enabled = True
            Next
        End If

        AcceptButton = BtnRegister
        CancelButton = BtnCancel

    End Sub

    Public Sub StopEditUser()
        BtnCancel.Hide()
        BtnRegister.Hide()
        BtnEdit.Show()
        BtnAdd.Show()
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtPassword.ReadOnly = True
        txtUsername.ReadOnly = True
        txtEmail.ReadOnly = True
        txtConfirmPassword.ReadOnly = True
        cmbRoles.Enabled = False
        cmbPermissions.Enabled = False
        GvUsers.Enabled = True

        AcceptButton = BtnAdd
        CancelButton = btnBack

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
        Next

    End Sub

    'Public Sub FillGvUsers()

    '    MdlCommon.conn.Close()
    '    MdlCommon.connect()


    '    GvUsers.Rows.Clear()

    '    GvUsers.ColumnCount = 9

    '    GvUsers.Columns(Users.UserID).Width = 30
    '    GvUsers.Columns(Users.Email).Width = 200
    '    GvUsers.Columns(Users.Username).Width = 90
    '    GvUsers.Columns(Users.Password).Width = 100
    '    GvUsers.Columns(Users.Fname).Width = 100
    '    GvUsers.Columns(Users.Lname).Width = 100
    '    GvUsers.Columns(Users.Active).Width = 50
    '    GvUsers.Columns(Users.RolesID).Width = 50
    '    GvUsers.Columns(Users.PermissionID).Width = 100

    '    Dim TheCommand As MySqlCommand
    '    Dim thereader As MySqlDataReader
    '    Dim thesql As String = "select * from users"

    '    Try
    '        TheCommand = New MySqlCommand(thesql, conn)
    '        TheCommand.CommandType = CommandType.Text
    '        thereader = TheCommand.ExecuteReader()

    '        GvUsers.Columns(Users.UserID).Name = thereader.GetName(Users.UserID)
    '        GvUsers.Columns(Users.Email).Name = thereader.GetName(Users.Email)
    '        GvUsers.Columns(Users.Username).Name = thereader.GetName(Users.Username)
    '        GvUsers.Columns(Users.Password).Name = thereader.GetName(Users.Password)
    '        GvUsers.Columns(Users.Fname).Name = thereader.GetName(Users.Fname)
    '        GvUsers.Columns(Users.Lname).Name = thereader.GetName(Users.Lname)
    '        GvUsers.Columns(Users.Active).Name = thereader.GetName(Users.Active)
    '        GvUsers.Columns(Users.RolesID).Name = thereader.GetName(Users.RolesID)
    '        GvUsers.Columns(Users.PermissionID).Name = thereader.GetName(Users.PermissionID)

    '        If (thereader.HasRows) Then
    '            While thereader.Read
    '                Dim row As ArrayList = New ArrayList
    '                row.Add(thereader.Item("ID"))
    '                row.Add(thereader.Item("Email"))
    '                row.Add(thereader.Item("Username"))
    '                row.Add(thereader.Item("Password"))
    '                row.Add(thereader.Item("FName"))
    '                row.Add(thereader.Item("LName"))
    '                row.Add(thereader.Item("Active"))
    '                row.Add(thereader.Item("RolesID"))
    '                row.Add(thereader.Item("PermissionID"))

    '                GvUsers.Rows.Add(row.ToArray())
    '            End While
    '        End If
    '        MdlCommon.conn.Close()

    '    Catch ex As Exception
    '        MdlCommon.conn.Close()

    '        MsgBox(ex.Message)
    '    End Try 'Fill


    'End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        MdlCommon.HidePassword(chkShowPassword, txtPassword)
        MdlCommon.HidePassword(chkShowPassword, txtConfirmPassword)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub checkboxhandling(sender As Object, e As EventArgs)
        Dim myCheckbox As CheckBox = DirectCast(sender, CheckBox)
        Dim c As Boolean = myCheckbox.Checked
    End Sub
End Class