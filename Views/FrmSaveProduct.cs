using DataBase;
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
                    new FrmProductStock(product.Id, txtName.Text.Trim()).ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
