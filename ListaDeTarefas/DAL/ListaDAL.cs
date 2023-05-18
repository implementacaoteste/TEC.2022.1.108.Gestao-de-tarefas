using System;
using System.Collections.Generic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Collections;

namespace DAL
{
    public class ListaDAL
    {
        
        public List<Lista> AdicionarLista(int _idGrupo)
        {            
            List<Lista> idsLista = new List<Lista>();
            Lista id;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);            
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ListaDeTarefas(NomeLista, IdGrupo) 
                                VALUES ('Lista 1', @IdGrupo) 
                                INSERT INTO ListaDeTarefas(NomeLista, IdGrupo) 
                                VALUES ('Lista 2', @IdGrupo) 
                                INSERT INTO ListaDeTarefas(NomeLista, IdGrupo) 
                                VALUES ('Lista 3', @IdGrupo) 
                                SELECT IdLista FROM ListaDeTarefas WHERE IdGrupo = @IdGrupo";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupo", _idGrupo);
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        id = new Lista();
                        id.IdLista = Convert.ToInt32(rd["IdLista"]);
                        idsLista.Add(id);
                    }
                }
                return idsLista;
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
        public List<Lista> buscarTarefasArea(int _idGrupo)
        {
            List<Lista> Listas = new List<Lista>();
            Lista lista = new Lista();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"select L.NomeLista, L.IdLista from ListaDeTarefas L INNER JOIN Grupo G on L.IdGrupo = G.IdGrupo where @IdUsuario = G.IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idGrupo);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        lista = new Lista();
                        lista.IdLista = Convert.ToInt32(rd["IdLista"]);
                        lista.NomeLista = rd["NomeLista"].ToString();
                        Listas.Add(lista);
                    }
                }
                return Listas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma lista no Banco de Dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AtribuirPrivacidade(int _bit, int _idLista)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE ListaDeTarefas SET Privacidade = @Bit WHERE IdLista = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Bit", _bit);
                cmd.Parameters.AddWithValue("@Id", _idLista);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar a privacidade da Lista de Tarefas", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool ConferirPrivacidade(int _idLista)
        {
            bool bit = false;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Privacidade  FROM ListaDeTarefas WHERE IdLista = @IdLista";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdLista", _idLista);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {                       
                        bit = Convert.ToBoolean(rd["Privacidade"]);

                    }
                }
                return bit;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar a privacidade de uma lista de tarefas", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Lista> BuscarListasCompartilhadas(int _idUsuario)
        {
            List<Lista> listas = new List<Lista>();
            Lista lista = new Lista();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT L.NomeLista FROM ListaDeTarefas L INNER JOIN ListadeTarefas_Usuario U " +
                                  "ON U.IdUsuario = @IdUsuario and L.IdLista = U.IdListaTarefas";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        lista = new Lista();
                        lista.NomeLista = rd["L.NomeLista"].ToString();
                        listas.Add(lista);
                    }
                }
                return listas;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar os grupos compartilhados!", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
