Namespace DetailReportsSum

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.nwindDataSet1 = New DetailReportsSum.nwindDataSet()
            Me.customersTableAdapter = New DetailReportsSum.nwindDataSetTableAdapters.CustomersTableAdapter()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrlFreightGrandTotal = New DevExpress.XtraReports.UI.XRLabel()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.ordersTableAdapter = New DetailReportsSum.nwindDataSetTableAdapters.OrdersTableAdapter()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrlFreight = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportFooter1 = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrlFreightTotal = New DevExpress.XtraReports.UI.XRLabel()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.Detail.Height = 29
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName", "")})
            Me.xrLabel1.Font = New System.Drawing.Font("Arial", 12F)
            Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.Size = New System.Drawing.Size(275, 20)
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFreightGrandTotal})
            Me.ReportFooter.Height = 27
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrlFreightGrandTotal
            ' 
            Me.xrlFreightGrandTotal.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((232)))))), (CInt(((CByte((232)))))))
            Me.xrlFreightGrandTotal.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrlFreightGrandTotal.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrlFreightGrandTotal.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((64)))))), (CInt(((CByte((64)))))))
            Me.xrlFreightGrandTotal.Location = New System.Drawing.Point(150, 0)
            Me.xrlFreightGrandTotal.Name = "xrlFreightGrandTotal"
            Me.xrlFreightGrandTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlFreightGrandTotal.Size = New System.Drawing.Size(133, 20)
            Me.xrlFreightGrandTotal.StylePriority.UseBackColor = False
            Me.xrlFreightGrandTotal.StylePriority.UseForeColor = False
            Me.xrlFreightGrandTotal.Text = "GrandTotal"
            Me.xrlFreightGrandTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            AddHandler Me.xrlFreightGrandTotal.BeforePrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.xrlFreightGrandTotal_BeforePrint)
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.ReportFooter1})
            Me.DetailReport.DataAdapter = Me.ordersTableAdapter
            Me.DetailReport.DataMember = "Customers.CustomersOrders"
            Me.DetailReport.DataSource = Me.nwindDataSet1
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrlFreight})
            Me.Detail1.Height = 20
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrlFreight
            ' 
            Me.xrlFreight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.Freight", "{0:c2}")})
            Me.xrlFreight.Location = New System.Drawing.Point(125, 0)
            Me.xrlFreight.Name = "xrlFreight"
            Me.xrlFreight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlFreight.Size = New System.Drawing.Size(158, 20)
            Me.xrlFreight.Text = "xrlFreight"
            Me.xrlFreight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderID", "")})
            Me.xrLabel3.Location = New System.Drawing.Point(42, 0)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.Size = New System.Drawing.Size(67, 20)
            Me.xrLabel3.Text = "xrLabel3"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportFooter1
            ' 
            Me.ReportFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFreightTotal})
            Me.ReportFooter1.Height = 20
            Me.ReportFooter1.Name = "ReportFooter1"
            ' 
            ' xrlFreightTotal
            ' 
            Me.xrlFreightTotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.Freight", "{0:c2}")})
            Me.xrlFreightTotal.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrlFreightTotal.Location = New System.Drawing.Point(150, 0)
            Me.xrlFreightTotal.Name = "xrlFreightTotal"
            Me.xrlFreightTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrlFreightTotal.Size = New System.Drawing.Size(133, 20)
            xrSummary1.FormatString = "{0:c2}"
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.xrlFreightTotal.Summary = xrSummary1
            Me.xrlFreightTotal.Text = "xrlFreightTotal"
            Me.xrlFreightTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            AddHandler Me.xrlFreightTotal.SummaryCalculated, New DevExpress.XtraReports.UI.TextFormatEventHandler(AddressOf Me.xrlFreightTotal_SummaryCalculated)
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.ReportFooter, Me.DetailReport})
            Me.DataAdapter = Me.customersTableAdapter
            Me.DataMember = "Customers"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "8.1"
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private nwindDataSet1 As DetailReportsSum.nwindDataSet

        Private customersTableAdapter As DetailReportsSum.nwindDataSetTableAdapters.CustomersTableAdapter

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrlFreightGrandTotal As DevExpress.XtraReports.UI.XRLabel

        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand

        Private Detail1 As DevExpress.XtraReports.UI.DetailBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrlFreight As DevExpress.XtraReports.UI.XRLabel

        Private ReportFooter1 As DevExpress.XtraReports.UI.ReportFooterBand

        Private xrlFreightTotal As DevExpress.XtraReports.UI.XRLabel

        Private ordersTableAdapter As DetailReportsSum.nwindDataSetTableAdapters.OrdersTableAdapter
    End Class
End Namespace
