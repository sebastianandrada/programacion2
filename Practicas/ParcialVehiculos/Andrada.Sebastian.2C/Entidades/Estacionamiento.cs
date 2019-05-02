using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento() {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estacionamiento {0}", e.nombre);
            sb.AppendFormat("espacio disponible ", e.espacioDisponible);
            sb.AppendFormat("********Hay {0} Vehiculos ************", e.vehiculos.Count);
            foreach(Vehiculo v in e.vehiculos)
            {
                sb.AppendLine(v.ConsultarDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool estaEnLista = false;
            foreach(Vehiculo v in estacionamiento.vehiculos)
            {
                if (v == vehiculo)
                {
                    estaEnLista = true;
                    break;
                }
            }
            return estaEnLista;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }


    }
}
