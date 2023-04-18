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
            //Usuario usuario = new Usuario();
            //usuario.Nome = "Danilo";
            //usuario.Email = "pudding@gmail.com";
            //usuario.Senha = "4400";
            //new UsuarioBLL().AdicionarUsuario(usuario);
            //new UsuarioBLL().AlterarUsuario(2,usuario);
            //new UsuarioBLL().ExcluirUsuario(1);

            //Grupo grupo = new Grupo();
            //grupo.IdUsuario = 3;
            //grupo.Titulo = "teste";
            //new GrupoBLL().AdicionarGrupo(grupo);

            //new GrupoBLL().AlterarGrupo("Tarefas", 1);
            //new GrupoBLL().ExcluirGrupo(1);
            //new GrupoBLL().BuscarPorTodos(3);

            ListaDeTarefas lista = new ListaDeTarefas();
            lista.NomeLista = "teste";
            lista.IdGrupo = 2;
            new ListaBLL().AdicionarLista(lista);
            
        }
    }
}
