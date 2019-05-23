using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        /*public string JugarPartido
        {
            get
            {
                Random r = new Random();
                index r.Next(0, this.equipos.Count);
                T eq1 = 
                string retorno  = CalcularPartido<T>(this.equipos.)
            }
        }*/

        public static bool operator ==(Torneo<T> torneo, Equipo equipo){
            bool estaEnTorneo = false;
            foreach(Equipo e in torneo.equipos)
            {
                if(e == equipo)
                {
                    estaEnTorneo = true;
                    break;
                }
            }
            return estaEnTorneo;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(!(torneo == equipo))
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Equipo {0}", this.nombre);
            sb.AppendLine("*****Equipos****");
            foreach(Equipo e in this.equipos)
            {
                //sb.Append(e.Mostrar());
            }
            return sb.ToString();
        }

        public string CalcularPartido<T>(T equipo1, T equipo2) where T  : Equipo
        {
            Random r = new Random();
            int rdoEquipo1 = r.Next();
            int rdoEquipo2 = r.Next();

            return "";
            //return string.Format("{0} {1} - {2} {3}", equipo1., rdoEquipo1, rdoEquipo2, equipo2.nombre);
        }
    }
}
