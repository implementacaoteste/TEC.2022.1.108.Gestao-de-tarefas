using DAL;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public void AdicionarListaUsuario(ListaDeTarefas_Usuario _listaUsuario, string _hex)
        {
            Lista lista = new ListaBLL().BuscarPorIdLista(int.Parse(_hex, System.Globalization.NumberStyles.HexNumber));
            _listaUsuario.IdLista = lista.IdLista;
            _listaUsuario.IdPermissao = 3;
            _listaUsuario.IdUsuario = Constantes.IdUsuarioLogado;
            if (new ListaDeTarefas_UsuarioBLL().VerificarExistencia(_listaUsuario.IdLista))
            {
                if (VerificarDuplicidade(_listaUsuario))
                { 
                    new ListadeTarefas_UsuarioDAL().AdicionarListaUsuario(_listaUsuario);
                }
                else
                    throw new Exception("Você já esta nessa Lista");
            }
            else
                throw new Exception("Essa lista não existe");

        }
        public bool VerificarDuplicidade(ListaDeTarefas_Usuario _lista)
        {
            return new ListadeTarefas_UsuarioDAL().VerificarDuplicidade(_lista);
        }
        public bool VerificarExistencia(int _idLista)
        {
            return new ListadeTarefas_UsuarioDAL().VerificarExistencia(_idLista);
        }
    }
}
