Imports MySql.Data.MySqlClient

Module MdlHistory
    Public Historycmd As MySqlCommand
    Public Historyrdr As MySqlDataReader
    Public Historysql As String
    Public person As String
    Public Historycmd2 As MySqlCommand
    Public Historyrdr2 As MySqlDataReader
    Public Historysql2 As String

    Public Sub fillLvHistory()

        person = Internship.frmLogin.txtCredential.Text

        If GlobalVariables.isLogin Then
            Historysql = "Insert into History (HistoryLog) VALUES ('" + person + " logged in')"
        ElseIf GlobalVariables.isAddRegistered Then
            Historysql = "Insert into History (HistoryLog) VALUES ('" + Internship.frmRegister.beforeRegisterUsername + " Registered')"
        ElseIf GlobalVariables.isEditRegistered Then
            Historysql = "Insert into History (HistoryLog) VALUES ('An Admin Edited a User: " + Internship.frmRegister.beforeRegisterUsername + "')"
        ElseIf GlobalVariables.isAddRoleStored Then
            Historysql = "Insert into History (HistoryLog) VALUES ('New Role " + Internship.FrmAdmin.AddUpdateRole + "')"
        ElseIf GlobalVariables.isEditRoleStored Then
            Historysql = "Insert into History (HistoryLog) VALUES ('" + person + " Edited a role " + Internship.FrmAdmin.BeforeUpdateRole + "')"
        ElseIf GlobalVariables.isAddProductStored Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Added a Product: " + Internship.FrmProducts.beforeProductUpdate + "')"
        ElseIf GlobalVariables.isEditProductStored Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Edited a Product: " + Internship.FrmProducts.beforeProductUpdate + "')"
        ElseIf GlobalVariables.isAddPermissionStored Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Added a Product: " + Internship.frmPermissions.BeforeUpdatePermission + "')"
        ElseIf GlobalVariables.isEditPermissionStored Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Edited a Product: " + Internship.frmPermissions.BeforeUpdatePermission + "')"
        ElseIf GlobalVariables.isMenuCreated Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Created a Menu: " + Internship.FrmMakeMenus.CreatedMenuName + "')"
        ElseIf GlobalVariables.isMenuEdited Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Edited a Menu: " + Internship.FrmMakeMenus.CreatedMenuName + "')"
        ElseIf GlobalVariables.isQrCodeCreated Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Created a QrCode for The Menu: " + Internship.FrmQrCode.cmbMenus.Text + "')"
        ElseIf GlobalVariables.isQrCodedownloaded Then
            Historysql = "Insert into History (HistoryLog) VALUES('" + person + " Downloaded a QrCode for The Menu: " + Internship.FrmQrCode.cmbMenus.Text + "')"
        End If

        Historycmd = New MySqlCommand(Historysql, MdlCommon.conn)
        Historyrdr = Historycmd.ExecuteReader()

        'internship1.FrmHistory.LvHistory

    End Sub

    Public Sub fillTheLvHistory()

        Historysql2 = "select HistoryLog,HistoryID from History Order By HistoryID DESC"

        Historycmd2 = New MySqlCommand(Historysql2, MdlCommon.conn)
        Historyrdr2 = Historycmd2.ExecuteReader()

        If Historyrdr2.HasRows Then
            While Historyrdr2.Read
                FrmHistory.LvHistory.Items.Add(Historyrdr2.Item("HistoryLog"))
            End While
        End If

    End Sub
End Module
