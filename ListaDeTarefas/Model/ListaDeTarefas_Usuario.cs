using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class ListaDeTarefas_Usuario
    {
        public List<ListaDeTarefas> ListaDeTarefas { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Permissao> Permissoes { get; set; }

    }
}
