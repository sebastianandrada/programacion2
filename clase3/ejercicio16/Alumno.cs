using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre; 

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            this.notaFinal = -1;
            if(this.nota1 >3 && this.nota2 >3)
            {
                Random random = new Random(10);
                System.Threading.Thread.Sleep(100);
                this.notaFinal = random.Next();
            }
        }

        public string Mostrar()
        {
            string notaFinal;
            string mostrar;

            if (this.notaFinal != -1)
            {
                notaFinal = "Nota final: " + this.notaFinal;
            }
            else
            {
                notaFinal = "alumno desaprobado";
            }
            mostrar = "Alumno :" + this.nombre + " " + this.apellido + " legajo: " + this.legajo + "\n " + notaFinal;
            return mostrar;
        }
    }
}
