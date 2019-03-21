using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";
            int numeroIngresado;
            int min = int.MaxValue;
            int maximo = int.MinValue;
            int promedio;
            int total = 0;
            Console.WriteLine("Ingrese 5 numeros");
            for(int i = 0; i < 5; i++){
                //if(int.TryParse(Console.ReadLine(), out numeroIngresado))
                string a = Console.ReadLine();
                if(int.TryParse(a, out numeroIngresado)){
                    total += numeroIngresado;
                    if (numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }else if(numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                }
                
            }
            promedio = total / 5;
            Console.WriteLine("el maximo es: {0}", maximo);
            Console.WriteLine("el minimo es: {0}", min);
            Console.WriteLine("el promedio es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
