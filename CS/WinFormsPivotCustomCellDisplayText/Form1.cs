using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WinFormsPivotCustomCellDisplayText {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson);
            fieldCountry.FilterValues.FilterType = PivotFilterType.Included;
            fieldCountry.FilterValues.Add("UK");
        }

        private void pivotGridControl1_CustomCellDisplayText(object sender, 
                     DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs e) {
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
