using DAL;
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
        public void Buscar()
        {
            new TarefaDAL().Buscar();
        }
        public void BuscarPorTodos()
        {
            new TarefaDAL().BuscarPorTodasTarefas();
        }
        public void BuscarPorId()
        {

        }
        public void Excluir()
        {

        }

    }
}
