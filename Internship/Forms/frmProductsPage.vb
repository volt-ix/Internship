Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Public Class frmProductsPage
    Dim WithEvents lblName As New Label
    Dim WithEvents lblPrice As New Label
    Dim j As Integer = 1
    Private Sub frmProductsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MdlCommon.connect()
            Dim cmd As MySqlCommand
            Dim rdr As MySqlDataReader
            Dim sql As String

            Search()

        Catch ex As Exception

        End Try 'Initialize

        FillCorousel()

        Try
            cmbFilter.Items.Add("A-Z")
            cmbFilter.Items.Add("Z-A")
            cmbFilter.Items.Add("Low-to-High")
            cmbFilter.Items.Add("High-to-Low")
        Catch ex As Exception

        End Try 'Fill CmbFilter

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()

            Dim cmdCategories As MySqlCommand
            Dim rdrCategories As MySqlDataReader
            Dim sqlCategories As String

            sqlCategories = "select * from categories"

            cmdCategories = New MySqlCommand(sqlCategories, MdlCommon.conn)

            rdrCategories = cmdCategories.ExecuteReader()

            If rdrCategories.HasRows Then
                While rdrCategories.Read
                    cmbCategories.Items.Add(rdrCategories.Item("CategoryName"))
                End While
            End If
        Catch ex As Exception

        End Try 'Fill CmbCategories
        cmbFilter.SelectedIndex = 0
        cmbCategories.SelectedIndex = 0

        TmrCorousel.Start()

    End Sub
    Private Sub myClickHandler(sender As Object, e As EventArgs)

        Dim clickedLabel As Label = DirectCast(sender, Label)

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Search()

    End Sub

    Private Sub Search()
        FLPProducts.Controls.Clear()

        Dim i As Integer = 0
        Dim FilterContent As String

        While i < cmbFilter.Items.Count - 1
            If cmbFilter.SelectedIndex = 0 Then
                FilterContent = "Order By ProductName ASC"
            ElseIf cmbFilter.SelectedIndex = 1 Then
                FilterContent = "Order By ProductName DESC"
            ElseIf cmbFilter.SelectedIndex = 2 Then
                FilterContent = "Order By ProductPrice ASC"
            ElseIf cmbFilter.SelectedIndex = 3 Then
                FilterContent = "Order By ProductPrice DESC"
            End If
            i += 1
        End While 'Filter 

        Dim categoryID As Integer

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim sqlCategory As String = "select * from categories"
            Dim cmdCategory As MySqlCommand = New MySqlCommand(sqlCategory, conn)
            Dim rdrcategory As MySqlDataReader = cmdCategory.ExecuteReader()

            If rdrcategory.HasRows Then
                While rdrcategory.Read
                    If cmbCategories.Text = rdrcategory.Item("CategoryName") Then
                        categoryID = rdrcategory.Item("CategoryID")
                    End If
                End While
            End If

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get categoryID


        Dim cmdSearch As MySqlCommand
        Dim rdrSearch As MySqlDataReader
        Dim sqlSearch As String

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            sqlSearch = "select ProductImage,ProductName,ProductPrice,CurrencyID from products where ProductName Like '" & txtSearch.Text & "%'"

            If categoryID > 1 Then
                sqlSearch = sqlSearch + " and CategoryID=" & categoryID
            End If

            If FilterContent IsNot "" Then
                sqlSearch = sqlSearch + " " + FilterContent
            End If

            cmdSearch = New MySqlCommand(sqlSearch, MdlCommon.conn)

            rdrSearch = cmdSearch.ExecuteReader()

            If rdrSearch.HasRows Then
                While rdrSearch.Read
                    Dim pic As New PictureBox() With {
                        .Size = New Drawing.Size(130, 130),
                        .BorderStyle = BorderStyle.FixedSingle,
                        .SizeMode = PictureBoxSizeMode.StretchImage,
                        .Image = Image.FromFile(rdrSearch.Item("ProductImage"))
                    }

                    FLPProducts.Controls.Add(pic)

                    lblName = New Label
                    lblName.ForeColor = Color.Blue
                    lblName.Cursor = Cursors.Hand

                    lblName.Text = rdrSearch.Item("ProductName")

                    lblName.AutoSize = True

                    pic.Controls.Add(lblName)

                    lblPrice = New Label
                    lblPrice.ForeColor = Color.Green
                    lblPrice.Dock = DockStyle.Bottom

                    lblPrice.Text = rdrSearch.Item("ProductPrice") & "$"

                    lblPrice.AutoSize = True

                    pic.Controls.Add(lblPrice)

                End While
            End If 'Fill Flow layout Panel with products

        Catch ex As Exception
            MdlCommon.conn.Close()
            MsgBox(ex.Message)
        End Try 'fill products

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged

        Search()

    End Sub

    Private Sub cmbCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategories.SelectedIndexChanged
        Search()
    End Sub

    Private Sub FillCorousel()

        Dim imageCount As Integer

        MdlCommon.conn.Close()
        MdlCommon.connect()

        Try
            Dim TheCmd As MySqlCommand
            Dim TheSql As String

            TheSql = "Select ProductID from products"

            TheCmd = New MySqlCommand(TheSql, MdlCommon.conn)

            Dim adapter As New MySqlDataAdapter(TheCmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            imageCount = table.Rows.Count
            MdlCommon.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try 'get image/deal counts

        Try

            MdlCommon.conn.Close()
            MdlCommon.connect()

            Dim sqlCorousel As String = "select ProductName,ProductImage,ProductPrice from products where ProductID=" & j

            Dim cmdcorousel As MySqlCommand = New MySqlCommand(sqlCorousel, conn)

            Dim rdrcorousel As MySqlDataReader = cmdcorousel.ExecuteReader()

            If rdrcorousel.HasRows Then
                While rdrcorousel.Read
                    ptbCourousel.Image = Image.FromFile(rdrcorousel.Item("ProductImage"))
                    ptbCourousel.SizeMode = PictureBoxSizeMode.StretchImage
                End While

            End If

            If j < imageCount Then
                j = j + 1
            ElseIf j = imageCount Then
                j = 1
            End If

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try
    End Sub

    Private Sub TmrCorousel_Tick(sender As Object, e As EventArgs) Handles TmrCorousel.Tick
        FillCorousel()
        TmrCorousel.Stop()
        TmrCorousel.Start()
    End Sub
End Class