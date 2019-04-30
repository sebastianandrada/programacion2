using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero");
            string aux = Console.ReadLine();
            if (int.TryParse(aux, out numeroIngresado)) {
                Console.WriteLine("Calculando primos");
                do
                {
                    if (esPrimo(num)){
                        Console.WriteLine(num);
                    }
                    num++;
                } while (num != numeroIngresado);
                Console.ReadKey();
            }
            
        }

        private static bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while(divisor < numero) {
                resto = numero % divisor;
                if(resto == 0)
                {
                    return false;
                }
                divisor++;
            }
            return true;
            /*bool esPrimo = true;
            for(int i = 1; i<num; i++){
                if(num % i != 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            return esPrimo;*/
        }
    }
}
