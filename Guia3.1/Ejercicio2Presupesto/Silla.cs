using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Muebles
{
    public class Silla : Producto
    {
        public Silla(string descripcion, double precioBase, int tipoMaterial) : base(descripcion, precioBase, tipoMaterial)
        {}
        override public double CalcularPrecio()
        {
            double precio = precioBase * (1 + tipoMaterial * 0.25);
            return precio;
        }
        public override string VerDetalle()
        {
            return $"Producto Silla: \r\n - Material: {DescripMat} \r\n - Precio base: {precioBase} \r\n - Precio: {CalcularPrecio():C2}";
        }
    }
}
