using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get {
                return this.duracion;
            }   
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada\n");
            sb.AppendFormat("duracion {0}\n", this.duracion);
            sb.AppendFormat("nro destino: {0}, numero origen: {1}\n", this.nroDestino, this.nroOrigen);
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada2.Duracion > llamada1.Duracion)
            {
                retorno = -1;
            }
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
    }
}
