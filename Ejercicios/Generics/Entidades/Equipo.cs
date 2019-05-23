using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo eq1, Equipo eq2)
        {
            return eq1.nombre == eq2.nombre && eq1.fechaCreacion == eq2.fechaCreacion;
        }

        public static bool operator !=(Equipo eq1, Equipo eq2)
        {
            return !(eq1 == eq2);
        }

        public string Ficha(Equipo equipo)
        {
            return string.Format("{0} fundado el {1}", equipo.nombre, equipo.fechaCreacion);
        }
    }
}
