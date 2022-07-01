using System.Windows.Forms;

namespace InfoSys
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            label_versao.Text = "Ver: 0.1.2.27";
        }

        private void pictureBoxClose_Click(object sender, System.EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btn_Adicionar_Click(object sender, System.EventArgs e)
        {
            FormCadCliente CadCliente = new FormCadCliente(0);
            CadCliente.Show();
        }

        private void pictureBoxMini_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
