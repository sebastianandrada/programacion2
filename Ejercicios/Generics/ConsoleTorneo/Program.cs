using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleTorneo
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol;
            Torneo<EquipoBasquet> torneoBasquet;

            EquipoFutbol eqf1 = new EquipoFutbol("equipo 1", DateTime.Now);
            EquipoFutbol eqf2 = new EquipoFutbol("equipo 2", DateTime.Now);
            EquipoFutbol eqf3 = new EquipoFutbol("equipo 3", DateTime.Now);


        }
    }
}
