Imports MySql.Data.MySqlClient

Public Class FrmAdmin
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim isAdd As Boolean
    Dim isEdit As Boolean
    Public BeforeUpdateRole As String
    Public AddUpdateRole As String
    Dim chk1 As New CheckBox


    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            MdlCommon.GlobalVariablesReset()
            MdlCommon.connect()
            FillLvRoles()
            stopEditRole()

            'LvRoles.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try  'initialize

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim i As Integer
            Dim posTop As Integer = 150
            Dim posLeft As Integer = 20

            Dim cmdPermission As MySqlCommand
            Dim sqlPermission As String

            sqlPermission = "Select * from permissions"

            cmdPermission = New MySqlCommand(sqlPermission, conn)

            Dim adapter As New MySqlDataAdapter(cmdPermission)
            Dim table As New DataTable()
            adapter.Fill(table)

            Dim Permissioncount As Integer = table.Rows.Count

            MdlCommon.conn.Close()
            MdlCommon.connect()

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

                    If theIndex = 3 Then
                        posLeft = 20
                        posTop += 30
                        theIndex = 0
                    End If

                End While
            End If

            MdlCommon.conn.Close()
            MdlCommon.connect()



        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
        End Try  'add checkboxes

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
            AddHandler checkBox.CheckedChanged, AddressOf checkboxhandling
        Next

        'LvRoles.SelectedIndex = 0

        txtRoleFill()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If (Access("createRole")) Then
            EditRole()
            txtRole.Text = ""
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

        If Access("updateRole") Then
            EditRole()
            isAdd = False
            isEdit = True

            If Access("putPermission") Then
                For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
                    checkBox.Enabled = True
                Next
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        stopEditRole()
        txtRoleFill()
        isAdd = False
        isEdit = False

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
        Next

    End Sub

    Private Sub BtnStore_Click(sender As Object, e As EventArgs) Handles BtnStore.Click
        stopEditRole()

        Dim isactive As String
        Dim RolesID As String

        If RbtnActive.Checked Then
            isactive = "1"
        ElseIf RbtnInactive.Checked Then
            isactive = "0"
        End If

        MdlCommon.conn.Close()

        MdlCommon.connect()

        Try
            Dim thecmd As MySqlCommand
            Dim therdr As MySqlDataReader
            Dim thesql As String

            thesql = "select RolesID from roles where RoleName = '" + LvRoles.Text + "'"

            thecmd = New MySqlCommand(thesql, MdlCommon.conn)
            thecmd.CommandType = CommandType.Text
            therdr = thecmd.ExecuteReader()

            If (therdr.HasRows) Then
                While therdr.Read
                    RolesID = therdr.Item("RolesID")
                End While
            End If

            MdlCommon.conn.Close()

            MdlCommon.connect()
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()

            MdlCommon.connect()
        End Try 'get RolesID

        Try
            Dim thecommand As MySqlCommand
            Dim thereaderRole As MySqlDataReader
            Dim thesqlAddRole As String
            Dim thesqlEditRole As String

            BeforeUpdateRole = txtRole.Text

            If isAdd Then
                thesqlAddRole = "insert into roles (RoleName,Active) VALUES ('" + txtRole.Text + "'," + isactive + ")"

                thecommand = New MySqlCommand(thesqlAddRole, MdlCommon.conn)

                GlobalVariables.isAddRoleStored = True
                AddUpdateRole = txtRole.Text

            ElseIf isEdit Then
                thesqlEditRole = "Update roles set RoleName = '" + txtRole.Text + "',Active= " + isactive + " where RolesID = " + RolesID + ";"

                thecommand = New MySqlCommand(thesqlEditRole, MdlCommon.conn)

                GlobalVariables.isEditRoleStored = True

            End If

            thereaderRole = thecommand.ExecuteReader()
            MsgBox("Done!")

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try 'add/edit

        Try
            MdlCommon.connect()
            Dim thesqlAddPermissions As String
            Dim thereaderPermission As MySqlDataReader
            Dim thecommandPermission As MySqlCommand

            Dim cmdCheckPermissions As MySqlCommand
            Dim sqlCheckPermissions As String
            Dim storePermission

            Dim i As Integer = 1

            For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))

                sqlCheckPermissions = "select * from rolespermission where RolesID=" & RolesID & " and PermissionID=" & i & ""

                cmdCheckPermissions = New MySqlCommand(sqlCheckPermissions, conn)

                Dim adapter As New MySqlDataAdapter(cmdCheckPermissions)
                Dim table As New DataTable()

                adapter.Fill(table)

                storePermission = table.Rows.Count

                MdlCommon.conn.Close()
                MdlCommon.connect()

                If storePermission = 0 Then
                    If checkBox.Checked = True Then
                        thesqlAddPermissions = "insert into rolespermission (RolesID,PermissionID) VALUES (" & RolesID & "," & i & ")"
                        thecommandPermission = New MySqlCommand(thesqlAddPermissions, conn)
                        thereaderPermission = thecommandPermission.ExecuteReader()
                        MsgBox("Permission Inserted")
                    End If
                ElseIf storePermission > 0 Then
                    If checkBox.Checked = False Then
                        thesqlAddPermissions = "Delete From rolespermission where PermissionID=" & i & ""
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

        Try
            MdlCommon.connect()
            MdlHistory.fillLvHistory()
            FilllvRoles()
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try 'fill history & roles

        isAdd = False
        isEdit = False
        stopEditRole()
        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Enabled = False
        Next

    End Sub

    Private Sub LvRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvRoles.SelectedIndexChanged
        txtRoleFill()
    End Sub

    Public Sub txtRoleFill()

        For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))
            checkBox.Checked = False
        Next

        txtRole.Text = LvRoles.Text

        Dim storeRoleID As Integer

        Try

            Dim cmdRoleID As MySqlCommand
            Dim rdrRoleID As MySqlDataReader
            Dim sqlRoleID As String

            MdlCommon.connect()

            sqlRoleID = "select * from roles where RoleName='" + LvRoles.Text + "'"

            cmdRoleID = New MySqlCommand(sqlRoleID, MdlCommon.conn)
            cmdRoleID.CommandType = CommandType.Text
            rdrRoleID = cmdRoleID.ExecuteReader()

            If rdrRoleID.HasRows Then
                While rdrRoleID.Read
                    storeRoleID = rdrRoleID.Item("RolesID")
                End While
            End If
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get RoleID

        Try
            MdlCommon.connect()

            Dim cmdGetPermissions As MySqlCommand
            Dim rdrGetPermissions As MySqlDataReader
            Dim sqlGetPermissions As String

            Dim chkName As String

            sqlGetPermissions = "SELECT * FROM rolespermission rp join permissions p on p.PermissionID=rp.PermissionID where rp.RolesID=" & storeRoleID

            cmdGetPermissions = New MySqlCommand(sqlGetPermissions, conn)

            rdrGetPermissions = cmdGetPermissions.ExecuteReader()

            If rdrGetPermissions.HasRows Then
                While rdrGetPermissions.Read
                    chkName = "chk" & rdrGetPermissions.Item("Description")
                    Dim ctl1 As Control = Me.Controls.Find(chkName, True).FirstOrDefault

                    'For Each checkBox In Me.Controls.OfType(Of CheckBox)().Where(Function(cbx As CheckBox) cbx.Name.Contains("chk"))

                    If Not IsNothing(ctl1) AndAlso TypeOf (ctl1) Is CheckBox Then
                        Dim cb1 As Boolean = True
                        DirectCast(ctl1, CheckBox).Checked = cb1
                    End If

                    'Next


                End While
            End If

            MdlCommon.conn.Close()

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'check checkboxes code

    End Sub

    'Public Sub FillLvRoles()
    '    Try
    '        LvRoles.Items.Clear()

    '        Dim COMMAND As MySqlCommand
    '        Dim reader As MySqlDataReader
    '        Dim sql As String

    '        MdlCommon.connect()

    '        sql = "select * from roles"

    '        COMMAND = New MySqlCommand(sql, MdlCommon.conn)
    '        COMMAND.CommandType = CommandType.Text
    '        reader = COMMAND.ExecuteReader()

    '        If (reader.HasRows) Then
    '            While (reader.Read)
    '                LvRoles.Items.Add(reader.Item("RoleName"))
    '            End While
    '        End If

    '        MdlCommon.conn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        MdlCommon.conn.Close()
    '    End Try
    'End Sub

    Public Sub FilllvRoles()
        RolesBindingSrc.DataSource = Nothing
        RolesBindingSrc.DataSource = getRoles(False)
    End Sub

    Public Sub EditRole()
        BtnCancel.Show()
        BtnStore.Show()
        BtnEdit.Hide()
        BtnAdd.Hide()
        txtRole.ReadOnly = False
        LvRoles.Enabled = False
        RbtnActive.Enabled = True
        RbtnInactive.Enabled = True

        AcceptButton = BtnStore
        CancelButton = BtnCancel

    End Sub

    Public Sub stopEditRole()
        BtnCancel.Hide()
        BtnStore.Hide()
        BtnEdit.Show()
        BtnAdd.Show()
        txtRole.ReadOnly = True
        RbtnActive.Enabled = False
        RbtnInactive.Enabled = False
        LvRoles.Enabled = True

        AcceptButton = BtnAdd
        CancelButton = BtnGoBack

    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub checkboxhandling(sender As Object, e As EventArgs)
        Dim myCheckbox As CheckBox = DirectCast(sender, CheckBox)
        Dim c As Boolean = myCheckbox.Checked
    End Sub
End Class