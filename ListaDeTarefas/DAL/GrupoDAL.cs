using System;
using Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography;

namespace DAL
{
    public class GrupoDAL
    {
        public void AdicionarGrupo(Grupo _grupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Grupo(Titulo, IdUsuario) Values(@Titulo, @IdUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _grupo.Titulo);
                cmd.Parameters.AddWithValue("@IdUsuario", _grupo.IdUsuario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao inserir um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarGrupo(string _titulo, int _idGrupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Grupo SET Titulo=@Titulo WHERE IdGrupo = @IdGrupo ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _titulo);
                cmd.Parameters.AddWithValue("@IdGrupo", _idGrupo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirGrupo(int _idGrupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Grupo WHERE IdGrupo = @IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdGrupo", _idGrupo);

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
        public List<Grupo> BuscarPorTodosGrupos(int _idUsuario)
        {
            List<Grupo> grupos = new List<Grupo>();
            Grupo grupo = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT Titulo FROM Grupo WHERE IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupo = new Grupo();                      
                        grupo.Titulo = rd["Titulo"].ToString();
                    }
                }
                return grupos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os Grupos no banco de dados", ex);
            }
            finally
            {
                cn.Close();


            }
        }
        public List<Grupo> BuscarPorTitulo(string _titulo)
        {
            List<Grupo> Grupos = new List<Grupo>();
            Grupo grupo = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdGrupo,Titulo, IdUsuario FROM Grupo WHERE Titulo LIKE @Titulo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", "%" + _titulo + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupo = new Grupo();
                        grupo.IdGrupo = Convert.ToInt32(rd["IdGrupo"]);
                        grupo.Titulo = rd["Titulo"].ToString();
                        grupo.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        Grupos.Add(grupo);
                    }
                }
                return Grupos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por título  no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Grupo> BuscarPorId(int _id)
        {
            List<Grupo> grupos = new List<Grupo> ();
            Grupo grupo;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdGrupo, Titulo  FROM Grupo WHERE IdGrupo = @IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupo", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupo  = new Grupo();
                        grupo.IdGrupo = Convert.ToInt32(rd["IdLista"]);
                        grupo.Titulo = rd["Nome"].ToString();

                    }
                }
                return grupos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar um usuário pelo Id ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
