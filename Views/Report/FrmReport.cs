using DataBase;
using Interface.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmReport : Form
    {

        int page = 1, pageMaximum = 1;
        string name, dateEntry;

        public FrmReport()
        {
            InitializeComponent();
        }


        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
            }

            cbPage.Text = page.ToString();

            if (page == 1)
            {
                DisabledBtnArrowLeft();
                EnabledBtnArrowRight();
            }
            else
            {
                EnabledBtnArrowLeft();
            }
            
            LoadReport();
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            if (page < pageMaximum)
            {
                page++;
            }

            cbPage.Text = page.ToString();

            if (page == pageMaximum)
            {

                DisabledBtnArrowRight();

            }

            else
            {
                btnArrowLeft.Enabled = true;
                btnArrowLeft.Image = Resources.left_arrow_white;

            }

            EnabledBtnArrowLeft();
            LoadReport();
        }

        private void DisabledBtnArrowLeft()
        {
            btnArrowLeft.Enabled = false;
            btnArrowLeft.Image = Resources.left_arrow_grey;
        }

        private void DisabledBtnArrowRight()
        {
            btnArrowRight.Enabled = false;
            btnArrowRight.Image = Resources.right_arrow_grey;
        }

        private void EnabledBtnArrowLeft()
        {
            btnArrowLeft.Enabled = true;
            btnArrowLeft.Image = Resources.left_arrow_white;
        }

        private void EnabledBtnArrowRight()
        {
            btnArrowRight.Enabled = true;
            btnArrowRight.Image = Resources.right_arrow_white;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            cbPage.Text = "1";
            cbRows.Text = "10";
            LoadEvents();
            this.cbRows.SelectedIndexChanged += cbRows_SelectedIndexChanged;
            this.cbPage.SelectedIndexChanged += new System.EventHandler(this.cbPage_SelectedIndexChanged);
            this.dtDateEntry.ValueChanged += new System.EventHandler(this.dtDateEntry_ValueChanged);
        }

        private void CheckNumberOfPages(int numberRows)
        {
            PageData.quantityRowsSelected = numberRows;
            pageMaximum = PageData.SetPageQuantityRowsReport(name, dateEntry);
           
            if (pageMaximum > 1)
                EnabledBtnArrowRight();

        }

        private void LoadReport()
        {
            try
            {
                dgvReport.Rows.Clear();

                int quantRows = int.Parse(cbRows.Text);
                int pageSelected = (page - 1) * quantRows;              

                DataTable dtReport = Report.GetReport(name, dateEntry, pageSelected, quantRows);

                foreach (DataRow storage in dtReport.Rows)
                {
                    int index = dgvReport.Rows.Add();
                    dgvReport.Rows[index].Cells["ColName"].Value = storage["name"].ToString();
                    dgvReport.Rows[index].Cells["ColDateEntry"].Value = storage["date_storage"].ToString();
                    dgvReport.Rows[index].Cells["ColStock"].Value = storage["stock"].ToString();
                    dgvReport.Rows[index].Cells["ColQuantityExit"].Value = storage["quantity_exit"].ToString() != ""  ? storage["quantity_exit"].ToString() : "---";
                    dgvReport.Rows[index].Cells["ColDescription"].Value = storage["description"].ToString() != string.Empty ? storage["description"].ToString() : "---";
                    dgvReport.Rows[index].Cells["ColDateExit"].Value = storage["date_exit"].ToString() != string.Empty ? storage["date_exit"].ToString() : "---";
                    dgvReport.Rows[index].Height = 45;
                    dgvReport.Rows[index].Selected = false;
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateComboBoxItems()
        {
            cbPage.Items.Clear();
            for (int i = 1; i <= pageMaximum; i++)
            {
                cbPage.Items.Add(i);
            }

            cbPage.Text = (page > pageMaximum ? pageMaximum : page).ToString();
        }

        private void FrmProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Right && btnArrowRight.Enabled) btnArrowRight_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Left && btnArrowLeft.Enabled) btnArrowLeft_Click(sender, e);
        }

        private void LoadEvents()
        {
            dateEntry = cbDateEntry.Checked ? dtDateEntry.Value.ToString("yyyy-MM-dd") : null;
            name = cbName.Checked ? txtName.Text.Trim() : null;
            CheckNumberOfPages(int.Parse(cbRows.Text));
            UpdateComboBoxItems();
            LoadReport();
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEvents();
            if (page == pageMaximum)
            {
                DisabledBtnArrowLeft();
                DisabledBtnArrowRight();
            }
        }

        private void cbPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = int.Parse(cbPage.Text);
            if (pageMaximum == 1) return;

            LoadReport();

            if (page == 1)
            {
                DisabledBtnArrowLeft();
                EnabledBtnArrowRight();
            }
            else if (page == pageMaximum)
            {
                DisabledBtnArrowRight();
                EnabledBtnArrowLeft();
            }

            else
            {
                EnabledBtnArrowLeft();
                EnabledBtnArrowRight();
            }

        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = cbName.Checked == true;
            txtName.Focus();
            LoadEvents();
         
            if (!cbName.Checked)
            {
                txtName.Clear();
                name = null;
            }
        }

        private void cbDateEntry_CheckedChanged(object sender, EventArgs e)
        {
            dtDateEntry.Enabled = cbDateEntry.Checked == true;
            LoadEvents();

            if (pageMaximum == 1)
            {
                DisabledBtnArrowLeft();
                DisabledBtnArrowRight();
            }

            if (!cbDateEntry.Checked)
            {
                dateEntry = null;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            LoadEvents();
            
            if (pageMaximum == 1)
            {
                DisabledBtnArrowLeft();
                DisabledBtnArrowRight();
            }
        }

        private void dtDateEntry_ValueChanged(object sender, EventArgs e)
        {
            LoadEvents();
            if (pageMaximum == 1)
            {
                DisabledBtnArrowLeft();
                DisabledBtnArrowRight();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }       
    }
}