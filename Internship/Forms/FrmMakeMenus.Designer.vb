<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMakeMenus
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
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.btnEditMenu = New System.Windows.Forms.Button()
        Me.btnCreateMenu = New System.Windows.Forms.Button()
        Me.txtCreateMenu = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.LbMenuItems = New System.Windows.Forms.ListBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.GvAddedItems = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.GvAddedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMenu
        '
        Me.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(122, 17)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(229, 24)
        Me.cmbMenu.TabIndex = 0
        '
        'btnEditMenu
        '
        Me.btnEditMenu.Location = New System.Drawing.Point(13, 13)
        Me.btnEditMenu.Name = "btnEditMenu"
        Me.btnEditMenu.Size = New System.Drawing.Size(103, 33)
        Me.btnEditMenu.TabIndex = 3
        Me.btnEditMenu.Text = "Edit Menu"
        Me.btnEditMenu.UseVisualStyleBackColor = True
        '
        'btnCreateMenu
        '
        Me.btnCreateMenu.Location = New System.Drawing.Point(627, 12)
        Me.btnCreateMenu.Name = "btnCreateMenu"
        Me.btnCreateMenu.Size = New System.Drawing.Size(104, 33)
        Me.btnCreateMenu.TabIndex = 3
        Me.btnCreateMenu.Text = "Create Menu"
        Me.btnCreateMenu.UseVisualStyleBackColor = True
        '
        'txtCreateMenu
        '
        Me.txtCreateMenu.Location = New System.Drawing.Point(736, 17)
        Me.txtCreateMenu.Name = "txtCreateMenu"
        Me.txtCreateMenu.Size = New System.Drawing.Size(229, 22)
        Me.txtCreateMenu.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(91, 342)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(130, 22)
        Me.txtPrice.TabIndex = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(146, 370)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "add item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(10, 345)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 16)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price(USD)"
        '
        'LbMenuItems
        '
        Me.LbMenuItems.FormattingEnabled = True
        Me.LbMenuItems.ItemHeight = 16
        Me.LbMenuItems.Location = New System.Drawing.Point(13, 53)
        Me.LbMenuItems.Name = "LbMenuItems"
        Me.LbMenuItems.Size = New System.Drawing.Size(208, 276)
        Me.LbMenuItems.TabIndex = 8
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(871, 338)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(84, 23)
        Me.btnRemoveItem.TabIndex = 10
        Me.btnRemoveItem.Text = "remove item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'GvAddedItems
        '
        Me.GvAddedItems.AllowUserToAddRows = False
        Me.GvAddedItems.AllowUserToDeleteRows = False
        Me.GvAddedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GvAddedItems.Location = New System.Drawing.Point(718, 53)
        Me.GvAddedItems.Name = "GvAddedItems"
        Me.GvAddedItems.ReadOnly = True
        Me.GvAddedItems.RowHeadersWidth = 51
        Me.GvAddedItems.RowTemplate.Height = 24
        Me.GvAddedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GvAddedItems.Size = New System.Drawing.Size(237, 276)
        Me.GvAddedItems.TabIndex = 11
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(849, 385)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(106, 36)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 403)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmMakeMenus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 438)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GvAddedItems)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.LbMenuItems)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtCreateMenu)
        Me.Controls.Add(Me.btnCreateMenu)
        Me.Controls.Add(Me.btnEditMenu)
        Me.Controls.Add(Me.cmbMenu)
        Me.Name = "FrmMakeMenus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMakeMenus"
        CType(Me.GvAddedItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents btnEditMenu As Button
    Friend WithEvents btnCreateMenu As Button
    Friend WithEvents txtCreateMenu As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents LbMenuItems As ListBox
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents GvAddedItems As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
End Class
