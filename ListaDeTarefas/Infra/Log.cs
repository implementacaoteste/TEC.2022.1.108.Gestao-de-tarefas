using Models;
using System;

namespace Infra
{
    public class Log
    {
        public static void Gravar(string _texto)
        {
            new Arquivo().GravarLinhaNoFinalDoArquivo(Constantes.CaminhoArquivoLog, DateTime.Now + ": " + _texto);
        }
    }
}
