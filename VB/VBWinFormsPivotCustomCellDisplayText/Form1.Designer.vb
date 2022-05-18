<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Me.NwindDataSet1 = New VBWinFormsPivotCustomCellDisplayText.nwindDataSet()
        Me.SalesPersonTableAdapter1 = New VBWinFormsPivotCustomCellDisplayText.nwindDataSetTableAdapters.SalesPersonTableAdapter()
        Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesPersonTableAdapter1
        '
        Me.SalesPersonTableAdapter1.ClearBeforeFill = True
        '
        'fieldSalesPerson
        '
        Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSalesPerson.AreaIndex = 1
        DataSourceColumnBinding1.ColumnName = "Sales Person"
        Me.fieldSalesPerson.DataBinding = DataSourceColumnBinding1
        Me.fieldSalesPerson.Name = "fieldSalesPerson"
        '
        'fieldProductName
        '
        Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductName.AreaIndex = 1
        Me.fieldProductName.Caption = "Product"
        DataSourceColumnBinding2.ColumnName = "ProductName"
        Me.fieldProductName.DataBinding = DataSourceColumnBinding2
        Me.fieldProductName.Name = "fieldProductName"
        '
        'fieldExtendedPrice
        '
        Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldExtendedPrice.AreaIndex = 0
        DataSourceColumnBinding3.ColumnName = "Extended Price"
        Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding3
        Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
        '
        'fieldCountry
        '
        Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCountry.AreaIndex = 0
        DataSourceColumnBinding4.ColumnName = "Country"
        Me.fieldCountry.DataBinding = DataSourceColumnBinding4
        Me.fieldCountry.Name = "fieldCountry"
        '
        'fieldCategoryName
        '
        Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCategoryName.AreaIndex = 0
        Me.fieldCategoryName.Caption = "Category"
        DataSourceColumnBinding5.ColumnName = "CategoryName"
        Me.fieldCategoryName.DataBinding = DataSourceColumnBinding5
        Me.fieldCategoryName.Name = "fieldCategoryName"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "SalesPerson"
        Me.PivotGridControl1.DataSource = Me.NwindDataSet1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldCountry, Me.fieldExtendedPrice, Me.fieldProductName, Me.fieldSalesPerson})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(720, 411)
        Me.PivotGridControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 411)
        Me.Controls.Add(Me.PivotGridControl1)
        Me.Name = "Form1"
        Me.Text = "DevExpress WinForms Pivot Grid"
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NwindDataSet1 As VBWinFormsPivotCustomCellDisplayText.nwindDataSet
    Friend WithEvents SalesPersonTableAdapter1 As VBWinFormsPivotCustomCellDisplayText.nwindDataSetTableAdapters.SalesPersonTableAdapter
    Friend WithEvents fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

End Class
