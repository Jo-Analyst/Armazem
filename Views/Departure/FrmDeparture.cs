using DataBase;
using Interface.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmDeparture : Form
    {
        int page = 1, pageMaximum = 1, idDeparture, idStorage, quantityRegistered;

        public FrmDeparture(int idStorage, string nameProduct, int quantityRegistered)
        {
            InitializeComponent();
            lblNameProduct.Text = nameProduct;
            this.idStorage = idStorage;
            lblQuantityRegistered.Text =  quantityRegistered.ToString();
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
            LoadDepartures();
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
            LoadDepartures();
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
            dtDateExit.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            cbPage.Text = "1";
            cbRows.Text = "10";
            LoadEvents();
            this.cbRows.SelectedIndexChanged += cbRows_SelectedIndexChanged;
            this.cbPage.SelectedIndexChanged += new EventHandler(this.cbPage_SelectedIndexChanged);
        }

        private void CheckNumberOfPages(int numberRows)
        {
            PageData.quantityRowsSelected = numberRows;
            pageMaximum = PageData.SetPageQuantityDepartures(idStorage);

            if (pageMaximum > 1)
                EnabledBtnArrowRight();

        }

        private void LoadDepartures()
        {
            try
            {
                dgvDeparture.Rows.Clear();

                int quantRows = int.Parse(cbRows.Text);
                int pageSelected = (page - 1) * quantRows;

                DataTable dtDeparture =  Departure.FindByStorageId(idStorage, pageSelected, quantRows);

                foreach (DataRow storage in dtDeparture.Rows)
                {
                    int index = dgvDeparture.Rows.Add();
                    dgvDeparture.Rows[index].Cells["ColEdit"].Value = Resources.edit;
                    dgvDeparture.Rows[index].Cells["ColDelete"].Value = Resources.delete;
                    dgvDeparture.Rows[index].Cells["ColId"].Value = storage["id"].ToString();
                    dgvDeparture.Rows[index].Cells["ColDateExit"].Value = storage["date"].ToString();
                    dgvDeparture.Rows[index].Cells["ColQuantityExit"].Value = storage["quantity_exit"].ToString();
                    dgvDeparture.Rows[index].Cells["ColDescription"].Value = storage["description"].ToString();
                    dgvDeparture.Rows[index].Height = 45;
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
                btnRegisterExit.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();

        }

        private void LoadEvents()
        {
            CheckNumberOfPages(int.Parse(cbRows.Text));
            UpdateComboBoxItems();
            LoadDepartures();
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

            LoadDepartures();

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

        private void dgvDeparture_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvDeparture.Cursor = e.ColumnIndex == 0 || e.ColumnIndex == 1 ? Cursors.Hand : Cursors.Arrow;
        }

        private void btnRegisterExit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(rtDescription.Text))
            {
                MessageBox.Show("Descreva no campo 'Descrição' o motivo da saída", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try 
            {
                new Departure { dateExit = dtDateExit.Value, description = rtDescription.Text.Trim(), storageId = idStorage, id = idDeparture, quantity_exit = Convert.ToDouble(ndQuantityExit.Value) }.Save();

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

        private void dgvDeparture_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            bool isConfirmed = false;

            if (e.RowIndex == -1) return;

            int id = Convert.ToInt32(dgvDeparture.CurrentRow.Cells["ColId"].Value);
            
            if (dgvDeparture.CurrentCell.ColumnIndex == 0)
            {
                idDeparture = id;
                dtDateExit.Value = Convert.ToDateTime(dgvDeparture.CurrentRow.Cells["ColDateExit"].Value);
                ndQuantityExit.Value = Convert.ToDecimal(dgvDeparture.CurrentRow.Cells["ColQuantityExit"].Value);
                rtDescription.Text = dgvDeparture.CurrentRow.Cells["ColDescription"].Value.ToString();
                btnRegisterExit.Image = Resources.icons8_crie_um_novo_32;
                 btnRegisterExit.Text = "Atualizar";
                btnCancel.Visible = true;
            }
            else if (dgvDeparture.CurrentCell.ColumnIndex == 1)
            {
                DialogResult dr = MessageBox.Show($"Deseja mesmo excluir?", "Controle do almoxarifado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Departure.Delete(id);
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
            idDeparture = 0;
            dtDateExit.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            rtDescription.Clear();
            ndQuantityExit.Value = 1;
             btnRegisterExit.Image = Resources.icons8_plus_key_32;
             btnRegisterExit.Text = "Adicionar";
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
