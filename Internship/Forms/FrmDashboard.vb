Imports MySql.Data.MySqlClient

Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdlCommon.connect()

        MdlCommon.countItems("select ID from users", lblNumUser) 'number of users
        MdlCommon.countItems("select RolesID from roles", LblNumRoles) 'number of roles
        MdlCommon.countItems("select ProductID from products", lblNumProducts) 'number of products
        MdlCommon.countItems("select HistoryID from history", LblHistoryLog) 'History log number

        Try
            MdlCommon.connect()
            Dim theCmdHistory As MySqlCommand
            Dim theRdrHistory As MySqlDataReader
            Dim theSqlHistory As String
            Dim i As Integer = 0
            Dim History2 As String
            Dim History1 As String

            theSqlHistory = "select HistoryID,HistoryLog from history Order By HistoryID DESC limit 2"

            theCmdHistory = New MySqlCommand(theSqlHistory, conn)

            theRdrHistory = theCmdHistory.ExecuteReader()
            If (theRdrHistory.HasRows) Then
                While (theRdrHistory.Read)
                    If (i = 0) Then
                        History2 = theRdrHistory.Item("HistoryLog")
                    End If

                    If (i = 1) Then
                        History1 = theRdrHistory.Item("HistoryLog")
                    End If
                    i += 1
                End While
            End If

            LblHistory2.Text = History2
            LblHistory1.Text = History1

        Catch ex As Exception

        End Try 'fill recent history

        Try
            MdlCommon.connect()
            Dim theCmdProductCount As MySqlCommand
            Dim theRdrProductCount As MySqlDataReader
            Dim theSqlProductCount As String

            Dim theCmdRowCount As MySqlCommand
            Dim theSqlRowCount As String
            Dim storeTableCount As Integer

            theSqlRowCount = "SELECT ProductName,ProductID,ProductQuantity FROM products"

            theCmdRowCount = New MySqlCommand(theSqlRowCount, conn)

            Dim adapter As New MySqlDataAdapter(theCmdRowCount)
            Dim table As New DataTable()

            adapter.Fill(table)

            Dim Theid As Integer = 1
            Dim i As Integer = 0

            storeTableCount = table.Rows.Count

            MdlCommon.conn.Close()

            While (Theid <= storeTableCount)
                i = 0

                MdlCommon.connect()

                theSqlProductCount = "SELECT ProductName,ProductID,ProductQuantity FROM products where ProductID= @ProductID"

                theCmdProductCount = New MySqlCommand(theSqlProductCount, conn)

                theCmdProductCount.Parameters.AddWithValue("ProductID", Theid)

                theRdrProductCount = theCmdProductCount.ExecuteReader()
                If (theRdrProductCount.HasRows) Then
                    While (theRdrProductCount.Read)
                        While (i < theRdrProductCount.Item("ProductQuantity"))

                            If (Theid = 1) Then
                                PBps5.PerformStep()
                                lblPS5Count.Text = theRdrProductCount.Item("ProductQuantity")
                            ElseIf (Theid = 2) Then
                                PBxbox1.PerformStep()
                                lblXboxCount2.Text = theRdrProductCount.Item("ProductQuantity")
                            ElseIf (Theid = 3) Then
                                PBnintendo.PerformStep()
                                lblNintendoCount.Text = theRdrProductCount.Item("ProductQuantity")
                            ElseIf (Theid = 5) Then
                                PBxbox2.PerformStep()
                                lblXbox2C.Text = theRdrProductCount.Item("ProductQuantity")
                            End If

                            i += 1

                        End While
                    End While
                End If

                MdlCommon.conn.Close()
                Theid += 1

            End While

            MdlCommon.connect()

            Dim cmdChart As MySqlCommand
            Dim sqlChart As String
            Dim rdrChart As MySqlDataReader

            sqlChart = "SELECT ProductName,ProductID,ProductQuantity FROM products"

            cmdChart = New MySqlCommand(sqlChart, conn)

            rdrChart = cmdChart.ExecuteReader()

            If rdrChart.HasRows Then
                While rdrChart.Read
                    chtProductsQuantities.Series("Product Quantity").Points.AddXY(rdrChart.Item("ProductName"), rdrChart.Item("ProductQuantity"))
                End While
            End If

        Catch ex As Exception

        End Try 'progress bars for quantities and chart

        Try
            MdlCommon.conn.Close()
            MdlCommon.connect()
            Dim cmdTopSelling As MySqlCommand
            Dim rdrTopSelling As MySqlDataReader
            Dim sqlTopSelling As String

            sqlTopSelling = "Select Sold_This_Month from products"

            cmdTopSelling = New MySqlCommand(sqlTopSelling, conn)

            Dim addSoldProducts As Integer = 0
            Dim previousItem As Integer
            Dim BiggestItem As Integer
            Dim theIndex As Integer = 0

            rdrTopSelling = cmdTopSelling.ExecuteReader()

            If rdrTopSelling.HasRows Then
                While (rdrTopSelling.Read)
                    If IsDBNull(rdrTopSelling.Item("Sold_This_Month")) = False Then
                        addSoldProducts += rdrTopSelling.Item("Sold_This_Month")
                        If (theIndex > 0) Then
                            If (BiggestItem < rdrTopSelling.Item("Sold_This_Month")) Then
                                BiggestItem = rdrTopSelling.Item("Sold_This_Month")
                            End If
                        Else
                            BiggestItem = rdrTopSelling.Item("Sold_This_Month")
                        End If

                        theIndex += 1
                    End If
                End While
            End If 'get sum of products sold this month and the biggest item

            MdlCommon.conn.Close()

            MdlCommon.connect()
            Dim cmdCalculateTop As MySqlCommand
            Dim rdrCalculateTop As MySqlDataReader
            Dim sqlCalculateTop As String

            sqlCalculateTop = "Select ProductName,Sold_This_Month from products"

            cmdCalculateTop = New MySqlCommand(sqlCalculateTop, conn)

            rdrCalculateTop = cmdCalculateTop.ExecuteReader()

            Dim percentageOfProduct As Integer

            If rdrCalculateTop.HasRows Then
                While (rdrCalculateTop.Read)
                    percentageOfProduct = (rdrCalculateTop.Item("Sold_This_Month") / addSoldProducts) * 100
                    chtTopSelling.Series("%TopSelling").Points.AddXY(rdrCalculateTop.Item("ProductName"), percentageOfProduct)
                End While
            End If

        Catch ex As Exception
            MdlCommon.conn.Close()
        End Try '%top selling chart

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        frmRegister.Show()
        Me.Close()
    End Sub

    Private Sub btnCreateRole_Click(sender As Object, e As EventArgs) Handles btnCreateRole.Click
        FrmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        FrmProducts.Show()
        Me.Close()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        FrmHistory.Show()
        Me.Close()
    End Sub

    Private Sub btnPermissions_Click(sender As Object, e As EventArgs) Handles btnPermissions.Click
        FrmAdmin.Show()
        Me.Close()
    End Sub
End Class