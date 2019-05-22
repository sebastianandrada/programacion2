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

        public static bool operator ==(Torneo<T> torneo, Equipo equipo){
            return true;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return true;
        }
    }
}
