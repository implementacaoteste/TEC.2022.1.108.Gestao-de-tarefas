using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ListaBLL
    {
        public List<ListaDeTarefas> BuscarPorIdLista(int _id)
        {
            return new ListaDAL().BuscarPorIdLista(_id);
        }
        public void BuscarPorIdGrupo()
        {
            
        }
        public void BuscarPorTodasEtapas()
        {

        }
        public void BuscarPorNomeLista()
        {

        }
        public void AdicionarLista(ListaDeTarefas _lista)
        {
            new ListaDAL().AdicionarLista(_lista);
        }
        public void AlterarLista()
        {
            
        }
        public void ExcluirLista()
        {
            
        }
    }
}
