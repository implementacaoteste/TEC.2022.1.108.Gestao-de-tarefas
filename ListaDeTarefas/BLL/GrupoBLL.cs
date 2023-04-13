using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoBLL
    {
        public  void Inserir()
        {
            new GrupoDAL().AdicionarGrupo();
        }
        public void Alterar()
        {
            new GrupoDAL().AlterarGrupo();
        }
        public void Buscar()
        {
            new GrupoDAL().Buscar();
        }
        public void BuscarPorTodos()
        {
            new GrupoDAL().BuscarPorTodosGrupos();
        }
        public void BuscarPorId()
        {
            new GrupoDAL().BuscarPorId();
        }
        public void Excluir()
        {
            new GrupoDAL().ExcluirGrupo();
        }
    }
}
