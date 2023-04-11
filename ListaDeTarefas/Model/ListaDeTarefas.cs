using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class ListaDeTarefas
    {
        public int Id { get; set; }
        public string NomeLista { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
