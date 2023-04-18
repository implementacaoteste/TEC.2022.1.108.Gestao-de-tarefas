using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string NomeTarefa { get; set; }
        public List<ListaDeTarefas> ListaTarefas { get; set; }
        public List<Etapa> Etapa { get; set; }
    }
}
