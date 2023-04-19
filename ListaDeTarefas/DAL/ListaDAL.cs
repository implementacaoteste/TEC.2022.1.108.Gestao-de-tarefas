using System;
using System.Collections.Generic;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ListaDAL
    {
        public void AdicionarLista(ListaDeTarefas _lista)
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
        public List<ListaDeTarefas> BuscarPorIdLista(int _id)
        {
            List<ListaDeTarefas> listas = new List<ListaDeTarefas>();
            ListaDeTarefas lista;
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
                        lista = new ListaDeTarefas();
                        lista.IdLista = Convert.ToInt32(rd["IdLista"]);
                        lista.NomeLista = rd["Nome"].ToString();
                       
                    }
                }
                return listas;
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
    }
}
