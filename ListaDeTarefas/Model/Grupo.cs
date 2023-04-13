using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class Grupo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
