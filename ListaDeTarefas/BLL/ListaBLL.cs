using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ListaBLL
    {
        public Lista BuscarPorIdLista(int _id)
        {
            return new ListaDAL().BuscarPorIdLista(_id);
        }
        public void BuscarPorIdGrupo(int _id)
        {
            new ListaDAL().BuscarPorIdGrupo(_id);
        }
        public void AlterarLista(int _id, string _nome)
        {
            new ListaDAL().AlterarLista(_id, _nome);
        }
        public void AdicionarLista(string _titulo)
        {
            ListaDeTarefas_Usuario lista_usuario = new ListaDeTarefas_Usuario();

            lista_usuario.IdLista = new ListaDAL().AdicionarLista(Constantes.IdGrupoAberto, _titulo);
            lista_usuario.IdUsuario = Constantes.IdUsuarioLogado;
            lista_usuario.IdPermissao = 1;
        }
        public void ExcluirLista(int _id)
        {
            new ListaDAL().ExcluirLista(_id);
        }

    }
}
