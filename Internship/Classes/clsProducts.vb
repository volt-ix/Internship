Public Class clsProducts
    Private ProductID As Integer
    Private ProductName As String
    Private ProductBarcode As Integer
    Private ProductReferenceNum As Integer
    Private ProductImage As String
    Private ProductPrice As Integer
    Private ProductQuantity As Integer
    Private CategoryID As Integer
    Private currencyID As Integer
    Private SoldThisMonth As Integer

    Public Property ProductProductID As Integer
        Get
            Return ProductID
        End Get
        Set(value As Integer)
            ProductID = value
        End Set
    End Property

    Public Property ProductProductName As String
        Get
            Return ProductName
        End Get
        Set(value As String)
            ProductName = value
        End Set
    End Property

    Public Property ProductProductBarcode As Integer
        Get
            Return ProductBarcode
        End Get
        Set(value As Integer)
            ProductBarcode = value
        End Set
    End Property

    Public Property ProductProductReferenceNum As Integer
        Get
            Return ProductReferenceNum
        End Get
        Set(value As Integer)
            ProductReferenceNum = value
        End Set
    End Property

    Public Property ProductProductImage As String
        Get
            Return ProductImage
        End Get
        Set(value As String)
            ProductImage = value
        End Set
    End Property

    Public Property ProductProductPrice As Integer
        Get
            Return ProductPrice
        End Get
        Set(value As Integer)
            ProductPrice = value
        End Set
    End Property

    Public Property ProductProductQuantity As Integer
        Get
            Return ProductQuantity
        End Get
        Set(value As Integer)
            ProductQuantity = value
        End Set
    End Property

    Public Property ProductCategoryID As Integer
        Get
            Return CategoryID
        End Get
        Set(value As Integer)
            CategoryID = value
        End Set
    End Property

    Public Property ProductcurrencyID As Integer
        Get
            Return currencyID
        End Get
        Set(value As Integer)
            currencyID = value
        End Set
    End Property

    Public Property ProductSoldThisMonth As Integer
        Get
            Return SoldThisMonth
        End Get
        Set(value As Integer)
            SoldThisMonth = value
        End Set
    End Property

    Public Sub New(IDOfProduct As Integer, NameOfProduct As String, BarcodeOfProduct As Integer, ReferenceNumOfProduct As Integer, ImageOfProduct As String,
                   PriceOfProduct As Integer, QuantityOfProduct As Integer, CategoryIDOfProduct As Integer, CurrencyIDOfProduct As Integer,
                   SoldThisMonth As Integer)
        Me.ProductID = IDOfProduct
        Me.ProductName = NameOfProduct
        Me.ProductBarcode = BarcodeOfProduct
        Me.ProductReferenceNum = ReferenceNumOfProduct
        Me.ProductImage = ImageOfProduct
        Me.ProductPrice = PriceOfProduct
        Me.ProductQuantity = QuantityOfProduct
        Me.CategoryID = CategoryIDOfProduct
        Me.currencyID = CurrencyIDOfProduct
        Me.SoldThisMonth = SoldThisMonth
    End Sub

End Class
