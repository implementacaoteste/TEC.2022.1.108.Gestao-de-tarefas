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
    public class TarefaDAL
    {
        public void BuscarPorIdTarefa(int _id)
        {
            Tarefa tarefa = new Tarefa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdTarefa,NomeTarefa FROM Tarefa WHERE IdTarefa = @IdTarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTarefa", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                    if (rd.Read())
                    {
                        tarefa.Id = Convert.ToInt32(rd["Id"]);
                        tarefa.NomeTarefa = rd["Descricao"].ToString();
                    }
                return;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Id de tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Buscar()
        {

        }
        public void BuscarPorIdLista()
        {

        }
        public List<Tarefa> BuscarPorTodasTarefas()
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            Tarefa tarefa;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdTarefa,NomeTarefa FROM Tarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                cn.Close();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                    }
                }
                return tarefas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos as Tarefas no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Tarefa> BuscarPorNomeTarefa(string _nomeTarefa)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            Tarefa tarefa = new Tarefa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdTarefa,NomeTarefa FROM Tarefa WHERE NomeTarefa LIKE @NomeTarefa";
                cmd.Parameters.AddWithValue("@NomeTarefa", "%" + _nomeTarefa + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                        tarefa.ListaTarefas = new ListaDAL().BuscarPorIdLista(tarefa.Id);
                        tarefas.Add(tarefa);
                    }
                }
                return tarefas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Nome de tarefa  no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AdicionarTarefa(Tarefa tarefa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Tarefa (NomeTarefa,IdTarefa) VALUES (@NomeTarefa,@IdTarefa)";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeTarefa", tarefa.NomeTarefa);
                cmd.Parameters.AddWithValue("@IdTarefa", tarefa.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
             }

            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar Inserir uma nova tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarTarefa(Tarefa tarefa)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE INTO Tarefa(IdTarefa,NomeTarefa) Values (@IdTarefa,@NomeTarefa)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTarefa", tarefa.Id);
                cmd.Parameters.AddWithValue("@NomeTarefa", tarefa.NomeTarefa);
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao Alterar uma Tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirTarefa(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Tarefa WHERE IdTarefa = @IdTarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Idtarefa", _id);
                cmd.Connection = cn;
                cn.Close();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao Excluir uma tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
