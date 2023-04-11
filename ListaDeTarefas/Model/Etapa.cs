using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Etapa
    {
        public int Id { get; set; }
        public string NomeEtapa { get; set; }
        public List<Tarefa> Tarefas { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
