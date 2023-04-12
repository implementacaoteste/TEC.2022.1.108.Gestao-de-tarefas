using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public Usuario BuscarPorID(int _id)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome ,  Email, Senha FROM Usuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        


                    }
                }
                return usuario;
            }

            catch (Exception ex)
            {
                throw new Exception($"ocorreu um erro ao buscar por id", ex);
            }
            finally
            {
                cn.Close();
            }
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
        public void AdicionarUsuario()
        {

        }
        public void AlterarUsuario()
        {

        }
        public void ExcluirUsuario()
        {

        }

    }
}
