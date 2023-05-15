﻿using BLL;
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
    public partial class FormCadastrarTarefas : Form
    {
        int id_lista, controle;
        public FormCadastrarTarefas(int _id, int _controle)
        {
            InitializeComponent();
            id_lista = _id;
            controle = _controle;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (controle == 0)
            {
                try
                {
                    string nome = nomeTarefaTextBox.Text;
                    new TarefaBLL().AdicionarTarefa(nome, id_lista);
                    MessageBox.Show("Tarefa inserida com sucesso!", "Concluido", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
            else
            {
                try
                {
                    string nome = nomeTarefaTextBox.Text;
                    new TarefaBLL().AlterarTarefa(nome,controle);
                    MessageBox.Show("Tarefa alterada com sucesso!", "Concluido", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
        }

        private void buttonCriar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nomeTarefaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonCriar_Click(null, null);
        }

        private void FormCadastrarTarefas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                buttonSair_Click(null, null);
        }

        private void FormCadastrarTarefas_Load(object sender, EventArgs e)
        {
            if (controle == 0)
                tarefaBindingSource.AddNew();
            else
                tarefaBindingSource.DataSource = new TarefaBLL().BuscarPorIdTarefa(controle);
        }
    }
}
