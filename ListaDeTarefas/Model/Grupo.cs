﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
     public class Grupo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
