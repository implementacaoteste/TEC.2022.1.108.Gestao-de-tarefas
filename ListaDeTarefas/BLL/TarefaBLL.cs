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

    }
}
