using DataBase;
using Interface.Properties;
using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmStorage : Form
    {
        int page = 1, pageMaximum = 1, idProduct, idStorage, quantityRegistered, quantityExit;

        public FrmStorage(int idProduct, string nameProduct)
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
            LoadStorages();
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
            LoadStorages();
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
            dtDateEntry.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            cbPage.Text = "1";
            cbRows.Text = "10";
            LoadEvents();
            this.cbRows.SelectedIndexChanged += cbRows_SelectedIndexChanged;
            this.cbPage.SelectedIndexChanged += new EventHandler(this.cbPage_SelectedIndexChanged);
        }

        private void CheckNumberOfPages(int numberRows)
        {
            PageData.quantityRowsSelected = numberRows;
            pageMaximum = PageData.SetPageQuantityStorages(idProduct);

            if (pageMaximum > 1)
                EnabledBtnArrowRight();

        }

        private void LoadStorages()
        {
            try
            {
                dgvProduct.Rows.Clear();

                int quantRows = int.Parse(cbRows.Text);
                int pageSelected = (page - 1) * quantRows;

                DataTable dtStorages =  Storage.FindByProductId(idProduct, pageSelected, quantRows);

                foreach (DataRow storage in dtStorages.Rows)
                {
                    int index = dgvProduct.Rows.Add();
                    dgvProduct.Rows[index].Cells["ColRegisterExit"].Value = Resources.icons8_cash_register_32;
                    dgvProduct.Rows[index].Cells["ColEdit"].Value = Resources.edit;
                    dgvProduct.Rows[index].Cells["ColDelete"].Value = Resources.delete;
                    dgvProduct.Rows[index].Cells["ColId"].Value = storage["id"].ToString();
                    dgvProduct.Rows[index].Cells["ColDateEntry"].Value = storage["date"].ToString();
                    dgvProduct.Rows[index].Cells["ColQuantityStock"].Value = storage["stock"].ToString();
                    dgvProduct.Rows[index].Cells["ColQuantityExit"].Value = storage["total_exit"].ToString() == "" ? "0" : storage["total_exit"].ToString();
                    dgvProduct.Rows[index].Cells["ColBalance"].Value = storage["balance"].ToString() == "" ? "0" : storage["balance"].ToString();
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
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();

        }

        private void LoadEvents()
        {
            CheckNumberOfPages(int.Parse(cbRows.Text));
            UpdateComboBoxItems();
            LoadStorages();
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

            LoadStorages();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            {

                if (idStorage > 0)
                    if(!ValidationFields(quantityRegistered, quantityExit)) return;

                new Storage
                {
                    id = idStorage,
                    dateStorage = dtDateEntry.Value.ToString("yyyy-MM-dd"),
                    stock = double.Parse(ndQuantityStock.Value.ToString().Replace(",", ".")),
                    productId = idProduct
                }.Save();

                LoadEvents();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool ValidationFields(double quantityStock, double quantityExit)
        {
            bool isValid = false;

            if (Convert.ToDouble(ndQuantityStock.Value) < quantityExit)
            {

                MessageBox.Show("A quantidade da entrada inicial não pode ser menor que a quantidade que saíram do estoque", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else                 
                isValid = true;
            
            return isValid;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bool isConfirmed = false;

            if (e.RowIndex == -1) return;

            int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ColId"].Value);
            
            if (dgvProduct.CurrentCell.ColumnIndex == 0)
            {
                FrmDeparture frmDeparture = new FrmDeparture(Convert.ToInt32(dgvProduct.CurrentRow.Cells["ColId"].Value), lblNameProduct.Text.ToString(), Convert.ToInt32(dgvProduct.CurrentRow.Cells["ColQuantityStock"].Value)); 
                frmDeparture.ShowDialog();
                if(frmDeparture.isSaved)
                {
                    LoadEvents();
                }
            }
            else if (dgvProduct.CurrentCell.ColumnIndex == 1)
            {
                idStorage = id;
                dtDateEntry.Value = Convert.ToDateTime(dgvProduct.CurrentRow.Cells["ColDateEntry"].Value);
                ndQuantityStock.Value = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["ColQuantityStock"].Value);
                quantityExit = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ColQuantityExit"].Value);
                quantityRegistered = Convert.ToInt32(ndQuantityStock.Value);
                btnAdd.Image = Resources.icons8_crie_um_novo_32;
                btnAdd.Text = "Atualizar";
                btnCancel.Visible = true;
            }
            else if (dgvProduct.CurrentCell.ColumnIndex == 2)
            {
                DialogResult dr = MessageBox.Show($"Deseja mesmo excluir?", "Controle do almoxarifado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Storage.Delete(id);
                        isConfirmed = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (isConfirmed)
            {
                LoadEvents();
                Clear();
            }
        }

        private void Clear()
        {
            idStorage = 0;
            dtDateEntry.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ndQuantityStock.Value = 1;
            btnAdd.Image = Resources.icons8_plus_key_32;
            btnAdd.Text = "Adicionar";
            btnCancel.Visible = false;
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
