using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("******Equipo*********\n");
            sb.AppendFormat("equipo: {0}\n", e.Nombre);
            sb.AppendLine("******DT*********\n");
            if (e.directorTecnico != null)
            {
                sb.AppendLine(String.Format("director tecnico: {0}\n", e.directorTecnico.Mostrar()));
            } else
            {
                sb.AppendLine("Sin DT asignado");
            }
            sb.AppendLine("******Jugadores*********\n");
            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine("-----------------------");
                sb.AppendLine(j.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool estaEnJugadores = false;
            foreach (Jugador jug in e.jugadores)
            {
                if (jug.Equals(j))
                {
                    estaEnJugadores = true;
                    break;
                }
            }
            return estaEnJugadores;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud() && j.ValidarEstadoFisico())
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool tieneArquero = false;
            int cantArqueros = 0;
            bool tieneDefensor = false;
            bool tieneDelantero = false;
            bool tieneCentral = false;
            foreach (Jugador j in e.jugadores)
            {
                if (j.Posicion == Posicion.Arquero)
                {
                    tieneArquero = true;
                } else if(j.Posicion == Posicion.Defensor)
                {
                    tieneDefensor = true;
                } else if(j.Posicion == Posicion.Central)
                {
                    tieneCentral = true;
                } else if(j.Posicion == Posicion.Delantero)
                {
                    tieneDelantero = true;
                }
            }
            return e.directorTecnico != null && tieneArquero && cantArqueros == 1 && tieneCentral && tieneDefensor && tieneDelantero && e.jugadores.Count == cantidadMaximaJugadores;
        }

    }
}
