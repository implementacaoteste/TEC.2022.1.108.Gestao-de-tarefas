using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void BuscarPorID()
        {

        }
        public void BuscarPorTodos()
        {

        }
        public void BuscarPorNome()
        {

        }
        public void BuscarPorEmail()
        {

        }
        public void BuscarPorSenha()
        {

        }
        public void AdicionarUsuario(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome, Email, Senha) 
                                VALUES (@Nome, @Email, @Senha)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no Banco de Dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarUsuario()
        {

        }
        public void ExcluirUsuario()
        {

        }

    }
}
