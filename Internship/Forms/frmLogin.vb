Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim cmd As MySqlCommand
    Public Shared TheRolesID As Integer
    Public Shared TheUserID As Integer

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            MdlCommon.GlobalVariablesReset()
            MdlCommon.connect()
            txtPassword.UseSystemPasswordChar = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try 'initialization

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        MdlCommon.conn.Close()
        MdlCommon.connect()

        If txtCredential.Text = "" Then
            MsgBox("Enter username or email")
            txtCredential.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Then
            MsgBox("enter password")
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            Dim thecmd As MySqlCommand
            Dim therdr As MySqlDataReader
            Dim thesql As String

            thesql = "select Active from users where Username='" + txtCredential.Text + "' or Email='" + txtCredential.Text + "'"

            thecmd = New MySqlCommand(thesql, MdlCommon.conn)
            therdr = thecmd.ExecuteReader()

            Dim isactive As Boolean

            If (therdr.HasRows()) Then
                While therdr.Read
                    isactive = therdr.Item("Active")
                End While
            End If

            If isactive Then
                'continue
            Else
                MsgBox("No user found")
                Exit Sub
            End If

            MdlCommon.conn.Close()
            MdlCommon.connect()

        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
            MsgBox(ex.Message)

        End Try   'check if user is active

        Try
            cmd = New MySqlCommand("select * from users where (Username='" + txtCredential.Text + "' or Email='" + txtCredential.Text + "') 
                                and Password = '" + txtPassword.Text + "' and Active = 1", MdlCommon.conn)
            cmd.Connection = MdlCommon.conn

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            If (table.Rows.Count = 0) Then
                MessageBox.Show("Invalid Username Or Password")
                Exit Sub
            Else
                MessageBox.Show("Logged In")
            End If

            MdlCommon.conn.Close()
            MdlCommon.connect()

        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
            MsgBox(ex.Message)

        End Try   'Login

        Try
            Dim CommandAdmin As MySqlCommand
            Dim ReaderAdmin As MySqlDataReader
            Dim SqlAdmin As String

            SqlAdmin = "select RolesID,ID from users where (Username='" + txtCredential.Text + "' or Email='" + txtCredential.Text + "')"

            CommandAdmin = New MySqlCommand(SqlAdmin, MdlCommon.conn)
            ReaderAdmin = CommandAdmin.ExecuteReader()


            If ReaderAdmin.HasRows Then
                While ReaderAdmin.Read()
                    TheRolesID = ReaderAdmin.Item("RolesID")
                    TheUserID = ReaderAdmin.Item("ID")
                End While

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try   'get roleID and UserID

        GlobalVariables.isLogin = True
        MdlCommon.conn.Close()

        Try
            MdlCommon.connect()
            MdlHistory.fillLvHistory()
            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try   'fill history

        FrmMenu.Show()
        Me.Hide()

    End Sub

    Private Sub LkLblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        frmRegister.Show()
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        MdlCommon.HidePassword(chkPassword, txtPassword)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
