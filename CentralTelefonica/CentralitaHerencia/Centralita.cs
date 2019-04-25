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

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0f;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach(Llamada l in Llamadas)
                    {
                        if(l is Local)
                        {
                            Local local = (Local)l;
                            ganancia += local.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada l in Llamadas)
                    {
                        if (l is Provincial)
                        {
                            Provincial provincial = (Provincial)l;
                            ganancia += provincial.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach(Llamada l in Llamadas)
                    {
                        if(l is Local)
                        {
                            Local local = (Local)l;
                            ganancia += local.CostoLlamada;
                        } else if (l is Provincial)
                        {
                            Provincial provincial = (Provincial)l;
                            ganancia += provincial.CostoLlamada;
                        }
                    }
                    break;
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

        }
    }
}
