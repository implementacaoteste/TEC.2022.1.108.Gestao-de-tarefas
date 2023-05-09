using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormCadastroDeGrupo : Form
    {
        public FormCadastroDeGrupo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonArea1_Click(object sender, EventArgs e)
        {
            try
            {
                //GrupoBLL grupoBLL = new GrupoBLL();
                //grupoBLL.AdicionarGrupo((Grupo)grupoBindingSource.Current);
            }
            catch (Exception ex)
            {
                throw new Exception("Errou ao salvar o grupo", ex);
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroDeGrupo_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void tituloTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
