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
        int idGrupo;
        public FormCadastroDeGrupo(int _id)
        {
            InitializeComponent();
            idGrupo = _id;
        }
        private void buttonArea1_Click(object sender, EventArgs e)
        {
            try
            {
                new GrupoBLL().AlterarGrupo(textBoxtitulo.Text,idGrupo);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroDeGrupo_Load(object sender, EventArgs e)
        {
            textBoxtitulo.Focus();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormCadastroDeGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonSair.Focus();
        }
        private void textBoxtitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonArea1_Click(null,null);
        }
    }
}
