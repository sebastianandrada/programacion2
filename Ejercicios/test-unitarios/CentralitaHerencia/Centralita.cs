using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CentralitaHerencia.Llamada;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0f;
            foreach (Llamada l in Llamadas)
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (l is Local)
                        {
                            Local local = (Local)l;
                            ganancia += local.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Provincial:
                        if (l is Provincial)
                        {
                            Provincial provincial = (Provincial)l;
                            ganancia += provincial.CostoLlamada;
                        }
                        break;
                    case TipoLlamada.Todas:
                        if (l is Local)
                        {
                            Local local = (Local)l;
                            ganancia += local.CostoLlamada;
                        }
                        else if (l is Provincial)
                        {
                            Provincial provincial = (Provincial)l;
                            ganancia += provincial.CostoLlamada;
                        }
                        break;
                }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("razon social: {0}\n", this.razonSocial);
            sb.AppendFormat("ganancia total: ${0}\n", GananciasPorTotal);
            sb.AppendFormat("ganancia por llamadas locales: ${0}\n", GananciasPorLocal);
            sb.AppendFormat("ganancias por llamadas provinciales: ${0}\n", GananciasPorProvincial);

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool contieneLlamada = false;
            foreach(Llamada l in c.Llamadas)
            {
                if(l == llamada)
                {
                    contieneLlamada = true;
                    break;
                }
            }
            return contieneLlamada;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c != nuevaLlamada)
            {
                c.Llamadas.Add(nuevaLlamada);
            } else
            {
                throw new CentralitaException("La llamada ya se encuentra registrada en el sistema", "Centralita", "+");
            }
            return c;
        }
    }
}
