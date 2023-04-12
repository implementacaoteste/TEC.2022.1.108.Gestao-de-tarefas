using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissoesBLL
    {
        public void Inserir()
        {
            new PermissaoDAL().Inserir();
        }
        public void Buscar()
        {
            new PermissaoDAL().Buscar();
        }
        public void BuscarPorTodos()
        {
            new PermissaoDAL().BuscarPorTodasPermissoes();
        }
        public void BuscarPorId()
        {
            new PermissaoDAL().BuscarPorIdPermissao();
        }
        public void Excluir()
        {

        }
    }
}
