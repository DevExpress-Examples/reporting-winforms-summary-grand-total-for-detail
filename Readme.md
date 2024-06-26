<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598786/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E633)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-summary-grand-total-for-detail&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-summary-grand-total-for-detail&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
