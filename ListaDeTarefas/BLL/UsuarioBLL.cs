using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        public void AdicionarUsuario(Usuario _usuario)
        {
            new UsuarioDAL().AdicionarUsuario(_usuario);
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);  
        }
        public Usuario BuscarPorTodos()
        {
            throw new NotImplementedException();
            //return new UsuarioDAL().BuscarPorTodos();
        }
        public Usuario BuscarPorIdEtapa(int _id)
        {
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorEmail(string _email)
        {
            return new UsuarioDAL().BuscarPorEmail(_email); 
        }
        public void ExcluirUsuario(int _id)
        {
            new UsuarioDAL().ExcluirUsuario(_id);
        }
        public void AlterarUsuario(int _id, Usuario _usuario)
        {
            new UsuarioDAL().AlterarUsuario(_id, _usuario);
        }
    }
}
