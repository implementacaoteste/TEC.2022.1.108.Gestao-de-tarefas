using DAL;
using Infra;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        public void AdicionarUsuario(Usuario _usuario,string _confirmarSenha)
        {
            
            new UsuarioBLL().ValidarCadastro(_usuario, _confirmarSenha);
            _usuario.Senha = new Criptografia().CriptografarSenha(_usuario.Senha);
            int idUser = new UsuarioDAL().AdicionarUsuario(_usuario);
            new GrupoBLL().AdicionarGrupo(idUser);
            List<Grupo> lista = new GrupoBLL().BuscarPorIdUsuario(idUser);
        }
        public void ValidarCadastro(Usuario _usuario, string _confirmarSenha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorEmail(_usuario.Email);
            if (_usuario.Senha != _confirmarSenha)
                throw new Exception("A senha digitada não é a mesma da confirmação!");
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
            string senha = new Criptografia().CriptografarSenha(_senha);
            if (senha == usuario.Senha)
            {
                Constantes.IdUsuarioLogado = usuario.Id;
                Log.Gravar("O usuário logou como " + usuario.Nome);
            }
            else
                throw new Exception("Usuário ou senha inválidos!"); 
        }
        public List<Usuario> BuscarUsuarioLista(int _idLista)
        {
            return new UsuarioDAL().BuscarUsuarioLista(_idLista);
        }
        public List<Usuario> GerarRelatorio(int _idLista)
        {
            return new UsuarioDAL().GerarRelatorio(_idLista);
        }
        public List<Usuario> GerarRelatorioCresc(int _idLista)
        {
            return new UsuarioDAL().GerarRelatorioCresc(_idLista);
        }
    }
}
