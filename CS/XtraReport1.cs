using System;
using DevExpress.XtraReports.UI;
// ...

namespace DetailReportsSum {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        decimal GrandTotals = 0;

        private void xrlFreightTotal_SummaryCalculated(object sender, TextFormatEventArgs e) {
            if(e.Value != null)
                GrandTotals += Convert.ToDecimal(e.Value);
        }

        private void xrlFreightGrandTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrlFreightGrandTotal.Text = string.Format("{0:c2}", GrandTotals);
        }

    }
}
