using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormCadastroEtapa : Form
    {
        int idTarefa, idEtapa, idLista;
        
        public FormCadastroEtapa(int _idTarefa, int _idEtapa, int _idLista)
        {
            InitializeComponent();
            idTarefa = _idTarefa;
            idLista = _idLista;
            idEtapa = _idEtapa;
        }
        private void buttonSalvarEtapa_Click(object sender, EventArgs e)
        {
                int id = ((Etapa)etapaBindingSource.Current).Id;
                if (id == 0)
                {
                int valor = Convert.ToInt32(comboBoxPontos.Text);
                new EtapaBLL().AdicionarEtapa((Etapa)etapaBindingSource.Current, idTarefa, valor);
                    MessageBox.Show("Etapa inserida com sucesso!", "Concluido", MessageBoxButtons.OK);
                }
                else
                {
                    new EtapaBLL().AlterarEtapa((Etapa)etapaBindingSource.Current);
                    MessageBox.Show("Etapa alterada com sucesso!", "Concluido", MessageBoxButtons.OK);
                }
                    
                Close();
        }
        private void buttonCancelarEtapa_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormCadastroEtapa_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarUsuarioLista(idLista);
            if (idEtapa == 0)
            {
                etapaBindingSource.AddNew();
                dataDateTimePicker.Value =
                ((Etapa)etapaBindingSource.Current).Data = DateTime.Now.Date;
            }
            else
                etapaBindingSource.DataSource = new EtapaBLL().BuscarPorIdEtapa(idEtapa);
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
        private void dataDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                comboBoxPontos.Focus();
        }
        private void comboBoxPontos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSalvarEtapa_Click(null, null);
        }
        private void FormCadastroEtapa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonCancelarEtapa_Click(null, null);
        }
        private void comboBoxResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dataDateTimePicker.Focus();
        }

    }
}
