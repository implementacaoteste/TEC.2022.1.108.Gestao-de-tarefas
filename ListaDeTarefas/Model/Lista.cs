﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lista
    {
        public int IdLista { get; set; }
        public string NomeLista { get; set; }
        public int IdGrupo { get; set; }
        public int Codigo { get; set; } 
        public bool Privacidade { get; set; }
        public List<Usuario> Usuarios { get; set; } 
    }
}
