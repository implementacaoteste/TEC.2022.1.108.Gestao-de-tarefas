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
        public void BuscarPorIdGrupo(int _lista)
        {
            new ListaDAL().BuscarPorIdLista(_lista);
        }
        public void BuscarPorTodasEtapas(int _lista)
        {
            new ListaDAL().BuscarPorIdLista(_lista);
        }
        public void AlterarLista(int _id, string _nome)
        {
            new ListaDAL().AlterarLista(_id, _nome);
        }
        public void AdicionarLista(Lista _lista)
        {
            new ListaDAL().AdicionarLista(_lista);
        }
        public void AlterarLista()
        {
            
        }
        public void ExcluirLista(int _id)
        {
            new ListaDAL().ExcluirLista(_id);
        }
    }
}
