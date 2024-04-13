﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        public int Edad {  get; set; }

        public bool EsMayorEdad() {
            return Edad >= 18;
        }

    }
}
