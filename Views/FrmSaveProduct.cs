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
                new Product {Id = idProduct, Name = txtName.Text.Trim() }.Save();
                isSaved = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro no sistema. Tente novamente", "Notificação de aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
