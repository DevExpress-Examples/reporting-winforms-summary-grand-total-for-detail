Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

' ...
Namespace DetailReportsSum

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreview()
        End Sub
    End Class
End Namespace
