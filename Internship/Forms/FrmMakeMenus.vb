Imports MySql.Data.MySqlClient

Public Class FrmMakeMenus
    Dim MenuID As Integer
    Dim isEdit As Boolean
    Dim isAdd As Boolean
    Dim TheMenuCount As Integer
    Public Shared CreatedMenuName As String
    Private Sub FrmMakeMenus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb("select * from menus", "MenuName", cmbMenu)

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()

            Dim menuItemSQL As String = "select ProductID,ProductName from products"
            Dim menuItemCMD As MySqlCommand = New MySqlCommand(menuItemSQL, conn)
            Dim menuItemRDR As MySqlDataReader = menuItemCMD.ExecuteReader()

            If menuItemRDR.HasRows Then
                While menuItemRDR.Read
                    LbMenuItems.Items.Add(menuItemRDR.Item("ProductName"))
                End While
            End If

        Catch ex As Exception

        End Try

        SetGvAddedItem()
        isNotEditMenu()
        GlobalVariablesReset()

    End Sub

    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim cmdGetID As MySqlCommand
        Dim rdrGetID As MySqlDataReader

        Try
            cmdGetID = New MySqlCommand("select * from menus", MdlCommon.conn)

            rdrGetID = cmdGetID.ExecuteReader()

            If rdrGetID.HasRows Then
                While rdrGetID.Read
                    If cmbMenu.Text = rdrGetID.Item("MenuName") Then
                        MenuID = rdrGetID.Item("MenuID")
                    End If
                End While
            End If
        Catch ex As Exception

        End Try

        MdlCommon.conn.Close()
        MdlCommon.connect()

        Dim GetItemsSQl As String = "select m.MenuID,m.ItemID,m.PriceDef,p.ProductID,p.ProductName,p.ProductPrice 
                                     from menuitems m 
                                     join products p 
                                     on m.ItemID=p.ProductID 
                                     where MenuID=" & MenuID & ""
        Dim GetItemsCMD As MySqlCommand = New MySqlCommand(GetItemsSQl, conn)
        Dim GetItemsRDR As MySqlDataReader = GetItemsCMD.ExecuteReader()

        If GetItemsRDR.HasRows Then
            While GetItemsRDR.Read
                Dim row As ArrayList = New ArrayList()
                row.Add(GetItemsRDR.Item("ProductName"))
                row.Add(GetItemsRDR.Item("ProductPrice"))
                row.Add(GetItemsRDR.Item("ProductID"))
                GvAddedItems.Rows.Add(row.ToArray())
            End While
        End If

        MdlCommon.conn.Close()


    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click

        Dim PriceText As Integer

        If Not txtPrice.Text = "" And Not Integer.TryParse(txtPrice.Text, PriceText) Then
            MsgBox("invalid price")
            Exit Sub
        End If

        Try

            MdlCommon.conn.Close()
            MdlCommon.connect()

            Dim PriceSql As String = "select ifNull(ProductName,'') as ProductName,ifNull(ProductPrice,'') as ProductPrice,ProductID from products where ProductName='" & LbMenuItems.Text & "'"
            Dim PriceCmd As MySqlCommand = New MySqlCommand(PriceSql, conn)
            Dim PriceRdr As MySqlDataReader = PriceCmd.ExecuteReader()

            Dim j As Integer = 0
            Dim jj As Integer = 0

            If PriceRdr.HasRows Then
                While PriceRdr.Read
                    If GvAddedItems.Rows.Count > 0 Then
                        While j < GvAddedItems.Rows.Count
                            If PriceRdr.Item("ProductID") = GvAddedItems.Rows(j).Cells("ItemID").Value Then
                                MsgBox("item Already in menu")
                                Exit Sub
                            End If
                            j += 1
                        End While
                    End If

                    Dim row As ArrayList = New ArrayList()
                    row.Add(PriceRdr.Item("ProductName"))

                    If txtPrice.Text = "" Then
                        row.Add(PriceRdr.Item("ProductPrice"))
                    Else
                        row.Add(txtPrice.Text)
                    End If

                    row.Add(PriceRdr.Item("ProductID"))
                    GvAddedItems.Rows.Add(row.ToArray())

                End While
            End If

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'fill listview

        LbMenuItems.Focus()

    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        GvAddedItems.Rows.Remove(GvAddedItems.CurrentRow)
    End Sub

    Public Sub SetGvAddedItem()
        GvAddedItems.Rows.Clear()

        GvAddedItems.RowHeadersVisible = False

        GvAddedItems.ColumnCount = 3

        GvAddedItems.Columns(0).Width = 100
        GvAddedItems.Columns(1).Width = 80
        GvAddedItems.Columns(2).Width = 1

        GvAddedItems.Columns(0).Name = "Added Item"
        GvAddedItems.Columns(1).Name = "Price"
        GvAddedItems.Columns(2).Name = "ItemID"


    End Sub

    Private Sub btnEditMenu_Click(sender As Object, e As EventArgs) Handles btnEditMenu.Click
        isEditMenu()
        isEdit = True
        isAdd = False
        txtCreateMenu.Text = ""
    End Sub

    Public Sub isEditMenu()
        If cmbMenu.SelectedIndex < 0 Then
            MsgBox("Please select a menu")
            Exit Sub
        Else
            btnEditMenu.Enabled = False
            btnCreateMenu.Enabled = False
            cmbMenu.Enabled = False
            txtCreateMenu.Enabled = False
        End If
        LbMenuItems.Enabled = True
        txtPrice.Enabled = True
        btnAddItem.Enabled = True
        GvAddedItems.Enabled = True
        btnRemoveItem.Enabled = True
        btnCreate.Enabled = True
    End Sub
    Public Sub isAddMenu()
        If txtCreateMenu.Text = "" Then
            MsgBox("Please input menu name to create")
            Exit Sub
        Else
            btnEditMenu.Enabled = False
            btnCreateMenu.Enabled = False
            cmbMenu.Enabled = False
            txtCreateMenu.Enabled = False
        End If
        LbMenuItems.Enabled = True
        txtPrice.Enabled = True
        btnAddItem.Enabled = True
        GvAddedItems.Enabled = True
        btnRemoveItem.Enabled = True
        btnCreate.Enabled = True
    End Sub
    Public Sub isNotEditMenu()
        btnEditMenu.Enabled = True
        btnCreateMenu.Enabled = True
        cmbMenu.Enabled = True
        txtCreateMenu.Enabled = True
        LbMenuItems.Enabled = False
        txtPrice.Enabled = False
        btnAddItem.Enabled = False
        GvAddedItems.Enabled = False
        btnRemoveItem.Enabled = False
        btnCreate.Enabled = False
    End Sub

    Private Sub btnCreateMenu_Click(sender As Object, e As EventArgs) Handles btnCreateMenu.Click
        isAddMenu()
        isEdit = False
        isAdd = True
        cmbMenu.SelectedIndex = -1

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim GetMenuCountSQl As String = "Select * from menus"
            Dim GetMenuCountCMD As MySqlCommand = New MySqlCommand(GetMenuCountSQl, conn)

            Dim adapter As New MySqlDataAdapter(GetMenuCountCMD)
            Dim table As New DataTable()

            adapter.Fill(table)

            TheMenuCount = table.Rows.Count

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'Get menus count

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Dim TheMenuID As Integer
        Dim menuCount As Integer
        Dim ItemID As Integer
        Dim Price As Integer

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim GetMenuIDSQl As String = "Select MenuID from menus where MenuName='" & cmbMenu.Text & "'"
            Dim GetMenuIDCMD As MySqlCommand = New MySqlCommand(GetMenuIDSQl, conn)
            Dim GetMenuIDRDR As MySqlDataReader = GetMenuIDCMD.ExecuteReader()

            If GetMenuIDRDR.HasRows Then
                While GetMenuIDRDR.Read
                    MenuID = GetMenuIDRDR.Item("MenuID")
                End While
            End If

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'get menuID

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim GetMenuCountSQl As String = "Select * from menus"
            Dim GetMenuCountCMD As MySqlCommand = New MySqlCommand(GetMenuCountSQl, conn)

            Dim adapter As New MySqlDataAdapter(GetMenuCountCMD)
            Dim table As New DataTable()

            adapter.Fill(table)

            menuCount = table.Rows.Count

            MdlCommon.conn.Close()
        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try 'Get menus count

        Try
            If isAdd Then
                MdlCommon.conn.Close()
                MdlCommon.connect()

                Dim addMenuSQL As String = "insert into menus (MenuName,isActive) Values ('" & txtCreateMenu.Text & "',1)"
                Dim addMenuCMD As MySqlCommand = New MySqlCommand(addMenuSQL, conn)
                Dim addMenuRDR As MySqlDataReader = addMenuCMD.ExecuteReader()

                MdlCommon.conn.Close()
                MdlCommon.connect()

                Dim insertItemsSQL As String
                Dim insertItemsCMD As MySqlCommand
                Dim insertItemsRDR As MySqlDataReader

                insertItemsSQL = "insert into menuitems (MenuID,ItemID,PriceDEF) VALUES "

                Dim i As Integer = 0
                While i < GvAddedItems.Rows.Count
                    ItemID = GvAddedItems.Rows(i).Cells("ItemID").Value
                    Price = GvAddedItems.Rows(i).Cells("Price").Value

                    If i > 0 Then
                        insertItemsSQL = insertItemsSQL + ",(" & menuCount + 1 & "," & ItemID & "," & Price & ")"
                    Else
                        insertItemsSQL = insertItemsSQL + "(" & menuCount + 1 & "," & ItemID & "," & Price & ")"
                    End If

                    i += 1
                End While

                insertItemsCMD = New MySqlCommand(insertItemsSQL, conn)

                insertItemsRDR = insertItemsCMD.ExecuteReader()

                MsgBox("Menu Created")
                CreatedMenuName = txtCreateMenu.Text
                GlobalVariables.isMenuCreated = True
                MdlCommon.conn.Close()

            End If
            If isEdit Then

                Dim insertItemsSQL As String
                Dim insertItemsCMD As MySqlCommand
                Dim insertItemsRDR As MySqlDataReader

                insertItemsSQL = "insert into menuitems (MenuID,ItemID,PriceDEF) VALUES "

                Dim i As Integer = 0
                While i < GvAddedItems.Rows.Count
                    ItemID = GvAddedItems.Rows(i).Cells("ItemID").Value
                    Price = GvAddedItems.Rows(i).Cells("Price").Value

                    MdlCommon.conn.Close()
                    MdlCommon.connect()

                    Dim GetItemsSQl As String = "select * from menuitems where MenuID=" & TheMenuID & ""
                    Dim GetItemsCMD As MySqlCommand = New MySqlCommand(GetItemsSQl, conn)
                    Dim GetItemsRDR As MySqlDataReader = GetItemsCMD.ExecuteReader()

                    Dim j As Integer = 0

                    If GetItemsRDR.HasRows Then
                        While GetItemsRDR.Read
                            While j < GvAddedItems.Rows.Count
                                If GetItemsRDR.Item("ItemID") = GvAddedItems.Rows(j).Cells("ItemID").Value And GetItemsRDR.Item("MenuID") = TheMenuID Then
                                    'ignore
                                ElseIf i > 0 Then
                                    insertItemsSQL = insertItemsSQL + ",(" & TheMenuID & "," & ItemID & "," & Price & ")"
                                Else
                                    insertItemsSQL = insertItemsSQL + "(" & TheMenuID & "," & ItemID & "," & Price & ")"
                                End If
                                j += 1
                            End While
                        End While
                    End If

                    i += 1
                End While

                MdlCommon.conn.Close()
                MdlCommon.connect()

                insertItemsCMD = New MySqlCommand(insertItemsSQL, conn)

                insertItemsRDR = insertItemsCMD.ExecuteReader()

                MsgBox("items added")
                CreatedMenuName = txtCreateMenu.Text
                GlobalVariables.isMenuEdited = True
                MdlCommon.conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MdlCommon.conn.Close()
        End Try

        isNotEditMenu()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        FrmMenu.Show()
    End Sub
End Class