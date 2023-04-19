using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EtapaDAL
    {
        public List<Etapa> BuscarPorIdEtapa(int IdEtapa)
        {
            List<Etapa> etapas = new List<Etapa>();
            Etapa etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdEtapa,NomeEtapa FROM Etapa WHERE IdEtapa = @IdEtapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", IdEtapa);
                cmd.ExecuteNonQuery();
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar Por Id de Usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorIdUsuario(int IdUsuario)
        {
            List<Etapa> etapas = new List<Etapa>();
            Etapa etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdUsuario,NomeEtapa FROM Etapa WHERE IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario",IdUsuario);
                cmd.ExecuteNonQuery();
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdUsuario"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar Por Id de Usuário no banco de dados",ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorIdTarefa(int IdTarefa)
        {
            Etapa _etapa = new Etapa();
            List<Etapa> etapas = new List<Etapa>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdTarefa,NomeEtapa FROM Etapa WHERE IdTarefa = @IdTarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTarefa", IdTarefa);
                cmd.ExecuteNonQuery();
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _etapa = new Etapa();
                        _etapa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        _etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(_etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar Por Id de tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorTodasEtapas(Etapa etapa)
        {
            List<Etapa> etapas = new List<Etapa>();
            Etapa _etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdEtapa,NomeEtapa FROM Etapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        _etapa = new Etapa();
                        _etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        _etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(_etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as Tarefas no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorNomeEtapa(Etapa _etapa)
        {
            List<Etapa> etapas = new List<Etapa>();
            Etapa etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT IdEtapa,NomeEtapa FROM Etapa WHERE NomeEtapa LIKE @NomeEtapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeEtapa", "%" + _etapa + "%");
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Buscar uma etapa por nome no banco de dados", ex);
            }
            finally 
            { 
                cn.Close(); 
            }
        }
        public void AlterarEtapa(Etapa _etapa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE INTO Etapa(IdEtapa,NomeEtapa) Values(@IdEtapa,@NomeTarefa)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", _etapa.Id);
                cmd.Parameters.AddWithValue("@NomeEtapa",_etapa.NomeEtapa);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma etapa no banco de dados",ex);
            }
            finally { cn.Close(); }
        }
        public void ExcluirEtapa(Etapa _etapa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Etapa  WHERE IdEtapa = @IdEtapa ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", _etapa.Id);
                cmd.Parameters.AddWithValue("@NomeEtapa", _etapa.NomeEtapa);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Excluir uma etapa no banco de dados", ex);
            }
            finally 
            { 
                cn.Close();
            }
        }
        public void AdicionarEtapa(Etapa _etapa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Etapa(IdEtapa,NomeEtapa) Values(@IdEtapa,@NomeTarefa)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", _etapa.Id);
                cmd.Parameters.AddWithValue("@NomeEtapa", _etapa.NomeEtapa);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Adicionar uma etapa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}