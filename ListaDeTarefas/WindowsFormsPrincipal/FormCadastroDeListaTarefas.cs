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
        private void FormCadastroDeListaTarefas_Load(object sender, EventArgs e)
        {
            nomeListaTextBox.Focus();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();  
        } 
        private void nomeListaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonArea1.Focus();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                new ListaBLL().AlterarLista(idLista, nomeListaTextBox.Text);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormCadastroDeListaTarefas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonSair_Click(null, null);
            else if (e.KeyCode == Keys.Enter)
                buttonSalvar_Click(null,null);
          
        }
    }
}
