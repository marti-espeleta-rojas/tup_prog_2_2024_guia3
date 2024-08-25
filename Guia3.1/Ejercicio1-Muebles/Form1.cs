using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Muebles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList productos = new ArrayList();
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            tbPruebaConcepto.Clear();
            Producto produ1 = new Mesa("Mesa Comedor", 10.1, 1, 1);
            productos.Add(produ1);
            Producto produ2 = new Silla("Silla Escritorio", 12.2, 2);
            productos.Add(produ2);
            foreach (Producto producto in productos)
            {
                tbPruebaConcepto.Text += $"{producto.VerDetalle()}\r\n";
            }
        }
    }
}
