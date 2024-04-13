using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Trabajador:Persona
    {
        public string Agencia { get; set; }
        public double Sueldo { get; set; }

        public double CalcularImpuesto()
        {
            return this.Sueldo * 0.18;
        }
    }
}
