Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmProducts
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim sql As String
    Dim WithEvents pic As New PictureBox
    Dim WithEvents lblName As New Label
    Dim WithEvents lblPrice As New Label
    Dim isAdd As Boolean
    Dim isEdit As Boolean
    Public beforeProductUpdate As String
    Dim opf As New OpenFileDialog
    Dim ProductID As Integer
    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isAdd = False
        isEdit = False

        MdlCommon.FillCmb("select CurrencyName from currency", "CurrencyName", CmbCurrency)

        MdlCommon.FillCmb("select CategoryName from categories", "CategoryName", cmbCategory)

        MdlCommon.GlobalVariablesReset()

        fillPage()

        stopEditProduct()

        LvProducts.SelectedIndex = 0

    End Sub

    Private Sub BtnGoBack_Click(sender As Object, e As EventArgs) Handles BtnGoBack.Click
        FrmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click

        opf.Filter = "choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            PtbBrowsePicture.BackgroundImage = Image.FromFile(opf.FileName)
            PtbBrowsePicture.BackgroundImageLayout = ImageLayout.Stretch
        End If

    End Sub

    Private Sub BtnStoreProduct_Click(sender As Object, e As EventArgs) Handles BtnStoreProduct.Click

        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim currencyID As Integer
        Dim ProductPrice As Integer

        If CInt(TxtProductPrice.Text) Then
            ProductPrice = CInt(TxtProductPrice.Text)
            'continue
        Else
            Exit Sub
        End If

        If isEdit Then
            Dim cmdFindID As MySqlCommand
            Dim rdrFindID As MySqlDataReader

            cmdFindID = New MySqlCommand("select ProductID from products where ProductName='" + TxtProductName.Text + "'", MdlCommon.conn)
            rdrFindID = cmdFindID.ExecuteReader()

            If rdrFindID.HasRows Then
                While rdrFindID.Read
                    ProductID = rdrFindID.Item("ProductID")
                End While

            End If
            MdlCommon.conn.Close()
            MdlCommon.connect()
        End If

        Try
            Dim cmdFindCurrencyID As MySqlCommand
            Dim rdrFindCurrencyID As MySqlDataReader
            Dim sqlFindCurrencyID As String

            sqlFindCurrencyID = "select CurrencyID from Currency where CurrencyName = '" + CmbCurrency.Text + "'"

            cmdFindCurrencyID = New MySqlCommand(sqlFindCurrencyID, MdlCommon.conn)

            rdrFindCurrencyID = cmdFindCurrencyID.ExecuteReader()

            If rdrFindCurrencyID.HasRows Then
                While rdrFindCurrencyID.Read
                    currencyID = rdrFindCurrencyID.Item("CurrencyID")
                End While
            End If

            MdlCommon.conn.Close()
            MdlCommon.connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
            MsgBox(ex.Message)
        End Try 'get CurrencyID

        Dim CategoryID As Integer

        Try
            Dim cmdFindCategoryID As MySqlCommand
            Dim rdrFindCategoryID As MySqlDataReader
            Dim sqlFindCategoryID As String

            sqlFindCategoryID = "select CategoryID from categories where CategoryName = '" + cmbCategory.Text + "'"

            cmdFindCategoryID = New MySqlCommand(sqlFindCategoryID, MdlCommon.conn)

            rdrFindCategoryID = cmdFindCategoryID.ExecuteReader()

            If rdrFindCategoryID.HasRows Then
                While rdrFindCategoryID.Read
                    CategoryID = rdrFindCategoryID.Item("CategoryID")
                End While
            End If

            MdlCommon.conn.Close()
            MdlCommon.connect()
        Catch ex As Exception
            MdlCommon.conn.Close()
            MdlCommon.connect()
            MsgBox(ex.Message)
        End Try 'get CategoryID


        Dim cmdProduct As MySqlCommand
        Dim rdrProduct As MySqlDataReader
        Dim sqlProduct As String
        Dim theFileName As String
        Dim theFilePath As String
        Dim ThePath As String
        beforeProductUpdate = TxtProductName.Text

        Try
            theFileName = Path.GetFileName(opf.FileName)
            theFilePath = Path.GetDirectoryName(opf.FileName) + "\" + theFileName
            ThePath = "C:\Users\andre\source\repos\internship1\internship1\Pictures\" + theFileName

            My.Computer.FileSystem.CopyFile(theFilePath, ThePath, True)

            'Dim LoadFile As String = "load_file('" + ThePath + "')"

            ThePath = ThePath.Replace("\", "\\")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If isAdd Then
            sqlProduct = "Insert into products (ProductName,ProductBarcode,ProductReferenceNum,ProductImage,ProductPrice,ProductQuantity,CategoryID,CurrencyID) 
                             VALUES (@ProductName,@ProductBarcode,@ProductReferenceNum,'" + ThePath + "',@ProductPrice,@ProductQuantity,@CategoryID,@CurrencyID)"

            GlobalVariables.isAddProductStored = True
            GlobalVariables.isEditProductStored = False

        ElseIf isEdit Then
            sqlProduct = "Update products set ProductName=@ProductName,ProductBarcode=@ProductBarcode, ProductReferenceNum=@ProductReferenceNum,
                                ProductImage='" + ThePath + "',ProductPrice= @ProductPrice,ProductQuantity= @ProductQuantity,
                                CategoryID=@CategoryID,CurrencyID= @CurrencyID where ProductID= @ProductID"

            GlobalVariables.isAddProductStored = False
            GlobalVariables.isEditProductStored = True

        End If 'add/edit products

        Try
            cmdProduct = New MySqlCommand(sqlProduct, MdlCommon.conn)

            cmdProduct.Parameters.AddWithValue("ProductName", TxtProductName.Text)
            cmdProduct.Parameters.AddWithValue("ProductBarcode", TxtProductBarcode.Text)
            cmdProduct.Parameters.AddWithValue("ProductReferenceNum", txtProductReferenceNum.Text)
            cmdProduct.Parameters.AddWithValue("ProductPrice", ProductPrice)
            cmdProduct.Parameters.AddWithValue("ProductQuantity", txtProductQuantity.Text)
            cmdProduct.Parameters.AddWithValue("CategoryID", CategoryID)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If isEdit Then
            cmdProduct.Parameters.AddWithValue("ProductID", ProductID)
        End If

        Try
            cmdProduct.ExecuteNonQuery()
            MsgBox("Done!")
            MdlCommon.conn.Close()
            MdlCommon.connect()
            MdlHistory.fillLvHistory()
            MdlCommon.conn.Close()
        Catch ex As Exception
            'MsgBox("there is already this product in the database")
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try

        isAdd = False
        isEdit = False

        stopEditProduct()
        fillPage()

    End Sub

    Private Sub BtnEditProduct_Click(sender As Object, e As EventArgs) Handles BtnEditProduct.Click
        If txtProductQuantity.Text = "" Or txtProductReferenceNum.Text = "" Or TxtProductBarcode.Text = "" Or TxtProductName.Text = "" Or TxtProductPrice.Text = "" Then
            Exit Sub
        End If
        If Access("updateProduct") Then
            EditProduct()
            isAdd = False
            isEdit = True
        End If
    End Sub


    Private Sub BtnAddProduct_Click(sender As Object, e As EventArgs) Handles BtnAddProduct.Click
        If Access("createProduct") Then
            EditProduct()
            TxtProductPrice.Text = ""
            TxtProductBarcode.Text = ""
            txtProductReferenceNum.Text = ""
            TxtProductName.Text = ""
            CmbCurrency.SelectedIndex = 0

            isAdd = True
            isEdit = False
        End If
    End Sub

    Private Sub BtnCancelProduct_Click(sender As Object, e As EventArgs) Handles BtnCancelProduct.Click
        stopEditProduct()
    End Sub


    Private Sub EditProduct()
        BtnCancelProduct.Show()
        BtnStoreProduct.Show()
        BtnEditProduct.Hide()
        BtnAddProduct.Hide()
        TxtProductName.Enabled = True
        TxtProductBarcode.Enabled = True
        txtProductReferenceNum.Enabled = True
        btnBrowseImage.Enabled = True
        TxtProductPrice.Enabled = True
        CmbCurrency.Enabled = True
        txtProductQuantity.Enabled = True
        cmbCategory.Enabled = True

        AcceptButton = BtnStoreProduct
        CancelButton = BtnCancelProduct

    End Sub
    Private Sub stopEditProduct()
        BtnCancelProduct.Hide()
        BtnStoreProduct.Hide()
        BtnEditProduct.Show()
        BtnAddProduct.Show()
        TxtProductName.Enabled = False
        TxtProductBarcode.Enabled = False
        txtProductReferenceNum.Enabled = False
        btnBrowseImage.Enabled = False
        TxtProductPrice.Enabled = False
        CmbCurrency.Enabled = False
        txtProductQuantity.Enabled = False
        cmbCategory.Enabled = False

        AcceptButton = BtnAddProduct
        CancelButton = BtnCancelProduct

    End Sub

    'Private Sub fillPage()
    '    MdlCommon.connect()

    '    LvProducts.Items.Clear()

    '    Try
    '        sql = "select ProductName from products"
    '        cmd = New MySqlCommand(sql, MdlCommon.conn)
    '        rdr = cmd.ExecuteReader()

    '        If rdr.HasRows Then
    '            While rdr.Read

    '                LvProducts.Items.Add(rdr.Item("ProductName"))

    '                Try
    '                    'Dim array(CInt(len)) As Byte
    '                    'rdr.GetBytes(0, 0, array, 0, CInt(len))
    '                    'pic = New PictureBox
    '                    'pic.Width = 150
    '                    'pic.Height = 150
    '                    'pic.BackgroundImageLayout = ImageLayout.Stretch

    '                    'lblName = New Label
    '                    'lblName.ForeColor = Color.Blue
    '                    'lblName.Cursor = Cursors.Hand

    '                    ''lblPrice = New Label
    '                    ''lblPrice.ForeColor = Color.Blue

    '                    'Dim ms As New System.IO.MemoryStream(array)
    '                    'Try
    '                    '    Dim bitmap As New System.Drawing.Bitmap(ms)
    '                    '    pic.BackgroundImage = bitmap
    '                    'Catch ex As Exception

    '                    'End Try

    '                    'lblName.Text = rdr.Item("ProductName").ToString
    '                    ''lblPrice.Text = rdr.Item("").ToString

    '                    'AddHandler lblName.Click, AddressOf myClickHandler

    '                    'pic.Controls.Add(lblName)
    '                    ''pic.Controls.Add(lblPrice)

    '                    'FLPProducts.Controls.Add(pic)
    '                    ''FLPProducts.Controls.Add(lblName)
    '                Catch
    '                End Try 'commentend code that i dont wanna get rid of

    '            End While
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    MdlCommon.conn.Close()
    'End Sub

    Private Sub fillPage()
        ProductBindingSrc.DataSource = Nothing
        ProductBindingSrc.DataSource = getProducts()
    End Sub

    Private Sub LvProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvProducts.SelectedIndexChanged
        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim cmdEditProduct As MySqlCommand
        Dim rdrEditProduct As MySqlDataReader
        Dim sqlEditProduct As String
        Dim i As Integer = 0

        Dim ThisCategoryID As String

        Try
            sqlEditProduct = "select * from products where ProductName='" + LvProducts.Text + "'"

            cmdEditProduct = New MySqlCommand(sqlEditProduct, MdlCommon.conn)

            rdrEditProduct = cmdEditProduct.ExecuteReader()

            If rdrEditProduct.HasRows Then
                While rdrEditProduct.Read

                    Try
                        PtbBrowsePicture.BackgroundImage = Image.FromFile(rdrEditProduct.Item("ProductImage"))
                        PtbBrowsePicture.BackgroundImageLayout = ImageLayout.Stretch
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    TxtProductName.Text = rdrEditProduct.Item("ProductName")
                    TxtProductBarcode.Text = rdrEditProduct.Item("ProductBarcode")
                    txtProductReferenceNum.Text = rdrEditProduct.Item("ProductReferenceNum")
                    TxtProductPrice.Text = rdrEditProduct.Item("ProductPrice")
                    CmbCurrency.SelectedIndex = 0

                    ThisCategoryID = rdrEditProduct.Item("CategoryID")

                    txtProductQuantity.Text = rdrEditProduct.Item("ProductQuantity")

                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try 'Fill Info

        Dim CategoryCount As Integer

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim TheCmd As MySqlCommand
            Dim TheSql As String

            TheSql = "select * from categories"

            TheCmd = New MySqlCommand(TheSql, MdlCommon.conn)

            Dim adapter As New MySqlDataAdapter(TheCmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            CategoryCount = table.Rows.Count
        Catch ex As Exception

        End Try 'get Category Row Count

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()

            Dim SqlCategory As String = "Select CategoryName from Categories where CategoryID=" & ThisCategoryID

            Dim cmdCategory As MySqlCommand

            cmdCategory = New MySqlCommand(SqlCategory, conn)

            Dim rdrCategory As MySqlDataReader

            rdrCategory = cmdCategory.ExecuteReader

            Dim j As Integer = 0

            If rdrCategory.HasRows Then
                While rdrCategory.Read
                    While j < CategoryCount
                        If cmbCategory.Text = rdrCategory.Item("CategoryName") Then
                            Exit While
                        Else
                            j = j + 1
                            cmbCategory.SelectedIndex = j
                        End If

                    End While
                End While
            End If

        Catch ex As Exception

        End Try 'set Category Cmb Index

        MdlCommon.conn.Close()
    End Sub
End Class