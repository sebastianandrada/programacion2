using Bilgraf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    /*
 1) la diferencia entre new reserva un espacio en memoria y un constructor define la estructura de datos del objeto
    a reservar en ese espacio , crea la instancia
2) Se llama constructor por defecto a al constructor que existe de forma implicita, aunque no 
    implementemos uno, sin completar atributos
3) Siempre va a existir el constructor por defecto, que no recibe ni completa ningun atributo de la clase
    le da a los atributos un valor por defecto (objetos == null, int == 0, string == "")

4) Un constructor estatico

 */
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            
            string pintura;
            if(boligrafoAzul.Pintar(3, out pintura))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine(pintura);
                
            }
            Console.WriteLine(boligrafoAzul.GetTinta());

            if(boligrafoRojo.Pintar(64, out pintura) == true)
            {
                Console.ForegroundColor = boligrafoRojo.GetColor();
                Console.WriteLine(pintura);
            }
            Console.WriteLine(boligrafoRojo.GetTinta());
            boligrafoRojo.Recargar();
            Console.WriteLine(boligrafoRojo.GetTinta());
            Console.ReadKey();
        }
    }
}
