using BLL;
using System;
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
    }
}
