using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormRelatorio : Form
    {
        int IdLista;
        public FormRelatorio(int _idLista)
        {
            IdLista = _idLista;
            InitializeComponent();
        }
        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new UsuarioBLL().GerarRelatorio(IdLista);
        }
        private void checkBoxDecrescente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDecrescente.Checked == true)
                checkBoxCrescente.Checked = false;

            usuarioBindingSource.DataSource = new UsuarioBLL().GerarRelatorio(IdLista);
        }
        private void checkBoxCrescente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrescente.Checked == true)
                checkBoxDecrescente.Checked = false;

            usuarioBindingSource.DataSource = new UsuarioBLL().GerarRelatorioCresc(IdLista);
        }
        private void FormRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeTarefas_Usuario listaUsuario = new ListaDeTarefas_Usuario();
            listaUsuario.IdLista = Constantes.IdAreaAberta;
            listaUsuario.IdUsuario = ((Usuario)usuarioBindingSource.Current).Id;
            if (Constantes.PermissaoUsuario == 1 && listaUsuario.IdUsuario != Constantes.IdUsuarioLogado)
            {
                new ListaDeTarefas_UsuarioBLL().AlterarPermissao(listaUsuario.IdUsuario, listaUsuario.IdLista, 3);
            } 
            else if(listaUsuario.IdUsuario == Constantes.IdUsuarioLogado)
                MessageBox.Show("Você não pode alterar sua própria permissão!", "Atenção!", MessageBoxButtons.OK);
            else
               MessageBox.Show("Você não tem autorização para alterar as permissões dos usuários!","Atenção!",MessageBoxButtons.OK);

        }
        private void padrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeTarefas_Usuario listaU = new ListaDeTarefas_Usuario();
            listaU.IdLista = Constantes.IdAreaAberta;
            listaU.IdUsuario = ((Usuario)usuarioBindingSource.Current).Id;
            if (Constantes.PermissaoUsuario == 1 && listaU.IdUsuario != Constantes.IdUsuarioLogado)
            {
                new ListaDeTarefas_UsuarioBLL().AlterarPermissao(listaU.IdUsuario, listaU.IdLista, 2);
            }
            if (listaU.IdUsuario == Constantes.IdUsuarioLogado)
                MessageBox.Show("Você não pode alterar sua própria permissão!", "Atenção!", MessageBoxButtons.OK);
            else
                MessageBox.Show("Você não tem autorização para alterar as permissões dos usuários!", "Atenção!", MessageBoxButtons.OK);
        }
    }
}
