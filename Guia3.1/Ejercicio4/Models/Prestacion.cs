using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    abstract public class Prestacion : Persona
    {
        public double MontoTotal { get; private set; }
        public Prestacion(string nombre, Prestador medico)
        {
            
        }
        abstract public double PrestarServicio();

    }
}
