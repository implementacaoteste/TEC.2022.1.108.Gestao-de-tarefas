using System;
using Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao permissao )
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Permissoes(IdPermissao,Descricao) Values(@IdPermissao,@Descricao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", permissao.Id);
                cmd.Parameters.AddWithValue("@Descricao", permissao.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao inserir uma permissão no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> Buscar(string _descricao)
        {
            List<Permissao> permissaos = new List<Permissao> { };
            Permissao _permissao = new Permissao();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdPermissao,Descricao FROM Permissoes WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    while (rd.Read())
                    {
                        _permissao = new Permissao();
                        _permissao.Id = Convert.ToInt32(rd["IdPermissao"]);
                        _permissao.Descricao = rd["Descricao"].ToString();
                    }
                return permissaos;
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
        public void BuscarPorIdPermissao(int _idPermissao)
        {
            Permissao permissao = new Permissao();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT FROM Permissoes IdPermissao,Descricao WHERE IdPermissao = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())

                    if (rd.Read())
                    {
                        permissao.Id = Convert.ToInt32(rd["IdPermissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();

                    }

                return;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Id de permissão no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            List<Permissao> permissaos = new List<Permissao> { };
            Permissao _permissao = new Permissao();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdPermissao,Descricao FROM Permissoes WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    while (rd.Read())
                    {
                        _permissao = new Permissao();
                        _permissao.Id = Convert.ToInt32(rd["IdPermissao"]);
                        _permissao.Descricao = rd["Descricao"].ToString();
                    }
                return permissaos;
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
        public List<Permissao> BuscarPorTodasPermissoes()
        {
            List<Permissao> permissaos = new List<Permissao>();
            Permissao permissao;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdPermissao,Descricao FROM Permissoes";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                cn.Close();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["IdPermissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return permissaos;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as permissões no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
