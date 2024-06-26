<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598786/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E633)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to calculate a grand total summary for a detail report's summaries


<p>This example demonstrates how to calculate the grand summary for detail reports.</p><p>In this example, the report's dataset contains two related tables. The <strong>Customers</strong> table is bound to the main report and the <strong>Orders</strong> table is used as the DetailReport's data source.</p><p>The detail report calculates the sum of the <strong>Freight</strong> columns for each customer. This summary is calculated automatically: see the <strong>Summary</strong> property of the <strong>xrlFreightTotal</strong> label in the detail report footer.</p><p>The grand total of the <strong>Freight</strong> summaries must be displayed in the main report. This cannot be calculated automatically, because the <strong>Freight</strong> column does not belong to the main report's data source.</p><p>So, you should handle the <strong>SummaryCalculated</strong> event of summary labels in your detail report. Please note that when the <strong>BeforePrint</strong> event is fired, a summary value is not yet calculated; you should use <strong>SummaryCalculated</strong> to obtain a calculated summary value. Summaries of individual detail reports are incremented in a global variable (<strong>GrandTotals</strong>) which is then printed in the main report's footer.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-summary-grand-total-for-detail&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-summary-grand-total-for-detail&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
