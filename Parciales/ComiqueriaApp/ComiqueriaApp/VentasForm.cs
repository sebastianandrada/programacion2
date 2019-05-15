using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Comiqueria comiqueria;
        private Producto productoSeleccionado;

        public VentasForm(Comiqueria comiqueria, Producto producto)
        {
            this.comiqueria = comiqueria;
            this.productoSeleccionado = producto;
            InitializeComponent();
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.lblPrecioFinal.Text = productoSeleccionado.Precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblCantidad.Text) <= productoSeleccionado.Stock)
            {
                comiqueria.Vender(productoSeleccionado, int.Parse(lblCantidad.Text));
                this.DialogResult = DialogResult.OK;
                Close();
            } else
            {
                MessageBox.Show("Haz superado el stock disponible, disminuye la cantidad");
            }
        }

        private void lblPrecioNumerico_Click(object sender, EventArgs e)
        {

        }
    }
}
