﻿using BLL;
using Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsPrincipal
{
    public partial class FormMenuDeTarefas : Form
    {
        int idLista;
        int idUsuarioLogado = Constantes.IdUsuarioLogado;
        int idListaAberta = Constantes.IdAreaAberta;

        public FormMenuDeTarefas(int _id)
        {
            InitializeComponent();
            idLista = _id;
            buttonBuscar_Click(_id, null);
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
            if(checkBoxAtrasado.Checked == false)
                tarefaBindingSource1.DataSource = new BLL.TarefaBLL().BuscarPorIdLista(idLista);
            else if(checkBoxAtrasado.Checked == true)
            {
                int id = ((Tarefa)tarefaBindingSource1.Current).Id;
                tarefaBindingSource1.DataSource = new BLL.TarefaBLL().BuscarAtrasado(Constantes.IdUsuarioLogado, id, idLista);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarTarefas frm = new FormCadastrarTarefas(idLista, 0))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(idLista, null);
        }
        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (tarefaBindingSource1.Count <= 0)
            {
                MessageBox.Show("Escolha um registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Tarefa)tarefaBindingSource1.Current).Id;
            new TarefaBLL().ExcluirTarefa(id);
            tarefaBindingSource1.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Tarefa)tarefaBindingSource1.Current).Id;
            using (FormCadastrarTarefas frm = new FormCadastrarTarefas(idLista, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(idLista, null);
        }
        private void buttonInserirEtapa_Click(object sender, EventArgs e)
        {
            int id = ((Tarefa)tarefaBindingSource1.Current).Id;
            using (FormCadastroEtapa frm = new FormCadastroEtapa(id, 0,idLista))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(idLista, null);
        }
        private void buttonAlterarEtapa_Click(object sender, EventArgs e)
        {
            int id = ((Etapa)etapaBindingSource.Current).Id;
            int id2 = ((Tarefa)tarefaBindingSource1.Current).Id;
            using (FormCadastroEtapa frm = new FormCadastroEtapa(id2, id, idLista))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(idLista, null);
        }           
        private void buttonDeletarEtapa_Click_1(object sender, EventArgs e)
        {
            if (tarefaBindingSource1.Count <= 0)
            {
                MessageBox.Show("Escolha um registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Etapa)etapaBindingSource.Current).Id;
            new EtapaBLL().ExcluirEtapa(id);
            etapaBindingSource.RemoveCurrent();
        }
        private void buttonVisualizarRanking_Click(object sender, EventArgs e)
        {
            using (FormRelatorio frm = new FormRelatorio(idLista))
            {
                frm.ShowDialog();
            }
        }
        private void FormMenuDeTarefas_Load(object sender, EventArgs e)
        {
            if (new ListaBLL().ConferirPrivacidade(Constantes.IdAreaAberta))
            {
                radioButtonPublico.Checked = true;
            }
            else
            {
                radioButtonPrivado.Checked = true;
            }

            Constantes.PermissaoUsuario = new ListaDeTarefas_UsuarioBLL().BuscarIdPermissao(idUsuarioLogado, idListaAberta).Id;
            switch (Constantes.PermissaoUsuario)
            {
                case 2:
                    buttonAlterar.Enabled = false;
                    buttonAlterarEtapa.Enabled = false;
                    buttonCodigo.Enabled = false;
                    buttonDeletar.Enabled = false;
                    buttonDeletarEtapa.Enabled = false;
                    buttonInserir.Enabled = false;
                    buttonInserirEtapa.Enabled = false;
                    radioButtonPrivado.Enabled = false;
                    radioButtonPublico.Enabled = false;
                    break;

                case 3:
                    checkBoxAtrasado.Enabled = false;
                    checkBoxAtribuicao.Enabled = false;
                    buttonAlterar.Enabled = false;
                    buttonAlterarEtapa.Enabled = false;
                    buttonCodigo.Enabled = false;
                    buttonDeletar.Enabled = false;
                    buttonDeletarEtapa.Enabled = false;
                    buttonInserir.Enabled = false;
                    buttonInserirEtapa.Enabled = false;
                    radioButtonPrivado.Enabled = false;
                    radioButtonPublico.Enabled = false;
                    break;
            }
        }
        private void radioButtonPrivado_CheckedChanged(object sender, EventArgs e)
        {
            new ListaBLL().AtribuirPrivacidade(0,Constantes.IdAreaAberta);
        }
        private void radioButtonPublico_CheckedChanged(object sender, EventArgs e)
        {
            new ListaBLL().AtribuirPrivacidade(1, Constantes.IdAreaAberta);
        }
        private void buttonCodigo_Click(object sender, EventArgs e)
        {
            labelCodigo.Text = Convert.ToString(Constantes.IdAreaAberta,16);
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCodigo.Text = "**********";
            timer1.Enabled = false;
        }
        private void checkBoxAtribuicao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxAtribuicao.Checked == true)
            {
                int id = ((Tarefa)tarefaBindingSource1.Current).Id;
                checkBoxAtrasado.Checked = false;
                tarefaBindingSource1.DataSource = new TarefaBLL().BuscarAtribuido(id, Constantes.IdUsuarioLogado, idLista);
            }
            else if (checkBoxAtrasado.Checked == false)
            {
                tarefaBindingSource1.DataSource = new TarefaBLL().BuscarPorIdLista(idLista);
            }
        }
        private void checkBoxAtrasado_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAtrasado.Checked == true)
            {
                checkBoxAtribuicao.Checked = false;
                int id = ((Tarefa)tarefaBindingSource1.Current).Id;
                tarefaBindingSource1.DataSource = new TarefaBLL().BuscarAtrasado(Constantes.IdUsuarioLogado, id,idLista);
            }
            else if (checkBoxAtrasado.Checked == false)
            {
                tarefaBindingSource1.DataSource = new TarefaBLL().BuscarPorIdLista(idLista);
            }
        }
        private void FormMenuDeTarefas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.I)
                buttonInserir_Click(null, null);
            else
                if (e.Control && e.KeyCode == Keys.A)
                buttonAlterar_Click(null, null);
            else
                if (e.KeyCode == Keys.Escape)
                buttonSair_Click(null, null);
            else
                if (e.Control && e.KeyCode == Keys.D)
                buttonDeletar_Click(null, null);
            else
                if (e.Control && e.KeyCode == Keys.F1)
                buttonInserirEtapa_Click(null, null);
            else
                if (e.Control && e.KeyCode == Keys.F2)
                buttonAlterarEtapa_Click(null, null);
            else
                if (e.Control && e.KeyCode == Keys.F3)
                buttonDeletarEtapa_Click_1(null, null);


            
        }
        private void etapaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
                return;

            int id = ((Etapa)etapaBindingSource.Current).Id;
            int score = ((Etapa)etapaBindingSource.Current).Valor;
            bool status = ((Etapa)etapaBindingSource.Current).Status;

            if (idUsuarioLogado == ((Etapa)etapaBindingSource.Current).IdUsuario || Constantes.PermissaoUsuario == 1)
                new EtapaBLL().StatusEtapa(id, score, idLista, status);
            else
                MessageBox.Show("Você não tem permissão para alterar o status dessa tarefa!", "Atenção!", MessageBoxButtons.OK);

            if (checkBoxAtrasado.Checked == false)
                buttonBuscar_Click(idLista, null);
        }
    }
}
