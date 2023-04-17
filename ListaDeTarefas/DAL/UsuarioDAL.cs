using Models;
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
        public Usuario BuscarPorTodos()
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome,Email, Senha FROM Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
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
                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuarios no banco de dados. ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorNome(string _nome)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email,Senha
                                  FROM Usuario WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
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
                throw new Exception("Ocorreu um erro ao tentar alterar o usuario no banco de dados. ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorEmail(string _email)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, NomeUsuario, Email, CPF, Ativo, Senha
                                  FROM Usuario WHERE Email LIKE @Email";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", "%" + _email + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
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
                throw new Exception("Ocorreu um erro ao tentar alterar o usuario no banco de dados. ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorSenha(string _senha)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Senha
                                  FROM Usuario WHERE Senha LIKE @Senha";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Senha", "%" + _senha + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
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
                throw new Exception("Ocorreu um erro ao tentar alterar o usuario no banco de dados. ", ex);
            }
            finally
            {
                cn.Close();
            }
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
        public void AlterarUsuario(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Usuario SET Nome=@Nome,Email=@Email,senha=@Senha WHERE IdUsuario = @IdUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao Alterar um usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirUsuario(int _idUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario = @IdUsuario", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = cn;
                        cn.Close();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Não foi possível excluir um usuário no banco de dados");
                    }
                    finally { cn.Close(); }
                }
            }
        }

    }
}
