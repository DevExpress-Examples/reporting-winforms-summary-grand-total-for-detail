*Files to look at*:


<!-- default file list end -->
# Reporting for WinForms - How to Calculate Grand Total for Detail Report Summaries


This example calculates grand total summary for detail reports.

In this example, the report is bound to a dataset that has two related tables - the `Customers` table for the main report, and the `Orders` table for the DetailReport band. 

The detail report calculates the sum of the `Freight` columns for each customer. This summary is calculated automatically in the `xrlFreightTotal` label in the detail report footer.

The grand total of the `Freight` summaries is displayed in the main report. This summary cannot be calculated automatically, because the `Freight` column does not belong to the main report data source. To solve the problem, the [SummaryCalculated](https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRLabel.SummaryCalculated) event of summary labels in a detail report is handled. Note that when the `BeforePrint` event occurs, a summary value is not yet calculated. Use the `SummaryCalculated` event to obtain a calculated summary value. The summary amounts of the individual detailed reports are summed up in a global variable (`GrandTotals`), which is then printed in the footer of the main report.

## Files to Review

* [Form1.cs](CS/Form1.cs) (VB: [Form1.vb](VB/Form1.vb))
* [Program.cs](CS/Program.cs) (VB: [Program.vb](/VB/Program.vb))
* [XtraReport1.cs](CS/XtraReport1.cs) (VB: [XtraReport1.vb](VB/XtraReport1.vb))

## Documentation

- [Calculate Summaries](https://docs.devexpress.com/XtraReports/401920/detailed-guide-to-devexpress-reporting/shape-report-data/calculate-summaries)

## More Examples

- [Reporting for WinForms - How to Create a Report with Running Totals](https://github.com/DevExpress-Examples/reporting-winforms-summary-running-totals)
- [How to sort groups by a custom summary function result](https://github.com/DevExpress-Examples/Reporting_how-to-sort-groups-by-a-custom-summary-function-result-e2536)
- [How to create a summary programmatically](https://github.com/DevExpress-Examples/Reporting_how-to-create-a-summary-programmatically-e2388)
- [How to calculate a total of different summary functions' results](https://github.com/DevExpress-Examples/Reporting_how-to-calculate-a-total-of-different-summary-functions-results-e2391)
- [How to calculate an aggregated summary function](https://github.com/DevExpress-Examples/Reporting_how-to-calculate-an-aggregated-summary-function-e4342)
- [How to conditionally suppress summary footer cell painting by using formatting rules](https://github.com/DevExpress-Examples/Reporting_how-to-conditionally-suppress-summary-footer-cell-painting-by-using-formatting-t211184)

