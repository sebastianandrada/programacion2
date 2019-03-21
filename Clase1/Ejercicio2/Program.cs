using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio n° 2";
            string aux = Console.ReadLine();
            int numeroIngresado;
            if (int.TryParse(aux, out numeroIngresado) && numeroIngresado > 0)
            {
                double cuadrado = Math.Pow(numeroIngresado, 2);
                double cubo = Math.Pow(numeroIngresado, 3);
                Console.WriteLine("El cuadrado es {0}", cuadrado);
                Console.WriteLine("El cubo es {0}", cubo);
            } else {
                Console.WriteLine("ERROR. Reingrese numero!");
            }
            Console.ReadKey();
        }
    }
}
