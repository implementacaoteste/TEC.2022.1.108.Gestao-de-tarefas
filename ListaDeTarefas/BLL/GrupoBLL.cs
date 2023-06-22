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
        public  void AdicionarGrupo(int _id)
        {
            Lista lista = new Lista();
            List<Grupo> ids =  new GrupoDAL().AdicionarGrupo(_id); 
            for(int i = 0; i < 3; i++)
            {
                new ListaBLL().AdicionarLista(ids[i].IdGrupo,_id);
            }
        }
        public void AlterarGrupo(string _titulo, int _idGrupo)
        {
            new GrupoBLL().ValidarTitulo(_titulo);
            new GrupoDAL().AlterarGrupo(_titulo, _idGrupo);
        }
        public List<Grupo> BuscarPorIdUsuario(int _id)
        {
            return new GrupoDAL().BuscarPorIdUsuario(_id);
        }
        private void ValidarTitulo(string _titulo)
        { 
            if(_titulo.Length < 3)
            {
                throw new Exception("O título do grupo deve ter mais de 3 caracteres!");
            }
        }
        public List<Grupo> buscarGruposArea(int _idUsuario)
        {
            return new GrupoDAL().buscarGruposArea(_idUsuario);
        }

    }
}
