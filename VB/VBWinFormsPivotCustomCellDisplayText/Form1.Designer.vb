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
        Me.NwindDataSet1 = New VBWinFormsPivotCustomCellDisplayText.nwindDataSet()
        Me.SalesPersonTableAdapter1 = New VBWinFormsPivotCustomCellDisplayText.nwindDataSetTableAdapters.SalesPersonTableAdapter()
        Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
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
        'fieldSalesPerson1
        '
        Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldSalesPerson1.AreaIndex = 1
        Me.fieldSalesPerson1.FieldName = "Sales Person"
        Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
        '
        'fieldProductName1
        '
        Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductName1.AreaIndex = 1
        Me.fieldProductName1.Caption = "Product"
        Me.fieldProductName1.FieldName = "ProductName"
        Me.fieldProductName1.Name = "fieldProductName1"
        '
        'fieldExtendedPrice1
        '
        Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldExtendedPrice1.AreaIndex = 0
        Me.fieldExtendedPrice1.FieldName = "Extended Price"
        Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
        '
        'fieldCountry1
        '
        Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldCountry1.AreaIndex = 0
        Me.fieldCountry1.FieldName = "Country"
        Me.fieldCountry1.Name = "fieldCountry1"
        '
        'fieldCategoryName1
        '
        Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldCategoryName1.AreaIndex = 0
        Me.fieldCategoryName1.Caption = "Category"
        Me.fieldCategoryName1.FieldName = "CategoryName"
        Me.fieldCategoryName1.Name = "fieldCategoryName1"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "SalesPerson"
        Me.PivotGridControl1.DataSource = Me.NwindDataSet1
        Me.PivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName1, Me.fieldCountry1, Me.fieldExtendedPrice1, Me.fieldProductName1, Me.fieldSalesPerson1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized
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
    Friend WithEvents fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

End Class
