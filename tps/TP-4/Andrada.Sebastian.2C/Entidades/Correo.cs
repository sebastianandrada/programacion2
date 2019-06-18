using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #region "Constructores"
        public Correo() { }
        #endregion

        #region "Metodos"
        public void FinEntregas()
        {

        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Paquete p in (List<Paquete>)elementos)
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            bool estaEnCorreo = false;
            foreach(Paquete paquete in c.Paquetes)
            {
                if(paquete == p)
                {
                    estaEnCorreo = true;
                    break;
                }
            }
            if (estaEnCorreo)
            {
                throw new TrackingIdRepetidoException("Ya esta en el correo");
            }
            else
            {
                c.Paquetes.Add(p);
            }

            return c;
        }
        #endregion
    }
}
