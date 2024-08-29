using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class SinObra : Persona
    {
        public string CUIT { get; set; }
        public double ImporteFijo = 250;

        public SinObra(string nombre, Prestador medico, string cuit) : base(nombre)
        {
            CUIT = cuit;
        }
        override public double PrestarServicio()
        {

        }
    }
}
