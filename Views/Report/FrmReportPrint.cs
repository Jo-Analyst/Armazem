using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface.Views.Report
{
    public partial class FrmReportPrint : Form
    {
        public FrmReportPrint(DataTable report, bool isDetailed = false)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = isDetailed ? "Interface.Views.Report.Relatório do Almoxarifado Detalhado.rdlc" : "Interface.Views.Report.Relatório do Almoxarifado.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsReport", report));
        }

        private void FrmReportPrint_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
