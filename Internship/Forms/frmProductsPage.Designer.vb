<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FLPProducts = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmbCategories = New System.Windows.Forms.ComboBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ptbCourousel = New System.Windows.Forms.PictureBox()
        Me.TmrCorousel = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ptbCourousel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FLPProducts
        '
        Me.FLPProducts.Location = New System.Drawing.Point(12, 364)
        Me.FLPProducts.Name = "FLPProducts"
        Me.FLPProducts.Size = New System.Drawing.Size(1414, 343)
        Me.FLPProducts.TabIndex = 0
        '
        'cmbCategories
        '
        Me.cmbCategories.FormattingEnabled = True
        Me.cmbCategories.Location = New System.Drawing.Point(12, 12)
        Me.cmbCategories.Name = "cmbCategories"
        Me.cmbCategories.Size = New System.Drawing.Size(224, 24)
        Me.cmbCategories.TabIndex = 1
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(322, 12)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(179, 24)
        Me.cmbFilter.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(570, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(332, 22)
        Me.txtSearch.TabIndex = 2
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.Location = New System.Drawing.Point(242, 15)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(62, 16)
        Me.lblCategories.TabIndex = 3
        Me.lblCategories.Text = "Category"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(507, 17)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(36, 16)
        Me.lblFilter.TabIndex = 3
        Me.lblFilter.Text = "Filter"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(908, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(46, 16)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Seach"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 713)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 33)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ptbCourousel
        '
        Me.ptbCourousel.Location = New System.Drawing.Point(245, 56)
        Me.ptbCourousel.Name = "ptbCourousel"
        Me.ptbCourousel.Size = New System.Drawing.Size(960, 292)
        Me.ptbCourousel.TabIndex = 5
        Me.ptbCourousel.TabStop = False
        '
        'TmrCorousel
        '
        Me.TmrCorousel.Interval = 5000
        '
        'frmProductsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 756)
        Me.Controls.Add(Me.ptbCourousel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.cmbCategories)
        Me.Controls.Add(Me.FLPProducts)
        Me.Name = "frmProductsPage"
        Me.Text = "frmProductsPage"
        CType(Me.ptbCourousel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FLPProducts As FlowLayoutPanel
    Friend WithEvents cmbCategories As ComboBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblCategories As Label
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents ptbCourousel As PictureBox
    Friend WithEvents TmrCorousel As Timer
End Class
