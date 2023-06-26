using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                cmd.CommandText = @"SELECT P.IdPermissao, P.Descricao
                                  FROM Permissoes P INNER JOIN ListadeTarefas_Usuario L 
                                  ON L.IdListaTarefas = @IdLista and L.IdUsuario = @IdUsuario and 
                                  L.IdPermissao = P.IdPermissao";
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
        public void AlterarPermissao(int _idU, int _idL, int _idP)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE ListadeTarefas_Usuario SET IdPermissao = @IdP
                                    WHERE IdUsuario = @IdU and IdListaTarefas = @IdL";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdP", _idP);
                cmd.Parameters.AddWithValue("@IdL", _idL);
                cmd.Parameters.AddWithValue("@IdU", _idU);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao alterar a permissao de um usuario", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool VerificarDuplicidade(ListaDeTarefas_Usuario _lista)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM ListadeTarefas_Usuario WHERE IdUsuario = @IdUsuario 
                                    and IdListaTarefas = @IdListaTarefas";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _lista.IdUsuario);
                cmd.Parameters.AddWithValue("@IdListaTarefas", _lista.IdLista);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao verificar a duplicidade de campos", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void ExcluirUsuario(int _idUsuario, int _idLista)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM ListadeTarefas_Usuario
                                    WHERE IdUsuario = @IdU and IdListaTarefas = @IdL";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdL", _idLista);
                cmd.Parameters.AddWithValue("@IdU", _idUsuario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um usuário da lista", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public bool VerificarExistencia(int _idLista)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM ListadeTarefas_Usuario WHERE 
                                    IdListaTarefas = @IdListaTarefas";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdListaTarefas", _idLista);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    return rd.Read();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao verificar a duplicidade de campos", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
