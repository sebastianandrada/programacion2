using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio n1 = new Negocio("negocio1");
            Cliente cliente1 = new Cliente(1, "cliente1");
            Cliente cliente2 = new Cliente(2, "cliente2");
            Cliente cliente3 = new Cliente(3, "cliente3");

            n1.Cliente = cliente1;
            n1.Cliente = cliente2;
            n1.Cliente = cliente3;

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
