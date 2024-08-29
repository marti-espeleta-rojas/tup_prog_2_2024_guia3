using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Muebles
{
    public class Mesa : Producto
    {
        private double largo;

        public Mesa(string descripcion, double precioBase, int tipoMaterial, double largo):base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }
        public override double CalcularPrecio()
        {
            double precio = (precioBase * largo) * (1 + tipoMaterial * 0.33);
            return precio;
        }
        public override string VerDetalle()
        {
            return $"Producto Mesa:\r\n - Material: {DescripMat}\r\n - Precio base: {precioBase}\r\n - Largo: {largo}\r\n - Precio: {CalcularPrecio():C2}";
        }
    }
}
