using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado { Ingresado, EnViaje, Entregado}

        public delegate void DelegadoEstado(object sender, EventArgs e);

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public event DelegadoEstado InformaEstado;

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #region "Constructores"
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }
        #endregion

        #region "Metodos"
        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                this.estado = this.estado + 1;
                this.InformaEstado(this, new EventArgs());
            }
            while (this.estado != EEstado.Entregado);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1.TrackingID == p2.TrackingID;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return MostrarDatos((IMostrar<Paquete>) this);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}\n", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }
        #endregion
    }
}
