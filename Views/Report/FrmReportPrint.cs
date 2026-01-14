using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Views.Report
{
    public partial class FrmReportPrint : Form
    {
        public FrmReportPrint()
        {
            InitializeComponent();
        }

        private void FrmReportPrint_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsReport.dtReport'. Você pode movê-la ou removê-la conforme necessário.
            this.dtReportTableAdapter.Fill(this.dsReport.dtReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
