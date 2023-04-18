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
    }
}
