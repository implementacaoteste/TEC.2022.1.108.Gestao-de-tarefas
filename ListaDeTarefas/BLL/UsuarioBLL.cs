using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.AdicionarUsuario();
        }
        public void BuscarPorNome()
        {
            
        }
        public void BuscarPorTodos()
        {

        }
        public void BuscarPorId()
        {

        }
        public void BuscarPorEmail()
        {

        }
        public void BuscarPorSenha()
        {

        }
        public void ExcluirUsuario()
        {
            new UsuarioDAL().ExcluirUsuario();
        }
        public void AlterarUsuario()
        {
            UsuarioDAL usuarioDAL=new UsuarioDAL();
            usuarioDAL.AlterarUsuario();
        }
    }
}
