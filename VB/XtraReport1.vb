Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace DetailReportsSum
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private GrandTotals As Decimal = 0

		Private Sub xrlFreightTotal_SummaryCalculated(ByVal sender As Object, ByVal e As TextFormatEventArgs) Handles xrlFreightTotal.SummaryCalculated
			If e.Value IsNot Nothing Then
				GrandTotals += Convert.ToDecimal(e.Value)
			End If
		End Sub

		Private Sub xrlFreightGrandTotal_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlFreightGrandTotal.BeforePrint
			xrlFreightGrandTotal.Text = String.Format("{0:c2}", GrandTotals)
		End Sub

	End Class
End Namespace
