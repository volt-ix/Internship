Imports MySql.Data.MySqlClient

Module MdlCommon
    Public connectionstring As String = "server=localhost;userid=root;password='ak75fu2003@';database=internship1"
    Public conn As MySqlConnection
    Public Sub connect()
        conn = New MySqlConnection
        conn.ConnectionString = connectionstring

        Try
            conn.Open()
            'MessageBox.Show("connection to MySQL test database was successful!!!!", "TESTING      connECTION TO MySQL DATABASE")
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Public Class GlobalVariables
        Public Shared isLogin As Boolean
        Public Shared isAddRegistered As Boolean
        Public Shared isEditRegistered As Boolean
        Public Shared isAddRoleStored As Boolean
        Public Shared isEditRoleStored As Boolean
        Public Shared isAddProductStored As Boolean
        Public Shared isEditProductStored As Boolean
        Public Shared isAddPermissionStored As Boolean
        Public Shared isEditPermissionStored As Boolean
        Public Shared isMenuCreated As Boolean
        Public Shared isMenuEdited As Boolean
        Public Shared isQrCodeCreated As Boolean
        Public Shared isQrCodedownloaded As Boolean

    End Class

    Public Sub GlobalVariablesReset()
        GlobalVariables.isLogin = False
        GlobalVariables.isAddRegistered = False
        GlobalVariables.isEditRegistered = False
        GlobalVariables.isEditRoleStored = False
        GlobalVariables.isAddRoleStored = False
        GlobalVariables.isAddProductStored = False
        GlobalVariables.isEditProductStored = False
        GlobalVariables.isAddPermissionStored = False
        GlobalVariables.isEditPermissionStored = False
        GlobalVariables.isMenuCreated = False
        GlobalVariables.isMenuEdited = False
        GlobalVariables.isQrCodeCreated = False
        GlobalVariables.isQrCodedownloaded = False
    End Sub

    Public Sub HidePassword(chk As CheckBox, txt As TextBox)
        If chk.Checked Then
            txt.UseSystemPasswordChar = False
            Exit Sub
        ElseIf chk.Checked = False Then
            txt.UseSystemPasswordChar = True
            Exit Sub
        End If
    End Sub

    Public Sub countItems(sql As String, lbl As Label)
        Try
            Dim TheCmd As MySqlCommand
            Dim TheSql As String

            TheSql = sql

            TheCmd = New MySqlCommand(TheSql, MdlCommon.conn)

            Dim adapter As New MySqlDataAdapter(TheCmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            lbl.Text = table.Rows.Count
            MdlCommon.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try
    End Sub
    Public Sub countItemsInt(sql As String, num As Integer)
        Try
            Dim TheCmd As MySqlCommand
            Dim TheSql As String

            TheSql = sql

            TheCmd = New MySqlCommand(TheSql, MdlCommon.conn)

            Dim adapter As New MySqlDataAdapter(TheCmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            num = table.Rows.Count
            MdlCommon.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try
    End Sub

    Public Function Access(PermissionDesc As String)

        connect()

        Dim theCmdPermission As MySqlCommand
        Dim theRdrPermission As MySqlDataReader
        Dim theSqlPermission As String

        Dim PermissionID As Integer

        theSqlPermission = "SELECT PermissionID FROM permissions where Description = '" + PermissionDesc + "'"

        theCmdPermission = New MySqlCommand(theSqlPermission, conn)

        theRdrPermission = theCmdPermission.ExecuteReader()

        If theRdrPermission.HasRows Then
            While theRdrPermission.Read
                PermissionID = theRdrPermission.Item("PermissionID")
            End While
        End If

        conn.Close()

        connect()

        Dim theCmdAccess As MySqlCommand
        Dim theRdrAccess As MySqlDataReader
        Dim theSqlAccess As String

        theSqlAccess = "SELECT * 
                        FROM rolespermission rp
                        join permissions p 
                        on p.PermissionID=rp.PermissionID 
                        where rp.RolesID= " & frmLogin.TheRolesID

        theCmdAccess = New MySqlCommand(theSqlAccess, conn)

        theRdrAccess = theCmdAccess.ExecuteReader()

        If theRdrAccess.HasRows Then
            While theRdrAccess.Read
                If (PermissionID = theRdrAccess.Item("PermissionID")) Then
                    Return True
                End If
            End While
        End If

        conn.Close()

        connect()

        Dim cmdAccess As MySqlCommand
        Dim rdrAccess As MySqlDataReader
        Dim sqlAccess As String

        sqlAccess = "SELECT * FROM userpermission up join permissions p on p.PermissionID=up.PermissionID where up.UserID=" & frmLogin.TheUserID

        cmdAccess = New MySqlCommand(sqlAccess, conn)

        rdrAccess = cmdAccess.ExecuteReader()

        If rdrAccess.HasRows Then
            While rdrAccess.Read
                If (PermissionID = rdrAccess.Item("PermissionID")) Then
                    Return True
                End If
            End While
        End If

        conn.Close()


    End Function

    Public Sub FillCmb(sql As String, Item As String, cmb As ComboBox)
        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader
        Dim i As Integer = 1

        Try
            cmd = New MySqlCommand(sql, MdlCommon.conn)

            rdr = cmd.ExecuteReader()

            If rdr.HasRows Then
                While rdr.Read
                    cmb.Items.Add(rdr.Item(Item))
                    cmb.SelectedValue = i
                    i = i + 1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MdlCommon.conn.Close()

        cmb.SelectedIndex = 0

    End Sub

    Public Sub GetIDFromCmb(sql As String, ItemName As String, ItemID As String, cmb As ComboBox)
        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim cmd As MySqlCommand
        Dim rdr As MySqlDataReader

        Try
            cmd = New MySqlCommand(sql, MdlCommon.conn)

            rdr = cmd.ExecuteReader()

            If rdr.HasRows Then
                While rdr.Read
                    If cmb.Text = rdr.Item(ItemName) Then
                        FrmQrCode.TheID = rdr.Item(ItemID)
                    End If
                End While
            End If
        Catch ex As Exception

        End Try
    End Sub

End Module
