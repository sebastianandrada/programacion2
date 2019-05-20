using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiOtraClase miClaseAux = new MiOtraClase();
                miClaseAux.MiMetodoDeInstancia();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                if(!object.ReferenceEquals(e, null))
                {
                    do
                    {
                        Console.WriteLine(e.Message);
                        e = e.InnerException;
                    } while (!object.ReferenceEquals(e, null));
                }
                Console.ReadKey();
            }
            
        }
    }
}
