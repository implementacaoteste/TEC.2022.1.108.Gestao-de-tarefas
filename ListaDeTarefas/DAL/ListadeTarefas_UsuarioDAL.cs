using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadeTarefas_UsuarioDAL
    {
        public void AdicionarListaUsuario(ListaDeTarefas_Usuario _lista_usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ListadeTarefas_Usuario(IdListaTarefas, IdUsuario, IdPermissao) 
                                    Values(@IdListaTarefas, @IdUsuario, @IdPermissao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdListaTarefas", _lista_usuario.IdLista );
                cmd.Parameters.AddWithValue("@IdUsuario", _lista_usuario.IdUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _lista_usuario.IdPermissao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao inserir uma relação Lista<>Usuario<>Permissao Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
