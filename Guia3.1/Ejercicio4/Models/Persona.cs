using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    abstract public class Persona
    {
        public string ApellidosNombre { get; set; }

        public Persona(string nombre)
        {
            ApellidosNombre = nombre;
        }
    }
}
