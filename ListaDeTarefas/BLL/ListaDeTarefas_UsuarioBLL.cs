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
        public string AdicionarListaUsuario(ListaDeTarefas_Usuario _listaUsuario, string _hex)
        {
            Lista lista = new ListaBLL().BuscarPorIdLista(int.Parse(_hex, System.Globalization.NumberStyles.HexNumber));
            _listaUsuario.IdLista = lista.IdLista;
            _listaUsuario.IdPermissao = 3;
            _listaUsuario.IdUsuario = Constantes.IdUsuarioLogado;
            if (new ListaDeTarefas_UsuarioBLL().VerificarExistencia(_listaUsuario.IdLista))
            {
                if (VerificarDuplicidade(_listaUsuario))
                    return "Você já esta nessa Lista";
                else
                {
                    if (lista.Privacidade)
                    {
                        new ListadeTarefas_UsuarioDAL().AdicionarListaUsuario(_listaUsuario);
                        return "Ingresso realizado com sucesso!";
                    }
                    else
                        return "Você não tem autorização para entrar nessa lista";
                }
            }
            else
                return "Essa lista não existe";

        }
        public void AlterarPermissao(int _idU, int _idL, int _idP)
        {
            new ListadeTarefas_UsuarioDAL().AlterarPermissao(_idU, _idL, _idP);
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
