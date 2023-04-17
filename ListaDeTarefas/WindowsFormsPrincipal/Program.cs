using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormTelaPrincipal());
           Usuario user = new Usuario();
            user.Nome = "teste";
            user.Email = "testes@gmail";
            user.Senha = "123";
            new UsuarioBLL().Inserir(user);

        }
    }
}
