﻿using BLL;
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
    public partial class FormCadastroEtapa : Form
    {
        int idTarefa;
        
        public FormCadastroEtapa(int _idTarefa = 0)
        {
            InitializeComponent();
            idTarefa = _idTarefa;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvarEtapa_Click(object sender, EventArgs e)
        {
                try
                {
                    new EtapaBLL().AdicionarEtapa(nomeEtapaTextBox.Text, Constantes.IdUsuarioLogado,idTarefa);
                    MessageBox.Show("Etapa inserida com sucesso!", "Concluido", MessageBoxButtons.OK);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarEtapa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroEtapa_Load(object sender, EventArgs e)
        {
        }

        private void buttonCancelarEtapa_Click_1(object sender, EventArgs e)
        {
            Close();
            
        }

        private void nomeEtapaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBoxResponsavel.Focus();
        }

        private void comboBoxResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                buttonSalvarEtapa_Click(null,null);
        }

        private void buttonCancelarEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.Close();


        }
    }
}
