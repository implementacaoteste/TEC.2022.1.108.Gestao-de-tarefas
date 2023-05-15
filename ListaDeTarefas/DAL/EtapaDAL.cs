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
        public Etapa BuscarPorIdEtapa(int IdEtapa)
        {
            Etapa etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdEtapa, NomeEtapa, IdUsuario, IdTarefa FROM Etapa WHERE IdEtapa = @IdEtapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", IdEtapa);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapa.IdTarefa = Convert.ToInt32(rd["IdTarefa"]);
                        etapa.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                    }
                }
                return etapa;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por id da etapa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorIdUsuario(int _idUsuario)
        {

            Etapa etapa = new Etapa();
            List<Etapa> etapas = new List<Etapa>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdEtapa, NomeEtapa, IdUsuario, IdTarefa FROM Etapa WHERE IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.IdTarefa = Convert.ToInt32(rd["IdTarefa"]);
                        etapa.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(etapa);
                    }
                }
                return etapas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar pelo Id do usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Etapa> BuscarPorIdTarefa(int _idTarefa)
        {
            Etapa etapa = new Etapa();
            List<Etapa> etapas = new List<Etapa>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdEtapa, NomeEtapa, IdUsuario, IdTarefa FROM Etapa WHERE IdTarefa = @IdTarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTarefa", _idTarefa);
                cn.Open();
                cmd.ExecuteNonQuery();
                
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.IdTarefa = Convert.ToInt32(rd["IdTarefa"]);
                        etapa.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        etapa.NomeEtapa = rd["NomeEtapa"].ToString();
                        etapas.Add(etapa);
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
        public List<Etapa> BuscarPorNomeEtapa(string _nome)
        {
            List<Etapa> etapas = new List<Etapa>();
            Etapa etapa = new Etapa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT IdEtapa,NomeEtapa,IdUsuario FROM Etapa WHERE NomeEtapa LIKE @NomeEtapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeEtapa", "%" + _nome + "%");
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdEtapa"]);
                        etapa.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
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
                cmd.CommandText = @"UPDATE Etapa SET NomeEtapa = @NomeEtapa, IdUsuario = @IdUsuario where IdEtapa = @IdEtapa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _etapa.IdUsuario);
                cmd.Parameters.AddWithValue("@NomeEtapa",_etapa.NomeEtapa);
                cmd.Parameters.AddWithValue("@IdEtapa", _etapa.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar uma etapa no banco de dados",ex);
            }
            finally 
            {
                cn.Close();
            }
        }
        public void ExcluirEtapa(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Etapa  WHERE IdEtapa = @IdEtapa ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdEtapa", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();               
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
        public void AdicionarEtapa(Etapa _etapa, int _idTarefa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Etapa(IdUsuario, IdTarefa, NomeEtapa) Values(@IdUsuario, @IdTarefa, @NomeEtapa)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _etapa.IdUsuario);
                cmd.Parameters.AddWithValue("@IdTarefa", _etapa.IdTarefa);
                cmd.Parameters.AddWithValue("@NomeEtapa", _etapa.NomeEtapa);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar adicionar uma etapa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}