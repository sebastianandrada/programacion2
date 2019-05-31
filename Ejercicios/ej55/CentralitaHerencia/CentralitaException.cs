using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get;
        }

        public string NombreMetodo
        {
            get;
        }

        public CentralitaException(string mensaje, string clase, string metodo) : base(string.Format("{0}, clase: {1}, metodo {2}", mensaje, clase, metodo))
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException): base(string.Format("{0}, clase: {1}, metodo {2}", mensaje, clase, metodo), innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
