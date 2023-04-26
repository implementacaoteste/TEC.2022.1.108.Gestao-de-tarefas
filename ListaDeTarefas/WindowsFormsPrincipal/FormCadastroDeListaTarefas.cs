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
        public FormCadastroDeListaTarefas(int _referencia)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroDeListaTarefas_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void buttonArea1_Click(object sender, EventArgs e)
        {
            try
            {
                ListaBLL listaBLL = new ListaBLL();
                listaBLL.AdicionarLista((Lista)listaDeTarefasBindingSource.Current);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar a lista", ex);
            }
        }
    }
}
