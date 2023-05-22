using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListaDeTarefas_UsuarioBLL
    {
        public Permissao BuscarIdPermissao(int _idUsuario, int _idLista)
        {
            return new ListadeTarefas_UsuarioDAL().BuscarPorIdPermissao(_idUsuario, _idLista);
        }
        public void AdicionarListaUsuario(ListaDeTarefas_Usuario _listaUsuario)
        {
            if(VerificarDuplicidade(_listaUsuario))
                new ListadeTarefas_UsuarioDAL().AdicionarListaUsuario(_listaUsuario);
            else
                new Exception("Você já esta nessa Lista");
        }
        public bool VerificarDuplicidade(ListaDeTarefas_Usuario _lista)
        {
            return new ListadeTarefas_UsuarioDAL().VerificarDuplicidade(_lista);
        }
    }
}
