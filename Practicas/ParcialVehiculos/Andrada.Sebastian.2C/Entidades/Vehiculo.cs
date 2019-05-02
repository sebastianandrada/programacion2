using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Count() == 6)
                {
                    this.patente = value;
                }
            }
        }

        public Vehiculo(string patente)
        {
            Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString());
            sb.AppendFormat("Ingreso: {0}", this.ingreso.ToString());
            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format("Patente {0}", Patente);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
