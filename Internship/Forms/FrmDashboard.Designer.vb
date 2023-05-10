<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
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
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PBxbox2 = New System.Windows.Forms.ProgressBar()
        Me.PBps5 = New System.Windows.Forms.ProgressBar()
        Me.PBnintendo = New System.Windows.Forms.ProgressBar()
        Me.PBxbox1 = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPS5Count = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblXboxCount2 = New System.Windows.Forms.Label()
        Me.lblXbox2C = New System.Windows.Forms.Label()
        Me.lblNintendoCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblHistory2 = New System.Windows.Forms.Label()
        Me.LblHistory1 = New System.Windows.Forms.Label()
        Me.LblHistoryLog = New System.Windows.Forms.Label()
        Me.lblNumProducts = New System.Windows.Forms.Label()
        Me.LblNumRoles = New System.Windows.Forms.Label()
        Me.lblNumUser = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.chtTopSelling = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtProductsQuantities = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTopSelling = New System.Windows.Forms.Label()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnCreateRole = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPermissions = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chtTopSelling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtProductsQuantities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.PBxbox2)
        Me.Panel2.Controls.Add(Me.PBps5)
        Me.Panel2.Controls.Add(Me.PBnintendo)
        Me.Panel2.Controls.Add(Me.PBxbox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblPS5Count)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblXboxCount2)
        Me.Panel2.Controls.Add(Me.lblXbox2C)
        Me.Panel2.Controls.Add(Me.lblNintendoCount)
        Me.Panel2.Location = New System.Drawing.Point(849, 417)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 210)
        Me.Panel2.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 28)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Top Products Quantities"
        '
        'PBxbox2
        '
        Me.PBxbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PBxbox2.Location = New System.Drawing.Point(207, 162)
        Me.PBxbox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBxbox2.Name = "PBxbox2"
        Me.PBxbox2.Size = New System.Drawing.Size(454, 23)
        Me.PBxbox2.TabIndex = 2
        '
        'PBps5
        '
        Me.PBps5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PBps5.Location = New System.Drawing.Point(209, 32)
        Me.PBps5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBps5.Name = "PBps5"
        Me.PBps5.Size = New System.Drawing.Size(452, 23)
        Me.PBps5.TabIndex = 2
        '
        'PBnintendo
        '
        Me.PBnintendo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PBnintendo.Location = New System.Drawing.Point(209, 120)
        Me.PBnintendo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBnintendo.Name = "PBnintendo"
        Me.PBnintendo.Size = New System.Drawing.Size(452, 23)
        Me.PBnintendo.TabIndex = 2
        '
        'PBxbox1
        '
        Me.PBxbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PBxbox1.Location = New System.Drawing.Point(209, 76)
        Me.PBxbox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PBxbox1.Name = "PBxbox1"
        Me.PBxbox1.Size = New System.Drawing.Size(452, 23)
        Me.PBxbox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(38, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 35)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Xbox Series S"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(148, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ps5"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 35)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nintendo Switch"
        '
        'lblPS5Count
        '
        Me.lblPS5Count.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPS5Count.AutoSize = True
        Me.lblPS5Count.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPS5Count.Location = New System.Drawing.Point(620, 58)
        Me.lblPS5Count.Name = "lblPS5Count"
        Me.lblPS5Count.Size = New System.Drawing.Size(17, 20)
        Me.lblPS5Count.TabIndex = 0
        Me.lblPS5Count.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(38, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 35)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Xbox Series X"
        '
        'lblXboxCount2
        '
        Me.lblXboxCount2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXboxCount2.AutoSize = True
        Me.lblXboxCount2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblXboxCount2.Location = New System.Drawing.Point(620, 102)
        Me.lblXboxCount2.Name = "lblXboxCount2"
        Me.lblXboxCount2.Size = New System.Drawing.Size(17, 20)
        Me.lblXboxCount2.TabIndex = 0
        Me.lblXboxCount2.Text = "0"
        '
        'lblXbox2C
        '
        Me.lblXbox2C.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblXbox2C.AutoSize = True
        Me.lblXbox2C.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblXbox2C.Location = New System.Drawing.Point(620, 188)
        Me.lblXbox2C.Name = "lblXbox2C"
        Me.lblXbox2C.Size = New System.Drawing.Size(17, 20)
        Me.lblXbox2C.TabIndex = 0
        Me.lblXbox2C.Text = "0"
        '
        'lblNintendoCount
        '
        Me.lblNintendoCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNintendoCount.AutoSize = True
        Me.lblNintendoCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNintendoCount.Location = New System.Drawing.Point(620, 144)
        Me.lblNintendoCount.Name = "lblNintendoCount"
        Me.lblNintendoCount.Size = New System.Drawing.Size(17, 20)
        Me.lblNintendoCount.TabIndex = 0
        Me.lblNintendoCount.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblHistory2)
        Me.Panel1.Controls.Add(Me.LblHistory1)
        Me.Panel1.Location = New System.Drawing.Point(849, 283)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 78)
        Me.Panel1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recent History"
        '
        'LblHistory2
        '
        Me.LblHistory2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHistory2.AutoSize = True
        Me.LblHistory2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LblHistory2.Location = New System.Drawing.Point(438, 34)
        Me.LblHistory2.Name = "LblHistory2"
        Me.LblHistory2.Size = New System.Drawing.Size(107, 35)
        Me.LblHistory2.TabIndex = 0
        Me.LblHistory2.Text = "History2"
        '
        'LblHistory1
        '
        Me.LblHistory1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblHistory1.AutoSize = True
        Me.LblHistory1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LblHistory1.Location = New System.Drawing.Point(83, 34)
        Me.LblHistory1.Name = "LblHistory1"
        Me.LblHistory1.Size = New System.Drawing.Size(107, 35)
        Me.LblHistory1.TabIndex = 0
        Me.LblHistory1.Text = "History1"
        '
        'LblHistoryLog
        '
        Me.LblHistoryLog.AutoSize = True
        Me.LblHistoryLog.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.LblHistoryLog.ForeColor = System.Drawing.Color.Green
        Me.LblHistoryLog.Location = New System.Drawing.Point(1356, 196)
        Me.LblHistoryLog.Name = "LblHistoryLog"
        Me.LblHistoryLog.Size = New System.Drawing.Size(37, 45)
        Me.LblHistoryLog.TabIndex = 4
        Me.LblHistoryLog.Text = "0"
        '
        'lblNumProducts
        '
        Me.lblNumProducts.AutoSize = True
        Me.lblNumProducts.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.lblNumProducts.ForeColor = System.Drawing.Color.Green
        Me.lblNumProducts.Location = New System.Drawing.Point(995, 196)
        Me.lblNumProducts.Name = "lblNumProducts"
        Me.lblNumProducts.Size = New System.Drawing.Size(37, 45)
        Me.lblNumProducts.TabIndex = 5
        Me.lblNumProducts.Text = "0"
        '
        'LblNumRoles
        '
        Me.LblNumRoles.AutoSize = True
        Me.LblNumRoles.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.LblNumRoles.ForeColor = System.Drawing.Color.Green
        Me.LblNumRoles.Location = New System.Drawing.Point(1356, 70)
        Me.LblNumRoles.Name = "LblNumRoles"
        Me.LblNumRoles.Size = New System.Drawing.Size(37, 45)
        Me.LblNumRoles.TabIndex = 6
        Me.LblNumRoles.Text = "0"
        '
        'lblNumUser
        '
        Me.lblNumUser.AutoSize = True
        Me.lblNumUser.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.lblNumUser.ForeColor = System.Drawing.Color.Green
        Me.lblNumUser.Location = New System.Drawing.Point(995, 70)
        Me.lblNumUser.Name = "lblNumUser"
        Me.lblNumUser.Size = New System.Drawing.Size(37, 45)
        Me.lblNumUser.TabIndex = 7
        Me.lblNumUser.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.Label7.Location = New System.Drawing.Point(1283, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 45)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "History Log"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.Label5.Location = New System.Drawing.Point(859, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(309, 45)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Products"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.Label3.Location = New System.Drawing.Point(1244, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 45)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Number of Roles"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 19.0!)
        Me.label1.Location = New System.Drawing.Point(882, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(262, 45)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Number of Users"
        '
        'chtTopSelling
        '
        ChartArea11.Name = "ChartArea1"
        Me.chtTopSelling.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.chtTopSelling.Legends.Add(Legend11)
        Me.chtTopSelling.Location = New System.Drawing.Point(163, 12)
        Me.chtTopSelling.Name = "chtTopSelling"
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series11.Legend = "Legend1"
        Series11.Name = "%TopSelling"
        Me.chtTopSelling.Series.Add(Series11)
        Me.chtTopSelling.Size = New System.Drawing.Size(671, 300)
        Me.chtTopSelling.TabIndex = 14
        Me.chtTopSelling.Text = "Top Selling"
        '
        'chtProductsQuantities
        '
        ChartArea12.Name = "ChartArea1"
        Me.chtProductsQuantities.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.chtProductsQuantities.Legends.Add(Legend12)
        Me.chtProductsQuantities.Location = New System.Drawing.Point(163, 327)
        Me.chtProductsQuantities.Name = "chtProductsQuantities"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Product Quantity"
        Me.chtProductsQuantities.Series.Add(Series12)
        Me.chtProductsQuantities.Size = New System.Drawing.Size(671, 300)
        Me.chtProductsQuantities.TabIndex = 15
        Me.chtProductsQuantities.Text = "chtProductsQuantities"
        '
        'lblTopSelling
        '
        Me.lblTopSelling.AutoSize = True
        Me.lblTopSelling.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTopSelling.Location = New System.Drawing.Point(180, 23)
        Me.lblTopSelling.Name = "lblTopSelling"
        Me.lblTopSelling.Size = New System.Drawing.Size(121, 24)
        Me.lblTopSelling.TabIndex = 16
        Me.lblTopSelling.Text = "%Top Selling"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(12, 12)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(145, 71)
        Me.btnCreateUser.TabIndex = 17
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnCreateRole
        '
        Me.btnCreateRole.Location = New System.Drawing.Point(12, 89)
        Me.btnCreateRole.Name = "btnCreateRole"
        Me.btnCreateRole.Size = New System.Drawing.Size(145, 71)
        Me.btnCreateRole.TabIndex = 18
        Me.btnCreateRole.Text = "Create Role"
        Me.btnCreateRole.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(12, 166)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(145, 71)
        Me.btnProducts.TabIndex = 19
        Me.btnProducts.Text = "Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Location = New System.Drawing.Point(12, 243)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(145, 71)
        Me.btnHistory.TabIndex = 20
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnPermissions
        '
        Me.btnPermissions.Location = New System.Drawing.Point(12, 320)
        Me.btnPermissions.Name = "btnPermissions"
        Me.btnPermissions.Size = New System.Drawing.Size(145, 71)
        Me.btnPermissions.TabIndex = 21
        Me.btnPermissions.Text = "Permissions"
        Me.btnPermissions.UseVisualStyleBackColor = True
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1522, 659)
        Me.Controls.Add(Me.btnPermissions)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnCreateRole)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.lblTopSelling)
        Me.Controls.Add(Me.chtProductsQuantities)
        Me.Controls.Add(Me.chtTopSelling)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblHistoryLog)
        Me.Controls.Add(Me.lblNumProducts)
        Me.Controls.Add(Me.LblNumRoles)
        Me.Controls.Add(Me.lblNumUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmDashboard"
        Me.Text = "FrmDashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chtTopSelling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtProductsQuantities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PBxbox2 As ProgressBar
    Friend WithEvents PBps5 As ProgressBar
    Friend WithEvents PBnintendo As ProgressBar
    Friend WithEvents PBxbox1 As ProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPS5Count As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblXboxCount2 As Label
    Friend WithEvents lblXbox2C As Label
    Friend WithEvents lblNintendoCount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblHistory2 As Label
    Friend WithEvents LblHistory1 As Label
    Friend WithEvents LblHistoryLog As Label
    Friend WithEvents lblNumProducts As Label
    Friend WithEvents LblNumRoles As Label
    Friend WithEvents lblNumUser As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents chtTopSelling As DataVisualization.Charting.Chart
    Friend WithEvents chtProductsQuantities As DataVisualization.Charting.Chart
    Friend WithEvents lblTopSelling As Label
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnCreateRole As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnPermissions As Button
End Class
