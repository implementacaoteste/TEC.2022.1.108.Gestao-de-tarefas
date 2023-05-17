﻿using Models;
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
        public Usuario BuscarPorId(int _id)
        {
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUsuario, Nome,  Email, Senha FROM Usuario WHERE IdUsuario = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar um usuário pelo Id", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdUsuario, Nome, Email,Senha
                                  FROM Usuario WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);
                    }

                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario no banco de dados.", ex);
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
                cmd.CommandText = @"SELECT IdUsuario, Nome, Email, Senha
                                  FROM Usuario WHERE Email = @Email";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Email",_email );

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["IdUsuario"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.Senha = rd["Senha"].ToString();
                    }
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o email do usuario no banco de dados. ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public int AdicionarUsuario(Usuario _usuario)
        {
            int id = 0;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome, Email, Senha) 
                                VALUES (@Nome, @Email, @Senha)
                                SELECT IdUsuario FROM Usuario WHERE IdUsuario = SCOPE_IDENTITY()";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Connection = cn;
                cn.Open();


                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        id = Convert.ToInt32(rd["IdUsuario"]);
                    }
                }
                return id;
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
        public void AlterarUsuario(int _id, Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Usuario SET Nome=@Nome,Email=@Email,Senha=@Senha WHERE IdUsuario = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar um usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirUsuario(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Usuario WHERE IdUsuario = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um usuário no Banco de Dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarUsuarioLista(int _idLista)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT U.IdUsuario, U.Nome, L.IdListaTarefas
                                    FROM Usuario U
                                    INNER JOIN ListadeTarefas_Usuario L ON L.IdListaTarefas = @IdUsuario and U.IdUsuario = L.IdUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario",_idLista);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = (int)rd["IdUsuario"];
                        usuario.Nome = rd["Nome"].ToString();
                        usuarios.Add(usuario);
                    }

                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o usuario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> GerarRelatorio(int _idLista)
        {
            List<Usuario> _usuarios = new List<Usuario> { };
            Usuario _usuario = new Usuario();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select L.Score, U.Nome
                                    from ListadeTarefas_Usuario L
                                    inner join Usuario U  
                                    ON
                                    L.IdUsuario = U.IdUsuario and L.IdListaTarefas = @IdLista
                                    ORDER BY Score DESC";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdLista", _idLista);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    while (rd.Read())
                    {
                        _usuario = new Usuario();
                        _usuario.Nome = rd["Nome"].ToString();
                        _usuario.Score = Convert.ToInt32(rd["Score"]);
                        _usuarios.Add(_usuario);
                    }
                return _usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Descricao no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> GerarRelatorioCresc(int _idLista)
        {
            List<Usuario> _usuarios = new List<Usuario> { };
            Usuario _usuario = new Usuario();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select L.Score, U.Nome
                                    from ListadeTarefas_Usuario L
                                    inner join Usuario U  
                                    ON
                                    L.IdUsuario = U.IdUsuario and L.IdListaTarefas = @IdLista
                                    ORDER BY Score ASC";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdLista", _idLista);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    while (rd.Read())
                    {
                        _usuario = new Usuario();
                        _usuario.Nome = rd["Nome"].ToString();
                        _usuario.Score = Convert.ToInt32(rd["Score"]);
                        _usuarios.Add(_usuario);
                    }
                return _usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Descricao no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool ValidarPermissao(int _idUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select 1 from Permissoes
                inner join ListadeTarefas_Usuario on Permissoes.IdPermissao = ListadeTarefas_Usuario.IdPermissao
                where ListadeTarefas_Usuario.IdUsuario = @IdUsuario and Permissoes.IdPermissao = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar permissao,", ex);
            }

        }

    }
}
