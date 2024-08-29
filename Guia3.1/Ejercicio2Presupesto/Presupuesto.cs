using Ejercicio1_Muebles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Presupesto
{
    public class Presupuesto
    {
        ArrayList presupuestados = new ArrayList(); //este arrlist va a tener todos los productos presupuestados que va a tener cada presupuesto.
        Producto producto = null;
        public int CantidadProductos { get; private set; }
        public double CostoTotal { get; private set; }
        public string Cliente { get; private set; }
        public string Direccion { get; private set; }

        public Presupuesto(string cliente, string direccion)
        {
            Cliente = cliente;
            Direccion = direccion;
        }

        public void AgregarProducto(Producto producto)
        {
            CantidadProductos++;
            CostoTotal += producto.CalcularPrecio();
            presupuestados.Add(producto);
        }

        public Producto VerProducto(int idx)
        {
            producto = (Producto)presupuestados[idx];
            return producto;
        }
    }
}
