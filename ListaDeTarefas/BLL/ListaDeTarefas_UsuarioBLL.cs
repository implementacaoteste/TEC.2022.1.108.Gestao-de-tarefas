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
    }
}
