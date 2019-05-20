using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**********************");
            sb.AppendFormat("Auto numero: {0}\n", this.numero);
            sb.AppendFormat("escuderia: {0}\n", this.escuderia);
            sb.AppendFormat("cantidad de combustible: {0} litros\n", this.cantidadCombustible);
            sb.AppendFormat("esta en competencia?: {0}\n", this.enCompetencia);
            sb.AppendFormat("cantidad de vueltas restantes: {0}\n", this.vueltasRestantes);
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.escuderia == a2.escuderia && a1.numero == a2.numero;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public void setCantidadCombustible(short cant)
        {
            this.cantidadCombustible = cant;
        }

        public short getCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void setEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public bool getEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void setVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public short getVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
    }
}
