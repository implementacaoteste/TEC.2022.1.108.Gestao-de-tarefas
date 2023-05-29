using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TarefaDAL
    {
        public Tarefa BuscarPorIdTarefa(int _id)
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
                { 
                    if (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                    }
                }
                return tarefa;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma tarefa pelo id no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AdicionarTarefa(string _nome, int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Tarefa (NomeTarefa,IdListaDeTarefas) VALUES (@NomeTarefa, @IdListaDeTarefas)";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeTarefa", _nome);
                cmd.Parameters.AddWithValue("@IdListaDeTarefas",_id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
             }

            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma nova tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarTarefa(string _nome, int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Tarefa SET NomeTarefa=@NomeTarefa WHERE IdTarefa = @IdTarefa";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdTarefa", _id);
                cmd.Parameters.AddWithValue("@NomeTarefa", _nome);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar uma tarefa no banco de dados", ex);
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
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao Excluir uma tarefa no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Tarefa> BuscarPorIdLista(int _id)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            Tarefa tarefa = new Tarefa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdTarefa, NomeTarefa FROM Tarefa where IdListaDeTarefas = @IdLista";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdLista", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader()) 
                { 
                    
                    while (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                        tarefa.Etapa = new EtapaDAL().BuscarPorIdTarefa(tarefa.Id);
                        tarefas.Add(tarefa);
                    }
                }
                return tarefas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma tarefa pelo id no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Tarefa> BuscarAtrasado(int _idUsuarioLogado, int _idTarefa, int _idLista)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            Tarefa tarefa = new Tarefa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select Distinct T.IdTarefa, T.NomeTarefa from Tarefa T  
                                    INNER JOIN Etapa E ON E.Status = 0 and E.Data < CONVERT (date, GETDATE())
                                    Where T.IdListaDeTarefas = @IdListaDeTarefas and E.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuarioLogado);
                cmd.Parameters.AddWithValue("@IdListaDeTarefas", _idLista);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {

                    while (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                        tarefa.Etapa = new EtapaDAL().BuscarPorIdTarefaAtraso(_idTarefa, _idUsuarioLogado);
                        tarefas.Add(tarefa);
                    }
                }
                return tarefas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma tarefa pelo id no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Tarefa> BuscarAtribuido(int _idTarefa, int _idUsuario, int _idLista)
        {
            List<Tarefa> tarefas = new List<Tarefa>();
            Tarefa tarefa = new Tarefa();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select Distinct T.IdTarefa, T.NomeTarefa from Tarefa T
                                    INNER JOIN Usuario U ON U.IdUsuario = @IdUsuario
                                    where T.IdListaDeTarefas = @IdListaDeTarefas";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdListaDeTarefas", _idLista);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tarefa = new Tarefa();
                        tarefa.Id = Convert.ToInt32(rd["IdTarefa"]);
                        tarefa.NomeTarefa = rd["NomeTarefa"].ToString();
                        tarefa.Etapa = new EtapaDAL().BuscarPorEtapaAtribuida(_idTarefa, _idUsuario);
                        tarefas.Add(tarefa);
                    }
                }
                return tarefas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as tarefas atribuidas!", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
