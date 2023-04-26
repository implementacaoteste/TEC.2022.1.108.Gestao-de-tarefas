using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FormTelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
