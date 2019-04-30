using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgraf
{

    class Boligrafo
    {
        //const int cantidadTintaMaxima = 100;

        private ConsoleColor color;
        private short tinta;
        private const short cantidadMaximaDeTinta = 100;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta >= 0 && tinta <= Boligrafo.cantidadMaximaDeTinta)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadMaximaDeTinta);
        }
        /// <summary>
        /// Pinta 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            string salida = "";
            ;
            int nuevo = this.GetTinta() - gasto;
            SetTinta(-12);
            
            if(this.tinta > 0)
            {
                for(int i = 0; i<gasto; i++)
                {
                    salida = salida + "*";
                }
                dibujo = salida;
                return true;
            } else
            {
                dibujo = "";
                return false;
            }
            
        }
    }
}
