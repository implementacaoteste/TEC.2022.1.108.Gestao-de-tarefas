using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Etapa
    {
        public int Id { get; set; }
        public string NomeEtapa { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario { get; set; }
        public int Valor { get; set; }
        public DateTime Data {  get; set; }


    }
}
