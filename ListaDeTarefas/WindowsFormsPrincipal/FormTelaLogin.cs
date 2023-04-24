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
        public FormTelaLogin()
        {
            InitializeComponent();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //new UsuarioBLL().Autenticar(textBoxLogin.Text, textBoxSenha.Text);
                //Logou = true;
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormTelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
