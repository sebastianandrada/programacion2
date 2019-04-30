using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("peso: {0}\n", Peso);
            sb.AppendFormat("altura: {0}\n", Altura);
            sb.AppendFormat("posicion: {0}", Posicion);
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            return Edad <= 40;
        }

        public bool ValidarEstadoFisico()
        {
            double imc = Peso / (Math.Pow(Altura, 2));

            return imc >= 18.5 && imc <= 25;
        }
    }
}
