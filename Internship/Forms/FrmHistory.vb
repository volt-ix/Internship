Imports MySql.Data.MySqlClient

Public Class FrmHistory
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Public Sub FrmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdlCommon.connect()
            MdlHistory.fillTheLvHistory()
            MdlCommon.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click
        MdlCommon.conn.Close()
        FrmMenu.Show()
        Me.Close()
    End Sub
End Class