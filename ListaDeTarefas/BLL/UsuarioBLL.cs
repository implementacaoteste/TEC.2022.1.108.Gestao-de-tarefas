using DAL;
using Model;
using System;
using System.Collections.Generic;
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
