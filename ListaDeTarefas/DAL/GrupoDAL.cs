using System;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAL
{
    public class GrupoDAL
    {
        public Grupo BuscarPorIdGrupo(int id)
        {
            Grupo _grupo = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Titulo FROM Grupo WHERE @IdGrupo = IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupo",id);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        _grupo = new Grupo();
                        _grupo.Id = Convert.ToInt32(rd["ID"]);
                        _grupo.Titulo = rd["Titulo"].ToString();
                    }
                }
                return _grupo;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Id de Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Grupo BuscarPorIdUsuario(int _idUsuario)
        {
        
            Grupo _GrupoUsuario = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUsuario, Titulo FROM Usuario WHERE IdUsuario = @Idusuario ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _GrupoUsuario = new Grupo();
                        _GrupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        _GrupoUsuario.Titulo = rd["Titulo"].ToString();
                    }
                }
                return _GrupoUsuario;
            }

            catch (Exception ex)
            {
                throw new Exception($"ocorreu um erro ao buscar por id de usuário no Grupo", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Grupo BuscarPorTodosGrupos()
        {
            Grupo _GrupoUsuario = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Titulo FROM Grupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                cn.Close();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _GrupoUsuario = new Grupo();
                        _GrupoUsuario.Id = Convert.ToInt32(rd["IdGrupo"]);
                        _GrupoUsuario.Titulo = rd["Titulo"].ToString();
                    }
                }
                return _GrupoUsuario;
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
                cmd.CommandText = "SELECT Id,Titulo FROM Grupo WHERE Titulo LIKE @Titulo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", "%" + _titulo + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupo = new Grupo();
                        grupo.Id = Convert.ToInt32(rd["ID"]);
                        grupo.Titulo = rd["Titulo"].ToString();
                        Grupos.Add(grupo);
                    }
                }
                return Grupos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por Titulo  no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Buscar()
        {

        }
        public void AdicionarGrupo(Grupo _grupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Grupo(Titulo) Values(@Titulo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _grupo.Titulo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao inserir um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarGrupo(Grupo _grupo )
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE INTO Grupo(Id,Titulo) Values(@Id,@Titulo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _grupo.Id);
                cmd.Parameters.AddWithValue("@Titulo", _grupo.Titulo);
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao Alterar um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirGrupo(int IdGrupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Grupo WHERE IdGrupo = @IdGrupo", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdGrupo", IdGrupo );
                        cmd.Connection = cn;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Ocorreu um erro ao excluir um Grupo no banco de dados", ex);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
        public void Adicionar(Grupo _grupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Grupo(Titulo) Values(@Titulo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupo.Titulo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao inserir um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
