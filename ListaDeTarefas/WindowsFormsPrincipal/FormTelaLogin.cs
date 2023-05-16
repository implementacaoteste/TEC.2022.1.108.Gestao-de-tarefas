using BLL;
using System;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormTelaLogin : Form
    {
        public bool Logou;
        public FormTelaLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarLogin(textBoxLogin.Text, textBoxSenha.Text);
                Logou = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FormCadastroUsuarios frm = new FormCadastroUsuarios())
            {
                frm.ShowDialog();
            }
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                 textBoxSenha.Focus();
        }
        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLogin_Click(null,null);
        }

        private void FormTelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormTelaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
