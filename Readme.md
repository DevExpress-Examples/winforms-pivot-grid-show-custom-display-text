<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T537319)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - Show Custom Display Text in Row Total Cells

The following example describes how handle the `CustomCellDisplayText` event to show custom display text in the Pivot Grid cells. 

The Pivot Grid shows the following display text instead of the row total cell value:

* "Low" when row total value is less than 2000;
* "Middle" when row total value is between 2000 and 6000;
* "High" when row total value exceeds 6000;

![Piovt Grid](images/pivotgrid.png)

<!-- default file list -->
## Files to Review

* [Form1.cs](./CS/WinFormsPivotCustomCellDisplayText/Form1.cs) (VB: [Form1.vb](./VB/VBWinFormsPivotCustomCellDisplayText/Form1.vb))
<!-- default file list end -->

## Documentation

[CustomCellDisplayText](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellDisplayText)
