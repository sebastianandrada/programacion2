using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej42
{
    public class MiOtraClase
    {
        public void MiMetodoDeInstancia()
        {
            try
            {
                new MiClase(0);
            }
            catch (UnaExcepcion e)
            {
                throw new MiException("esta es MiException de mi otra clase", e);
            }
        }

    }
}
