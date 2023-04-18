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
        public void Inserir()
        {

        }
        public Tarefa BuscarPorIdLsita(int _id)
        {
            return new TarefaDAL().BuscarPorIdLista(_id);
        }
        public void BuscarPorTodos()
        {
            new TarefaDAL().BuscarPorTodasTarefas();
        }
        public Tarefa  BuscarPorIdTarefa(int _id)
        {
            return new TarefaDAL().BuscarPorIdTarefa(_id);
        }
        public void Excluir()
        {

        }

    }
}
