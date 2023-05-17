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
                cmd.Parameters.AddWithValue("@IdListaTarefas", _lista_usuario.IdLista);
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
        public Permissao BuscarPorIdPermissao(int _idUsuario, int _idLista)
        {
            Permissao permissao = new Permissao();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT P.IdPermissao, P.Descricao" +
                                  "FROM Permissoes P INNER JOIN ListadeTarefas_Usuario L " +
                                  "ON L.IdListaTarefas = @IdLista and L.IdUsuario = @IdUsuario and " +
                                  "L.IdPermissao = P.IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdLista", _idLista);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["IdPermissao"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return permissao;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar a permissão pelo IdUsuario e IdLista", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
