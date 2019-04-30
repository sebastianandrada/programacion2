using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "si";
            do
            {
                Console.WriteLine("Ingrese un numero");
                string aux;
                int num1;
                int num2;
                string operador;
                int resultado;

                aux = Console.ReadLine();
                num1 = int.Parse(aux);
                Console.WriteLine("Ingrese otro numero");
                aux = Console.ReadLine();
                num2 = int.Parse(aux);
                Console.WriteLine("Ingrese un operador (+, -, /, *)");
                aux = Console.ReadLine();
                operador = aux;

                resultado = Calculadora.Calcular(num1, num2, operador);

                Console.WriteLine("{0} {1} {2} = {3}", num1, operador, num2, resultado);
                Console.WriteLine("desea continuar? (si/no)");
                continuar = Console.ReadLine();
                
            } while (continuar=="si");
            Console.ReadKey();
        }
    }
    
}
