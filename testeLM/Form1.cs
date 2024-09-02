namespace testeLM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMSG_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Nome:" + txtNome.Text + "" +
                "\nEmail:" + txtEmail.Text +
                "\nFone:" + txtFone.Text + "" +
                "\nData Nascimento:" + cbNasc.Text.ToString() +
                "\nNacionalidade: " + maskNac.Text +
                "\nEndereço: " + txtEndereco.Text +
                "\nN°: " + txtN.Text +
                "\nBairro:" + txtBairro.Text +
                "\nEstado: " + cbUF.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Dados recebidos:.";
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            maskNac.SelectedIndex = -1;
            txtFone.Text = string.Empty;
            txtEndereco.Text = "";
            txtN.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cbNasc.Text = string.Empty;
            cbUF.SelectedIndex = -1;
            txtNome.Focus();
        }

        private void btnLB_Click(object sender, EventArgs e)
        {
            lblResult.Text =
                  "Nome:" + txtNome.Text + "" +
                 "\nEmail:" + txtEmail.Text +
                 "\nFone:" + txtFone.Text + "" +
                 "\nData Nascimento:" + cbNasc.Text.ToString() +
                 "\nNacionalidade: " + maskNac.Text +
                 "\nEndereço: " + txtEndereco.Text +
                 "\nN°: " + txtN.Text +
                 "\nBairro:" + txtBairro.Text +
                 "\nEstado: " + cbUF.Text;
        }

       
    }
}
