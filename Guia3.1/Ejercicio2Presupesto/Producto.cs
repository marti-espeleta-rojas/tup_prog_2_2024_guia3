using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Muebles
{
    public abstract class Producto
    {
        private string descripcion;
        protected double precioBase;
        protected int tipoMaterial;
        protected string DescripMat
        {
            get
            {
                switch (tipoMaterial)
                {
                    case 0:
                        {
                            return "Pino";
                        }
                    case 1:
                        {
                            return "Algarrobo";
                        }
                    case 2:
                        {
                            return "Caoba";
                        }
                    default:
                        {
                            return "Inválido";
                        }
                }
            }
            private set { }
        }

        public Producto(string descripcion, double precioBase, int tipoMaterial)
        {
            this.descripcion = descripcion;
            this.precioBase = precioBase;
            this.tipoMaterial = tipoMaterial;
        }

        public abstract double CalcularPrecio();
        public abstract string VerDetalle();
    }
}
