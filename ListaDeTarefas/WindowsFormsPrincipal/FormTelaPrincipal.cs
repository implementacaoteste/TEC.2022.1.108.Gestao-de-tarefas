using BLL;
using Models;
using System;
using System.Collections.Generic;
using Infra;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormTelaPrincipal : Form
    {
        List<Grupo> grupos;
        List<Lista> listas;
        List<Lista> lista;
        int Area1, Area2, Area3, lista1, lista2, lista3;
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }
        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Gravar("Abrir a tela de login");
                using (FormTelaLogin frm = new FormTelaLogin())
                {
                    try
                    {
                        frm.ShowDialog();
                        if (!frm.Logou)
                        {
                            Log.Gravar("Usuário não logou e a aplicação será fechada. ");
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                try
                {
                    buttonIngressar.Visible = false;
                    dataGridViewCompartilhados.Visible = false;
                    grupos = new GrupoBLL().buscarGruposArea(Constantes.IdUsuarioLogado);

                    buttonGrupo1.Text = grupos[0].Titulo;
                    Area1 = grupos[0].IdGrupo;
                    buttonGrupo2.Text = grupos[1].Titulo;
                    Area2 = grupos[1].IdGrupo;
                    buttonGrupo3.Text = grupos[2].Titulo;
                    Area3 = grupos[2].IdGrupo;

                    listas = new ListaBLL().buscarTarefasArea(Area1);

                    buttonArea1.Text = listas[0].NomeLista;
                    lista1 = listas[0].IdLista;
                    buttonArea2.Text = listas[1].NomeLista;
                    lista2 = listas[1].IdLista;
                    buttonArea3.Text = listas[2].NomeLista;
                    lista3 = listas[2].IdLista;

                    Constantes.IdAreaAberta = Area1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch
            {

            }
        }
        private void FormTelaPrincipal_Load_1(object sender, EventArgs e)
        {

        }
        private void buttonGrupo1_Click(object sender, EventArgs e)
        {
            buttonIngressar.Visible = false;
            dataGridViewCompartilhados.Visible = false;
            Constantes.IdGrupoAberto = grupos[0].IdGrupo;
            buttonArea1.Visible = true;
            buttonArea2.Visible = true;
            buttonArea3.Visible = true;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void buttonGrupo2_Click(object sender, EventArgs e)
        {
            buttonIngressar.Visible = false;
            dataGridViewCompartilhados.Visible = false;
            Constantes.IdGrupoAberto = grupos[1].IdGrupo;
            buttonArea1.Visible = true;
            buttonArea2.Visible = true;
            buttonArea3.Visible = true;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void buttonGrupo3_Click(object sender, EventArgs e)
        {
            buttonIngressar.Visible = false;
            dataGridViewCompartilhados.Visible = false;
            Constantes.IdGrupoAberto = grupos[2].IdGrupo;
            buttonArea1.Visible = true;
            buttonArea2.Visible = true;
            buttonArea3.Visible = true;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void buttonGrupo4_Click(object sender, EventArgs e)
        {
            bindingSourceListaCompartilhados.DataSource = new ListaBLL().BuscarListasCompartilhadas(Constantes.IdUsuarioLogado);
            buttonIngressar.Visible = true;
            dataGridViewCompartilhados.Visible = true;
            buttonArea1.Visible = false;
            buttonArea2.Visible = false;
            buttonArea3.Visible = false;
        }
        private void buttonArea1_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[0].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void buttonArea2_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[1].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void buttonArea3_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[2].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void abrirToolStripGrupo1_Click(object sender, EventArgs e)
        {
            Constantes.IdGrupoAberto = grupos[0].IdGrupo;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void renomearToolStripGrupo1_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo(grupos[0].IdGrupo))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }
        private void abrirToolStripGrupo2_Click(object sender, EventArgs e)
        {
            Constantes.IdGrupoAberto = grupos[1].IdGrupo;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void renomearToolStripGrupo2_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo(grupos[1].IdGrupo))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }
        private void abrirToolStripGrupo3_Click(object sender, EventArgs e)
        {
            Constantes.IdGrupoAberto = grupos[2].IdGrupo;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
        }
        private void renomearToolStripGrupo3_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo(grupos[2].IdGrupo))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }
        private void abrirToolStripArea1_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[0].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void renomearToolStripArea1_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(listas[0].IdLista))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }
        private void abrirToolStripArea2_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[1].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void renomearToolStripArea2_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(listas[1].IdLista))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }

        private void buttonIngressar_Click(object sender, EventArgs e)
        {
            using (FormTelaIngresso frm = new FormTelaIngresso())
            {
                frm.ShowDialog();
            }
        }

        private void dataGridViewCompartilhados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void abrirToolStripArea3_Click(object sender, EventArgs e)
        {
            Constantes.IdAreaAberta = listas[2].IdLista;
            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        private void renomearToolStripArea3_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(listas[2].IdLista))
            {
                frm.ShowDialog();
            }
            RecarregarTelaPrincipal();
        }
        private void FormTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonSair_Click(null, null);

        }
        private void DoubleClick_Lista(object sender, DataGridViewCellEventArgs e)
        {
            Constantes.IdAreaAberta = ((Lista)bindingSourceListaCompartilhados.Current).IdLista;

            using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Constantes.IdAreaAberta))
            {
                frm.ShowDialog();
            }
        }
        public void RecarregarTelaPrincipal()
        {
            try
            {
                grupos = new GrupoBLL().buscarGruposArea(Constantes.IdUsuarioLogado);


                buttonGrupo1.Text = grupos[0].Titulo;
                Area1 = grupos[0].IdGrupo;
                buttonGrupo2.Text = grupos[1].Titulo;
                Area2 = grupos[1].IdGrupo;
                buttonGrupo3.Text = grupos[2].Titulo;
                Area3 = grupos[2].IdGrupo;
                

                listas = new ListaBLL().buscarTarefasArea(Constantes.IdAreaAberta);

                buttonArea1.Text = listas[0].NomeLista;
                lista1 = listas[0].IdLista;
                buttonArea2.Text = listas[1].NomeLista;
                lista2 = listas[1].IdLista;
                buttonArea3.Text = listas[2].NomeLista;
                lista3 = listas[2].IdLista;
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }

    }
}
    

  