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
        public void BuscarPorIdEtapa()
        {

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
            List<Etapa> etapas = new List<Etapa>();
            Etapa etapa = new Etapa();
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
                        etapa = new Etapa();
                        etapa.Id = Convert.ToInt32(rd["IdTarefa"]);
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
        public void BuscarPorTodasEtapas()
        {

        }
        public void BuscarPorNomeEtapa()
        {

        }
        public void AdicionarEtapa()
        {

        }
        public void AlterarEtapa(Etapa _etapa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE INTO Etapa(IdEtapa,NomeEtapa) Values(@IdEtapa,@NomeTarefa)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _etapa.Id);
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
        public void ExcluirEtapa()
        {

        }
    }
}
