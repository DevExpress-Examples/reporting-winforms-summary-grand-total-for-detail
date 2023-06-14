namespace DetailReportsSum {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.nwindDataSet1 = new DetailReportsSum.nwindDataSet();
            this.customersTableAdapter = new DetailReportsSum.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrlFreightGrandTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.ordersTableAdapter = new DetailReportsSum.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrlFreight = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrlFreightTotal = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.Detail.Height = 29;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.ContactName", "")});
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Arial", 12F);
            this.xrLabel1.Location = new System.Drawing.Point(8, 8);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.Size = new System.Drawing.Size(275, 20);
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlFreightGrandTotal});
            this.ReportFooter.Height = 27;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrlFreightGrandTotal
            // 
            this.xrlFreightGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.xrlFreightGrandTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrlFreightGrandTotal.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrlFreightGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xrlFreightGrandTotal.Location = new System.Drawing.Point(150, 0);
            this.xrlFreightGrandTotal.Name = "xrlFreightGrandTotal";
            this.xrlFreightGrandTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlFreightGrandTotal.Size = new System.Drawing.Size(133, 20);
            this.xrlFreightGrandTotal.StylePriority.UseBackColor = false;
            this.xrlFreightGrandTotal.StylePriority.UseForeColor = false;
            this.xrlFreightGrandTotal.Text = "GrandTotal";
            this.xrlFreightGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrlFreightGrandTotal.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.xrlFreightGrandTotal_BeforePrint);
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter1});
            this.DetailReport.DataAdapter = this.ordersTableAdapter;
            this.DetailReport.DataMember = "Customers.CustomersOrders";
            this.DetailReport.DataSource = this.nwindDataSet1;
            this.DetailReport.Name = "DetailReport";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrlFreight});
            this.Detail1.Height = 20;
            this.Detail1.Name = "Detail1";
            // 
            // xrlFreight
            // 
            this.xrlFreight.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.Freight", "{0:c2}")});
            this.xrlFreight.Location = new System.Drawing.Point(125, 0);
            this.xrlFreight.Name = "xrlFreight";
            this.xrlFreight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlFreight.Size = new System.Drawing.Size(158, 20);
            this.xrlFreight.Text = "xrlFreight";
            this.xrlFreight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderID", "")});
            this.xrLabel3.Location = new System.Drawing.Point(42, 0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Size = new System.Drawing.Size(67, 20);
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlFreightTotal});
            this.ReportFooter1.Height = 20;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // xrlFreightTotal
            // 
            this.xrlFreightTotal.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.Freight", "{0:c2}")});
            this.xrlFreightTotal.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrlFreightTotal.Location = new System.Drawing.Point(150, 0);
            this.xrlFreightTotal.Name = "xrlFreightTotal";
            this.xrlFreightTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlFreightTotal.Size = new System.Drawing.Size(133, 20);
            xrSummary1.FormatString = "{0:c2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrlFreightTotal.Summary = xrSummary1;
            this.xrlFreightTotal.Text = "xrlFreightTotal";
            this.xrlFreightTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrlFreightTotal.SummaryCalculated += new DevExpress.XtraReports.UI.TextFormatEventHandler(this.xrlFreightTotal_SummaryCalculated);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportFooter,
            this.DetailReport});
            this.DataAdapter = this.customersTableAdapter;
            this.DataMember = "Customers";
            this.DataSource = this.nwindDataSet1;
            this.Version = "8.1";
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private nwindDataSet nwindDataSet1;
        private DetailReportsSum.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrlFreightGrandTotal;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrlFreight;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrlFreightTotal;
        private DetailReportsSum.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
    }
}
