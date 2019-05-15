using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                Producto retorno = null;
                foreach(Producto producto in this.productos)
                {
                    if((Guid)producto == codigo)
                    {
                        retorno = producto;
                        break;
                    }
                }
                return retorno;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        /// <summary>
        /// Cada elemento del diccionario corresponderá con cada producto en la lista de productos.
        /// La key será el código del producto y el valor la descripción del producto.
        /// </summary>
        /// <returns>devuelve un Dictionary</returns>
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> listaProductos = new Dictionary<Guid, string>();
            foreach(Producto producto in this.productos)
            {
                listaProductos.Add((Guid)producto, producto.Descripcion);
            }
            return listaProductos;
        }

        /// <summary>
        ///  devuelve un string conteniendo la descripción breve de cada venta en la lista de ventas
        /// </summary>
        /// <returns>string que describe las ventas</returns>
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ventas de la comiqueria");
            //OrdenarVentas();
            foreach (Venta venta in this.ventas)
            {
                sb.AppendLine("*******************");
                sb.Append(venta.ObtenerDescripcionBreve());
            }
            return sb.ToString();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool estaEnLista = false;
            foreach(Producto p in comiqueria.productos)
            {
                if(p.Descripcion == producto.Descripcion)
                {
                    estaEnLista = true;
                    break;
                }
            }
            return estaEnLista;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
        }

        /*public void OrdenarVentas()
        {
            this.ventas.Sort(Venta.OrdenarPorDuracion);
        }*/
    }
}
