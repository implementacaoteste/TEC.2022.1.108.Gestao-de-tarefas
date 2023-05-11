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
        public void AdicionarLista(int _id, int _usuario)
        {
            ListaDeTarefas_Usuario lista_usuario = new ListaDeTarefas_Usuario();
            List<Lista> ids = new ListaDAL().AdicionarLista(_id);
            for(int i = 0; i<3; i++)
            {
                lista_usuario.IdLista = ids[i].IdLista;
                lista_usuario.IdUsuario = _usuario;
                lista_usuario.IdPermissao = 1;
                new ListadeTarefas_UsuarioDAL().AdicionarListaUsuario(lista_usuario);
            }
            
        }
        public void ExcluirLista(int _id)
        {
            new ListaDAL().ExcluirLista(_id);
        }
        public List<Lista> buscarTarefasArea(int _idGrupo)
        {
            return new ListaDAL().buscarTarefasArea(_idGrupo);
        }
    }
}
