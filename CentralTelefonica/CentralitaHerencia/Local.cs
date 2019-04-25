using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public Local(string nroDestino, float duracion, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo): base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return this.costo * duracion;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("costo de la llamada: {0}\n", CostoLlamada.ToString());
            return sb.ToString();
        }

    }
}
