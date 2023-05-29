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
    public class TarefaBLL 
    {
        public void AdicionarTarefa(string _nome, int _id)
        {
            new TarefaDAL().AdicionarTarefa(_nome,_id);
        }
        public Tarefa BuscarPorIdTarefa(int _id)
        {
            return new TarefaDAL().BuscarPorIdTarefa(_id);
        }
        public void AlterarTarefa(string _nome, int _id)
        {
            new TarefaDAL().AlterarTarefa(_nome, _id);
        }
        public void ExcluirTarefa(int _id)
        {
            new TarefaDAL().ExcluirTarefa(_id);
        }
        public void ValidarTarefa()
        {

        }
        public List<Tarefa> BuscarPorIdLista(int _idLista)
        {
            return new TarefaDAL().BuscarPorIdLista(_idLista);
        }
        public List<Tarefa> BuscarAtrasado(int _idUsuarioLogado, int _idTarefa,int _idLista)
        {
            return new TarefaDAL().BuscarAtrasado(_idUsuarioLogado, _idTarefa, _idLista);
        }
        public List<Tarefa> BuscarAtribuido(int _idTarefa, int _idUsuario, int _idLista)
        {
            return new TarefaDAL().BuscarAtribuido(_idTarefa,_idUsuario, _idLista);
        }
    }
}