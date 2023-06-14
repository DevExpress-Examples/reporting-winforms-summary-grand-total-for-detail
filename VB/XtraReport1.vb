Imports System
Imports DevExpress.XtraReports.UI

' ...
Namespace DetailReportsSum

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private GrandTotals As Decimal = 0

        Private Sub xrlFreightTotal_SummaryCalculated(ByVal sender As Object, ByVal e As TextFormatEventArgs)
            If e.Value IsNot Nothing Then GrandTotals += Convert.ToDecimal(e.Value)
        End Sub

        Private Sub xrlFreightGrandTotal_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            xrlFreightGrandTotal.Text = String.Format("{0:c2}", GrandTotals)
        End Sub
    End Class
End Namespace
