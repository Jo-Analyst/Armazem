using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmSaveProduct : Form
    {

        public bool isSaved = false;
        int idProduct;

        public FrmSaveProduct()
        {
            InitializeComponent();
        }

        public FrmSaveProduct(int id, string name)
        {
            InitializeComponent();
            idProduct = id;
            txtName.Text = name;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = idProduct;
                product.Name = txtName.Text.Trim();
                product.Save();
                isSaved = true;
                this.Visible = false;

                if (idProduct == 0)
                    new FrmStorage(product.Id, txtName.Text.Trim()).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSaveProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }
    }
}
