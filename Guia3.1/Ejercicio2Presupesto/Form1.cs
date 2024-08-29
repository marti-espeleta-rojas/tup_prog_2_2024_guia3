using Ejercicio1_Muebles;
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

namespace Ejercicio2Presupesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAgregarProducto.Enabled = false;
            btnVerPresupuesto.Enabled = false;
        }
        ArrayList presupuestos = new ArrayList();
        Presupuesto presupuesto = null;
        int cont = 0;
        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            DatosDelCliente datos = new DatosDelCliente();
            if (datos.ShowDialog() == DialogResult.OK)
            {
                presupuesto = new Presupuesto(datos.tbNombre.Text, datos.tbDireccion.Text);
                lbNombre.Text = datos.tbNombre.Text;
                lbDirección.Text = datos.tbDireccion.Text;
                presupuestos.Add(presupuesto);
            }
            btnAgregarProducto.Enabled = true;
            btnIniciarPresupuesto.Enabled = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto;
            DatosDelProducto datosProducto = new DatosDelProducto();
            if (datosProducto.ShowDialog() == DialogResult.OK)
            {
                if (datosProducto.cbxTipoProducto.SelectedIndex == 0)
                {
                    producto = new Mesa(datosProducto.tbDescripcion.Text, Convert.ToDouble(datosProducto.tbPrecio.Text), Convert.ToInt32(datosProducto.cbxMaterial.SelectedIndex), Convert.ToDouble(datosProducto.tbLargo.Text));
                }
                else
                {
                    producto = new Silla(datosProducto.tbDescripcion.Text, Convert.ToDouble(datosProducto.tbPrecio.Text), Convert.ToInt32(datosProducto.cbxMaterial.SelectedIndex));
                }
                presupuesto.AgregarProducto(producto);
            }
            btnVerPresupuesto.Enabled = true;
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            VerPresupuesto ver = new VerPresupuesto();
            Producto produ = null;
            ver.tbVerPresupuesto.Text += $"Cliente: {presupuesto.Cliente}\r\nDirección: {presupuesto.Direccion}\r\n" +
                $"Items presupuestados: {presupuesto.CantidadProductos}\r\n";
            for (int i = 0; i < presupuesto.CantidadProductos; i++)
            {
                produ = presupuesto.VerProducto(i);
                ver.tbVerPresupuesto.Text += $"{produ.VerDetalle()}\r\n";
            }
            ver.ShowDialog();
            btnIniciarPresupuesto.Enabled = true;
        }
    }
}
