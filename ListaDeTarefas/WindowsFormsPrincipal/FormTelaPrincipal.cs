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
        int Area1,Area2,Area3;
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo())
            {
                frm.ShowDialog();
            }
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

        }

        private void buttonArea2_Click(object sender, EventArgs e)
        {
            if (Area2 == 0)
            {
                using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(0))
                {
                    frm.ShowDialog();
                }
            }
            else if (Area2 != 0)
            {
                using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Area2))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void buttonArea3_Click(object sender, EventArgs e)
        {
            if (Area3 == 0)
            {
                using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(0))
                {
                    frm.ShowDialog();
                }
            }
            else if (Area3 != 0)
            {
                using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Area3))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void buttonGrupo1_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo())
            {
                frm.ShowDialog();
            }

        }

        private void buttonGrupo3_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeGrupo frm = new FormCadastroDeGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void buttonArea1_Click(object sender, EventArgs e)
        {
            if(Area1 == 0)
            {
                using (FormCadastroDeListaTarefas frm = new FormCadastroDeListaTarefas(0))
                {
                    frm.ShowDialog();
                }
            }
            else if(Area1 != 0)
            {
                using (FormMenuDeTarefas frm = new FormMenuDeTarefas(Area1))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
