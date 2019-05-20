using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores): this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("COMPETENCIA!!");
            sb.AppendFormat("Cantidad de vueltas: {0}\n", this.cantidadVueltas);
            sb.AppendFormat("Cantidad de competidores: {0}\n", this.cantidadCompetidores);
            foreach(AutoF1 autoF1 in this.competidores)
            {
                sb.AppendLine(autoF1.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if(c.cantidadCompetidores <= c.competidores.Count && c != a)
            {
                a.setEnCompetencia(true);
                a.setVueltasRestantes(c.cantidadVueltas);
                Random random = new Random();
                a.setCantidadCombustible((short)random.Next(15, 100));
                c.competidores.Add(a);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if(c == a)
            {
                retorno = c.competidores.Remove(a);
                a.setEnCompetencia(false);
                c.cantidadCompetidores--;
            }
            return retorno;
        }

        /// <summary>
        /// Retorna true si el competidor forma parte de la competencia
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool estaEnCompetencia = false;
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    estaEnCompetencia = true;
                    break;
                }
            }
            return estaEnCompetencia;
        }

        /// <summary>
        /// Retorna false si el competidor forma parte de la competencia
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
