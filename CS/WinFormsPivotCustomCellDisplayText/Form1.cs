using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WinFormsPivotCustomCellDisplayText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson);
            fieldCountry1.FilterValues.FilterType = PivotFilterType.Included;
            fieldCountry1.FilterValues.Add("UK");
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, 
                     DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e)
        {
            // In this example, if a row total value is less than 2000, 'Low' is displayed instead. 
            // If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.
            if (e.RowValueType == PivotGridValueType.Total ||
                e.ColumnValueType != PivotGridValueType.Total) return;
            if (Convert.ToSingle(e.Value) < 2000)
                e.DisplayText = "Low";
            else if (Convert.ToSingle(e.Value) > 6000)
                e.DisplayText = "High";
            else
                e.DisplayText = "Middle";
        }
    }
}
