using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private int valorHora;

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            this.valorHora = valorHora;
        }

        //private PickUp() { };

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehiculo pickUp");
            sb.AppendFormat("patente {0}", Patente);
            sb.AppendFormat("modelo {0}", this.modelo);
            return sb.ToString();
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

        public override bool Equals(object obj)
        {
            return obj is PickUp;
        }
    }
}
