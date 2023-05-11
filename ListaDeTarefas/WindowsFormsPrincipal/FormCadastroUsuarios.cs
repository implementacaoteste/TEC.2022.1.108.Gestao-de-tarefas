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
    public partial class FormCadastroUsuarios : Form
    {
        public FormCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void FormCadastroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario();
            usuario.Nome = nomeTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.Senha = senhaTextBox.Text;

            try
            {
                new UsuarioBLL().AdicionarUsuario(usuario, textBoxConfirmarSenha.Text);
                MessageBox.Show("Cadastro efetuado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                emailTextBox.Focus();
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                senhaTextBox.Focus();  
        }

        private void senhaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                textBoxConfirmarSenha.Focus();
        }
    }
}
