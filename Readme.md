# How to calculate a grand total summary for a detail report's summaries


<p>This example demonstrates how to calculate the grand summary for detail reports.</p><p>In this example, the report's dataset contains two related tables. The <strong>Customers</strong> table is bound to the main report and the <strong>Orders</strong> table is used as the DetailReport's data source.</p><p>The detail report calculates the sum of the <strong>Freight</strong> columns for each customer. This summary is calculated automatically: see the <strong>Summary</strong> property of the <strong>xrlFreightTotal</strong> label in the detail report footer.</p><p>The grand total of the <strong>Freight</strong> summaries must be displayed in the main report. This cannot be calculated automatically, because the <strong>Freight</strong> column does not belong to the main report's data source.</p><p>So, you should handle the <strong>SummaryCalculated</strong> event of summary labels in your detail report. Please note that when the <strong>BeforePrint</strong> event is fired, a summary value is not yet calculated; you should use <strong>SummaryCalculated</strong> to obtain a calculated summary value. Summaries of individual detail reports are incremented in a global variable (<strong>GrandTotals</strong>) which is then printed in the main report's footer.</p>

<br/>


