using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Boligrafo
    {
        const int cantidadTintaMaxima = 100;

        public short cantidadMaximaDeTinta;
        private ConsoleColor color;
        private short tinta;

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
            if(tinta >= 0 && tinta <= this.cantidadMaximaDeTinta)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            this.SetTinta(this.cantidadMaximaDeTinta);
        }

    }
}
