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
    public partial class FormCadastroDeListaTarefas : Form
    {
        int idLista;
        public FormCadastroDeListaTarefas(int _id)
        {
            InitializeComponent();
            idLista = _id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroDeListaTarefas_Load(object sender, EventArgs e)
        {
            nomeListaTextBox.Focus();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void buttonArea1_Click(object sender, EventArgs e)
        {
            try
            {
                new ListaBLL().AlterarLista(idLista, nomeListaTextBox.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar a lista", ex);
            }
        }

        private void nomeListaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonArea1.Focus();
        }

        private void buttonSair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonSair.Focus();
        }
    }
}
