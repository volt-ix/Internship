Imports MySql.Data.MySqlClient

Module MdlProductsfcts
    Private ProductsList As New List(Of clsProducts)

    Public Function getProducts() As List(Of clsProducts)
        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim Rs As MySqlDataReader
            Dim SQL As String

            SQL = "SELECT p.ProductID as ProductID,ifNull(p.ProductName,'') as ProductName,ifNull(p.ProductBarcode,'') as ProductBarcode,
                    ifNull(p.ProductReferenceNum,'') as ProductReferenceNum,ifNull(p.ProductImage,'') as ProductImage,
                    ifNull(p.ProductPrice,'') as ProductPrice,ifNull(p.ProductQuantity,'') as ProductQuantity,
                    ifNull(p.CategoryID,'') as ProductCategoryID, ifNull(p.CurrencyID,'') as ProductCurrencyID, ifNull(Sold_This_Month,'') as ProductSoldPerMonth
                    FROM products p"

            'If showAll Then
            '    SQL &= " WHERE (R.Active=1 OR R.Active=0)"
            'Else
            '    SQL &= " WHERE (R.Active=1)"
            'End If

            Dim cmd As MySqlCommand = New MySqlCommand(SQL, conn)

            Rs = cmd.ExecuteReader()

            If Rs IsNot Nothing Then
                ProductsList.Clear()
                While Rs.Read
                    ProductsList.Add(New clsProducts(Rs("ProductID"), Rs("ProductName"), Rs("ProductBarcode"), Rs("ProductReferenceNum"), Rs("ProductImage"),
                                                     Rs("ProductPrice"), Rs("ProductQuantity"), Rs("ProductCategoryID"), Rs("ProductCurrencyID"), Rs("ProductSoldPerMonth")))
                End While

                Return ProductsList
            Else
                Return Nothing
            End If

            Rs.Close()
            Rs.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Module
