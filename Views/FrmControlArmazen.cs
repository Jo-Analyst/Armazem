using System.Windows.Forms;

namespace Interface
{
    public partial class FrmControlArmazen : Form
    {
        public FrmControlArmazen()
        {
            InitializeComponent();
        }

        private void FrmControlArmazen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, System.EventArgs e)
        {
            new FrmProducts().ShowDialog();
        }

        private void btnReport_Click(object sender, System.EventArgs e)
        {
            new FrmReportCompleted().ShowDialog();
        }

        private void btnDetailedReport_Click(object sender, System.EventArgs e)
        {
            new FrmDetailedReport().ShowDialog();
        }

        private void btnBackupAndRestore_Click(object sender, System.EventArgs e)
        {

        }
    }
}