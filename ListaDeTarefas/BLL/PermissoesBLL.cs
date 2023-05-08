using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissoesBLL
    {
        public void Inserir(Permissao _permissao)
        {
            new PermissaoDAL().Inserir(_permissao);
        }
        public void BuscarPorTodos()
        {
            new PermissaoDAL().BuscarPorTodasPermissoes();
        }
        public Permissao BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarPorIdPermissao(_id);
        }
        public void ExcluirPermissao(int _id)
        {
            new PermissaoDAL().ExcluirPermissao(_id);
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            return new PermissaoDAL().BuscarPorDescricao(_descricao);
        }
    }
}
