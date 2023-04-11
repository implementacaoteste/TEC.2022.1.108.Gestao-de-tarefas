using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public string NomeTarefa { get; set; }
        public List<ListaDeTarefas> Lista { get; set; }
    }
}
