using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        /// <summary>
        ///  transforma un producto en su código
        /// </summary>
        /// <param name="p">producto</param>
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        /// <summary>
        ///  devuelve un string con los datos de un producto: descripción, código, precio y stock.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Producto: {0}\n", this.descripcion);
            sb.AppendFormat("Código: {0}\n", this.codigo);
            sb.AppendFormat("Precio: ${0}\n", this.precio);
            sb.AppendFormat("stock: {0}unidades\n", this.stock);
            return sb.ToString();
        }
    }
}
