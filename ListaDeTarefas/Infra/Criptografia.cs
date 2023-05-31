using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class Criptografia
    {
        private RSA rsa;
        public string CriptografarSenha(string _senha)
        {
            rsa = RSA.Create();
            string retorno = _senha;

            for(int i = 0; i < _senha.Length; i++)
            {
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno);
                retorno = GerarHash(retorno);
                retorno = ReverterTexto(retorno) + "alalalal";
                retorno = GerarHash(retorno);
            }
            return GerarHash(retorno);
        }
        public string GerarHash(string texto)
        {
            using (var Sha256 = SHA256.Create())
            {
                byte[] hashHeadBytes = Sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                return Convert.ToBase64String(hashHeadBytes);
            }
        }
        public string ReverterTexto(string texto)
        {
            char[] charArray = texto.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string 
    }
}
