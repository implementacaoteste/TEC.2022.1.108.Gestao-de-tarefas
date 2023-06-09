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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsPrincipal
{
    public partial class FormTelaIngresso : Form
    {
        public FormTelaIngresso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonIngressar_Click(object sender, EventArgs e)
        {
            string text;
            ListaDeTarefas_Usuario lista_usuario = new ListaDeTarefas_Usuario();
            string hex = textBoxCodigo.Text;
      
            text = new ListaDeTarefas_UsuarioBLL().AdicionarListaUsuario(lista_usuario, hex);
            MessageBox.Show(text);
            if(text == "Ingresso realizado com sucesso!")
                Close();

        }
    }
}
