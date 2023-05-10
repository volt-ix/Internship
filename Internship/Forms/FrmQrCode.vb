Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient

Public Class FrmQrCode
    Public Shared TheID As Integer
    Dim domainName As String
    Public Shared MenuName As String
    Private Sub FrmQrCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb("select * from menus", "MenuName", cmbMenus)
        cmbMenus.SelectedIndex = 0
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Dim qrCode As New QRCodeEncoder()
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            ptbQrCode.Image = qrCode.Encode(domainName, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim SD As New SaveFileDialog

        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = cmbMenus.Text
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                ptbQrCode.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cmbMenus.Items.Clear()
        ptbQrCode.Image = Nothing
        cmbMenus.Focus()
    End Sub

    Private Sub cmbMenus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenus.SelectedIndexChanged
        'GetIDFromCmb("select * from menus where MenuName=" + cmbMenus.Text, "MenuName", "MenuID", cmbMenus)
        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim cmdGetID As MySqlCommand
        Dim rdrGetID As MySqlDataReader

        Try
            cmdGetID = New MySqlCommand("select * from menus", MdlCommon.conn)

            rdrGetID = cmdGetID.ExecuteReader()

            If rdrGetID.HasRows Then
                While rdrGetID.Read
                    If cmbMenus.Text = rdrGetID.Item("MenuName") Then
                        FrmQrCode.TheID = rdrGetID.Item("MenuID")
                    End If
                End While
            End If
        Catch ex As Exception

        End Try
        domainName = "www.andrew.com?MenuID=" & TheID
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmMenu.Show()
    End Sub
End Class