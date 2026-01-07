using DataBase;
using Interface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmProductStock : Form
    {
        int page = 1, pageMaximum = 1, idProduct;

        public FrmProductStock(int idProduct, string nameProduct)
        {
            InitializeComponent();
            lblNameProduct.Text = nameProduct;
            this.idProduct = idProduct;
        }


        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FrmSaveProduct frmSaveProduct = new FrmSaveProduct();
            frmSaveProduct.ShowDialog();
            if (frmSaveProduct.isSaved)
            {
                LoadEvents();
            }
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
            LoadProducts();
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
            LoadProducts();
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

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            //cbPage.Text = "1";
            //cbRows.Text = "10";
            //LoadEvents();
            //this.cbRows.SelectedIndexChanged += cbRows_SelectedIndexChanged;
            //this.cbPage.SelectedIndexChanged += new System.EventHandler(this.cbPage_SelectedIndexChanged);
        }

        private void CheckNumberOfPages(int numberRows)
        {
            PageData.quantityRowsSelected = numberRows;
            pageMaximum = string.IsNullOrWhiteSpace(lblNameProduct.Text) ? PageData.SetPageQuantityProducts() : PageData.SetPageQuantityProductsByName(lblNameProduct.Text);

            if (pageMaximum > 1)
                EnabledBtnArrowRight();

        }

        private void LoadProducts()
        {
            try
            {
                dgvProduct.Rows.Clear();

                int quantRows = int.Parse(cbRows.Text);
                int pageSelected = (page - 1) * quantRows;

                DataTable dtProducts = string.IsNullOrWhiteSpace(lblNameProduct.Text) ? Product.FindAll(pageSelected, quantRows)
                    : Product.FindByName(lblNameProduct.Text.Trim(), pageSelected, quantRows);

                foreach (DataRow user in dtProducts.Rows)
                {
                    int index = dgvProduct.Rows.Add();
                    dgvProduct.Rows[index].Cells["ColADD"].Value = Resources.add_post;
                    dgvProduct.Rows[index].Cells["ColEdit"].Value = Resources.edit;
                    dgvProduct.Rows[index].Cells["ColDelete"].Value = Resources.delete;
                    dgvProduct.Rows[index].Cells["ColId"].Value = user["id"].ToString();
                    dgvProduct.Rows[index].Cells["ColName"].Value = user["name"].ToString();
                    dgvProduct.Rows[index].Height = 45;
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
            if (e.Control && e.KeyCode == Keys.N)
                btnNewProduct_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Right && btnArrowRight.Enabled) btnArrowRight_Click(sender, e);
            else if (e.Control && e.KeyCode == Keys.Left && btnArrowLeft.Enabled) btnArrowLeft_Click(sender, e);
        }

        private void LoadEvents()
        {
            CheckNumberOfPages(int.Parse(cbRows.Text));
            UpdateComboBoxItems();
            LoadProducts();
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

            LoadProducts();

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

        private void dgvProducts_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 ? Cursors.Hand : Cursors.Arrow;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bool isConfirmed = false;

            if (e.RowIndex == -1) return;

            int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ColId"].Value);
            string name = dgvProduct.CurrentRow.Cells["ColName"].Value.ToString();

            if (dgvProduct.CurrentCell.ColumnIndex == 0)
            {
                //new FrmCustomerService(id, name).ShowDialog();
            }
            else if (dgvProduct.CurrentCell.ColumnIndex == 1)
            {

                FrmSaveProduct frmProduct = new FrmSaveProduct(id, name);
                frmProduct.ShowDialog();
                if (frmProduct.isSaved)
                    isConfirmed = true;
            }
            else if (dgvProduct.CurrentCell.ColumnIndex == 2)
            {
                DialogResult dr = MessageBox.Show($"Deseja mesmo excluir o(a) usuário(a) {name} do sistema?", "Central Serviços", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Product.Delete(id);
                        isConfirmed = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (isConfirmed) LoadEvents();
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
    }
}
