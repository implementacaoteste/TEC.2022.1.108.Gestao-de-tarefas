using System;
using System.Collections.Generic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class ListaDAL
    {
        public void AdicionarLista(Lista _lista)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ListaDeTarefas(NomeLista, IdGrupo) 
                                VALUES (@NomeLista, @IdGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeLista", _lista.NomeLista);
                cmd.Parameters.AddWithValue("@IdGrupo", _lista.IdGrupo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma lista de tarefas no Banco de Dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Lista BuscarPorIdLista(int _id)
        {
            Lista lista = new Lista();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdLista, NomeLista  FROM ListaDeTarefas WHERE IdLista = @IdLista";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdLista", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        lista = new Lista();
                        lista.IdLista = Convert.ToInt32(rd["IdLista"]);
                        lista.NomeLista = rd["NomeLista"].ToString();
                       
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar um usuário pelo Id da lista", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Lista> BuscarPorIdGrupo(int _id)
        {
            List<Lista> listas = new List<Lista>();
            Lista lista = new Lista();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IdLista, NomeLista  FROM ListaDeTarefas WHERE IdGrupo = @IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupo", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        lista = new Lista();
                        lista.IdLista = Convert.ToInt32(rd["IdLista"]);
                        lista.NomeLista = rd["NomeLista"].ToString();
                        listas.Add(lista);
                    }
                }
                return listas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar uma lista pelo id do grupo", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void ExcluirLista(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM ListaDeTarefas WHERE IdLista = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar a lista no Banco de Dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarLista(int _id,string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE ListaDeTarefas SET NomeLista=@NomeLista WHERE IdLista = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeLista", _nome);
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar uma lista no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
         
    }
}
