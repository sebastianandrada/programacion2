using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        static Venta() {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioFinal = precioUnidad * cantidad;
            double iva = (precioFinal * porcentajeIva) / 100;
            precioFinal = precioFinal - iva;
            return precioFinal;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - {1} - {2}", this.Fecha, this.producto.Descripcion, this.precioFinal);
            return sb.ToString();
        }

        /*public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada2.Duracion > llamada1.Duracion)
            {
                retorno = -1;
            }
            return retorno;
        }*/
    }
}
