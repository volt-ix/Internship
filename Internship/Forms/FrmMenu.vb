Public Class FrmMenu
    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub BtnCreateUser_Click(sender As Object, e As EventArgs) Handles BtnCreateUser.Click

        If MdlCommon.Access("createUser") Then
            frmRegister.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If


    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        If MdlCommon.Access("createProduct") Then
            FrmProducts.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        If MdlCommon.Access("seeHistory") Then
            FrmHistory.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If
    End Sub

    Private Sub BtnPermissions_Click(sender As Object, e As EventArgs) Handles BtnPermissions.Click
        If MdlCommon.Access("putPermission") Then
            frmPermissions.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If
    End Sub

    Private Sub BtnManageRoles_Click(sender As Object, e As EventArgs) Handles BtnManageRoles.Click

        If MdlCommon.Access("createRole") Then
            FrmAdmin.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If

    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        If MdlCommon.Access("seeDashboard") Then
            FrmDashboard.Show()
            Me.Close()
        Else
            MsgBox("Access Denied")
        End If
    End Sub

    Private Sub btnProductsPage_Click(sender As Object, e As EventArgs) Handles btnProductsPage.Click
        frmProductsPage.Show()
        Me.Close()
    End Sub

    Private Sub btnQrCode_Click(sender As Object, e As EventArgs) Handles btnQrCode.Click
        FrmQrCode.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateMenu_Click(sender As Object, e As EventArgs) Handles btnCreateMenu.Click
        FrmMakeMenus.Show()
        Me.Close()
    End Sub
End Class