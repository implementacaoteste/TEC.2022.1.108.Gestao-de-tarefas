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
    public partial class FormTelaPrincipal : Form
    {
        List<Grupo> grupos;
        List<Lista> listas;
        List<Lista> lista;
        int Area1, Area2, Area3, Area4, lista1, lista2, lista3;
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }
        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            using (FormTelaLogin frm = new FormTelaLogin())
            {
                try
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                grupos = new GrupoBLL().buscarGruposArea(Constantes.IdUsuarioLogado);


                buttonGrupo1.Text = grupos[0].Titulo;
                Area1 = grupos[0].IdGrupo;
                buttonGrupo2.Text = grupos[1].Titulo;
                Area2 = grupos[1].IdGrupo;
                buttonGrupo3.Text = grupos[2].Titulo;
                Area3 = grupos[2].IdGrupo;
                buttonGrupo4.Text = grupos[3].Titulo;
                Area4 = grupos[3].IdGrupo;

                listas = new ListaBLL().buscarTarefasArea(Area1);

                buttonArea1.Text = listas[0].NomeLista;
                lista1 = listas[0].IdLista;
                buttonArea2.Text = listas[1].NomeLista;
                lista2 = listas[1].IdLista;
                buttonArea3.Text = listas[2].NomeLista;
                lista3 = listas[2].IdLista;
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
            Constantes.IdGrupoAberto = grupos[0].IdGrupo;
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
            Constantes.IdGrupoAberto = grupos[1].IdGrupo;
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
            Constantes.IdGrupoAberto = grupos[2].IdGrupo;
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
            Constantes.IdGrupoAberto = grupos[3].IdGrupo;
            List<Lista> lista = new ListaBLL().buscarTarefasArea(Constantes.IdGrupoAberto);

            buttonArea1.Text = lista[0].NomeLista;
            listas[0].IdLista = lista[0].IdLista;
            buttonArea2.Text = lista[1].NomeLista;
            listas[1].IdLista = lista[1].IdLista;
            buttonArea3.Text = lista[2].NomeLista;
            listas[2].IdLista = lista[2].IdLista;
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
    }
}
    

  