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
            new UsuarioBLL().ValidarCadastro(_usuario);
            new UsuarioDAL().AdicionarUsuario(_usuario);
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarPorNome(_nome);  
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
            new UsuarioBLL().ValidarCadastro(_usuario);
            new UsuarioDAL().AlterarUsuario(_id, _usuario);
        }
        public void ValidarCadastro(Usuario _usuario)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorEmail(_usuario.Email);
            if (_usuario.Nome.Length < 3)
                throw new Exception("O nome deve ter 3 ou mais caracteres!");
            if (_usuario.Email == usuario.Email)
                throw new Exception("Já existe uma conta vinculada a esse email!");
            if (_usuario.Senha.Length < 8)
                throw new Exception("A senha deve ter 8 ou mais caracteres!");
        }
        public void ValidarLogin(string _email, string _senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorEmail(_email);

            if (_senha == usuario.Senha)
                Constantes.IdUsuarioLogado = usuario.Id;
            else 
                 throw new Exception("Usuário ou senha inválidos!"); 
        }
    }
}
