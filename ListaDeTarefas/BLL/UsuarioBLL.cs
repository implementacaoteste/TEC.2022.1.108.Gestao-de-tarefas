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
        public void Inserir(Usuario _usuario)
        {
            new UsuarioDAL().AdicionarUsuario(_usuario);
        }
        public void BuscarPorNome(string _nome)
        {
            new UsuarioDAL().BuscarPorNome(_nome);  
        }
        public Usuario BuscarPorTodos()
        {
            return new UsuarioDAL().BuscarPorTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new UsuarioDAL().BuscarPorID(_id);
        }
        public Usuario BuscarPorEmail(string _email)
        {
            return new UsuarioDAL().BuscarPorEmail(_email); 
        }
        public Usuario BuscarPorSenha(string _senha)
        {
            return new UsuarioDAL().BuscarPorSenha(_senha);
        }
        public void ExcluirUsuario()
        {
            
        }
        public void AlterarUsuario()
        {

        }
    }
}
