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
    public partial class FormMenuDeTarefas : Form
    {
        public FormMenuDeTarefas(int _id)
        {
            InitializeComponent();
            
            tarefaBindingSource1.DataSource = new BLL.TarefaBLL().BuscarPorIdLista(_id);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuDeTarefas_Load(object sender, EventArgs e)
        {

        }

        private void tarefaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tarefaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
