Imports DevExpress.XtraPivotGrid

Public Class Form1

    Sub New()

        InitializeComponent()
        SalesPersonTableAdapter1.Fill(NwindDataSet1.SalesPerson)
        fieldCountry1.FilterValues.FilterType = PivotFilterType.Included
        fieldCountry1.FilterValues.Add("UK")

    End Sub

    Private Sub PivotGridControl1_CustomCellDisplayText(sender As System.Object,
                e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PivotGridControl1.CustomCellDisplayText
        ' In this example, if a row total value is less than 2000, 'Low' is displayed instead. 
        ' If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.
        If e.RowValueType = PivotGridValueType.Total OrElse e.ColumnValueType <> PivotGridValueType.Total Then
            Return
        End If
        If Convert.ToSingle(e.Value) < 2000 Then
            e.DisplayText = "Low"
        ElseIf Convert.ToSingle(e.Value) > 6000 Then
            e.DisplayText = "High"
        Else
            e.DisplayText = "Middle"
        End If
    End Sub
End Class
