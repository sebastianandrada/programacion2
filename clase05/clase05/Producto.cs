using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05
{
    class Producto
    {
        private String codigoDeBarra;
        private String marca;
        private float precio;

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public String GetMarca()
        {
            return this.codigoDeBarra;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static String mostrarProducto(Producto p)
        {
            return "producto: " + p.codigoDeBarra + "\n" + p.GetMarca() + "\n precio: " + p.GetPrecio() + "\n";
        }

        public static bool operator ==(Producto p, String marca)
        {
            return p.GetMarca() == marca;
        }

        public static bool operator !=(Producto p, String marca) {
            return p.GetMarca() != marca;
        }


        public static bool operator ==(Producto p1, Producto p2) {
            return p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1.GetMarca() != p2.GetMarca() || p1.codigoDeBarra != p2.codigoDeBarra;
        }

        public  Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
    }
}
