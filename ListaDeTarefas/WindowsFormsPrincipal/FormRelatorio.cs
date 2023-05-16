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
    }
}
