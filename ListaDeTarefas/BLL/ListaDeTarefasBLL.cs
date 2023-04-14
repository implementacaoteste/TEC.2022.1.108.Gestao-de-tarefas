using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ListaDeTarefasBLL
    {
        public void BuscarPorIdLista()
        {
           
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
        public void AdicionarLista()
        {
            ListaDAL listaDALcs = new ListaDAL();
            listaDALcs.AdicionarLista();
        }
        public void AlterarLista()
        {
            ListaDAL listaDALcs = new ListaDAL();
            listaDALcs.AlterarLista();
        }
        public void ExcluirLista()
        {
            ListaDAL listaDALcs = new ListaDAL();
            listaDALcs.ExcluirLista();
        }
    }
}
