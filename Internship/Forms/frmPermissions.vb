Imports System.Security.Permissions
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Public Class frmPermissions

    Public Shared BeforeUpdatePermission As String
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim isAdd As Boolean
    Dim isEdit As Boolean
    Public Sub FillLvPermissions()
        Try
            LvPermissions.Items.Clear()

            Dim COMMAND As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            MdlCommon.connect()

            sql = "select * from permissions"

            COMMAND = New MySqlCommand(sql, MdlCommon.conn)
            COMMAND.CommandType = CommandType.Text
            reader = COMMAND.ExecuteReader()

            If (reader.HasRows) Then
                While (reader.Read)
                    LvPermissions.Items.Add(reader.Item("Description"))
                End While
            End If

            MdlCommon.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try
    End Sub

    Public Sub txtPermissionFill()
        txtPermissions.Text = LvPermissions.Text
    End Sub

    Public Sub EditPermission()
        BtnCancel.Show()
        BtnStore.Show()
        BtnEdit.Hide()
        BtnAdd.Hide()
        txtPermissions.ReadOnly = False
        LvPermissions.Enabled = False
    End Sub

    Public Sub stopEditPermission()
        BtnCancel.Hide()
        BtnStore.Hide()
        BtnEdit.Show()
        BtnAdd.Show()
        txtPermissions.ReadOnly = True
        LvPermissions.Enabled = True
    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub LvPermissions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvPermissions.SelectedIndexChanged
        txtPermissionFill()

        Dim storePermissionID As Integer

        Try

            Dim cmdPermissionID As MySqlCommand
            Dim rdrPermissionID As MySqlDataReader
            Dim sqlPermissionID As String

            MdlCommon.connect()

            sqlPermissionID = "select * from permissions where Description='" + LvPermissions.Text + "'"

            cmdPermissionID = New MySqlCommand(sqlPermissionID, MdlCommon.conn)
            cmdPermissionID.CommandType = CommandType.Text
            rdrPermissionID = cmdPermissionID.ExecuteReader()

            If rdrPermissionID.HasRows Then
                While rdrPermissionID.Read
                    storePermissionID = rdrPermissionID.Item("PermissionID")
                End While
            End If
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get PermissionID

    End Sub

    Private Sub BtnStore_Click(sender As Object, e As EventArgs) Handles BtnStore.Click
        stopEditPermission()

        Dim isactive As String
        Dim storePermissionID As Integer

        MdlCommon.conn.Close()

        MdlCommon.connect()

        Try

            Dim cmdPermissionID As MySqlCommand
            Dim rdrPermissionID As MySqlDataReader
            Dim sqlPermissionID As String

            MdlCommon.connect()

            sqlPermissionID = "select * from permissions where Description='" + LvPermissions.Text + "'"

            cmdPermissionID = New MySqlCommand(sqlPermissionID, MdlCommon.conn)
            cmdPermissionID.CommandType = CommandType.Text
            rdrPermissionID = cmdPermissionID.ExecuteReader()

            If rdrPermissionID.HasRows Then
                While rdrPermissionID.Read
                    storePermissionID = rdrPermissionID.Item("PermissionID")
                End While
            End If
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get PermissionID

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim thecommand As MySqlCommand
            Dim thereaderPermission As MySqlDataReader
            Dim thesqlAddPermission As String
            Dim thesqlEditPermission As String

            BeforeUpdatePermission = txtPermissions.Text

            If isAdd Then
                thesqlAddPermission = "insert into permissions (Description) VALUES ('" + txtPermissions.Text + "')"

                thecommand = New MySqlCommand(thesqlAddPermission, MdlCommon.conn)

                GlobalVariables.isAddPermissionStored = True

            ElseIf isEdit Then
                thesqlEditPermission = "Update permissions set Description = '" + txtPermissions.Text + "' where PermissionID = " & storePermissionID & ";"

                thecommand = New MySqlCommand(thesqlEditPermission, MdlCommon.conn)

                GlobalVariables.isEditPermissionStored = True

            End If

            thereaderPermission = thecommand.ExecuteReader()
            MsgBox("Done!")

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try 'add/edit Permission

        Try
            MdlCommon.connect()
            MdlHistory.fillLvHistory()
            FillLvPermissions()
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try 'fill history & roles

        isAdd = False
        isEdit = False
        stopEditPermission()
    End Sub

    Private Sub frmPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdlCommon.GlobalVariablesReset()
            MdlCommon.connect()
            FillLvPermissions()
            stopEditPermission()

            LvPermissions.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try  'initialize
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If (Access("putPermission")) Then
            EditPermission()
            txtPermissions.Text = ""
            isAdd = True
            isEdit = False
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If Access("putPermission") Then
            EditPermission()
            isAdd = False
            isEdit = True
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        stopEditPermission()
        txtPermissionFill()
        isAdd = False
        isEdit = False

    End Sub
End Class