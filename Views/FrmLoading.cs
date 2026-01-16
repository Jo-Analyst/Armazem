using DataBase;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < 100)
            {
                pbLoading.Value += 5;
            }
            else
            {
                timer.Stop();
                this.Visible = false;
                try
                {
                    if(!DB.IsConnect())
                    {
                        MessageBox.Show("Não foi possível conectar ao servidor. Verifique as configurações.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        new FrmSetting().ShowDialog();
                        Application.Exit();
                        return;
                    }

                    DB.CreateDatabase();
                    DB.CreateTables();

                    new FrmControlArmazen().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um problema no servidor. Tente novamente. Caso o erro persista contate o suporte.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void lkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {

        }
    }
}
