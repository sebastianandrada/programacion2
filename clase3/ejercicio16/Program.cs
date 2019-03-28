using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Gonzalez", "Juan", 1);
            Alumno alumno2 = new Alumno("Jimenez", "Micaela", 2);
            Alumno alumno3 = new Alumno("Perez", "Florencia", 3);


            alumno1.Estudiar(1, 5);
            alumno2.Estudiar(10,10);
            alumno3.Estudiar(4, 6);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
        }
    }
}
