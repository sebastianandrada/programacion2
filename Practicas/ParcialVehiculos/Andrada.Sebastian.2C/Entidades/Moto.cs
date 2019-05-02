using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        //private Moto() { }

        public Moto(string patente, int cilindrada) :base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) :this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short rueda, int valorHora) :this(patente, cilindrada, rueda)
        {
            this.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Moto de cilindrada {0}", this.cilindrada);
            sb.AppendFormat("rueda: {0}", this.ruedas);
            sb.AppendFormat("patente {0}", Patente);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;
        }

        public override string ImprimirTicket()
        {
            float costoEstadia = 0;
            float horasDeEstadia = (DateTime.Now - ingreso).Ticks;
            costoEstadia = valorHora * horasDeEstadia;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendFormat("Costo de la estadia: ${0}", costoEstadia);
            return sb.ToString();
        }
    }
}
