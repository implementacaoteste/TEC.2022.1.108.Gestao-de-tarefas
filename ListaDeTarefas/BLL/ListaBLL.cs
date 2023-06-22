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
        public void AlterarLista(int _id, string _nome)
        {
            ValidarNome(_nome);
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
        public List<Lista> buscarTarefasArea(int _idGrupo)
        {
            return new ListaDAL().buscarTarefasArea(_idGrupo);
        }
        public void AtribuirPrivacidade(int _bit, int _idLista)
        {
            new ListaDAL().AtribuirPrivacidade(_bit, _idLista);
        }
        public bool ConferirPrivacidade(int _idLista)
        {
            return new ListaDAL().ConferirPrivacidade(_idLista);
        }
        public void ValidarNome(string _nome)
        {
            if(_nome.Length < 3)
            {
                throw new Exception("O nome da lista de tarefas deve ter mais de 3 caracteres!");
            }
        }
        public List<Lista> BuscarListasCompartilhadas(int _idUsuario)
        {
            return new ListaDAL().BuscarListasCompartilhadas(_idUsuario);
        }
    }
}
