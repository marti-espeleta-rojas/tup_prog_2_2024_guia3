using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class ObraSocial
    {
        public double Arancel = 200;
        public int ConsultasMensuales { get; private set; }

        public ObraSocial(string nombre, Prestador medico)
        {

        }
        override public double PrestarServicio()
        {

        }
    }

}
