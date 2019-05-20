using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(20, 5);
            AutoF1 a1 = new AutoF1(1, "Volvo");
            AutoF1 a2 = new AutoF1(2, "Mercedes");
            AutoF1 a3 = new AutoF1(3, "Ferrari");
            AutoF1 a4 = new AutoF1(4, "Mazeratti");
            AutoF1 a5 = new AutoF1(5, "Renault");

            if(!(c + a1 && c + a2 && c + a3 && c + a4 && c + a5))
            {
                Console.WriteLine(c.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
