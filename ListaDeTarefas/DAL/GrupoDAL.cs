using System;
using Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoDAL
    {
        public Grupo BuscarPorIdGrupo(int id)
        {
            Grupo _grupo = new Grupo();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT FROM Grupo WHERE @IdGrupo = IdGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupo",id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        _grupo.Id = Convert.ToInt32(rd["ID"]);
                    }
                }
                return _grupo;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Id de Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void BuscarPorIdUsuario()
        {

        }
        public void BuscarPorTodosGrupos()
        {
              
        }
        public void BuscarPorTitulo()
        {

        }
        public void Buscar()
        {

        }
        public void AdicionarGrupo(Grupo _grupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Grupo(Titulo) Values(@Titulo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _grupo.Titulo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro ao inserir um Grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void AlterarGrupo()
        {

        }
        public void ExcluirGrupo()
        {

        }
    }
}
