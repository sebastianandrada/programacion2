using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDeAcceso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada): base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo llamada: {0}\n", CostoLlamada);
            sb.AppendFormat("franja horaria: {0}\n", this.franjaHoraria);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = Duracion * (float)0.66;
                    break;
                default:
                    break;
            }
            return costo;

        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar(Provincial obj)
        {
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
    }
}
