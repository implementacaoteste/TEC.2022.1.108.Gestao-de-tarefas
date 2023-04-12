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
            ListaDALcs listaDALcs = new ListaDALcs();
            listaDALcs.AdicionarLista();
        }
        public void AlterarLista()
        {
            ListaDALcs listaDALcs = new ListaDALcs();
            listaDALcs.AlterarLista();
        }
        public void ExcluirLista()
        {
            ListaDALcs listaDALcs = new ListaDALcs();
            listaDALcs.ExcluirLista();
        }
    }
}
