<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T537319)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinFormsPivotCustomCellDisplayText/Form1.cs) (VB: [Form1.vb](./VB/VBWinFormsPivotCustomCellDisplayText/Form1.vb))
<!-- default file list end -->
# How to format cells  to show custom display text


<p>The following example shows how to provide custom text for the PivotGridControl's cells by handling the <a href="https://documentation.devexpress.com/windowsforms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellDisplayText.event">PivotGridControl.CustomCellDisplayText</a> event.</p>
<p>In this example, if a <a href="https://documentation.devexpress.com/WindowsForms/1691/Controls-and-Libraries/Pivot-Grid/UI-Elements/Totals">row total value</a> is less than 2000, PivotGridControl displays the 'Low' value instead. If the value exceeds 6000, 'High' is displayed; otherwise, 'Middle'.</p>

<br/>


