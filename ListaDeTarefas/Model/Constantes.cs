using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Constantes
    {
        public static int IdUsuarioLogado;
        public static int IdGrupoAberto;
        public static int IdAreaAberta;
        public static int PermissaoUsuario;
        public static string CaminhoChavePublica = "C:\\Configuracao\\ChavePublica.txt";
        public static string CaminhoChavePrivada = "C:\\Configuracao\\ChavePrivada.txt";

        public static string CaminhoArquivoLog 
        {
            get
            {
                string diretorio = Environment.CurrentDirectory + "\\Logs\\";
                Directory.CreateDirectory(diretorio);
                return diretorio + "Log" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".log";
            }
        }
    }
}
