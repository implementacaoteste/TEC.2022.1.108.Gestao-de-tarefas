using BLL;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormMenuDeTarefas : Form
    {
        int idLista;
        public FormMenuDeTarefas(int _id)
        {
            InitializeComponent();
            idLista = _id;
            buttonBuscar_Click(_id, null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            tarefaBindingSource1.DataSource = new BLL.TarefaBLL().BuscarPorIdLista(idLista);
        }

        private void tarefaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
            int id2 = ((Tarefa)tarefaBindingSource1.Current).Id;
            using (FormCadastroEtapa frm = new FormCadastroEtapa(id2,idLista))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(idLista, null);
        }

        private void tarefaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonAlterarEtapa_Click(object sender, EventArgs e)
        {
            int id = ((Etapa)etapaBindingSource.Current).Id;
            using (FormCadastroEtapa frm = new FormCadastroEtapa(id, idLista))
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

        private void etapaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
