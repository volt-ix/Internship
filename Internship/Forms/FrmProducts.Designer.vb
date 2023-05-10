<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LvProducts = New System.Windows.Forms.ListBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.CmbCurrency = New System.Windows.Forms.ComboBox()
        Me.TxtProductPrice = New System.Windows.Forms.TextBox()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.BtnCancelProduct = New System.Windows.Forms.Button()
        Me.BtnStoreProduct = New System.Windows.Forms.Button()
        Me.BtnAddProduct = New System.Windows.Forms.Button()
        Me.BtnEditProduct = New System.Windows.Forms.Button()
        Me.PtbBrowsePicture = New System.Windows.Forms.PictureBox()
        Me.btnBrowseImage = New System.Windows.Forms.Button()
        Me.txtProductReferenceNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProductBarcode = New System.Windows.Forms.TextBox()
        Me.lblProductBarcode = New System.Windows.Forms.Label()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.BtnGoBack = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtProductQuantity = New System.Windows.Forms.TextBox()
        Me.lblProductQuantity = New System.Windows.Forms.Label()
        Me.ProductBindingSrc = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PtbBrowsePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LvProducts
        '
        Me.LvProducts.DataSource = Me.ProductBindingSrc
        Me.LvProducts.DisplayMember = "ProductProductName"
        Me.LvProducts.FormattingEnabled = True
        Me.LvProducts.ItemHeight = 16
        Me.LvProducts.Location = New System.Drawing.Point(3, 9)
        Me.LvProducts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LvProducts.Name = "LvProducts"
        Me.LvProducts.Size = New System.Drawing.Size(430, 452)
        Me.LvProducts.TabIndex = 37
        Me.LvProducts.ValueMember = "ProductProductID"
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Location = New System.Drawing.Point(744, 267)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(60, 16)
        Me.lblCurrency.TabIndex = 36
        Me.lblCurrency.Text = "Currency"
        '
        'CmbCurrency
        '
        Me.CmbCurrency.FormattingEnabled = True
        Me.CmbCurrency.Location = New System.Drawing.Point(816, 265)
        Me.CmbCurrency.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCurrency.Name = "CmbCurrency"
        Me.CmbCurrency.Size = New System.Drawing.Size(207, 24)
        Me.CmbCurrency.TabIndex = 35
        '
        'TxtProductPrice
        '
        Me.TxtProductPrice.Location = New System.Drawing.Point(681, 229)
        Me.TxtProductPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProductPrice.Name = "TxtProductPrice"
        Me.TxtProductPrice.Size = New System.Drawing.Size(342, 22)
        Me.TxtProductPrice.TabIndex = 34
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(579, 231)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(87, 16)
        Me.lblProductPrice.TabIndex = 33
        Me.lblProductPrice.Text = "Product Price"
        '
        'BtnCancelProduct
        '
        Me.BtnCancelProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelProduct.Location = New System.Drawing.Point(766, 421)
        Me.BtnCancelProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelProduct.Name = "BtnCancelProduct"
        Me.BtnCancelProduct.Size = New System.Drawing.Size(121, 38)
        Me.BtnCancelProduct.TabIndex = 32
        Me.BtnCancelProduct.Text = "Cancel"
        Me.BtnCancelProduct.UseVisualStyleBackColor = True
        '
        'BtnStoreProduct
        '
        Me.BtnStoreProduct.Location = New System.Drawing.Point(893, 421)
        Me.BtnStoreProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStoreProduct.Name = "BtnStoreProduct"
        Me.BtnStoreProduct.Size = New System.Drawing.Size(121, 38)
        Me.BtnStoreProduct.TabIndex = 31
        Me.BtnStoreProduct.Text = "Store"
        Me.BtnStoreProduct.UseVisualStyleBackColor = True
        '
        'BtnAddProduct
        '
        Me.BtnAddProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAddProduct.Location = New System.Drawing.Point(893, 421)
        Me.BtnAddProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddProduct.Name = "BtnAddProduct"
        Me.BtnAddProduct.Size = New System.Drawing.Size(121, 38)
        Me.BtnAddProduct.TabIndex = 30
        Me.BtnAddProduct.Text = "Add"
        Me.BtnAddProduct.UseVisualStyleBackColor = True
        '
        'BtnEditProduct
        '
        Me.BtnEditProduct.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEditProduct.Location = New System.Drawing.Point(766, 421)
        Me.BtnEditProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEditProduct.Name = "BtnEditProduct"
        Me.BtnEditProduct.Size = New System.Drawing.Size(121, 38)
        Me.BtnEditProduct.TabIndex = 29
        Me.BtnEditProduct.Text = "Edit"
        Me.BtnEditProduct.UseVisualStyleBackColor = True
        '
        'PtbBrowsePicture
        '
        Me.PtbBrowsePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtbBrowsePicture.Location = New System.Drawing.Point(764, 127)
        Me.PtbBrowsePicture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PtbBrowsePicture.Name = "PtbBrowsePicture"
        Me.PtbBrowsePicture.Size = New System.Drawing.Size(128, 90)
        Me.PtbBrowsePicture.TabIndex = 28
        Me.PtbBrowsePicture.TabStop = False
        '
        'btnBrowseImage
        '
        Me.btnBrowseImage.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBrowseImage.Location = New System.Drawing.Point(898, 127)
        Me.btnBrowseImage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBrowseImage.Name = "btnBrowseImage"
        Me.btnBrowseImage.Size = New System.Drawing.Size(121, 38)
        Me.btnBrowseImage.TabIndex = 27
        Me.btnBrowseImage.Text = "Browse"
        Me.btnBrowseImage.UseVisualStyleBackColor = True
        '
        'txtProductReferenceNum
        '
        Me.txtProductReferenceNum.Location = New System.Drawing.Point(677, 101)
        Me.txtProductReferenceNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProductReferenceNum.Name = "txtProductReferenceNum"
        Me.txtProductReferenceNum.Size = New System.Drawing.Size(342, 22)
        Me.txtProductReferenceNum.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product Reference Number"
        '
        'TxtProductBarcode
        '
        Me.TxtProductBarcode.Location = New System.Drawing.Point(677, 61)
        Me.TxtProductBarcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProductBarcode.Name = "TxtProductBarcode"
        Me.TxtProductBarcode.Size = New System.Drawing.Size(342, 22)
        Me.TxtProductBarcode.TabIndex = 24
        '
        'lblProductBarcode
        '
        Me.lblProductBarcode.AutoSize = True
        Me.lblProductBarcode.Location = New System.Drawing.Point(552, 61)
        Me.lblProductBarcode.Name = "lblProductBarcode"
        Me.lblProductBarcode.Size = New System.Drawing.Size(108, 16)
        Me.lblProductBarcode.TabIndex = 23
        Me.lblProductBarcode.Text = "Product Barcode"
        '
        'TxtProductName
        '
        Me.TxtProductName.Location = New System.Drawing.Point(677, 17)
        Me.TxtProductName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(342, 22)
        Me.TxtProductName.TabIndex = 22
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(567, 17)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(93, 16)
        Me.lblProductName.TabIndex = 21
        Me.lblProductName.Text = "Product Name"
        '
        'BtnGoBack
        '
        Me.BtnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnGoBack.Location = New System.Drawing.Point(439, 425)
        Me.BtnGoBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGoBack.Name = "BtnGoBack"
        Me.BtnGoBack.Size = New System.Drawing.Size(128, 31)
        Me.BtnGoBack.TabIndex = 20
        Me.BtnGoBack.Text = "Go Back"
        Me.BtnGoBack.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(744, 354)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(62, 16)
        Me.lblCategory.TabIndex = 39
        Me.lblCategory.Text = "Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(816, 352)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(207, 24)
        Me.cmbCategory.TabIndex = 38
        '
        'txtProductQuantity
        '
        Me.txtProductQuantity.Location = New System.Drawing.Point(681, 309)
        Me.txtProductQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProductQuantity.Name = "txtProductQuantity"
        Me.txtProductQuantity.Size = New System.Drawing.Size(342, 22)
        Me.txtProductQuantity.TabIndex = 41
        '
        'lblProductQuantity
        '
        Me.lblProductQuantity.AutoSize = True
        Me.lblProductQuantity.Location = New System.Drawing.Point(571, 312)
        Me.lblProductQuantity.Name = "lblProductQuantity"
        Me.lblProductQuantity.Size = New System.Drawing.Size(104, 16)
        Me.lblProductQuantity.TabIndex = 40
        Me.lblProductQuantity.Text = "Product Quantity"
        '
        'ProductBindingSrc
        '
        Me.ProductBindingSrc.DataSource = GetType(Internship.clsProducts)
        '
        'FrmProducts
        '
        Me.AcceptButton = Me.BtnAddProduct
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnGoBack
        Me.ClientSize = New System.Drawing.Size(1026, 467)
        Me.Controls.Add(Me.txtProductQuantity)
        Me.Controls.Add(Me.lblProductQuantity)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.LvProducts)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.CmbCurrency)
        Me.Controls.Add(Me.TxtProductPrice)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.BtnCancelProduct)
        Me.Controls.Add(Me.BtnStoreProduct)
        Me.Controls.Add(Me.BtnAddProduct)
        Me.Controls.Add(Me.BtnEditProduct)
        Me.Controls.Add(Me.PtbBrowsePicture)
        Me.Controls.Add(Me.btnBrowseImage)
        Me.Controls.Add(Me.txtProductReferenceNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProductBarcode)
        Me.Controls.Add(Me.lblProductBarcode)
        Me.Controls.Add(Me.TxtProductName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.BtnGoBack)
        Me.Name = "FrmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProducts"
        CType(Me.PtbBrowsePicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSrc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LvProducts As ListBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents CmbCurrency As ComboBox
    Friend WithEvents TxtProductPrice As TextBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents BtnCancelProduct As Button
    Friend WithEvents BtnStoreProduct As Button
    Friend WithEvents BtnAddProduct As Button
    Friend WithEvents BtnEditProduct As Button
    Friend WithEvents PtbBrowsePicture As PictureBox
    Friend WithEvents btnBrowseImage As Button
    Friend WithEvents txtProductReferenceNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProductBarcode As TextBox
    Friend WithEvents lblProductBarcode As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents BtnGoBack As Button
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents lblProductQuantity As Label
    Friend WithEvents ProductBindingSrc As BindingSource
End Class
