using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        /// <summary>
        /// Agregar a lo devuelto por el ToString de la clase base los datos del Comic(Autor y TipoComic).
        /// </summary>
        /// <returns>descripcion del comic</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Autor: {0}", this.autor);
            sb.AppendFormat("Tipo de Comic: {0}", this.tipoComic);
            return sb.ToString();
        }

        public enum TipoComic
        {
            Occidental, Oriental
        }
    }
}
