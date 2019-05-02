using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            this.valorHora = 50;
        }

        //private Automovil() { valorHora = 50; }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Automovil);
        }

        public override string ImprimirTicket()
        {
            float costoEstadia = 0;
            float horasDeEstadia = (DateTime.Now - ingreso).Ticks;
            costoEstadia = valorHora * horasDeEstadia; 
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ImprimirTicket());
            sb.AppendFormat("Costo de la estadia: ${0}", costoEstadia);
            return sb.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Automovil");
            sb.AppendFormat("patente {0}", Patente);
            sb.AppendFormat("color: {0}", this.color);
            return sb.ToString();
        }
    }
}
