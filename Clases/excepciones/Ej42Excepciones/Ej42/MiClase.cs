using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MiMetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        public MiClase(int n)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("esta es UnaExcepcion", e);
            }
        }



        public static void MiMetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
