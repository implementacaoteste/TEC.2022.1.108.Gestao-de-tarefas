using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoBLL
    {
        public  void AdicionarGrupo(Grupo _grupo)
        {
            new GrupoDAL().AdicionarGrupo(_grupo); 
        }
        public void AlterarGrupo(string _titulo, int _idGrupo)
        {
            new GrupoDAL().AlterarGrupo(_titulo, _idGrupo);
        }
        public void ExcluirGrupo(int _idGrupo)
        {
            new GrupoDAL().ExcluirGrupo(_idGrupo);
        }
        public List<Grupo> BuscarPorTitulo(string _titulo)
        {
            return new GrupoDAL().BuscarPorTitulo(_titulo);
        }
        public List<Grupo> BuscarPorTodos(int _idUsuario)
        {
            return new GrupoDAL().BuscarPorTodosGrupos(_idUsuario);
        }
        public List<Grupo> BuscarPorId(int _id)
        {
            return new GrupoDAL().BuscarPorId(_id);
        }
    }
}
