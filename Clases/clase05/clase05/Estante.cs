using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad) {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos() {
            return this.productos;
        }

        public static string MostrarEstante(Estante e) {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Estante {0}", e.ubicacionEstante);
            for (int i = 0; i < e.productos.Length; i++) {
                if (!(Object.ReferenceEquals(e.productos[i], null))) {
                    builder.AppendLine(Producto.mostrarProducto(e.productos[i]));
                }
            }
            return builder.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto prd in e.GetProductos())
            {
                if(!(Object.ReferenceEquals(prd, null)) && prd == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            Producto[] productos = e.GetProductos();
            if (e != p)
            {
           
                
                for(int i = 0; i<productos.Length; i++)
                {
                    if(!Object.ReferenceEquals(productos[i], null))
                    {
                        productos[i] = p;
                        retorno = true;
                        break;
                    }
                }

            }
            return retorno;
        }

        /*private int estantesOcupados(Estante e)
        {
            
            for(int i = 0; i < e.productos.Length; i++){
                if(Object.ReferenceEquals(productos[i], null){
                    return i;
                    break;
                }
            }
        }*/

        public static Estante operator -(Estante e, Producto p)
        {
            Estante retorno = null;
            Producto[] productos = e.GetProductos();
            if ( e == p){
                for(int i = 0; i<productos.Length; i++)
                {
                    if(productos[i] == p){
                        productos[i] = null;
                    }
                }
            }
            return retorno;
        }
    }
}
