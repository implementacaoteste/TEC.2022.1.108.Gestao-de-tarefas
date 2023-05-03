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
           ValidarDados(_grupo);
            GrupoDAL grupoDAL = new GrupoDAL();
            grupoDAL.AdicionarGrupo(_grupo);
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
        public List<Grupo> BuscarPorIdUsuario(int _id)
        {
            return new GrupoDAL().BuscarPorIdUsuario(_id);
        }
        private void ValidarDados(Grupo _grupo)
        { if(_grupo.Titulo.Length <= 3)
            throw new System.Exception("O nome do grupo deve ter mais de 3 caracteres");
        }
        public List<Grupo> buscarGruposArea(int _idUsuario)
        {
            return new GrupoDAL().buscarGruposArea(_idUsuario);
        }
    }
}
