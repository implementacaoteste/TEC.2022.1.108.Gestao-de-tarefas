using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        private static string stringDeConexao;
        public static string StringDeConexao
        {
            get
            {
                if (String.IsNullOrEmpty(stringDeConexao))
                    if (File.Exists("C:\\Users\\vsistema\\Desktop\\Configuracoes\\conexao.txt"))
                        stringDeConexao = File.ReadAllText("C:\\Users\\vsistema\\Desktop\\Configuracoes\\conexao.txt");
                    else throw new Exception("Você precisa criar à conexão com o banco de dados");
                return stringDeConexao;
            }
        }
    }
}
