using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
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
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }
        #endregion

        #region "Metodos"
        public void FinEntregas()
        {
            foreach(Thread mocked in this.mockPaquetes)
            {
                if (mocked.IsAlive)
                {
                    mocked.Abort();
                }
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> paquetes = ((Correo)elementos).paquetes;
            StringBuilder sb = new StringBuilder();
            foreach(Paquete p in paquetes)
            {
                sb.AppendFormat("{0} para {1} ({2})\n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }
            return sb.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach(Paquete paquete in c.Paquetes)
            {
                if(paquete == p)
                {
                    throw new TrackingIdRepetidoException(String.Format("El tracking ID {0} ya esta en la lista de envios.", p.TrackingID));
                }
            }
            c.Paquetes.Add(p);
            Thread thread = new Thread(new ThreadStart(p.MockCicloDeVida));
            thread.Start();
            c.mockPaquetes.Add(thread);
            return c;
        }
        #endregion
    }
}
