using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class Prestador : Persona
    {
        ArrayList consultas = new ArrayList();
        Prestacion prestacion = new Prestacion();
        public Prestador(string nombre):base(nombre)
        {

        }
        public void AgregarConsulta()
        {
            consultas.Add(prestacion);
        }
        public double GenerarPago()
        {
            double pago;
            return pago;
        }
    }
}
